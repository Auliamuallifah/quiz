Public Class Soal2

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        txtnim.Text = ""
        txtnama.Text = ""
        txtkelas.Text = ""
        txtuts.Text = ""
        txtuas.Text = ""
        txttugas.Text = ""
        txtangka.Text = ""
        txtketerangan.Text = ""
        txtnama.Focus()
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        End
    End Sub

    Private Sub btnproses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnproses.Click
        Dim nama As String
        Dim nim As String
        Dim tugas As Double
        Dim uts As Double
        Dim uas As Double
        Dim angka As Double
        Dim keterangan As String

        nim = txtnim.Text
        nama = txtnama.Text
        tugas = Val(txttugas.Text)
        uts = Val(txtuts.Text)
        uas = Val(txtuas.Text)
        angka = (0.2 * tugas + 0.3 * uts + 0.5 * uas)
        txtangka.Text = angka
        keterangan = txtketerangan.Text

        If angka >= 60 Then
            txtketerangan.Text = "Nilai anda baik! Anda Lulus"
        Else
            txtketerangan.Text = "Nilai anda sangat kurang! Maaf, anda tidak lulus"
        End If



    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub
End Class