Public Class f_data_jenis_laundry

    Private Sub f_data_jenis_laundry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_laundryDataSet.tb_jenis_laundry' table. You can move, or remove it, as needed.
        Me.ta_jenis_laundry.Fill(Me.Db_laundryDataSet.tb_jenis_laundry)

        kosongkan()
    End Sub

    Private Sub kd_otomatis()
        txt_kd_jenis.Text = "JNS-" & Format(bs_jenis_laundry.Count + 1, "000")
    End Sub

    Private Sub kosongkan()
        txt_kd_jenis.Clear()
        jenis.Clear()
        tarif.Clear()
        kd_otomatis()
        jenis.Focus()
    End Sub

    Private Sub cmd_tambah_Click(sender As Object, e As EventArgs) Handles cmd_tambah.Click
        Call kosongkan()
        tambah(txt_kd_jenis, cmd_simpan, cmd_perbarui, cmd_hapus)
    End Sub

    Private Sub cmd_simpan_Click(sender As Object, e As EventArgs) Handles cmd_simpan.Click
        With bs_jenis_laundry
            .AddNew()
            .Current("kd_jenis_laundry") = txt_kd_jenis.Text
            .Current("jenis_laundry") = jenis.Text
            .Current("tarif") = tarif.Text
            .EndEdit()
            ta_jenis_laundry.Update(Db_laundryDataSet)
            kosongkan()
        End With
    End Sub

    Private Sub dgv_sup_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_sup.CellClick
        With bs_jenis_laundry
            If .Count > 0 Then
                txt_kd_jenis.Text = .Current("kd_jenis_laundry")
                jenis.Text = .Current("jenis_laundry")
                tarif.Text = .Current("tarif")

                pilih(txt_kd_jenis, cmd_simpan, cmd_perbarui, cmd_hapus)
            End If
        End With
    End Sub

    Private Sub cmd_perbarui_Click(sender As Object, e As EventArgs) Handles cmd_perbarui.Click
        With bs_jenis_laundry
            .Current("kd_jenis_laundry") = txt_kd_jenis.Text
            .Current("jenis_laundry") = jenis.Text
            .Current("tarif") = tarif.Text
            .EndEdit()
            ta_jenis_laundry.Update(Db_laundryDataSet)
            kosongkan()
        End With
    End Sub

    Private Sub cmd_hapus_Click(sender As Object, e As EventArgs) Handles cmd_hapus.Click
        If bs_jenis_laundry.Count > 0 Then
            If MsgBox("Yakin Anda akan menghapus data ini ?", vbQuestion + vbYesNo, "Konfirmasi") = vbYes Then
                bs_jenis_laundry.RemoveCurrent()
                bs_jenis_laundry.EndEdit()
                ta_jenis_laundry.Update(Db_laundryDataSet)
                kosongkan()
            End If
        Else
            MsgBox("Maaf data jenis laundry masih kosong !", vbExclamation, "Perhatian")
        End If
    End Sub

    Private Sub cmd_keluar_Click(sender As Object, e As EventArgs) Handles cmd_keluar.Click
        keluar(Me)
    End Sub
End Class