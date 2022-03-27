Public Class Satışİşlemleri
    Private Sub Satışİşlemleri_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAra_Click(sender As Object, e As EventArgs) Handles btnAra.Click
        ÜrünKayıt.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSatısİslem.CellContentClick
        dgSatısİslem.Rows.Add();
          dgSatısİslem[0].Cells[0].Value = 1;
            dgSatısİslem.Rows[0].Cells[1].Value = "Ramazan";
            dgSatısİslem.Rows[0].Cells[2].Value = "TOKAY";
    End Sub

    Private Sub btnSatısYap_Click(sender As Object, e As EventArgs) Handles btnSatısYap.Click
        Dim bt As New Button
        bt.Location = New Drawing.Point(8, 15 + Index * 24)
        bt.TabIndex = Index
        bt.Text = "Düğme: " & Index.ToString
        bt.Name = "Düğme" & Index.ToString
        AddHandler bt.Click, AddressOf tıkla
        Me.FlowLayoutPanel1.Controls.Add(bt)
        Index += 1
    End Sub

    Sub tıkla(ByVal sender As Object, ByVal e As System.EventArgs)
        MsgBox(DirectCast(sender, Button).Name & " tıklandı!")
    End Sub

    Private Sub cmbxTarih_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxTarih.SelectedIndexChanged
        cmbxTarih.Items.Add("10.12.2019");
        cmbxTarih.Items.Add("07.07.2019");
    End Sub

    Private Sub cmbxUrunAdi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxUrunAdi.SelectedIndexChanged
        cmbxUrunAdi.Items.Add("Kola");
        cmbxUrunAdi.Items.Add("Fanta");
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxKisiler.SelectedIndexChanged
        cmbxKisiler.Items.Add("Ali");
        cmbxKisiler.Items.Add("Veli");
    End Sub

    Private Sub btnKapat_Click(sender As Object, e As EventArgs) Handles btnKapat.Click
        Me.Close()
    End Sub
End Class