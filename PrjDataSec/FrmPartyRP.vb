Imports CrystalDecisions.CrystalReports.Engine
Public Class FrmPartyRP
    Dim robj As New ReportDocument
    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        robj.Load("D:\DataSec\PrjDataSec\PartyInfoReport.rpt")
        CrystalReportViewer1.ReportSource = robj
        CrystalReportViewer1.Refresh()
    End Sub
End Class