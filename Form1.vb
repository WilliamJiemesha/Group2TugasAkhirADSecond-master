Public Class DebitForm
    Private Sub AgreeButton_Click(sender As Object, e As EventArgs) Handles AgreeButton.Click
        If CardNumber.Text = "" Then
            MessageBox.Show("Input Data Dengan Benar!", "PENTING", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf ExpiredDate.Text = "" Then
            MessageBox.Show("Input Data Dengan Benar!", "PENTING", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf SecurityNumber.Text = "" Then
            MessageBox.Show("Input Data Dengan Benar!", "PENTING", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Apakah Anda Yakin Ingin Melanjutkan ?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        End If
        FinishForm.Show()
    End Sub

    Private Sub buttonx_Click(sender As Object, e As EventArgs) Handles buttonx.Click
        MehtodePayForm.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles PriceCard.TextChanged
        PriceCard.Text = ReceiptFormvb.total
    End Sub


End Class