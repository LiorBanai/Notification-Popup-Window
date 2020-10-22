Public Class Form1
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim notify = New NotificationWindow.PopupNotifier()
        notify.Image = My.Resources.icon
        notify.ContentText = "test"
        notify.Popup()
    End Sub
End Class
