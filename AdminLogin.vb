Imports MySql.Data.MySqlClient
Public Class AdminLogin
    Private Sub Homebutton_Click(sender As Object, e As EventArgs) Handles Homebutton.Click
        Me.Close()
        Selection.Show()
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim connect As New MySqlConnection("datasource=127.0.0.1;port=3308;username=root;password=;database=movie_theatre")
        Dim command As New MySqlCommand
        Dim adapt As New MySqlDataAdapter
        Dim dt, passcheck As New DataTable
        Dim query, checker, user, pass As String

        Try
            connect.Open()
            dt.Clear()
            query = "SELECT * FROM administration WHERE username = '" + usertextbox.Text + "'"
            command = New MySqlCommand(query, connect)
            adapt = New MySqlDataAdapter(command)
            adapt.Fill(dt)

            If dt.Rows.Count = 0 Then
                errors()
            Else
                For i = 0 To dt.Rows.Count - 1
                    user = dt.Rows(i).Item(0)
                    If user = usertextbox.Text.ToLower Then
                        query = "SELECT password FROM administration WHERE username = '" + user + "'"
                        command = New MySqlCommand(query, connect)
                        adapt = New MySqlDataAdapter(command)
                        adapt.Fill(passcheck)
                        If passcheck.Rows(0).Item(0) = passwordtextbox.Text Then
                            MainFormvb.Show()
                            Me.Hide()
                        Else
                            errors()
                        End If
                    End If
                Next
            End If
            connect.Close()
        Catch ex As Exception
            connect.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub errors()
        Me.Hide()
        MessageBoxs.ErrorText.Text = "Wrong Username or Password"
        MessageBoxs.ErrorText.Tag = "Admin"
        MessageBoxs.Show()
    End Sub
End Class