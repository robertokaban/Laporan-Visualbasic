Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'db_akademikDataSet.tb_mahasiswa' table. You can move, or remove it, as needed.
        Me.tb_mahasiswaTableAdapter.Fill(Me.db_akademikDataSet.tb_mahasiswa)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
