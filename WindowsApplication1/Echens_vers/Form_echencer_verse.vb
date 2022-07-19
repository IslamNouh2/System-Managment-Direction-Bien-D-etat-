Imports System.Data
Imports System.Data.SqlClient






Public Class Form_echencer_verse


    'dim conn As New SqlConnection("Data Source=ISLAMOUH-PC\SQLEXPRESS;Initial Catalog=droit_propriter_etat;Integrated Security=True")

    Private Sub fillBenefic()
        conn = getconnect()
        conn.Open()
        Dim query = "select * from dbo.Beneficiaire"
        Dim cmd As New SqlCommand(query, conn)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        adapter.Fill(tbl)
        Beneficiaire_cd_beneComboBox.DataSource = tbl
        Beneficiaire_cd_beneComboBox.DisplayMember = "Cd_bene"
        Beneficiaire_cd_beneComboBox.ValueMember = "Cd_bene"
        conn.Close()

    End Sub


    Private Sub fillAbattment()
        conn = getconnect()
        conn.Open()
        Dim query = "select * from dbo.Abattement"
        Dim cmd As New SqlCommand(query, conn)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        adapter.Fill(tbl)
        Abattement_cd_abatComboBox.DataSource = tbl
        Abattement_cd_abatComboBox.DisplayMember = "Duree_vers"
        Abattement_cd_abatComboBox.ValueMember = "Duree_vers"
        conn.Close()

    End Sub

    Private Sub Form_echencer_verse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Echen_versDataSet.ListeNomCompletDataTable' table. You can move, or remove it, as needed.
        Me.ListeNomCompletDataTableTableAdapter.Fill(Me.Echen_versDataSet.ListeNomCompletDataTable)
        'TODO: This line of code loads data into the 'Echen_versDataSet.ListeNomCompletDataTable' table. You can move, or remove it, as needed.
        Me.ListeNomCompletDataTableTableAdapter.Fill(Me.Echen_versDataSet.ListeNomCompletDataTable)
        'TODO: This line of code loads data into the 'Droit_propriter_etatDataSet.Echencer_Versement' table. You can move, or remove it, as needed.
        Me.Echencer_VersementTableAdapter.Fill(Me.Droit_propriter_etatDataSet.Echencer_Versement)
        'TODO: This line of code loads data into the 'Droit_propriter_etatDataSet.Echencer_Versement' table. You can move, or remove it, as needed.
        Me.Echencer_VersementTableAdapter.Fill(Me.Droit_propriter_etatDataSet.Echencer_Versement)
        'TODO: This line of code loads data into the 'Droit_propriter_etatDataSet.Abattement' table. You can move, or remove it, as needed.
        Me.AbattementTableAdapter.Fill(Me.Droit_propriter_etatDataSet.Abattement)
        'TODO: This line of code loads data into the 'Droit_propriter_etatDataSet.Beneficiaire' table. You can move, or remove it, as needed.
        Me.BeneficiaireTableAdapter.Fill(Me.Droit_propriter_etatDataSet.Beneficiaire)
        'TODO: This line of code loads data from table beneficiare to comboBox   
        'fillBenefic()
        'TODO: This line of code loads data from table Abattment to comboBox   
        'fillAbattment()

    End Sub

    Private Sub charge()
        'TODO: This line of code loads data into the 'Echen_versDataSet.ListeNomCompletDataTable' table. You can move, or remove it, as needed.
        Me.ListeNomCompletDataTableTableAdapter.Fill(Me.Echen_versDataSet.ListeNomCompletDataTable)
        'TODO: This line of code loads data into the 'Echen_versDataSet.ListeNomCompletDataTable' table. You can move, or remove it, as needed.
        Me.ListeNomCompletDataTableTableAdapter.Fill(Me.Echen_versDataSet.ListeNomCompletDataTable)
        'TODO: This line of code loads data into the 'Droit_propriter_etatDataSet.Echencer_Versement' table. You can move, or remove it, as needed.
        Me.Echencer_VersementTableAdapter.Fill(Me.Droit_propriter_etatDataSet.Echencer_Versement)
        'TODO: This line of code loads data into the 'Droit_propriter_etatDataSet.Echencer_Versement' table. You can move, or remove it, as needed.
        Me.Echencer_VersementTableAdapter.Fill(Me.Droit_propriter_etatDataSet.Echencer_Versement)
        'TODO: This line of code loads data into the 'Droit_propriter_etatDataSet.Abattement' table. You can move, or remove it, as needed.
        Me.AbattementTableAdapter.Fill(Me.Droit_propriter_etatDataSet.Abattement)
        'TODO: This line of code loads data into the 'Droit_propriter_etatDataSet.Beneficiaire' table. You can move, or remove it, as needed.
        Me.BeneficiaireTableAdapter.Fill(Me.Droit_propriter_etatDataSet.Beneficiaire)
        'TODO: This line of code loads data from table beneficiare to comboBox   
        'fillBenefic()
        'TODO: This line of code loads data from table Abattment to comboBox   
        'fillAbattment()
    End Sub


    Private Sub abattbtn_Click(sender As Object, e As EventArgs) Handles abattbtn.Click
        Form_Abattment.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        form_RPCR.cd_ben = Beneficiaire_cd_beneComboBox.SelectedValue
        MsgBox(Me.Beneficiaire_cd_beneComboBox.SelectedValue)
        form_RPCR.Show()
    End Sub






    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Me.Validate()
        Me.Echencer_VersementBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Droit_propriter_etatDataSet)
        charge()
    End Sub
End Class

