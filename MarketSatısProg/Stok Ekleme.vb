Public Class Stok_Ekleme
    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        Dim txtUrunAdi As Object = Nothing

        If txtUrunAdi.Text = "" Or txtBirimFiyat.Text = "" Or
txtKdv.Text = "" Then
            MsgBox("Lütfen Tüm Alanları Doldurunuz",
           MsgBoxStyle.Critical, "Hata")
            Return
        End If
    End Sub

    Private Sub cmbxUrunAdi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxUrunAdi.SelectedIndexChanged
        cmbxUrunAdi.Items.Add("kola");
        cmbxUrunAdi.Items.Add("fanta");
    End Sub

    Private Sub btnKapat_Click(sender As Object, e As EventArgs) Handles btnKapat.Click
        Me.Close()
    End Sub
End Class