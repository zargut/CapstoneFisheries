Public Class TripEntry
    Private myButtons As List(Of Button) = New List(Of Button)
    Private siteButtons As List(Of Button) = New List(Of Button)
    Private areaButtons As List(Of Button) = New List(Of Button)
    Private vesselButtons As List(Of Button) = New List(Of Button)

    Private siteStr As String = "Site"
    Private vesselStr As String = "Vessel"
    Private areaStr As String = "area"
    Private recStr As String = "recorder"
    Private numAngStr As String = "num_anglers"
    Private username As String = System.Environment.UserName
    Private DBPATH As String = "C:\Users\" & username & "\Documents\fisheries.accdb"
    Private TABLENAME As String = "trip_info"
    Public numAnglr As String = "0"
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        myButtons.Add(ButtonSiteMPA)
        myButtons.Add(ButtonVesRit)
        myButtons.Add(ButtonSiteREF)
        myButtons.Add(ButtonAreaAN)
        myButtons.Add(ButtonAreaBL)
        myButtons.Add(ButtonAreaPB)
        myButtons.Add(ButtonAreaPL)
        myButtons.Add(ButtonVesAve)
        myButtons.Add(ButtonVesFie)
        myButtons.Add(ButtonVesPho)
        myButtons.Add(ButtonVesEnd)
        myButtons.Add(ButtonVesPat)


        siteButtons.Add(ButtonSiteMPA)
        siteButtons.Add(ButtonSiteREF)

        areaButtons.Add(ButtonAreaAN)
        areaButtons.Add(ButtonAreaBL)
        areaButtons.Add(ButtonAreaPB)
        areaButtons.Add(ButtonAreaPL)

        vesselButtons.Add(ButtonVesRit)
        vesselButtons.Add(ButtonVesAve)
        vesselButtons.Add(ButtonVesFie)
        vesselButtons.Add(ButtonVesPho)
        vesselButtons.Add(ButtonVesEnd)
        vesselButtons.Add(ButtonVesPat)

        ButtonStart.BackColor = Color.Gray
        ButtonStart.Enabled = False
        TextBoxAngler.Text = numAnglr

        For Each btn As Button In myButtons
            AddHandler btn.Click, AddressOf myButtonClick 'Add your eventhandlers
            btn.BackColor = Color.Black                   'Fixes double click issue!
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
    Private Sub CheckButtons(sender As Object) 'Checks all buttons that belong to the same section
        Static checkedSite = False
        Static checkedArea = False
        Static checkedVessel = False
        Dim btn As Button = DirectCast(sender, Button)
        If siteButtons.Contains(btn) Then 'Change current option
            checkedSite = True
            For Each b As Button In siteButtons
                If btn IsNot b And b.BackColor = Color.Blue Then
                    b.BackColor = Color.Black
                End If
            Next
        ElseIf areaButtons.Contains(btn) Then
            checkedArea = True
            For Each b As Button In areaButtons
                If btn IsNot b And b.BackColor = Color.Blue Then
                    b.BackColor = Color.Black
                End If
            Next
        ElseIf vesselButtons.Contains(btn) Then
            checkedVessel = True
            For Each b As Button In vesselButtons
                If btn IsNot b And b.BackColor = Color.Blue Then
                    b.BackColor = Color.Black
                End If
            Next
        End If

        If checkedSite And checkedArea And checkedVessel Then
            ButtonStart.BackColor = Color.Green
            ButtonStart.Enabled = True
        End If
    End Sub

    Private Sub TextBoxAnglers(sender As Object, e As EventArgs) Handles TextBoxAngler.Click
        FormNumPad.openNumpad(DirectCast(sender, TextBox))
    End Sub
    Private Sub ButtonDrift(sender As Object, e As EventArgs) Handles ButtonStart.Click
        ' Set up database fields
        Dim fieldsArr As ArrayList = New ArrayList()
        Dim valuesArr As ArrayList = New ArrayList()

        ' Flags for null checking
        Dim foundSite = False
        Dim foundVessel = False
        Dim foundArea = False
        Dim foundRec = False
        Dim foundNumAng = False
        Dim flags(5) As Boolean


        ' Check buttons and text boxes, add their info to values array
        For Each btn As Button In siteButtons
            If btn.BackColor = Color.Blue Then
                foundSite = True
                valuesArr.Add(btn.Text.Replace(" ", "_"))
            End If
        Next

        For Each btn As Button In vesselButtons
            If btn.BackColor = Color.Blue Then
                foundVessel = True
                valuesArr.Add(btn.Text.Replace(" ", "_"))
            End If
        Next

        For Each btn As Button In areaButtons
            If btn.BackColor = Color.Blue Then
                foundArea = True
                valuesArr.Add(btn.Text.Replace(" ", "_"))
            End If
        Next

        If TextBoxRecord.Text IsNot "" Then
            foundRec = True
            valuesArr.Add(TextBoxRecord.Text)
        End If

        If TextBoxAngler.Text IsNot "" Then
            foundNumAng = True
            valuesArr.Add(TextBoxAngler.Text)
        End If

        ' Build fieldsArr based on found values
        If foundSite = True Then
            fieldsArr.Add(siteStr)
        End If
        If foundVessel = True Then
            fieldsArr.Add(vesselStr)
        End If
        If foundArea = True Then
            fieldsArr.Add(areaStr)
        End If
        If foundRec = True Then
            fieldsArr.Add(recStr)
        End If
        If foundNumAng = True Then
            fieldsArr.Add(numAngStr)
        End If

        ' Add to the DB if theres anything to add
        If valuesArr.Count > 0 Then
            Dim db As AccessDB = New AccessDB(DBPATH, TABLENAME)
            db.addNewRow(valuesArr, fieldsArr)
        End If
        numAnglr = TextBoxAngler.Text

        DriftEntry.Show()
        Me.FindForm().Close()
    End Sub
    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.FindForm().Close()
    End Sub

    Private Sub TextBoxAngler_TextChanged(sender As Object, e As EventArgs) Handles TextBoxAngler.TextChanged

    End Sub
End Class