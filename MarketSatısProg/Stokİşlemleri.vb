Public Class Stokİşlemleri
    Private Sub dgStokİslem_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgStokİslem.CellContentClick
        dgStokİslem.Rows.Add();
    End Sub

    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click
        If txtUrunAdi.Text = "" Then
            MsgBox("Silinecek Kayıt Seçiniz", MsgBoxStyle.Critical, "Hata")
            Return
        End If
        If MsgBox("Kayıt Silinecektir Onaylıyor musunuz?", MsgBoxStyle.YesNo, "İşlem Onayı") = MsgBox() Then
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxUrunler.SelectedIndexChanged
        cmbxUrunler.Items.Add("ekmek");
        cmbxUrunler.Items.Add("süt");
    End Sub

    Private Sub btnKapat_Click(sender As Object, e As EventArgs) Handles btnKapat.Click
        Me.Close()
    End Sub
End Class