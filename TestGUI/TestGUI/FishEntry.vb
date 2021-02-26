
Public Class FishEntry
    Dim myButtons As List(Of Button) = New List(Of Button)
    Dim fishButtons As List(Of Button) = New List(Of Button)
    Dim stationButtons As List(Of Button) = New List(Of Button)
    Dim condButtons As List(Of Button) = New List(Of Button)

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        myButtons.Add(ButtonFishBlue)
        myButtons.Add(ButtonFishGopher)
        myButtons.Add(ButtonFishOlive)
        myButtons.Add(ButtonFishVerm)
        myButtons.Add(ButtonFishLingcod)
        myButtons.Add(ButtonStation1)
        myButtons.Add(ButtonStation2)
        myButtons.Add(ButtonStation3)
        myButtons.Add(ButtonStation4)
        myButtons.Add(ButtonStation6)
        myButtons.Add(ButtonStation7)
        myButtons.Add(ButtonStation8)
        myButtons.Add(ButtonStation9)
        myButtons.Add(ButtonStation11)
        myButtons.Add(ButtonStation12)
        myButtons.Add(ButtonNoCond)
        myButtons.Add(ButtonCondCry)
        myButtons.Add(ButtonCondVen)
        myButtons.Add(ButtonCondFlo)
        myButtons.Add(ButtonCondMam)
        myButtons.Add(ButtonCondHoo)
        myButtons.Add(ButtonCondRel)
        myButtons.Add(ButtonCondMor1)
        myButtons.Add(ButtonCondMor2)
        myButtons.Add(ButtonRetained)
        myButtons.Add(ButtonRecaptured)
        myButtons.Add(ButtonComAP)
        myButtons.Add(ButtonComSIM)
        myButtons.Add(ButtonComBE)

        fishButtons.Add(ButtonFishBlue)
        fishButtons.Add(ButtonFishGopher)
        fishButtons.Add(ButtonFishOlive)
        fishButtons.Add(ButtonFishVerm)
        fishButtons.Add(ButtonFishLingcod)

        stationButtons.Add(ButtonStation1)
        stationButtons.Add(ButtonStation2)
        stationButtons.Add(ButtonStation3)
        stationButtons.Add(ButtonStation4)
        stationButtons.Add(ButtonStation6)
        stationButtons.Add(ButtonStation7)
        stationButtons.Add(ButtonStation8)
        stationButtons.Add(ButtonStation9)
        stationButtons.Add(ButtonStation11)
        stationButtons.Add(ButtonStation12)

        condButtons.Add(ButtonNoCond)
        condButtons.Add(ButtonCondCry)
        condButtons.Add(ButtonCondVen)
        condButtons.Add(ButtonCondFlo)
        condButtons.Add(ButtonCondMam)
        condButtons.Add(ButtonCondHoo)
        condButtons.Add(ButtonCondRel)
        condButtons.Add(ButtonCondMor1)
        condButtons.Add(ButtonCondMor2)

        For Each btn As Button In myButtons
            AddHandler btn.Click, AddressOf myButtonClick 'Add your eventhandlers
            btn.BackColor = Color.Black
        Next

    End Sub

    Public Sub myButtonClick(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        If btn.BackColor = Color.Black Then
            btn.BackColor = Color.Blue
            CheckButtons(btn)
        Else
            btn.BackColor = Color.Black
        End If
        'Do what ever you need to do to the calling control
    End Sub

    Private Sub PushDatabase()
        Dim dataArray As ArrayList = New ArrayList()
        Dim columnArray As ArrayList = New ArrayList()
        Dim username As String = System.Environment.UserName
        Dim accessdb As AccessDB = New AccessDB("C:\Users\" + username + "\Documents\fisheries.accdb", "CaughtFishes")
        Dim comments As String = ""

        If ButtonRetained.BackColor = Color.Blue Then
            dataArray.Add(True)
            columnArray.Add("Retained")
        End If
        If ButtonRecaptured.BackColor = Color.Blue Then
            dataArray.Add(True)
            columnArray.Add("Recapture")
        End If
        If TextBoxLen.Text.Length > 0 Then
            dataArray.Add(TextBoxLen.Text)
            columnArray.Add("Length")
        End If
        If TextBoxTag.Text.Length > 0 Then
            dataArray.Add(TextBoxTag.Text)
            columnArray.Add("TagID")
        End If
        If (ButtonComBE.BackColor = Color.Blue) Then
            comments += ButtonComBE.Text + " "
        End If
        If (ButtonComAP.BackColor = Color.Blue) Then
            comments += ButtonComAP.Text + " "
        End If
        If (ButtonComSIM.BackColor = Color.Blue) Then
            comments += ButtonComSIM.Text + " "
        End If
        'comments += TextBoxCom.Text
        If comments.Length > 0 Then
            dataArray.Add(comments)
            columnArray.Add("Comments")
        End If


        For Each btn As Button In fishButtons
            If btn.BackColor = Color.Blue Then
                If btn.Name = "ButtonFishBlue" Then
                    dataArray.Add("BLU")
                    columnArray.Add("SpeciesCode")

                ElseIf btn.Name = "ButtonFishGopher" Then
                    dataArray.Add("GPR")
                    columnArray.Add("SpeciesCode")

                ElseIf btn.Name = "ButtonFishOlive" Then
                    dataArray.Add("OLV")
                    columnArray.Add("SpeciesCode")

                ElseIf btn.Name = "ButtonFishVerm" Then
                    dataArray.Add("VER")
                    columnArray.Add("SpeciesCode")

                ElseIf btn.Name = "ButtonFishLingcod" Then
                    dataArray.Add("LCD")
                    columnArray.Add("SpeciesCode")
                Else
                    'If ComboBoxOther.Text.Length > 0 Then
                    'dataArray.Add(ComboBoxOther.Text)
                    'columnArray.Add("SpeciesCode")
                    'End If

                End If
            End If

        Next
        For Each btn As Button In stationButtons
            If btn.BackColor = Color.Blue Then
                dataArray.Add(btn.Text)
                columnArray.Add("StationNumber")
            End If
        Next
        For Each btn As Button In condButtons
            If btn.BackColor = Color.Blue Then
                If btn.Name = "ButtonNoCond" Then
                    dataArray.Add(True)
                    columnArray.Add("Condition0")
                End If
                If btn.Name = "ButtonCondCry" Then
                    dataArray.Add(True)
                    columnArray.Add("Condition1")
                End If
                If btn.Name = "ButtonCondVen" Then
                    dataArray.Add(True)
                    columnArray.Add("Condition2")
                End If
                If btn.Name = "ButtonCondMam" Then
                    dataArray.Add(True)
                    columnArray.Add("Condition3")
                End If
                If btn.Name = "ButtonCondHoo" Then
                    dataArray.Add(True)
                    columnArray.Add("Condition4")
                End If
                If btn.Name = "ButtonCondRel" Then
                    dataArray.Add(True)
                    columnArray.Add("Condition5")
                End If
                If btn.Name = "ButtonCondFlo" Then
                    dataArray.Add(True)
                    columnArray.Add("Condition6")
                End If
                If btn.Name = "ButtonCondMor1" Then
                    dataArray.Add(True)
                    columnArray.Add("Condition7")
                End If
                If btn.Name = "ButtonCondMor2" Then
                    dataArray.Add(True)
                    columnArray.Add("Condition8")
                End If

            End If
        Next
        If dataArray.Count > 0 Then
            accessdb.addNewRow(dataArray, columnArray)
        End If

    End Sub

    Private Sub CheckButtons(sender As Object) 'Checks all buttons that belong to the same section
        Dim btn As Button = DirectCast(sender, Button)
        If fishButtons.Contains(btn) Then 'Change current option
            For Each b As Button In fishButtons
                If btn IsNot b And b.BackColor = Color.Blue Then
                    b.BackColor = Color.Black
                End If
            Next
            ComboBoxOther.Text = ""
        ElseIf stationButtons.Contains(btn) Then
            For Each b As Button In stationButtons
                If btn IsNot b And b.BackColor = Color.Blue Then
                    b.BackColor = Color.Black
                End If
            Next
        ElseIf condButtons.Contains(btn) Then
            If btn Is ButtonNoCond Then
                For Each b As Button In condButtons
                    If btn IsNot b And b.BackColor = Color.Blue Then
                        b.BackColor = Color.Black
                    End If
                Next
            ElseIf ButtonNoCond.BackColor = Color.Blue Then
                ButtonNoCond.BackColor = Color.Black
            End If
        ElseIf btn Is ButtonRecaptured Then
            If ButtonRetained.BackColor = Color.Blue Then
                ButtonRetained.BackColor = Color.Black
            End If
        ElseIf btn Is ButtonRetained Then
            If ButtonRecaptured.BackColor = Color.Blue Then
                ButtonRecaptured.BackColor = Color.Black
            End If

        End If
    End Sub

    Private Sub ButtonNew_Click(sender As Object, e As EventArgs) Handles ButtonNew.Click
        DriftEntry.Show()
    End Sub
    Private Sub ButtonStart_Click(sender As Object, e As EventArgs)
        StartDrift.Show()
    End Sub
    Private Sub ButtonEnd_Click(sender As Object, e As EventArgs) Handles ButtonEnd.Click
        EndDrift.Show()
    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        PushDatabase()
        For Each btn As Button In myButtons
            btn.BackColor = Color.Black
        Next
        ComboBoxOther.Text = ""
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBoxLen.Click, TextBoxTag.Click
        FormNumPad.openNumpad(DirectCast(sender, TextBox))
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxOther.SelectionChangeCommitted
        For Each b As Button In fishButtons
            If b.BackColor = Color.Blue Then
                b.BackColor = Color.Black
            End If
        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ButtonCondRel.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub FishEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PrototypeDataSet2.test' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'PrototypeDataSet1.test' table. You can move, or remove it, as needed.
        'Me.TestTableAdapter.Fill(Me.PrototypeDataSet1.test)
        'TODO: This line of code loads data into the 'PrototypeDataSet1._4_Caught_Fishes' table. You can move, or remove it, as needed.
        'Me.CaughtFishesTableAdapter.Fill(Me.PrototypeDataSet1._4_Caught_Fishes)
    End Sub

End Class