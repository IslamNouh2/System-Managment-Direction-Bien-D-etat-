Imports System.Data
Imports System.Data.SqlClient



Public Class Form_Login

    'Dim conn As New SqlConnection("Data Source=ISLAMOUH-PC\SQLSERVER;Initial Catalog=droit_propriter_etat;Integrated Security=True")


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cancelBTN.Click
        Application.Exit()
    End Sub


    Public Sub login()
        conn = getconnect()
        conn.Open()
        Dim query = "select * from users where username='" & usernametxt.Text & "' and password ='" & MD5(passwordtxt.Text) & "' and type= '" & TypeComboBox.SelectedItem & "' "
        Dim cmd As New SqlCommand(query, conn)
        Dim sda As New SqlDataAdapter(cmd)
        Dim dt As New DataTable("Type")
        sda.Fill(dt)


        If (dt.Rows.Count <= 0) Then
            MessageBox.Show("إسم المستخدم أو كلمة المرور غير صحيحة", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            MessageBox.Show("Login success!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Try
                If TypeComboBox.SelectedItem = "عـون معاينة" Then
                    form_dashboard.Show()
                    Me.Hide()
                    form_dashboard.Beneficiairebtn.Enabled = False
                    form_dashboard.localbtn.Enabled = True
                    form_dashboard.wilayabtn.Enabled = True
                    form_dashboard.Residancebtn.Enabled = True
                    form_dashboard.echen_versbtn.Enabled = True
                    form_dashboard.commi_cessbtn.Enabled = False
                    form_dashboard.echn_droit_probtn.Enabled = True
                    form_dashboard.echn_val_inbtn.Enabled = True
                    form_dashboard.arrete_cessbtn.Enabled = True
                    form_dashboard.engag_achabtn.Enabled = False
                    form_dashboard.attes_paie_loyerbtn.Enabled = False
                    FormDroi_pro.Droits_de_propriete_de_etatBindingSource1BindingNavigator.Enabled = False
                    Form_echenc_paie_initial.Calendrier_valueur_initaleBindingNavigator.Enabled = False
                    Form_echencer_verse.BindingNavigator.Enabled = False
                    Form_Abattment.AbattementBindingNavigator.Enabled = False

                Else
                    form_dashboard.Show()
                    Me.Hide()
                End If
            Catch ex As Exception

            End Try



        End If





    End Sub



    Private Sub loginBTN_Click_1(sender As Object, e As EventArgs) Handles loginBTN.Click
        login()
    End Sub

    Private Sub typeCB_KeyDown(sender As Object, e As KeyEventArgs) 
        If e.KeyCode = Keys.Enter Then
            loginBTN_Click_1(Nothing, Nothing)
        Else
            Exit Sub

        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub ADD_USBTN_Click(sender As Object, e As EventArgs) Handles ADD_USBTN.Click
        Form_ADD_USER_login.Show()
    End Sub


End Class