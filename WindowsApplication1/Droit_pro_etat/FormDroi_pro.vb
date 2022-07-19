Public Class FormDroi_pro


    Private Sub Droits_de_propriete_de_etatBindingSource1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Droits_de_propriete_de_etatBindingSource1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Droits_de_propriete_de_etatBindingSource1.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.Droit_propriter_etatDataSet1)

    End Sub

    Private Sub FormDroi_pro_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Droit_proDataSet1.Nom_complet' table. You can move, or remove it, as needed.
        Me.Nom_completTableAdapter1.FillNomComplet(Me.Droit_proDataSet1.Nom_complet)
        'TODO: This line of code loads data into the 'Droit_propriter_etatDataSet1.Droits_de_propriete_de_etat' table. You can move, or remove it, as needed.
        Me.Droits_de_propriete_de_etatTableAdapter1.Fill(Me.Droit_propriter_etatDataSet1.Droits_de_propriete_de_etat)

    End Sub

    Private Sub print_dro_Click(sender As Object, e As EventArgs) Handles print_dro.Click
        form_RPCR.cd_ben = Me.Beneficiaire_cd_beneComboBox1.SelectedValue
        MsgBox(Me.Beneficiaire_cd_beneComboBox1.SelectedValue)
        FormCRDP.Show()
    End Sub
End Class