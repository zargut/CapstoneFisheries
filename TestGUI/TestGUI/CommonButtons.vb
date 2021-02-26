Public Class CommonButtons

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'ButtonSave.BackColor = Color.Green
        'ButtonCancel.BackColor = Color.Red

    End Sub
    Private Sub CommonButtons_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CommonButtons_Click(sender As Object, e As MouseEventArgs) Handles Me.Click

    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Me.FindForm().Close()
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.FindForm().Close()
    End Sub
End Class
