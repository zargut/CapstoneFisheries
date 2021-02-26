Imports Microsoft.VisualBasic
Public Class FormNumPad
    Dim myButtons As List(Of Button) = New List(Of Button)
    Dim curTxt As TextBox
    Dim newTxt As TextBox
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        myButtons.Add(Button1)
        myButtons.Add(Button2)
        myButtons.Add(Button3)
        myButtons.Add(Button4)
        myButtons.Add(Button5)
        myButtons.Add(Button6)
        myButtons.Add(Button7)
        myButtons.Add(Button8)
        myButtons.Add(Button9)
        myButtons.Add(Button0)
        myButtons.Add(ButtonClear)
        myButtons.Add(ButtonBack)
        myButtons.Add(ButtonCancel)
        myButtons.Add(ButtonOK)
        For Each btn As Button In myButtons
            AddHandler btn.Click, AddressOf padButtonClick 'Add your eventhandlers
        Next

        'ButtonSave.BackColor = Color.Green
        'ButtonCancel.BackColor = Color.Red
        'ButtonBack.BackColor = Color.LightYellow
        'ButtonClear.BackColor = Color.LightYellow

    End Sub

    Public Sub openNumpad(sender As Object)
        curTxt = DirectCast(sender, TextBox)
        Me.Show()
        NumPadText.Text = curTxt.Text
    End Sub

    Private Sub padButtonClick(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        If btn Is ButtonOK Then
            curTxt.Text = NumPadText.Text
            Me.Close()
            Return
        ElseIf btn Is ButtonCancel Then
            Me.Close()
            Return
        ElseIf btn Is ButtonClear Then
            NumPadText.Clear()
        ElseIf btn Is ButtonBack Then
            If NumPadText.Text.Count > 0 Then
                NumPadText.Text = NumPadText.Text.Remove(NumPadText.Text.Count - 1)
            End If
        Else
            NumPadText.AppendText(btn.Text)
        End If

        'Do what ever you need to do to the calling control
    End Sub
End Class