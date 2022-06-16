<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_data_karyawan
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
        Dim Kd_karyawanLabel As System.Windows.Forms.Label
        Dim KaryawanLabel As System.Windows.Forms.Label
        Dim AlamatLabel As System.Windows.Forms.Label
        Dim JkLabel As System.Windows.Forms.Label
        Dim CpLabel As System.Windows.Forms.Label
        Dim JabatanLabel As System.Windows.Forms.Label
        Dim User_nameLabel As System.Windows.Forms.Label
        Dim SandiLabel As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmd_keluar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rb_pr = New System.Windows.Forms.RadioButton()
        Me.rb_lk = New System.Windows.Forms.RadioButton()
        Me.dgv_kry = New System.Windows.Forms.DataGridView()
        Me.KdkaryawanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KaryawanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlamatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JabatanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SandiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bs_karyawan = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_laundryDataSet = New JASA_LAUNDRY.db_laundryDataSet()
        Me.cmd_perbarui = New System.Windows.Forms.Button()
        Me.cmd_simpan = New System.Windows.Forms.Button()
        Me.cmd_tambah = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmd_hapus = New System.Windows.Forms.Button()
        Me.jabatan = New System.Windows.Forms.ComboBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.kd_karyawan = New System.Windows.Forms.TextBox()
        Me.karyawan = New System.Windows.Forms.TextBox()
        Me.cp = New System.Windows.Forms.TextBox()
        Me.alamat = New System.Windows.Forms.TextBox()
        Me.user_name = New System.Windows.Forms.TextBox()
        Me.sandi = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmd_reset = New System.Windows.Forms.Button()
        Me.cmd_cari = New System.Windows.Forms.Button()
        Me.txt_cari = New System.Windows.Forms.TextBox()
        Me.ta_karyawan = New JASA_LAUNDRY.db_laundryDataSetTableAdapters.tb_karyawanTableAdapter()
        Kd_karyawanLabel = New System.Windows.Forms.Label()
        KaryawanLabel = New System.Windows.Forms.Label()
        AlamatLabel = New System.Windows.Forms.Label()
        JkLabel = New System.Windows.Forms.Label()
        CpLabel = New System.Windows.Forms.Label()
        JabatanLabel = New System.Windows.Forms.Label()
        User_nameLabel = New System.Windows.Forms.Label()
        SandiLabel = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_kry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_karyawan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_laundryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Kd_karyawanLabel
        '
        Kd_karyawanLabel.AutoSize = True
        Kd_karyawanLabel.Location = New System.Drawing.Point(28, 33)
        Kd_karyawanLabel.Name = "Kd_karyawanLabel"
        Kd_karyawanLabel.Size = New System.Drawing.Size(88, 13)
        Kd_karyawanLabel.TabIndex = 27
        Kd_karyawanLabel.Text = "Kode Karyawan :"
        '
        'KaryawanLabel
        '
        KaryawanLabel.AutoSize = True
        KaryawanLabel.Location = New System.Drawing.Point(25, 61)
        KaryawanLabel.Name = "KaryawanLabel"
        KaryawanLabel.Size = New System.Drawing.Size(91, 13)
        KaryawanLabel.TabIndex = 29
        KaryawanLabel.Text = "Nama Karyawan :"
        '
        'AlamatLabel
        '
        AlamatLabel.AutoSize = True
        AlamatLabel.Location = New System.Drawing.Point(39, 94)
        AlamatLabel.Name = "AlamatLabel"
        AlamatLabel.Size = New System.Drawing.Size(77, 13)
        AlamatLabel.TabIndex = 31
        AlamatLabel.Text = "Jenis Kelamin :"
        '
        'JkLabel
        '
        JkLabel.AutoSize = True
        JkLabel.Location = New System.Drawing.Point(30, 128)
        JkLabel.Name = "JkLabel"
        JkLabel.Size = New System.Drawing.Size(86, 13)
        JkLabel.TabIndex = 33
        JkLabel.Text = "Contact Person :"
        '
        'CpLabel
        '
        CpLabel.AutoSize = True
        CpLabel.Location = New System.Drawing.Point(65, 156)
        CpLabel.Name = "CpLabel"
        CpLabel.Size = New System.Drawing.Size(51, 13)
        CpLabel.TabIndex = 35
        CpLabel.Text = "Jabatan :"
        '
        'JabatanLabel
        '
        JabatanLabel.AutoSize = True
        JabatanLabel.Location = New System.Drawing.Point(71, 184)
        JabatanLabel.Name = "JabatanLabel"
        JabatanLabel.Size = New System.Drawing.Size(45, 13)
        JabatanLabel.TabIndex = 37
        JabatanLabel.Text = "Alamat :"
        '
        'User_nameLabel
        '
        User_nameLabel.AutoSize = True
        User_nameLabel.Location = New System.Drawing.Point(50, 247)
        User_nameLabel.Name = "User_nameLabel"
        User_nameLabel.Size = New System.Drawing.Size(66, 13)
        User_nameLabel.TabIndex = 39
        User_nameLabel.Text = "User Name :"
        '
        'SandiLabel
        '
        SandiLabel.AutoSize = True
        SandiLabel.Location = New System.Drawing.Point(76, 275)
        SandiLabel.Name = "SandiLabel"
        SandiLabel.Size = New System.Drawing.Size(40, 13)
        SandiLabel.TabIndex = 41
        SandiLabel.Text = "Sandi :"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.ForeColor = System.Drawing.Color.White
        Label5.Location = New System.Drawing.Point(540, 35)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(160, 24)
        Label5.TabIndex = 27
        Label5.Text = "Data Karyawan"
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
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.White
        Label1.Location = New System.Drawing.Point(51, 26)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(51, 13)
        Label1.TabIndex = 23
        Label1.Text = "Cari Data"
        '
        'cmd_keluar
        '
        Me.cmd_keluar.BackColor = System.Drawing.Color.Orange
        Me.cmd_keluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_keluar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_keluar.ForeColor = System.Drawing.Color.White
        Me.cmd_keluar.Location = New System.Drawing.Point(310, 10)
        Me.cmd_keluar.Name = "cmd_keluar"
        Me.cmd_keluar.Size = New System.Drawing.Size(72, 36)
        Me.cmd_keluar.TabIndex = 29
        Me.cmd_keluar.Text = "&Keluar"
        Me.cmd_keluar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rb_pr)
        Me.GroupBox2.Controls.Add(Me.rb_lk)
        Me.GroupBox2.Location = New System.Drawing.Point(119, 81)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(182, 37)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        '
        'rb_pr
        '
        Me.rb_pr.AutoSize = True
        Me.rb_pr.Location = New System.Drawing.Point(90, 12)
        Me.rb_pr.Name = "rb_pr"
        Me.rb_pr.Size = New System.Drawing.Size(79, 17)
        Me.rb_pr.TabIndex = 1
        Me.rb_pr.Text = "Perempuan"
        Me.rb_pr.UseVisualStyleBackColor = True
        '
        'rb_lk
        '
        Me.rb_lk.AutoSize = True
        Me.rb_lk.Checked = True
        Me.rb_lk.Location = New System.Drawing.Point(14, 12)
        Me.rb_lk.Name = "rb_lk"
        Me.rb_lk.Size = New System.Drawing.Size(68, 17)
        Me.rb_lk.TabIndex = 0
        Me.rb_lk.TabStop = True
        Me.rb_lk.Text = "Laki-Laki"
        Me.rb_lk.UseVisualStyleBackColor = True
        '
        'dgv_kry
        '
        Me.dgv_kry.AllowUserToAddRows = False
        Me.dgv_kry.AllowUserToDeleteRows = False
        Me.dgv_kry.AllowUserToOrderColumns = True
        Me.dgv_kry.AutoGenerateColumns = False
        Me.dgv_kry.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_kry.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_kry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_kry.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KdkaryawanDataGridViewTextBoxColumn, Me.KaryawanDataGridViewTextBoxColumn, Me.AlamatDataGridViewTextBoxColumn, Me.JkDataGridViewTextBoxColumn, Me.CpDataGridViewTextBoxColumn, Me.JabatanDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.SandiDataGridViewTextBoxColumn})
        Me.dgv_kry.DataSource = Me.bs_karyawan
        Me.dgv_kry.EnableHeadersVisualStyles = False
        Me.dgv_kry.GridColor = System.Drawing.Color.Gold
        Me.dgv_kry.Location = New System.Drawing.Point(14, 71)
        Me.dgv_kry.Name = "dgv_kry"
        Me.dgv_kry.ReadOnly = True
        Me.dgv_kry.Size = New System.Drawing.Size(368, 232)
        Me.dgv_kry.TabIndex = 0
        '
        'KdkaryawanDataGridViewTextBoxColumn
        '
        Me.KdkaryawanDataGridViewTextBoxColumn.DataPropertyName = "kd_karyawan"
        Me.KdkaryawanDataGridViewTextBoxColumn.HeaderText = "KODE KARYAWAN"
        Me.KdkaryawanDataGridViewTextBoxColumn.Name = "KdkaryawanDataGridViewTextBoxColumn"
        Me.KdkaryawanDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KaryawanDataGridViewTextBoxColumn
        '
        Me.KaryawanDataGridViewTextBoxColumn.DataPropertyName = "karyawan"
        Me.KaryawanDataGridViewTextBoxColumn.HeaderText = "NAMA KARYAWAN"
        Me.KaryawanDataGridViewTextBoxColumn.Name = "KaryawanDataGridViewTextBoxColumn"
        Me.KaryawanDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AlamatDataGridViewTextBoxColumn
        '
        Me.AlamatDataGridViewTextBoxColumn.DataPropertyName = "alamat"
        Me.AlamatDataGridViewTextBoxColumn.HeaderText = "ALAMAT"
        Me.AlamatDataGridViewTextBoxColumn.Name = "AlamatDataGridViewTextBoxColumn"
        Me.AlamatDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JkDataGridViewTextBoxColumn
        '
        Me.JkDataGridViewTextBoxColumn.DataPropertyName = "jk"
        Me.JkDataGridViewTextBoxColumn.HeaderText = "JENIS KELAMIN"
        Me.JkDataGridViewTextBoxColumn.Name = "JkDataGridViewTextBoxColumn"
        Me.JkDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CpDataGridViewTextBoxColumn
        '
        Me.CpDataGridViewTextBoxColumn.DataPropertyName = "cp"
        Me.CpDataGridViewTextBoxColumn.HeaderText = "CONTACT PERSON"
        Me.CpDataGridViewTextBoxColumn.Name = "CpDataGridViewTextBoxColumn"
        Me.CpDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JabatanDataGridViewTextBoxColumn
        '
        Me.JabatanDataGridViewTextBoxColumn.DataPropertyName = "jabatan"
        Me.JabatanDataGridViewTextBoxColumn.HeaderText = "JABATAN"
        Me.JabatanDataGridViewTextBoxColumn.Name = "JabatanDataGridViewTextBoxColumn"
        Me.JabatanDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "user_name"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "USER NAME"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SandiDataGridViewTextBoxColumn
        '
        Me.SandiDataGridViewTextBoxColumn.DataPropertyName = "sandi"
        Me.SandiDataGridViewTextBoxColumn.HeaderText = "SANDI"
        Me.SandiDataGridViewTextBoxColumn.Name = "SandiDataGridViewTextBoxColumn"
        Me.SandiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'bs_karyawan
        '
        Me.bs_karyawan.DataMember = "tb_karyawan"
        Me.bs_karyawan.DataSource = Me.Db_laundryDataSet
        '
        'Db_laundryDataSet
        '
        Me.Db_laundryDataSet.DataSetName = "db_laundryDataSet"
        Me.Db_laundryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmd_perbarui
        '
        Me.cmd_perbarui.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_perbarui.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_perbarui.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_perbarui.ForeColor = System.Drawing.Color.White
        Me.cmd_perbarui.Location = New System.Drawing.Point(252, 10)
        Me.cmd_perbarui.Name = "cmd_perbarui"
        Me.cmd_perbarui.Size = New System.Drawing.Size(72, 36)
        Me.cmd_perbarui.TabIndex = 28
        Me.cmd_perbarui.Text = "&Perbarui"
        Me.cmd_perbarui.UseVisualStyleBackColor = False
        '
        'cmd_simpan
        '
        Me.cmd_simpan.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_simpan.Enabled = False
        Me.cmd_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_simpan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_simpan.ForeColor = System.Drawing.Color.White
        Me.cmd_simpan.Location = New System.Drawing.Point(174, 10)
        Me.cmd_simpan.Name = "cmd_simpan"
        Me.cmd_simpan.Size = New System.Drawing.Size(72, 36)
        Me.cmd_simpan.TabIndex = 27
        Me.cmd_simpan.Text = "&Simpan"
        Me.cmd_simpan.UseVisualStyleBackColor = False
        '
        'cmd_tambah
        '
        Me.cmd_tambah.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_tambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_tambah.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_tambah.ForeColor = System.Drawing.Color.White
        Me.cmd_tambah.Location = New System.Drawing.Point(96, 10)
        Me.cmd_tambah.Name = "cmd_tambah"
        Me.cmd_tambah.Size = New System.Drawing.Size(72, 36)
        Me.cmd_tambah.TabIndex = 26
        Me.cmd_tambah.Text = "&Tambah"
        Me.cmd_tambah.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.cmd_hapus)
        Me.Panel2.Controls.Add(Me.cmd_keluar)
        Me.Panel2.Location = New System.Drawing.Point(366, 438)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(402, 55)
        Me.Panel2.TabIndex = 51
        '
        'cmd_hapus
        '
        Me.cmd_hapus.BackColor = System.Drawing.Color.Orange
        Me.cmd_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_hapus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_hapus.ForeColor = System.Drawing.Color.White
        Me.cmd_hapus.Location = New System.Drawing.Point(232, 10)
        Me.cmd_hapus.Name = "cmd_hapus"
        Me.cmd_hapus.Size = New System.Drawing.Size(72, 36)
        Me.cmd_hapus.TabIndex = 30
        Me.cmd_hapus.Text = "&Hapus"
        Me.cmd_hapus.UseVisualStyleBackColor = False
        '
        'jabatan
        '
        Me.jabatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.jabatan.FormattingEnabled = True
        Me.jabatan.Items.AddRange(New Object() {"OPERATOR", "PETUGAS CUCI"})
        Me.jabatan.Location = New System.Drawing.Point(119, 153)
        Me.jabatan.Name = "jabatan"
        Me.jabatan.Size = New System.Drawing.Size(182, 21)
        Me.jabatan.TabIndex = 43
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 502)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(780, 22)
        Me.StatusStrip1.TabIndex = 52
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.cmd_perbarui)
        Me.Panel1.Controls.Add(Me.cmd_simpan)
        Me.Panel1.Controls.Add(Me.cmd_tambah)
        Me.Panel1.Location = New System.Drawing.Point(9, 438)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(351, 55)
        Me.Panel1.TabIndex = 50
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.jabatan)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Kd_karyawanLabel)
        Me.GroupBox1.Controls.Add(Me.kd_karyawan)
        Me.GroupBox1.Controls.Add(KaryawanLabel)
        Me.GroupBox1.Controls.Add(Me.karyawan)
        Me.GroupBox1.Controls.Add(AlamatLabel)
        Me.GroupBox1.Controls.Add(JkLabel)
        Me.GroupBox1.Controls.Add(Me.cp)
        Me.GroupBox1.Controls.Add(CpLabel)
        Me.GroupBox1.Controls.Add(JabatanLabel)
        Me.GroupBox1.Controls.Add(Me.alamat)
        Me.GroupBox1.Controls.Add(User_nameLabel)
        Me.GroupBox1.Controls.Add(Me.user_name)
        Me.GroupBox1.Controls.Add(SandiLabel)
        Me.GroupBox1.Controls.Add(Me.sandi)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 106)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(352, 326)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Karyawan"
        '
        'kd_karyawan
        '
        Me.kd_karyawan.Enabled = False
        Me.kd_karyawan.Location = New System.Drawing.Point(119, 30)
        Me.kd_karyawan.Name = "kd_karyawan"
        Me.kd_karyawan.Size = New System.Drawing.Size(182, 20)
        Me.kd_karyawan.TabIndex = 0
        '
        'karyawan
        '
        Me.karyawan.Location = New System.Drawing.Point(119, 58)
        Me.karyawan.Name = "karyawan"
        Me.karyawan.Size = New System.Drawing.Size(182, 20)
        Me.karyawan.TabIndex = 1
        '
        'cp
        '
        Me.cp.Location = New System.Drawing.Point(119, 125)
        Me.cp.Name = "cp"
        Me.cp.Size = New System.Drawing.Size(182, 20)
        Me.cp.TabIndex = 3
        '
        'alamat
        '
        Me.alamat.Location = New System.Drawing.Point(119, 181)
        Me.alamat.Multiline = True
        Me.alamat.Name = "alamat"
        Me.alamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.alamat.Size = New System.Drawing.Size(182, 56)
        Me.alamat.TabIndex = 5
        '
        'user_name
        '
        Me.user_name.Location = New System.Drawing.Point(119, 244)
        Me.user_name.Name = "user_name"
        Me.user_name.Size = New System.Drawing.Size(182, 20)
        Me.user_name.TabIndex = 6
        '
        'sandi
        '
        Me.sandi.Location = New System.Drawing.Point(119, 272)
        Me.sandi.Name = "sandi"
        Me.sandi.Size = New System.Drawing.Size(182, 20)
        Me.sandi.TabIndex = 7
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
        Me.Panel3.Size = New System.Drawing.Size(780, 100)
        Me.Panel3.TabIndex = 47
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Gold
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 87)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(780, 13)
        Me.Panel4.TabIndex = 24
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmd_reset)
        Me.GroupBox3.Controls.Add(Me.cmd_cari)
        Me.GroupBox3.Controls.Add(Label1)
        Me.GroupBox3.Controls.Add(Me.txt_cari)
        Me.GroupBox3.Controls.Add(Me.dgv_kry)
        Me.GroupBox3.Location = New System.Drawing.Point(366, 106)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(402, 325)
        Me.GroupBox3.TabIndex = 49
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Data Karyawan"
        '
        'cmd_reset
        '
        Me.cmd_reset.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_reset.ForeColor = System.Drawing.Color.White
        Me.cmd_reset.Location = New System.Drawing.Point(306, 40)
        Me.cmd_reset.Name = "cmd_reset"
        Me.cmd_reset.Size = New System.Drawing.Size(75, 25)
        Me.cmd_reset.TabIndex = 25
        Me.cmd_reset.Text = "&Reset"
        Me.cmd_reset.UseVisualStyleBackColor = False
        '
        'cmd_cari
        '
        Me.cmd_cari.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_cari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_cari.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_cari.ForeColor = System.Drawing.Color.White
        Me.cmd_cari.Location = New System.Drawing.Point(225, 40)
        Me.cmd_cari.Name = "cmd_cari"
        Me.cmd_cari.Size = New System.Drawing.Size(75, 25)
        Me.cmd_cari.TabIndex = 22
        Me.cmd_cari.Text = "&Cari"
        Me.cmd_cari.UseVisualStyleBackColor = False
        '
        'txt_cari
        '
        Me.txt_cari.Location = New System.Drawing.Point(54, 43)
        Me.txt_cari.Name = "txt_cari"
        Me.txt_cari.Size = New System.Drawing.Size(165, 20)
        Me.txt_cari.TabIndex = 24
        '
        'ta_karyawan
        '
        Me.ta_karyawan.ClearBeforeFill = True
        '
        'f_data_karyawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(780, 524)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "f_data_karyawan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Karyawan"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv_kry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_karyawan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_laundryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_keluar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_pr As System.Windows.Forms.RadioButton
    Friend WithEvents rb_lk As System.Windows.Forms.RadioButton
    Friend WithEvents dgv_kry As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_perbarui As System.Windows.Forms.Button
    Friend WithEvents cmd_simpan As System.Windows.Forms.Button
    Friend WithEvents cmd_tambah As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmd_hapus As System.Windows.Forms.Button
    Friend WithEvents jabatan As System.Windows.Forms.ComboBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents kd_karyawan As System.Windows.Forms.TextBox
    Friend WithEvents karyawan As System.Windows.Forms.TextBox
    Friend WithEvents cp As System.Windows.Forms.TextBox
    Friend WithEvents alamat As System.Windows.Forms.TextBox
    Friend WithEvents user_name As System.Windows.Forms.TextBox
    Friend WithEvents sandi As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Db_laundryDataSet As JASA_LAUNDRY.db_laundryDataSet
    Friend WithEvents bs_karyawan As System.Windows.Forms.BindingSource
    Friend WithEvents ta_karyawan As JASA_LAUNDRY.db_laundryDataSetTableAdapters.tb_karyawanTableAdapter
    Friend WithEvents KdkaryawanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KaryawanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlamatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JkDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CpDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JabatanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SandiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmd_reset As System.Windows.Forms.Button
    Friend WithEvents cmd_cari As System.Windows.Forms.Button
    Friend WithEvents txt_cari As System.Windows.Forms.TextBox

End Class
