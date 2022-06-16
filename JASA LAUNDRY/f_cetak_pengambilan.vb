Public Class f_cetak_pengambilan

    Private Sub f_cetak_pengambilan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ta_cetak_pengambilan.tampil_kd_transaksi(db_laundryDataSet.query_cetak_pengambilan, f_transaksi_pengambilan.txt_kd_transaksi.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class