' This class is designed to create an object that allows devs
' to easily get and add data to a MS Access Database.
' Create one object per Access Table
'
' In order for this to work, the user should install 
' 32 bit MS Access and the latest 32 bit MS Access Database engine
' 64 bit works, just don't mix and match. 
' Dont install different versions of the Database engine,
' it can cause funky problems.
'
'
' Constructor(databaseFilePath, providerString)
' providerString defaults to ACE.OleDb1b.12.0 if not entered,
' that should work for access files 2007-Present
'
'
' me.readEntireDB()
' Reads entire database and returns as an Array list full
' of Array lists. The outer array represents the current row,
' the inner array represents which column in the row you are at.
'
'
' me.addNewRow(values, Optional fields)
' The paramater values should be an Array list.
' The parameter fields is optional, and should be and Array list
' if supplied. There are 2 ways to use this function:
'   1.) You supply the fields parameter.
'       If you do this, fields should contain
'       the names of each of the columns you 
'       want to fill as strings. They can be
'       in any order, and you do not have to supply
'       every column, only the ones you want to fill.
'       The skipped columns will autofill with no value.
'       The values array should contain the values of
'       each column, in the same order as the column array.
'       I can switch this to a dictionary if it's easier.
'
'   2.) You dont supply the fields parameter.
'       If you do this, the values array should
'       be filled with each value you want in the 
'       corresponding column. The array should be
'       filled in the order of the columns on the
'       corresponding table.
'
'
'
' Uses the SQL Command:
' INSERT INTO table_name (column1, column2, column3, ...) VALUES (value1, value2, value3, ...);

'
' TODO: Error Handling
' TODO: Input Sanitation
'



'The database engine used
Imports System.Data.OleDb
Public Class AccessDB

    Private connString As String = ""
    Private conn As OleDbConnection
    Private tableName As String = ""

    'Some Useful SQL Commands
    'Some of these get set in the constructor
    Private readAll_sql As String               ' Get all contents of db
    Private addNewRow_sql As String             ' Create a new row in the db, specify fields to fill
    Private getRowID_sql As String


    'This is the constructor. It takes a filepath, table name, and optionally the provider string. 
    'If provider is not supplied, it defaults to Microsoft.ACE.OLEDB.12.0
    'Potentially change the provider for different versions of access
    Public Sub New(ByVal filepath As String, ByVal u_tableName As String, Optional ByVal provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;")
        connString = provider & "Data Source=" & filepath
        conn = New OleDbConnection(connString)
        tableName = u_tableName
        setSqlStrings()
    End Sub


    ' Just sets the private global sql command strings above
    Private Sub setSqlStrings()
        readAll_sql = "Select * FROM " & tableName
        addNewRow_sql = "Insert Into " & tableName & " "
        getRowID_sql = "Select * From " & tableName & "WHERE "
    End Sub

    Public Function testConnection() As Boolean
        Try
            conn.Open()
        Catch ex As Exception
            conn.Close()
            Return False
        End Try

        conn.Close()
        Return True
    End Function

    ' Reads entire database and returns as an Array list full
    ' of Array lists. The outer array represents the current row,
    ' the inner array represents which column in the row you are at.
    Public Function readEntireDB() As ArrayList
        Dim table As ArrayList = New ArrayList()
        Dim dbCmd As OleDbCommand = New OleDbCommand(readAll_sql, conn)
        Dim dbReader As OleDbDataReader
        Dim rowSize As Integer
        Dim row As ArrayList

        conn.Open()
        Try
            dbReader = dbCmd.ExecuteReader()
        Catch
            MsgBox("Could not find the table")
            Return Nothing
        End Try

        rowSize = dbReader.FieldCount() - 1
        While dbReader.Read() = True
            row = New ArrayList(rowSize)
            For index As Integer = 0 To rowSize
                row.Add(dbReader(index))
            Next
            table.Add(row)
        End While

        dbReader.Close()
        conn.Close()
        Return table
    End Function

    Public Function addNewRow(ByVal values As ArrayList, Optional ByVal fields As ArrayList = Nothing) As Boolean
        Dim fieldsStr As String = ""
        Dim finalCmdStr As String = ""
        Dim valuesStr As String = ""
        Dim valueLen As Integer = values.Count - 1
        Dim fieldLen As Integer
        Dim numRowsAdded As Integer = 0

        ' Just sets fieldLen based on whether fields
        ' was supplied or not.
        If fields Is Nothing Then
            fieldLen = 0
        Else
            fieldLen = fields.Count - 1
        End If

        ' If fields array is supplied, create the string for it
        If fields IsNot Nothing Then
            fieldsStr = "("
            For index As Integer = 0 To fieldLen
                fieldsStr &= fields(index).ToString()
                If (index + 1) <= fieldLen Then
                    fieldsStr &= ", "
                End If
            Next
            fieldsStr &= ")"
        End If

        ' Create SQL String for values
        valuesStr = "("
        For index As Integer = 0 To valueLen
            valuesStr &= "'" & values(index).ToString & "'"
            If (index + 1) <= valueLen Then
                valuesStr &= ", "
            End If
        Next
        valuesStr &= ")"

        ' Finalize SQL command string
        If fieldsStr = "" Then
            finalCmdStr = addNewRow_sql & "Values " & valuesStr
        Else
            finalCmdStr = addNewRow_sql & fieldsStr & " Values " & valuesStr
        End If

        ' System.Diagnostics.Debug.WriteLine(finalCmdStr)
        ' Send the SQL command
        Dim connCmd As OleDbCommand = New OleDbCommand(finalCmdStr, conn)
        System.Diagnostics.Debug.WriteLine(finalCmdStr)
        conn.Open()

        Try
            numRowsAdded = connCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Issue with table name or row data")
            System.Diagnostics.Debug.WriteLine(ex)
            conn.close()
            Return False
        End Try

        conn.Close()

        ' Check that it's right.
        If (numRowsAdded = fieldLen + 1) Or (numRowsAdded = 1 And fields Is Nothing) Then
            Return True
        Else
            Return False
        End If
    End Function


    Public Function getRowByID(ByVal idColum As String, ByVal id As Object)
        Dim cmdStr As String
        Dim dbReader As OleDbDataReader
        Dim rowSize As Integer
        Dim row As ArrayList
        Dim table As ArrayList = New ArrayList()
        conn.Open()

        'Check if ID is string or Int
        If id Is GetType(String) Then
            cmdStr = getRowID_sql & idColum & "='" & DirectCast(id, String) & "'"
        Else
            cmdStr = getRowID_sql & idColum & "=" & DirectCast(id, Integer)
        End If

        Dim dbCmd As OleDbCommand = New OleDbCommand(cmdStr, conn)

        Try
            dbReader = dbCmd.ExecuteReader()
        Catch
            MsgBox("Could not find the table")
            conn.Close()

            Return Nothing
        End Try

        rowSize = dbReader.FieldCount() - 1
        While dbReader.Read() = True
            row = New ArrayList(rowSize)
            For index As Integer = 0 To rowSize
                row.Add(dbReader(index))
            Next
            table.Add(row)
        End While

        dbReader.Close()
        conn.Close()
        Return table

    End Function

End Class