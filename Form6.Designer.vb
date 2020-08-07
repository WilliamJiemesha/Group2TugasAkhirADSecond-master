<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MehtodePayForm
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AgreeButton = New System.Windows.Forms.Button()
        Me.CbPayment = New DevExpress.XtraEditors.ComboBoxEdit()
        CType(Me.CbPayment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Japanese Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(407, 264)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 26)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Payment Method"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Japanese Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(407, 321)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(474, 26)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "__________________________________________"
        '
        'AgreeButton
        '
        Me.AgreeButton.BackColor = System.Drawing.Color.Transparent
        Me.AgreeButton.BackgroundImage = Global.Group2TugasAkhirADSecond.My.Resources.ImageHolder.GoldCheck
        Me.AgreeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AgreeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AgreeButton.ForeColor = System.Drawing.Color.Transparent
        Me.AgreeButton.Location = New System.Drawing.Point(635, 389)
        Me.AgreeButton.Name = "AgreeButton"
        Me.AgreeButton.Size = New System.Drawing.Size(75, 75)
        Me.AgreeButton.TabIndex = 17
        Me.AgreeButton.UseVisualStyleBackColor = False
        '
        'CbPayment
        '
        Me.CbPayment.EditValue = ""
        Me.CbPayment.Location = New System.Drawing.Point(414, 312)
        Me.CbPayment.Name = "CbPayment"
        Me.CbPayment.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CbPayment.Properties.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CbPayment.Properties.Appearance.Font = New System.Drawing.Font("Japanese Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbPayment.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CbPayment.Properties.Appearance.Options.UseBackColor = True
        Me.CbPayment.Properties.Appearance.Options.UseFont = True
        Me.CbPayment.Properties.Appearance.Options.UseForeColor = True
        Me.CbPayment.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CbPayment.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CbPayment.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Japanese Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbPayment.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CbPayment.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.CbPayment.Properties.AppearanceDropDown.Options.UseFont = True
        Me.CbPayment.Properties.AppearanceDropDown.Options.UseForeColor = True
        Me.CbPayment.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CbPayment.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.CbPayment.Properties.AppearanceItemSelected.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CbPayment.Properties.AppearanceItemSelected.Options.UseForeColor = True
        Me.CbPayment.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.CbPayment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbPayment.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.CbPayment.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Standard
        Me.CbPayment.Properties.Items.AddRange(New Object() {"Cash", "Debit/Credit Card", "OVO", "Go-Pay"})
        Me.CbPayment.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.CbPayment.Size = New System.Drawing.Size(464, 32)
        Me.CbPayment.TabIndex = 44
        '
        'MehtodePayForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.Group2TugasAkhirADSecond.My.Resources.Resources.Floral
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.CbPayment)
        Me.Controls.Add(Me.AgreeButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "MehtodePayForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.CbPayment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AgreeButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CbPayment As DevExpress.XtraEditors.ComboBoxEdit
End Class
