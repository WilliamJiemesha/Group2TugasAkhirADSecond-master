Public Class MehtodePayForm
    Public Jumlah As Integer = ReceiptFormvb.total
    Private Sub AgreeButton_Click(sender As Object, e As EventArgs) Handles AgreeButton.Click
        If CbPayment.Text = "Cash" Then
            CashForm.Show()
        ElseIf CbPayment.Text = "Debit/Credit Card" Then
            DebitForm.Show()
        ElseIf CbPayment.Text = "OVO" Then
            OvoForm.Show()
        ElseIf CbPayment.Text = "Go-Pay" Then
            GopayForm.Show()
        End If
    End Sub

End Class