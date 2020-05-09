<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CashForm
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
        Me.AgreeButton = New System.Windows.Forms.Button()
        Me.CashInput = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CashPrice = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.buttonx = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AgreeButton
        '
        Me.AgreeButton.BackColor = System.Drawing.Color.Transparent
        Me.AgreeButton.BackgroundImage = Global.Group2TugasAkhirADSecond.My.Resources.ImageHolder.GoldCheck
        Me.AgreeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AgreeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AgreeButton.ForeColor = System.Drawing.Color.Transparent
        Me.AgreeButton.Location = New System.Drawing.Point(399, 486)
        Me.AgreeButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AgreeButton.Name = "AgreeButton"
        Me.AgreeButton.Size = New System.Drawing.Size(100, 92)
        Me.AgreeButton.TabIndex = 17
        Me.AgreeButton.UseVisualStyleBackColor = False
        '
        'CashInput
        '
        Me.CashInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CashInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CashInput.Enabled = False
        Me.CashInput.Font = New System.Drawing.Font("Japanese Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CashInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CashInput.Location = New System.Drawing.Point(297, 370)
        Me.CashInput.Margin = New System.Windows.Forms.Padding(4)
        Me.CashInput.Name = "CashInput"
        Me.CashInput.Size = New System.Drawing.Size(660, 32)
        Me.CashInput.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Japanese Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(290, 335)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 34)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Cash"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Japanese Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(290, 372)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(600, 34)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "_____________________________________________"
        '
        'CashPrice
        '
        Me.CashPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CashPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CashPrice.Enabled = False
        Me.CashPrice.Font = New System.Drawing.Font("Japanese Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CashPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CashPrice.Location = New System.Drawing.Point(297, 262)
        Me.CashPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.CashPrice.Name = "CashPrice"
        Me.CashPrice.Size = New System.Drawing.Size(660, 32)
        Me.CashPrice.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Japanese Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(290, 226)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 34)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Japanese Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(290, 263)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(600, 34)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "_____________________________________________"
        '
        'buttonx
        '
        Me.buttonx.BackColor = System.Drawing.Color.Transparent
        Me.buttonx.BackgroundImage = Global.Group2TugasAkhirADSecond.My.Resources.ImageHolder.GoldX
        Me.buttonx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.buttonx.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.buttonx.ForeColor = System.Drawing.Color.Transparent
        Me.buttonx.Location = New System.Drawing.Point(658, 486)
        Me.buttonx.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonx.Name = "buttonx"
        Me.buttonx.Size = New System.Drawing.Size(100, 92)
        Me.buttonx.TabIndex = 18
        Me.buttonx.UseVisualStyleBackColor = False
        '
        'CashForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Group2TugasAkhirADSecond.My.Resources.Resources.Floral
        Me.ClientSize = New System.Drawing.Size(1247, 780)
        Me.Controls.Add(Me.buttonx)
        Me.Controls.Add(Me.AgreeButton)
        Me.Controls.Add(Me.CashInput)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CashPrice)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "CashForm"
        Me.Text = "Cash"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AgreeButton As Button
    Friend WithEvents CashInput As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CashPrice As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents buttonx As Button
End Class
