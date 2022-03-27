Public Class Ürünİşlemleri
    Private Sub btnEkle_Click(sender As Object, e As EventArgs) Handles btnEkle.Click
        ÜrünKayıt.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgUrunIslem.CellContentClick
        dgUrunIslem.Rows.Add();
            dgUrunIslem.Rows[0].Cells[0].Value = 1;
            dgUrunIslem.Rows[0].Cells[1].Value = "Ali";
            dgUrunIslem.Rows[0].Cells[2].Value = "Can";
    End Sub

    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click
        If txtUrunler.Text = "" Then
            MsgBox("Silinecek Kayıt Seçiniz", MsgBoxStyle.Critical, "Hata")
            Return
        End If
        If MsgBox("Kayıt Silinecektir Onaylıyor musunuz?", MsgBoxStyle.YesNo, "İşlem
Onayı") = MsgB Then
    End Sub

    Private Sub btnAra_Click(sender As Object, e As EventArgs) Handles btnAra.Click
        Dim kelimeKontrol As String = txtUrunler.Text
        Dim kelimeBul As String = txtUrunler.Text

        If kelimeKontrol.Contains(kelimeBul) Then
            MsgBox("Aradığınız kelime mevcuttur.")
        Else
            MsgBox("Aradığınız kelime içermemektedir")
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxUrunler.SelectedIndexChanged
        cmbxUrunler.Items.Add("Ayran");
    End Sub
End Class