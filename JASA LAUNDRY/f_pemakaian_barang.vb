Public Class f_pemakaian_barang
    Public kd_pemakaian As String

    Private Sub f_pemakaian_barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_laundryDataSet.tb_detail_pemakaian_barang' table. You can move, or remove it, as needed.
        Me.ta_detail_pemakaian_barang.Fill(Me.Db_laundryDataSet.tb_detail_pemakaian_barang)
        'TODO: This line of code loads data into the 'Db_laundryDataSet.tb_pemakaian_barang' table. You can move, or remove it, as needed.
        Me.ta_pemakaian_barang.Fill(Me.Db_laundryDataSet.tb_pemakaian_barang)
        'TODO: This line of code loads data into the 'Db_laundryDataSet.tb_barang' table. You can move, or remove it, as needed.
        Me.ta_barang.Fill(Me.Db_laundryDataSet.tb_barang)

    End Sub

    Private Sub kd_otomatis()
        kd_pemakaian = "PMK-" & Format(bs_pemakaian_barang.Count + 1, "000")
    End Sub

    Private Sub kosongkan()
        txt_kd_barang.Clear()
        txt_barang.Clear()
        txt_satuan.Clear()
        txt_jumlah.Clear()
        txt_kd_barang.Focus()
    End Sub

    Private Sub cari_barang()
        With bs_barang
            .Filter = "kd_barang='" & txt_kd_barang.Text & "'"
            If .Count > 0 Then
                txt_barang.Text = .Current("barang")
                txt_satuan.Text = .Current("satuan")
                txt_jumlah.Focus()
            Else
                MsgBox("Maaf kode barang tidak ditemukan !", vbExclamation, "Perhatian")
                Call kosongkan()
            End If
        End With
    End Sub

    Private Sub txt_kd_barang_LostFocus(sender As Object, e As EventArgs) Handles txt_kd_barang.LostFocus
        If txt_kd_barang.Text <> "" Then
            cari_barang()
        End If
    End Sub


    Private Sub cmd_ok_Click(sender As Object, e As EventArgs) Handles cmd_ok.Click
        With bs_c_pemakaian
            .AddNew()
            .Current("kd_barang") = txt_kd_barang.Text
            .Current("barang") = txt_barang.Text
            .Current("satuan") = txt_satuan.Text
            .Current("jumlah") = txt_jumlah.Text
            .EndEdit()
            Call kosongkan()
        End With
    End Sub

    Private Sub cmd_simpan_Click(sender As Object, e As EventArgs) Handles cmd_simpan.Click
        Call kd_otomatis()

        With bs_pemakaian_barang
            .AddNew()
            .Current("kd_pemakaian_barang") = kd_pemakaian
            .Current("kd_karyawan") = f_menu_utama.id_user.ToString
            .Current("tgl_pemakaian") = CDate(Now)
            .Current("waktu_pemakaian") = TimeString
            .EndEdit()
            ta_pemakaian_barang.Update(Db_laundryDataSet)
        End With

        bs_c_pemakaian.MoveFirst()
        For i = 1 To bs_c_pemakaian.Count
            With bs_detail_pemakaian_barang
                .AddNew()
                .Current("kd_pemakaian_barang") = kd_pemakaian
                .Current("kd_barang") = bs_c_pemakaian.Current("kd_barang")
                .Current("jumlah_pemakaian") = bs_c_pemakaian.Current("jumlah")
                .EndEdit()
                ta_detail_pemakaian_barang.Update(Db_laundryDataSet)
                bs_c_pemakaian.MoveNext()
            End With
        Next

        For i = 1 To bs_c_pemakaian.Count
            bs_c_pemakaian.RemoveCurrent()
            bs_c_pemakaian.EndEdit()
        Next
    End Sub

    Private Sub cmd_resett_Click(sender As Object, e As EventArgs) Handles cmd_resett.Click
        Call kosongkan()
    End Sub

    Private Sub cmd_keluar_Click(sender As Object, e As EventArgs) Handles cmd_keluar.Click
        keluar(Me)
    End Sub
End Class