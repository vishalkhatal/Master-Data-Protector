Imports System.IO
Public Class frmBooking
    Dim w As StreamWriter
    Private Sub BookingBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookingBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BookingBindingSource.EndEdit()
        Me.BookingTableAdapter.Update(Me.StockDataSet.Booking)


        '----------------------------------------------------------------------------
        w = File.AppendText("D:\DataSec\PrjDataSec\StockFile\BookingUpdate.txt")
        w.WriteLine("Table Name :- Stock Booking")
        w.WriteLine("Supplier Name:")
        w.WriteLine(SubNameComboBox.Text)

        w.WriteLine("Part Booking Limits:")
        w.WriteLine(LimitTextBox.Text)

        w.WriteLine("Booking Quantity:")
        w.WriteLine(BQtyTextBox.Text)
        w.WriteLine("Cost:")
        w.WriteLine(PerQtyCostTextBox.Text)
        w.WriteLine("Booking Date:")
        w.WriteLine(BkdateDateTimePicker.Value)
        w.WriteLine("Part Delivery Date:")
        w.WriteLine(DelDateDateTimePicker.Value)
        w.WriteLine("Total Cost:")
        w.WriteLine(TotalCostTextBox.Text)

        w.WriteLine("Remark:")
        w.WriteLine(RemarkTextBox.Text)

        w.WriteLine("User Name")
        w.WriteLine(FrmLogin.TextBox1.Text)
        w.WriteLine("Date ")
        w.WriteLine(Now)
        w.WriteLine("--------------------------------")
        w.Close()

    End Sub

    Private Sub frmBooking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StockDataSet.PartCode' table. You can move, or remove it, as needed.
        Me.PartCodeTableAdapter.Fill(Me.StockDataSet.PartCode)
        'TODO: This line of code loads data into the 'StockDataSet.Booking' table. You can move, or remove it, as needed.
        Me.BookingTableAdapter.Fill(Me.StockDataSet.Booking)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub PerQtyCostTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles PerQtyCostTextBox.LostFocus
        TotalCostTextBox.Text = BQtyTextBox.Text * PerQtyCostTextBox.Text
    End Sub

    Private Sub PerQtyCostTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerQtyCostTextBox.TextChanged

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        w = File.AppendText("D:\DataSec\PrjDataSec\StockFile\Booking.txt")
        w.WriteLine("Table Name :- Stock Booking")
        w.WriteLine("Supplier Name:")
        w.WriteLine(SubNameComboBox.Text)

        w.WriteLine("Part Booking Limits:")
        w.WriteLine(LimitTextBox.Text)

        w.WriteLine("Booking Quantity:")
        w.WriteLine(BQtyTextBox.Text)
        w.WriteLine("Cost:")
        w.WriteLine(PerQtyCostTextBox.Text)
        w.WriteLine("Booking Date:")
        w.WriteLine(BkdateDateTimePicker.Value)
        w.WriteLine("Part Delivery Date:")
        w.WriteLine(DelDateDateTimePicker.Value)
        w.WriteLine("Total Cost:")
        w.WriteLine(TotalCostTextBox.Text)

        w.WriteLine("Remark:")
        w.WriteLine(RemarkTextBox.Text)

        w.WriteLine("User Name")
        w.WriteLine(FrmLogin.TextBox1.Text)
        w.WriteLine("Date ")
        w.WriteLine(Now)
        w.WriteLine("--------------------------------")

        
        w.Close()

    End Sub

    Private Sub BookingBindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookingBindingNavigator.RefreshItems

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FrmBookRp.Show()
    End Sub
End Class