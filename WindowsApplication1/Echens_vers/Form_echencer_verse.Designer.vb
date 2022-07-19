<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_echencer_verse
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
        Dim Num_tab_versLabel As System.Windows.Forms.Label
        Dim Dat_tab_versLabel As System.Windows.Forms.Label
        Dim Mont_loy_retLabel As System.Windows.Forms.Label
        Dim Mont_vers_initLabel As System.Windows.Forms.Label
        Dim Mont_GarLabel As System.Windows.Forms.Label
        Dim Beneficiaire_cd_beneLabel As System.Windows.Forms.Label
        Dim Abattement_cd_abatLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_echencer_verse))
        Me.Droit_propriter_etatDataSet = New WindowsApplication1.droit_propriter_etatDataSet()
        Me.Echencer_VersementDataGridView = New System.Windows.Forms.DataGridView()
        Me.Echencer_VersementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dat_tab_versDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Mont_loy_retTextBox = New System.Windows.Forms.TextBox()
        Me.Mont_vers_initTextBox = New System.Windows.Forms.TextBox()
        Me.Mont_GarTextBox = New System.Windows.Forms.TextBox()
        Me.abattbtn = New System.Windows.Forms.Button()
        Me.Beneficiaire_cd_beneComboBox = New System.Windows.Forms.ComboBox()
        Me.ListeNomCompletDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Echen_versDataSet = New WindowsApplication1.echen_versDataSet()
        Me.BeneficiaireBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Abattement_cd_abatComboBox = New System.Windows.Forms.ComboBox()
        Me.AbattementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BeneficiaireTableAdapter = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.BeneficiaireTableAdapter()
        Me.AbattementTableAdapter = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.AbattementTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Echencer_VersementTableAdapter = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.Echencer_VersementTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.TableAdapterManager()
        Me.BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ListeNomCompletDataTableTableAdapter = New WindowsApplication1.echen_versDataSetTableAdapters.ListeNomCompletDataTableTableAdapter()
        Me.Num_tab_versTextBox = New System.Windows.Forms.TextBox()
        Me.Droits_handComboBox = New System.Windows.Forms.ComboBox()
        Me.NumtabversDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DattabversDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontloyretDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontversinitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontGarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BeneficiairecdbeneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AbattementcdabatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.droits_hand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Num_tab_versLabel = New System.Windows.Forms.Label()
        Dat_tab_versLabel = New System.Windows.Forms.Label()
        Mont_loy_retLabel = New System.Windows.Forms.Label()
        Mont_vers_initLabel = New System.Windows.Forms.Label()
        Mont_GarLabel = New System.Windows.Forms.Label()
        Beneficiaire_cd_beneLabel = New System.Windows.Forms.Label()
        Abattement_cd_abatLabel = New System.Windows.Forms.Label()
        CType(Me.Droit_propriter_etatDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Echencer_VersementDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Echencer_VersementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListeNomCompletDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Echen_versDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BeneficiaireBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AbattementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Num_tab_versLabel
        '
        Num_tab_versLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Num_tab_versLabel.AutoSize = True
        Num_tab_versLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Num_tab_versLabel.ForeColor = System.Drawing.Color.White
        Num_tab_versLabel.Location = New System.Drawing.Point(357, 73)
        Num_tab_versLabel.Name = "Num_tab_versLabel"
        Num_tab_versLabel.Size = New System.Drawing.Size(85, 20)
        Num_tab_versLabel.TabIndex = 2
        Num_tab_versLabel.Text = "رقم جدول الدفع"
        '
        'Dat_tab_versLabel
        '
        Dat_tab_versLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Dat_tab_versLabel.AutoSize = True
        Dat_tab_versLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Dat_tab_versLabel.ForeColor = System.Drawing.Color.White
        Dat_tab_versLabel.Location = New System.Drawing.Point(335, 118)
        Dat_tab_versLabel.Name = "Dat_tab_versLabel"
        Dat_tab_versLabel.Size = New System.Drawing.Size(108, 20)
        Dat_tab_versLabel.TabIndex = 4
        Dat_tab_versLabel.Text = "تاريخ الجدول الدفع "
        '
        'Mont_loy_retLabel
        '
        Mont_loy_retLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Mont_loy_retLabel.AutoSize = True
        Mont_loy_retLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Mont_loy_retLabel.ForeColor = System.Drawing.Color.White
        Mont_loy_retLabel.Location = New System.Drawing.Point(323, 157)
        Mont_loy_retLabel.Name = "Mont_loy_retLabel"
        Mont_loy_retLabel.Size = New System.Drawing.Size(119, 20)
        Mont_loy_retLabel.TabIndex = 6
        Mont_loy_retLabel.Text = "مبلغ الإيجار المخصوم"
        '
        'Mont_vers_initLabel
        '
        Mont_vers_initLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Mont_vers_initLabel.AutoSize = True
        Mont_vers_initLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Mont_vers_initLabel.ForeColor = System.Drawing.Color.White
        Mont_vers_initLabel.Location = New System.Drawing.Point(345, 203)
        Mont_vers_initLabel.Name = "Mont_vers_initLabel"
        Mont_vers_initLabel.Size = New System.Drawing.Size(93, 20)
        Mont_vers_initLabel.TabIndex = 8
        Mont_vers_initLabel.Text = "مبلغ الدفع المبدئي"
        '
        'Mont_GarLabel
        '
        Mont_GarLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Mont_GarLabel.AutoSize = True
        Mont_GarLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Mont_GarLabel.ForeColor = System.Drawing.Color.White
        Mont_GarLabel.Location = New System.Drawing.Point(866, 73)
        Mont_GarLabel.Name = "Mont_GarLabel"
        Mont_GarLabel.Size = New System.Drawing.Size(70, 20)
        Mont_GarLabel.TabIndex = 10
        Mont_GarLabel.Text = "مبلغ الضمان"
        '
        'Beneficiaire_cd_beneLabel
        '
        Beneficiaire_cd_beneLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Beneficiaire_cd_beneLabel.AutoSize = True
        Beneficiaire_cd_beneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Beneficiaire_cd_beneLabel.ForeColor = System.Drawing.Color.White
        Beneficiaire_cd_beneLabel.Location = New System.Drawing.Point(885, 118)
        Beneficiaire_cd_beneLabel.Name = "Beneficiaire_cd_beneLabel"
        Beneficiaire_cd_beneLabel.Size = New System.Drawing.Size(52, 20)
        Beneficiaire_cd_beneLabel.TabIndex = 14
        Beneficiaire_cd_beneLabel.Text = " المستفيد"
        '
        'Abattement_cd_abatLabel
        '
        Abattement_cd_abatLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Abattement_cd_abatLabel.AutoSize = True
        Abattement_cd_abatLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Abattement_cd_abatLabel.ForeColor = System.Drawing.Color.White
        Abattement_cd_abatLabel.Location = New System.Drawing.Point(861, 164)
        Abattement_cd_abatLabel.Name = "Abattement_cd_abatLabel"
        Abattement_cd_abatLabel.Size = New System.Drawing.Size(79, 20)
        Abattement_cd_abatLabel.TabIndex = 16
        Abattement_cd_abatLabel.Text = "رمز التخفيض"
        '
        'Droit_propriter_etatDataSet
        '
        Me.Droit_propriter_etatDataSet.DataSetName = "droit_propriter_etatDataSet"
        Me.Droit_propriter_etatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Echencer_VersementDataGridView
        '
        Me.Echencer_VersementDataGridView.AutoGenerateColumns = False
        Me.Echencer_VersementDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Echencer_VersementDataGridView.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.Echencer_VersementDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Echencer_VersementDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumtabversDataGridViewTextBoxColumn, Me.DattabversDataGridViewTextBoxColumn, Me.MontloyretDataGridViewTextBoxColumn, Me.MontversinitDataGridViewTextBoxColumn, Me.MontGarDataGridViewTextBoxColumn, Me.BeneficiairecdbeneDataGridViewTextBoxColumn, Me.AbattementcdabatDataGridViewTextBoxColumn, Me.droits_hand})
        Me.Echencer_VersementDataGridView.DataSource = Me.Echencer_VersementBindingSource
        Me.Echencer_VersementDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Echencer_VersementDataGridView.Location = New System.Drawing.Point(0, 339)
        Me.Echencer_VersementDataGridView.Name = "Echencer_VersementDataGridView"
        Me.Echencer_VersementDataGridView.Size = New System.Drawing.Size(944, 188)
        Me.Echencer_VersementDataGridView.TabIndex = 1
        '
        'Echencer_VersementBindingSource
        '
        Me.Echencer_VersementBindingSource.DataMember = "Echencer_Versement"
        Me.Echencer_VersementBindingSource.DataSource = Me.Droit_propriter_etatDataSet
        '
        'Dat_tab_versDateTimePicker
        '
        Me.Dat_tab_versDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Dat_tab_versDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Echencer_VersementBindingSource, "Dat_tab_vers", True))
        Me.Dat_tab_versDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dat_tab_versDateTimePicker.Location = New System.Drawing.Point(87, 112)
        Me.Dat_tab_versDateTimePicker.Name = "Dat_tab_versDateTimePicker"
        Me.Dat_tab_versDateTimePicker.Size = New System.Drawing.Size(200, 26)
        Me.Dat_tab_versDateTimePicker.TabIndex = 5
        '
        'Mont_loy_retTextBox
        '
        Me.Mont_loy_retTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Mont_loy_retTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Echencer_VersementBindingSource, "Mont_loy_ret", True))
        Me.Mont_loy_retTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mont_loy_retTextBox.Location = New System.Drawing.Point(87, 154)
        Me.Mont_loy_retTextBox.Name = "Mont_loy_retTextBox"
        Me.Mont_loy_retTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Mont_loy_retTextBox.TabIndex = 7
        '
        'Mont_vers_initTextBox
        '
        Me.Mont_vers_initTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Mont_vers_initTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Echencer_VersementBindingSource, "Mont_vers_init", True))
        Me.Mont_vers_initTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mont_vers_initTextBox.Location = New System.Drawing.Point(87, 200)
        Me.Mont_vers_initTextBox.Name = "Mont_vers_initTextBox"
        Me.Mont_vers_initTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Mont_vers_initTextBox.TabIndex = 9
        '
        'Mont_GarTextBox
        '
        Me.Mont_GarTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Mont_GarTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Echencer_VersementBindingSource, "Mont_Gar", True))
        Me.Mont_GarTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mont_GarTextBox.Location = New System.Drawing.Point(543, 70)
        Me.Mont_GarTextBox.Name = "Mont_GarTextBox"
        Me.Mont_GarTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Mont_GarTextBox.TabIndex = 11
        '
        'abattbtn
        '
        Me.abattbtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.abattbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.abattbtn.FlatAppearance.BorderSize = 0
        Me.abattbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.abattbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.abattbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.abattbtn.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.abattbtn.ForeColor = System.Drawing.Color.White
        Me.abattbtn.Location = New System.Drawing.Point(497, 280)
        Me.abattbtn.Name = "abattbtn"
        Me.abattbtn.Size = New System.Drawing.Size(153, 46)
        Me.abattbtn.TabIndex = 18
        Me.abattbtn.Text = "التخفيض"
        Me.abattbtn.UseVisualStyleBackColor = False
        '
        'Beneficiaire_cd_beneComboBox
        '
        Me.Beneficiaire_cd_beneComboBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Beneficiaire_cd_beneComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Echencer_VersementBindingSource, "beneficiaire_cd_bene", True))
        Me.Beneficiaire_cd_beneComboBox.DataSource = Me.ListeNomCompletDataTableBindingSource
        Me.Beneficiaire_cd_beneComboBox.DisplayMember = "NomC"
        Me.Beneficiaire_cd_beneComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Beneficiaire_cd_beneComboBox.FormattingEnabled = True
        Me.Beneficiaire_cd_beneComboBox.Location = New System.Drawing.Point(543, 115)
        Me.Beneficiaire_cd_beneComboBox.Name = "Beneficiaire_cd_beneComboBox"
        Me.Beneficiaire_cd_beneComboBox.Size = New System.Drawing.Size(200, 28)
        Me.Beneficiaire_cd_beneComboBox.TabIndex = 20
        Me.Beneficiaire_cd_beneComboBox.ValueMember = "Cd_bene"
        '
        'ListeNomCompletDataTableBindingSource
        '
        Me.ListeNomCompletDataTableBindingSource.DataMember = "ListeNomCompletDataTable"
        Me.ListeNomCompletDataTableBindingSource.DataSource = Me.Echen_versDataSet
        '
        'Echen_versDataSet
        '
        Me.Echen_versDataSet.DataSetName = "echen_versDataSet"
        Me.Echen_versDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BeneficiaireBindingSource
        '
        Me.BeneficiaireBindingSource.DataMember = "Beneficiaire"
        Me.BeneficiaireBindingSource.DataSource = Me.Droit_propriter_etatDataSet
        '
        'Abattement_cd_abatComboBox
        '
        Me.Abattement_cd_abatComboBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Abattement_cd_abatComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Echencer_VersementBindingSource, "abattement_cd_abat", True))
        Me.Abattement_cd_abatComboBox.DataSource = Me.AbattementBindingSource
        Me.Abattement_cd_abatComboBox.DisplayMember = "Duree_vers"
        Me.Abattement_cd_abatComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Abattement_cd_abatComboBox.FormattingEnabled = True
        Me.Abattement_cd_abatComboBox.Location = New System.Drawing.Point(543, 161)
        Me.Abattement_cd_abatComboBox.Name = "Abattement_cd_abatComboBox"
        Me.Abattement_cd_abatComboBox.Size = New System.Drawing.Size(200, 28)
        Me.Abattement_cd_abatComboBox.TabIndex = 22
        Me.Abattement_cd_abatComboBox.ValueMember = "Cd_abat"
        '
        'AbattementBindingSource
        '
        Me.AbattementBindingSource.DataMember = "Abattement"
        Me.AbattementBindingSource.DataSource = Me.Droit_propriter_etatDataSet
        '
        'BeneficiaireTableAdapter
        '
        Me.BeneficiaireTableAdapter.ClearBeforeFill = True
        '
        'AbattementTableAdapter
        '
        Me.AbattementTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(310, 280)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 46)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "نسخ جدول الدفع"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Echencer_VersementTableAdapter
        '
        Me.Echencer_VersementTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AbattementTableAdapter = Me.AbattementTableAdapter
        Me.TableAdapterManager.Arrete_cession_bien_etatTableAdapter = Nothing
        Me.TableAdapterManager.Attestation_paiemnet_loyerTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BeneficiaireTableAdapter = Me.BeneficiaireTableAdapter
        Me.TableAdapterManager.Calendrier_valueur_initaleTableAdapter = Nothing
        Me.TableAdapterManager.Certificat_engagement_achatTableAdapter = Nothing
        Me.TableAdapterManager.Commission_cession_immobiliereTableAdapter = Nothing
        Me.TableAdapterManager.CommuneTableAdapter = Nothing
        Me.TableAdapterManager.DairaTableAdapter = Nothing
        Me.TableAdapterManager.Demande_acquisitionTableAdapter = Nothing
        Me.TableAdapterManager.DirecteurTableAdapter = Nothing
        Me.TableAdapterManager.Droits_de_propriete_de_etatTableAdapter = Nothing
        Me.TableAdapterManager.Echencer_VersementTableAdapter = Me.Echencer_VersementTableAdapter
        Me.TableAdapterManager.GestionnaireTableAdapter = Nothing
        Me.TableAdapterManager.LocalTableAdapter = Nothing
        Me.TableAdapterManager.NomC_direcTableAdapter = Nothing
        Me.TableAdapterManager.NomCBeneficiaireTableAdapter = Nothing
        Me.TableAdapterManager.PV_Commession_CessionTableAdapter = Nothing
        Me.TableAdapterManager.QuartierTableAdapter = Nothing
        Me.TableAdapterManager.Rapport_evaluationTableAdapter = Nothing
        Me.TableAdapterManager.ResidenceTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.droit_propriter_etatDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        Me.TableAdapterManager.WilayaTableAdapter = Nothing
        '
        'BindingNavigator
        '
        Me.BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator.BindingSource = Me.Echencer_VersementBindingSource
        Me.BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SaveToolStripButton})
        Me.BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator.Name = "BindingNavigator"
        Me.BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator.Size = New System.Drawing.Size(944, 31)
        Me.BindingNavigator.TabIndex = 24
        Me.BindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 28)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(28, 28)
        Me.SaveToolStripButton.Text = "&Save"
        '
        'ListeNomCompletDataTableTableAdapter
        '
        Me.ListeNomCompletDataTableTableAdapter.ClearBeforeFill = True
        '
        'Num_tab_versTextBox
        '
        Me.Num_tab_versTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Num_tab_versTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Echencer_VersementBindingSource, "Num_tab_vers", True))
        Me.Num_tab_versTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num_tab_versTextBox.Location = New System.Drawing.Point(87, 70)
        Me.Num_tab_versTextBox.Name = "Num_tab_versTextBox"
        Me.Num_tab_versTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Num_tab_versTextBox.TabIndex = 25
        '
        'Droits_handComboBox
        '
        Me.Droits_handComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Echencer_VersementBindingSource, "droits_hand", True))
        Me.Droits_handComboBox.FormattingEnabled = True
        Me.Droits_handComboBox.Items.AddRange(New Object() {"O", "N"})
        Me.Droits_handComboBox.Location = New System.Drawing.Point(543, 205)
        Me.Droits_handComboBox.Name = "Droits_handComboBox"
        Me.Droits_handComboBox.Size = New System.Drawing.Size(200, 21)
        Me.Droits_handComboBox.TabIndex = 26
        '
        'NumtabversDataGridViewTextBoxColumn
        '
        Me.NumtabversDataGridViewTextBoxColumn.DataPropertyName = "Num_tab_vers"
        Me.NumtabversDataGridViewTextBoxColumn.HeaderText = "Num_tab_vers"
        Me.NumtabversDataGridViewTextBoxColumn.Name = "NumtabversDataGridViewTextBoxColumn"
        Me.NumtabversDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DattabversDataGridViewTextBoxColumn
        '
        Me.DattabversDataGridViewTextBoxColumn.DataPropertyName = "Dat_tab_vers"
        Me.DattabversDataGridViewTextBoxColumn.HeaderText = "Dat_tab_vers"
        Me.DattabversDataGridViewTextBoxColumn.Name = "DattabversDataGridViewTextBoxColumn"
        '
        'MontloyretDataGridViewTextBoxColumn
        '
        Me.MontloyretDataGridViewTextBoxColumn.DataPropertyName = "Mont_loy_ret"
        Me.MontloyretDataGridViewTextBoxColumn.HeaderText = "Mont_loy_ret"
        Me.MontloyretDataGridViewTextBoxColumn.Name = "MontloyretDataGridViewTextBoxColumn"
        '
        'MontversinitDataGridViewTextBoxColumn
        '
        Me.MontversinitDataGridViewTextBoxColumn.DataPropertyName = "Mont_vers_init"
        Me.MontversinitDataGridViewTextBoxColumn.HeaderText = "Mont_vers_init"
        Me.MontversinitDataGridViewTextBoxColumn.Name = "MontversinitDataGridViewTextBoxColumn"
        '
        'MontGarDataGridViewTextBoxColumn
        '
        Me.MontGarDataGridViewTextBoxColumn.DataPropertyName = "Mont_Gar"
        Me.MontGarDataGridViewTextBoxColumn.HeaderText = "Mont_Gar"
        Me.MontGarDataGridViewTextBoxColumn.Name = "MontGarDataGridViewTextBoxColumn"
        '
        'BeneficiairecdbeneDataGridViewTextBoxColumn
        '
        Me.BeneficiairecdbeneDataGridViewTextBoxColumn.DataPropertyName = "beneficiaire_cd_bene"
        Me.BeneficiairecdbeneDataGridViewTextBoxColumn.HeaderText = "beneficiaire_cd_bene"
        Me.BeneficiairecdbeneDataGridViewTextBoxColumn.Name = "BeneficiairecdbeneDataGridViewTextBoxColumn"
        '
        'AbattementcdabatDataGridViewTextBoxColumn
        '
        Me.AbattementcdabatDataGridViewTextBoxColumn.DataPropertyName = "abattement_cd_abat"
        Me.AbattementcdabatDataGridViewTextBoxColumn.HeaderText = "abattement_cd_abat"
        Me.AbattementcdabatDataGridViewTextBoxColumn.Name = "AbattementcdabatDataGridViewTextBoxColumn"
        '
        'droits_hand
        '
        Me.droits_hand.DataPropertyName = "droits_hand"
        Me.droits_hand.HeaderText = "droits_hand"
        Me.droits_hand.Name = "droits_hand"
        '
        'Form_echencer_verse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(944, 527)
        Me.Controls.Add(Me.Droits_handComboBox)
        Me.Controls.Add(Me.Num_tab_versTextBox)
        Me.Controls.Add(Me.BindingNavigator)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Abattement_cd_abatComboBox)
        Me.Controls.Add(Me.Beneficiaire_cd_beneComboBox)
        Me.Controls.Add(Me.abattbtn)
        Me.Controls.Add(Num_tab_versLabel)
        Me.Controls.Add(Dat_tab_versLabel)
        Me.Controls.Add(Me.Dat_tab_versDateTimePicker)
        Me.Controls.Add(Mont_loy_retLabel)
        Me.Controls.Add(Me.Mont_loy_retTextBox)
        Me.Controls.Add(Mont_vers_initLabel)
        Me.Controls.Add(Me.Mont_vers_initTextBox)
        Me.Controls.Add(Mont_GarLabel)
        Me.Controls.Add(Me.Mont_GarTextBox)
        Me.Controls.Add(Beneficiaire_cd_beneLabel)
        Me.Controls.Add(Abattement_cd_abatLabel)
        Me.Controls.Add(Me.Echencer_VersementDataGridView)
        Me.Name = "Form_echencer_verse"
        Me.Text = "جدول بالدفع"
        CType(Me.Droit_propriter_etatDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Echencer_VersementDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Echencer_VersementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListeNomCompletDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Echen_versDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BeneficiaireBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AbattementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator.ResumeLayout(False)
        Me.BindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Droit_propriter_etatDataSet As droit_propriter_etatDataSet
    Friend WithEvents Echencer_VersementDataGridView As DataGridView
    Friend WithEvents Dat_tab_versDateTimePicker As DateTimePicker
    Friend WithEvents Mont_loy_retTextBox As TextBox
    Friend WithEvents Mont_vers_initTextBox As TextBox
    Friend WithEvents Mont_GarTextBox As TextBox
    Friend WithEvents abattbtn As Button
    Friend WithEvents Beneficiaire_cd_beneComboBox As ComboBox
    Friend WithEvents Abattement_cd_abatComboBox As ComboBox
    Friend WithEvents BeneficiaireBindingSource As BindingSource
    Friend WithEvents BeneficiaireTableAdapter As droit_propriter_etatDataSetTableAdapters.BeneficiaireTableAdapter
    Friend WithEvents AbattementBindingSource As BindingSource
    Friend WithEvents AbattementTableAdapter As droit_propriter_etatDataSetTableAdapters.AbattementTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents Echencer_VersementBindingSource As BindingSource
    Friend WithEvents Echencer_VersementTableAdapter As droit_propriter_etatDataSetTableAdapters.Echencer_VersementTableAdapter
    Friend WithEvents TableAdapterManager As droit_propriter_etatDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BindingNavigator As BindingNavigator
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
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents Echen_versDataSet As echen_versDataSet
    Friend WithEvents ListeNomCompletDataTableBindingSource As BindingSource
    Friend WithEvents ListeNomCompletDataTableTableAdapter As echen_versDataSetTableAdapters.ListeNomCompletDataTableTableAdapter
    Friend WithEvents Num_tab_versTextBox As TextBox
    Friend WithEvents Droits_handComboBox As ComboBox
    Friend WithEvents NumtabversDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DattabversDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontloyretDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontversinitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontGarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BeneficiairecdbeneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AbattementcdabatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents droits_hand As DataGridViewTextBoxColumn
End Class
