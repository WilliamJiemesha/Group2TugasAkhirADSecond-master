Imports MySql.Data.MySqlClient
Public Class Seats
    Dim buttons As New Button
    Dim x As Integer = 110
    Dim y As Integer = 100
    Dim markx As String
    Dim marky As String
    Dim intervalx As Integer = 40
    Dim intervaly As Integer = 30

    'Sent Data About Seat Count
    Dim seat_count As Integer
    Dim seat_count_x As Integer = 8
    Dim seat_count_y As Integer = seat_count / 8

    Dim screening As String
    Dim theatre As String
    Dim film As String
    Dim count As Integer
    Public tickets As Integer
    Dim seatschosen, continueseat As String
    Dim seatchosencount, temposeat, seatykeepcount As Integer

    'Private Sub painting(sender As Object, e As PaintEventArgs)
    '    Dim BorderPanel As New Panel

    '    BorderPanel.Width = 800
    '    BorderPanel.Height = 600
    '    BorderPanel.BackColor = Color.Transparent
    '    BorderPanel.BorderStyle = BorderStyle.Fixed3D
    '    ControlPaint.DrawBorder(e.Graphics, BorderPanel.ClientRectangle, Color.FromArgb(255, 207, 64), ButtonBorderStyle.Solid)
    'End Sub

    Private Sub ShowSeats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            tickets = 0
            'painting(sender, e)
            Me.Height = 720
            Me.Width = 1280
            Me.BackColor = Color.FromArgb(18, 16, 10)


            Dim connect As New MySqlConnection(AskDatabase.ConnStringFix)
            Dim command As New MySqlCommand
            Dim adapt As New MySqlDataAdapter
            Dim query As String
            Dim dw, seatcounts As New DataTable
            screening = TimeSelection.Screening
            theatre = TimeSelection.Theatre
            film = TimeSelection.ChosenFilm

            query = "SELECT seat_ammount FROM theatre WHERE theatre_id = '" + theatre + "'"
            command = New MySqlCommand(query, connect)
            adapt = New MySqlDataAdapter(command)
            adapt.Fill(seatcounts)

            seat_count = seatcounts.Rows(0).Item(0)
            seat_count_y = seat_count / 8
            seatykeepcount = seat_count / 8
            SeatChooseBox.Properties.MaxValue = seat_count

            'Simulation Screen
            buttons = New Button
            With buttons
                .Parent = Me
                .Width = 200
                .Height = 50
                .Location = New Point(200, 0)
                .BackColor = Color.Black
            End With

            query = "SELECT seat_id, seat_status FROM seat WHERE theatre_id = '" + theatre + "' AND screening_id = '" + screening + "' AND film_id = '" + film + "'"
            command = New MySqlCommand(query, connect)
            adapt = New MySqlDataAdapter(command)
            adapt.Fill(dw)


            'Seat X Max 8
            'Seat Y Max 10
            'Total Seats Max 80

            'Simulation Seats
            For i = 1 To seat_count_x
                x += intervalx
                markx += 1
                marky = 0
                y = 100
                For j = 1 To seat_count_y
                    y += intervaly
                    marky += 1
                    buttons = New Button
                    With buttons
                        .Parent = Me
                        .Width = 25
                        .Height = 25
                        .Location = New Point(x, y)
                        .FlatStyle = FlatStyle.Flat
                        .Name = markx + "_" + marky
                        .Tag = dw.Rows(count).Item(0).ToString
                    End With
                    If dw.Rows(count).Item(1).ToString = "1" Then
                        buttons.BackColor = Color.Gray
                    Else
                        buttons.BackColor = Color.Red
                    End If
                    count += 1
                    'For Click Event
                    AddHandler buttons.Click, AddressOf buttons_click
                    Me.Controls.Add(buttons)
                Next
            Next

            'Simulation Entrance
            buttons = New Button
            With buttons
                .Parent = Me
                .Width = 50
                .Height = 30
                .Location = New Point(0, 420)
                .BackColor = Color.Brown
            End With

            'Simulation Exit
            buttons = New Button
            With buttons
                .Parent = Me
                .Width = 30
                .Height = 50
                .Location = New Point(0, 0)
                .BackColor = Color.Brown
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'For Another Click Event
    Private Sub buttonmultiples(sender As String)
        Dim saveme As String = sender
        Dim butts As Button
        butts = Me.Controls(saveme)
        butts.BackColor = Color.Green
    End Sub

    'For Another Another Click Event
    Function buttontag(sender As String)
        Dim saveme As String = sender
        Dim butts As Button
        butts = Me.Controls(saveme)
        Return (butts.Tag)
    End Function

    'For Click Event
    Protected Sub buttons_click(sender As Object, e As EventArgs)
        Dim simpan As String = CType(sender, Button).Name
        If CType(sender, Button).BackColor = Color.Red Then
            MessageBox.Show("Occupied", "Notice", MessageBoxButtons.OK, MessageBoxIcon.None)
        Else
            If MessageBox.Show("Are you sure?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.None) = DialogResult.Yes Then
                Dim connect As New MySqlConnection(AskDatabase.ConnStringFix)
                Dim command As New MySqlCommand
                Dim query As String
                Dim adapt As New MySqlDataAdapter
                Dim dts As New DataTable

                If MultipleSelection.Checked = True Then
                    If SeatChooseBox.text <> String.Empty Then
                        Try
                            connect.Open()
                            Dim checker As New Boolean
                            Dim butsname As String = CType(sender, Button).Name
                            checker = True
                            seatchosencount = SeatChooseBox.Text

                            Dim buttonname(seatchosencount) As String
                            Dim x, y As Integer

                            seatschosen = CType(sender, Button).Tag
                            x = butsname.Substring(0, butsname.IndexOf("_"))
                            y = butsname.Substring(butsname.IndexOf("_") + 1, butsname.Length - butsname.IndexOf("_") - 1)
                            temposeat = Convert.ToInt32(seatschosen.Substring(seatschosen.Length - 2))

                            'Check seats for checker
                            For i = 1 To seatchosencount
                                buttonname(i) = x.ToString + "_" + y.ToString

                                query = "SELECT seat_status FROM seat WHERE theatre_id = '" + theatre + "' AND screening_id = '" + screening + "' AND film_id = '" + film + "' AND seat_id = '" + buttontag(buttonname(i)).ToString + "'"

                                'Button Names
                                dts.Clear()
                                command = New MySqlCommand(query, connect)
                                adapt = New MySqlDataAdapter(command)
                                adapt.Fill(dts)
                                If dts.Rows(0).Item(0) <> 1 Then
                                    checker = False
                                    i = 99999
                                Else
                                    temposeat += 1
                                End If
                                If x >= 8 Then
                                    x = 1
                                    If y >= seatykeepcount Then
                                        y = 1
                                    Else
                                        y += 1

                                    End If
                                Else
                                    x += 1
                                End If
                            Next

                            'Pass The Checker and ready to go
                            If checker = True Then
                                For i = 1 To seatchosencount
                                    query = "UPDATE seat SET seat_status = '0' WHERE seat_id = '" + buttontag(buttonname(i)).ToString + "' AND theatre_id = '" + theatre + "' AND screening_id = '" + screening + "' AND film_id = '" + film + "'"
                                    command = New MySqlCommand(query, connect)
                                    command.ExecuteNonQuery()
                                    buttonmultiples(buttonname(i))
                                Next
                                tickets += seatchosencount
                            Else
                                MessageBox.Show("Some Already Booked", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            End If

                            connect.Close()
                        Catch ex As Exception
                            connect.Close()
                            MsgBox(ex.Message)
                        End Try
                    Else
                        MessageBox.Show("Chosen Multiple Seats Empty", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Else
                    CType(sender, Button).BackColor = Color.Green
                    Try
                        connect.Open()

                        tickets += 1
                        query = "UPDATE seat SET seat_status = '0' WHERE seat_id = '" + CType(sender, Button).Tag + "' AND theatre_id = '" + theatre + "' AND screening_id = '" + screening + "' AND film_id = '" + film + "'"
                        command = New MySqlCommand(query, connect)
                        command.ExecuteNonQuery()

                        MessageBox.Show("Success", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        connect.Close()
                    Catch ex As Exception
                        connect.Close()
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub buttonx_Click(sender As Object, e As EventArgs) Handles buttonx.Click
        TimeSelection.Show()
        Me.Close()
    End Sub

    Private Sub buttoncheck_Click(sender As Object, e As EventArgs) Handles buttoncheck.Click
        ReceiptFormvb.Show()
        Me.Hide()
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Me.Close()
        TimeSelection.Show()
        TimeSelection.loadin()
    End Sub

    Private Sub MultipleSelection_CheckedChanged(sender As Object, e As EventArgs) Handles MultipleSelection.CheckedChanged
        If MultipleSelection.checked = True Then
            seatchooselabel.Visible = True
            SeatChooseBox.Visible = True
        Else
            seatchooselabel.Visible = False
            SeatChooseBox.Visible = False
        End If
    End Sub
End Class