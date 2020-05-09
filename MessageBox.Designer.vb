<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MessageBoxs
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
        Me.ErrorText = New System.Windows.Forms.Label()
        Me.YesCheck = New System.Windows.Forms.PictureBox()
        CType(Me.YesCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ErrorText
        '
        Me.ErrorText.AutoSize = True
        Me.ErrorText.BackColor = System.Drawing.Color.Transparent
        Me.ErrorText.Font = New System.Drawing.Font("Japanese Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ErrorText.Location = New System.Drawing.Point(12, 9)
        Me.ErrorText.Name = "ErrorText"
        Me.ErrorText.Size = New System.Drawing.Size(64, 34)
        Me.ErrorText.TabIndex = 0
        Me.ErrorText.Text = "Test"
        '
        'YesCheck
        '
        Me.YesCheck.BackColor = System.Drawing.Color.Transparent
        Me.YesCheck.BackgroundImage = Global.Group2TugasAkhirADSecond.My.Resources.ImageHolder.GoldCheck
        Me.YesCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.YesCheck.Location = New System.Drawing.Point(392, 201)
        Me.YesCheck.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.YesCheck.Name = "YesCheck"
        Me.YesCheck.Size = New System.Drawing.Size(93, 86)
        Me.YesCheck.TabIndex = 1
        Me.YesCheck.TabStop = False
        '
        'MessageBoxs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Group2TugasAkhirADSecond.My.Resources.ImageHolder.BackgroundFloral
        Me.ClientSize = New System.Drawing.Size(500, 302)
        Me.Controls.Add(Me.YesCheck)
        Me.Controls.Add(Me.ErrorText)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MessageBoxs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MessageBox"
        CType(Me.YesCheck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ErrorText As Label
    Friend WithEvents YesCheck As PictureBox
End Class
