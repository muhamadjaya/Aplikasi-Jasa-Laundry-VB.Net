<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_transaksi_pengambilan
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
        Dim Kd_transaksiLabel As System.Windows.Forms.Label
        Dim Tgl_ambilLabel As System.Windows.Forms.Label
        Dim DiskonLabel As System.Windows.Forms.Label
        Dim Kd_konsumenLabel As System.Windows.Forms.Label
        Dim KonsumenLabel As System.Windows.Forms.Label
        Dim AlamatLabel As System.Windows.Forms.Label
        Dim CpLabel As System.Windows.Forms.Label
        Dim Kd_jenis_laundryLabel As System.Windows.Forms.Label
        Dim Jenis_laundryLabel As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgv_pengambilan = New System.Windows.Forms.DataGridView()
        Me.KdjenislaundryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JenislaundryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TarifDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BeratDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bs_cari_pengambilan = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_laundryDataSet = New JASA_LAUNDRY.db_laundryDataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cmd_keluar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cmd_resett = New System.Windows.Forms.Button()
        Me.cmd_simpan = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txt_kd_transaksi = New System.Windows.Forms.TextBox()
        Me.DiskonTextBox = New System.Windows.Forms.TextBox()
        Me.Kd_konsumenTextBox = New System.Windows.Forms.TextBox()
        Me.KonsumenTextBox = New System.Windows.Forms.TextBox()
        Me.txt_diskon = New System.Windows.Forms.TextBox()
        Me.txt_tot_bayar = New System.Windows.Forms.TextBox()
        Me.txt_jml_uang = New System.Windows.Forms.TextBox()
        Me.txt_kembalian = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bs_transaksi = New System.Windows.Forms.BindingSource(Me.components)
        Me.ta_transaksi = New JASA_LAUNDRY.db_laundryDataSetTableAdapters.tb_transaksiTableAdapter()
        Me.ta_cari_pengambilan = New JASA_LAUNDRY.db_laundryDataSetTableAdapters.query_cari_pengambilanTableAdapter()
        Kd_transaksiLabel = New System.Windows.Forms.Label()
        Tgl_ambilLabel = New System.Windows.Forms.Label()
        DiskonLabel = New System.Windows.Forms.Label()
        Kd_konsumenLabel = New System.Windows.Forms.Label()
        KonsumenLabel = New System.Windows.Forms.Label()
        AlamatLabel = New System.Windows.Forms.Label()
        CpLabel = New System.Windows.Forms.Label()
        Kd_jenis_laundryLabel = New System.Windows.Forms.Label()
        Jenis_laundryLabel = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_pengambilan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_cari_pengambilan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_laundryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.bs_transaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Kd_transaksiLabel
        '
        Kd_transaksiLabel.AutoSize = True
        Kd_transaksiLabel.Location = New System.Drawing.Point(38, 43)
        Kd_transaksiLabel.Name = "Kd_transaksiLabel"
        Kd_transaksiLabel.Size = New System.Drawing.Size(87, 13)
        Kd_transaksiLabel.TabIndex = 26
        Kd_transaksiLabel.Text = "Kode Transaksi :"
        '
        'Tgl_ambilLabel
        '
        Tgl_ambilLabel.AutoSize = True
        Tgl_ambilLabel.Location = New System.Drawing.Point(34, 71)
        Tgl_ambilLabel.Name = "Tgl_ambilLabel"
        Tgl_ambilLabel.Size = New System.Drawing.Size(91, 13)
        Tgl_ambilLabel.TabIndex = 28
        Tgl_ambilLabel.Text = "Kode Konsumen :"
        '
        'DiskonLabel
        '
        DiskonLabel.AutoSize = True
        DiskonLabel.Location = New System.Drawing.Point(31, 97)
        DiskonLabel.Name = "DiskonLabel"
        DiskonLabel.Size = New System.Drawing.Size(94, 13)
        DiskonLabel.TabIndex = 30
        DiskonLabel.Text = "Nama Konsumen :"
        '
        'Kd_konsumenLabel
        '
        Kd_konsumenLabel.AutoSize = True
        Kd_konsumenLabel.Location = New System.Drawing.Point(39, 124)
        Kd_konsumenLabel.Name = "Kd_konsumenLabel"
        Kd_konsumenLabel.Size = New System.Drawing.Size(86, 13)
        Kd_konsumenLabel.TabIndex = 32
        Kd_konsumenLabel.Text = "Contact Person :"
        '
        'KonsumenLabel
        '
        KonsumenLabel.AutoSize = True
        KonsumenLabel.Location = New System.Drawing.Point(80, 151)
        KonsumenLabel.Name = "KonsumenLabel"
        KonsumenLabel.Size = New System.Drawing.Size(45, 13)
        KonsumenLabel.TabIndex = 34
        KonsumenLabel.Text = "Alamat :"
        '
        'AlamatLabel
        '
        AlamatLabel.AutoSize = True
        AlamatLabel.Location = New System.Drawing.Point(79, 215)
        AlamatLabel.Name = "AlamatLabel"
        AlamatLabel.Size = New System.Drawing.Size(46, 13)
        AlamatLabel.TabIndex = 36
        AlamatLabel.Text = "Diskon :"
        '
        'CpLabel
        '
        CpLabel.AutoSize = True
        CpLabel.Location = New System.Drawing.Point(58, 242)
        CpLabel.Name = "CpLabel"
        CpLabel.Size = New System.Drawing.Size(67, 13)
        CpLabel.TabIndex = 38
        CpLabel.Text = "Total Bayar :"
        '
        'Kd_jenis_laundryLabel
        '
        Kd_jenis_laundryLabel.AutoSize = True
        Kd_jenis_laundryLabel.Location = New System.Drawing.Point(50, 269)
        Kd_jenis_laundryLabel.Name = "Kd_jenis_laundryLabel"
        Kd_jenis_laundryLabel.Size = New System.Drawing.Size(75, 13)
        Kd_jenis_laundryLabel.TabIndex = 40
        Kd_jenis_laundryLabel.Text = "Jumlah Uang :"
        '
        'Jenis_laundryLabel
        '
        Jenis_laundryLabel.AutoSize = True
        Jenis_laundryLabel.Location = New System.Drawing.Point(63, 296)
        Jenis_laundryLabel.Name = "Jenis_laundryLabel"
        Jenis_laundryLabel.Size = New System.Drawing.Size(62, 13)
        Jenis_laundryLabel.TabIndex = 42
        Jenis_laundryLabel.Text = "Kembalian :"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.ForeColor = System.Drawing.Color.White
        Label5.Location = New System.Drawing.Point(495, 34)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(245, 24)
        Label5.TabIndex = 27
        Label5.Text = "Transaksi Pengambilan"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.ForeColor = System.Drawing.Color.White
        Label4.Location = New System.Drawing.Point(9, 64)
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgv_pengambilan)
        Me.GroupBox2.Location = New System.Drawing.Point(358, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(364, 305)
        Me.GroupBox2.TabIndex = 45
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Daftar Jenis Laundry Terpilih"
        '
        'dgv_pengambilan
        '
        Me.dgv_pengambilan.AllowUserToAddRows = False
        Me.dgv_pengambilan.AllowUserToDeleteRows = False
        Me.dgv_pengambilan.AllowUserToOrderColumns = True
        Me.dgv_pengambilan.AutoGenerateColumns = False
        Me.dgv_pengambilan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pengambilan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KdjenislaundryDataGridViewTextBoxColumn, Me.JenislaundryDataGridViewTextBoxColumn, Me.TarifDataGridViewTextBoxColumn, Me.BeratDataGridViewTextBoxColumn})
        Me.dgv_pengambilan.DataSource = Me.bs_cari_pengambilan
        Me.dgv_pengambilan.Location = New System.Drawing.Point(15, 24)
        Me.dgv_pengambilan.Name = "dgv_pengambilan"
        Me.dgv_pengambilan.ReadOnly = True
        Me.dgv_pengambilan.Size = New System.Drawing.Size(332, 266)
        Me.dgv_pengambilan.TabIndex = 0
        '
        'KdjenislaundryDataGridViewTextBoxColumn
        '
        Me.KdjenislaundryDataGridViewTextBoxColumn.DataPropertyName = "kd_jenis_laundry"
        Me.KdjenislaundryDataGridViewTextBoxColumn.HeaderText = "KODE JENIS LAUNDRY"
        Me.KdjenislaundryDataGridViewTextBoxColumn.Name = "KdjenislaundryDataGridViewTextBoxColumn"
        Me.KdjenislaundryDataGridViewTextBoxColumn.ReadOnly = True
        Me.KdjenislaundryDataGridViewTextBoxColumn.Width = 170
        '
        'JenislaundryDataGridViewTextBoxColumn
        '
        Me.JenislaundryDataGridViewTextBoxColumn.DataPropertyName = "jenis_laundry"
        Me.JenislaundryDataGridViewTextBoxColumn.HeaderText = "JENIS LAUNDRY"
        Me.JenislaundryDataGridViewTextBoxColumn.Name = "JenislaundryDataGridViewTextBoxColumn"
        Me.JenislaundryDataGridViewTextBoxColumn.ReadOnly = True
        Me.JenislaundryDataGridViewTextBoxColumn.Width = 140
        '
        'TarifDataGridViewTextBoxColumn
        '
        Me.TarifDataGridViewTextBoxColumn.DataPropertyName = "tarif"
        Me.TarifDataGridViewTextBoxColumn.HeaderText = "TARIF"
        Me.TarifDataGridViewTextBoxColumn.Name = "TarifDataGridViewTextBoxColumn"
        Me.TarifDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BeratDataGridViewTextBoxColumn
        '
        Me.BeratDataGridViewTextBoxColumn.DataPropertyName = "berat"
        Me.BeratDataGridViewTextBoxColumn.HeaderText = "BERAT"
        Me.BeratDataGridViewTextBoxColumn.Name = "BeratDataGridViewTextBoxColumn"
        Me.BeratDataGridViewTextBoxColumn.ReadOnly = True
        '
        'bs_cari_pengambilan
        '
        Me.bs_cari_pengambilan.DataMember = "query_cari_pengambilan"
        Me.bs_cari_pengambilan.DataSource = Me.Db_laundryDataSet
        '
        'Db_laundryDataSet
        '
        Me.Db_laundryDataSet.DataSetName = "db_laundryDataSet"
        Me.Db_laundryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel4)
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Kd_transaksiLabel)
        Me.GroupBox1.Controls.Add(Me.txt_kd_transaksi)
        Me.GroupBox1.Controls.Add(Tgl_ambilLabel)
        Me.GroupBox1.Controls.Add(DiskonLabel)
        Me.GroupBox1.Controls.Add(Me.DiskonTextBox)
        Me.GroupBox1.Controls.Add(Kd_konsumenLabel)
        Me.GroupBox1.Controls.Add(Me.Kd_konsumenTextBox)
        Me.GroupBox1.Controls.Add(KonsumenLabel)
        Me.GroupBox1.Controls.Add(Me.KonsumenTextBox)
        Me.GroupBox1.Controls.Add(AlamatLabel)
        Me.GroupBox1.Controls.Add(Me.txt_diskon)
        Me.GroupBox1.Controls.Add(CpLabel)
        Me.GroupBox1.Controls.Add(Me.txt_tot_bayar)
        Me.GroupBox1.Controls.Add(Kd_jenis_laundryLabel)
        Me.GroupBox1.Controls.Add(Me.txt_jml_uang)
        Me.GroupBox1.Controls.Add(Jenis_laundryLabel)
        Me.GroupBox1.Controls.Add(Me.txt_kembalian)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(734, 408)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.Controls.Add(Me.cmd_keluar)
        Me.Panel4.Location = New System.Drawing.Point(358, 336)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(364, 62)
        Me.Panel4.TabIndex = 47
        '
        'cmd_keluar
        '
        Me.cmd_keluar.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_keluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_keluar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_keluar.ForeColor = System.Drawing.Color.White
        Me.cmd_keluar.Location = New System.Drawing.Point(277, 14)
        Me.cmd_keluar.Name = "cmd_keluar"
        Me.cmd_keluar.Size = New System.Drawing.Size(70, 34)
        Me.cmd_keluar.TabIndex = 23
        Me.cmd_keluar.Text = "&Keluar"
        Me.cmd_keluar.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Controls.Add(Me.cmd_resett)
        Me.Panel3.Controls.Add(Me.cmd_simpan)
        Me.Panel3.Location = New System.Drawing.Point(29, 336)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(310, 62)
        Me.Panel3.TabIndex = 46
        '
        'cmd_resett
        '
        Me.cmd_resett.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_resett.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_resett.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_resett.ForeColor = System.Drawing.Color.White
        Me.cmd_resett.Location = New System.Drawing.Point(229, 14)
        Me.cmd_resett.Name = "cmd_resett"
        Me.cmd_resett.Size = New System.Drawing.Size(70, 34)
        Me.cmd_resett.TabIndex = 22
        Me.cmd_resett.Text = "&Reset"
        Me.cmd_resett.UseVisualStyleBackColor = False
        '
        'cmd_simpan
        '
        Me.cmd_simpan.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_simpan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_simpan.ForeColor = System.Drawing.Color.White
        Me.cmd_simpan.Location = New System.Drawing.Point(153, 14)
        Me.cmd_simpan.Name = "cmd_simpan"
        Me.cmd_simpan.Size = New System.Drawing.Size(70, 34)
        Me.cmd_simpan.TabIndex = 21
        Me.cmd_simpan.Text = "&Bayar"
        Me.cmd_simpan.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs_cari_pengambilan, "kd_konsumen", True))
        Me.TextBox1.Location = New System.Drawing.Point(128, 68)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 20)
        Me.TextBox1.TabIndex = 44
        '
        'txt_kd_transaksi
        '
        Me.txt_kd_transaksi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_kd_transaksi.Location = New System.Drawing.Point(128, 41)
        Me.txt_kd_transaksi.Name = "txt_kd_transaksi"
        Me.txt_kd_transaksi.Size = New System.Drawing.Size(200, 20)
        Me.txt_kd_transaksi.TabIndex = 27
        '
        'DiskonTextBox
        '
        Me.DiskonTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DiskonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs_cari_pengambilan, "konsumen", True))
        Me.DiskonTextBox.Location = New System.Drawing.Point(128, 95)
        Me.DiskonTextBox.Name = "DiskonTextBox"
        Me.DiskonTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DiskonTextBox.TabIndex = 31
        '
        'Kd_konsumenTextBox
        '
        Me.Kd_konsumenTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Kd_konsumenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs_cari_pengambilan, "cp", True))
        Me.Kd_konsumenTextBox.Location = New System.Drawing.Point(128, 122)
        Me.Kd_konsumenTextBox.Name = "Kd_konsumenTextBox"
        Me.Kd_konsumenTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Kd_konsumenTextBox.TabIndex = 33
        '
        'KonsumenTextBox
        '
        Me.KonsumenTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KonsumenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs_cari_pengambilan, "alamat", True))
        Me.KonsumenTextBox.Location = New System.Drawing.Point(128, 149)
        Me.KonsumenTextBox.Multiline = True
        Me.KonsumenTextBox.Name = "KonsumenTextBox"
        Me.KonsumenTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.KonsumenTextBox.Size = New System.Drawing.Size(200, 57)
        Me.KonsumenTextBox.TabIndex = 35
        '
        'txt_diskon
        '
        Me.txt_diskon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_diskon.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs_cari_pengambilan, "diskon", True))
        Me.txt_diskon.Location = New System.Drawing.Point(128, 213)
        Me.txt_diskon.Name = "txt_diskon"
        Me.txt_diskon.Size = New System.Drawing.Size(200, 20)
        Me.txt_diskon.TabIndex = 37
        '
        'txt_tot_bayar
        '
        Me.txt_tot_bayar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tot_bayar.Location = New System.Drawing.Point(128, 240)
        Me.txt_tot_bayar.Name = "txt_tot_bayar"
        Me.txt_tot_bayar.Size = New System.Drawing.Size(200, 20)
        Me.txt_tot_bayar.TabIndex = 39
        '
        'txt_jml_uang
        '
        Me.txt_jml_uang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_jml_uang.Location = New System.Drawing.Point(128, 267)
        Me.txt_jml_uang.Name = "txt_jml_uang"
        Me.txt_jml_uang.Size = New System.Drawing.Size(200, 20)
        Me.txt_jml_uang.TabIndex = 41
        '
        'txt_kembalian
        '
        Me.txt_kembalian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_kembalian.Location = New System.Drawing.Point(128, 294)
        Me.txt_kembalian.Name = "txt_kembalian"
        Me.txt_kembalian.Size = New System.Drawing.Size(200, 20)
        Me.txt_kembalian.TabIndex = 43
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 528)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(752, 22)
        Me.StatusStrip1.TabIndex = 49
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Label5)
        Me.Panel1.Controls.Add(Label4)
        Me.Panel1.Controls.Add(Label3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(752, 108)
        Me.Panel1.TabIndex = 47
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gold
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 95)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(752, 13)
        Me.Panel2.TabIndex = 24
        '
        'bs_transaksi
        '
        Me.bs_transaksi.DataMember = "tb_transaksi"
        Me.bs_transaksi.DataSource = Me.Db_laundryDataSet
        '
        'ta_transaksi
        '
        Me.ta_transaksi.ClearBeforeFill = True
        '
        'ta_cari_pengambilan
        '
        Me.ta_cari_pengambilan.ClearBeforeFill = True
        '
        'f_transaksi_pengambilan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(752, 550)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "f_transaksi_pengambilan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaksi Pengambilan"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgv_pengambilan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_cari_pengambilan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_laundryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.bs_transaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_pengambilan As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents cmd_keluar As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cmd_resett As System.Windows.Forms.Button
    Friend WithEvents cmd_simpan As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_kd_transaksi As System.Windows.Forms.TextBox
    Friend WithEvents DiskonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Kd_konsumenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KonsumenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents txt_diskon As System.Windows.Forms.TextBox
    Friend WithEvents txt_tot_bayar As System.Windows.Forms.TextBox
    Friend WithEvents txt_jml_uang As System.Windows.Forms.TextBox
    Friend WithEvents txt_kembalian As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Db_laundryDataSet As JASA_LAUNDRY.db_laundryDataSet
    Friend WithEvents bs_transaksi As System.Windows.Forms.BindingSource
    Friend WithEvents ta_transaksi As JASA_LAUNDRY.db_laundryDataSetTableAdapters.tb_transaksiTableAdapter
    Friend WithEvents KdjenislaundryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JenislaundryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TarifDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BeratDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bs_cari_pengambilan As System.Windows.Forms.BindingSource
    Friend WithEvents ta_cari_pengambilan As JASA_LAUNDRY.db_laundryDataSetTableAdapters.query_cari_pengambilanTableAdapter
End Class
