Imports System.Data
Imports System.Data.SqlClient



Public Class Form_SING_UP
    Private Sub singBTN_Click(sender As Object, e As EventArgs) Handles singBTN.Click
        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Or Full_nameTextBox.Text = "" Or TypeComboBox.SelectedItem = "" Then
            MsgBox("Missing Information!")
        Else

            Try
                conn = getconnect()
                conn.Open()
                Dim query = "insert into users (username,  password,  full_name,  type,  phone,  address) values ('" & UsernameTextBox.Text & "'   , '" + MD5(PasswordTextBox.Text) + "'   ,'" & Full_nameTextBox.Text & "'  ,  '" & TypeComboBox.SelectedItem.ToString & "' ,'" & PhoneTextBox.Text & "' ,'" & AddressTextBox.Text & "' )"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, conn)
                cmd.ExecuteNonQuery()
                MsgBox("SING UP SUCCESS!")
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End If
    End Sub

    Private Sub Show_userBTN_Click(sender As Object, e As EventArgs) Handles Show_userBTN.Click
        Form_display_login.Show()
    End Sub

    Private Sub cancelBTN_Click(sender As Object, e As EventArgs) Handles cancelBTN.Click
        Me.Close()
    End Sub
End Class