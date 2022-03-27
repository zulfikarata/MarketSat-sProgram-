Public Class kategori
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstbxYeniKategoriEkle.SelectedIndexChanged

    End Sub

    Private Sub dgKategori_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgKategori.CellContentClick
        dgKategori.Rows.Add();
    End Sub

    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click
        If txtEkle.Text = "" Then
            MsgBox("Silinecek Kayıt Seçiniz", MsgBoxStyle.Critical, "Hata")
            Return
        End If
        If MsgBox("Kayıt Silinecektir Onaylıyor musunuz?", MsgBoxStyle.YesNo, "İşlem
Onayı") = MsgBoxResult Then
    End Sub

    Private Sub btnKapat_Click(sender As Object, e As EventArgs) Handles btnKapat.Click
        Me.Close()
    End Sub
End Class