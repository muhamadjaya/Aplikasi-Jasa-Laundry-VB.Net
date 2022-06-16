<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_data_jenis_laundry
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
        Dim SupplierLabel As System.Windows.Forms.Label
        Dim CpLabel As System.Windows.Forms.Label
        Dim Kd_supplierLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.dgv_sup = New System.Windows.Forms.DataGridView()
        Me.KdjenislaundryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JenislaundryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TarifDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bs_jenis_laundry = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_laundryDataSet = New JASA_LAUNDRY.db_laundryDataSet()
        Me.cmd_keluar = New System.Windows.Forms.Button()
        Me.txt_kd_jenis = New System.Windows.Forms.TextBox()
        Me.jenis = New System.Windows.Forms.TextBox()
        Me.tarif = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmd_perbarui = New System.Windows.Forms.Button()
        Me.cmd_simpan = New System.Windows.Forms.Button()
        Me.cmd_tambah = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cmd_hapus = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ta_jenis_laundry = New JASA_LAUNDRY.db_laundryDataSetTableAdapters.tb_jenis_laundryTableAdapter()
        Label5 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        SupplierLabel = New System.Windows.Forms.Label()
        CpLabel = New System.Windows.Forms.Label()
        Kd_supplierLabel = New System.Windows.Forms.Label()
        CType(Me.dgv_sup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_jenis_laundry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_laundryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.ForeColor = System.Drawing.Color.White
        Label5.Location = New System.Drawing.Point(540, 35)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(145, 24)
        Label5.TabIndex = 27
        Label5.Text = "Data Supplier"
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
        'SupplierLabel
        '
        SupplierLabel.AutoSize = True
        SupplierLabel.Location = New System.Drawing.Point(39, 78)
        SupplierLabel.Name = "SupplierLabel"
        SupplierLabel.Size = New System.Drawing.Size(78, 13)
        SupplierLabel.TabIndex = 3
        SupplierLabel.Text = "Jenis Laundry :"
        '
        'CpLabel
        '
        CpLabel.AutoSize = True
        CpLabel.Location = New System.Drawing.Point(83, 111)
        CpLabel.Name = "CpLabel"
        CpLabel.Size = New System.Drawing.Size(34, 13)
        CpLabel.TabIndex = 7
        CpLabel.Text = "Tarif :"
        '
        'Kd_supplierLabel
        '
        Kd_supplierLabel.AutoSize = True
        Kd_supplierLabel.Location = New System.Drawing.Point(11, 45)
        Kd_supplierLabel.Name = "Kd_supplierLabel"
        Kd_supplierLabel.Size = New System.Drawing.Size(106, 13)
        Kd_supplierLabel.TabIndex = 1
        Kd_supplierLabel.Text = "Kode Jenis Laundry :"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 357)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(714, 22)
        Me.StatusStrip1.TabIndex = 64
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'dgv_sup
        '
        Me.dgv_sup.AllowUserToAddRows = False
        Me.dgv_sup.AllowUserToDeleteRows = False
        Me.dgv_sup.AllowUserToOrderColumns = True
        Me.dgv_sup.AutoGenerateColumns = False
        Me.dgv_sup.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_sup.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_sup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_sup.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KdjenislaundryDataGridViewTextBoxColumn, Me.JenislaundryDataGridViewTextBoxColumn, Me.TarifDataGridViewTextBoxColumn})
        Me.dgv_sup.DataSource = Me.bs_jenis_laundry
        Me.dgv_sup.EnableHeadersVisualStyles = False
        Me.dgv_sup.GridColor = System.Drawing.Color.Gold
        Me.dgv_sup.Location = New System.Drawing.Point(10, 21)
        Me.dgv_sup.Name = "dgv_sup"
        Me.dgv_sup.ReadOnly = True
        Me.dgv_sup.Size = New System.Drawing.Size(345, 140)
        Me.dgv_sup.TabIndex = 1
        '
        'KdjenislaundryDataGridViewTextBoxColumn
        '
        Me.KdjenislaundryDataGridViewTextBoxColumn.DataPropertyName = "kd_jenis_laundry"
        Me.KdjenislaundryDataGridViewTextBoxColumn.HeaderText = "KODE JENIS LAUNDRY"
        Me.KdjenislaundryDataGridViewTextBoxColumn.Name = "KdjenislaundryDataGridViewTextBoxColumn"
        Me.KdjenislaundryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JenislaundryDataGridViewTextBoxColumn
        '
        Me.JenislaundryDataGridViewTextBoxColumn.DataPropertyName = "jenis_laundry"
        Me.JenislaundryDataGridViewTextBoxColumn.HeaderText = "JENIS LAUNDRY"
        Me.JenislaundryDataGridViewTextBoxColumn.Name = "JenislaundryDataGridViewTextBoxColumn"
        Me.JenislaundryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TarifDataGridViewTextBoxColumn
        '
        Me.TarifDataGridViewTextBoxColumn.DataPropertyName = "tarif"
        Me.TarifDataGridViewTextBoxColumn.HeaderText = "TARIF"
        Me.TarifDataGridViewTextBoxColumn.Name = "TarifDataGridViewTextBoxColumn"
        Me.TarifDataGridViewTextBoxColumn.ReadOnly = True
        '
        'bs_jenis_laundry
        '
        Me.bs_jenis_laundry.DataMember = "tb_jenis_laundry"
        Me.bs_jenis_laundry.DataSource = Me.Db_laundryDataSet
        '
        'Db_laundryDataSet
        '
        Me.Db_laundryDataSet.DataSetName = "db_laundryDataSet"
        Me.Db_laundryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmd_keluar
        '
        Me.cmd_keluar.BackColor = System.Drawing.Color.Orange
        Me.cmd_keluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_keluar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_keluar.ForeColor = System.Drawing.Color.White
        Me.cmd_keluar.Location = New System.Drawing.Point(282, 9)
        Me.cmd_keluar.Name = "cmd_keluar"
        Me.cmd_keluar.Size = New System.Drawing.Size(72, 36)
        Me.cmd_keluar.TabIndex = 29
        Me.cmd_keluar.Text = "&Keluar"
        Me.cmd_keluar.UseVisualStyleBackColor = False
        '
        'txt_kd_jenis
        '
        Me.txt_kd_jenis.Enabled = False
        Me.txt_kd_jenis.Location = New System.Drawing.Point(120, 42)
        Me.txt_kd_jenis.Name = "txt_kd_jenis"
        Me.txt_kd_jenis.Size = New System.Drawing.Size(170, 20)
        Me.txt_kd_jenis.TabIndex = 2
        '
        'jenis
        '
        Me.jenis.Location = New System.Drawing.Point(120, 75)
        Me.jenis.Name = "jenis"
        Me.jenis.Size = New System.Drawing.Size(170, 20)
        Me.jenis.TabIndex = 4
        '
        'tarif
        '
        Me.tarif.Location = New System.Drawing.Point(120, 108)
        Me.tarif.Name = "tarif"
        Me.tarif.Size = New System.Drawing.Size(170, 20)
        Me.tarif.TabIndex = 8
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Gold
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 87)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(714, 13)
        Me.Panel4.TabIndex = 24
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.cmd_perbarui)
        Me.Panel1.Controls.Add(Me.cmd_simpan)
        Me.Panel1.Controls.Add(Me.cmd_tambah)
        Me.Panel1.Location = New System.Drawing.Point(8, 290)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(328, 55)
        Me.Panel1.TabIndex = 60
        '
        'cmd_perbarui
        '
        Me.cmd_perbarui.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_perbarui.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_perbarui.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_perbarui.ForeColor = System.Drawing.Color.White
        Me.cmd_perbarui.Location = New System.Drawing.Point(229, 9)
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
        Me.cmd_simpan.Location = New System.Drawing.Point(151, 9)
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
        Me.cmd_tambah.Location = New System.Drawing.Point(73, 9)
        Me.cmd_tambah.Name = "cmd_tambah"
        Me.cmd_tambah.Size = New System.Drawing.Size(72, 36)
        Me.cmd_tambah.TabIndex = 26
        Me.cmd_tambah.Text = "&Tambah"
        Me.cmd_tambah.UseVisualStyleBackColor = False
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
        Me.Panel3.Size = New System.Drawing.Size(714, 100)
        Me.Panel3.TabIndex = 59
        '
        'cmd_hapus
        '
        Me.cmd_hapus.BackColor = System.Drawing.Color.Orange
        Me.cmd_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_hapus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_hapus.ForeColor = System.Drawing.Color.White
        Me.cmd_hapus.Location = New System.Drawing.Point(204, 9)
        Me.cmd_hapus.Name = "cmd_hapus"
        Me.cmd_hapus.Size = New System.Drawing.Size(72, 36)
        Me.cmd_hapus.TabIndex = 30
        Me.cmd_hapus.Text = "&Hapus"
        Me.cmd_hapus.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.cmd_hapus)
        Me.Panel2.Controls.Add(Me.cmd_keluar)
        Me.Panel2.Location = New System.Drawing.Point(342, 290)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(365, 55)
        Me.Panel2.TabIndex = 61
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgv_sup)
        Me.GroupBox2.Location = New System.Drawing.Point(341, 105)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(366, 179)
        Me.GroupBox2.TabIndex = 63
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Jenis Laundry"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Kd_supplierLabel)
        Me.GroupBox1.Controls.Add(Me.txt_kd_jenis)
        Me.GroupBox1.Controls.Add(SupplierLabel)
        Me.GroupBox1.Controls.Add(Me.jenis)
        Me.GroupBox1.Controls.Add(CpLabel)
        Me.GroupBox1.Controls.Add(Me.tarif)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 180)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Jenis Laundry"
        '
        'ta_jenis_laundry
        '
        Me.ta_jenis_laundry.ClearBeforeFill = True
        '
        'f_data_jenis_laundry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(714, 379)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "f_data_jenis_laundry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Jenis Laundry"
        CType(Me.dgv_sup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_jenis_laundry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_laundryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents dgv_sup As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_keluar As System.Windows.Forms.Button
    Friend WithEvents txt_kd_jenis As System.Windows.Forms.TextBox
    Friend WithEvents jenis As System.Windows.Forms.TextBox
    Friend WithEvents tarif As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmd_perbarui As System.Windows.Forms.Button
    Friend WithEvents cmd_simpan As System.Windows.Forms.Button
    Friend WithEvents cmd_tambah As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cmd_hapus As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Db_laundryDataSet As JASA_LAUNDRY.db_laundryDataSet
    Friend WithEvents bs_jenis_laundry As System.Windows.Forms.BindingSource
    Friend WithEvents ta_jenis_laundry As JASA_LAUNDRY.db_laundryDataSetTableAdapters.tb_jenis_laundryTableAdapter
    Friend WithEvents KdjenislaundryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JenislaundryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TarifDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
