Public Class CashForm
    Private Sub SeatCountBox_TextChanged(sender As Object, e As EventArgs) Handles CashPrice.TextChanged
        CashPrice.Text = ReceiptFormvb.total
    End Sub
    Private Sub AgreeButton_Click(sender As Object, e As EventArgs) Handles AgreeButton.Click
        If CashInput.Text = "" Then
            MessageBox.Show("Input Data Dengan Benar!", "PENTING", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Apakah Anda Yakin Ingin Melanjutkan ?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        End If
        FinishForm.Show()
    End Sub

    Private Sub buttonx_Click(sender As Object, e As EventArgs) Handles buttonx.Click
        MehtodePayForm.Show()
    End Sub
End Class