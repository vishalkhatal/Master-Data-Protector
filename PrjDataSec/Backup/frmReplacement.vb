Imports System.IO
Public Class frmReplacement
    Dim w As StreamWriter
    Dim s As String
    Private Sub ReplecementBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReplecementBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ReplecementBindingSource.EndEdit()
        Me.ReplecementTableAdapter.Update(Me.StockDataSet.Replecement)
        w = File.AppendText("D:\DataSec\PrjDataSec\StockFile\ReplaceUpdate.txt")
        w.WriteLine("After Update")

        w.WriteLine("Table Name :- Replacement ")
        w.WriteLine("Replacement Note Number:")
        w.WriteLine(RepNoteNoTextBox.Text)

        w.WriteLine("Bill Number:")
        w.WriteLine(BillNoComboBox.Text)

        w.WriteLine("Part Name:")
        w.WriteLine(PNameComboBox.Text)
        w.WriteLine("Bill Date:")
        w.WriteLine(DateDateTimePicker.Value)
        w.WriteLine("Damage Percentage:")
        w.WriteLine(DperTextBox.Text)
        w.WriteLine("Sale Cost:")
        w.WriteLine(SaleCostTextBox.Text)
        w.WriteLine("Quantity:")
        w.WriteLine(QtyTextBox.Text)
        w.WriteLine("Total Amount:")
        w.WriteLine(TotalAmtTextBox.Text)

        w.WriteLine("Replacement Status:")
        w.WriteLine(ReplStatusTextBox.Text)
        w.WriteLine("User Name")
        w.WriteLine(fLogIn.txtUserName.Text)
        w.WriteLine("Date ")
        w.WriteLine(Now)
        w.WriteLine("----------------------------------")
        w.Close()

    End Sub

    Private Sub frmReplacement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StockDataSet.PartCode' table. You can move, or remove it, as needed.
        Me.PartCodeTableAdapter.Fill(Me.StockDataSet.PartCode)
        'TODO: This line of code loads data into the 'StockDataSet.Replecement' table. You can move, or remove it, as needed.
        Me.ReplecementTableAdapter.Fill(Me.StockDataSet.Replecement)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub DperTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DperTextBox.LostFocus
        If DperTextBox.Text >= 85 Then
            ReplStatusTextBox.Text = "Material Accepted"
        Else
            ReplStatusTextBox.Text = "Material Not Accepted"
        End If
    End Sub

    Private Sub DperTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DperTextBox.TextChanged

    End Sub

    Private Sub ReplecementBindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReplecementBindingNavigator.RefreshItems

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        w = File.AppendText("D:\DataSec\PrjDataSec\StockFile\Replacement.txt")
        w.WriteLine("After Deleted")

        w.WriteLine("Table Name :- Replacement ")
        w.WriteLine("Replacement Note Number:")
        w.WriteLine(RepNoteNoTextBox.Text)

        w.WriteLine("Bill Number:")
        w.WriteLine(BillNoComboBox.Text)

        w.WriteLine("Part Name:")
        w.WriteLine(PNameComboBox.Text)
        w.WriteLine("Bill Date:")
        w.WriteLine(DateDateTimePicker.Value)
        w.WriteLine("Damage Percentage:")
        w.WriteLine(DperTextBox.Text)
        w.WriteLine("Sale Cost:")
        w.WriteLine(SaleCostTextBox.Text)
        w.WriteLine("Quantity:")
        w.WriteLine(QtyTextBox.Text)
        w.WriteLine("Total Amount:")
        w.WriteLine(TotalAmtTextBox.Text)

        w.WriteLine("Replacement Status:")
        w.WriteLine(ReplStatusTextBox.Text)
        w.WriteLine("User Name")
        w.WriteLine(fLogIn.txtUserName.Text)
        w.WriteLine("Date ")
        w.WriteLine(Now)
        w.WriteLine("----------------------------------")
        w.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FrmReplaceRP.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        s = MsgBox("Do You Want to Update Record", MsgBoxStyle.YesNo)
        If s = vbYes Then
            w = File.AppendText("D:\DataSec\PrjDataSec\StockFile\Replacement.txt")
            w.WriteLine("Before Deleted ")
            w.WriteLine("Table Name :- Replacement ")
            w.WriteLine("Replacement Note Number:")
            w.WriteLine(RepNoteNoTextBox.Text)

            w.WriteLine("Bill Number:")
            w.WriteLine(BillNoComboBox.Text)

            w.WriteLine("Part Name:")
            w.WriteLine(PNameComboBox.Text)
            w.WriteLine("Bill Date:")
            w.WriteLine(DateDateTimePicker.Value)
            w.WriteLine("Damage Percentage:")
            w.WriteLine(DperTextBox.Text)
            w.WriteLine("Sale Cost:")
            w.WriteLine(SaleCostTextBox.Text)
            w.WriteLine("Quantity:")
            w.WriteLine(QtyTextBox.Text)
            w.WriteLine("Total Amount:")
            w.WriteLine(TotalAmtTextBox.Text)

            w.WriteLine("Replacement Status:")
            w.WriteLine(ReplStatusTextBox.Text)
            w.WriteLine("User Name")
            w.WriteLine(fLogIn.txtUserName.Text)
            w.WriteLine("Date ")
            w.WriteLine(Now)
            w.WriteLine("----------------------------------")
            w.Close()
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        s = MsgBox("Do You Want to Update Record", MsgBoxStyle.YesNo)
        If s = vbYes Then
            w = File.AppendText("D:\DataSec\PrjDataSec\StockFile\ReplaceUpdate.txt")
            w.WriteLine("Before Update")

            w.WriteLine("Table Name :- Replacement ")
            w.WriteLine("Replacement Note Number:")
            w.WriteLine(RepNoteNoTextBox.Text)

            w.WriteLine("Bill Number:")
            w.WriteLine(BillNoComboBox.Text)

            w.WriteLine("Part Name:")
            w.WriteLine(PNameComboBox.Text)
            w.WriteLine("Bill Date:")
            w.WriteLine(DateDateTimePicker.Value)
            w.WriteLine("Damage Percentage:")
            w.WriteLine(DperTextBox.Text)
            w.WriteLine("Sale Cost:")
            w.WriteLine(SaleCostTextBox.Text)
            w.WriteLine("Quantity:")
            w.WriteLine(QtyTextBox.Text)
            w.WriteLine("Total Amount:")
            w.WriteLine(TotalAmtTextBox.Text)

            w.WriteLine("Replacement Status:")
            w.WriteLine(ReplStatusTextBox.Text)
            w.WriteLine("User Name")
            w.WriteLine(fLogIn.txtUserName.Text)
            w.WriteLine("Date ")
            w.WriteLine(Now)
            w.WriteLine("----------------------------------")
            w.Close()
        Else
            MsgBox("Record Not Updated!!!!!!!!!!")

        End If

    End Sub
End Class