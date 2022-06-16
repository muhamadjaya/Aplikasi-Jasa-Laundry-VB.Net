Public Class f_menu_utama

    Public id_user, user, status As String
    Public setter As New f_user
    Public tool As New ToolStripControlHost(setter)

    Private Sub f_menu_utama_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If id_user = "" And user = "" Then
            f_login.ShowDialog()
        End If
    End Sub


    Private Sub f_menu_utama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mn_user.DropDownItems.Add(tool)

        With setter
            .lbl_nama.RightToLeft = Windows.Forms.RightToLeft.No
            .lbl_user.RightToLeft = Windows.Forms.RightToLeft.No
            .lbl_logout.RightToLeft = Windows.Forms.RightToLeft.No
            .lbl_ubah_sandi.RightToLeft = Windows.Forms.RightToLeft.No
            .lbl_keluar.RightToLeft = Windows.Forms.RightToLeft.No
        End With
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        If MsgBox("Yakin Anda akan logout ?", vbQuestion + vbYesNo, "Konfirmasi") = vbYes Then
            id_user = ""
            user = ""
            f_login.ShowDialog()
        End If
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        f_cetak_penerimaan.ReportViewer1.Dispose()
        f_cetak_pengambilan.ReportViewer1.Dispose()
        f_cetak_lap_transaksi_bulanan.ReportViewer1.Dispose()
        End
    End Sub

    Private Sub PenerimaanLaundryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenerimaanLaundryToolStripMenuItem.Click
        f_transaksi_penerimaan.ShowDialog()
    End Sub

    Private Sub PengambilanLaundryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengambilanLaundryToolStripMenuItem.Click
        f_transaksi_pengambilan.ShowDialog()
    End Sub

    Private Sub PembelianBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembelianBarangToolStripMenuItem.Click
        f_pembelian_barang.ShowDialog()
    End Sub

    Private Sub PengambilanBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengambilanBarangToolStripMenuItem.Click
        f_pemakaian_barang.ShowDialog()
    End Sub

    Private Sub BarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangToolStripMenuItem.Click

    End Sub

    Private Sub JenisLaundryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JenisLaundryToolStripMenuItem.Click
        f_data_jenis_laundry.ShowDialog()
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem.Click
        f_data_supplier.ShowDialog()
    End Sub

    Private Sub KaryawanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KaryawanToolStripMenuItem.Click
        f_data_karyawan.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        f_transaksi_penerimaan.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        f_transaksi_pengambilan.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        f_pembelian_barang.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        f_pemakaian_barang.ShowDialog()
    End Sub

    Private Sub TransaksiBulananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiBulananToolStripMenuItem.Click
        f_lap_transaksi_bulanan.ShowDialog()
    End Sub
End Class