<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCRVI1
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
        Me.BeneficiaireTableAdapter = New WindowsApplication1.Valeur_inDataSetTableAdapters.BeneficiaireTableAdapter()
        Me.Calendrier_valueur_initaleTableAdapter = New WindowsApplication1.Valeur_inDataSetTableAdapters.Calendrier_valueur_initaleTableAdapter()
        Me.LocalTableAdapter = New WindowsApplication1.Valeur_inDataSetTableAdapters.LocalTableAdapter()
        Me.QuartierTableAdapter = New WindowsApplication1.Valeur_inDataSetTableAdapters.QuartierTableAdapter()
        Me.DairaTableAdapter = New WindowsApplication1.Valeur_inDataSetTableAdapters.DairaTableAdapter()
        Me.CommuneTableAdapter = New WindowsApplication1.Valeur_inDataSetTableAdapters.CommuneTableAdapter()
        Me.WilayaTableAdapter = New WindowsApplication1.Valeur_inDataSetTableAdapters.WilayaTableAdapter()
        Me.ResidenceTableAdapter = New WindowsApplication1.Valeur_inDataSetTableAdapters.ResidenceTableAdapter()
        Me.Valeur_inDataSet = New WindowsApplication1.Valeur_inDataSet()
        Me.NomCDataTableTableAdapter = New WindowsApplication1.Valeur_inDataSetTableAdapters.NomCDataTableTableAdapter()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Valeur_INCrystalReport = New WindowsApplication1.Valeur_INCrystalReport()
        Me.CachedEchn_versCrystalReport1 = New WindowsApplication1.CachedEchn_versCrystalReport()
        CType(Me.Valeur_inDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BeneficiaireTableAdapter
        '
        Me.BeneficiaireTableAdapter.ClearBeforeFill = True
        '
        'Calendrier_valueur_initaleTableAdapter
        '
        Me.Calendrier_valueur_initaleTableAdapter.ClearBeforeFill = True
        '
        'LocalTableAdapter
        '
        Me.LocalTableAdapter.ClearBeforeFill = True
        '
        'QuartierTableAdapter
        '
        Me.QuartierTableAdapter.ClearBeforeFill = True
        '
        'DairaTableAdapter
        '
        Me.DairaTableAdapter.ClearBeforeFill = True
        '
        'CommuneTableAdapter
        '
        Me.CommuneTableAdapter.ClearBeforeFill = True
        '
        'WilayaTableAdapter
        '
        Me.WilayaTableAdapter.ClearBeforeFill = True
        '
        'ResidenceTableAdapter
        '
        Me.ResidenceTableAdapter.ClearBeforeFill = True
        '
        'Valeur_inDataSet
        '
        Me.Valeur_inDataSet.DataSetName = "Valeur_inDataSet"
        Me.Valeur_inDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NomCDataTableTableAdapter
        '
        Me.NomCDataTableTableAdapter.ClearBeforeFill = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.Valeur_INCrystalReport
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(913, 513)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'FormCRVI1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(913, 513)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "FormCRVI1"
        Me.Text = "طبع أمر بالدفع"
        CType(Me.Valeur_inDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Valeur_INCrystalReport As Valeur_INCrystalReport
    Friend WithEvents BeneficiaireTableAdapter As Valeur_inDataSetTableAdapters.BeneficiaireTableAdapter
    Friend WithEvents Calendrier_valueur_initaleTableAdapter As Valeur_inDataSetTableAdapters.Calendrier_valueur_initaleTableAdapter
    Friend WithEvents LocalTableAdapter As Valeur_inDataSetTableAdapters.LocalTableAdapter
    Friend WithEvents QuartierTableAdapter As Valeur_inDataSetTableAdapters.QuartierTableAdapter
    Friend WithEvents DairaTableAdapter As Valeur_inDataSetTableAdapters.DairaTableAdapter
    Friend WithEvents CommuneTableAdapter As Valeur_inDataSetTableAdapters.CommuneTableAdapter
    Friend WithEvents WilayaTableAdapter As Valeur_inDataSetTableAdapters.WilayaTableAdapter
    Friend WithEvents ResidenceTableAdapter As Valeur_inDataSetTableAdapters.ResidenceTableAdapter
    Friend WithEvents Valeur_inDataSet As Valeur_inDataSet
    Friend WithEvents NomCDataTableTableAdapter As Valeur_inDataSetTableAdapters.NomCDataTableTableAdapter
    Friend WithEvents CachedEchn_versCrystalReport1 As CachedEchn_versCrystalReport
End Class
