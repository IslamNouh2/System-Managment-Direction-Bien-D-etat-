Public Class FormCRVI1

    Public Cd_ben As String
    Private Sub FormCRVI1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BeneficiaireTableAdapter.Fill(Me.Valeur_inDataSet.Beneficiaire)
        Me.QuartierTableAdapter.Fill(Me.Valeur_inDataSet.Quartier)
        Me.WilayaTableAdapter.Fill(Me.Valeur_inDataSet.Wilaya)
        Me.DairaTableAdapter.Fill(Me.Valeur_inDataSet.Daira)
        Me.CommuneTableAdapter.Fill(Me.Valeur_inDataSet.Commune)
        Me.Calendrier_valueur_initaleTableAdapter.Fill(Me.Valeur_inDataSet.Calendrier_valueur_initale)
        Me.LocalTableAdapter.Fill(Me.Valeur_inDataSet.Local)
        Me.ResidenceTableAdapter.Fill(Me.Valeur_inDataSet.Residence)
        Me.NomCDataTableTableAdapter.Fill(Me.Valeur_inDataSet.NomCDataTable)

        Try
            If (Cd_ben.Trim <> "") Then
                Me.BeneficiaireTableAdapter.FillByCd_be(Valeur_inDataSet.Beneficiaire, Cd_ben)
            End If
        Catch ex As Exception

        End Try

        Me.Valeur_INCrystalReport.SetDataSource(Valeur_inDataSet)
        Me.Valeur_INCrystalReport.Refresh()
    End Sub
End Class