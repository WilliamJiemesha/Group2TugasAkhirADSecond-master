<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminLogin
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
        Me.UserPicture = New System.Windows.Forms.PictureBox()
        Me.LoginLabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.usertextbox = New System.Windows.Forms.TextBox()
        Me.passwordtextbox = New System.Windows.Forms.TextBox()
        Me.Homebutton = New System.Windows.Forms.PictureBox()
        Me.LoginButton = New System.Windows.Forms.Button()
        CType(Me.UserPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Homebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserPicture
        '
        Me.UserPicture.BackColor = System.Drawing.Color.Transparent
        Me.UserPicture.BackgroundImage = Global.Group2TugasAkhirADSecond.My.Resources.ImageHolder.GoldPerson
        Me.UserPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UserPicture.Location = New System.Drawing.Point(309, 169)
        Me.UserPicture.Name = "UserPicture"
        Me.UserPicture.Size = New System.Drawing.Size(85, 79)
        Me.UserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.UserPicture.TabIndex = 0
        Me.UserPicture.TabStop = False
        '
        'LoginLabel
        '
        Me.LoginLabel.AutoSize = True
        Me.LoginLabel.BackColor = System.Drawing.Color.Transparent
        Me.LoginLabel.Font = New System.Drawing.Font("Japanese Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LoginLabel.Location = New System.Drawing.Point(565, 92)
        Me.LoginLabel.Name = "LoginLabel"
        Me.LoginLabel.Size = New System.Drawing.Size(224, 77)
        Me.LoginLabel.TabIndex = 4
        Me.LoginLabel.Text = "LOGIN"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(411, 238)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(517, 5)
        Me.Panel1.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Group2TugasAkhirADSecond.My.Resources.ImageHolder.GoldKey
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(309, 284)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(85, 79)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(411, 358)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(517, 5)
        Me.Panel2.TabIndex = 6
        '
        'usertextbox
        '
        Me.usertextbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.usertextbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.usertextbox.Font = New System.Drawing.Font("Japanese Gothic", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usertextbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.usertextbox.Location = New System.Drawing.Point(413, 172)
        Me.usertextbox.Name = "usertextbox"
        Me.usertextbox.Size = New System.Drawing.Size(517, 65)
        Me.usertextbox.TabIndex = 7
        '
        'passwordtextbox
        '
        Me.passwordtextbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.passwordtextbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.passwordtextbox.Font = New System.Drawing.Font("Japanese Gothic", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordtextbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.passwordtextbox.Location = New System.Drawing.Point(410, 292)
        Me.passwordtextbox.Name = "passwordtextbox"
        Me.passwordtextbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordtextbox.Size = New System.Drawing.Size(517, 65)
        Me.passwordtextbox.TabIndex = 8
        '
        'Homebutton
        '
        Me.Homebutton.BackColor = System.Drawing.Color.Transparent
        Me.Homebutton.BackgroundImage = Global.Group2TugasAkhirADSecond.My.Resources.ImageHolder.GoldHome
        Me.Homebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Homebutton.Location = New System.Drawing.Point(1196, -2)
        Me.Homebutton.Name = "Homebutton"
        Me.Homebutton.Size = New System.Drawing.Size(85, 79)
        Me.Homebutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Homebutton.TabIndex = 10
        Me.Homebutton.TabStop = False
        '
        'LoginButton
        '
        Me.LoginButton.BackColor = System.Drawing.Color.Transparent
        Me.LoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoginButton.Font = New System.Drawing.Font("Japanese Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LoginButton.Location = New System.Drawing.Point(413, 404)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(515, 75)
        Me.LoginButton.TabIndex = 11
        Me.LoginButton.Text = "LOGIN"
        Me.LoginButton.UseVisualStyleBackColor = False
        '
        'AdminLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Group2TugasAkhirADSecond.My.Resources.ImageHolder.BackgroundFloral
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.Homebutton)
        Me.Controls.Add(Me.passwordtextbox)
        Me.Controls.Add(Me.usertextbox)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LoginLabel)
        Me.Controls.Add(Me.UserPicture)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminLogin"
        CType(Me.UserPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Homebutton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserPicture As PictureBox
    Friend WithEvents LoginLabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents usertextbox As TextBox
    Friend WithEvents passwordtextbox As TextBox
    Friend WithEvents Homebutton As PictureBox
    Friend WithEvents LoginButton As Button
End Class
