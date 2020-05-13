Public Class TicketForm
    Dim ticks As Integer
    Private Sub TicketForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrintThisDocument.PrintFileName = FilmLabel.Text
        'PrintThisDocument.Print()
    End Sub

    Private Sub LoadTime_Tick(sender As Object, e As EventArgs) Handles LoadTime.Tick
        If ticks = 2 Then
            LoadTime.Enabled = False
            PrintThisDocument.Print()
        Else
            ticks += 1
        End If
    End Sub
    Private Sub exitnow(sender As Object, e As EventArgs) Handles MyBase.Click
        Selection.Show()
        Me.Close()
        FinishForm.Close()
        ReceiptFormvb.Close()
        MehtodePayForm.Close()
        OvoForm.Close()
        GopayForm.Close()
        CashForm.Close()
        DebitForm.Close()
        Seats.Close()
        TimeSelection.Close()
        FilmSelection.Close()
    End Sub


End Class