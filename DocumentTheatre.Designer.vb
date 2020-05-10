<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DocumentTheatre
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
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.Theatres = New DevExpress.XtraPrinting.Preview.DocumentViewer()
        Me.SuspendLayout()
        '
        'Theatres
        '
        Me.Theatres.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Theatres.DocumentSource = GetType(Group2TugasAkhirADSecond.XtraReport2)
        Me.Theatres.IsMetric = True
        Me.Theatres.Location = New System.Drawing.Point(0, 0)
        Me.Theatres.Name = "Theatres"
        Me.Theatres.Size = New System.Drawing.Size(1264, 681)
        Me.Theatres.TabIndex = 0
        '
        'DocumentTheatre
        '
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Theatres)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "DocumentTheatre"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PrintDocument2 As Printing.PrintDocument
    Friend WithEvents DocumentTheatre As DevExpress.XtraPrinting.Preview.DocumentViewer
    Friend WithEvents Theatres As DevExpress.XtraPrinting.Preview.DocumentViewer
End Class
