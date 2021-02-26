Public Class EndDrift
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.FindForm().Close()
    End Sub

    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        FishEntry.Close()
        Me.FindForm().Close()
        DriftEntry.Show()
    End Sub
End Class