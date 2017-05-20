Public Class FrmStartUpScreen

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FrmFrontScreen.Show()
        'Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FrmCode.Show()
        'Me.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        FrmFront.Show()
        Me.Close()
    End Sub

 

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        fUser.Show()
    End Sub

    Private Sub FrmStartUpScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        fUser.Show()
    End Sub
End Class