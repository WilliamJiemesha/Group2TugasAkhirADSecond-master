Imports MySql.Data.MySqlClient
Public Class AskDatabase
    Dim connect As New MySqlConnection
    Dim query, connstring As String
    Public ConnStringFix, filepath As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        LoadingForm.Close()
    End Sub

    Private Sub DeviceButton_Click(sender As Object, e As EventArgs) Handles DeviceButton.Click
        If DeviceBox.Text <> "" Then
            Try
                connect.Open()

                Dim command As New MySqlCommand
                Dim adapt As New MySqlDataAdapter
                Dim dt As New DataTable
                query = "SELECT filepath FROM device WHERE device_id = '" + DeviceBox.SelectedValue.ToString + "'"
                command = New MySqlCommand(query, connect)
                adapt = New MySqlDataAdapter(command)
                adapt.Fill(dt)

                filepath = dt.Rows(0).Item(0)
                Me.Hide()
                Selection.Show()

                connect.Close()
            Catch ex As Exception
                connect.Close()
            End Try
        Else
            MessageBox.Show("Device is Empty", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub EnterButton_Click(sender As Object, e As EventArgs) Handles EnterButton.Click
        Try
            connect = New MySqlConnection("datasource = " + DatasourceBox.Text + ";port=" + PortBox.Text + ";username=" + Usernamebox.Text + ";password=" + PasswordBox.Text + ";database=movie_theatre")
            connect.Open()

            ConnStringFix = "datasource=" + DatasourceBox.Text + ";port=" + PortBox.Text + ";username=" + Usernamebox.Text + ";password=" + PasswordBox.Text + ";database=movie_theatre"
            Dim command As New MySqlCommand
            Dim adapt As New MySqlDataAdapter
            Dim dt As New DataTable
            query = "SELECT device_id, device_name FROM device"
            command = New MySqlCommand(query, connect)
            adapt = New MySqlDataAdapter(command)
            adapt.Fill(dt)
            DeviceBox.DataSource = dt
            DeviceBox.DisplayMember = "device_name"
            DeviceBox.ValueMember = "device_id"

            EnterButton.Enabled = False
            DeviceButton.Visible = True
            DeviceBox.Visible = True
            DeviceLabel.Visible = True
            DeviceInfo.Visible = True

            connect.Close()
            MessageBox.Show("Success Connecting to The Server", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            connect.Close()
            MessageBox.Show("Error Input, Try Again", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
End Class