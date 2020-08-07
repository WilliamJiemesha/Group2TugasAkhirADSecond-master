Public Class OvoForm
    Private Sub AgreeButton_Click(sender As Object, e As EventArgs) Handles AgreeButton.Click
        If OvoNumber.Text = "" Then
            MessageBox.Show("Wrong Input", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If MessageBox.Show("Are you sure you want to continue?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                FinishForm.Show()
                Me.Hide()
            End If
        End If


    End Sub

    Private Sub buttonx_Click(sender As Object, e As EventArgs) Handles buttonx.Click
        MehtodePayForm.Show()
        Me.Close()
    End Sub

    Private Sub OvoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OvoPrice.Text = ReceiptFormvb.total
    End Sub
End Class