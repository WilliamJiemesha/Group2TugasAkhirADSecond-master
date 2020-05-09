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
    Dim count As Integer
    Public tickets As Integer


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


            Dim connect As New MySqlConnection("datasource=127.0.0.1;port=3308;username=root;password=;database=movie_theatre")
            Dim command As New MySqlCommand
            Dim adapt As New MySqlDataAdapter
            Dim query As String
            Dim dw As New DataTable
            screening = TimeSelection.Screening
            theatre = TimeSelection.Theatre
            seat_count = 24
            seat_count_y = seat_count / 8

            'Simulation Screen
            buttons = New Button
            With buttons
                .Parent = Me
                .Width = 200
                .Height = 50
                .Location = New Point(200, 0)
                .BackColor = Color.Black
            End With

            query = "SELECT seat_id, seat_status FROM seat WHERE theatre_id = '" + theatre + "' AND screening_id = '" + screening + "'"
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
                        .Name = markx + "_" + marky 'JANGAN LUPA TAMBAH ID THEATRE DAN KODE UNTUK MERAH DAN APA GITU
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



    'For Click Event
    Protected Sub buttons_click(sender As Object, e As EventArgs)
        Dim simpan As String = CType(sender, Button).Name
        If CType(sender, Button).BackColor = Color.Red Then
            MessageBox.Show("Occupied", "Notice", MessageBoxButtons.OK, MessageBoxIcon.None)
        Else
            If MessageBox.Show("Are you sure?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.None) = DialogResult.Yes Then
                CType(sender, Button).BackColor = Color.Green
                Dim connect As New MySqlConnection("datasource=127.0.0.1;port=3308;username=root;password=;database=movie_theatre")
                Dim command As New MySqlCommand
                Dim query As String
                Try
                    connect.Open()

                    tickets += 1
                    query = "UPDATE seat SET seat_status = '0' WHERE seat_id = '" + CType(sender, Button).Tag + "' AND theatre_id = '" + theatre + "' AND screening_id = '" + screening + "'"
                    command = New MySqlCommand(query, connect)
                    command.ExecuteNonQuery()

                    MessageBox.Show("Success", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    connect.Close()
                Catch ex As Exception
                    connect.Close()
                End Try
            End If
        End If
    End Sub
End Class