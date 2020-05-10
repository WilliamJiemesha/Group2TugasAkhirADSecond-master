<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AskDatabase
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DatasourceBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PortBox = New System.Windows.Forms.TextBox()
        Me.Usernamebox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PasswordBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EnterButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DeviceBox = New System.Windows.Forms.ComboBox()
        Me.DeviceLabel = New System.Windows.Forms.Label()
        Me.DeviceInfo = New System.Windows.Forms.Label()
        Me.DeviceButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DatasourceBox
        '
        Me.DatasourceBox.Location = New System.Drawing.Point(80, 12)
        Me.DatasourceBox.Name = "DatasourceBox"
        Me.DatasourceBox.Size = New System.Drawing.Size(228, 20)
        Me.DatasourceBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Datasource"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Port"
        '
        'PortBox
        '
        Me.PortBox.Location = New System.Drawing.Point(80, 52)
        Me.PortBox.Name = "PortBox"
        Me.PortBox.Size = New System.Drawing.Size(228, 20)
        Me.PortBox.TabIndex = 3
        '
        'Usernamebox
        '
        Me.Usernamebox.Location = New System.Drawing.Point(80, 92)
        Me.Usernamebox.Name = "Usernamebox"
        Me.Usernamebox.Size = New System.Drawing.Size(228, 20)
        Me.Usernamebox.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Username"
        '
        'PasswordBox
        '
        Me.PasswordBox.Location = New System.Drawing.Point(80, 129)
        Me.PasswordBox.Name = "PasswordBox"
        Me.PasswordBox.Size = New System.Drawing.Size(228, 20)
        Me.PasswordBox.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Password"
        '
        'EnterButton
        '
        Me.EnterButton.Location = New System.Drawing.Point(80, 165)
        Me.EnterButton.Name = "EnterButton"
        Me.EnterButton.Size = New System.Drawing.Size(228, 23)
        Me.EnterButton.TabIndex = 8
        Me.EnterButton.Text = "Test Connection and Submit"
        Me.EnterButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(314, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(211, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Your datasource, ex : '127.0.0.1' (localhost)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(314, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Your port, ex : '3306'"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(314, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Your username. ex : 'root'"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(314, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(251, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Your database password, ex : 'root' or can be empty"
        '
        'DeviceBox
        '
        Me.DeviceBox.FormattingEnabled = True
        Me.DeviceBox.Location = New System.Drawing.Point(80, 194)
        Me.DeviceBox.Name = "DeviceBox"
        Me.DeviceBox.Size = New System.Drawing.Size(228, 21)
        Me.DeviceBox.TabIndex = 13
        Me.DeviceBox.Visible = False
        '
        'DeviceLabel
        '
        Me.DeviceLabel.AutoSize = True
        Me.DeviceLabel.Location = New System.Drawing.Point(14, 202)
        Me.DeviceLabel.Name = "DeviceLabel"
        Me.DeviceLabel.Size = New System.Drawing.Size(41, 13)
        Me.DeviceLabel.TabIndex = 14
        Me.DeviceLabel.Text = "Device"
        Me.DeviceLabel.Visible = False
        '
        'DeviceInfo
        '
        Me.DeviceInfo.AutoSize = True
        Me.DeviceInfo.Location = New System.Drawing.Point(314, 202)
        Me.DeviceInfo.Name = "DeviceInfo"
        Me.DeviceInfo.Size = New System.Drawing.Size(179, 13)
        Me.DeviceInfo.TabIndex = 15
        Me.DeviceInfo.Text = "The device you are using for filepath"
        Me.DeviceInfo.Visible = False
        '
        'DeviceButton
        '
        Me.DeviceButton.Location = New System.Drawing.Point(80, 221)
        Me.DeviceButton.Name = "DeviceButton"
        Me.DeviceButton.Size = New System.Drawing.Size(228, 23)
        Me.DeviceButton.TabIndex = 16
        Me.DeviceButton.Text = "Yes this is my Device"
        Me.DeviceButton.UseVisualStyleBackColor = True
        Me.DeviceButton.Visible = False
        '
        'AskDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 400)
        Me.Controls.Add(Me.DeviceButton)
        Me.Controls.Add(Me.DeviceInfo)
        Me.Controls.Add(Me.DeviceLabel)
        Me.Controls.Add(Me.DeviceBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.EnterButton)
        Me.Controls.Add(Me.PasswordBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Usernamebox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PortBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DatasourceBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AskDatabase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AskDatabase"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DatasourceBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PortBox As TextBox
    Friend WithEvents Usernamebox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PasswordBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents EnterButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DeviceBox As ComboBox
    Friend WithEvents DeviceLabel As Label
    Friend WithEvents DeviceInfo As Label
    Friend WithEvents DeviceButton As Button
End Class
