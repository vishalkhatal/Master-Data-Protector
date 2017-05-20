Public Class fLogIn

    Private Sub btnLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogIn.Click
        If txtUserName.Text = "" Then
            Message("Enter User Name.")
            txtUserName.Focus()
        ElseIf txtPassword.Text = "" Then
            Message("Enter Password.")
            txtPassword.Focus()
        Else
            Com.Connection = Module1.Cnn
            Com.CommandText = "Select Permission,UserName,Pass from tblUser where UserName='" & Encrypt(txtUserName.Text) & "' And Pass='" & Encrypt(txtPassword.Text) & "'"
            Dim str As String = Com.ExecuteScalar
            txtUserName.Text = ""
            txtPassword.Text = ""


            If str = "Admin" Then
              
                FrmStartUpScreen.Button5.Visible = True
                FrmStartUpScreen.Button2.Visible = True
                
                FrmStartUpScreen.Show()
                
                FrmFront.Hide()
                Me.Hide()

            ElseIf str = "User" Then
               
                FrmStartUpScreen.Button5.Visible = False
                FrmStartUpScreen.Button2.Visible = False
                
                FrmStartUpScreen.Show()
                
                FrmFront.Hide()
                Me.Hide()


            Else
                MessageBox.Show("Please Enter Valid User Id and Password.")
            End If
        End If


            
    End Sub

 

    Private Sub txtPassword_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnLogIn_Click(sender, e)
        End If
    End Sub

    Private Sub txtUserName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserName.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnLogIn_Click(sender, e)
        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

   
End Class