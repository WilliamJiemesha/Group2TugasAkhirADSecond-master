Imports mysql.data.MySqlClient
Public Class LoadingForm
    Private Sub ProgressTimer_Tick(sender As Object, e As EventArgs) Handles ProgressTimer.Tick
        If Progress.Value < 1000 Then
            Progress.Value += 2
        Else
            ProgressTimer.Enabled = False
            Selection.Show()
            Me.Hide()
        End If
    End Sub
End Class
