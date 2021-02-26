
Public Class MainMenu

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub ButtonFishLingcod_Click(sender As Object, e As EventArgs) Handles ButtonTrip.Click
        TripEntry.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub SettingsHandler(sender As Object, e As EventArgs) Handles SettingsButton.Click
        Settings.Show()
    End Sub

End Class