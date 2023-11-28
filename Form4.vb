Imports System.Web

Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String
        Dim password As String
        username = txtUserName.Text
        password = txtPassWord.Text

        If username.Equals("Emmanuel") And password.Equals("Boateng") Then
            Form5.Show()
            Me.Hide()
            txtPassWord.Text = String.Empty
            txtUserName.Text = String.Empty
        Else
            MessageBox.Show("Invalid details", "Information")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkPass.CheckedChanged
        If chkPass.Checked Then
            txtPassWord.PasswordChar = ""
        Else
            txtPassWord.PasswordChar = "*"
        End If
    End Sub

    Private Sub txtPassWord_TextChanged(sender As Object, e As EventArgs) Handles txtPassWord.TextChanged

    End Sub
End Class