<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimeSelection
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
        Me.timebox = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.timeimage = New System.Windows.Forms.PictureBox()
        Me.HomeButton = New System.Windows.Forms.Button()
        CType(Me.timebox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.timeimage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timebox
        '
        Me.timebox.Location = New System.Drawing.Point(587, 612)
        Me.timebox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.timebox.Name = "timebox"
        Me.timebox.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.timebox.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.timebox.Properties.Appearance.Font = New System.Drawing.Font("Japanese Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timebox.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.timebox.Properties.Appearance.Options.UseBackColor = True
        Me.timebox.Properties.Appearance.Options.UseFont = True
        Me.timebox.Properties.Appearance.Options.UseForeColor = True
        Me.timebox.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.timebox.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Japanese Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timebox.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.timebox.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.timebox.Properties.AppearanceDropDown.Options.UseFont = True
        Me.timebox.Properties.AppearanceDropDown.Options.UseForeColor = True
        Me.timebox.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.timebox.Properties.AppearanceFocused.Font = New System.Drawing.Font("Japanese Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timebox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.timebox.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.timebox.Properties.AppearanceFocused.Options.UseFont = True
        Me.timebox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.timebox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.timebox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.timebox.Size = New System.Drawing.Size(533, 40)
        Me.timebox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Japanese Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(577, 560)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 49)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Time"
        '
        'timeimage
        '
        Me.timeimage.BackColor = System.Drawing.Color.Transparent
        Me.timeimage.Location = New System.Drawing.Point(720, 185)
        Me.timeimage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.timeimage.Name = "timeimage"
        Me.timeimage.Size = New System.Drawing.Size(267, 369)
        Me.timeimage.TabIndex = 2
        Me.timeimage.TabStop = False
        '
        'HomeButton
        '
        Me.HomeButton.BackColor = System.Drawing.Color.Transparent
        Me.HomeButton.BackgroundImage = Global.Group2TugasAkhirADSecond.My.Resources.ImageHolder.GoldLogOutExit
        Me.HomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.HomeButton.Location = New System.Drawing.Point(1675, 0)
        Me.HomeButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(33, 31)
        Me.HomeButton.TabIndex = 22
        Me.HomeButton.UseVisualStyleBackColor = False
        '
        'TimeSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Group2TugasAkhirADSecond.My.Resources.ImageHolder.BackgroundFloral
        Me.ClientSize = New System.Drawing.Size(1707, 886)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.timeimage)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.timebox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "TimeSelection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TimeSelection"
        CType(Me.timebox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.timeimage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents timebox As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents timeimage As PictureBox
    Friend WithEvents HomeButton As Button
End Class
