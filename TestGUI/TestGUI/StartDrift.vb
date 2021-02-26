Public Class StartDrift
    Dim myButtons As List(Of Button) = New List(Of Button)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        myButtons.Add(Button1)
        myButtons.Add(Button2)
        myButtons.Add(Button8)


        ' Add any initialization after the InitializeComponent() call.
        For Each btn As Button In myButtons
            AddHandler btn.Click, AddressOf myButtonClick 'Add your eventhandlers
        Next

    End Sub
    Public Sub myButtonClick(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        If btn.BackColor = Color.Black Then
            btn.BackColor = Color.Blue
            For Each b As Button In myButtons
                If b IsNot btn And b.BackColor = Color.Blue Then
                    b.BackColor = Color.Black
                End If
            Next
        Else
            btn.BackColor = Color.Black
        End If
        'Do what ever you need to do to the calling control
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.FindForm().Close()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        FishEntry.Show()
        Me.FindForm().Close()
        DriftEntry.Close()
    End Sub
End Class