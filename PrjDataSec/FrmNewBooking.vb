Imports System.IO
Public Class FrmNewBooking
    Dim w As StreamWriter
    Dim s As String

    Private Sub BookingBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookingBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BookingBindingSource.EndEdit()
        Me.BookingTableAdapter.Update(Me.New_StockDataSet.Booking)

        w = File.AppendText("D:\DataSec\PrjDataSec\StockFile\BookingUpdate.txt")
        w.WriteLine("After Update Records")

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
        w.WriteLine(fLogIn.txtUserName.Text)
        w.WriteLine("Date ")
        w.WriteLine(Now)
        w.WriteLine("--------------------------------")
        w.Close()
    End Sub

    Private Sub FrmNewBooking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'New_StockDataSet.PartCode' table. You can move, or remove it, as needed.
        Me.PartCodeTableAdapter.Fill(Me.New_StockDataSet.PartCode)
        'TODO: This line of code loads data into the 'StockDataSet.SubCompany' table. You can move, or remove it, as needed.
        Me.SubCompanyTableAdapter.Fill(Me.StockDataSet.SubCompany)
        'TODO: This line of code loads data into the 'New_StockDataSet.Booking' table. You can move, or remove it, as needed.
        Me.BookingTableAdapter.Fill(Me.New_StockDataSet.Booking)

    End Sub

    Private Sub PerQtyCostTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles PerQtyCostTextBox.LostFocus
        TotalCostTextBox.Text = BQtyTextBox.Text * PerQtyCostTextBox.Text
    End Sub

    Private Sub PerQtyCostTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerQtyCostTextBox.TextChanged

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        w = File.AppendText("D:\DataSec\PrjDataSec\StockFile\Booking.txt")
        w.WriteLine("After Delete Record?")
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
        w.WriteLine(fLogIn.txtUserName.Text)
        w.WriteLine("Date ")
        w.WriteLine(Now)
        w.WriteLine("--------------------------------")


        w.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FrmBookRp.Show()
    End Sub

    Private Sub BQtyTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BQtyTextBox.TextChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        s = MsgBox("Do you want to deleted Record?", MsgBoxStyle.YesNo)
        If s = vbYes Then
            w = File.AppendText("D:\DataSec\PrjDataSec\StockFile\Booking.txt")
            w.WriteLine("Before Delete Record?")

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
            w.WriteLine(fLogIn.txtUserName.Text)
            w.WriteLine("Date ")
            w.WriteLine(Now)
            w.WriteLine("--------------------------------")


            w.Close()
        Else
            MsgBox("Record Not Deleted")

        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        w = File.AppendText("D:\DataSec\PrjDataSec\StockFile\BookingUpdate.txt")
        w.WriteLine("Before Update Records")

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
        w.WriteLine(fLogIn.txtUserName.Text)
        w.WriteLine("Date ")
        w.WriteLine(Now)
        w.WriteLine("--------------------------------")
        w.Close()
    End Sub
End Class