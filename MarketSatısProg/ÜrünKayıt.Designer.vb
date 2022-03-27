<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ÜrünKayıt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ÜrünKayıt))
        Me.lblUrunAdı = New System.Windows.Forms.Label()
        Me.lblUrunKodu = New System.Windows.Forms.Label()
        Me.lblFirmaAdı = New System.Windows.Forms.Label()
        Me.lblAlısFiyatı = New System.Windows.Forms.Label()
        Me.lblSatısFiyatı = New System.Windows.Forms.Label()
        Me.lblKategori = New System.Windows.Forms.Label()
        Me.txtUrunAdi = New System.Windows.Forms.TextBox()
        Me.txtUrunKodu = New System.Windows.Forms.TextBox()
        Me.txtAlisFiyati = New System.Windows.Forms.TextBox()
        Me.txtSatisFiyati = New System.Windows.Forms.TextBox()
        Me.cmbxFirmaAdi = New System.Windows.Forms.ComboBox()
        Me.cmbxKategori = New System.Windows.Forms.ComboBox()
        Me.btnKaydet = New System.Windows.Forms.Button()
        Me.ımageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnKapat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblUrunAdı
        '
        Me.lblUrunAdı.AutoSize = True
        Me.lblUrunAdı.Location = New System.Drawing.Point(29, 25)
        Me.lblUrunAdı.Name = "lblUrunAdı"
        Me.lblUrunAdı.Size = New System.Drawing.Size(56, 13)
        Me.lblUrunAdı.TabIndex = 0
        Me.lblUrunAdı.Text = "Ürün Adı"
        '
        'lblUrunKodu
        '
        Me.lblUrunKodu.AutoSize = True
        Me.lblUrunKodu.Location = New System.Drawing.Point(29, 54)
        Me.lblUrunKodu.Name = "lblUrunKodu"
        Me.lblUrunKodu.Size = New System.Drawing.Size(67, 13)
        Me.lblUrunKodu.TabIndex = 1
        Me.lblUrunKodu.Text = "Ürün Kodu"
        '
        'lblFirmaAdı
        '
        Me.lblFirmaAdı.AutoSize = True
        Me.lblFirmaAdı.Location = New System.Drawing.Point(29, 83)
        Me.lblFirmaAdı.Name = "lblFirmaAdı"
        Me.lblFirmaAdı.Size = New System.Drawing.Size(59, 13)
        Me.lblFirmaAdı.TabIndex = 2
        Me.lblFirmaAdı.Text = "Firma Adı"
        '
        'lblAlısFiyatı
        '
        Me.lblAlısFiyatı.AutoSize = True
        Me.lblAlısFiyatı.Location = New System.Drawing.Point(29, 109)
        Me.lblAlısFiyatı.Name = "lblAlısFiyatı"
        Me.lblAlısFiyatı.Size = New System.Drawing.Size(62, 13)
        Me.lblAlısFiyatı.TabIndex = 3
        Me.lblAlısFiyatı.Text = "Alış Fİyatı"
        '
        'lblSatısFiyatı
        '
        Me.lblSatısFiyatı.AutoSize = True
        Me.lblSatısFiyatı.Location = New System.Drawing.Point(29, 138)
        Me.lblSatısFiyatı.Name = "lblSatısFiyatı"
        Me.lblSatısFiyatı.Size = New System.Drawing.Size(69, 13)
        Me.lblSatısFiyatı.TabIndex = 4
        Me.lblSatısFiyatı.Text = "Satış Fiyatı"
        '
        'lblKategori
        '
        Me.lblKategori.AutoSize = True
        Me.lblKategori.Location = New System.Drawing.Point(29, 168)
        Me.lblKategori.Name = "lblKategori"
        Me.lblKategori.Size = New System.Drawing.Size(54, 13)
        Me.lblKategori.TabIndex = 5
        Me.lblKategori.Text = "Kategori"
        '
        'txtUrunAdi
        '
        Me.txtUrunAdi.Location = New System.Drawing.Point(126, 25)
        Me.txtUrunAdi.Name = "txtUrunAdi"
        Me.txtUrunAdi.Size = New System.Drawing.Size(121, 20)
        Me.txtUrunAdi.TabIndex = 6
        '
        'txtUrunKodu
        '
        Me.txtUrunKodu.Location = New System.Drawing.Point(126, 51)
        Me.txtUrunKodu.Name = "txtUrunKodu"
        Me.txtUrunKodu.Size = New System.Drawing.Size(121, 20)
        Me.txtUrunKodu.TabIndex = 7
        '
        'txtAlisFiyati
        '
        Me.txtAlisFiyati.Location = New System.Drawing.Point(126, 109)
        Me.txtAlisFiyati.Name = "txtAlisFiyati"
        Me.txtAlisFiyati.Size = New System.Drawing.Size(121, 20)
        Me.txtAlisFiyati.TabIndex = 8
        '
        'txtSatisFiyati
        '
        Me.txtSatisFiyati.Location = New System.Drawing.Point(126, 138)
        Me.txtSatisFiyati.Name = "txtSatisFiyati"
        Me.txtSatisFiyati.Size = New System.Drawing.Size(121, 20)
        Me.txtSatisFiyati.TabIndex = 9
        '
        'cmbxFirmaAdi
        '
        Me.cmbxFirmaAdi.FormattingEnabled = True
        Me.cmbxFirmaAdi.Items.AddRange(New Object() {"ATA A.Ş", "CCAN A.Ş", "Metro A.ş"})
        Me.cmbxFirmaAdi.Location = New System.Drawing.Point(126, 80)
        Me.cmbxFirmaAdi.Name = "cmbxFirmaAdi"
        Me.cmbxFirmaAdi.Size = New System.Drawing.Size(121, 21)
        Me.cmbxFirmaAdi.TabIndex = 10
        '
        'cmbxKategori
        '
        Me.cmbxKategori.FormattingEnabled = True
        Me.cmbxKategori.Location = New System.Drawing.Point(126, 164)
        Me.cmbxKategori.Name = "cmbxKategori"
        Me.cmbxKategori.Size = New System.Drawing.Size(121, 21)
        Me.cmbxKategori.TabIndex = 11
        '
        'btnKaydet
        '
        Me.btnKaydet.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnKaydet.ImageKey = "indir (4).jpg"
        Me.btnKaydet.ImageList = Me.ımageList1
        Me.btnKaydet.Location = New System.Drawing.Point(65, 216)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(87, 57)
        Me.btnKaydet.TabIndex = 12
        Me.btnKaydet.Text = "Kaydet"
        Me.btnKaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnKaydet.UseVisualStyleBackColor = False
        '
        'ımageList1
        '
        Me.ımageList1.ImageStream = CType(resources.GetObject("ımageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ımageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ımageList1.Images.SetKeyName(0, "close-icon-41.jpg")
        Me.ımageList1.Images.SetKeyName(1, "indir (4).jpg")
        '
        'btnKapat
        '
        Me.btnKapat.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnKapat.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnKapat.ImageKey = "close-icon-41.jpg"
        Me.btnKapat.ImageList = Me.ımageList1
        Me.btnKapat.Location = New System.Drawing.Point(212, 216)
        Me.btnKapat.Name = "btnKapat"
        Me.btnKapat.Size = New System.Drawing.Size(75, 57)
        Me.btnKapat.TabIndex = 13
        Me.btnKapat.Text = "Kapat"
        Me.btnKapat.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnKapat.UseVisualStyleBackColor = False
        '
        'ÜrünKayıt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(385, 364)
        Me.Controls.Add(Me.btnKapat)
        Me.Controls.Add(Me.btnKaydet)
        Me.Controls.Add(Me.cmbxKategori)
        Me.Controls.Add(Me.cmbxFirmaAdi)
        Me.Controls.Add(Me.txtSatisFiyati)
        Me.Controls.Add(Me.txtAlisFiyati)
        Me.Controls.Add(Me.txtUrunKodu)
        Me.Controls.Add(Me.txtUrunAdi)
        Me.Controls.Add(Me.lblKategori)
        Me.Controls.Add(Me.lblSatısFiyatı)
        Me.Controls.Add(Me.lblAlısFiyatı)
        Me.Controls.Add(Me.lblFirmaAdı)
        Me.Controls.Add(Me.lblUrunKodu)
        Me.Controls.Add(Me.lblUrunAdı)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Name = "ÜrünKayıt"
        Me.Text = "ÜrünKayıt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUrunAdı As Label
    Friend WithEvents lblUrunKodu As Label
    Friend WithEvents lblFirmaAdı As Label
    Friend WithEvents lblAlısFiyatı As Label
    Friend WithEvents lblSatısFiyatı As Label
    Friend WithEvents lblKategori As Label
    Friend WithEvents txtUrunAdi As TextBox
    Friend WithEvents txtUrunKodu As TextBox
    Friend WithEvents txtAlisFiyati As TextBox
    Friend WithEvents txtSatisFiyati As TextBox
    Friend WithEvents cmbxFirmaAdi As ComboBox
    Friend WithEvents cmbxKategori As ComboBox
    Friend WithEvents btnKaydet As Button
    Friend WithEvents ımageList1 As ImageList
    Friend WithEvents btnKapat As Button
End Class
