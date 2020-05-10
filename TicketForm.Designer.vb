<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TicketForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TicketForm))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.FilmLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TheatreLabel = New System.Windows.Forms.Label()
        Me.TheatreLabel2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TimeLabel2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DateLabel2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.FilmLabel2 = New System.Windows.Forms.Label()
        Me.PrintThisDocument = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.LoadTime = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Japanese Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(386, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 26)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "CineOne"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Japanese Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(69, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 26)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "CineOne"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(240, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 409)
        Me.Panel1.TabIndex = 17
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(-3, 64)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(606, 5)
        Me.Panel2.TabIndex = 18
        '
        'FilmLabel
        '
        Me.FilmLabel.AutoSize = True
        Me.FilmLabel.BackColor = System.Drawing.Color.Transparent
        Me.FilmLabel.Font = New System.Drawing.Font("Japanese Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilmLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FilmLabel.Location = New System.Drawing.Point(251, 72)
        Me.FilmLabel.Name = "FilmLabel"
        Me.FilmLabel.Size = New System.Drawing.Size(90, 26)
        Me.FilmLabel.TabIndex = 19
        Me.FilmLabel.Text = "CineOne"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Japanese Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(251, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 26)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Date : "
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.BackColor = System.Drawing.Color.Transparent
        Me.DateLabel.Font = New System.Drawing.Font("Japanese Gothic", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DateLabel.Location = New System.Drawing.Point(324, 132)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(56, 17)
        Me.DateLabel.TabIndex = 21
        Me.DateLabel.Text = "CineOne"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Japanese Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(251, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 26)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Time :"
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.BackColor = System.Drawing.Color.Transparent
        Me.TimeLabel.Font = New System.Drawing.Font("Japanese Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TimeLabel.Location = New System.Drawing.Point(322, 171)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(90, 26)
        Me.TimeLabel.TabIndex = 23
        Me.TimeLabel.Text = "CineOne"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Japanese Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(251, 332)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 26)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Price : 50,000"
        '
        'TheatreLabel
        '
        Me.TheatreLabel.AutoSize = True
        Me.TheatreLabel.BackColor = System.Drawing.Color.Transparent
        Me.TheatreLabel.Font = New System.Drawing.Font("Japanese Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TheatreLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TheatreLabel.Location = New System.Drawing.Point(256, 248)
        Me.TheatreLabel.Name = "TheatreLabel"
        Me.TheatreLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TheatreLabel.Size = New System.Drawing.Size(90, 26)
        Me.TheatreLabel.TabIndex = 25
        Me.TheatreLabel.Text = "CineOne"
        '
        'TheatreLabel2
        '
        Me.TheatreLabel2.AutoSize = True
        Me.TheatreLabel2.BackColor = System.Drawing.Color.Transparent
        Me.TheatreLabel2.Font = New System.Drawing.Font("Japanese Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TheatreLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TheatreLabel2.Location = New System.Drawing.Point(-2, 248)
        Me.TheatreLabel2.Name = "TheatreLabel2"
        Me.TheatreLabel2.Size = New System.Drawing.Size(90, 26)
        Me.TheatreLabel2.TabIndex = 32
        Me.TheatreLabel2.Text = "CineOne"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Japanese Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(-2, 332)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 26)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Price : 50,000"
        '
        'TimeLabel2
        '
        Me.TimeLabel2.AutoSize = True
        Me.TimeLabel2.BackColor = System.Drawing.Color.Transparent
        Me.TimeLabel2.Font = New System.Drawing.Font("Japanese Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TimeLabel2.Location = New System.Drawing.Point(69, 171)
        Me.TimeLabel2.Name = "TimeLabel2"
        Me.TimeLabel2.Size = New System.Drawing.Size(90, 26)
        Me.TimeLabel2.TabIndex = 30
        Me.TimeLabel2.Text = "CineOne"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Japanese Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(-2, 171)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 26)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Time :"
        '
        'DateLabel2
        '
        Me.DateLabel2.AutoSize = True
        Me.DateLabel2.BackColor = System.Drawing.Color.Transparent
        Me.DateLabel2.Font = New System.Drawing.Font("Japanese Gothic", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DateLabel2.Location = New System.Drawing.Point(71, 131)
        Me.DateLabel2.Name = "DateLabel2"
        Me.DateLabel2.Size = New System.Drawing.Size(56, 17)
        Me.DateLabel2.TabIndex = 28
        Me.DateLabel2.Text = "CineOne"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Japanese Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(-2, 123)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 26)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Date : "
        '
        'FilmLabel2
        '
        Me.FilmLabel2.AutoSize = True
        Me.FilmLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FilmLabel2.Font = New System.Drawing.Font("Japanese Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilmLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FilmLabel2.Location = New System.Drawing.Point(-2, 72)
        Me.FilmLabel2.Name = "FilmLabel2"
        Me.FilmLabel2.Size = New System.Drawing.Size(90, 26)
        Me.FilmLabel2.TabIndex = 26
        Me.FilmLabel2.Text = "CineOne"
        '
        'PrintThisDocument
        '
        Me.PrintThisDocument.DocumentName = "document"
        Me.PrintThisDocument.Form = Me
        Me.PrintThisDocument.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintThisDocument.PrinterSettings = CType(resources.GetObject("PrintThisDocument.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintThisDocument.PrintFileName = Nothing
        '
        'LoadTime
        '
        Me.LoadTime.Enabled = True
        Me.LoadTime.Interval = 1000
        '
        'TicketForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Group2TugasAkhirADSecond.My.Resources.ImageHolder.BackgroundFloral
        Me.ClientSize = New System.Drawing.Size(600, 400)
        Me.Controls.Add(Me.TheatreLabel2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TimeLabel2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DateLabel2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.FilmLabel2)
        Me.Controls.Add(Me.TheatreLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TimeLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FilmLabel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TicketForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TicketForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FilmLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TimeLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TheatreLabel As Label
    Friend WithEvents TheatreLabel2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TimeLabel2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DateLabel2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents FilmLabel2 As Label
    Friend WithEvents PrintThisDocument As PowerPacks.Printing.PrintForm
    Friend WithEvents LoadTime As Timer
End Class
