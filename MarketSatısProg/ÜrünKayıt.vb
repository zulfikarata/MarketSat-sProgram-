Public Class ÜrünKayıt
    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        If txtUrunAdi.Text = "" Or txtUrunKodu.Text = "" Or
cmbxFirmaAdi.Text = "" Then
            MsgBox("Lütfen Tüm Alanları Doldurunuz",
           MsgBoxStyle.Critical, "Hata")
            Return
        End If
    End Sub

    Private Sub cmbxFirmaAdi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxFirmaAdi.SelectedIndexChanged
        cmbxFirmaAdi.Items.Add("ATA A.Ş");
        cmbxFirmaAdi.Items.Add("CCAN.A.Ş");
    End Sub

    Private Sub btnKapat_Click(sender As Object, e As EventArgs) Handles btnKapat.Click
        Me.Close()
    End Sub
End Class