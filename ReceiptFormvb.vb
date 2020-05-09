Public Class ReceiptFormvb
    Public total As Integer
    Private Sub ReceiptFormvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SeatCountBox.Text = Seats.tickets
        TotalAmmountBox.Text = Seats.tickets * 50000
        total = Seats.tickets * 50000
    End Sub

    Private Sub AgreeButton_Click(sender As Object, e As EventArgs) Handles AgreeButton.Click
        MehtodePayForm.Show()
        Me.Hide()
    End Sub
End Class