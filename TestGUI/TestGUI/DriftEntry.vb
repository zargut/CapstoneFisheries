Public Class DriftEntry
    Private myButtons As List(Of Button) = New List(Of Button)
    Private siteButtons As List(Of Button) = New List(Of Button)
    Private areaButtons As List(Of Button) = New List(Of Button)
    Private cloudButtons As List(Of Button) = New List(Of Button)
    Private vesselButtons As List(Of Button) = New List(Of Button)

    Private username As String = System.Environment.UserName
    Private DBPATH As String = "C:\Users\" & username & "\Documents\fisheries.accdb"
    Private TABLENAME As String = "drift_info"



    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        myButtons.Add(ButtonCloud0)
        myButtons.Add(ButtonCloud3)
        myButtons.Add(ButtonCloud2)
        myButtons.Add(ButtonCloud1)
        cloudButtons.Add(ButtonCloud0)
        cloudButtons.Add(ButtonCloud3)
        cloudButtons.Add(ButtonCloud2)
        cloudButtons.Add(ButtonCloud1)
        TextBoxAnglers.Text = TripEntry.numAnglr

        ButtonStart.Enabled = False
        ButtonStart.BackColor = Color.Gray
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
    Private Sub CheckButtons(sender As Object) 'Checks all buttons that belong to the same section
        Static isChecked = False
        Dim btn As Button = DirectCast(sender, Button)
        If cloudButtons.Contains(btn) Then
            isChecked = True
            For Each b As Button In cloudButtons
                If btn IsNot b And b.BackColor = Color.Blue Then
                    b.BackColor = Color.Black
                End If
            Next
        End If
        If isChecked Then
            ButtonStart.Enabled = True
            ButtonStart.BackColor = Color.Green
        End If
    End Sub
    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBoxDrift.Click
        FormNumPad.openNumpad(DirectCast(sender, TextBox))
    End Sub
    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBoxAnglers.Click
        FormNumPad.openNumpad(DirectCast(sender, TextBox))
    End Sub

    Private Sub TextBox3_Click(sender As Object, e As EventArgs) Handles TextBoxGrid.Click
        FormNumPad.openNumpad(DirectCast(sender, TextBox))
    End Sub

    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        Dim db As AccessDB = New AccessDB(DBPATH, TABLENAME)
        Dim values As ArrayList = New ArrayList()
        Dim fields As ArrayList = New ArrayList()

        Dim cloudStr = "cloud_cover"
        Dim windStr = "wind_speed_direction"
        Dim swellStr = "swell_height_direction"
        Dim gridStr = "gridNum"
        Dim driftStr = "driftNum"
        Dim angStr = "anglerNum"
        Dim tagStr = "tag_crew"
        Dim weightStr = "weights_bars"

        For Each btn As Button In cloudButtons
            If btn.BackColor = Color.Blue Then
                values.Add(btn.Text)
                fields.Add(cloudStr)
            End If
        Next

        If TextBoxWind.Text IsNot "" Then
            values.Add(TextBoxWind.Text)
            fields.Add(windStr)
        End If
        If TextBoxSwell.Text IsNot "" Then
            values.Add(TextBoxSwell.Text)
            fields.Add(swellStr)
        End If
        If TextBoxGrid.Text IsNot "" Then
            values.Add(TextBoxGrid.Text)
            fields.Add(gridStr)
        End If
        If TextBoxDrift.Text IsNot "" Then
            values.Add(TextBoxDrift.Text)
            fields.Add(driftStr)
        End If
        If TextBoxAnglers.Text IsNot "" Then
            values.Add(TextBoxAnglers.Text)
            fields.Add(angStr)
        End If
        If TextBoxWeight.Text IsNot "" Then
            values.Add(TextBoxWeight.Text)
            fields.Add(weightStr)
        End If



        If values.Count > 0 Then
            db.addNewRow(values, fields)
        End If

        FishEntry.Show()
        TripEntry.Close()
    End Sub
    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.FindForm().Close()
        TripEntry.Show()
    End Sub

    Private Sub ButtonEnd_Click(sender As Object, e As EventArgs) Handles ButtonEnd.Click
        Me.FindForm().Close()

    End Sub

End Class
