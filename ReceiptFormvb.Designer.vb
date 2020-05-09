<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReceiptFormvb
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
        Me.SeatCountBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TotalAmmountBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AgreeButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SeatCountBox
        '
        Me.SeatCountBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.SeatCountBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SeatCountBox.Enabled = False
        Me.SeatCountBox.Font = New System.Drawing.Font("Japanese Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeatCountBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SeatCountBox.Location = New System.Drawing.Point(392, 265)
        Me.SeatCountBox.Name = "SeatCountBox"
        Me.SeatCountBox.Size = New System.Drawing.Size(495, 26)
        Me.SeatCountBox.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Japanese Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(387, 236)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 26)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Seats"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Japanese Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(387, 266)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(507, 26)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "_____________________________________________"
        '
        'TotalAmmountBox
        '
        Me.TotalAmmountBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.TotalAmmountBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TotalAmmountBox.Enabled = False
        Me.TotalAmmountBox.Font = New System.Drawing.Font("Japanese Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalAmmountBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TotalAmmountBox.Location = New System.Drawing.Point(392, 353)
        Me.TotalAmmountBox.Name = "TotalAmmountBox"
        Me.TotalAmmountBox.Size = New System.Drawing.Size(495, 26)
        Me.TotalAmmountBox.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Japanese Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(387, 324)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 26)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Japanese Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(387, 354)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(507, 26)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "_____________________________________________"
        '
        'AgreeButton
        '
        Me.AgreeButton.BackColor = System.Drawing.Color.Transparent
        Me.AgreeButton.BackgroundImage = Global.Group2TugasAkhirADSecond.My.Resources.ImageHolder.GoldCheck
        Me.AgreeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AgreeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AgreeButton.ForeColor = System.Drawing.Color.Transparent
        Me.AgreeButton.Location = New System.Drawing.Point(617, 428)
        Me.AgreeButton.Name = "AgreeButton"
        Me.AgreeButton.Size = New System.Drawing.Size(75, 75)
        Me.AgreeButton.TabIndex = 10
        Me.AgreeButton.UseVisualStyleBackColor = False
        '
        'ReceiptFormvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Group2TugasAkhirADSecond.My.Resources.ImageHolder.BackgroundFloral
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.AgreeButton)
        Me.Controls.Add(Me.TotalAmmountBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SeatCountBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ReceiptFormvb"
        Me.Text = "ReceiptFormvb"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SeatCountBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TotalAmmountBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents AgreeButton As Button
End Class
