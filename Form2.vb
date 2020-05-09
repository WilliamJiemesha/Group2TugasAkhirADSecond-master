Public Class GopayForm
    Private Sub AgreeButton_Click(sender As Object, e As EventArgs) Handles AgreeButton.Click
        If GoNumber.Text = "" Then
            MessageBox.Show("Input Data Dengan Benar!", "PENTING", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Apakah Anda Yakin Ingin Melanjutkan ?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        End If
        FinishForm.Show()
    End Sub

    Private Sub buttonx_Click(sender As Object, e As EventArgs) Handles buttonx.Click
        MehtodePayForm.Show()
    End Sub

    Private Sub SeatCountBox_TextChanged(sender As Object, e As EventArgs) Handles GoPrice.TextChanged
        GoPrice.Text = ReceiptFormvb.total
    End Sub


End Class