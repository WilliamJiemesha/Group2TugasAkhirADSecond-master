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
        Me.CbPayment = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Japanese Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(274, 211)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(215, 34)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Payment Method"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Japanese Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(274, 280)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(600, 34)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "_____________________________________________"
        '
        'AgreeButton
        '
        Me.AgreeButton.BackColor = System.Drawing.Color.Transparent
        Me.AgreeButton.BackgroundImage = Global.Group2TugasAkhirADSecond.My.Resources.ImageHolder.GoldCheck
        Me.AgreeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AgreeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AgreeButton.ForeColor = System.Drawing.Color.Transparent
        Me.AgreeButton.Location = New System.Drawing.Point(579, 364)
        Me.AgreeButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AgreeButton.Name = "AgreeButton"
        Me.AgreeButton.Size = New System.Drawing.Size(100, 92)
        Me.AgreeButton.TabIndex = 17
        Me.AgreeButton.UseVisualStyleBackColor = False
        '
        'CbPayment
        '
        Me.CbPayment.AutoCompleteCustomSource.AddRange(New String() {"Cash", "Debit/Credit Card", "Ovo", "Go-Pay"})
        Me.CbPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CbPayment.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CbPayment.Font = New System.Drawing.Font("Japanese Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbPayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CbPayment.Location = New System.Drawing.Point(280, 280)
        Me.CbPayment.Margin = New System.Windows.Forms.Padding(4)
        Me.CbPayment.Name = "CbPayment"
        Me.CbPayment.Size = New System.Drawing.Size(660, 32)
        Me.CbPayment.TabIndex = 18
        '
        'MehtodePayForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.Group2TugasAkhirADSecond.My.Resources.Resources.Floral
        Me.ClientSize = New System.Drawing.Size(1240, 783)
        Me.Controls.Add(Me.CbPayment)
        Me.Controls.Add(Me.AgreeButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Name = "MehtodePayForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AgreeButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CbPayment As TextBox
End Class
