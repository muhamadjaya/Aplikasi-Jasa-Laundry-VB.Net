Public Class f_transaksi_penerimaan
    Public kd_transaksi As String

    Private Sub f_transaksi_penerimaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_laundryDataSet.tb_detail_transaksi' table. You can move, or remove it, as needed.
        Me.ta_detail_transaksi.Fill(Me.Db_laundryDataSet.tb_detail_transaksi)
        'TODO: This line of code loads data into the 'Db_laundryDataSet.tb_transaksi' table. You can move, or remove it, as needed.
        Me.ta_transaksi.Fill(Me.Db_laundryDataSet.tb_transaksi)
        'TODO: This line of code loads data into the 'Db_laundryDataSet.tb_konsumen' table. You can move, or remove it, as needed.
        Me.ta_konsumen.Fill(Me.Db_laundryDataSet.tb_konsumen)
        'TODO: This line of code loads data into the 'Db_laundryDataSet.tb_jenis_laundry' table. You can move, or remove it, as needed.
        Me.ta_jenis_laundry.Fill(Me.Db_laundryDataSet.tb_jenis_laundry)

    End Sub

    Private Sub kd_otomatis()
        kd_transaksi = "TRX-" & Format(bs_transaksi.Count + 1, "000")
    End Sub

    Private Sub kd_konsumen()
        txt_kd_konsumen.Text = "KSM-" & Format(bs_konsumen.Count + 1, "000")
    End Sub

    Private Sub kosongkan_data_jenis_laundry()
        cb_jenis_laundry.SelectedIndex = 0
        txt_berat.Clear()
    End Sub

    Private Sub kosongkan_data_konsumen()
        txt_kd_konsumen.Clear()
        txt_konsumen.Clear()
        txt_cp.Clear()
        txt_alamat.Clear()
        txt_diskon.Clear()
        dtp_tgl_selesai.Value = CDate(Now)
        txt_kd_konsumen.Focus()
    End Sub


    Private Sub cmd_ok_Click(sender As Object, e As EventArgs) Handles cmd_ok.Click
        With bs_tampil_jenis_laundry
            .AddNew()
            .Current("kd_jenis_laundry") = cb_jenis_laundry.SelectedValue
            .Current("jenis_laundry") = cb_jenis_laundry.Text
            .Current("tarif") = txt_tarif.Text
            .Current("berat") = txt_berat.Text
            .EndEdit()
            Call kosongkan_data_jenis_laundry()
        End With
    End Sub

    Private Sub cmd_reset_Click(sender As Object, e As EventArgs) Handles cmd_reset.Click
        Call kosongkan_data_jenis_laundry()
    End Sub

    Private Sub cmd_hapus_Click(sender As Object, e As EventArgs) Handles cmd_hapus.Click
        bs_tampil_jenis_laundry.RemoveCurrent()
        bs_tampil_jenis_laundry.EndEdit()
    End Sub

    Private Sub cari_konsumen()
        With bs_konsumen
            .Filter = "kd_konsumen='" & txt_kd_konsumen.Text & "'"
            If .Count > 0 Then
                txt_konsumen.Text = .Current("konsumen")
                txt_cp.Text = .Current("cp")
                txt_alamat.Text = .Current("alamat")
                dtp_tgl_selesai.Focus()
            Else
                txt_konsumen.Clear()
                txt_cp.Clear()
                txt_alamat.Clear()
                txt_konsumen.Focus()
            End If
        End With
    End Sub

    Private Sub txt_kd_konsumen_LostFocus(sender As Object, e As EventArgs) Handles txt_kd_konsumen.LostFocus
        cari_konsumen()
    End Sub


    Private Sub simpan_transaksi_dan_detail_transaksi()
        Call kd_otomatis()

        With bs_transaksi
            .AddNew()
            .Current("kd_transaksi") = kd_transaksi
            .Current("kd_konsumen") = txt_kd_konsumen.Text
            .Current("kd_karyawan") = "KRY-001"
            .Current("tgl_transaksi") = CDate(Now)
            .Current("tgl_selesai") = dtp_tgl_selesai.Value
            .Current("diskon") = txt_diskon.Text
            .EndEdit()
            ta_transaksi.Update(Db_laundryDataSet)
        End With

        bs_tampil_jenis_laundry.MoveFirst()
        For i = 1 To bs_tampil_jenis_laundry.Count
            With bs_detail_transaksi
                .AddNew()
                .Current("kd_transaksi") = kd_transaksi
                .Current("kd_jenis_laundry") = bs_tampil_jenis_laundry.Current("kd_jenis_laundry")
                .Current("berat") = bs_tampil_jenis_laundry.Current("berat")
                .EndEdit()
                ta_detail_transaksi.Update(Db_laundryDataSet)
                bs_tampil_jenis_laundry.MoveNext()
            End With
        Next

        Call kosongkan_data_jenis_laundry()
        Call kosongkan_data_konsumen()

        For i = 1 To bs_tampil_jenis_laundry.Count
            bs_tampil_jenis_laundry.RemoveCurrent()
            bs_tampil_jenis_laundry.EndEdit()
        Next

        MsgBox("Data berhasil tersimpan", vbInformation, "Informasi")
    End Sub
  
    Private Sub cmd_simpan_Click(sender As Object, e As EventArgs) Handles cmd_simpan.Click
        If bs_konsumen.Count > 0 Then
            Call simpan_transaksi_dan_detail_transaksi()
        Else

            With bs_konsumen
                .AddNew()
                .Current("kd_konsumen") = txt_kd_konsumen.Text
                .Current("konsumen") = txt_konsumen.Text
                .Current("alamat") = txt_alamat.Text
                .Current("cp") = txt_cp.Text
                .EndEdit()
                ta_konsumen.Update(Db_laundryDataSet)
            End With

            Call simpan_transaksi_dan_detail_transaksi()
        End If
        f_cetak_penerimaan.ShowDialog()
    End Sub

    Private Sub cmd_resett_Click(sender As Object, e As EventArgs) Handles cmd_resett.Click
        Call kosongkan_data_konsumen()
    End Sub

    Private Sub cmd_generate_Click(sender As Object, e As EventArgs) Handles cmd_generate.Click
        bs_konsumen.RemoveFilter()
        Call kd_konsumen()
        cari_konsumen()
    End Sub

    Private Sub txt_kd_konsumen_TextChanged(sender As Object, e As EventArgs) Handles txt_kd_konsumen.TextChanged

    End Sub
End Class