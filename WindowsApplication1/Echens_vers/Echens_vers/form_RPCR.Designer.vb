<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_RPCR
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
        Me.EchDataTableTableAdapter = New WindowsApplication1.echen_versDataSetTableAdapters.EchDataTableTableAdapter()
        Me.Echen_versDataSet = New WindowsApplication1.echen_versDataSet()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Echn_versCrystalReport = New WindowsApplication1.Echn_versCrystalReport()
        CType(Me.Echen_versDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EchDataTableTableAdapter
        '
        Me.EchDataTableTableAdapter.ClearBeforeFill = True
        '
        'Echen_versDataSet
        '
        Me.Echen_versDataSet.DataSetName = "echen_versDataSet"
        Me.Echen_versDataSet.Locale = New System.Globalization.CultureInfo("ar-DZ")
        Me.Echen_versDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.Echn_versCrystalReport
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1057, 535)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'form_RPCR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1057, 535)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "form_RPCR"
        Me.Text = "form_RPCR"
        CType(Me.Echen_versDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Echn_versCrystalReport As Echn_versCrystalReport
    Friend WithEvents EchDataTableTableAdapter As echen_versDataSetTableAdapters.EchDataTableTableAdapter
    Friend WithEvents Echen_versDataSet As echen_versDataSet
End Class
