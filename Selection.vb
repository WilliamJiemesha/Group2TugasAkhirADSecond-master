Public Class Selection
    Private Sub openformadmin()
        AdminLogin.Show()
        Me.Hide()
    End Sub
    Private Sub openformorder()
        FilmSelection.Show()
        Me.Hide()
    End Sub



    Private Sub AdminButton_Click(sender As Object, e As EventArgs) Handles AdminButton.Click
        openformadmin()
    End Sub

    Private Sub AdminLabel_Click(sender As Object, e As EventArgs) Handles AdminLabel.Click
        openformadmin()
    End Sub

    Private Sub OrderLabel_Click(sender As Object, e As EventArgs) Handles OrderLabel.Click
        openformorder()
    End Sub
    Private Sub OrderButton_Click(sender As Object, e As EventArgs) Handles OrderButton.Click
        openformorder()
    End Sub
End Class