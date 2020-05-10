Imports MySql.Data.MySqlClient
Public Class TimeSelection
    Dim connect As New MySqlConnection(AskDatabase.ConnStringFix)
    Public ChosenFilm, Screening, Theatre, TimeStart As String

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Me.Close()
        FilmSelection.Show()
    End Sub

    Private Sub TimeSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String
        Dim command As New MySqlCommand
        Dim adapt As New MySqlDataAdapter
        Dim dts As New DataTable
        Try
            connect.Open()
            query = "SELECT s.starting_time, d.theatre_id FROM screening s, dtheatre d WHERE d.film_id = '" + ChosenFilm + "' AND d.screening_id = s.screening_id"
            command = New MySqlCommand(query, connect)
            adapt = New MySqlDataAdapter(command)
            adapt.Fill(dts)

            timebox.Properties.DataSource = dts
            timebox.Properties.DisplayMember = "starting_time"
            timebox.Properties.ValueMember = "theatre_id"
            timebox.Text = ""
            connect.Close()
        Catch ex As Exception
            connect.Close()
            MsgBox(ex.Message)
        End Try

        timeimage.Image = Image.FromFile(AskDatabase.filepath + "\" + ChosenFilm + ".jpg")
    End Sub

    Private Sub timebox_EditValueChanged(sender As Object, e As EventArgs) Handles timebox.EditValueChanged
        Try
            TimeStart = timebox.Text
            Theatre = timebox.EditValue
            Dim query As String
            Dim command As New MySqlCommand
            Dim adapt As New MySqlDataAdapter
            Dim dt As New DataTable
            connect.Open()

            query = "SELECT screening_id FROM screening WHERE starting_time = '" + timebox.Text + "'"
            command = New MySqlCommand(query, connect)
            adapt = New MySqlDataAdapter(command)
            adapt.Fill(dt)

            Screening = dt.Rows(0).Item(0)
            connect.Close()
            Seats.Show()
            Me.Hide()
        Catch ex As Exception
            connect.close
        End Try
    End Sub
End Class