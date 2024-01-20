Public Class Soal4
    Public biaya, layanan As Integer


    Private Sub cmbjenis_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbjenis.SelectedIndexChanged
        Select Case cmbjenis.Text
            Case "Toyota Avanza"
                txtbiaya.Text = "Rp. 240.000"
                biaya = 240000
            Case "Toyota Calya"
                txtbiaya.Text = "Rp. 210.000"
                biaya = 210000
            Case "Toyota Inova"
                txtbiaya.Text = "Rp. 340.000"
                biaya = 340000
            Case "Daihatsu Xenia"
                txtbiaya.Text = "Rp. 230.000"
                biaya = 230000
            Case "Daihatsu Sigra"
                txtbiaya.Text = "Rp. 200.000"
                biaya = 200000
            Case "Honda Brio"
                txtbiaya.Text = "Rp. 230.000"
                biaya = 230000
            Case "Honda Mobilio"
                txtbiaya.Text = "Rp. 240.000"
                biaya = 240000
            Case "Mitsubishi Xpander"
                txtbiaya.Text = "Rp. 300.000"
                biaya = 300000
        End Select
    End Sub

    Private Sub cmblayanan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmblayanan.SelectedIndexChanged
        Select Case cmblayanan.Text
            Case "Lepas Kunci"
                txtlayanan.Text = "Rp. 0"
                layanan = 0
            Case "Dengan Supir"
                txtlayanan.Text = "Rp. 150.000"
                layanan = 150000
        End Select
    End Sub

    Private Sub Proses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Proses.Click
        txttotal.Text = Val(txtbiaya.Text) * Val(txtlamasewa.Text) + Val(txtlayanan.Text)

    End Sub

    Private Sub Keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Keluar.Click
        End
    End Sub

    Private Sub Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear.Click
        txtbiaya.Text = ""
        txtidentitas.Text = ""
        txtlamasewa.Text = ""
        txtlayanan.Text = ""
        txtnama.Text = ""
        txtnohp.Text = ""
        txttotal.Text = ""
        cmbjenis.Text = ""
        cmblayanan.Text = ""
        txtnama.Focus()
    End Sub
End Class