Public Class Kasiyerler
    Private Sub btnEkle_Click(sender As Object, e As EventArgs) Handles btnEkle.Click
        dgKasiyerler.Rows.Add(cboxKasiyerler.SelectedIndex + 1, cboxKasiyerler.SelectedItem)
    End Sub

    Private Sub btnKapat_Click(sender As Object, e As EventArgs) Handles btnKapat.Click
        Me.Close()
    End Sub

    Private Sub dgKasiyerler_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgKasiyerler.CellContentClick
        dgKasiyerler.Rows.Add()
        dgKasiyerler.Rows[0].Cells[0].Value = 1;
        dgKasiyerler.Rows[0].Cells[1].Value = "Ramazan";
        dgKasiyerler.Rows[0].Cells[2].Value = "TOKAY";
    End Sub

    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click
        For Each c In Me.Controls
            If TypeOf c Is TextBox Then
                c.text = ""
    End Sub

    Private Sub btnAra_Click(sender As Object, e As EventArgs) Handles btnAra.Click
        Dim kelimeKontrol As String = txtKasiyerler.Text
        Dim kelimeBul As String = txtKasiyerler.Text

        If kelimeKontrol.Contains(kelimeBul) Then
            MsgBox("Aradığınız kelime mevcuttur.")
        Else
            MsgBox("Aradığınız kelime içermemektedir")
        End If
    End Sub

    Private Sub cboxKasiyerler_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxKasiyerler.SelectedIndexChanged
        cboxKasiyerler.Items.Add("ayşe");
        cboxKasiyerler.Items.Add("Fatma");
    End Sub
End Class