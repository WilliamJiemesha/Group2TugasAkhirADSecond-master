Imports MySql.Data.MySqlClient
Public Class FilmSelection
    Dim connect As New MySqlConnection("datasource=127.0.0.1;port=3308;username=root;password=;database=movie_theatre")
    Private Sub FilmSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connect.Open()

            Dim command As New MySqlCommand
            Dim adapt As New MySqlDataAdapter
            Dim query As String
            Dim dt, ds As New DataTable
            query = "SELECT film.film_id, film.film_name FROM film, dtheatre WHERE film.film_id = dtheatre.film_id GROUP BY film_id LIMIT 10;"
            command = New MySqlCommand(query, connect)
            adapt = New MySqlDataAdapter(command)
            adapt.Fill(dt)
            simpan.DataSource = dt


            If dt.Rows.Count = 10 Then
                box1.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(0).Cells(0).Value.ToString() + ".jpg")
                box2.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(1).Cells(0).Value.ToString() + ".jpg")
                box3.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(2).Cells(0).Value.ToString() + ".jpg")
                box4.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(3).Cells(0).Value.ToString() + ".jpg")
                box5.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(4).Cells(0).Value.ToString() + ".jpg")
                box6.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(5).Cells(0).Value.ToString() + ".jpg")
                box7.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(6).Cells(0).Value.ToString() + ".jpg")
                box8.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(7).Cells(0).Value.ToString() + ".jpg")
                box9.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(8).Cells(0).Value.ToString() + ".jpg")
                box10.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(9).Cells(0).Value.ToString() + ".jpg")
                Label1.Text = simpan.Rows(0).Cells(1).Value.ToString()
                Label2.Text = simpan.Rows(1).Cells(1).Value.ToString()
                Label3.Text = simpan.Rows(2).Cells(1).Value.ToString()
                Label4.Text = simpan.Rows(3).Cells(1).Value.ToString()
                Label5.Text = simpan.Rows(4).Cells(1).Value.ToString()
                Label6.Text = simpan.Rows(5).Cells(1).Value.ToString()
                Label7.Text = simpan.Rows(6).Cells(1).Value.ToString()
                Label8.Text = simpan.Rows(7).Cells(1).Value.ToString()
                Label9.Text = simpan.Rows(8).Cells(1).Value.ToString()
                Label10.Text = simpan.Rows(9).Cells(1).Value.ToString()
            ElseIf dt.Rows.Count = 9 Then
                box1.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(0).Cells(0).Value.ToString() + ".jpg")
                box2.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(1).Cells(0).Value.ToString() + ".jpg")
                box3.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(2).Cells(0).Value.ToString() + ".jpg")
                box4.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(3).Cells(0).Value.ToString() + ".jpg")
                box5.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(4).Cells(0).Value.ToString() + ".jpg")
                box6.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(5).Cells(0).Value.ToString() + ".jpg")
                box7.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(6).Cells(0).Value.ToString() + ".jpg")
                box8.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(7).Cells(0).Value.ToString() + ".jpg")
                box9.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(8).Cells(0).Value.ToString() + ".jpg")
                Label1.Text = simpan.Rows(0).Cells(1).Value.ToString()
                Label2.Text = simpan.Rows(1).Cells(1).Value.ToString()
                Label3.Text = simpan.Rows(2).Cells(1).Value.ToString()
                Label4.Text = simpan.Rows(3).Cells(1).Value.ToString()
                Label5.Text = simpan.Rows(4).Cells(1).Value.ToString()
                Label6.Text = simpan.Rows(5).Cells(1).Value.ToString()
                Label7.Text = simpan.Rows(6).Cells(1).Value.ToString()
                Label8.Text = simpan.Rows(7).Cells(1).Value.ToString()
                Label9.Text = simpan.Rows(8).Cells(1).Value.ToString()
            ElseIf dt.Rows.Count = 8 Then
                box1.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(0).Cells(0).Value.ToString() + ".jpg")
                box2.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(1).Cells(0).Value.ToString() + ".jpg")
                box3.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(2).Cells(0).Value.ToString() + ".jpg")
                box4.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(3).Cells(0).Value.ToString() + ".jpg")
                box5.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(4).Cells(0).Value.ToString() + ".jpg")
                box6.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(5).Cells(0).Value.ToString() + ".jpg")
                box7.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(6).Cells(0).Value.ToString() + ".jpg")
                box8.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(7).Cells(0).Value.ToString() + ".jpg")
                Label1.Text = simpan.Rows(0).Cells(1).Value.ToString()
                Label2.Text = simpan.Rows(1).Cells(1).Value.ToString()
                Label3.Text = simpan.Rows(2).Cells(1).Value.ToString()
                Label4.Text = simpan.Rows(3).Cells(1).Value.ToString()
                Label5.Text = simpan.Rows(4).Cells(1).Value.ToString()
                Label6.Text = simpan.Rows(5).Cells(1).Value.ToString()
                Label7.Text = simpan.Rows(6).Cells(1).Value.ToString()
                Label8.Text = simpan.Rows(7).Cells(1).Value.ToString()
            ElseIf dt.Rows.Count = 7 Then
                box1.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(0).Cells(0).Value.ToString() + ".jpg")
                box2.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(1).Cells(0).Value.ToString() + ".jpg")
                box3.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(2).Cells(0).Value.ToString() + ".jpg")
                box4.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(3).Cells(0).Value.ToString() + ".jpg")
                box5.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(4).Cells(0).Value.ToString() + ".jpg")
                box6.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(5).Cells(0).Value.ToString() + ".jpg")
                box7.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(6).Cells(0).Value.ToString() + ".jpg")
                Label1.Text = simpan.Rows(0).Cells(1).Value.ToString()
                Label2.Text = simpan.Rows(1).Cells(1).Value.ToString()
                Label3.Text = simpan.Rows(2).Cells(1).Value.ToString()
                Label4.Text = simpan.Rows(3).Cells(1).Value.ToString()
                Label5.Text = simpan.Rows(4).Cells(1).Value.ToString()
                Label6.Text = simpan.Rows(5).Cells(1).Value.ToString()
                Label7.Text = simpan.Rows(6).Cells(1).Value.ToString()
            ElseIf dt.Rows.Count = 6 Then
                box1.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(0).Cells(0).Value.ToString() + ".jpg")
                box2.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(1).Cells(0).Value.ToString() + ".jpg")
                box3.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(2).Cells(0).Value.ToString() + ".jpg")
                box4.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(3).Cells(0).Value.ToString() + ".jpg")
                box5.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(4).Cells(0).Value.ToString() + ".jpg")
                box6.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(5).Cells(0).Value.ToString() + ".jpg")
                Label1.Text = simpan.Rows(0).Cells(1).Value.ToString()
                Label2.Text = simpan.Rows(1).Cells(1).Value.ToString()
                Label3.Text = simpan.Rows(2).Cells(1).Value.ToString()
                Label4.Text = simpan.Rows(3).Cells(1).Value.ToString()
                Label5.Text = simpan.Rows(4).Cells(1).Value.ToString()
                Label6.Text = simpan.Rows(5).Cells(1).Value.ToString()
            ElseIf dt.Rows.Count = 5 Then
                box1.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(0).Cells(0).Value.ToString() + ".jpg")
                box2.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(1).Cells(0).Value.ToString() + ".jpg")
                box3.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(2).Cells(0).Value.ToString() + ".jpg")
                box4.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(3).Cells(0).Value.ToString() + ".jpg")
                box5.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(4).Cells(0).Value.ToString() + ".jpg")
                Label1.Text = simpan.Rows(0).Cells(1).Value.ToString()
                Label2.Text = simpan.Rows(1).Cells(1).Value.ToString()
                Label3.Text = simpan.Rows(2).Cells(1).Value.ToString()
                Label4.Text = simpan.Rows(3).Cells(1).Value.ToString()
                Label5.Text = simpan.Rows(4).Cells(1).Value.ToString()
            ElseIf dt.Rows.Count = 4 Then
                box1.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(0).Cells(0).Value.ToString() + ".jpg")
                box2.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(1).Cells(0).Value.ToString() + ".jpg")
                box3.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(2).Cells(0).Value.ToString() + ".jpg")
                box4.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(3).Cells(0).Value.ToString() + ".jpg")
                Label1.Text = simpan.Rows(0).Cells(1).Value.ToString()
                Label2.Text = simpan.Rows(1).Cells(1).Value.ToString()
                Label3.Text = simpan.Rows(2).Cells(1).Value.ToString()
                Label4.Text = simpan.Rows(3).Cells(1).Value.ToString()
            ElseIf dt.Rows.Count = 3 Then
                box1.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(0).Cells(0).Value.ToString() + ".jpg")
                box2.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(1).Cells(0).Value.ToString() + ".jpg")
                box3.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(2).Cells(0).Value.ToString() + ".jpg")
                Label1.Text = simpan.Rows(0).Cells(1).Value.ToString()
                Label2.Text = simpan.Rows(1).Cells(1).Value.ToString()
                Label3.Text = simpan.Rows(2).Cells(1).Value.ToString()
            ElseIf dt.Rows.Count = 2 Then
                box1.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(0).Cells(0).Value.ToString() + ".jpg")
                box2.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(1).Cells(0).Value.ToString() + ".jpg")
                Label1.Text = simpan.Rows(0).Cells(1).Value.ToString()
                Label2.Text = simpan.Rows(1).Cells(1).Value.ToString()
            ElseIf dt.Rows.Count = 1 Then
                box1.Image = Image.FromFile("C:\Users\user\source\repos\Group2TugasAkhirADSecond\Resources\" + simpan.Rows(0).Cells(0).Value.ToString() + ".jpg")
                Label1.Text = simpan.Rows(0).Cells(1).Value.ToString()
            End If

            connect.Close()
        Catch ex As Exception
            connect.Close()
            MsgBox("error")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub box1_Click(sender As Object, e As EventArgs) Handles box1.Click
        TimeSelection.ChosenFilm = simpan.Rows(0).Cells(0).Value.ToString
        TimeSelection.Show()
        Me.Close()
    End Sub

    Private Sub box2_Click(sender As Object, e As EventArgs) Handles box2.Click
        TimeSelection.ChosenFilm = simpan.Rows(1).Cells(0).Value.ToString
        TimeSelection.Show()
        Me.Close()
    End Sub

    Private Sub box3_Click(sender As Object, e As EventArgs) Handles box3.Click
        TimeSelection.ChosenFilm = simpan.Rows(2).Cells(0).Value.ToString
        TimeSelection.Show()
        Me.Close()
    End Sub

    Private Sub box4_Click(sender As Object, e As EventArgs) Handles box4.Click
        TimeSelection.ChosenFilm = simpan.Rows(3).Cells(0).Value.ToString
        TimeSelection.Show()
        Me.Close()
    End Sub

    Private Sub box5_Click(sender As Object, e As EventArgs) Handles box5.Click
        TimeSelection.ChosenFilm = simpan.Rows(4).Cells(0).Value.ToString
        TimeSelection.Show()
        Me.Close()
    End Sub

    Private Sub box6_Click(sender As Object, e As EventArgs) Handles box6.Click
        TimeSelection.ChosenFilm = simpan.Rows(5).Cells(0).Value.ToString
        TimeSelection.Show()
        Me.Close()
    End Sub

    Private Sub box7_Click(sender As Object, e As EventArgs) Handles box7.Click
        TimeSelection.ChosenFilm = simpan.Rows(6).Cells(0).Value.ToString
        TimeSelection.Show()
        Me.Close()
    End Sub

    Private Sub box8_Click(sender As Object, e As EventArgs) Handles box8.Click
        TimeSelection.ChosenFilm = simpan.Rows(7).Cells(0).Value.ToString
        TimeSelection.Show()
        Me.Close()
    End Sub

    Private Sub box9_Click(sender As Object, e As EventArgs) Handles box9.Click
        TimeSelection.ChosenFilm = simpan.Rows(8).Cells(0).Value.ToString
        TimeSelection.Show()
        Me.Close()
    End Sub

    Private Sub box10_Click(sender As Object, e As EventArgs) Handles box10.Click
        TimeSelection.ChosenFilm = simpan.Rows(9).Cells(0).Value.ToString
        TimeSelection.Show()
        Me.Close()
    End Sub
End Class