<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoadingForm
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
        Me.components = New System.ComponentModel.Container()
        Me.Progress = New System.Windows.Forms.ProgressBar()
        Me.ProgressTimer = New System.Windows.Forms.Timer(Me.components)
        Me.LogoAwal = New System.Windows.Forms.PictureBox()
        CType(Me.LogoAwal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Progress
        '
        Me.Progress.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Progress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Progress.Location = New System.Drawing.Point(290, 540)
        Me.Progress.Maximum = 1000
        Me.Progress.Name = "Progress"
        Me.Progress.Size = New System.Drawing.Size(700, 20)
        Me.Progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.Progress.TabIndex = 2
        '
        'ProgressTimer
        '
        Me.ProgressTimer.Enabled = True
        Me.ProgressTimer.Interval = 10
        '
        'LogoAwal
        '
        Me.LogoAwal.BackColor = System.Drawing.Color.Transparent
        Me.LogoAwal.Image = Global.Group2TugasAkhirADSecond.My.Resources.ImageHolder.LogoTheatre
        Me.LogoAwal.Location = New System.Drawing.Point(440, 100)
        Me.LogoAwal.Name = "LogoAwal"
        Me.LogoAwal.Size = New System.Drawing.Size(400, 400)
        Me.LogoAwal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoAwal.TabIndex = 1
        Me.LogoAwal.TabStop = False
        '
        'LoadingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Group2TugasAkhirADSecond.My.Resources.ImageHolder.BackgroundFloral
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.Progress)
        Me.Controls.Add(Me.LogoAwal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "LoadingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.LogoAwal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LogoAwal As PictureBox
    Friend WithEvents Progress As ProgressBar
    Friend WithEvents ProgressTimer As Timer
End Class
