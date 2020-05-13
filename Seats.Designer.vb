<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Seats
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.buttoncheck = New System.Windows.Forms.Button()
        Me.buttonx = New System.Windows.Forms.Button()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.MultipleSelection = New DevExpress.XtraEditors.CheckEdit()
        Me.seatchooselabel = New System.Windows.Forms.Label()
        Me.SeatChooseBox = New DevExpress.XtraEditors.SpinEdit()
        CType(Me.MultipleSelection.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeatChooseBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(787, 121)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 31)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(787, 174)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(33, 31)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gray
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(787, 226)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(33, 31)
        Me.Button3.TabIndex = 2
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Japanese Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(828, 121)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Selected"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Japanese Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(828, 174)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Taken"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Japanese Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(828, 226)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Available"
        '
        'buttoncheck
        '
        Me.buttoncheck.BackColor = System.Drawing.Color.Transparent
        Me.buttoncheck.BackgroundImage = Global.Group2TugasAkhirADSecond.My.Resources.ImageHolder.GoldCheck
        Me.buttoncheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.buttoncheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.buttoncheck.ForeColor = System.Drawing.Color.Transparent
        Me.buttoncheck.Location = New System.Drawing.Point(195, 745)
        Me.buttoncheck.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.buttoncheck.Name = "buttoncheck"
        Me.buttoncheck.Size = New System.Drawing.Size(100, 92)
        Me.buttoncheck.TabIndex = 6
        Me.buttoncheck.UseVisualStyleBackColor = False
        '
        'buttonx
        '
        Me.buttonx.BackColor = System.Drawing.Color.Transparent
        Me.buttonx.BackgroundImage = Global.Group2TugasAkhirADSecond.My.Resources.ImageHolder.GoldX
        Me.buttonx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.buttonx.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.buttonx.ForeColor = System.Drawing.Color.Transparent
        Me.buttonx.Location = New System.Drawing.Point(389, 745)
        Me.buttonx.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.buttonx.Name = "buttonx"
        Me.buttonx.Size = New System.Drawing.Size(100, 92)
        Me.buttonx.TabIndex = 7
        Me.buttonx.UseVisualStyleBackColor = False
        '
        'HomeButton
        '
        Me.HomeButton.BackColor = System.Drawing.Color.Transparent
        Me.HomeButton.BackgroundImage = Global.Group2TugasAkhirADSecond.My.Resources.ImageHolder.GoldLogOutExit
        Me.HomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.HomeButton.Location = New System.Drawing.Point(1673, -4)
        Me.HomeButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(33, 31)
        Me.HomeButton.TabIndex = 23
        Me.HomeButton.UseVisualStyleBackColor = False
        '
        'MultipleSelection
        '
        Me.MultipleSelection.Location = New System.Drawing.Point(787, 331)
        Me.MultipleSelection.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MultipleSelection.Name = "MultipleSelection"
        Me.MultipleSelection.Properties.Appearance.Font = New System.Drawing.Font("Japanese Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MultipleSelection.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MultipleSelection.Properties.Appearance.Options.UseFont = True
        Me.MultipleSelection.Properties.Appearance.Options.UseForeColor = True
        Me.MultipleSelection.Properties.AppearanceFocused.Font = New System.Drawing.Font("Japanese Gothic", 15.75!)
        Me.MultipleSelection.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MultipleSelection.Properties.AppearanceFocused.Options.UseFont = True
        Me.MultipleSelection.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.MultipleSelection.Properties.Caption = "Select Multiple"
        Me.MultipleSelection.Size = New System.Drawing.Size(241, 30)
        Me.MultipleSelection.TabIndex = 24
        '
        'seatchooselabel
        '
        Me.seatchooselabel.AutoSize = True
        Me.seatchooselabel.BackColor = System.Drawing.Color.Transparent
        Me.seatchooselabel.Font = New System.Drawing.Font("Japanese Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seatchooselabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.seatchooselabel.Location = New System.Drawing.Point(783, 374)
        Me.seatchooselabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.seatchooselabel.Name = "seatchooselabel"
        Me.seatchooselabel.Size = New System.Drawing.Size(129, 20)
        Me.seatchooselabel.TabIndex = 25
        Me.seatchooselabel.Text = "How many seats?"
        Me.seatchooselabel.Visible = False
        '
        'SeatChooseBox
        '
        Me.SeatChooseBox.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SeatChooseBox.Location = New System.Drawing.Point(787, 398)
        Me.SeatChooseBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SeatChooseBox.Name = "SeatChooseBox"
        Me.SeatChooseBox.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.SeatChooseBox.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.SeatChooseBox.Properties.Appearance.Font = New System.Drawing.Font("Japanese Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeatChooseBox.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SeatChooseBox.Properties.Appearance.Options.UseBackColor = True
        Me.SeatChooseBox.Properties.Appearance.Options.UseBorderColor = True
        Me.SeatChooseBox.Properties.Appearance.Options.UseFont = True
        Me.SeatChooseBox.Properties.Appearance.Options.UseForeColor = True
        Me.SeatChooseBox.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.SeatChooseBox.Properties.AppearanceFocused.Font = New System.Drawing.Font("Japanese Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeatChooseBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SeatChooseBox.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.SeatChooseBox.Properties.AppearanceFocused.Options.UseFont = True
        Me.SeatChooseBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.SeatChooseBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SeatChooseBox.Properties.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.SeatChooseBox.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SeatChooseBox.Size = New System.Drawing.Size(154, 34)
        Me.SeatChooseBox.TabIndex = 52
        Me.SeatChooseBox.Visible = False
        '
        'Seats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Group2TugasAkhirADSecond.My.Resources.ImageHolder.BackgroundFloral
        Me.ClientSize = New System.Drawing.Size(1707, 886)
        Me.Controls.Add(Me.SeatChooseBox)
        Me.Controls.Add(Me.seatchooselabel)
        Me.Controls.Add(Me.MultipleSelection)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.buttonx)
        Me.Controls.Add(Me.buttoncheck)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Seats"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seats"
        CType(Me.MultipleSelection.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeatChooseBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents buttoncheck As Button
    Friend WithEvents buttonx As Button
    Friend WithEvents HomeButton As Button
    Friend WithEvents MultipleSelection As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents seatchooselabel As Label
    Friend WithEvents SeatChooseBox As DevExpress.XtraEditors.SpinEdit
End Class
