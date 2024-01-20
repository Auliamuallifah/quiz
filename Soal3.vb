Public Class Soal3
    Public biaya, layanan As Integer
    Private Sub Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear.Click
        txtidentitas.Text = ""
        txtnama.Text = ""
        txtnohp.Text = ""
        txtlama.Text = ""
        txtbiaya.Text = ""
        txttotalbayar.Text = ""
        cmbjeniskamar.Text = ""
        cmblayanan.Text = ""
        txtnama.Focus()
    End Sub

    Private Sub Proses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Proses.Click
        txttotalbayar.Text = Val(txtbiaya.Text) * Val(txtlama.Text) + Val(txtlayanan.Text)

    End Sub

    Private Sub cmbjeniskamar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbjeniskamar.SelectedIndexChanged
        Select Case cmbjeniskamar.Text
            Case "Standard Room"
                txtbiaya.Text = "Rp. 200.000"
                biaya = 200000
            Case "Superior Room"
                txtbiaya.Text = "Rp. 300.000"
                biaya = 300000
            Case "Deluxe Room"
                txtbiaya.Text = "Rp. 350.000"
                biaya = 350000
            Case "Suite Room"
                txtbiaya.Text = "Rp. 550.000"
                biaya = 550000
        End Select
    End Sub

    Private Sub Soal3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmblayanan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmblayanan.SelectedIndexChanged
        Select Case cmblayanan.Text
            Case "Tanpa Breakfast"
                txtlayanan.Text = "Rp. 0"
                layanan = 0
            Case "Dengan Breakfast"
                txtlayanan.Text = "Rp. 20.000"
                layanan = 20000
        End Select
    End Sub

    Private Sub Keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Keluar.Click
        End
    End Sub
End Class