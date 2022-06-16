<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_user
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lbl_ubah_sandi = New System.Windows.Forms.Button()
        Me.lbl_nama = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_keluar = New System.Windows.Forms.Button()
        Me.lbl_logout = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_ubah_sandi
        '
        Me.lbl_ubah_sandi.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_ubah_sandi.FlatAppearance.BorderSize = 0
        Me.lbl_ubah_sandi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_ubah_sandi.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lbl_ubah_sandi.ForeColor = System.Drawing.Color.Blue
        Me.lbl_ubah_sandi.Location = New System.Drawing.Point(0, 62)
        Me.lbl_ubah_sandi.Name = "lbl_ubah_sandi"
        Me.lbl_ubah_sandi.Size = New System.Drawing.Size(130, 29)
        Me.lbl_ubah_sandi.TabIndex = 4
        Me.lbl_ubah_sandi.Text = "Ubah Sandi"
        Me.lbl_ubah_sandi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_ubah_sandi.UseVisualStyleBackColor = True
        '
        'lbl_nama
        '
        Me.lbl_nama.AutoEllipsis = True
        Me.lbl_nama.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nama.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_nama.Location = New System.Drawing.Point(18, 18)
        Me.lbl_nama.Name = "lbl_nama"
        Me.lbl_nama.Size = New System.Drawing.Size(269, 23)
        Me.lbl_nama.TabIndex = 5
        Me.lbl_nama.Text = "NAMA"
        Me.lbl_nama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(22, 59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(117, 130)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'lbl_user
        '
        Me.lbl_user.AutoEllipsis = True
        Me.lbl_user.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.lbl_user.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_user.Location = New System.Drawing.Point(0, 0)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(130, 33)
        Me.lbl_user.TabIndex = 2
        Me.lbl_user.Text = "User"
        Me.lbl_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbl_keluar)
        Me.Panel1.Controls.Add(Me.lbl_ubah_sandi)
        Me.Panel1.Controls.Add(Me.lbl_logout)
        Me.Panel1.Controls.Add(Me.lbl_user)
        Me.Panel1.Location = New System.Drawing.Point(146, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(130, 130)
        Me.Panel1.TabIndex = 6
        '
        'lbl_keluar
        '
        Me.lbl_keluar.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_keluar.FlatAppearance.BorderSize = 0
        Me.lbl_keluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_keluar.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lbl_keluar.ForeColor = System.Drawing.Color.Red
        Me.lbl_keluar.Location = New System.Drawing.Point(0, 91)
        Me.lbl_keluar.Name = "lbl_keluar"
        Me.lbl_keluar.Size = New System.Drawing.Size(130, 29)
        Me.lbl_keluar.TabIndex = 5
        Me.lbl_keluar.Text = "Keluar"
        Me.lbl_keluar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_keluar.UseVisualStyleBackColor = True
        '
        'lbl_logout
        '
        Me.lbl_logout.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_logout.FlatAppearance.BorderSize = 0
        Me.lbl_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_logout.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lbl_logout.ForeColor = System.Drawing.Color.Blue
        Me.lbl_logout.Location = New System.Drawing.Point(0, 33)
        Me.lbl_logout.Name = "lbl_logout"
        Me.lbl_logout.Size = New System.Drawing.Size(130, 29)
        Me.lbl_logout.TabIndex = 3
        Me.lbl_logout.Text = "Logout"
        Me.lbl_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_logout.UseVisualStyleBackColor = True
        '
        'f_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lbl_nama)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "f_user"
        Me.Size = New System.Drawing.Size(305, 207)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_ubah_sandi As System.Windows.Forms.Button
    Friend WithEvents lbl_nama As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_user As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_keluar As System.Windows.Forms.Button
    Friend WithEvents lbl_logout As System.Windows.Forms.Button

End Class
