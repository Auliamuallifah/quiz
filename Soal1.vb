Public Class Soal1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Bilangan Masih Kosong")
        Else
            If TextBox1.Text Mod 2 = 0 Then
                Label2.Text = TextBox1.Text + " Adalah Bilangan Genap"
            Else
                Label2.Text = TextBox1.Text + " Adalah Bilangan Ganjil"
            End If
        End If
    End Sub
End Class