Imports mysql.data.MySqlClient
Public Class LoadingForm
    Private Sub ProgressTimer_Tick(sender As Object, e As EventArgs) Handles ProgressTimer.Tick
        If Progress.Value < 1000 Then
            Progress.Value += 5
        Else
            ProgressTimer.Enabled = False
            AskDatabase.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub LoadingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
