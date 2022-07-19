Public Class FormCRDP
    Public Cd_ben As String

    Private Sub FormCRDP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Beneficiaire_DTableAdapter.Fill(Me.Droit_proDataSet.Beneficiaire)
        'Me.Quartier_DTableAdapter.Fill(Me.Droit_proDataSet.Quartier)
        'Me.Wilaya_DTableAdapter.Fill(Me.Droit_proDataSet.Wilaya)
        'Me.Daira_DTableAdapter.Fill(Me.Droit_proDataSet.Daira)
        'Me.Commune_DTableAdapter.Fill(Me.Droit_proDataSet.Commune)
        'Me.Droits_de_propriete_de_etatTableAdapter.Fill(Me.Droit_proDataSet.Droits_de_propriete_de_etat)
        'Me.Local_DTableAdapter.Fill(Me.Droit_proDataSet.Local)
        'Me.Residence_DTableAdapter.Fill(Me.Droit_proDataSet.Residence)
        'Me.Nom_completTableAdapter.FillNomComplet(Me.Droit_proDataSet.Nom_complet)
        Me.DroTableAdapter.Fill(Me.Droit_proDataSet.droDataTable)

        Try
            If (Cd_ben.Trim <> "") Then
                DroTableAdapter.FillByCd_bene(Droit_proDataSet.droDataTable, Cd_ben)
            End If
            Me.Droi_proCrystalReport.SetDataSource(Droit_proDataSet)
            Me.Droi_proCrystalReport.Refresh()
        Catch ex As Exception

        End Try

        Me.Droi_proCrystalReport.SetDataSource(Droit_proDataSet)
        Me.Droi_proCrystalReport.Refresh()



    End Sub
End Class