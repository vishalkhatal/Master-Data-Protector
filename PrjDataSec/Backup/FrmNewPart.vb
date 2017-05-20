Public Class FrmNewPart

    Private Sub PartCodeBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PartCodeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PartCodeBindingSource.EndEdit()
        Me.PartCodeTableAdapter.Update(Me.New_StockDataSet.PartCode)

    End Sub

    Private Sub FrmNewPart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'New_StockDataSet.PartCode' table. You can move, or remove it, as needed.
        Me.PartCodeTableAdapter.Fill(Me.New_StockDataSet.PartCode)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FrmPartRP.Show()
    End Sub

    Private Sub ScostTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ScostTextBox.LostFocus
        If ScostTextBox.Text < MCostTextBox.Text Then
            MsgBox("Sale Cost greater than Manufacturing Cost")
            MCostTextBox.Text = 0
            ScostTextBox.Text = 0
        End If
    End Sub

    Private Sub ScostTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScostTextBox.TextChanged

    End Sub
End Class