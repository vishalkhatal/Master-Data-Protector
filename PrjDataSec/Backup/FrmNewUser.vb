Public Class FrmNewUser

    Private Sub UserMasterBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserMasterBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UserMasterBindingSource.EndEdit()
        Me.UserMasterTableAdapter.Update(Me.StockDataSet.UserMaster)

    End Sub

    Private Sub FrmNewUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StockDataSet.UserMaster' table. You can move, or remove it, as needed.
        Me.UserMasterTableAdapter.Fill(Me.StockDataSet.UserMaster)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class