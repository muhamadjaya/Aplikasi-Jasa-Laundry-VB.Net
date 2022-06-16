<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_pembelian_barang
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
        Dim Label1 As System.Windows.Forms.Label
        Dim Kd_barangLabel As System.Windows.Forms.Label
        Dim BarangLabel As System.Windows.Forms.Label
        Dim StokLabel As System.Windows.Forms.Label
        Dim SatuanLabel As System.Windows.Forms.Label
        Dim H_beliLabel As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmd_hapus = New System.Windows.Forms.Button()
        Me.cmd_reset = New System.Windows.Forms.Button()
        Me.cmd_ok = New System.Windows.Forms.Button()
        Me.cb_satuan = New System.Windows.Forms.ComboBox()
        Me.txt_jumlah = New System.Windows.Forms.TextBox()
        Me.txt_kd_barang = New System.Windows.Forms.TextBox()
        Me.txt_barang = New System.Windows.Forms.TextBox()
        Me.txt_h_beli = New System.Windows.Forms.TextBox()
        Me.txt_qty = New System.Windows.Forms.TextBox()
        Me.cmd_keluar = New System.Windows.Forms.Button()
        Me.cmd_simpan = New System.Windows.Forms.Button()
        Me.dtp_tgl_beli = New System.Windows.Forms.DateTimePicker()
        Me.cb_supplier = New System.Windows.Forms.ComboBox()
        Me.bs_supplier = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_laundryDataSet = New JASA_LAUNDRY.db_laundryDataSet()
        Me.txt_jml_item = New System.Windows.Forms.TextBox()
        Me.txt_tot_biaya = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgv_barang = New System.Windows.Forms.DataGridView()
        Me.KdbarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SatuanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HbeliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bs_c_pembelian = New System.Windows.Forms.BindingSource(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.bs_barang = New System.Windows.Forms.BindingSource(Me.components)
        Me.ta_barang = New JASA_LAUNDRY.db_laundryDataSetTableAdapters.tb_barangTableAdapter()
        Me.bs_pembelian_barang = New System.Windows.Forms.BindingSource(Me.components)
        Me.ta_pembelian_barang = New JASA_LAUNDRY.db_laundryDataSetTableAdapters.tb_pembelian_barangTableAdapter()
        Me.bs_detail_pembelian_barang = New System.Windows.Forms.BindingSource(Me.components)
        Me.ta_detail_pembelian_barang = New JASA_LAUNDRY.db_laundryDataSetTableAdapters.tb_detail_pembelian_barangTableAdapter()
        Me.ta_supplier = New JASA_LAUNDRY.db_laundryDataSetTableAdapters.tb_supplierTableAdapter()
        Label1 = New System.Windows.Forms.Label()
        Kd_barangLabel = New System.Windows.Forms.Label()
        BarangLabel = New System.Windows.Forms.Label()
        StokLabel = New System.Windows.Forms.Label()
        SatuanLabel = New System.Windows.Forms.Label()
        H_beliLabel = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.bs_supplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_laundryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv_barang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_c_pembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.bs_barang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_pembelian_barang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_detail_pembelian_barang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(295, 82)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(46, 13)
        Label1.TabIndex = 12
        Label1.Text = "Jumlah :"
        '
        'Kd_barangLabel
        '
        Kd_barangLabel.AutoSize = True
        Kd_barangLabel.Location = New System.Drawing.Point(24, 31)
        Kd_barangLabel.Name = "Kd_barangLabel"
        Kd_barangLabel.Size = New System.Drawing.Size(75, 13)
        Kd_barangLabel.TabIndex = 1
        Kd_barangLabel.Text = "Kode Barang :"
        '
        'BarangLabel
        '
        BarangLabel.AutoSize = True
        BarangLabel.Location = New System.Drawing.Point(52, 57)
        BarangLabel.Name = "BarangLabel"
        BarangLabel.Size = New System.Drawing.Size(47, 13)
        BarangLabel.TabIndex = 3
        BarangLabel.Text = "Barang :"
        '
        'StokLabel
        '
        StokLabel.AutoSize = True
        StokLabel.Location = New System.Drawing.Point(52, 83)
        StokLabel.Name = "StokLabel"
        StokLabel.Size = New System.Drawing.Size(47, 13)
        StokLabel.TabIndex = 5
        StokLabel.Text = "Satuan :"
        '
        'SatuanLabel
        '
        SatuanLabel.AutoSize = True
        SatuanLabel.Location = New System.Drawing.Point(279, 26)
        SatuanLabel.Name = "SatuanLabel"
        SatuanLabel.Size = New System.Drawing.Size(62, 13)
        SatuanLabel.TabIndex = 7
        SatuanLabel.Text = "Harga Beli :"
        '
        'H_beliLabel
        '
        H_beliLabel.AutoSize = True
        H_beliLabel.Location = New System.Drawing.Point(289, 56)
        H_beliLabel.Name = "H_beliLabel"
        H_beliLabel.Size = New System.Drawing.Size(52, 13)
        H_beliLabel.TabIndex = 9
        H_beliLabel.Text = "Quantity :"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.ForeColor = System.Drawing.Color.White
        Label6.Location = New System.Drawing.Point(612, 33)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(194, 24)
        Label6.TabIndex = 27
        Label6.Text = "Pembelian Barang"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.ForeColor = System.Drawing.Color.White
        Label7.Location = New System.Drawing.Point(9, 64)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(147, 24)
        Label7.TabIndex = 26
        Label7.Text = "Jasa Laundry"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.ForeColor = System.Drawing.Color.White
        Label8.Location = New System.Drawing.Point(8, 8)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(209, 29)
        Label8.TabIndex = 25
        Label8.Text = "MAMA LAUNDRY"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(18, 105)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(66, 13)
        Label5.TabIndex = 20
        Label5.Text = "Total Biaya :"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(33, 24)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(51, 13)
        Label2.TabIndex = 14
        Label2.Text = "Supplier :"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(15, 76)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(69, 13)
        Label4.TabIndex = 18
        Label4.Text = "Jumlah Item :"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(12, 50)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(72, 13)
        Label3.TabIndex = 16
        Label3.Text = "Tanggal Beli :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmd_hapus)
        Me.GroupBox1.Controls.Add(Me.cmd_reset)
        Me.GroupBox1.Controls.Add(Me.cmd_ok)
        Me.GroupBox1.Controls.Add(Me.cb_satuan)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Me.txt_jumlah)
        Me.GroupBox1.Controls.Add(Kd_barangLabel)
        Me.GroupBox1.Controls.Add(Me.txt_kd_barang)
        Me.GroupBox1.Controls.Add(BarangLabel)
        Me.GroupBox1.Controls.Add(Me.txt_barang)
        Me.GroupBox1.Controls.Add(StokLabel)
        Me.GroupBox1.Controls.Add(SatuanLabel)
        Me.GroupBox1.Controls.Add(Me.txt_h_beli)
        Me.GroupBox1.Controls.Add(H_beliLabel)
        Me.GroupBox1.Controls.Add(Me.txt_qty)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 286)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(534, 178)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        '
        'cmd_hapus
        '
        Me.cmd_hapus.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_hapus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_hapus.ForeColor = System.Drawing.Color.White
        Me.cmd_hapus.Location = New System.Drawing.Point(429, 130)
        Me.cmd_hapus.Name = "cmd_hapus"
        Me.cmd_hapus.Size = New System.Drawing.Size(70, 34)
        Me.cmd_hapus.TabIndex = 25
        Me.cmd_hapus.Text = "&Hapus"
        Me.cmd_hapus.UseVisualStyleBackColor = False
        '
        'cmd_reset
        '
        Me.cmd_reset.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_reset.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_reset.ForeColor = System.Drawing.Color.White
        Me.cmd_reset.Location = New System.Drawing.Point(353, 130)
        Me.cmd_reset.Name = "cmd_reset"
        Me.cmd_reset.Size = New System.Drawing.Size(70, 34)
        Me.cmd_reset.TabIndex = 24
        Me.cmd_reset.Text = "&Cancel"
        Me.cmd_reset.UseVisualStyleBackColor = False
        '
        'cmd_ok
        '
        Me.cmd_ok.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_ok.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_ok.ForeColor = System.Drawing.Color.White
        Me.cmd_ok.Location = New System.Drawing.Point(277, 130)
        Me.cmd_ok.Name = "cmd_ok"
        Me.cmd_ok.Size = New System.Drawing.Size(70, 34)
        Me.cmd_ok.TabIndex = 23
        Me.cmd_ok.Text = "&OK"
        Me.cmd_ok.UseVisualStyleBackColor = False
        '
        'cb_satuan
        '
        Me.cb_satuan.FormattingEnabled = True
        Me.cb_satuan.Items.AddRange(New Object() {"PCS", "BTL", "PAK", "DUS"})
        Me.cb_satuan.Location = New System.Drawing.Point(102, 80)
        Me.cb_satuan.Name = "cb_satuan"
        Me.cb_satuan.Size = New System.Drawing.Size(87, 21)
        Me.cb_satuan.TabIndex = 13
        '
        'txt_jumlah
        '
        Me.txt_jumlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_jumlah.Location = New System.Drawing.Point(344, 80)
        Me.txt_jumlah.Name = "txt_jumlah"
        Me.txt_jumlah.Size = New System.Drawing.Size(155, 20)
        Me.txt_jumlah.TabIndex = 11
        '
        'txt_kd_barang
        '
        Me.txt_kd_barang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_kd_barang.Location = New System.Drawing.Point(102, 28)
        Me.txt_kd_barang.Name = "txt_kd_barang"
        Me.txt_kd_barang.Size = New System.Drawing.Size(155, 20)
        Me.txt_kd_barang.TabIndex = 2
        '
        'txt_barang
        '
        Me.txt_barang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_barang.Location = New System.Drawing.Point(102, 54)
        Me.txt_barang.Name = "txt_barang"
        Me.txt_barang.Size = New System.Drawing.Size(155, 20)
        Me.txt_barang.TabIndex = 4
        '
        'txt_h_beli
        '
        Me.txt_h_beli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_h_beli.Location = New System.Drawing.Point(344, 28)
        Me.txt_h_beli.Name = "txt_h_beli"
        Me.txt_h_beli.Size = New System.Drawing.Size(155, 20)
        Me.txt_h_beli.TabIndex = 8
        '
        'txt_qty
        '
        Me.txt_qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_qty.Location = New System.Drawing.Point(344, 54)
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Size = New System.Drawing.Size(85, 20)
        Me.txt_qty.TabIndex = 10
        '
        'cmd_keluar
        '
        Me.cmd_keluar.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_keluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_keluar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_keluar.ForeColor = System.Drawing.Color.White
        Me.cmd_keluar.Location = New System.Drawing.Point(163, 130)
        Me.cmd_keluar.Name = "cmd_keluar"
        Me.cmd_keluar.Size = New System.Drawing.Size(70, 34)
        Me.cmd_keluar.TabIndex = 26
        Me.cmd_keluar.Text = "&Keluar"
        Me.cmd_keluar.UseVisualStyleBackColor = False
        '
        'cmd_simpan
        '
        Me.cmd_simpan.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_simpan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_simpan.ForeColor = System.Drawing.Color.White
        Me.cmd_simpan.Location = New System.Drawing.Point(87, 130)
        Me.cmd_simpan.Name = "cmd_simpan"
        Me.cmd_simpan.Size = New System.Drawing.Size(70, 34)
        Me.cmd_simpan.TabIndex = 25
        Me.cmd_simpan.Text = "&Simpan"
        Me.cmd_simpan.UseVisualStyleBackColor = False
        '
        'dtp_tgl_beli
        '
        Me.dtp_tgl_beli.Location = New System.Drawing.Point(87, 47)
        Me.dtp_tgl_beli.Name = "dtp_tgl_beli"
        Me.dtp_tgl_beli.Size = New System.Drawing.Size(155, 20)
        Me.dtp_tgl_beli.TabIndex = 21
        '
        'cb_supplier
        '
        Me.cb_supplier.DataSource = Me.bs_supplier
        Me.cb_supplier.DisplayMember = "supplier"
        Me.cb_supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_supplier.FormattingEnabled = True
        Me.cb_supplier.Location = New System.Drawing.Point(87, 21)
        Me.cb_supplier.Name = "cb_supplier"
        Me.cb_supplier.Size = New System.Drawing.Size(155, 21)
        Me.cb_supplier.TabIndex = 19
        Me.cb_supplier.ValueMember = "kd_supplier"
        '
        'bs_supplier
        '
        Me.bs_supplier.DataMember = "tb_supplier"
        Me.bs_supplier.DataSource = Me.Db_laundryDataSet
        '
        'Db_laundryDataSet
        '
        Me.Db_laundryDataSet.DataSetName = "db_laundryDataSet"
        Me.Db_laundryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txt_jml_item
        '
        Me.txt_jml_item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_jml_item.Location = New System.Drawing.Point(87, 74)
        Me.txt_jml_item.Name = "txt_jml_item"
        Me.txt_jml_item.Size = New System.Drawing.Size(155, 20)
        Me.txt_jml_item.TabIndex = 15
        '
        'txt_tot_biaya
        '
        Me.txt_tot_biaya.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tot_biaya.Location = New System.Drawing.Point(87, 100)
        Me.txt_tot_biaya.Name = "txt_tot_biaya"
        Me.txt_tot_biaya.Size = New System.Drawing.Size(155, 20)
        Me.txt_tot_biaya.TabIndex = 17
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gold
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 95)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(813, 13)
        Me.Panel2.TabIndex = 24
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgv_barang)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 108)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(801, 180)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        '
        'dgv_barang
        '
        Me.dgv_barang.AllowUserToAddRows = False
        Me.dgv_barang.AllowUserToDeleteRows = False
        Me.dgv_barang.AllowUserToOrderColumns = True
        Me.dgv_barang.AutoGenerateColumns = False
        Me.dgv_barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_barang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KdbarangDataGridViewTextBoxColumn, Me.BarangDataGridViewTextBoxColumn, Me.SatuanDataGridViewTextBoxColumn, Me.HbeliDataGridViewTextBoxColumn, Me.QtyDataGridViewTextBoxColumn})
        Me.dgv_barang.DataSource = Me.bs_c_pembelian
        Me.dgv_barang.Location = New System.Drawing.Point(11, 19)
        Me.dgv_barang.Name = "dgv_barang"
        Me.dgv_barang.ReadOnly = True
        Me.dgv_barang.Size = New System.Drawing.Size(778, 150)
        Me.dgv_barang.TabIndex = 0
        '
        'KdbarangDataGridViewTextBoxColumn
        '
        Me.KdbarangDataGridViewTextBoxColumn.DataPropertyName = "kd_barang"
        Me.KdbarangDataGridViewTextBoxColumn.HeaderText = "KODE BARANG"
        Me.KdbarangDataGridViewTextBoxColumn.Name = "KdbarangDataGridViewTextBoxColumn"
        Me.KdbarangDataGridViewTextBoxColumn.ReadOnly = True
        Me.KdbarangDataGridViewTextBoxColumn.Width = 110
        '
        'BarangDataGridViewTextBoxColumn
        '
        Me.BarangDataGridViewTextBoxColumn.DataPropertyName = "barang"
        Me.BarangDataGridViewTextBoxColumn.HeaderText = "NAMA BARANG"
        Me.BarangDataGridViewTextBoxColumn.Name = "BarangDataGridViewTextBoxColumn"
        Me.BarangDataGridViewTextBoxColumn.ReadOnly = True
        Me.BarangDataGridViewTextBoxColumn.Width = 120
        '
        'SatuanDataGridViewTextBoxColumn
        '
        Me.SatuanDataGridViewTextBoxColumn.DataPropertyName = "satuan"
        Me.SatuanDataGridViewTextBoxColumn.HeaderText = "SATUAN"
        Me.SatuanDataGridViewTextBoxColumn.Name = "SatuanDataGridViewTextBoxColumn"
        Me.SatuanDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HbeliDataGridViewTextBoxColumn
        '
        Me.HbeliDataGridViewTextBoxColumn.DataPropertyName = "h_beli"
        Me.HbeliDataGridViewTextBoxColumn.HeaderText = "HARGA BELI (PER ITEM)"
        Me.HbeliDataGridViewTextBoxColumn.Name = "HbeliDataGridViewTextBoxColumn"
        Me.HbeliDataGridViewTextBoxColumn.ReadOnly = True
        Me.HbeliDataGridViewTextBoxColumn.Width = 190
        '
        'QtyDataGridViewTextBoxColumn
        '
        Me.QtyDataGridViewTextBoxColumn.DataPropertyName = "qty"
        Me.QtyDataGridViewTextBoxColumn.HeaderText = "QUANTITY"
        Me.QtyDataGridViewTextBoxColumn.Name = "QtyDataGridViewTextBoxColumn"
        Me.QtyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'bs_c_pembelian
        '
        Me.bs_c_pembelian.DataMember = "cache_pembelian"
        Me.bs_c_pembelian.DataSource = Me.Db_laundryDataSet
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 469)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(813, 22)
        Me.StatusStrip1.TabIndex = 32
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Label6)
        Me.Panel1.Controls.Add(Label7)
        Me.Panel1.Controls.Add(Label8)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(813, 108)
        Me.Panel1.TabIndex = 30
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmd_keluar)
        Me.GroupBox2.Controls.Add(Me.cmd_simpan)
        Me.GroupBox2.Controls.Add(Me.dtp_tgl_beli)
        Me.GroupBox2.Controls.Add(Label5)
        Me.GroupBox2.Controls.Add(Me.cb_supplier)
        Me.GroupBox2.Controls.Add(Me.txt_jml_item)
        Me.GroupBox2.Controls.Add(Label2)
        Me.GroupBox2.Controls.Add(Label4)
        Me.GroupBox2.Controls.Add(Me.txt_tot_biaya)
        Me.GroupBox2.Controls.Add(Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(542, 286)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(264, 178)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        '
        'bs_barang
        '
        Me.bs_barang.DataMember = "tb_barang"
        Me.bs_barang.DataSource = Me.Db_laundryDataSet
        '
        'ta_barang
        '
        Me.ta_barang.ClearBeforeFill = True
        '
        'bs_pembelian_barang
        '
        Me.bs_pembelian_barang.DataMember = "tb_pembelian_barang"
        Me.bs_pembelian_barang.DataSource = Me.Db_laundryDataSet
        '
        'ta_pembelian_barang
        '
        Me.ta_pembelian_barang.ClearBeforeFill = True
        '
        'bs_detail_pembelian_barang
        '
        Me.bs_detail_pembelian_barang.DataMember = "tb_detail_pembelian_barang"
        Me.bs_detail_pembelian_barang.DataSource = Me.Db_laundryDataSet
        '
        'ta_detail_pembelian_barang
        '
        Me.ta_detail_pembelian_barang.ClearBeforeFill = True
        '
        'ta_supplier
        '
        Me.ta_supplier.ClearBeforeFill = True
        '
        'f_pembelian_barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(813, 491)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "f_pembelian_barang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Pembelian Barang"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.bs_supplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_laundryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgv_barang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_c_pembelian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.bs_barang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_pembelian_barang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_detail_pembelian_barang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_hapus As System.Windows.Forms.Button
    Friend WithEvents cmd_reset As System.Windows.Forms.Button
    Friend WithEvents cmd_ok As System.Windows.Forms.Button
    Friend WithEvents cb_satuan As System.Windows.Forms.ComboBox
    Friend WithEvents txt_jumlah As System.Windows.Forms.TextBox
    Friend WithEvents txt_kd_barang As System.Windows.Forms.TextBox
    Friend WithEvents txt_barang As System.Windows.Forms.TextBox
    Friend WithEvents txt_h_beli As System.Windows.Forms.TextBox
    Friend WithEvents txt_qty As System.Windows.Forms.TextBox
    Friend WithEvents cmd_keluar As System.Windows.Forms.Button
    Friend WithEvents cmd_simpan As System.Windows.Forms.Button
    Friend WithEvents dtp_tgl_beli As System.Windows.Forms.DateTimePicker
    Friend WithEvents cb_supplier As System.Windows.Forms.ComboBox
    Friend WithEvents txt_jml_item As System.Windows.Forms.TextBox
    Friend WithEvents txt_tot_biaya As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_barang As System.Windows.Forms.DataGridView
    Friend WithEvents bs_c_pembelian As System.Windows.Forms.BindingSource
    Friend WithEvents Db_laundryDataSet As JASA_LAUNDRY.db_laundryDataSet
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents bs_barang As System.Windows.Forms.BindingSource
    Friend WithEvents ta_barang As JASA_LAUNDRY.db_laundryDataSetTableAdapters.tb_barangTableAdapter
    Friend WithEvents bs_pembelian_barang As System.Windows.Forms.BindingSource
    Friend WithEvents ta_pembelian_barang As JASA_LAUNDRY.db_laundryDataSetTableAdapters.tb_pembelian_barangTableAdapter
    Friend WithEvents bs_detail_pembelian_barang As System.Windows.Forms.BindingSource
    Friend WithEvents ta_detail_pembelian_barang As JASA_LAUNDRY.db_laundryDataSetTableAdapters.tb_detail_pembelian_barangTableAdapter
    Friend WithEvents bs_supplier As System.Windows.Forms.BindingSource
    Friend WithEvents ta_supplier As JASA_LAUNDRY.db_laundryDataSetTableAdapters.tb_supplierTableAdapter
    Friend WithEvents KdbarangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BarangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SatuanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HbeliDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
