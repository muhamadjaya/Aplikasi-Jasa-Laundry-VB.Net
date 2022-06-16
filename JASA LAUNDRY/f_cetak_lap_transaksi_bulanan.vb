Imports Microsoft.Reporting.WinForms
Public Class f_cetak_lap_transaksi_bulanan

    Private Sub f_cetak_lap_transaksi_bulanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'db_laundryDataSet.tb_transaksi' table. You can move, or remove it, as needed.
        Me.ta_transaksi.Fill(Me.db_laundryDataSet.tb_transaksi)

        ta_transaksi.tampil_querybulanan(db_laundryDataSet.tb_transaksi, f_lap_transaksi_bulanan.dtp_awal.Value, f_lap_transaksi_bulanan.dtp_akhir.Value)
        Dim tanggal_awal, tanggal_akhir As ReportParameter
        tanggal_awal = New ReportParameter("tanggal1", f_lap_transaksi_bulanan.dtp_awal.Value)
        tanggal_akhir = New ReportParameter("tanggal2", f_lap_transaksi_bulanan.dtp_akhir.Value)
        ReportViewer1.LocalReport.SetParameters(tanggal_awal)
        ReportViewer1.LocalReport.SetParameters(tanggal_akhir)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class