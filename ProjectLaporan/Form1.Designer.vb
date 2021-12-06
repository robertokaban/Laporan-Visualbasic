<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.db_akademikDataSet = New ProjectLaporan.db_akademikDataSet()
        Me.tb_mahasiswaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tb_mahasiswaTableAdapter = New ProjectLaporan.db_akademikDataSetTableAdapters.tb_mahasiswaTableAdapter()
        CType(Me.db_akademikDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_mahasiswaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSetMahasiswa"
        ReportDataSource1.Value = Me.tb_mahasiswaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ProjectLaporan.LaporanMahasiswa.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(929, 427)
        Me.ReportViewer1.TabIndex = 0
        '
        'db_akademikDataSet
        '
        Me.db_akademikDataSet.DataSetName = "db_akademikDataSet"
        Me.db_akademikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tb_mahasiswaBindingSource
        '
        Me.tb_mahasiswaBindingSource.DataMember = "tb_mahasiswa"
        Me.tb_mahasiswaBindingSource.DataSource = Me.db_akademikDataSet
        '
        'tb_mahasiswaTableAdapter
        '
        Me.tb_mahasiswaTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 439)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.db_akademikDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_mahasiswaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tb_mahasiswaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents db_akademikDataSet As ProjectLaporan.db_akademikDataSet
    Friend WithEvents tb_mahasiswaTableAdapter As ProjectLaporan.db_akademikDataSetTableAdapters.tb_mahasiswaTableAdapter

End Class
