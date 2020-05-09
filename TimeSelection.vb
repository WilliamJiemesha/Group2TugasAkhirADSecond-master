Imports MySql.Data.MySqlClient
Public Class TimeSelection
    Dim connect As New MySqlConnection("datasource=127.0.0.1;port=3308;username=root;password=;database=movie_theatre")
    Public ChosenFilm, Screening, Theatre As String
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

        timeimage.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + ChosenFilm + ".jpg")
    End Sub

    Private Sub timebox_EditValueChanged(sender As Object, e As EventArgs) Handles timebox.EditValueChanged
        Try
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