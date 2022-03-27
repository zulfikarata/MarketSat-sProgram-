Public Class KasiyerEkleme
    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        If txtAdı.Text = "" Or txtSoyadi.Text = "" Or txtCepTel.Text = "" Then
            MsgBox("Lütfen Tüm Alanları Doldurunuz",
           MsgBoxStyle.Critical, "Hata")
            Return
        End If
    End Sub
    End Sub

    Private Sub KasiyerEkleme_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmbxGorevBasTarih_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxGorevBasTarih.SelectedIndexChanged
        cmbxGorevBasTarih.Items.Add("20.12.2018");
        cmbxGorevBasTarih.Items.Add("07.08.2005");
    End Sub

    Private Sub cmbxGorevBitimTarih_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxGorevBitimTarih.SelectedIndexChanged
        cmbxGorevBitimTarih.Items.Add("12.06.2020");
        cmbxGorevBitimTarih.Items.Add("07.01.2022");
    End Sub

    Private Sub btnKapat_Click(sender As Object, e As EventArgs) Handles btnKapat.Click
        Me.Close()
    End Sub
End Class