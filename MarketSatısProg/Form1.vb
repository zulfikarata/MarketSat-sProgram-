Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMusIslem.Click
        MüsteriArama.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnUrunIslem.Click
        Ürünİşlemleri.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnKasiyerIslem.Click
        Kasiyerler.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnStokIslem.Click
        Stokİşlemleri.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnSatısIslem.Click
        Satışİşlemleri.Show()
    End Sub

    Private Sub btnCikis_Click(sender As Object, e As EventArgs) Handles btnCikis.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgMusteri.CellContentClick
        dgMusteri.Rows.Add();
            dgMusteri.Rows[0].Cells[0].Value = 1;
            dgMusteri.Rows[0].Cells[1].Value = "Ali";
            dgMusteri.Rows[0].Cells[2].Value = "Can";
            dgMusteri.Rows[1].Cells[0].Value = 2;
            dgMusteri.Rows[1].Cells[1].Value = "Veli";
            dgMusteri.Rows[1].Cells[2].Value = "Yurt";

        Dim dt As DataTable =
dtGetir("select * from musteriler order
by adsoyad")
        For i = 0 To dt.Rows.Count - 1
            dgMusteri.Rows.Add(dt.Rows(i)
("musteriNo").ToString(),
dt.Rows(i)("adsoyad").ToString(),
dt.Rows(i)("tel").ToString(),
dt.Rows(i)("adres").ToString())
 Next
        Me.Width = 360
    End Sub
End Class
