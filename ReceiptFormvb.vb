Imports MySql.Data.MySqlClient
Public Class ReceiptFormvb
    Public total As Integer
    Dim connect As New MySqlConnection(AskDatabase.ConnStringFix)
    Private Sub ReceiptFormvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SeatCountBox.Text = Seats.tickets
        TotalAmmountBox.Text = Seats.tickets * 50000
        total = Seats.tickets * 50000
    End Sub

    Private Sub AgreeButton_Click(sender As Object, e As EventArgs) Handles AgreeButton.Click
        MehtodePayForm.Show()
        Me.Hide()
        Dim query As String
        Dim command As New MySqlCommand
        Dim adapt As New MySqlDataAdapter
        Try
            connect.Open()

            query = "INSERT INTO sales VALUES ('" + Date.Now.ToString("yyyy-MM-dd") + "','" + Seats.tickets.ToString + "','" + total.ToString + "','" + TimeSelection.ChosenFilm.ToString + "')"
            command = New MySqlCommand(query, connect)
            command.ExecuteNonQuery()

            connect.Close()
        Catch ex As Exception
            connect.Close()
        End Try

    End Sub
End Class