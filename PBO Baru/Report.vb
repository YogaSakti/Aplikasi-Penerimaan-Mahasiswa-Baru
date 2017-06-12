Public Class Report
    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'pmbDataSet.data_pmb' table. You can move, or remove it, as needed.
        Me.data_pmbTableAdapter.Fill(Me.pmbDataSet.data_pmb)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class