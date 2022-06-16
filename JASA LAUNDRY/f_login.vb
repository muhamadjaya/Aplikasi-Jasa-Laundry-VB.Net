Public Class f_login

   

    Private Sub f_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_laundryDataSet.tb_karyawan' table. You can move, or remove it, as needed.
        Me.ta_karyawan.Fill(Me.Db_laundryDataSet.tb_karyawan)

    End Sub

    Private Sub cmd_login_Click(sender As Object, e As EventArgs) Handles cmd_login.Click
        With bs_karyawan
            .MoveFirst()
            For i = 1 To bs_karyawan.Count
                If txt_user_name.Text = .Current("user_name") And txt_sandi.Text = .Current("sandi") Then
                    f_menu_utama.id_user = .Current("kd_karyawan")
                    f_menu_utama.user = .Current("karyawan")
                    Me.Close()
                    Exit Sub
                Else
                    .MoveNext()
                End If
            Next
            MsgBox("Maaf user name atau sandi yang Anda masukkan salah !", vbCritical, "Perhatian")
        End With
    End Sub
End Class