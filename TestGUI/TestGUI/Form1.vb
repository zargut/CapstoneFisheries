Public Class Form1
    Dim myButtons As List(Of Button) = New List(Of Button)
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        myButtons.Add(Button1)
        myButtons.Add(Button2)
        For Each btn As Button In myButtons
            AddHandler btn.Click, AddressOf myButtonClick 'Add your eventhandlers
        Next

    End Sub

    Public Sub myButtonClick(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        If btn.BackColor = Color.Black Then
            btn.BackColor = Color.Blue
        Else
            btn.BackColor = Color.Black
        End If
        'Do what ever you need to do to the calling control
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        FormNumPad.Show()
    End Sub

    Private Sub openNumPad(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormNumPad.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
