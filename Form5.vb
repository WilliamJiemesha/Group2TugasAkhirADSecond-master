Public Class CashForm
    Private Sub AgreeButton_Click(sender As Object, e As EventArgs) Handles AgreeButton.Click
        If CashInput.Text = "" Then
            MessageBox.Show("Input Data Dengan Benar!", "PENTING", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If MessageBox.Show("Apakah Anda Yakin Ingin Melanjutkan ?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                FinishForm.Show()
            End If
        End If
    End Sub

    Private Sub buttonx_Click(sender As Object, e As EventArgs) Handles buttonx.Click
        MehtodePayForm.Show()
        Me.Close()
    End Sub

    Private Sub CashForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CashPrice.Text = ReceiptFormvb.total
    End Sub
End Class