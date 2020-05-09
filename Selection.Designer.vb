<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Selection
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.AdminButton = New System.Windows.Forms.PictureBox()
        Me.ExitButton = New System.Windows.Forms.PictureBox()
        Me.AdminLabel = New System.Windows.Forms.Label()
        Me.ExitLabel = New System.Windows.Forms.Label()
        Me.OrderButton = New System.Windows.Forms.PictureBox()
        Me.OrderLabel = New System.Windows.Forms.Label()
        CType(Me.AdminButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExitButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AdminButton
        '
        Me.AdminButton.BackColor = System.Drawing.Color.Transparent
        Me.AdminButton.BackgroundImage = Global.Group2TugasAkhirADSecond.My.Resources.ImageHolder.GoldGearAdmin
        Me.AdminButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AdminButton.Location = New System.Drawing.Point(473, 300)
        Me.AdminButton.Name = "AdminButton"
        Me.AdminButton.Size = New System.Drawing.Size(140, 140)
        Me.AdminButton.TabIndex = 1
        Me.AdminButton.TabStop = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Transparent
        Me.ExitButton.BackgroundImage = Global.Group2TugasAkhirADSecond.My.Resources.ImageHolder.GoldLogOutExit
        Me.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ExitButton.Location = New System.Drawing.Point(470, 490)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(140, 140)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.TabStop = False
        '
        'AdminLabel
        '
        Me.AdminLabel.AutoSize = True
        Me.AdminLabel.BackColor = System.Drawing.Color.Transparent
        Me.AdminLabel.Font = New System.Drawing.Font("Japanese Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AdminLabel.Location = New System.Drawing.Point(501, 334)
        Me.AdminLabel.Name = "AdminLabel"
        Me.AdminLabel.Size = New System.Drawing.Size(366, 77)
        Me.AdminLabel.TabIndex = 4
        Me.AdminLabel.Text = "       ADMIN"
        '
        'ExitLabel
        '
        Me.ExitLabel.AutoSize = True
        Me.ExitLabel.BackColor = System.Drawing.Color.Transparent
        Me.ExitLabel.Font = New System.Drawing.Font("Japanese Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ExitLabel.Location = New System.Drawing.Point(534, 519)
        Me.ExitLabel.Name = "ExitLabel"
        Me.ExitLabel.Size = New System.Drawing.Size(293, 77)
        Me.ExitLabel.TabIndex = 5
        Me.ExitLabel.Text = "       EXIT"
        '
        'OrderButton
        '
        Me.OrderButton.BackColor = System.Drawing.Color.Transparent
        Me.OrderButton.BackgroundImage = Global.Group2TugasAkhirADSecond.My.Resources.ImageHolder.GoldPurchaseOrder
        Me.OrderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OrderButton.Location = New System.Drawing.Point(473, 110)
        Me.OrderButton.Name = "OrderButton"
        Me.OrderButton.Size = New System.Drawing.Size(140, 140)
        Me.OrderButton.TabIndex = 0
        Me.OrderButton.TabStop = False
        '
        'OrderLabel
        '
        Me.OrderLabel.AutoSize = True
        Me.OrderLabel.BackColor = System.Drawing.Color.Transparent
        Me.OrderLabel.Font = New System.Drawing.Font("Japanese Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.OrderLabel.Location = New System.Drawing.Point(534, 146)
        Me.OrderLabel.Name = "OrderLabel"
        Me.OrderLabel.Size = New System.Drawing.Size(333, 77)
        Me.OrderLabel.TabIndex = 3
        Me.OrderLabel.Text = "     ORDER"
        '
        'Selection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Group2TugasAkhirADSecond.My.Resources.ImageHolder.BackgroundFloral
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.AdminButton)
        Me.Controls.Add(Me.OrderButton)
        Me.Controls.Add(Me.OrderLabel)
        Me.Controls.Add(Me.AdminLabel)
        Me.Controls.Add(Me.ExitLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Selection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selection"
        CType(Me.AdminButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExitButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AdminButton As PictureBox
    Friend WithEvents ExitButton As PictureBox
    Friend WithEvents AdminLabel As Label
    Friend WithEvents ExitLabel As Label
    Friend WithEvents OrderButton As PictureBox
    Friend WithEvents OrderLabel As Label
End Class
