Public Class MüsteriArama

    End Sub
    Private Sub dgMusteriArama_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgMusteriArama.CellContentClick
        dgMusteriArama.Rows.Add();
    End Sub

    Private Sub btnEkle_Click(sender As Object, e As EventArgs) Handles btnEkle.Click
        dgMusteriArama.Rows.Clear()
        dgMusteriArama.Rows.Clear()
        If txtArama.Text = "" Then
            MsgBox("Lütfen Bir Müşteri Seçiniz", MsgBoxStyle.Critical, "Hata")
            Return
        End If
        Dim musteriNo As Integer = Convert.ToInt32(txtArama.Text)
        Dim dtKay As DataTable = dtGetir("select * from kayitlar where musteriNo=" &
       musteriNo)
        For i = 0 To dtKay.Rows.Count - 1
            dgMusteriArama.Rows.Add(dtKay.Rows(i)("kayNo").ToString(),
           dtKay.Rows(i)("kayGun").ToString() & "." & dtKay.Rows(i)("kayAy").ToString() & "." &
           dtKay.Rows(i)("kayYil").ToString(), dtKay.Rows(i)("baslik").ToString(),
           dtKay.Rows(i)("ucret").ToString())
        Next
    End Sub

    Private Sub MüsteriArama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable = dtGetir("select * from musteriler order by adsoyad")
        For i = 0 To dt.Rows.Count - 1
            dgMusteriArama.Rows.Add(dt.Rows(i)("musteriNo").ToString(),
           dt.Rows(i)("adsoyad").ToString(), dt.Rows(i)("tel").ToString(),
           dt.Rows(i)("adres").ToString(), BorcHesapla(dt.Rows(i)("musteriNo").ToString()),
           OdenenHesapla(dt.Rows(i)("musteriNo").ToString()))
        Next
        BakiyeHesapla()
    End Sub
    Private Sub txtArama_TextChanged(sender As Object, e As EventArgs) Handles
txtArama.Texarama()
        dgMusteriArama.Rows.Clear()
        Dim dt As DataTable = dtGetir("select * from musteriler where adsoyad like '%" &
       txtArama.Text & "%' or adres like '%" & txtArama.Text & "%' order by adsoyad")
        For i = 0 To dt.Rows.Count - 1
            dgMusteriArama.Rows.Add(dt.Rows(i)("musteriNo").ToString(),
           dt.Rows(i)("adsoyad").ToString(), dt.Rows(i)("tel").ToString(),
           dt.Rows(i)("adres").ToString(), BorcHesapla(dt.Rows(i)("musteriNo").ToString()),
           OdenenHesapla(dt.Rows(i)("musteriNo").ToString()))
        Next
        BakiyeHesapla()
    End Sub
    Function BorcHesapla(musteriNo As Integer)
        Dim dt As DataTable = dtGetir("select * from kayitlar where musteriNo=" &
       musteriNo)
        Dim borc As Double = 0
        For i = 0 To dt.Rows.Count - 1
            borc += Convert.ToDouble(dt.Rows(i)("ucret").ToString())
        Next
        Return borc
    End Function
    Function OdenenHesapla(musteriNo As Integer)
        Dim dt As DataTable = dtGetir("select * from odemeler where musteriNo=" &
       musteriNo)
        Dim odenen As Double = 0
        For i = 0 To dt.Rows.Count - 1
            odenen += Convert.ToDouble(dt.Rows(i)("odenen").ToString())
        Next
        Return odenen
    End Function
    Sub BakiyeHesapla()
        Dim borc, odenen, bakiye As Double
        For i = 0 To dgMusteriArama.Rows.Count - 1
            borc = dgMusteriArama.Rows(i).Cells(4).Value
            odenen = dgMusteriArama.Rows(i).Cells(5).Value
            bakiye = odenen - borc
            dgMusteriArama.Rows(i).Cells(6).Value = bakiye.ToString(".00 TL")
            If bakiye < 0 Then
                dgMusteriArama.Rows(i).Cells(6).Style.ForeColor = Color.Red
            Else
                dgMusteriArama.Rows(i).Cells(6).Style.ForeColor = Color.Green
            End If
        Next
    End Sub

    Private Sub btnKapat_Click(sender As Object, e As EventArgs) Handles btnKapat.Click
        Me.Close()
    End Sub

    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click
        If txtArama.Text = "" Then
            MsgBox("Silinecek Kayıt Seçiniz", MsgBoxStyle.Critical, "Hata")
            Return
        End If
        If MsgBox("Kayıt Silinecektir Onaylıyor musunuz?", MsgBoxStyle.YesNo, "İşlemOnayı") = MsgBoxResult.Cancel Then

        End If
    End Sub

    Private Sub btnAra_Click(sender As Object, e As EventArgs) Handles btnAra.Click
        Dim kelimeKontrol As String = txtArama.Text
        Dim kelimeBul As String = txtArama.Text

        If kelimeKontrol.Contains(kelimeBul) Then
            MsgBox("Aradığınız kelime mevcuttur.")
        Else
            MsgBox("Aradığınız kelime içermemektedir")
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxMusteriler.SelectedIndexChanged
        cmbxMusteriler.Items.Add("mehmet");
        cmbxMusteriler.Items.Add("Ali");
    End Sub
End Class