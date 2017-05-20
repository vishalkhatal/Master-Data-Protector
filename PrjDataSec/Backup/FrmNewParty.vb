Public Class FrmNewParty

    Private Sub PartyMastBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PartyMastBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PartyMastBindingSource.EndEdit()
        Me.PartyMastTableAdapter.Update(Me.StockDataSet.PartyMast)

    End Sub

    Private Sub FrmNewParty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StockDataSet.PartyMast' table. You can move, or remove it, as needed.
        Me.PartyMastTableAdapter.Fill(Me.StockDataSet.PartyMast)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FrmPartyRP.Show()
    End Sub
End Class