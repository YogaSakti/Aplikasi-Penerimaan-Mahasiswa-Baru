<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        Me.pmbDataSet = New PBO_Baru.pmbDataSet()
        Me.data_pmbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.data_pmbTableAdapter = New PBO_Baru.pmbDataSetTableAdapters.data_pmbTableAdapter()
        CType(Me.pmbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.data_pmbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetPMB"
        ReportDataSource1.Value = Me.data_pmbBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PBO_Baru.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1304, 436)
        Me.ReportViewer1.TabIndex = 0
        '
        'pmbDataSet
        '
        Me.pmbDataSet.DataSetName = "pmbDataSet"
        Me.pmbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'data_pmbBindingSource
        '
        Me.data_pmbBindingSource.DataMember = "data_pmb"
        Me.data_pmbBindingSource.DataSource = Me.pmbDataSet
        '
        'data_pmbTableAdapter
        '
        Me.data_pmbTableAdapter.ClearBeforeFill = True
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(1304, 436)
        Me.Controls.Add(Me.ReportViewer1)
        Me.MinimizeBox = False
        Me.Name = "Report"
        Me.ShowInTaskbar = False
        Me.Text = "Report"
        CType(Me.pmbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.data_pmbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents data_pmbBindingSource As BindingSource
    Friend WithEvents pmbDataSet As pmbDataSet
    Friend WithEvents data_pmbTableAdapter As pmbDataSetTableAdapters.data_pmbTableAdapter
End Class
