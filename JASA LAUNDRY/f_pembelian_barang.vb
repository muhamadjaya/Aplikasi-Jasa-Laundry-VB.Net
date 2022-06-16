Public Class f_pembelian_barang
    Public kd_pembelian As String

    Private Sub f_pembelian_barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_laundryDataSet.tb_supplier' table. You can move, or remove it, as needed.
        Me.ta_supplier.Fill(Me.Db_laundryDataSet.tb_supplier)
        'TODO: This line of code loads data into the 'Db_laundryDataSet.tb_detail_pembelian_barang' table. You can move, or remove it, as needed.
        Me.ta_detail_pembelian_barang.Fill(Me.Db_laundryDataSet.tb_detail_pembelian_barang)
        'TODO: This line of code loads data into the 'Db_laundryDataSet.tb_pembelian_barang' table. You can move, or remove it, as needed.
        Me.ta_pembelian_barang.Fill(Me.Db_laundryDataSet.tb_pembelian_barang)
        'TODO: This line of code loads data into the 'Db_laundryDataSet.tb_barang' table. You can move, or remove it, as needed.
        Me.ta_barang.Fill(Me.Db_laundryDataSet.tb_barang)

    End Sub

    Private Sub kd_otomatis()
        kd_pembelian = "BLI-" & Format(bs_pembelian_barang.Count + 1, "000")
    End Sub

    Private Sub kosongkan()
        txt_kd_barang.Clear()
        txt_barang.Clear()
        cb_satuan.SelectedIndex = 0
        txt_h_beli.Clear()
        txt_qty.Clear()
        txt_jumlah.Clear()
        txt_kd_barang.Focus()
    End Sub

    Private Sub kosongkan_lanjut()
        cb_supplier.SelectedIndex = 0
        dtp_tgl_beli.Value = CDate(Now)
        txt_jml_item.Clear()
        txt_tot_biaya.Clear()
    End Sub

    Private Sub cari_barang()
        With bs_barang
            .Filter = "kd_barang='" & txt_kd_barang.Text & "'"
            If .Count > 0 Then
                txt_barang.Text = .Current("barang")
                cb_satuan.SelectedItem = .Current("satuan")
                txt_h_beli.Text = .Current("h_beli")
                txt_qty.Focus()
            Else
                txt_barang.Clear()
                cb_satuan.SelectedIndex = 0
                txt_h_beli.Clear()
                txt_barang.Focus()
            End If
        End With
    End Sub

    Private Sub txt_kd_barang_LostFocus(sender As Object, e As EventArgs) Handles txt_kd_barang.LostFocus
        If txt_kd_barang.Text <> "" Then
            cari_barang()
        End If
    End Sub

    Private Sub txt_qty_TextChanged(sender As Object, e As EventArgs) Handles txt_qty.TextChanged
        If txt_qty.Text <> "" And IsNumeric(txt_qty.Text) = True Then
            txt_jumlah.Text = Val(txt_h_beli.Text) * Val(txt_qty.Text)
        End If
    End Sub

    Private Sub simpan_barang()

        With bs_c_pembelian
            .Filter = "kd_barang='" & txt_kd_barang.Text & "'"
            If .Count > 0 Then
                bs_c_pembelian.Current("qty") = Val(bs_c_pembelian.Current("qty")) + Val(txt_qty.Text)
                bs_c_pembelian.EndEdit()
                bs_c_pembelian.RemoveFilter()
            Else
                With bs_c_pembelian
                    .AddNew()
                    .Current("kd_barang") = txt_kd_barang.Text
                    .Current("barang") = txt_barang.Text
                    .Current("satuan") = cb_satuan.Text
                    .Current("h_beli") = txt_h_beli.Text
                    .Current("qty") = txt_qty.Text
                    .EndEdit()
                    bs_c_pembelian.RemoveFilter()
                End With
            End If
        End With

        txt_jml_item.Text = bs_c_pembelian.Count
        txt_tot_biaya.Text = Val(txt_tot_biaya.Text) + Val(txt_jumlah.Text)

        Call kosongkan()
    End Sub

    Private Sub cmd_ok_Click(sender As Object, e As EventArgs) Handles cmd_ok.Click
        If bs_barang.Count > 0 Then
            bs_barang.Current("stok") = Val(bs_barang.Current("stok")) + Val(txt_qty.Text)
            bs_barang.EndEdit()
            ta_barang.Update(Db_laundryDataSet)
            Call simpan_barang()
        Else
            With bs_barang
                .AddNew()
                .Current("kd_barang") = txt_kd_barang.Text
                .Current("barang") = txt_barang.Text
                .Current("stok") = txt_qty.Text
                .Current("satuan") = cb_satuan.Text
                .Current("h_beli") = txt_h_beli.Text
                .EndEdit()
                ta_barang.Update(Db_laundryDataSet)
            End With

            Call simpan_barang()
        End If
    End Sub

    Private Sub cmd_reset_Click(sender As Object, e As EventArgs) Handles cmd_reset.Click
        Call kosongkan()
    End Sub

    Private Sub cmd_simpan_Click(sender As Object, e As EventArgs) Handles cmd_simpan.Click
        Call kd_otomatis()

        With bs_pembelian_barang
            .AddNew()
            .Current("kd_pembelian") = kd_pembelian
            .Current("kd_supplier") = cb_supplier.SelectedValue
            .Current("kd_karyawan") = f_menu_utama.id_user.ToString
            .Current("tgl_pembelian") = dtp_tgl_beli.Value
            .Current("item") = bs_c_pembelian.Count
            .Current("tot_biaya") = txt_tot_biaya.Text
            .EndEdit()
            ta_pembelian_barang.Update(Db_laundryDataSet)
        End With

        bs_c_pembelian.MoveFirst()
        For i = 1 To bs_c_pembelian.Count
            With bs_detail_pembelian_barang
                .AddNew()
                .Current("kd_pembelian") = kd_pembelian
                .Current("kd_barang") = bs_c_pembelian.Current("kd_barang")
                .Current("qty") = bs_c_pembelian.Current("qty")
                .Current("tot_harga_item") = Val(bs_c_pembelian.Current("h_beli")) * Val(bs_c_pembelian.Current("qty"))
                .EndEdit()
                ta_detail_pembelian_barang.Update(Db_laundryDataSet)
                bs_c_pembelian.MoveNext()
            End With
        Next

        For i = 1 To bs_c_pembelian.Count
            bs_c_pembelian.RemoveCurrent()
            bs_c_pembelian.EndEdit()
        Next

        Call kosongkan()
        Call kosongkan_lanjut()
    End Sub

    Private Sub cmd_keluar_Click(sender As Object, e As EventArgs) Handles cmd_keluar.Click
        f_cetak_pengambilan.ReportViewer1.Dispose()
        keluar(Me)
    End Sub

    Private Sub cmd_hapus_Click(sender As Object, e As EventArgs) Handles cmd_hapus.Click
        With bs_barang
            .Filter = "kd_barang='" & bs_c_pembelian.Current("kd_barang") & "'"
            If .Count > 0 Then
                bs_barang.Current("stok") = Val(bs_barang.Current("stok")) - Val(bs_c_pembelian.Current("qty"))
                bs_barang.EndEdit()
                ta_barang.Update(Db_laundryDataSet)
                bs_barang.RemoveFilter()
            End If
            txt_tot_biaya.Text = Val(txt_tot_biaya.Text) - (Val(bs_c_pembelian.Current("h_beli")) * Val(bs_c_pembelian.Current("qty")))
            bs_c_pembelian.RemoveCurrent()
            bs_c_pembelian.EndEdit()
            txt_jml_item.Text = bs_c_pembelian.Count
        End With
    End Sub
End Class