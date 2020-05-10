Imports MySql.Data.MySqlClient
Public Class FilmSelection
    Dim connect As New MySqlConnection(AskDatabase.ConnStringFix)
    Public filmname As String
    Public filepath As String
    Private Sub FilmSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        box1.Visible = False
        box2.Visible = False
        box3.Visible = False
        box4.Visible = False
        box5.Visible = False
        box6.Visible = False
        box7.Visible = False
        box8.Visible = False
        box9.Visible = False
        box10.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Try
            connect.Open()

            Dim command As New MySqlCommand
            Dim adapt As New MySqlDataAdapter
            Dim query As String
            Dim dd, dt, ds As New DataTable
            query = "SELECT film.film_id, film.film_name FROM film, dtheatre WHERE film.film_id = dtheatre.film_id GROUP BY film_id LIMIT 10;"
            command = New MySqlCommand(query, connect)
            adapt = New MySqlDataAdapter(command)
            adapt.Fill(dt)
            simpan.DataSource = dt
            query = "SELECT filepath FROM administration"

            If dt.Rows.Count = 10 Then
                box1.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(0).Cells(0).Value.ToString() + ".jpg")
                box2.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(1).Cells(0).Value.ToString() + ".jpg")
                box3.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(2).Cells(0).Value.ToString() + ".jpg")
                box4.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(3).Cells(0).Value.ToString() + ".jpg")
                box5.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(4).Cells(0).Value.ToString() + ".jpg")
                box6.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(5).Cells(0).Value.ToString() + ".jpg")
                box7.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(6).Cells(0).Value.ToString() + ".jpg")
                box8.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(7).Cells(0).Value.ToString() + ".jpg")
                box9.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(8).Cells(0).Value.ToString() + ".jpg")
                box10.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(9).Cells(0).Value.ToString() + ".jpg")
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

                box1.Visible = True
                box2.Visible = True
                box3.Visible = True
                box4.Visible = True
                box5.Visible = True
                box6.Visible = True
                box7.Visible = True
                box8.Visible = True
                box9.Visible = True
                box10.Visible = True
                Label1.Visible = True
                Label2.Visible = True
                Label3.Visible = True
                Label4.Visible = True
                Label5.Visible = True
                Label6.Visible = True
                Label7.Visible = True
                Label8.Visible = True
                Label9.Visible = True
                Label10.Visible = True
            ElseIf dt.Rows.Count = 9 Then
                box1.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(0).Cells(0).Value.ToString() + ".jpg")
                box2.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(1).Cells(0).Value.ToString() + ".jpg")
                box3.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(2).Cells(0).Value.ToString() + ".jpg")
                box4.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(3).Cells(0).Value.ToString() + ".jpg")
                box5.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(4).Cells(0).Value.ToString() + ".jpg")
                box6.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(5).Cells(0).Value.ToString() + ".jpg")
                box7.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(6).Cells(0).Value.ToString() + ".jpg")
                box8.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(7).Cells(0).Value.ToString() + ".jpg")
                box9.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(8).Cells(0).Value.ToString() + ".jpg")
                Label1.Text = simpan.Rows(0).Cells(1).Value.ToString()
                Label2.Text = simpan.Rows(1).Cells(1).Value.ToString()
                Label3.Text = simpan.Rows(2).Cells(1).Value.ToString()
                Label4.Text = simpan.Rows(3).Cells(1).Value.ToString()
                Label5.Text = simpan.Rows(4).Cells(1).Value.ToString()
                Label6.Text = simpan.Rows(5).Cells(1).Value.ToString()
                Label7.Text = simpan.Rows(6).Cells(1).Value.ToString()
                Label8.Text = simpan.Rows(7).Cells(1).Value.ToString()
                Label9.Text = simpan.Rows(8).Cells(1).Value.ToString()

                box1.Visible = True
                box2.Visible = True
                box3.Visible = True
                box4.Visible = True
                box5.Visible = True
                box6.Visible = True
                box7.Visible = True
                box8.Visible = True
                box9.Visible = True
                Label1.Visible = True
                Label2.Visible = True
                Label3.Visible = True
                Label4.Visible = True
                Label5.Visible = True
                Label6.Visible = True
                Label7.Visible = True
                Label8.Visible = True
                Label9.Visible = True
            ElseIf dt.Rows.Count = 8 Then
                box1.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(0).Cells(0).Value.ToString() + ".jpg")
                box2.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(1).Cells(0).Value.ToString() + ".jpg")
                box3.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(2).Cells(0).Value.ToString() + ".jpg")
                box4.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(3).Cells(0).Value.ToString() + ".jpg")
                box5.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(4).Cells(0).Value.ToString() + ".jpg")
                box6.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(5).Cells(0).Value.ToString() + ".jpg")
                box7.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(6).Cells(0).Value.ToString() + ".jpg")
                box8.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(7).Cells(0).Value.ToString() + ".jpg")
                Label1.Text = simpan.Rows(0).Cells(1).Value.ToString()
                Label2.Text = simpan.Rows(1).Cells(1).Value.ToString()
                Label3.Text = simpan.Rows(2).Cells(1).Value.ToString()
                Label4.Text = simpan.Rows(3).Cells(1).Value.ToString()
                Label5.Text = simpan.Rows(4).Cells(1).Value.ToString()
                Label6.Text = simpan.Rows(5).Cells(1).Value.ToString()
                Label7.Text = simpan.Rows(6).Cells(1).Value.ToString()
                Label8.Text = simpan.Rows(7).Cells(1).Value.ToString()

                box1.Visible = True
                box2.Visible = True
                box3.Visible = True
                box4.Visible = True
                box5.Visible = True
                box6.Visible = True
                box7.Visible = True
                box10.Visible = True
                Label1.Visible = True
                Label2.Visible = True
                Label3.Visible = True
                Label4.Visible = True
                Label5.Visible = True
                Label6.Visible = True
                Label7.Visible = True
                Label8.Visible = True
            ElseIf dt.Rows.Count = 7 Then
                box1.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(0).Cells(0).Value.ToString() + ".jpg")
                box2.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(1).Cells(0).Value.ToString() + ".jpg")
                box3.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(2).Cells(0).Value.ToString() + ".jpg")
                box4.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(3).Cells(0).Value.ToString() + ".jpg")
                box5.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(4).Cells(0).Value.ToString() + ".jpg")
                box6.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(5).Cells(0).Value.ToString() + ".jpg")
                box7.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(6).Cells(0).Value.ToString() + ".jpg")
                Label1.Text = simpan.Rows(0).Cells(1).Value.ToString()
                Label2.Text = simpan.Rows(1).Cells(1).Value.ToString()
                Label3.Text = simpan.Rows(2).Cells(1).Value.ToString()
                Label4.Text = simpan.Rows(3).Cells(1).Value.ToString()
                Label5.Text = simpan.Rows(4).Cells(1).Value.ToString()
                Label6.Text = simpan.Rows(5).Cells(1).Value.ToString()
                Label7.Text = simpan.Rows(6).Cells(1).Value.ToString()
                box1.Visible = True
                box2.Visible = True
                box3.Visible = True
                box4.Visible = True
                box5.Visible = True
                box6.Visible = True
                box7.Visible = True
                Label1.Visible = True
                Label2.Visible = True
                Label3.Visible = True
                Label4.Visible = True
                Label5.Visible = True
                Label6.Visible = True
                Label7.Visible = True
            ElseIf dt.Rows.Count = 6 Then
                box1.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(0).Cells(0).Value.ToString() + ".jpg")
                box2.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(1).Cells(0).Value.ToString() + ".jpg")
                box3.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(2).Cells(0).Value.ToString() + ".jpg")
                box4.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(3).Cells(0).Value.ToString() + ".jpg")
                box5.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(4).Cells(0).Value.ToString() + ".jpg")
                box6.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(5).Cells(0).Value.ToString() + ".jpg")
                Label1.Text = simpan.Rows(0).Cells(1).Value.ToString()
                Label2.Text = simpan.Rows(1).Cells(1).Value.ToString()
                Label3.Text = simpan.Rows(2).Cells(1).Value.ToString()
                Label4.Text = simpan.Rows(3).Cells(1).Value.ToString()
                Label5.Text = simpan.Rows(4).Cells(1).Value.ToString()
                Label6.Text = simpan.Rows(5).Cells(1).Value.ToString()

                box1.Visible = True
                box2.Visible = True
                box3.Visible = True
                box4.Visible = True
                box5.Visible = True
                box6.Visible = True
                Label1.Visible = True
                Label2.Visible = True
                Label3.Visible = True
                Label4.Visible = True
                Label5.Visible = True
                Label6.Visible = True
            ElseIf dt.Rows.Count = 5 Then
                box1.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(0).Cells(0).Value.ToString() + ".jpg")
                box2.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(1).Cells(0).Value.ToString() + ".jpg")
                box3.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(2).Cells(0).Value.ToString() + ".jpg")
                box4.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(3).Cells(0).Value.ToString() + ".jpg")
                box5.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(4).Cells(0).Value.ToString() + ".jpg")
                Label1.Text = simpan.Rows(0).Cells(1).Value.ToString()
                Label2.Text = simpan.Rows(1).Cells(1).Value.ToString()
                Label3.Text = simpan.Rows(2).Cells(1).Value.ToString()
                Label4.Text = simpan.Rows(3).Cells(1).Value.ToString()
                Label5.Text = simpan.Rows(4).Cells(1).Value.ToString()

                box1.Visible = True
                box2.Visible = True
                box3.Visible = True
                box4.Visible = True
                box5.Visible = True
                Label1.Visible = True
                Label2.Visible = True
                Label3.Visible = True
                Label4.Visible = True
                Label5.Visible = True
            ElseIf dt.Rows.Count = 4 Then
                box1.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(0).Cells(0).Value.ToString() + ".jpg")
                box2.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(1).Cells(0).Value.ToString() + ".jpg")
                box3.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(2).Cells(0).Value.ToString() + ".jpg")
                box4.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(3).Cells(0).Value.ToString() + ".jpg")
                Label1.Text = simpan.Rows(0).Cells(1).Value.ToString()
                Label2.Text = simpan.Rows(1).Cells(1).Value.ToString()
                Label3.Text = simpan.Rows(2).Cells(1).Value.ToString()
                Label4.Text = simpan.Rows(3).Cells(1).Value.ToString()
                box1.Visible = True
                box2.Visible = True
                box3.Visible = True
                box4.Visible = True
                Label1.Visible = True
                Label2.Visible = True
                Label3.Visible = True
                Label4.Visible = True
            ElseIf dt.Rows.Count = 3 Then
                box1.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(0).Cells(0).Value.ToString() + ".jpg")
                box2.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(1).Cells(0).Value.ToString() + ".jpg")
                box3.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(2).Cells(0).Value.ToString() + ".jpg")
                Label1.Text = simpan.Rows(0).Cells(1).Value.ToString()
                Label2.Text = simpan.Rows(1).Cells(1).Value.ToString()
                Label3.Text = simpan.Rows(2).Cells(1).Value.ToString()
                box1.Visible = True
                box2.Visible = True
                box3.Visible = True
                Label1.Visible = True
                Label2.Visible = True
                Label3.Visible = True
            ElseIf dt.Rows.Count = 2 Then
                box1.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(0).Cells(0).Value.ToString() + ".jpg")
                box2.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(1).Cells(0).Value.ToString() + ".jpg")
                Label1.Text = simpan.Rows(0).Cells(1).Value.ToString()
                Label2.Text = simpan.Rows(1).Cells(1).Value.ToString()
                box1.Visible = True
                box2.Visible = True
                Label1.Visible = True
                Label2.Visible = True
            ElseIf dt.Rows.Count = 1 Then
                box1.Image = Image.FromFile(AskDatabase.filepath + "\" + simpan.Rows(0).Cells(0).Value.ToString() + ".jpg")
                Label1.Text = simpan.Rows(0).Cells(1).Value.ToString()
                box1.Visible = True
                Label1.Visible = True
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

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Me.Close()
        Selection.Show()
    End Sub
End Class