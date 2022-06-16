Public Class f_lap_transaksi_bulanan

    Private Sub f_lap_transaksi_bulanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_laundryDataSet.tb_transaksi' table. You can move, or remove it, as needed.
        Me.ta_transaksi.Fill(Me.Db_laundryDataSet.tb_transaksi)


    End Sub

    Private Sub dtp_awal_ValueChanged(sender As Object, e As EventArgs) Handles dtp_awal.ValueChanged
        ta_transaksi.tampil_querybulanan(Db_laundryDataSet.tb_transaksi, dtp_awal.Value, dtp_akhir.Value)
    End Sub

    Private Sub cmd_reset_Click(sender As Object, e As EventArgs) Handles cmd_reset.Click
        dtp_awal.Value = CDate(Now)
        dtp_akhir.Value = CDate(Now)
        Me.ta_transaksi.Fill(Me.Db_laundryDataSet.tb_transaksi)
    End Sub

    Private Sub dtp_akhir_ValueChanged(sender As Object, e As EventArgs) Handles dtp_akhir.ValueChanged
        ta_transaksi.tampil_querybulanan(Db_laundryDataSet.tb_transaksi, dtp_awal.Value, dtp_akhir.Value)
    End Sub

    Private Sub cmd_cetak_Click(sender As Object, e As EventArgs) Handles cmd_cetak.Click
        f_cetak_lap_transaksi_bulanan.ShowDialog()
    End Sub

    Private Sub cmd_keluar_Click(sender As Object, e As EventArgs) Handles cmd_keluar.Click
        Me.Close()
    End Sub
End Class