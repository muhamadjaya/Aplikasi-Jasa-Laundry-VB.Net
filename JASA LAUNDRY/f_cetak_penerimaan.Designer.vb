<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_cetak_penerimaan
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
        Me.db_laundryDataSet = New JASA_LAUNDRY.db_laundryDataSet()
        Me.bs_cetak_penerimaan = New System.Windows.Forms.BindingSource(Me.components)
        Me.ta_cetak_penerimaan = New JASA_LAUNDRY.db_laundryDataSetTableAdapters.query_cetak_penerimaanTableAdapter()
        CType(Me.db_laundryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_cetak_penerimaan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "ds_cetak_penerimaan"
        ReportDataSource1.Value = Me.bs_cetak_penerimaan
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "JASA_LAUNDRY.report_struk_penerimaan.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(442, 340)
        Me.ReportViewer1.TabIndex = 0
        '
        'db_laundryDataSet
        '
        Me.db_laundryDataSet.DataSetName = "db_laundryDataSet"
        Me.db_laundryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bs_cetak_penerimaan
        '
        Me.bs_cetak_penerimaan.DataMember = "query_cetak_penerimaan"
        Me.bs_cetak_penerimaan.DataSource = Me.db_laundryDataSet
        '
        'ta_cetak_penerimaan
        '
        Me.ta_cetak_penerimaan.ClearBeforeFill = True
        '
        'f_cetak_penerimaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 340)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "f_cetak_penerimaan"
        Me.Text = "f_cetak_penerimaan"
        CType(Me.db_laundryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_cetak_penerimaan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents bs_cetak_penerimaan As System.Windows.Forms.BindingSource
    Friend WithEvents db_laundryDataSet As JASA_LAUNDRY.db_laundryDataSet
    Friend WithEvents ta_cetak_penerimaan As JASA_LAUNDRY.db_laundryDataSetTableAdapters.query_cetak_penerimaanTableAdapter
End Class
