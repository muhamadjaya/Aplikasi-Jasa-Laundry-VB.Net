Public Class f_cetak_penerimaan

    Private Sub f_cetak_penerimaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ta_cetak_penerimaan.tampil_kd_transaksi(db_laundryDataSet.query_cetak_penerimaan, f_transaksi_penerimaan.kd_transaksi)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class