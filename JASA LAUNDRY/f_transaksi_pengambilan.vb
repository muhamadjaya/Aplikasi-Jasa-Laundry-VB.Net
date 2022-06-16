Public Class f_transaksi_pengambilan

    Private Sub f_transaksi_pengambilan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_laundryDataSet.tb_transaksi' table. You can move, or remove it, as needed.
        Me.ta_transaksi.Fill(Me.Db_laundryDataSet.tb_transaksi)

    End Sub

    Private Sub kosongkan()
        ta_cari_pengambilan.tampil_kd_transaksi(Db_laundryDataSet.query_cari_pengambilan, "")

        txt_kd_transaksi.Clear()
        txt_tot_bayar.Clear()
        txt_jml_uang.Clear()
        txt_kembalian.Clear()
        txt_kd_transaksi.Focus()
    End Sub

    Private Sub txt_kd_transaksi_LostFocus(sender As Object, e As EventArgs) Handles txt_kd_transaksi.LostFocus
        If txt_kd_transaksi.Text <> "" Then
            txt_tot_bayar.Clear()

            ta_cari_pengambilan.tampil_kd_transaksi(Db_laundryDataSet.query_cari_pengambilan, txt_kd_transaksi.Text)

            If bs_cari_pengambilan.Current("tgl_ambil").ToString <> "" Then
                MsgBox("Transaksi pengambilan ini sudah dilakukan !", vbExclamation, "Perhatian")
                Call kosongkan()
                Exit Sub
            End If

            bs_cari_pengambilan.MoveFirst()
            For i = 1 To bs_cari_pengambilan.Count
                txt_tot_bayar.Text = Val(txt_tot_bayar.Text) + (Val(bs_cari_pengambilan.Current("tarif")) * Val(bs_cari_pengambilan.Current("berat")))
                bs_cari_pengambilan.MoveNext()
            Next

            txt_tot_bayar.Text = Val(txt_tot_bayar.Text) - (Val(txt_tot_bayar.Text) * Val(txt_diskon.Text) / 100)
        End If
    End Sub


    Private Sub txt_jml_uang_TextChanged(sender As Object, e As EventArgs) Handles txt_jml_uang.TextChanged
        If txt_jml_uang.Text <> "" And IsNumeric(txt_jml_uang.Text) = True Then
            txt_kembalian.Text = Val(txt_jml_uang.Text) - Val(txt_tot_bayar.Text)
        Else
            txt_jml_uang.Clear()
            txt_kembalian.Clear()
        End If
    End Sub

    Private Sub cmd_simpan_Click(sender As Object, e As EventArgs) Handles cmd_simpan.Click
        With bs_transaksi
            .Filter = "kd_transaksi='" & txt_kd_transaksi.Text & "'"

            .Current("tgl_ambil") = CDate(Now)
            .Current("tot_bayar") = txt_tot_bayar.Text
            .EndEdit()
            ta_transaksi.Update(Db_laundryDataSet)
            MsgBox("Transaksi berhasil tersimpan", vbInformation, "Informasi")
            f_cetak_pengambilan.ShowDialog()
            Call kosongkan()
        End With
    End Sub

    Private Sub cmd_resett_Click(sender As Object, e As EventArgs) Handles cmd_resett.Click
        Call kosongkan()
    End Sub

    Private Sub cmd_keluar_Click(sender As Object, e As EventArgs) Handles cmd_keluar.Click
        keluar(Me)
    End Sub
End Class