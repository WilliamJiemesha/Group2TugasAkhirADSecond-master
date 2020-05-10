Imports MySql.Data.MySqlClient
Imports System.IO
Public Class MainFormvb
    Dim connect As New MySqlConnection(AskDatabase.ConnStringFix)
    Dim command As New MySqlCommand
    Dim adapt As New MySqlDataAdapter
    Dim query As String

    'Add Theatre
    Dim dt, dw As New DataTable
    Dim id As String


    'Max Value Accepted for ID Datatype that is VARCHAR(10)
    Dim idvalue As Integer = 2

    Dim name As String
    Dim seat As String
    Dim status As String = "Available"
    Dim delete As String

    'Edit Theatre
    Dim keeper As Boolean = True
    Dim dx, dbdb As New DataTable

    'Add Film
    Dim dt0, dt1, dt2, khusus As New DataTable
    Dim ids As String
    Dim idvalues As Integer = 2
    Dim showthem As Boolean = False

    'Edit Film
    Dim idp As String
    Dim dtp, dt1p, dt2p As New DataTable

    'Add Schedule
    Dim adsc1, adsc2, adsc3 As New DataTable
    Dim idtheatreadsc, idfilmadsc, idscreeningadsc As String
    Dim datas As New DataTable
    Dim dtsch As New DataTable

    'Edit schedule
    Dim esdt As New DataTable


    'Exit Button
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Selection.Show()
        AdminLogin.Close()
        Me.Close()
    End Sub


    'Uncheck
    Private Sub uncheck()
        Addtheatre.Checked = False
        EditTheatre.Checked = False
        AddFilm.Checked = False
        EditFilm.Checked = False
        AddSchedule.Checked = False
        EditSchedule.Checked = False
    End Sub

    'Load form
    Private Sub MainFormvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Add Theatre
        PanelAddTheatre.Width = 1280
        PanelAddTheatre.Height = 620
        PanelAddTheatre.Location = New Point(0, 100)
        'Edit Theatre
        PanelEditTheatre.Width = 1280
        PanelEditTheatre.Height = 620
        PanelEditTheatre.Location = New Point(0, 100)

        'Add Film
        PanelAddFilm.Width = 1280
        PanelAddFilm.Height = 620
        PanelAddFilm.Location = New Point(0, 100)

        'Edit Film
        PanelEditFilm.Width = 1280
        PanelEditFilm.Height = 620
        PanelEditFilm.Location = New Point(0, 100)

        'Add Schedule
        PanelAddSchedule.Width = 1280
        PanelAddSchedule.Height = 620
        PanelAddSchedule.Location = New Point(0, 100)

        'Edit Schedule
        PanelEditSchedule.Width = 1280
        PanelEditSchedule.Height = 620
        PanelEditSchedule.Location = New Point(0, 100)

        'Report Panel
        ReportPanel.Width = 1280
        ReportPanel.Height = 620
        ReportPanel.Location = New Point(0, 100)

        panelshide()
    End Sub

    'Neutralize
    Private Sub panelshide()
        PanelAddTheatre.Visible = False
        PanelEditTheatre.Visible = False
        PanelAddFilm.Visible = False
        PanelEditFilm.Visible = False
        PanelAddSchedule.Visible = False
        PanelEditSchedule.Visible = False
        ReportPanel.Visible = False
    End Sub




    Private Sub ReportButton_CheckedChanged(sender As Object, e As EventArgs) Handles ReportButton.CheckedChanged
        If ReportButton.Checked = True Then
            panelshide()
            uncheck()
            ReportPanel.Visible = True
        End If
    End Sub













    Private Sub AddTheatreButton_Click(sender As Object, e As EventArgs) Handles addtheatrebutton.Click
        If addtheatretextbox.Text <> "" Then

            If MessageBox.Show("Are you sure?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                Try
                    connect.Open()
                    '
                    dw.Clear()
                    'For Structure of Database Tables 
                    query = "SELECT * FROM theatre"
                    command = New MySqlCommand(query, connect)
                    adapt = New MySqlDataAdapter(command)
                    adapt.Fill(dw)

                    'Add Data to Database Part 1, Declare Variables and Prepare for Insertion
                    If dt.Rows.Count < 9 Then
                        id = "T" + String.Join("", Enumerable.Repeat("0", idvalue)) + (dw.Rows.Count + 1).ToString
                    ElseIf dt.Rows.Count < 99 Then
                        id = "T" + String.Join("", Enumerable.Repeat("0", idvalue - 1)) + (dw.Rows.Count + 1).ToString
                    ElseIf dt.Rows.Count < 999 Then
                        id = "T" + String.Join("", Enumerable.Repeat("0", idvalue - 2)) + (dw.Rows.Count + 1).ToString
                    ElseIf dt.Rows.Count < 9999 Then
                        id = "T" + String.Join("", Enumerable.Repeat("0", idvalue - 3)) + (dw.Rows.Count + 1).ToString
                    ElseIf dt.Rows.Count < 99999 Then
                        id = "T" + String.Join("", Enumerable.Repeat("0", idvalue - 4)) + (dw.Rows.Count + 1).ToString
                    End If
                    name = addtheatretextbox.Text
                    seat = addtheatreseatbox.Text.ToString
                    delete = 0

                    'Adding Data/Inserting Datas into Database
                    query = "INSERT INTO theatre VALUES ('" + id + "', '" + name + "', '" + seat + "', '" + status + "', '" + delete + "')"
                    command = New MySqlCommand(query, connect)
                    command.ExecuteNonQuery()
                    connect.Close()

                    'Close Form
                    MessageBox.Show("Executed Successfully!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    showdgvaddtheatre()
                Catch ex As Exception
                    connect.Close()
                    MsgBox(ex.Message)
                End Try
            End If
        Else
            MessageBox.Show("Data is not completed", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub AvailableButton_CheckedChanged(sender As Object, e As EventArgs)
        If addtheatrestatusbox.Text = "Available" Then
            status = "Available"
        Else
            status = "Not Available"
        End If
    End Sub

    Private Sub showdgvaddtheatre()
        Try
            connect.Open()
            dt.Clear()
            addtheatredatashown.Refresh()
            query = "SELECT theatre_id, theatre_name, theatre_status, seat_ammount, IF(delete_status = '1', 'Scheduled for Deletion', 'Not Scheduled for Deletion') `Delete Status` FROM theatre"
            command = New MySqlCommand(query, connect)
            adapt = New MySqlDataAdapter(command)
            adapt.Fill(dt)
            addtheatredatashown.DataSource = dt

            connect.Close()
        Catch ex As Exception
            connect.Close()
        End Try
    End Sub

    'This is load for addtheatre
    Private Sub Addtheatre_CheckedChanged(sender As Object, e As EventArgs) Handles Addtheatre.CheckedChanged
        If Addtheatre.Checked = True Then
            showdgvaddtheatre()
            panelshide()
            PanelAddTheatre.Visible = True
            uncheck()
        End If
    End Sub


    'Edit Theatre
    Private Sub DataShown_CellClicks(sender As Object, e As DataGridViewCellEventArgs) Handles edittheatredatashown.CellClick
        Try
            edittheatreidbox.Text = edittheatredatashown.Rows(edittheatredatashown.CurrentRow.Index).Cells(0).Value.ToString
            edittheatrenamebox.Text = edittheatredatashown.Rows(edittheatredatashown.CurrentRow.Index).Cells(1).Value.ToString
            edittheatreseatbox.Text = edittheatredatashown.Rows(edittheatredatashown.CurrentRow.Index).Cells(2).Value
            edittheatrestatusbox.Text = edittheatredatashown.Rows(edittheatredatashown.CurrentRow.Index).Cells(3).Value.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub EditButton_Clicks(sender As Object, e As EventArgs) Handles edittheatreeditbutton.Click
        If edittheatreidbox.Text = "" Or edittheatrenamebox.Text = "" Then
            MessageBox.Show("Some are still empty", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            connect.Open()
            query = "UPDATE theatre SET theatre_name = '" + edittheatrenamebox.Text + "', seat_ammount = '" + edittheatreseatbox.Text + "', theatre_status = '" + edittheatrestatusbox.Text + "' WHERE theatre_id = '" + edittheatreidbox.Text + "'"
            command = New MySqlCommand(query, connect)
            command.ExecuteNonQuery()
            dx.Clear()
            edittheatredatashown.Refresh()
            query = "SELECT theatre_id `Theatre ID`, theatre_name `Theatre Name`, seat_ammount `Seat Number`, theatre_status `Status`, IF(delete_status = 1, 'Scheduled for Deletion', 'Not Scheduled for Deletion') `Delete` FROM theatre"
            command = New MySqlCommand(query, connect)
            adapt = New MySqlDataAdapter(command)
            adapt.Fill(dx)

            edittheatredatashown.DataSource = dx

            connect.Close()
        End If
    End Sub


    'This is load for Edit Theatre
    Private Sub edittheatre_load(sender As Object, e As EventArgs) Handles EditTheatre.CheckedChanged
        If EditTheatre.Checked = True Then
            panelshide()
            PanelEditTheatre.Visible = True
            uncheck()
            Try
                keeper = True
                connect.Open()
                dx.Clear()
                query = "SELECT theatre_id `Theatre ID`, theatre_name `Theatre Name`, seat_ammount `Seat Number`, theatre_status `Status`, IF(delete_status = 1, 'Scheduled for Deletion', 'Not Scheduled for Deletion') `Delete` FROM theatre WHERE delete_status = 0"
                command = New MySqlCommand(query, connect)
                adapt = New MySqlDataAdapter(command)
                adapt.Fill(dx)

                edittheatredatashown.DataSource = dx

                connect.Close()
            Catch ex As Exception
                connect.Close()
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub executedelete_Click(sender As Object, e As EventArgs)
        Try
            'EXECUTE DELETE
            If MessageBox.Show("Are you sure you want to execute all scheduled deletion for theatre? You cant undo after you do this.", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                connect.Open()

                query = "DELETE FROM theatre WHERE delete_status = 1"
                command = New MySqlCommand(query, connect)
                command.ExecuteNonQuery()

                dx.Clear()
                edittheatredatashown.Refresh()
                If keeper = True Then
                    query = "SELECT theatre_id `Theatre ID`, theatre_name `Theatre Name`, seat_ammount `Seat Number`, theatre_status `Status`, IF(delete_status = 1, 'Scheduled for Deletion', 'Not Scheduled for Deletion') `Delete` FROM theatre"

                Else
                    query = "SELECT theatre_id `Theatre ID`, theatre_name `Theatre Name`, seat_ammount `Seat Number`, theatre_status `Status`, IF(delete_status = 1, 'Scheduled for Deletion', 'Not Scheduled for Deletion') `Delete` FROM theatre WHERE delete_status = 0"

                End If
                command = New MySqlCommand(query, connect)
                adapt = New MySqlDataAdapter(command)
                adapt.Fill(dx)
                edittheatredatashown.DataSource = dx


                connect.Close()
            End If

        Catch ex As Exception
            connect.Close()
        End Try
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles edittheatredelete.Click
        Try
            If edittheatreidbox.Text <> "" Then
                connect.Open()
                query = "UPDATE theatre SET delete_status = 1 WHERE theatre_id = '" + edittheatreidbox.Text + "'"
                command = New MySqlCommand(query, connect)
                command.ExecuteNonQuery()
                MessageBox.Show("Success", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                dx.Clear()
                edittheatredatashown.Refresh()
                If keeper = True Then
                    query = "SELECT theatre_id `Theatre ID`, theatre_name `Theatre Name`, seat_ammount `Seat Number`, theatre_status `Status`, IF(delete_status = 1, 'Scheduled for Deletion', 'Not Scheduled for Deletion') `Delete` FROM theatre"
                Else
                    query = "SELECT theatre_id `Theatre ID`, theatre_name `Theatre Name`, seat_ammount `Seat Number`, theatre_status `Status`, IF(delete_status = 1, 'Scheduled for Deletion', 'Not Scheduled for Deletion') `Delete` FROM theatre WHERE delete_status = 0"
                End If
                command = New MySqlCommand(query, connect)
                adapt = New MySqlDataAdapter(command)
                adapt.Fill(dx)
                edittheatredatashown.DataSource = dx

                connect.Close()
            Else

            End If
        Catch ex As Exception
            connect.Close()
        End Try
    End Sub

    Private Sub RestoreButton_Clics(sender As Object, e As EventArgs) Handles edittheatrerestore.Click
        Try
            If edittheatreidbox.Text <> "" Then
                connect.Open()
                query = "UPDATE theatre SET delete_status = 0 WHERE theatre_id = '" + edittheatreidbox.Text + "'"
                command = New MySqlCommand(query, connect)
                command.ExecuteNonQuery()
                MessageBox.Show("Success", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                dx.Clear()
                edittheatredatashown.Refresh()
                If keeper = True Then
                    query = "SELECT theatre_id `Theatre ID`, theatre_name `Theatre Name`, seat_ammount `Seat Number`, theatre_status `Status`, IF(delete_status = 1, 'Scheduled for Deletion', 'Not Scheduled for Deletion') `Delete` FROM theatre"

                Else
                    query = "SELECT theatre_id `Theatre ID`, theatre_name `Theatre Name`, seat_ammount `Seat Number`, theatre_status `Status`, IF(delete_status = 1, 'Scheduled for Deletion', 'Not Scheduled for Deletion') `Delete` FROM theatre WHERE delete_status = 0"

                End If
                command = New MySqlCommand(query, connect)
                adapt = New MySqlDataAdapter(command)
                adapt.Fill(dx)
                edittheatredatashown.DataSource = dx

                connect.Close()
            Else

            End If
        Catch ex As Exception
            connect.Close()
        End Try
    End Sub



    Private Sub ShowHide_Click(sender As Object, e As EventArgs) Handles edittheatreshow.Click
        Try
            connect.Open()


            dx.Clear()
            edittheatredatashown.Refresh()
            If keeper = True Then
                keeper = False
            Else
                keeper = True
            End If
            If keeper = True Then
                query = "SELECT theatre_id `Theatre ID`, theatre_name `Theatre Name`, seat_ammount `Seat Number`, theatre_status `Status`, IF(delete_status = 1, 'Scheduled for Deletion', 'Not Scheduled for Deletion') `Delete` FROM theatre"
            Else
                query = "SELECT theatre_id `Theatre ID`, theatre_name `Theatre Name`, seat_ammount `Seat Number`, theatre_status `Status`, IF(delete_status = 1, 'Scheduled for Deletion', 'Not Scheduled for Deletion') `Delete` FROM theatre WHERE delete_status = 0"
            End If
            command = New MySqlCommand(query, connect)
            adapt = New MySqlDataAdapter(command)
            adapt.Fill(dx)

            edittheatredatashown.DataSource = dx

            connect.Close()
        Catch ex As Exception
            connect.Close()
            MsgBox(ex.Message)
        End Try
    End Sub


    'This is for Add Film
    Private Sub AddFilm_CheckedChanged(sender As Object, e As EventArgs) Handles AddFilm.CheckedChanged
        If AddFilm.Checked = True Then
            ForTable()
            forPG()
            forGenre()
            panelshide()
            PanelAddFilm.Visible = True
            uncheck()
        End If
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles addfilmaddbutton.Click
        Try
            If addfilmfilmbox.Text <> "" Then
                checkRows()
                connect.Open()
                query = "INSERT INTO film VALUES ('" + ids.ToString + "', '" + addfilmfilmbox.Text + "', '" + addfilmratingbox.EditValue.ToString + "', '" + addfilmgenrebox.EditValue.ToString + "', '" + addfilmdatebox.Text + "', '" + addfilmdurationbox.Value.ToString + "', '" + addfilmstatusbox.Text + "', '0')"
                command = New MySqlCommand(query, connect)
                command.ExecuteNonQuery()
                connect.Close()


                'New
                Dim fd As OpenFileDialog = New OpenFileDialog()
                Dim strFileName As String
                Dim strFilePath As String
                Dim filename As String
                fd.Title = "Open File Dialog"
                fd.InitialDirectory = "C:\"
                fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
                fd.FilterIndex = 2
                fd.RestoreDirectory = True


                If fd.ShowDialog() = DialogResult.OK Then
                    strFileName = fd.FileName
                    strFilePath = System.IO.Path.GetDirectoryName(fd.FileName)
                End If

                filename = Path.GetFileName(strFileName)
                If File.Exists(strFileName) Then
                    Dim destinationPath As String = Path.Combine(AskDatabase.filepath, filename)
                    If File.Exists(destinationPath) Then
                        MessageBox.Show("File name already exists", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        File.Copy(strFileName, destinationPath, False)
                        MsgBox("File Moved")
                    End If
                Else
                    MsgBox("File Not move")
                End If

                'Later Change
                My.Computer.FileSystem.RenameFile(AskDatabase.filepath + "\" + filename, ids.ToString + ".jpg")
                ForTable()
            End If
        Catch ex As Exception
            connect.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub showbutton_Clicks(sender As Object, e As EventArgs) Handles addfilmshowbutton.Click
        If showthem = True Then
            showthem = False
        Else
            showthem = True
        End If
        ForTable()
    End Sub

    Private Sub forPG()
        Try
            connect.Open()

            dt1.Clear()
            query = "SELECT * FROM pg"
            command = New MySqlCommand(query, connect)
            adapt = New MySqlDataAdapter(command)
            adapt.Fill(dt1)

            addfilmratingbox.Properties.DataSource = dt1
            addfilmratingbox.Properties.DisplayMember = "rating"
            addfilmratingbox.Properties.ValueMember = "pg_id"

            connect.Close()
        Catch ex As Exception
            connect.Close()
        End Try
    End Sub
    Private Sub forGenre()
        Try
            connect.Open()

            dt2.Clear()
            query = "SELECT * FROM genre"
            command = New MySqlCommand(query, connect)
            adapt = New MySqlDataAdapter(command)
            adapt.Fill(dt2)

            addfilmgenrebox.Properties.DataSource = dt2
            addfilmgenrebox.Properties.DisplayMember = "genre_name"
            addfilmgenrebox.Properties.ValueMember = "genre_id"

            connect.Close()
        Catch ex As Exception
            connect.Close()
        End Try
    End Sub
    Private Sub ForTable()
        Try
            connect.Open()

            dt0.Clear()
            addfilmdatashown.Refresh()

            If showthem = False Then
                query = "SELECT * FROM film WHERE delete_status = 0"
            Else
                query = "SELECT * FROM film"
            End If

            command = New MySqlCommand(query, connect)
            adapt = New MySqlDataAdapter(command)
            adapt.Fill(dt0)

            addfilmdatashown.DataSource = dt0
            connect.Close()
        Catch ex As Exception
            connect.Close()
        End Try
    End Sub


    Private Sub checkRows()
        Try
            khusus.Clear()
            connect.Open()
            query = "SELECT * FROM film WHERE release_date LIKE '" + addfilmdatebox.SelectedText.Substring(0, 4) + "%'"
            command = New MySqlCommand(query, connect)
            adapt = New MySqlDataAdapter(command)
            adapt.Fill(khusus)

            If khusus.Rows.Count < 9 Then
                ids = "F" + addfilmdatebox.Text.Substring(0, 4) + String.Join("", Enumerable.Repeat("0", idvalue)).ToString + (khusus.Rows.Count + 1).ToString
            ElseIf khusus.Rows.Count < 99 Then
                ids = "F" + addfilmdatebox.Text.Substring(0, 4) + String.Join("", Enumerable.Repeat("0", idvalue - 1)).ToString + (khusus.Rows.Count + 1).ToString
            ElseIf khusus.Rows.Count < 999 Then
                ids = "F" + addfilmdatebox.Text.Substring(0, 4) + String.Join("", Enumerable.Repeat("0", idvalue - 2)).ToString + (khusus.Rows.Count + 1).ToString
            End If

            connect.Close()
        Catch ex As Exception
            connect.Close()
        End Try
    End Sub

    'Edit Film
    Private Sub EditFilm_CheckedChanged(sender As Object, e As EventArgs) Handles EditFilm.CheckedChanged
        If EditFilm.Checked = True Then
            panelshide()
            paneleditfilm.Visible = True
            uncheck()
            ForTables()
            forGenres()
            forPGs()
        End If
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles editfilmeditbutton.Click
        Try
            If editfilmfilmbox.Text <> "" Then
                connect.Open()
                query = "UPDATE film SET film_name = '" + editfilmfilmbox.Text + "', pg_id = '" + editfilmratingbox.EditValue.ToString + "', genre_id = '" + editfilmgenrebox.EditValue.ToString + "', release_date = '" + editfilmdatebox.Text + "', duration = '" + editfilmdurationbox.Text.ToString + "', film_status = '" + editfilmstatusbox.Text.ToString + "'  WHERE film_id = '" + idp + "'"
                command = New MySqlCommand(query, connect)
                command.ExecuteNonQuery()
                connect.Close()
                ForTables()
                forGenres()
                MessageBox.Show("Success", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            connect.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub showbutton_Click(sender As Object, e As EventArgs) Handles editfilmdeletebutton.Click
        Try
            If MessageBox.Show("Are you Sure?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                connect.Open()

                If idp <> "" Then
                    query = "UPDATE film SET delete_status = 1 WHERE film_id = '" + idp + "'"
                    command = New MySqlCommand(query, connect)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Success", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    MessageBox.Show("No Items Selected", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
                connect.Close()
            End If
        Catch ex As Exception
            connect.Close()
        End Try


        ForTables()
    End Sub
    Private Sub DataShown_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles editfilmdatashown.CellClick
        Try
            editfilmfilmbox.Text = editfilmdatashown.Rows(editfilmdatashown.CurrentRow.Index).Cells(1).Value.ToString
            editfilmgenrebox.Text = editfilmdatashown.Rows(editfilmdatashown.CurrentRow.Index).Cells(3).Value.ToString
            editfilmratingbox.Text = editfilmdatashown.Rows(editfilmdatashown.CurrentRow.Index).Cells(2).Value.ToString
            editfilmdatebox.Text = editfilmdatashown.Rows(editfilmdatashown.CurrentRow.Index).Cells(4).Value.ToString
            editfilmdurationbox.Value = editfilmdatashown.Rows(editfilmdatashown.CurrentRow.Index).Cells(5).Value.ToString
            editfilmstatusbox.Text = editfilmdatashown.Rows(editfilmdatashown.CurrentRow.Index).Cells(6).Value.ToString
            idp = editfilmdatashown.Rows(editfilmdatashown.CurrentRow.Index).Cells(0).Value.ToString
            editfilmidnow.Text = editfilmdatashown.Rows(editfilmdatashown.CurrentRow.Index).Cells(0).Value.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RestoreButton_Click(sender As Object, e As EventArgs) Handles editfilmrestorebutton.Click
        Try
            If MessageBox.Show("Are you Sure?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                connect.Open()

                If idp <> "" Then
                    query = "UPDATE film SET delete_status = 0 WHERE film_id = '" + id + "'"
                    command = New MySqlCommand(query, connect)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Success", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    MessageBox.Show("No Items Selected", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If

                connect.Close()
            End If
        Catch ex As Exception
            connect.Close()
        End Try


        ForTables()
    End Sub

    Private Sub forPGs()
        Try
            connect.Open()

            dt1p.Clear()
            query = "SELECT * FROM pg"
            command = New MySqlCommand(query, connect)
            adapt = New MySqlDataAdapter(command)
            adapt.Fill(dt1p)

            editfilmratingbox.Properties.DataSource = dt1p
            editfilmratingbox.Properties.DisplayMember = "rating"
            editfilmratingbox.Properties.ValueMember = "pg_id"

            connect.Close()
        Catch ex As Exception
            connect.Close()
        End Try
    End Sub

    Private Sub forGenres()
        Try
            connect.Open()

            dt2p.Clear()
            query = "SELECT * FROM genre"
            command = New MySqlCommand(query, connect)
            adapt = New MySqlDataAdapter(command)
            adapt.Fill(dt2p)

            editfilmgenrebox.Properties.DataSource = dt2p
            editfilmgenrebox.Properties.DisplayMember = "genre_name"
            editfilmgenrebox.Properties.ValueMember = "genre_id"

            connect.Close()
        Catch ex As Exception
            connect.Close()
        End Try
    End Sub

    Private Sub ForTables()
        Try
            connect.Open()

            dtp.Clear()
            editfilmdatashown.Refresh()

            query = "SELECT f.film_id, f.film_name, p.rating, g.genre_name, f.release_date, f.duration, f.film_status, f.delete_status FROM film f,genre g, pg p WHERE p.pg_id = f.pg_id AND f.genre_id = g.genre_id"

            command = New MySqlCommand(query, connect)
            adapt = New MySqlDataAdapter(command)
            adapt.Fill(dtp)

            editfilmdatashown.DataSource = dtp
            connect.Close()
        Catch ex As Exception
            connect.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    'This is for Schedule Add
    Private Sub CheckButton5_CheckedChanged(sender As Object, e As EventArgs) Handles AddSchedule.CheckedChanged
        If AddSchedule.Checked = True Then
            Try
                panelshide()
                PanelAddSchedule.Visible = True
                uncheck()
                connect.Open()
                'Theatre
                adsc1.Clear()
                query = "SELECT * FROM theatre"
                command = New MySqlCommand(query, connect)
                adapt = New MySqlDataAdapter(command)
                adapt.Fill(adsc1)

                'Film
                adsc2.Clear()
                query = "SELECT * FROM film"
                command = New MySqlCommand(query, connect)
                adapt = New MySqlDataAdapter(command)
                adapt.Fill(adsc2)

                'Screening
                adsc3.Clear()
                query = "SELECT * FROM screening"
                command = New MySqlCommand(query, connect)
                adapt = New MySqlDataAdapter(command)
                adapt.Fill(adsc3)

                addscheduledatashowntheatre.DataSource = adsc1
                addscheduledatashownfilm.DataSource = adsc2
                addscheduledatashownscreening.DataSource = adsc3
                connect.Close()
            Catch ex As Exception
                connect.Close()
            End Try
        End If
    End Sub

    'Cell Clicks
    Private Sub addscheduledatashowntheatre_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles addscheduledatashowntheatre.CellClick
        idtheatreadsc = addscheduledatashowntheatre.Rows(addscheduledatashowntheatre.CurrentRow.Index).Cells(0).Value.ToString
        addscheduletheatrebox.Text = addscheduledatashowntheatre.Rows(addscheduledatashowntheatre.CurrentRow.Index).Cells(0).Value.ToString
    End Sub
    Private Sub addscheduledatashownfilm_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles addscheduledatashownfilm.CellClick
        idfilmadsc = addscheduledatashownfilm.Rows(addscheduledatashownfilm.CurrentRow.Index).Cells(0).Value.ToString
        addschedulefilmbox.Text = addscheduledatashownfilm.Rows(addscheduledatashownfilm.CurrentRow.Index).Cells(0).Value.ToString
    End Sub
    Private Sub addscheduledatashownscreening_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles addscheduledatashownscreening.CellClick
        idscreeningadsc = addscheduledatashownscreening.Rows(addscheduledatashownscreening.CurrentRow.Index).Cells(0).Value.ToString
        addschedulescreeningbox.Text = addscheduledatashownscreening.Rows(addscheduledatashownscreening.CurrentRow.Index).Cells(0).Value.ToString
    End Sub

    Private Sub checkaddschedulebutton(sender As Object, e As EventArgs) Handles addscheduleschedulebutton.Click

        If addscheduletheatrebox.Text <> "" And addschedulefilmbox.Text <> "" And addschedulescreeningbox.Text <> "" Then

            Try
                connect.Open()

                datas.Clear()
                query = "SELECT * FROM dtheatre WHERE theatre_id = '" + idtheatreadsc + "' AND screening_id = '" + idscreeningadsc + "'"
                command = New MySqlCommand(query, connect)
                adapt = New MySqlDataAdapter(command)
                adapt.Fill(datas)


                If datas.Rows.Count = 0 Then
                    query = "INSERT INTO dtheatre VALUES ('" + idtheatreadsc + "','" + idscreeningadsc + "','" + idfilmadsc + "')"
                    command = New MySqlCommand(query, connect)
                    command.ExecuteNonQuery()

                    'Seats time
                    dtsch.Clear()
                    query = "SELECT seat_ammount FROM theatre WHERE theatre_id = '" + idtheatreadsc + "';"
                    command = New MySqlCommand(query, connect)
                    adapt = New MySqlDataAdapter(command)
                    adapt.Fill(dtsch)

                    Dim idseat As String
                    For i = 1 To dtsch.Rows(0).Item(0)
                        If i < 10 Then
                            idseat = "D0" + i.ToString
                        ElseIf i < 100 Then
                            idseat = "D" + i.ToString
                        End If

                        query = "INSERT INTO seat VALUES ('" + idseat + "','1','" + idtheatreadsc + "','" + idscreeningadsc + "', '" + idfilmadsc + "')"
                        command = New MySqlCommand(query, connect)
                        command.ExecuteNonQuery()
                    Next
                    connect.Close()
                    MessageBox.Show("Success", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    MessageBox.Show("Schedule already exists", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    connect.Close()
                End If
            Catch ex As Exception
                connect.Close()
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Data Incomplete", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub




    'This is for Schedule Edit
    Private Sub EditSchedule_CheckedChanged(sender As Object, e As EventArgs) Handles EditSchedule.CheckedChanged
        panelshide()
        uncheck()
        PanelEditSchedule.Visible = True


        esdt.Clear()
        query = "SELECT t.theatre_id `Theatre ID`, t.theatre_name `Theatre Name`, f.film_id `Film ID`, f.film_name `Film Name`, s.screening_id `Screening ID`, s.starting_time `Starting Time` FROM dtheatre d, film f, screening s, theatre t WHERE t.theatre_id = d.theatre_id AND d.film_id = f.film_id AND s.screening_id = d.screening_id"
        command = New MySqlCommand(query, connect)
        adapt = New MySqlDataAdapter(command)
        adapt.Fill(esdt)

        editscheduledatashown.DataSource = esdt
    End Sub

    Private Sub editscheduledatashown_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles editscheduledatashown.CellClick
        editscheduletheatrebox.Text = editscheduledatashown.Rows(editscheduledatashown.CurrentRow.Index).Cells(0).Value.ToString
        editschedulefilmbox.Text = editscheduledatashown.Rows(editscheduledatashown.CurrentRow.Index).Cells(2).Value.ToString
        editschedulescreeningbox.Text = editscheduledatashown.Rows(editscheduledatashown.CurrentRow.Index).Cells(4).Value.ToString
    End Sub

    Private Sub editscheduletrashbutton_Click(sender As Object, e As EventArgs) Handles editscheduletrashbutton.Click
        If editscheduletheatrebox.Text <> "" And editschedulefilmbox.Text <> "" And editschedulescreeningbox.Text <> "" Then
            Try
                connect.Open()

                query = "DELETE FROM dtheatre WHERE screening_id = '" + editschedulescreeningbox.Text + "' AND theatre_id = '" + editscheduletheatrebox.Text + "' AND film_id = '" + editschedulefilmbox.Text + "'"
                command = New MySqlCommand(query, connect)
                command.ExecuteNonQuery()

                query = "DELETE FROM seat WHERE screening_id = '" + editschedulescreeningbox.Text + "' AND theatre_id = '" + editscheduletheatrebox.Text + "'"
                command = New MySqlCommand(query, connect)
                command.ExecuteNonQuery()

                MessageBox.Show("Success", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                esdt.Clear()
                query = "SELECT t.theatre_id `Theatre ID`, t.theatre_name `Theatre Name`, f.film_id `Film ID`, f.film_name `Film Name`, s.screening_id `Screening ID`, s.starting_time `Starting Time` FROM dtheatre d, film f, screening s, theatre t WHERE t.theatre_id = d.theatre_id AND d.film_id = f.film_id AND s.screening_id = d.screening_id"
                command = New MySqlCommand(query, connect)
                adapt = New MySqlDataAdapter(command)
                adapt.Fill(esdt)

                editscheduledatashown.DataSource = esdt

                connect.Close()
            Catch ex As Exception
                connect.Close()
            End Try
        Else
            MessageBox.Show("Data Incomplete", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub FilmReportButton_Click(sender As Object, e As EventArgs) Handles FilmReportButton.Click
        DocumentFilm.Show()
    End Sub

    Private Sub SalesReportButton_Click(sender As Object, e As EventArgs) Handles SalesReportButton.Click
        DocumentSales.Show()
    End Sub

    Private Sub TheatreReportButton_Click(sender As Object, e As EventArgs) Handles TheatreReportButton.Click
        DocumentTheatre.Show()
    End Sub










    'This is for screening edit if we agree to do







End Class