Imports MySql.Data.MySqlClient
Public Class FinishForm
    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        Dim connect As New MySqlConnection(AskDatabase.ConnStringFix)
        Dim command As New MySqlCommand
        Dim adapt As New MySqlDataAdapter
        Dim dt As New DataTable
        Dim query As String
        Try
            connect.Open()
            query = "SELECT theatre_name FROM theatre WHERE theatre_id = '" + TimeSelection.Theatre + "'"
            command = New MySqlCommand(query, connect)
            adapt = New MySqlDataAdapter(command)
            adapt.Fill(dt)

            connect.Close()
        Catch ex As Exception
            connect.Close()
        End Try

        TicketForm.FilmLabel.Text = FilmSelection.filmname
        TicketForm.TheatreLabel.Text = dt.Rows(0).Item(0)
        TicketForm.FilmLabel2.Text = FilmSelection.filmname
        TicketForm.TheatreLabel2.Text = TimeSelection.Theatre
        TicketForm.TimeLabel.Text = TimeSelection.TimeStart
        TicketForm.TimeLabel2.Text = TimeSelection.TimeStart
        TicketForm.DateLabel.Text = DateTime.Now.ToString("dddd , dd MMMM yyyy")
        TicketForm.DateLabel2.Text = DateTime.Now.ToString("dddd , dd MMMM yyyy")
        TicketForm.Show()
        Me.Hide()
    End Sub
End Class