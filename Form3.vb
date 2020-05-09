Public Class OvoForm
    Private Sub OvoPrice_TextChanged(sender As Object, e As EventArgs) Handles OvoPrice.TextChanged
        OvoPrice.Text = ReceiptFormvb.total
    End Sub

    Private Sub AgreeButton_Click(sender As Object, e As EventArgs) Handles AgreeButton.Click
        If OvoNumber.Text = "" Then
            MessageBox.Show("Input Data Dengan Benar!", "PENTING", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Apakah Anda Yakin Ingin Melanjutkan ?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        End If

        FinishForm.Show()

    End Sub

    Private Sub buttonx_Click(sender As Object, e As EventArgs) Handles buttonx.Click

        MehtodePayForm.Show()
    End Sub

    Private Sub OvoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class