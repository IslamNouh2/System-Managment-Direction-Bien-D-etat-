<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCRDP
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Droi_proCrystalReport = New WindowsApplication1.Droi_proCrystalReport()
        Me.Droit_proDataSet = New WindowsApplication1.droit_proDataSet()
        Me.Beneficiaire_DTableAdapter = New WindowsApplication1.droit_proDataSetTableAdapters.Beneficiaire_DTableAdapter()
        Me.Local_DTableAdapter = New WindowsApplication1.droit_proDataSetTableAdapters.Local_DTableAdapter()
        Me.Residence_DTableAdapter = New WindowsApplication1.droit_proDataSetTableAdapters.Residence_DTableAdapter()
        Me.Quartier_DTableAdapter = New WindowsApplication1.droit_proDataSetTableAdapters.Quartier_DTableAdapter()
        Me.Wilaya_DTableAdapter = New WindowsApplication1.droit_proDataSetTableAdapters.Wilaya_DTableAdapter()
        Me.Daira_DTableAdapter = New WindowsApplication1.droit_proDataSetTableAdapters.Daira_DTableAdapter()
        Me.Commune_DTableAdapter = New WindowsApplication1.droit_proDataSetTableAdapters.Commune_DTableAdapter()
        Me.Nom_completTableAdapter = New WindowsApplication1.droit_proDataSetTableAdapters.Nom_completTableAdapter()
        Me.Droits_de_propriete_de_etatTableAdapter = New WindowsApplication1.droit_proDataSetTableAdapters.Droits_de_propriete_de_etatTableAdapter()
        Me.DroTableAdapter = New WindowsApplication1.droit_proDataSetTableAdapters.droTableAdapter()
        CType(Me.Droit_proDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.Droi_proCrystalReport
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1045, 522)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'Droit_proDataSet
        '
        Me.Droit_proDataSet.DataSetName = "droit_proDataSet"
        Me.Droit_proDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Beneficiaire_DTableAdapter
        '
        Me.Beneficiaire_DTableAdapter.ClearBeforeFill = True
        '
        'Local_DTableAdapter
        '
        Me.Local_DTableAdapter.ClearBeforeFill = True
        '
        'Residence_DTableAdapter
        '
        Me.Residence_DTableAdapter.ClearBeforeFill = True
        '
        'Quartier_DTableAdapter
        '
        Me.Quartier_DTableAdapter.ClearBeforeFill = True
        '
        'Wilaya_DTableAdapter
        '
        Me.Wilaya_DTableAdapter.ClearBeforeFill = True
        '
        'Daira_DTableAdapter
        '
        Me.Daira_DTableAdapter.ClearBeforeFill = True
        '
        'Commune_DTableAdapter
        '
        Me.Commune_DTableAdapter.ClearBeforeFill = True
        '
        'Nom_completTableAdapter
        '
        Me.Nom_completTableAdapter.ClearBeforeFill = True
        '
        'Droits_de_propriete_de_etatTableAdapter
        '
        Me.Droits_de_propriete_de_etatTableAdapter.ClearBeforeFill = True
        '
        'DroTableAdapter
        '
        Me.DroTableAdapter.ClearBeforeFill = True
        '
        'FormCRDP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1045, 522)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "FormCRDP"
        Me.Text = "طبع أمر بالدفع"
        CType(Me.Droit_proDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Droi_proCrystalReport As Droi_proCrystalReport
    Friend WithEvents Droit_proDataSet As droit_proDataSet
    Friend WithEvents Beneficiaire_DTableAdapter As droit_proDataSetTableAdapters.Beneficiaire_DTableAdapter
    Friend WithEvents Local_DTableAdapter As droit_proDataSetTableAdapters.Local_DTableAdapter
    Friend WithEvents Residence_DTableAdapter As droit_proDataSetTableAdapters.Residence_DTableAdapter
    Friend WithEvents Quartier_DTableAdapter As droit_proDataSetTableAdapters.Quartier_DTableAdapter
    Friend WithEvents Wilaya_DTableAdapter As droit_proDataSetTableAdapters.Wilaya_DTableAdapter
    Friend WithEvents Daira_DTableAdapter As droit_proDataSetTableAdapters.Daira_DTableAdapter
    Friend WithEvents Commune_DTableAdapter As droit_proDataSetTableAdapters.Commune_DTableAdapter
    Friend WithEvents Nom_completTableAdapter As droit_proDataSetTableAdapters.Nom_completTableAdapter
    Friend WithEvents Droits_de_propriete_de_etatTableAdapter As droit_proDataSetTableAdapters.Droits_de_propriete_de_etatTableAdapter
    Friend WithEvents DroTableAdapter As droit_proDataSetTableAdapters.droTableAdapter
End Class
