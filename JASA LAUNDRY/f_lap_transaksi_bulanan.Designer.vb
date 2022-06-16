<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_lap_transaksi_bulanan
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
        Dim Label5 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Kd_karyawanLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv_trx = New System.Windows.Forms.DataGridView()
        Me.KdtransaksiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KdkonsumenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KdkaryawanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TgltransaksiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglselesaiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglambilDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiskonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotbayarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bs_transaksi = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_laundryDataSet = New JASA_LAUNDRY.db_laundryDataSet()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmd_reset = New System.Windows.Forms.Button()
        Me.dtp_akhir = New System.Windows.Forms.DateTimePicker()
        Me.dtp_awal = New System.Windows.Forms.DateTimePicker()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmd_keluar = New System.Windows.Forms.Button()
        Me.cmd_cetak = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ta_transaksi = New JASA_LAUNDRY.db_laundryDataSetTableAdapters.tb_transaksiTableAdapter()
        Label5 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Kd_karyawanLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.dgv_trx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_transaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_laundryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.ForeColor = System.Drawing.Color.White
        Label5.Location = New System.Drawing.Point(367, 35)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(287, 24)
        Label5.TabIndex = 27
        Label5.Text = "Laporan Transaksi Bulanan"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.ForeColor = System.Drawing.Color.White
        Label4.Location = New System.Drawing.Point(9, 58)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(147, 24)
        Label4.TabIndex = 26
        Label4.Text = "Jasa Laundry"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.Color.White
        Label3.Location = New System.Drawing.Point(8, 8)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(209, 29)
        Label3.TabIndex = 25
        Label3.Text = "MAMA LAUNDRY"
        '
        'Kd_karyawanLabel
        '
        Kd_karyawanLabel.AutoSize = True
        Kd_karyawanLabel.Location = New System.Drawing.Point(22, 26)
        Kd_karyawanLabel.Name = "Kd_karyawanLabel"
        Kd_karyawanLabel.Size = New System.Drawing.Size(78, 13)
        Kd_karyawanLabel.TabIndex = 28
        Kd_karyawanLabel.Text = "Tanggal Awal :"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(263, 26)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(79, 13)
        Label1.TabIndex = 30
        Label1.Text = "Tanggal Akhir :"
        '
        'dgv_trx
        '
        Me.dgv_trx.AllowUserToAddRows = False
        Me.dgv_trx.AllowUserToDeleteRows = False
        Me.dgv_trx.AllowUserToOrderColumns = True
        Me.dgv_trx.AutoGenerateColumns = False
        Me.dgv_trx.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_trx.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_trx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_trx.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KdtransaksiDataGridViewTextBoxColumn, Me.KdkonsumenDataGridViewTextBoxColumn, Me.KdkaryawanDataGridViewTextBoxColumn, Me.TgltransaksiDataGridViewTextBoxColumn, Me.TglselesaiDataGridViewTextBoxColumn, Me.TglambilDataGridViewTextBoxColumn, Me.DiskonDataGridViewTextBoxColumn, Me.TotbayarDataGridViewTextBoxColumn})
        Me.dgv_trx.DataSource = Me.bs_transaksi
        Me.dgv_trx.EnableHeadersVisualStyles = False
        Me.dgv_trx.GridColor = System.Drawing.Color.Gold
        Me.dgv_trx.Location = New System.Drawing.Point(14, 76)
        Me.dgv_trx.Name = "dgv_trx"
        Me.dgv_trx.ReadOnly = True
        Me.dgv_trx.Size = New System.Drawing.Size(622, 227)
        Me.dgv_trx.TabIndex = 0
        '
        'KdtransaksiDataGridViewTextBoxColumn
        '
        Me.KdtransaksiDataGridViewTextBoxColumn.DataPropertyName = "kd_transaksi"
        Me.KdtransaksiDataGridViewTextBoxColumn.HeaderText = "kd_transaksi"
        Me.KdtransaksiDataGridViewTextBoxColumn.Name = "KdtransaksiDataGridViewTextBoxColumn"
        Me.KdtransaksiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KdkonsumenDataGridViewTextBoxColumn
        '
        Me.KdkonsumenDataGridViewTextBoxColumn.DataPropertyName = "kd_konsumen"
        Me.KdkonsumenDataGridViewTextBoxColumn.HeaderText = "kd_konsumen"
        Me.KdkonsumenDataGridViewTextBoxColumn.Name = "KdkonsumenDataGridViewTextBoxColumn"
        Me.KdkonsumenDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KdkaryawanDataGridViewTextBoxColumn
        '
        Me.KdkaryawanDataGridViewTextBoxColumn.DataPropertyName = "kd_karyawan"
        Me.KdkaryawanDataGridViewTextBoxColumn.HeaderText = "kd_karyawan"
        Me.KdkaryawanDataGridViewTextBoxColumn.Name = "KdkaryawanDataGridViewTextBoxColumn"
        Me.KdkaryawanDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TgltransaksiDataGridViewTextBoxColumn
        '
        Me.TgltransaksiDataGridViewTextBoxColumn.DataPropertyName = "tgl_transaksi"
        Me.TgltransaksiDataGridViewTextBoxColumn.HeaderText = "tgl_transaksi"
        Me.TgltransaksiDataGridViewTextBoxColumn.Name = "TgltransaksiDataGridViewTextBoxColumn"
        Me.TgltransaksiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TglselesaiDataGridViewTextBoxColumn
        '
        Me.TglselesaiDataGridViewTextBoxColumn.DataPropertyName = "tgl_selesai"
        Me.TglselesaiDataGridViewTextBoxColumn.HeaderText = "tgl_selesai"
        Me.TglselesaiDataGridViewTextBoxColumn.Name = "TglselesaiDataGridViewTextBoxColumn"
        Me.TglselesaiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TglambilDataGridViewTextBoxColumn
        '
        Me.TglambilDataGridViewTextBoxColumn.DataPropertyName = "tgl_ambil"
        Me.TglambilDataGridViewTextBoxColumn.HeaderText = "tgl_ambil"
        Me.TglambilDataGridViewTextBoxColumn.Name = "TglambilDataGridViewTextBoxColumn"
        Me.TglambilDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DiskonDataGridViewTextBoxColumn
        '
        Me.DiskonDataGridViewTextBoxColumn.DataPropertyName = "diskon"
        Me.DiskonDataGridViewTextBoxColumn.HeaderText = "diskon"
        Me.DiskonDataGridViewTextBoxColumn.Name = "DiskonDataGridViewTextBoxColumn"
        Me.DiskonDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotbayarDataGridViewTextBoxColumn
        '
        Me.TotbayarDataGridViewTextBoxColumn.DataPropertyName = "tot_bayar"
        Me.TotbayarDataGridViewTextBoxColumn.HeaderText = "tot_bayar"
        Me.TotbayarDataGridViewTextBoxColumn.Name = "TotbayarDataGridViewTextBoxColumn"
        Me.TotbayarDataGridViewTextBoxColumn.ReadOnly = True
        '
        'bs_transaksi
        '
        Me.bs_transaksi.DataMember = "tb_transaksi"
        Me.bs_transaksi.DataSource = Me.Db_laundryDataSet
        '
        'Db_laundryDataSet
        '
        Me.Db_laundryDataSet.DataSetName = "db_laundryDataSet"
        Me.Db_laundryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmd_reset)
        Me.GroupBox3.Controls.Add(Me.dtp_akhir)
        Me.GroupBox3.Controls.Add(Label1)
        Me.GroupBox3.Controls.Add(Me.dtp_awal)
        Me.GroupBox3.Controls.Add(Kd_karyawanLabel)
        Me.GroupBox3.Controls.Add(Me.dgv_trx)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 106)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(651, 325)
        Me.GroupBox3.TabIndex = 54
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Data Transaksi"
        '
        'cmd_reset
        '
        Me.cmd_reset.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_reset.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_reset.ForeColor = System.Drawing.Color.White
        Me.cmd_reset.Location = New System.Drawing.Point(484, 37)
        Me.cmd_reset.Name = "cmd_reset"
        Me.cmd_reset.Size = New System.Drawing.Size(72, 25)
        Me.cmd_reset.TabIndex = 28
        Me.cmd_reset.Text = "&Reset"
        Me.cmd_reset.UseVisualStyleBackColor = False
        '
        'dtp_akhir
        '
        Me.dtp_akhir.Location = New System.Drawing.Point(266, 42)
        Me.dtp_akhir.Name = "dtp_akhir"
        Me.dtp_akhir.Size = New System.Drawing.Size(200, 20)
        Me.dtp_akhir.TabIndex = 31
        '
        'dtp_awal
        '
        Me.dtp_awal.Location = New System.Drawing.Point(25, 42)
        Me.dtp_awal.Name = "dtp_awal"
        Me.dtp_awal.Size = New System.Drawing.Size(200, 20)
        Me.dtp_awal.TabIndex = 29
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Gold
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 87)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(670, 13)
        Me.Panel4.TabIndex = 24
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 507)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(670, 22)
        Me.StatusStrip1.TabIndex = 56
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.cmd_keluar)
        Me.Panel1.Controls.Add(Me.cmd_cetak)
        Me.Panel1.Location = New System.Drawing.Point(9, 437)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(651, 55)
        Me.Panel1.TabIndex = 55
        '
        'cmd_keluar
        '
        Me.cmd_keluar.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_keluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_keluar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_keluar.ForeColor = System.Drawing.Color.White
        Me.cmd_keluar.Location = New System.Drawing.Point(567, 11)
        Me.cmd_keluar.Name = "cmd_keluar"
        Me.cmd_keluar.Size = New System.Drawing.Size(72, 36)
        Me.cmd_keluar.TabIndex = 27
        Me.cmd_keluar.Text = "&Keluar"
        Me.cmd_keluar.UseVisualStyleBackColor = False
        '
        'cmd_cetak
        '
        Me.cmd_cetak.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_cetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_cetak.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_cetak.ForeColor = System.Drawing.Color.White
        Me.cmd_cetak.Location = New System.Drawing.Point(489, 11)
        Me.cmd_cetak.Name = "cmd_cetak"
        Me.cmd_cetak.Size = New System.Drawing.Size(72, 36)
        Me.cmd_cetak.TabIndex = 26
        Me.cmd_cetak.Text = "&Cetak"
        Me.cmd_cetak.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel3.Controls.Add(Label5)
        Me.Panel3.Controls.Add(Label4)
        Me.Panel3.Controls.Add(Label3)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(670, 100)
        Me.Panel3.TabIndex = 53
        '
        'ta_transaksi
        '
        Me.ta_transaksi.ClearBeforeFill = True
        '
        'f_lap_transaksi_bulanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(670, 529)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "f_lap_transaksi_bulanan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laporan Transaksi Bulanan"
        CType(Me.dgv_trx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_transaksi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_laundryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_trx As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmd_cetak As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dtp_akhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_awal As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmd_reset As System.Windows.Forms.Button
    Friend WithEvents cmd_keluar As System.Windows.Forms.Button
    Friend WithEvents Db_laundryDataSet As JASA_LAUNDRY.db_laundryDataSet
    Friend WithEvents bs_transaksi As System.Windows.Forms.BindingSource
    Friend WithEvents ta_transaksi As JASA_LAUNDRY.db_laundryDataSetTableAdapters.tb_transaksiTableAdapter
    Friend WithEvents KdtransaksiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KdkonsumenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KdkaryawanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TgltransaksiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TglselesaiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TglambilDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiskonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotbayarDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
