<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_pemakaian_barang
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
        Dim Kd_barangLabel As System.Windows.Forms.Label
        Dim BarangLabel As System.Windows.Forms.Label
        Dim StokLabel As System.Windows.Forms.Label
        Dim SatuanLabel As System.Windows.Forms.Label
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cmd_ok = New System.Windows.Forms.Button()
        Me.cmd_resett = New System.Windows.Forms.Button()
        Me.cmd_keluar = New System.Windows.Forms.Button()
        Me.cmd_simpan = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.KdbarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SatuanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bs_c_pemakaian = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_laundryDataSet = New JASA_LAUNDRY.db_laundryDataSet()
        Me.txt_kd_barang = New System.Windows.Forms.TextBox()
        Me.txt_barang = New System.Windows.Forms.TextBox()
        Me.txt_satuan = New System.Windows.Forms.TextBox()
        Me.txt_jumlah = New System.Windows.Forms.TextBox()
        Me.bs_barang = New System.Windows.Forms.BindingSource(Me.components)
        Me.ta_barang = New JASA_LAUNDRY.db_laundryDataSetTableAdapters.tb_barangTableAdapter()
        Me.bs_pemakaian_barang = New System.Windows.Forms.BindingSource(Me.components)
        Me.ta_pemakaian_barang = New JASA_LAUNDRY.db_laundryDataSetTableAdapters.tb_pemakaian_barangTableAdapter()
        Me.bs_detail_pemakaian_barang = New System.Windows.Forms.BindingSource(Me.components)
        Me.ta_detail_pemakaian_barang = New JASA_LAUNDRY.db_laundryDataSetTableAdapters.tb_detail_pemakaian_barangTableAdapter()
        Label5 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Kd_barangLabel = New System.Windows.Forms.Label()
        BarangLabel = New System.Windows.Forms.Label()
        StokLabel = New System.Windows.Forms.Label()
        SatuanLabel = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_c_pemakaian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_laundryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_barang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_pemakaian_barang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_detail_pemakaian_barang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.ForeColor = System.Drawing.Color.White
        Label5.Location = New System.Drawing.Point(474, 37)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(200, 24)
        Label5.TabIndex = 27
        Label5.Text = "Pemakaian Barang"
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
        'Kd_barangLabel
        '
        Kd_barangLabel.AutoSize = True
        Kd_barangLabel.Location = New System.Drawing.Point(41, 51)
        Kd_barangLabel.Name = "Kd_barangLabel"
        Kd_barangLabel.Size = New System.Drawing.Size(75, 13)
        Kd_barangLabel.TabIndex = 1
        Kd_barangLabel.Text = "Kode Barang :"
        '
        'BarangLabel
        '
        BarangLabel.AutoSize = True
        BarangLabel.Location = New System.Drawing.Point(69, 80)
        BarangLabel.Name = "BarangLabel"
        BarangLabel.Size = New System.Drawing.Size(47, 13)
        BarangLabel.TabIndex = 3
        BarangLabel.Text = "Barang :"
        '
        'StokLabel
        '
        StokLabel.AutoSize = True
        StokLabel.Location = New System.Drawing.Point(69, 108)
        StokLabel.Name = "StokLabel"
        StokLabel.Size = New System.Drawing.Size(47, 13)
        StokLabel.TabIndex = 5
        StokLabel.Text = "Satuan :"
        '
        'SatuanLabel
        '
        SatuanLabel.AutoSize = True
        SatuanLabel.Location = New System.Drawing.Point(70, 137)
        SatuanLabel.Name = "SatuanLabel"
        SatuanLabel.Size = New System.Drawing.Size(46, 13)
        SatuanLabel.TabIndex = 7
        SatuanLabel.Text = "Jumlah :"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 392)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(683, 22)
        Me.StatusStrip1.TabIndex = 29
        Me.StatusStrip1.Text = "StatusStrip1"
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
        Me.Panel3.Size = New System.Drawing.Size(683, 108)
        Me.Panel3.TabIndex = 28
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Gold
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 95)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(683, 13)
        Me.Panel4.TabIndex = 24
        '
        'cmd_ok
        '
        Me.cmd_ok.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_ok.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_ok.ForeColor = System.Drawing.Color.White
        Me.cmd_ok.Location = New System.Drawing.Point(113, 11)
        Me.cmd_ok.Name = "cmd_ok"
        Me.cmd_ok.Size = New System.Drawing.Size(70, 34)
        Me.cmd_ok.TabIndex = 25
        Me.cmd_ok.Text = "&OK"
        Me.cmd_ok.UseVisualStyleBackColor = False
        '
        'cmd_resett
        '
        Me.cmd_resett.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_resett.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_resett.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_resett.ForeColor = System.Drawing.Color.White
        Me.cmd_resett.Location = New System.Drawing.Point(189, 11)
        Me.cmd_resett.Name = "cmd_resett"
        Me.cmd_resett.Size = New System.Drawing.Size(70, 34)
        Me.cmd_resett.TabIndex = 24
        Me.cmd_resett.Text = "&Reset"
        Me.cmd_resett.UseVisualStyleBackColor = False
        '
        'cmd_keluar
        '
        Me.cmd_keluar.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_keluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_keluar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_keluar.ForeColor = System.Drawing.Color.White
        Me.cmd_keluar.Location = New System.Drawing.Point(261, 11)
        Me.cmd_keluar.Name = "cmd_keluar"
        Me.cmd_keluar.Size = New System.Drawing.Size(70, 34)
        Me.cmd_keluar.TabIndex = 25
        Me.cmd_keluar.Text = "&Keluar"
        Me.cmd_keluar.UseVisualStyleBackColor = False
        '
        'cmd_simpan
        '
        Me.cmd_simpan.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_simpan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_simpan.ForeColor = System.Drawing.Color.White
        Me.cmd_simpan.Location = New System.Drawing.Point(185, 11)
        Me.cmd_simpan.Name = "cmd_simpan"
        Me.cmd_simpan.Size = New System.Drawing.Size(70, 34)
        Me.cmd_simpan.TabIndex = 23
        Me.cmd_simpan.Text = "&Simpan"
        Me.cmd_simpan.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Kd_barangLabel)
        Me.GroupBox1.Controls.Add(Me.txt_kd_barang)
        Me.GroupBox1.Controls.Add(BarangLabel)
        Me.GroupBox1.Controls.Add(Me.txt_barang)
        Me.GroupBox1.Controls.Add(StokLabel)
        Me.GroupBox1.Controls.Add(Me.txt_satuan)
        Me.GroupBox1.Controls.Add(SatuanLabel)
        Me.GroupBox1.Controls.Add(Me.txt_jumlah)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(664, 272)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.cmd_keluar)
        Me.Panel2.Controls.Add(Me.cmd_simpan)
        Me.Panel2.Location = New System.Drawing.Point(302, 198)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(343, 56)
        Me.Panel2.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.cmd_ok)
        Me.Panel1.Controls.Add(Me.cmd_resett)
        Me.Panel1.Location = New System.Drawing.Point(21, 198)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(270, 56)
        Me.Panel1.TabIndex = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(302, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(343, 165)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Daftar Pemakaian Barang"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KdbarangDataGridViewTextBoxColumn, Me.BarangDataGridViewTextBoxColumn, Me.SatuanDataGridViewTextBoxColumn, Me.JumlahDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.bs_c_pemakaian
        Me.DataGridView1.Location = New System.Drawing.Point(11, 17)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(320, 138)
        Me.DataGridView1.TabIndex = 0
        '
        'KdbarangDataGridViewTextBoxColumn
        '
        Me.KdbarangDataGridViewTextBoxColumn.DataPropertyName = "kd_barang"
        Me.KdbarangDataGridViewTextBoxColumn.HeaderText = "KODE BARANG"
        Me.KdbarangDataGridViewTextBoxColumn.Name = "KdbarangDataGridViewTextBoxColumn"
        Me.KdbarangDataGridViewTextBoxColumn.ReadOnly = True
        Me.KdbarangDataGridViewTextBoxColumn.Width = 120
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
        'JumlahDataGridViewTextBoxColumn
        '
        Me.JumlahDataGridViewTextBoxColumn.DataPropertyName = "jumlah"
        Me.JumlahDataGridViewTextBoxColumn.HeaderText = "JUMLAH"
        Me.JumlahDataGridViewTextBoxColumn.Name = "JumlahDataGridViewTextBoxColumn"
        Me.JumlahDataGridViewTextBoxColumn.ReadOnly = True
        '
        'bs_c_pemakaian
        '
        Me.bs_c_pemakaian.DataMember = "cache_pemakaian"
        Me.bs_c_pemakaian.DataSource = Me.Db_laundryDataSet
        '
        'Db_laundryDataSet
        '
        Me.Db_laundryDataSet.DataSetName = "db_laundryDataSet"
        Me.Db_laundryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txt_kd_barang
        '
        Me.txt_kd_barang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_kd_barang.Location = New System.Drawing.Point(119, 48)
        Me.txt_kd_barang.Name = "txt_kd_barang"
        Me.txt_kd_barang.Size = New System.Drawing.Size(161, 20)
        Me.txt_kd_barang.TabIndex = 2
        '
        'txt_barang
        '
        Me.txt_barang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_barang.Location = New System.Drawing.Point(119, 77)
        Me.txt_barang.Name = "txt_barang"
        Me.txt_barang.Size = New System.Drawing.Size(161, 20)
        Me.txt_barang.TabIndex = 4
        '
        'txt_satuan
        '
        Me.txt_satuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_satuan.Location = New System.Drawing.Point(119, 105)
        Me.txt_satuan.Name = "txt_satuan"
        Me.txt_satuan.Size = New System.Drawing.Size(161, 20)
        Me.txt_satuan.TabIndex = 6
        '
        'txt_jumlah
        '
        Me.txt_jumlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_jumlah.Location = New System.Drawing.Point(119, 134)
        Me.txt_jumlah.Name = "txt_jumlah"
        Me.txt_jumlah.Size = New System.Drawing.Size(161, 20)
        Me.txt_jumlah.TabIndex = 8
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
        'bs_pemakaian_barang
        '
        Me.bs_pemakaian_barang.DataMember = "tb_pemakaian_barang"
        Me.bs_pemakaian_barang.DataSource = Me.Db_laundryDataSet
        '
        'ta_pemakaian_barang
        '
        Me.ta_pemakaian_barang.ClearBeforeFill = True
        '
        'bs_detail_pemakaian_barang
        '
        Me.bs_detail_pemakaian_barang.DataMember = "tb_detail_pemakaian_barang"
        Me.bs_detail_pemakaian_barang.DataSource = Me.Db_laundryDataSet
        '
        'ta_detail_pemakaian_barang
        '
        Me.ta_detail_pemakaian_barang.ClearBeforeFill = True
        '
        'f_pemakaian_barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(683, 414)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "f_pemakaian_barang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Pemakaian Barang"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_c_pemakaian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_laundryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_barang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_pemakaian_barang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_detail_pemakaian_barang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents cmd_ok As System.Windows.Forms.Button
    Friend WithEvents cmd_resett As System.Windows.Forms.Button
    Friend WithEvents cmd_keluar As System.Windows.Forms.Button
    Friend WithEvents cmd_simpan As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents bs_c_pemakaian As System.Windows.Forms.BindingSource
    Friend WithEvents Db_laundryDataSet As JASA_LAUNDRY.db_laundryDataSet
    Friend WithEvents txt_kd_barang As System.Windows.Forms.TextBox
    Friend WithEvents txt_barang As System.Windows.Forms.TextBox
    Friend WithEvents txt_satuan As System.Windows.Forms.TextBox
    Friend WithEvents txt_jumlah As System.Windows.Forms.TextBox
    Friend WithEvents bs_barang As System.Windows.Forms.BindingSource
    Friend WithEvents ta_barang As JASA_LAUNDRY.db_laundryDataSetTableAdapters.tb_barangTableAdapter
    Friend WithEvents bs_pemakaian_barang As System.Windows.Forms.BindingSource
    Friend WithEvents ta_pemakaian_barang As JASA_LAUNDRY.db_laundryDataSetTableAdapters.tb_pemakaian_barangTableAdapter
    Friend WithEvents bs_detail_pemakaian_barang As System.Windows.Forms.BindingSource
    Friend WithEvents ta_detail_pemakaian_barang As JASA_LAUNDRY.db_laundryDataSetTableAdapters.tb_detail_pemakaian_barangTableAdapter
    Friend WithEvents KdbarangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BarangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SatuanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JumlahDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
