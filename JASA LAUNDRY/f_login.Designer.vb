<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_login
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmd_login = New System.Windows.Forms.Button()
        Me.txt_sandi = New System.Windows.Forms.TextBox()
        Me.txt_user_name = New System.Windows.Forms.TextBox()
        Me.sandi = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.Db_laundryDataSet = New JASA_LAUNDRY.db_laundryDataSet()
        Me.bs_karyawan = New System.Windows.Forms.BindingSource(Me.components)
        Me.ta_karyawan = New JASA_LAUNDRY.db_laundryDataSetTableAdapters.tb_karyawanTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.Db_laundryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_karyawan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(381, 61)
        Me.Panel1.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(122, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "USER LOGIN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmd_login
        '
        Me.cmd_login.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.cmd_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_login.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_login.ForeColor = System.Drawing.Color.White
        Me.cmd_login.Location = New System.Drawing.Point(72, 196)
        Me.cmd_login.Name = "cmd_login"
        Me.cmd_login.Size = New System.Drawing.Size(240, 41)
        Me.cmd_login.TabIndex = 10
        Me.cmd_login.Text = "Login"
        Me.cmd_login.UseVisualStyleBackColor = False
        '
        'txt_sandi
        '
        Me.txt_sandi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_sandi.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sandi.Location = New System.Drawing.Point(71, 165)
        Me.txt_sandi.Name = "txt_sandi"
        Me.txt_sandi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_sandi.Size = New System.Drawing.Size(241, 23)
        Me.txt_sandi.TabIndex = 9
        '
        'txt_user_name
        '
        Me.txt_user_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_user_name.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_user_name.Location = New System.Drawing.Point(71, 108)
        Me.txt_user_name.Name = "txt_user_name"
        Me.txt_user_name.Size = New System.Drawing.Size(241, 23)
        Me.txt_user_name.TabIndex = 7
        '
        'sandi
        '
        Me.sandi.AutoSize = True
        Me.sandi.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sandi.ForeColor = System.Drawing.Color.DodgerBlue
        Me.sandi.Location = New System.Drawing.Point(69, 145)
        Me.sandi.Name = "sandi"
        Me.sandi.Size = New System.Drawing.Size(42, 17)
        Me.sandi.TabIndex = 8
        Me.sandi.Text = "Sandi"
        Me.sandi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.ForeColor = System.Drawing.Color.DodgerBlue
        Me.UsernameLabel.Location = New System.Drawing.Point(69, 88)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(75, 17)
        Me.UsernameLabel.TabIndex = 6
        Me.UsernameLabel.Text = "User Name"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Db_laundryDataSet
        '
        Me.Db_laundryDataSet.DataSetName = "db_laundryDataSet"
        Me.Db_laundryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bs_karyawan
        '
        Me.bs_karyawan.DataMember = "tb_karyawan"
        Me.bs_karyawan.DataSource = Me.Db_laundryDataSet
        '
        'ta_karyawan
        '
        Me.ta_karyawan.ClearBeforeFill = True
        '
        'f_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(381, 248)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmd_login)
        Me.Controls.Add(Me.txt_sandi)
        Me.Controls.Add(Me.txt_user_name)
        Me.Controls.Add(Me.sandi)
        Me.Controls.Add(Me.UsernameLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "f_login"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Db_laundryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_karyawan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmd_login As System.Windows.Forms.Button
    Friend WithEvents txt_sandi As System.Windows.Forms.TextBox
    Friend WithEvents txt_user_name As System.Windows.Forms.TextBox
    Friend WithEvents sandi As System.Windows.Forms.Label
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents Db_laundryDataSet As JASA_LAUNDRY.db_laundryDataSet
    Friend WithEvents bs_karyawan As System.Windows.Forms.BindingSource
    Friend WithEvents ta_karyawan As JASA_LAUNDRY.db_laundryDataSetTableAdapters.tb_karyawanTableAdapter
End Class
