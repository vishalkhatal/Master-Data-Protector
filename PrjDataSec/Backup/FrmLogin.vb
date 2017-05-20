Public Class FrmLogin

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = "Admin" And TextBox2.Text = "admin" Then
            FrmStartUpScreen.Show()
            FrmStartUpScreen.Button2.Visible = True
            FrmStartUpScreen.Button5.Visible = True
            Me.Close()
        ElseIf TextBox1.Text = "Student" And TextBox2.Text = "Stud" Then
            FrmStartUpScreen.Show()
            FrmStartUpScreen.Button2.Visible = False
            FrmStartUpScreen.Button5.Visible = False
            Me.Close()
        Else
            MsgBox("Invalid User Try Again!!!")
            TextBox1.Text = ""
            TextBox2.Text = ""

        End If

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class