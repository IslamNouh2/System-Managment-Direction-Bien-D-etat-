<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDroi_pro
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
        Dim Beneficiaire_cd_beneLabel As System.Windows.Forms.Label
        Dim Dat_tab_vers_droi_prop_etatLabel As System.Windows.Forms.Label
        Dim N_tab_vers_droi_prop_etatLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDroi_pro))
        Me.Droit_propriter_etatDataSet1 = New WindowsApplication1.droit_propriter_etatDataSet()
        Me.Droits_de_propriete_de_etatBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Droits_de_propriete_de_etatTableAdapter1 = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.Droits_de_propriete_de_etatTableAdapter()
        Me.TableAdapterManager1 = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.TableAdapterManager()
        Me.Droits_de_propriete_de_etatBindingSource1BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Droits_de_propriete_de_etatBindingSource1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Droits_de_propriete_de_etatDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N_tab_vers_droi_prop_etatTextBox1 = New System.Windows.Forms.TextBox()
        Me.Dat_tab_vers_droi_prop_etatDateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Beneficiaire_cd_beneComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Nom_completBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Droit_proDataSet1 = New WindowsApplication1.droit_proDataSet()
        Me.Nom_completTableAdapter1 = New WindowsApplication1.droit_proDataSetTableAdapters.Nom_completTableAdapter()
        Me.TableAdapterManager3 = New WindowsApplication1.droit_proDataSetTableAdapters.TableAdapterManager()
        Me.print_dro = New System.Windows.Forms.Button()
        Beneficiaire_cd_beneLabel = New System.Windows.Forms.Label()
        Dat_tab_vers_droi_prop_etatLabel = New System.Windows.Forms.Label()
        N_tab_vers_droi_prop_etatLabel = New System.Windows.Forms.Label()
        CType(Me.Droit_propriter_etatDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Droits_de_propriete_de_etatBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Droits_de_propriete_de_etatBindingSource1BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Droits_de_propriete_de_etatBindingSource1BindingNavigator.SuspendLayout()
        CType(Me.Droits_de_propriete_de_etatDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nom_completBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Droit_proDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Beneficiaire_cd_beneLabel
        '
        Beneficiaire_cd_beneLabel.AutoSize = True
        Beneficiaire_cd_beneLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Beneficiaire_cd_beneLabel.ForeColor = System.Drawing.Color.White
        Beneficiaire_cd_beneLabel.Location = New System.Drawing.Point(590, 185)
        Beneficiaire_cd_beneLabel.Name = "Beneficiaire_cd_beneLabel"
        Beneficiaire_cd_beneLabel.Size = New System.Drawing.Size(72, 19)
        Beneficiaire_cd_beneLabel.TabIndex = 8
        Beneficiaire_cd_beneLabel.Text = "رمز المستفيد"
        '
        'Dat_tab_vers_droi_prop_etatLabel
        '
        Dat_tab_vers_droi_prop_etatLabel.AutoSize = True
        Dat_tab_vers_droi_prop_etatLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Dat_tab_vers_droi_prop_etatLabel.ForeColor = System.Drawing.Color.White
        Dat_tab_vers_droi_prop_etatLabel.Location = New System.Drawing.Point(772, 96)
        Dat_tab_vers_droi_prop_etatLabel.Name = "Dat_tab_vers_droi_prop_etatLabel"
        Dat_tab_vers_droi_prop_etatLabel.Size = New System.Drawing.Size(231, 19)
        Dat_tab_vers_droi_prop_etatLabel.TabIndex = 4
        Dat_tab_vers_droi_prop_etatLabel.Text = "تاريح جدول الدفع الخاص بحقوق أملاك الدولة"
        '
        'N_tab_vers_droi_prop_etatLabel
        '
        N_tab_vers_droi_prop_etatLabel.AutoSize = True
        N_tab_vers_droi_prop_etatLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        N_tab_vers_droi_prop_etatLabel.ForeColor = System.Drawing.Color.White
        N_tab_vers_droi_prop_etatLabel.Location = New System.Drawing.Point(299, 96)
        N_tab_vers_droi_prop_etatLabel.Name = "N_tab_vers_droi_prop_etatLabel"
        N_tab_vers_droi_prop_etatLabel.Size = New System.Drawing.Size(220, 19)
        N_tab_vers_droi_prop_etatLabel.TabIndex = 2
        N_tab_vers_droi_prop_etatLabel.Text = "رقم جدول الدفع الخاص بحقوق أملاك الدولة"
        '
        'Droit_propriter_etatDataSet1
        '
        Me.Droit_propriter_etatDataSet1.DataSetName = "droit_propriter_etatDataSet"
        Me.Droit_propriter_etatDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Droits_de_propriete_de_etatBindingSource1
        '
        Me.Droits_de_propriete_de_etatBindingSource1.DataMember = "Droits_de_propriete_de_etat"
        Me.Droits_de_propriete_de_etatBindingSource1.DataSource = Me.Droit_propriter_etatDataSet1
        '
        'Droits_de_propriete_de_etatTableAdapter1
        '
        Me.Droits_de_propriete_de_etatTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.AbattementTableAdapter = Nothing
        Me.TableAdapterManager1.Arrete_cession_bien_etatTableAdapter = Nothing
        Me.TableAdapterManager1.Attestation_paiemnet_loyerTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.BeneficiaireTableAdapter = Nothing
        Me.TableAdapterManager1.Calendrier_valueur_initaleTableAdapter = Nothing
        Me.TableAdapterManager1.Certificat_engagement_achatTableAdapter = Nothing
        Me.TableAdapterManager1.Commission_cession_immobiliereTableAdapter = Nothing
        Me.TableAdapterManager1.CommuneTableAdapter = Nothing
        Me.TableAdapterManager1.DairaTableAdapter = Nothing
        Me.TableAdapterManager1.Demande_acquisitionTableAdapter = Nothing
        Me.TableAdapterManager1.DirecteurTableAdapter = Nothing
        Me.TableAdapterManager1.Droits_de_propriete_de_etatTableAdapter = Me.Droits_de_propriete_de_etatTableAdapter1
        Me.TableAdapterManager1.Echencer_VersementTableAdapter = Nothing
        Me.TableAdapterManager1.GestionnaireTableAdapter = Nothing
        Me.TableAdapterManager1.LocalTableAdapter = Nothing
        Me.TableAdapterManager1.NomC_direcTableAdapter = Nothing
        Me.TableAdapterManager1.NomCBeneficiaireTableAdapter = Nothing
        Me.TableAdapterManager1.PV_Commession_CessionTableAdapter = Nothing
        Me.TableAdapterManager1.QuartierTableAdapter = Nothing
        Me.TableAdapterManager1.Rapport_evaluationTableAdapter = Nothing
        Me.TableAdapterManager1.ResidenceTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = WindowsApplication1.droit_propriter_etatDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.usersTableAdapter = Nothing
        Me.TableAdapterManager1.WilayaTableAdapter = Nothing
        '
        'Droits_de_propriete_de_etatBindingSource1BindingNavigator
        '
        Me.Droits_de_propriete_de_etatBindingSource1BindingNavigator.AddNewItem = Me.ToolStripButton5
        Me.Droits_de_propriete_de_etatBindingSource1BindingNavigator.BindingSource = Me.Droits_de_propriete_de_etatBindingSource1
        Me.Droits_de_propriete_de_etatBindingSource1BindingNavigator.CountItem = Me.ToolStripLabel1
        Me.Droits_de_propriete_de_etatBindingSource1BindingNavigator.DeleteItem = Me.ToolStripButton6
        Me.Droits_de_propriete_de_etatBindingSource1BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator3, Me.ToolStripButton5, Me.ToolStripButton6, Me.Droits_de_propriete_de_etatBindingSource1BindingNavigatorSaveItem})
        Me.Droits_de_propriete_de_etatBindingSource1BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Droits_de_propriete_de_etatBindingSource1BindingNavigator.MoveFirstItem = Me.ToolStripButton1
        Me.Droits_de_propriete_de_etatBindingSource1BindingNavigator.MoveLastItem = Me.ToolStripButton4
        Me.Droits_de_propriete_de_etatBindingSource1BindingNavigator.MoveNextItem = Me.ToolStripButton3
        Me.Droits_de_propriete_de_etatBindingSource1BindingNavigator.MovePreviousItem = Me.ToolStripButton2
        Me.Droits_de_propriete_de_etatBindingSource1BindingNavigator.Name = "Droits_de_propriete_de_etatBindingSource1BindingNavigator"
        Me.Droits_de_propriete_de_etatBindingSource1BindingNavigator.PositionItem = Me.ToolStripTextBox1
        Me.Droits_de_propriete_de_etatBindingSource1BindingNavigator.Size = New System.Drawing.Size(1029, 25)
        Me.Droits_de_propriete_de_etatBindingSource1BindingNavigator.TabIndex = 0
        Me.Droits_de_propriete_de_etatBindingSource1BindingNavigator.Text = "BindingNavigator1"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Add new"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel1.Text = "of {0}"
        Me.ToolStripLabel1.ToolTipText = "Total number of items"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "Delete"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Move first"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Move previous"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Position"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Current position"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Move next"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Move last"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'Droits_de_propriete_de_etatBindingSource1BindingNavigatorSaveItem
        '
        Me.Droits_de_propriete_de_etatBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Droits_de_propriete_de_etatBindingSource1BindingNavigatorSaveItem.Image = CType(resources.GetObject("Droits_de_propriete_de_etatBindingSource1BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Droits_de_propriete_de_etatBindingSource1BindingNavigatorSaveItem.Name = "Droits_de_propriete_de_etatBindingSource1BindingNavigatorSaveItem"
        Me.Droits_de_propriete_de_etatBindingSource1BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Droits_de_propriete_de_etatBindingSource1BindingNavigatorSaveItem.Text = "Save Data"
        '
        'Droits_de_propriete_de_etatDataGridView1
        '
        Me.Droits_de_propriete_de_etatDataGridView1.AutoGenerateColumns = False
        Me.Droits_de_propriete_de_etatDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Droits_de_propriete_de_etatDataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.Droits_de_propriete_de_etatDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Droits_de_propriete_de_etatDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7})
        Me.Droits_de_propriete_de_etatDataGridView1.DataSource = Me.Droits_de_propriete_de_etatBindingSource1
        Me.Droits_de_propriete_de_etatDataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Droits_de_propriete_de_etatDataGridView1.Location = New System.Drawing.Point(0, 295)
        Me.Droits_de_propriete_de_etatDataGridView1.Name = "Droits_de_propriete_de_etatDataGridView1"
        Me.Droits_de_propriete_de_etatDataGridView1.Size = New System.Drawing.Size(1029, 220)
        Me.Droits_de_propriete_de_etatDataGridView1.TabIndex = 1
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "N_tab_vers_droi_prop_etat"
        Me.DataGridViewTextBoxColumn3.HeaderText = "N_tab_vers_droi_prop_etat"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Dat_tab_vers_droi_prop_etat"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Dat_tab_vers_droi_prop_etat"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "beneficiaire_cd_bene"
        Me.DataGridViewTextBoxColumn7.HeaderText = "beneficiaire_cd_bene"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'N_tab_vers_droi_prop_etatTextBox1
        '
        Me.N_tab_vers_droi_prop_etatTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Droits_de_propriete_de_etatBindingSource1, "N_tab_vers_droi_prop_etat", True))
        Me.N_tab_vers_droi_prop_etatTextBox1.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.N_tab_vers_droi_prop_etatTextBox1.Location = New System.Drawing.Point(77, 93)
        Me.N_tab_vers_droi_prop_etatTextBox1.Name = "N_tab_vers_droi_prop_etatTextBox1"
        Me.N_tab_vers_droi_prop_etatTextBox1.Size = New System.Drawing.Size(200, 27)
        Me.N_tab_vers_droi_prop_etatTextBox1.TabIndex = 3
        '
        'Dat_tab_vers_droi_prop_etatDateTimePicker1
        '
        Me.Dat_tab_vers_droi_prop_etatDateTimePicker1.CustomFormat = "dd/mm/yyyy"
        Me.Dat_tab_vers_droi_prop_etatDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Droits_de_propriete_de_etatBindingSource1, "Dat_tab_vers_droi_prop_etat", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "d"))
        Me.Dat_tab_vers_droi_prop_etatDateTimePicker1.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dat_tab_vers_droi_prop_etatDateTimePicker1.Location = New System.Drawing.Point(550, 93)
        Me.Dat_tab_vers_droi_prop_etatDateTimePicker1.Name = "Dat_tab_vers_droi_prop_etatDateTimePicker1"
        Me.Dat_tab_vers_droi_prop_etatDateTimePicker1.Size = New System.Drawing.Size(200, 27)
        Me.Dat_tab_vers_droi_prop_etatDateTimePicker1.TabIndex = 5
        Me.Dat_tab_vers_droi_prop_etatDateTimePicker1.Value = New Date(2022, 6, 9, 0, 0, 0, 0)
        '
        'Beneficiaire_cd_beneComboBox1
        '
        Me.Beneficiaire_cd_beneComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Droits_de_propriete_de_etatBindingSource1, "beneficiaire_cd_bene", True))
        Me.Beneficiaire_cd_beneComboBox1.DataSource = Me.Nom_completBindingSource1
        Me.Beneficiaire_cd_beneComboBox1.DisplayMember = "NomComplet"
        Me.Beneficiaire_cd_beneComboBox1.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Beneficiaire_cd_beneComboBox1.FormattingEnabled = True
        Me.Beneficiaire_cd_beneComboBox1.Location = New System.Drawing.Point(367, 182)
        Me.Beneficiaire_cd_beneComboBox1.Name = "Beneficiaire_cd_beneComboBox1"
        Me.Beneficiaire_cd_beneComboBox1.Size = New System.Drawing.Size(200, 27)
        Me.Beneficiaire_cd_beneComboBox1.TabIndex = 9
        Me.Beneficiaire_cd_beneComboBox1.ValueMember = "Cd_bene"
        '
        'Nom_completBindingSource1
        '
        Me.Nom_completBindingSource1.DataMember = "Nom_complet"
        Me.Nom_completBindingSource1.DataSource = Me.Droit_proDataSet1
        '
        'Droit_proDataSet1
        '
        Me.Droit_proDataSet1.DataSetName = "droit_proDataSet"
        Me.Droit_proDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Nom_completTableAdapter1
        '
        Me.Nom_completTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.Beneficiaire_DTableAdapter = Nothing
        Me.TableAdapterManager3.Commune_DTableAdapter = Nothing
        Me.TableAdapterManager3.Droits_de_propriete_de_etatTableAdapter = Nothing
        Me.TableAdapterManager3.Local_DTableAdapter = Nothing
        Me.TableAdapterManager3.Nom_completTableAdapter = Me.Nom_completTableAdapter1
        Me.TableAdapterManager3.Quartier_DTableAdapter = Nothing
        Me.TableAdapterManager3.Residence_DTableAdapter = Nothing
        Me.TableAdapterManager3.UpdateOrder = WindowsApplication1.droit_proDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager3.Wilaya_DTableAdapter = Nothing
        '
        'print_dro
        '
        Me.print_dro.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.print_dro.FlatAppearance.BorderSize = 0
        Me.print_dro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.print_dro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.print_dro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.print_dro.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.print_dro.ForeColor = System.Drawing.Color.White
        Me.print_dro.Location = New System.Drawing.Point(385, 251)
        Me.print_dro.Name = "print_dro"
        Me.print_dro.Size = New System.Drawing.Size(212, 38)
        Me.print_dro.TabIndex = 10
        Me.print_dro.Text = "إستخـراج جدول الدفــع"
        Me.print_dro.UseVisualStyleBackColor = False
        '
        'FormDroi_pro
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1029, 515)
        Me.Controls.Add(Me.print_dro)
        Me.Controls.Add(N_tab_vers_droi_prop_etatLabel)
        Me.Controls.Add(Me.N_tab_vers_droi_prop_etatTextBox1)
        Me.Controls.Add(Dat_tab_vers_droi_prop_etatLabel)
        Me.Controls.Add(Me.Dat_tab_vers_droi_prop_etatDateTimePicker1)
        Me.Controls.Add(Beneficiaire_cd_beneLabel)
        Me.Controls.Add(Me.Beneficiaire_cd_beneComboBox1)
        Me.Controls.Add(Me.Droits_de_propriete_de_etatDataGridView1)
        Me.Controls.Add(Me.Droits_de_propriete_de_etatBindingSource1BindingNavigator)
        Me.Name = "FormDroi_pro"
        Me.Text = "حقوق أملاك الدولة"
        CType(Me.Droit_propriter_etatDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Droits_de_propriete_de_etatBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Droits_de_propriete_de_etatBindingSource1BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Droits_de_propriete_de_etatBindingSource1BindingNavigator.ResumeLayout(False)
        Me.Droits_de_propriete_de_etatBindingSource1BindingNavigator.PerformLayout()
        CType(Me.Droits_de_propriete_de_etatDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nom_completBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Droit_proDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Droit_propriter_etatDataSet As droit_propriter_etatDataSet
    Friend WithEvents Droits_de_propriete_de_etatBindingSource As BindingSource
    Friend WithEvents Droits_de_propriete_de_etatTableAdapter As droit_propriter_etatDataSetTableAdapters.Droits_de_propriete_de_etatTableAdapter
    Friend WithEvents TableAdapterManager As droit_propriter_etatDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Droits_de_propriete_de_etatBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Droits_de_propriete_de_etatBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Droits_de_propriete_de_etatDataGridView As DataGridView
    Friend WithEvents N_tab_vers_droi_prop_etatTextBox As TextBox
    Friend WithEvents Dat_tab_vers_droi_prop_etatDateTimePicker As DateTimePicker
    Friend WithEvents Beneficiaire_cd_beneComboBox As ComboBox
    Friend WithEvents Echen_versDataSet As echen_versDataSet
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Droit_proDataSet As droit_proDataSet
    Friend WithEvents Nom_completBindingSource As BindingSource
    Friend WithEvents Nom_completTableAdapter As droit_proDataSetTableAdapters.Nom_completTableAdapter
    Friend WithEvents TableAdapterManager2 As droit_proDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button1 As Button
    Friend WithEvents Droit_propriter_etatDataSet1 As droit_propriter_etatDataSet
    Friend WithEvents Droits_de_propriete_de_etatBindingSource1 As BindingSource
    Friend WithEvents Droits_de_propriete_de_etatTableAdapter1 As droit_propriter_etatDataSetTableAdapters.Droits_de_propriete_de_etatTableAdapter
    Friend WithEvents TableAdapterManager1 As droit_propriter_etatDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Droits_de_propriete_de_etatBindingSource1BindingNavigator As BindingNavigator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents Droits_de_propriete_de_etatBindingSource1BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Droits_de_propriete_de_etatDataGridView1 As DataGridView
    Friend WithEvents N_tab_vers_droi_prop_etatTextBox1 As TextBox
    Friend WithEvents Dat_tab_vers_droi_prop_etatDateTimePicker1 As DateTimePicker
    Friend WithEvents Beneficiaire_cd_beneComboBox1 As ComboBox
    Friend WithEvents Droit_proDataSet1 As droit_proDataSet
    Friend WithEvents Nom_completBindingSource1 As BindingSource
    Friend WithEvents Nom_completTableAdapter1 As droit_proDataSetTableAdapters.Nom_completTableAdapter
    Friend WithEvents TableAdapterManager3 As droit_proDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents print_dro As Button
End Class
