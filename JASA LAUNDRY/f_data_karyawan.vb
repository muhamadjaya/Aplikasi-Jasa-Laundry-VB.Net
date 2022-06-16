Public Class f_data_karyawan

    Private Sub f_data_karyawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_laundryDataSet.tb_karyawan' table. You can move, or remove it, as needed.
        Me.ta_karyawan.Fill(Me.Db_laundryDataSet.tb_karyawan)

        Call kd_otomatis()
    End Sub

    Private Sub kd_otomatis()
        kd_karyawan.Text = "KRY-" & Format(bs_karyawan.Count + 1, "000")
    End Sub

    Private Sub kosongkan()
        kd_karyawan.Clear()
        karyawan.Clear()
        rb_lk.Checked = True
        cp.Clear()
        jabatan.SelectedIndex = 0
        alamat.Clear()
        user_name.Clear()
        sandi.Clear()
        Call kd_otomatis()
        karyawan.Focus()
    End Sub

    Private Sub cmd_tambah_Click(sender As Object, e As EventArgs) Handles cmd_tambah.Click
        Call kosongkan()
        kd_karyawan.Enabled = True
        cmd_simpan.Enabled = True
        cmd_perbarui.Enabled = False
        cmd_hapus.Enabled = False
    End Sub

    Private Sub cmd_simpan_Click(sender As Object, e As EventArgs) Handles cmd_simpan.Click
        With bs_karyawan
            .AddNew()
            .Current("kd_karyawan") = kd_karyawan.Text
            .Current("karyawan") = karyawan.Text
            .Current("alamat") = alamat.Text
            If rb_lk.Checked = True Then
                .Current("jk") = "LAKI-LAKI"
            Else
                .Current("jk") = "PEREMPUAN"
            End If
            .Current("cp") = cp.Text
            .Current("jabatan") = jabatan.SelectedItem
            .Current("user_name") = user_name.Text
            .Current("sandi") = sandi.Text
            .EndEdit()
            ta_karyawan.Update(Db_laundryDataSet)
            Call kosongkan()
        End With
    End Sub

    Private Sub dgv_kry_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_kry.CellClick
        With bs_karyawan
            If .Count > 0 Then
                kd_karyawan.Text = .Current("kd_karyawan")
                karyawan.Text = .Current("karyawan")
                alamat.Text = .Current("alamat")
                If .Current("jk") = "LAKI-LAKI" Then
                    rb_lk.Checked = True
                Else
                    rb_pr.Checked = True
                End If
                cp.Text = .Current("cp")
                jabatan.SelectedItem = .Current("jabatan")
                user_name.Text = .Current("user_name")
                sandi.Text = .Current("sandi")

                kd_karyawan.Enabled = False
                cmd_simpan.Enabled = False
                cmd_perbarui.Enabled = True
                cmd_hapus.Enabled = True
            End If
        End With
    End Sub

  
    Private Sub cmd_perbarui_Click(sender As Object, e As EventArgs) Handles cmd_perbarui.Click
        With bs_karyawan
            .Current("kd_karyawan") = kd_karyawan.Text
            .Current("karyawan") = karyawan.Text
            .Current("alamat") = alamat.Text
            If rb_lk.Checked = True Then
                .Current("jk") = "LKAI-LAKI"
            Else
                .Current("jk") = "PEREMPUAN"
            End If
            .Current("cp") = cp.Text
            .Current("jabatan") = jabatan.SelectedItem
            .Current("user_name") = user_name.Text
            .Current("sandi") = sandi.Text
            .EndEdit()
            ta_karyawan.Update(Db_laundryDataSet)
            Call kosongkan()
        End With
    End Sub

    Private Sub cmd_hapus_Click(sender As Object, e As EventArgs) Handles cmd_hapus.Click
        If bs_karyawan.Count > 0 Then
            If MsgBox("Yakin Anda akan menghapus data ini ?", vbQuestion + vbYesNo, "Konfirmasi") = vbYes Then
                bs_karyawan.RemoveCurrent()
                bs_karyawan.EndEdit()
                ta_karyawan.Update(Db_laundryDataSet)
                kosongkan()
            End If
        Else
            MsgBox("Maaf data karyawan masih kosong !", vbExclamation, "Perhatian")
        End If
    End Sub

    Private Sub cmd_keluar_Click(sender As Object, e As EventArgs) Handles cmd_keluar.Click
        keluar(Me)
    End Sub

    Private Sub cmd_cari_Click(sender As Object, e As EventArgs) Handles cmd_cari.Click
        If txt_cari.Text <> "" Then
            ta_karyawan.FillBynamakry(Db_laundryDataSet.tb_karyawan, "%" & txt_cari.Text & "%")
        End If
    End Sub

    Private Sub cmd_reset_Click(sender As Object, e As EventArgs) Handles cmd_reset.Click
        txt_cari.Clear()
        txt_cari.Focus()
        bs_karyawan.RemoveFilter()
        ta_karyawan.Fill(Db_laundryDataSet.tb_karyawan)
    End Sub
End Class
