Imports System.IO
Public Class frmSaleBill
    Dim w As StreamWriter 'object
    Dim s As String

    Private Sub BillBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BillBindingSource.EndEdit()
        Me.BillTableAdapter.Update(Me.StockDataSet.Bill)


        w = File.AppendText("D:\DataSec\PrjDataSec\StockFile\BillUpdate.txt")
        w.WriteLine("Table Name :- Bill Invoice")
        w.WriteLine("After Update Records")
        w.WriteLine("Bill Number:")
        w.WriteLine(BillNoTextBox.Text)

        w.WriteLine("Bill Date:")
        w.WriteLine(BillDateDateTimePicker.Value)

        w.WriteLine("Supplier Name:")
        w.WriteLine(SubCompNameComboBox.Text)
        w.WriteLine("Part Name:")
        w.WriteLine(PartNameComboBox.Text)
        w.WriteLine("Mode Of Payments:")
        w.WriteLine(ModeofPaymentComboBox.Text)
        w.WriteLine("Quantity:")
        w.WriteLine(QtyTextBox.Text)

        w.WriteLine("Cost:")
        w.WriteLine(CostTextBox.Text)

        w.WriteLine("Net Amount:")
        w.WriteLine(NetAmtTextBox.Text)
        w.WriteLine("User Name")
        w.WriteLine(fLogIn.txtUserName.Text)
        w.WriteLine("Date ")
        w.WriteLine(Now)
        w.WriteLine("----------------------------------")
        w.Close()
    End Sub

    Private Sub frmSaleBill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StockDataSet.SubCompany' table. You can move, or remove it, as needed.
        Me.SubCompanyTableAdapter.Fill(Me.StockDataSet.SubCompany)
        'TODO: This line of code loads data into the 'StockDataSet.PartCode' table. You can move, or remove it, as needed.
        Me.PartCodeTableAdapter.Fill(Me.StockDataSet.PartCode)
        'TODO: This line of code loads data into the 'StockDataSet.Bill' table. You can move, or remove it, as needed.
        Me.BillTableAdapter.Fill(Me.StockDataSet.Bill)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub CostTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CostTextBox.LostFocus
        TotalAmtTextBox.Text = QtyTextBox.Text * CostTextBox.Text
        DisTextBox.Text = TotalAmtTextBox.Text * 10 / 100
        NetAmtTextBox.Text = Val(TotalAmtTextBox.Text) - Val(DisTextBox.Text)

    End Sub

    Private Sub CostTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CostTextBox.TextChanged

    End Sub

    Private Sub TotalAmtTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalAmtTextBox.TextChanged

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click


    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
      


        w = File.AppendText("D:\DataSec\PrjDataSec\StockFile\Sale Bill.txt")
        w.WriteLine("--------------------------")
        w.WriteLine("Before Update")

        w.WriteLine("Table Name :- Bill Invoice")
        w.WriteLine("Bill Number:")
        w.WriteLine(BillNoTextBox.Text)

        w.WriteLine("Bill Date:")
        w.WriteLine(BillDateDateTimePicker.Value)

        w.WriteLine("Supplier Name:")
        w.WriteLine(SubCompNameComboBox.Text)
        w.WriteLine("Part Name:")
        w.WriteLine(PartNameComboBox.Text)
        w.WriteLine("Mode Of Payments:")
        w.WriteLine(ModeofPaymentComboBox.Text)
        w.WriteLine("Quantity:")
        w.WriteLine(QtyTextBox.Text)

        w.WriteLine("Cost:")
        w.WriteLine(CostTextBox.Text)

        w.WriteLine("Net Amount:")
        w.WriteLine(NetAmtTextBox.Text)
        w.WriteLine("User Name")
        w.WriteLine(fLogIn.txtUserName.Text)
        w.WriteLine("Date ")
        w.WriteLine(Now)
        w.WriteLine("----------------------------------")
        w.Close()
       
    End Sub

    Private Sub BillBindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillBindingNavigator.RefreshItems

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FrmBillRP.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        s = MsgBox("Do You Want to Update Record", MsgBoxStyle.YesNo)
        If s = vbYes Then


            w = File.AppendText("D:\DataSec\PrjDataSec\StockFile\BillUpdate.txt")
            w.WriteLine("--------------------------")
            w.WriteLine("Before Update")

            w.WriteLine("Table Name :- Bill Invoice")
            w.WriteLine("Bill Number:")
            w.WriteLine(BillNoTextBox.Text)

            w.WriteLine("Bill Date:")
            w.WriteLine(BillDateDateTimePicker.Value)

            w.WriteLine("Supplier Name:")
            w.WriteLine(SubCompNameComboBox.Text)
            w.WriteLine("Part Name:")
            w.WriteLine(PartNameComboBox.Text)
            w.WriteLine("Mode Of Payments:")
            w.WriteLine(ModeofPaymentComboBox.Text)
            w.WriteLine("Quantity:")
            w.WriteLine(QtyTextBox.Text)

            w.WriteLine("Cost:")
            w.WriteLine(CostTextBox.Text)

            w.WriteLine("Net Amount:")
            w.WriteLine(NetAmtTextBox.Text)
            w.WriteLine("User Name")
            w.WriteLine(fLogIn.txtUserName.Text)
            w.WriteLine("Date ")
            w.WriteLine(Now)
            w.WriteLine("----------------------------------")
            w.Close()
        Else
            MsgBox("Record Not Updated!!!!")
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        s = MsgBox("Do You Want to Update Record", MsgBoxStyle.YesNo)
        If s = vbYes Then


            w = File.AppendText("D:\DataSec\PrjDataSec\StockFile\Sale Bill.txt")
            w.WriteLine("--------------------------")
            w.WriteLine("Before Deleted")

            w.WriteLine("Table Name :- Bill Invoice")
            w.WriteLine("Bill Number:")
            w.WriteLine(BillNoTextBox.Text)

            w.WriteLine("Bill Date:")
            w.WriteLine(BillDateDateTimePicker.Value)

            w.WriteLine("Supplier Name:")
            w.WriteLine(SubCompNameComboBox.Text)
            w.WriteLine("Part Name:")
            w.WriteLine(PartNameComboBox.Text)
            w.WriteLine("Mode Of Payments:")
            w.WriteLine(ModeofPaymentComboBox.Text)
            w.WriteLine("Quantity:")
            w.WriteLine(QtyTextBox.Text)

            w.WriteLine("Cost:")
            w.WriteLine(CostTextBox.Text)

            w.WriteLine("Net Amount:")
            w.WriteLine(NetAmtTextBox.Text)
            w.WriteLine("User Name")
            w.WriteLine(fLogIn.txtUserName.Text)
            w.WriteLine("Date ")
            w.WriteLine(Now)
            w.WriteLine("----------------------------------")
            w.Close()
        Else
            MsgBox("Record Not Updated!!!!")
        End If
    End Sub
End Class