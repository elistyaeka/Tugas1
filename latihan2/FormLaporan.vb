Public Class FormLaporan

    Private Sub FormLaporan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rep As New CRStudents
        Dim dt As DataTable
        Dim dtstudents As DTStudentsTableAdapters.TableStudentsTableAdapter
        dtstudents = New DTStudentsTableAdapters.TableStudentsTableAdapter
        dt = dtstudents.GetData()
        rep.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = rep
    End Sub
End Class