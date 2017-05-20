
Imports CrystalDecisions.CrystalReports.Engine
Public Class FrmBookRp
    Dim bookobj As New ReportDocument
    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        bookobj.Load("D:\DataSec\PrjDataSec\NewBooking.rpt")
        CrystalReportViewer1.ReportSource = bookobj
        CrystalReportViewer1.Refresh()
    End Sub

    Private Sub FrmBookRp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub
End Class