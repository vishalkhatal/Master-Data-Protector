Imports CrystalDecisions.CrystalReports.Engine

Public Class FrmReplaceRP
    Dim obj As New ReportDocument
    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        obj.Load("D:\DataSec\PrjDataSec\RptReplace.rpt")
        CrystalReportViewer1.ReportSource = obj
        CrystalReportViewer1.Refresh()

    End Sub
End Class