Public Class f_data_supplier

    Private Sub f_data_supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_laundryDataSet.tb_supplier' table. You can move, or remove it, as needed.
        Me.ta_supplier.Fill(Me.Db_laundryDataSet.tb_supplier)

    End Sub

    Private Sub kd_otomatis()
        txt_kd_supplier.Text = "SPL-" & Format(bs_supplier.Count + 1, "000")
    End Sub

    Private Sub kosongkan()
        txt_kd_supplier.Clear()
        supplier.Clear()
        alamat.Clear()
        cp.Clear()
        Call kd_otomatis()
        supplier.Focus()
    End Sub

    Private Sub cmd_tambah_Click(sender As Object, e As EventArgs) Handles cmd_tambah.Click
        Call kosongkan()
        tambah(txt_kd_supplier, cmd_simpan, cmd_perbarui, cmd_hapus)
    End Sub

    Private Sub cmd_simpan_Click(sender As Object, e As EventArgs) Handles cmd_simpan.Click
        With bs_supplier
            .AddNew()
            .Current("kd_supplier") = txt_kd_supplier.Text
            .Current("supplier") = supplier.Text
            .Current("alamat") = alamat.Text
            .Current("cp") = cp.Text
            .EndEdit()
            ta_supplier.Update(Db_laundryDataSet)
            kosongkan()
        End With
    End Sub

    Private Sub dgv_sup_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_sup.CellClick
        With bs_supplier
            If .Count > 0 Then
                txt_kd_supplier.Text = .Current("kd_supplier")
                supplier.Text = .Current("supplier")
                alamat.Text = .Current("alamat")
                cp.Text = .Current("cp")

                pilih(txt_kd_supplier, cmd_simpan, cmd_perbarui, cmd_hapus)
            End If
        End With
    End Sub

  
    Private Sub cmd_perbarui_Click(sender As Object, e As EventArgs) Handles cmd_perbarui.Click
        With bs_supplier
            .AddNew()
            .Current("kd_supplier") = txt_kd_supplier.Text
            .Current("supplier") = supplier.Text
            .Current("alamat") = alamat.Text
            .Current("cp") = cp.Text
            .EndEdit()
            ta_supplier.Update(Db_laundryDataSet)
            kosongkan()
        End With
    End Sub

    Private Sub cmd_hapus_Click(sender As Object, e As EventArgs) Handles cmd_hapus.Click
        If bs_supplier.Count > 0 Then
            If MsgBox("Yakin Anda akan menghapus data ini ?", vbQuestion + vbYesNo, "Konfirmasi") = vbYes Then
                bs_supplier.RemoveCurrent()
                bs_supplier.EndEdit()
                ta_supplier.Update(Db_laundryDataSet)
                kosongkan()
            End If
        Else
            MsgBox("Maaf data supplier masih kosong !", vbExclamation, "Perhatian")
        End If
    End Sub

    Private Sub cmd_keluar_Click(sender As Object, e As EventArgs) Handles cmd_keluar.Click
        keluar(Me)
    End Sub
End Class