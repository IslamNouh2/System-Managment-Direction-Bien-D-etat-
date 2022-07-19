Public Class form_RPCR

    Public cd_ben As String
    Private Sub form_RPCR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EchDataTableTableAdapter.Fill(Echen_versDataSet.EchDataTable)
        If (cd_ben.Trim <> "") Then
            Me.EchDataTableTableAdapter.FillBycd_bene(Echen_versDataSet.EchDataTable, cd_ben)
        End If
        Me.Echn_versCrystalReport.SetDataSource(Echen_versDataSet)
        Me.Echn_versCrystalReport.Refresh()


    End Sub


End Class