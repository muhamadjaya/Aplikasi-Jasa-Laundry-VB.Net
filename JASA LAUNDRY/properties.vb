Module properties

    Public Sub keluar(ByVal frm As Form)
        If MsgBox("Yakin Anda akan keluar ?", vbQuestion + vbYesNo, "Konfirmasi") = vbYes Then
            frm.Close()
        End If
    End Sub

    Public Sub tambah(ByVal txt_kd As TextBox, ByVal cmd_simpan As Button, ByVal cmd_perbarui As Button, ByVal cmd_hapus As Button)
        txt_kd.Enabled = True
        cmd_simpan.Enabled = True
        cmd_perbarui.Enabled = False
        cmd_hapus.Enabled = False
    End Sub

    Public Sub pilih(ByVal txt_kd As TextBox, ByVal cmd_simpan As Button, ByVal cmd_perbarui As Button, ByVal cmd_hapus As Button)
        txt_kd.Enabled = False
        cmd_simpan.Enabled = False
        cmd_perbarui.Enabled = True
        cmd_hapus.Enabled = True
    End Sub

End Module
