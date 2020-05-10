Public Class Selection
    Private Sub openformadmin()
        AdminLogin.Show()
        Me.Hide()
    End Sub
    Private Sub openformorder()
        FilmSelection.Show()
        Me.Hide()
    End Sub
    Private Sub exitform()
        LoadingForm.Close()
        AskDatabase.Close()
        Me.Close()
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

    Private Sub ExitLabel_Click(sender As Object, e As EventArgs) Handles ExitLabel.Click
        exitform()
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        exitform()
    End Sub
End Class