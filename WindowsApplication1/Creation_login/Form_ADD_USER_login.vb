Imports System.Data
Imports System.Data.SqlClient


Public Class Form_ADD_USER_login
    Private Sub loginBTN_Click(sender As Object, e As EventArgs) Handles loginBTN.Click

        If UsernameTXT.Text = "" Or Passwordtxt.Text = "" Then
            MsgBox("Missing Information!")
        Else

            Try
                conn = getconnect()
                conn.Open()
                Dim query = "select * from Admin where username= '" & UsernameTXT.Text & "' and password ='" + Passwordtxt.Text + "'  "
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Welcome Admin!")
                Form_SING_UP.Show()
                Me.Hide()
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End If

    End Sub

    Private Sub cancelBTN_Click(sender As Object, e As EventArgs) Handles cancelBTN.Click
        Application.Exit()
    End Sub
End Class