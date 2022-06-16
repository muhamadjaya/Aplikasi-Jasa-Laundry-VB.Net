<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_transaksi_penerimaan
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
        Dim Label6 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Kd_konsumenLabel As System.Windows.Forms.Label
        Dim KonsumenLabel As System.Windows.Forms.Label
        Dim AlamatLabel As System.Windows.Forms.Label
        Dim CpLabel As System.Windows.Forms.Label
        Dim Kd_jenis_laundryLabel As System.Windows.Forms.Label
        Dim Jenis_laundryLabel As System.Windows.Forms.Label
        Dim TarifLabel As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.cmd_reset = New System.Windows.Forms.Button()
        Me.dgv_jenis = New System.Windows.Forms.DataGridView()
        Me.KdjenislaundryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JenislaundryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TarifDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BeratDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bs_tampil_jenis_laundry = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_laundryDataSet = New JASA_LAUNDRY.db_laundryDataSet()
        Me.cmd_generate = New System.Windows.Forms.Button()
        Me.cmd_hapus = New System.Windows.Forms.Button()
        Me.cmd_resett = New System.Windows.Forms.Button()
        Me.dtp_tgl_selesai = New System.Windows.Forms.DateTimePicker()
        Me.txt_diskon = New System.Windows.Forms.TextBox()
        Me.txt_kd_konsumen = New System.Windows.Forms.TextBox()
        Me.txt_konsumen = New System.Windows.Forms.TextBox()
        Me.txt_cp = New System.Windows.Forms.TextBox()
        Me.txt_alamat = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.cmd_simpan = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmd_ok = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cb_jenis_laundry = New System.Windows.Forms.ComboBox()
        Me.bs_jenis_laundry = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_tarif = New System.Windows.Forms.TextBox()
        Me.txt_berat = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ta_jenis_laundry = New JASA_LAUNDRY.db_laundryDataSetTableAdapters.tb_jenis_laundryTableAdapter()
        Me.bs_konsumen = New System.Windows.Forms.BindingSource(Me.components)
        Me.ta_konsumen = New JASA_LAUNDRY.db_laundryDataSetTableAdapters.tb_konsumenTableAdapter()
        Me.bs_transaksi = New System.Windows.Forms.BindingSource(Me.components)
        Me.ta_transaksi = New JASA_LAUNDRY.db_laundryDataSetTableAdapters.tb_transaksiTableAdapter()
        Me.bs_detail_transaksi = New System.Windows.Forms.BindingSource(Me.components)
        Me.ta_detail_transaksi = New JASA_LAUNDRY.db_laundryDataSetTableAdapters.tb_detail_transaksiTableAdapter()
        Label6 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Kd_konsumenLabel = New System.Windows.Forms.Label()
        KonsumenLabel = New System.Windows.Forms.Label()
        AlamatLabel = New System.Windows.Forms.Label()
        CpLabel = New System.Windows.Forms.Label()
        Kd_jenis_laundryLabel = New System.Windows.Forms.Label()
        Jenis_laundryLabel = New System.Windows.Forms.Label()
        TarifLabel = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.dgv_jenis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_tampil_jenis_laundry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_laundryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.bs_jenis_laundry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.bs_konsumen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_transaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_detail_transaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(213, 97)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(39, 13)
        Label6.TabIndex = 19
        Label6.Text = "Kg / m"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(35, 231)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(46, 13)
        Label1.TabIndex = 28
        Label1.Text = "Diskon :"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(36, 286)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(89, 13)
        Label2.TabIndex = 29
        Label2.Text = "Tanggal Selesai :"
        '
        'Kd_konsumenLabel
        '
        Kd_konsumenLabel.AutoSize = True
        Kd_konsumenLabel.Location = New System.Drawing.Point(35, 29)
        Kd_konsumenLabel.Name = "Kd_konsumenLabel"
        Kd_konsumenLabel.Size = New System.Drawing.Size(91, 13)
        Kd_konsumenLabel.TabIndex = 20
        Kd_konsumenLabel.Text = "Kode Konsumen :"
        '
        'KonsumenLabel
        '
        KonsumenLabel.AutoSize = True
        KonsumenLabel.Location = New System.Drawing.Point(35, 74)
        KonsumenLabel.Name = "KonsumenLabel"
        KonsumenLabel.Size = New System.Drawing.Size(63, 13)
        KonsumenLabel.TabIndex = 22
        KonsumenLabel.Text = "Konsumen :"
        '
        'AlamatLabel
        '
        AlamatLabel.AutoSize = True
        AlamatLabel.Location = New System.Drawing.Point(35, 119)
        AlamatLabel.Name = "AlamatLabel"
        AlamatLabel.Size = New System.Drawing.Size(86, 13)
        AlamatLabel.TabIndex = 24
        AlamatLabel.Text = "Contact Person :"
        '
        'CpLabel
        '
        CpLabel.AutoSize = True
        CpLabel.Location = New System.Drawing.Point(35, 164)
        CpLabel.Name = "CpLabel"
        CpLabel.Size = New System.Drawing.Size(45, 13)
        CpLabel.TabIndex = 26
        CpLabel.Text = "Alamat :"
        '
        'Kd_jenis_laundryLabel
        '
        Kd_jenis_laundryLabel.AutoSize = True
        Kd_jenis_laundryLabel.Location = New System.Drawing.Point(40, 40)
        Kd_jenis_laundryLabel.Name = "Kd_jenis_laundryLabel"
        Kd_jenis_laundryLabel.Size = New System.Drawing.Size(78, 13)
        Kd_jenis_laundryLabel.TabIndex = 1
        Kd_jenis_laundryLabel.Text = "Jenis Laundry :"
        '
        'Jenis_laundryLabel
        '
        Jenis_laundryLabel.AutoSize = True
        Jenis_laundryLabel.Location = New System.Drawing.Point(84, 68)
        Jenis_laundryLabel.Name = "Jenis_laundryLabel"
        Jenis_laundryLabel.Size = New System.Drawing.Size(34, 13)
        Jenis_laundryLabel.TabIndex = 3
        Jenis_laundryLabel.Text = "Tarif :"
        '
        'TarifLabel
        '
        TarifLabel.AutoSize = True
        TarifLabel.Location = New System.Drawing.Point(30, 96)
        TarifLabel.Name = "TarifLabel"
        TarifLabel.Size = New System.Drawing.Size(88, 13)
        TarifLabel.TabIndex = 5
        TarifLabel.Text = "Berat / Panjang :"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.ForeColor = System.Drawing.Color.White
        Label5.Location = New System.Drawing.Point(420, 33)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(234, 24)
        Label5.TabIndex = 27
        Label5.Text = "Transaksi Penerimaan"
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
        'cmd_reset
        '
        Me.cmd_reset.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_reset.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_reset.ForeColor = System.Drawing.Color.White
        Me.cmd_reset.Location = New System.Drawing.Point(194, 121)
        Me.cmd_reset.Name = "cmd_reset"
        Me.cmd_reset.Size = New System.Drawing.Size(68, 34)
        Me.cmd_reset.TabIndex = 18
        Me.cmd_reset.Text = "&Reset"
        Me.cmd_reset.UseVisualStyleBackColor = False
        '
        'dgv_jenis
        '
        Me.dgv_jenis.AllowUserToAddRows = False
        Me.dgv_jenis.AllowUserToDeleteRows = False
        Me.dgv_jenis.AllowUserToOrderColumns = True
        Me.dgv_jenis.AutoGenerateColumns = False
        Me.dgv_jenis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_jenis.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KdjenislaundryDataGridViewTextBoxColumn, Me.JenislaundryDataGridViewTextBoxColumn, Me.TarifDataGridViewTextBoxColumn, Me.BeratDataGridViewTextBoxColumn})
        Me.dgv_jenis.DataSource = Me.bs_tampil_jenis_laundry
        Me.dgv_jenis.Location = New System.Drawing.Point(16, 24)
        Me.dgv_jenis.Name = "dgv_jenis"
        Me.dgv_jenis.ReadOnly = True
        Me.dgv_jenis.Size = New System.Drawing.Size(277, 126)
        Me.dgv_jenis.TabIndex = 0
        '
        'KdjenislaundryDataGridViewTextBoxColumn
        '
        Me.KdjenislaundryDataGridViewTextBoxColumn.DataPropertyName = "kd_jenis_laundry"
        Me.KdjenislaundryDataGridViewTextBoxColumn.HeaderText = "KODE JENIS LAUNDRY"
        Me.KdjenislaundryDataGridViewTextBoxColumn.Name = "KdjenislaundryDataGridViewTextBoxColumn"
        Me.KdjenislaundryDataGridViewTextBoxColumn.ReadOnly = True
        Me.KdjenislaundryDataGridViewTextBoxColumn.Width = 150
        '
        'JenislaundryDataGridViewTextBoxColumn
        '
        Me.JenislaundryDataGridViewTextBoxColumn.DataPropertyName = "jenis_laundry"
        Me.JenislaundryDataGridViewTextBoxColumn.HeaderText = "JENIS LAUNDRY"
        Me.JenislaundryDataGridViewTextBoxColumn.Name = "JenislaundryDataGridViewTextBoxColumn"
        Me.JenislaundryDataGridViewTextBoxColumn.ReadOnly = True
        Me.JenislaundryDataGridViewTextBoxColumn.Width = 120
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
        'bs_tampil_jenis_laundry
        '
        Me.bs_tampil_jenis_laundry.DataMember = "tb_tampil_jenis_laundry"
        Me.bs_tampil_jenis_laundry.DataSource = Me.Db_laundryDataSet
        '
        'Db_laundryDataSet
        '
        Me.Db_laundryDataSet.DataSetName = "db_laundryDataSet"
        Me.Db_laundryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmd_generate
        '
        Me.cmd_generate.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_generate.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_generate.ForeColor = System.Drawing.Color.White
        Me.cmd_generate.Location = New System.Drawing.Point(232, 45)
        Me.cmd_generate.Name = "cmd_generate"
        Me.cmd_generate.Size = New System.Drawing.Size(56, 20)
        Me.cmd_generate.TabIndex = 32
        Me.cmd_generate.Text = "Generate"
        Me.cmd_generate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_generate.UseVisualStyleBackColor = False
        '
        'cmd_hapus
        '
        Me.cmd_hapus.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_hapus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_hapus.ForeColor = System.Drawing.Color.White
        Me.cmd_hapus.Location = New System.Drawing.Point(225, 156)
        Me.cmd_hapus.Name = "cmd_hapus"
        Me.cmd_hapus.Size = New System.Drawing.Size(68, 34)
        Me.cmd_hapus.TabIndex = 32
        Me.cmd_hapus.Text = "&Hapus"
        Me.cmd_hapus.UseVisualStyleBackColor = False
        '
        'cmd_resett
        '
        Me.cmd_resett.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_resett.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_resett.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_resett.ForeColor = System.Drawing.Color.White
        Me.cmd_resett.Location = New System.Drawing.Point(163, 338)
        Me.cmd_resett.Name = "cmd_resett"
        Me.cmd_resett.Size = New System.Drawing.Size(68, 34)
        Me.cmd_resett.TabIndex = 20
        Me.cmd_resett.Text = "&Reset"
        Me.cmd_resett.UseVisualStyleBackColor = False
        '
        'dtp_tgl_selesai
        '
        Me.dtp_tgl_selesai.Location = New System.Drawing.Point(38, 302)
        Me.dtp_tgl_selesai.Name = "dtp_tgl_selesai"
        Me.dtp_tgl_selesai.Size = New System.Drawing.Size(193, 20)
        Me.dtp_tgl_selesai.TabIndex = 31
        '
        'txt_diskon
        '
        Me.txt_diskon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_diskon.Location = New System.Drawing.Point(39, 247)
        Me.txt_diskon.Name = "txt_diskon"
        Me.txt_diskon.Size = New System.Drawing.Size(192, 20)
        Me.txt_diskon.TabIndex = 30
        '
        'txt_kd_konsumen
        '
        Me.txt_kd_konsumen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_kd_konsumen.Location = New System.Drawing.Point(38, 45)
        Me.txt_kd_konsumen.Name = "txt_kd_konsumen"
        Me.txt_kd_konsumen.Size = New System.Drawing.Size(192, 20)
        Me.txt_kd_konsumen.TabIndex = 21
        '
        'txt_konsumen
        '
        Me.txt_konsumen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_konsumen.Location = New System.Drawing.Point(38, 90)
        Me.txt_konsumen.Name = "txt_konsumen"
        Me.txt_konsumen.Size = New System.Drawing.Size(192, 20)
        Me.txt_konsumen.TabIndex = 23
        '
        'txt_cp
        '
        Me.txt_cp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cp.Location = New System.Drawing.Point(38, 135)
        Me.txt_cp.Name = "txt_cp"
        Me.txt_cp.Size = New System.Drawing.Size(192, 20)
        Me.txt_cp.TabIndex = 25
        '
        'txt_alamat
        '
        Me.txt_alamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_alamat.Location = New System.Drawing.Point(38, 180)
        Me.txt_alamat.Multiline = True
        Me.txt_alamat.Name = "txt_alamat"
        Me.txt_alamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_alamat.Size = New System.Drawing.Size(192, 43)
        Me.txt_alamat.TabIndex = 27
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 511)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(667, 22)
        Me.StatusStrip1.TabIndex = 26
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'cmd_simpan
        '
        Me.cmd_simpan.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_simpan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_simpan.ForeColor = System.Drawing.Color.White
        Me.cmd_simpan.Location = New System.Drawing.Point(89, 338)
        Me.cmd_simpan.Name = "cmd_simpan"
        Me.cmd_simpan.Size = New System.Drawing.Size(68, 34)
        Me.cmd_simpan.TabIndex = 19
        Me.cmd_simpan.Text = "&Simpan"
        Me.cmd_simpan.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gold
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 95)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(667, 13)
        Me.Panel2.TabIndex = 24
        '
        'cmd_ok
        '
        Me.cmd_ok.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_ok.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_ok.ForeColor = System.Drawing.Color.White
        Me.cmd_ok.Location = New System.Drawing.Point(120, 121)
        Me.cmd_ok.Name = "cmd_ok"
        Me.cmd_ok.Size = New System.Drawing.Size(68, 34)
        Me.cmd_ok.TabIndex = 17
        Me.cmd_ok.Text = "&OK"
        Me.cmd_ok.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmd_generate)
        Me.GroupBox2.Controls.Add(Me.cmd_resett)
        Me.GroupBox2.Controls.Add(Me.cmd_simpan)
        Me.GroupBox2.Controls.Add(Me.dtp_tgl_selesai)
        Me.GroupBox2.Controls.Add(Me.txt_diskon)
        Me.GroupBox2.Controls.Add(Label1)
        Me.GroupBox2.Controls.Add(Label2)
        Me.GroupBox2.Controls.Add(Kd_konsumenLabel)
        Me.GroupBox2.Controls.Add(Me.txt_kd_konsumen)
        Me.GroupBox2.Controls.Add(KonsumenLabel)
        Me.GroupBox2.Controls.Add(Me.txt_konsumen)
        Me.GroupBox2.Controls.Add(AlamatLabel)
        Me.GroupBox2.Controls.Add(Me.txt_cp)
        Me.GroupBox2.Controls.Add(CpLabel)
        Me.GroupBox2.Controls.Add(Me.txt_alamat)
        Me.GroupBox2.Location = New System.Drawing.Point(362, 111)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(295, 388)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Konsumen"
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
        Me.Panel1.Size = New System.Drawing.Size(667, 108)
        Me.Panel1.TabIndex = 27
        '
        'cb_jenis_laundry
        '
        Me.cb_jenis_laundry.DataSource = Me.bs_jenis_laundry
        Me.cb_jenis_laundry.DisplayMember = "jenis_laundry"
        Me.cb_jenis_laundry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_jenis_laundry.FormattingEnabled = True
        Me.cb_jenis_laundry.Location = New System.Drawing.Point(120, 37)
        Me.cb_jenis_laundry.Name = "cb_jenis_laundry"
        Me.cb_jenis_laundry.Size = New System.Drawing.Size(161, 21)
        Me.cb_jenis_laundry.TabIndex = 15
        Me.cb_jenis_laundry.ValueMember = "kd_jenis_laundry"
        '
        'bs_jenis_laundry
        '
        Me.bs_jenis_laundry.DataMember = "tb_jenis_laundry"
        Me.bs_jenis_laundry.DataSource = Me.Db_laundryDataSet
        '
        'txt_tarif
        '
        Me.txt_tarif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tarif.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs_jenis_laundry, "tarif", True))
        Me.txt_tarif.Location = New System.Drawing.Point(120, 65)
        Me.txt_tarif.Name = "txt_tarif"
        Me.txt_tarif.Size = New System.Drawing.Size(161, 20)
        Me.txt_tarif.TabIndex = 4
        '
        'txt_berat
        '
        Me.txt_berat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_berat.Location = New System.Drawing.Point(120, 93)
        Me.txt_berat.Name = "txt_berat"
        Me.txt_berat.Size = New System.Drawing.Size(87, 20)
        Me.txt_berat.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Label6)
        Me.GroupBox1.Controls.Add(Me.cmd_reset)
        Me.GroupBox1.Controls.Add(Me.cmd_ok)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.cb_jenis_laundry)
        Me.GroupBox1.Controls.Add(Kd_jenis_laundryLabel)
        Me.GroupBox1.Controls.Add(Jenis_laundryLabel)
        Me.GroupBox1.Controls.Add(Me.txt_tarif)
        Me.GroupBox1.Controls.Add(TarifLabel)
        Me.GroupBox1.Controls.Add(Me.txt_berat)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 111)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(348, 389)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Laundry"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmd_hapus)
        Me.GroupBox3.Controls.Add(Me.dgv_jenis)
        Me.GroupBox3.Location = New System.Drawing.Point(19, 182)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(312, 200)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Daftar Jenis Laundry Terpilih"
        '
        'ta_jenis_laundry
        '
        Me.ta_jenis_laundry.ClearBeforeFill = True
        '
        'bs_konsumen
        '
        Me.bs_konsumen.DataMember = "tb_konsumen"
        Me.bs_konsumen.DataSource = Me.Db_laundryDataSet
        '
        'ta_konsumen
        '
        Me.ta_konsumen.ClearBeforeFill = True
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
        'bs_detail_transaksi
        '
        Me.bs_detail_transaksi.DataMember = "tb_detail_transaksi"
        Me.bs_detail_transaksi.DataSource = Me.Db_laundryDataSet
        '
        'ta_detail_transaksi
        '
        Me.ta_detail_transaksi.ClearBeforeFill = True
        '
        'f_transaksi_penerimaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(667, 533)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "f_transaksi_penerimaan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaksi Penerimaan"
        CType(Me.dgv_jenis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_tampil_jenis_laundry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_laundryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.bs_jenis_laundry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.bs_konsumen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_transaksi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_detail_transaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_reset As System.Windows.Forms.Button
    Friend WithEvents dgv_jenis As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_generate As System.Windows.Forms.Button
    Friend WithEvents cmd_hapus As System.Windows.Forms.Button
    Friend WithEvents cmd_resett As System.Windows.Forms.Button
    Friend WithEvents dtp_tgl_selesai As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_diskon As System.Windows.Forms.TextBox
    Friend WithEvents txt_kd_konsumen As System.Windows.Forms.TextBox
    Friend WithEvents txt_konsumen As System.Windows.Forms.TextBox
    Friend WithEvents txt_cp As System.Windows.Forms.TextBox
    Friend WithEvents txt_alamat As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents cmd_simpan As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmd_ok As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cb_jenis_laundry As System.Windows.Forms.ComboBox
    Friend WithEvents txt_tarif As System.Windows.Forms.TextBox
    Friend WithEvents txt_berat As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents bs_tampil_jenis_laundry As System.Windows.Forms.BindingSource
    Friend WithEvents Db_laundryDataSet As JASA_LAUNDRY.db_laundryDataSet
    Friend WithEvents bs_jenis_laundry As System.Windows.Forms.BindingSource
    Friend WithEvents ta_jenis_laundry As JASA_LAUNDRY.db_laundryDataSetTableAdapters.tb_jenis_laundryTableAdapter
    Friend WithEvents bs_konsumen As System.Windows.Forms.BindingSource
    Friend WithEvents ta_konsumen As JASA_LAUNDRY.db_laundryDataSetTableAdapters.tb_konsumenTableAdapter
    Friend WithEvents bs_transaksi As System.Windows.Forms.BindingSource
    Friend WithEvents ta_transaksi As JASA_LAUNDRY.db_laundryDataSetTableAdapters.tb_transaksiTableAdapter
    Friend WithEvents bs_detail_transaksi As System.Windows.Forms.BindingSource
    Friend WithEvents ta_detail_transaksi As JASA_LAUNDRY.db_laundryDataSetTableAdapters.tb_detail_transaksiTableAdapter
    Friend WithEvents KdjenislaundryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JenislaundryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TarifDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BeratDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
