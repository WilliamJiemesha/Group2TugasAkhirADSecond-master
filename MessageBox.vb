Public Class MessageBoxs
    Private Sub YesCheck_Click(sender As Object, e As EventArgs) Handles YesCheck.Click
        If ErrorText.Tag = "Admin" Then
            AdminLogin.Show()
            Me.Close()
        End If
    End Sub

    Private Sub MessageBoxs_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class