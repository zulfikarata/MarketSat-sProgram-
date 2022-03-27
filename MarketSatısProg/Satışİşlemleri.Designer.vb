<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Satışİşlemleri
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Satışİşlemleri))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmbxKisiler = New System.Windows.Forms.ComboBox()
        Me.btnAra = New System.Windows.Forms.Button()
        Me.ımageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.dgSatısİslem = New System.Windows.Forms.DataGridView()
        Me.Müsteriadi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MüsteriSoyadı = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TcKimlik = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CepTel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EvTel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Adres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtFaturaNo = New System.Windows.Forms.TextBox()
        Me.txtMusteriAdi = New System.Windows.Forms.TextBox()
        Me.txtMusteriSoyadi = New System.Windows.Forms.TextBox()
        Me.txtTcKimlik = New System.Windows.Forms.TextBox()
        Me.txtSatisFiyatı = New System.Windows.Forms.TextBox()
        Me.cmbxUrunAdi = New System.Windows.Forms.ComboBox()
        Me.cmbxTarih = New System.Windows.Forms.ComboBox()
        Me.txtAdı = New System.Windows.Forms.TextBox()
        Me.txtToplamTutar = New System.Windows.Forms.TextBox()
        Me.txtKasaNo = New System.Windows.Forms.TextBox()
        Me.lblFaturaNo = New System.Windows.Forms.Label()
        Me.lblMusteriAdı = New System.Windows.Forms.Label()
        Me.lblMusteriSoyadı = New System.Windows.Forms.Label()
        Me.lblTckimlik = New System.Windows.Forms.Label()
        Me.lblUrunAdı = New System.Windows.Forms.Label()
        Me.lblSatısFiyatı = New System.Windows.Forms.Label()
        Me.lblAdet = New System.Windows.Forms.Label()
        Me.lblToplamTutar = New System.Windows.Forms.Label()
        Me.lblKasaNo = New System.Windows.Forms.Label()
        Me.lblTarih = New System.Windows.Forms.Label()
        Me.btnSatısYap = New System.Windows.Forms.Button()
        Me.btnKapat = New System.Windows.Forms.Button()
        CType(Me.dgSatısİslem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(86, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(139, 20)
        Me.TextBox1.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'cmbxKisiler
        '
        Me.cmbxKisiler.FormattingEnabled = True
        Me.cmbxKisiler.Location = New System.Drawing.Point(279, 21)
        Me.cmbxKisiler.Name = "cmbxKisiler"
        Me.cmbxKisiler.Size = New System.Drawing.Size(140, 21)
        Me.cmbxKisiler.TabIndex = 2
        '
        'btnAra
        '
        Me.btnAra.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAra.ImageKey = "indir (5).jpg"
        Me.btnAra.ImageList = Me.ımageList1
        Me.btnAra.Location = New System.Drawing.Point(465, 12)
        Me.btnAra.Name = "btnAra"
        Me.btnAra.Size = New System.Drawing.Size(79, 36)
        Me.btnAra.TabIndex = 3
        Me.btnAra.Text = "Ara"
        Me.btnAra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAra.UseVisualStyleBackColor = False
        '
        'ımageList1
        '
        Me.ımageList1.ImageStream = CType(resources.GetObject("ımageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ımageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ımageList1.Images.SetKeyName(0, "indir (1).png")
        Me.ımageList1.Images.SetKeyName(1, "indir (7).jpg")
        Me.ımageList1.Images.SetKeyName(2, "indir (5).jpg")
        '
        'dgSatısİslem
        '
        Me.dgSatısİslem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSatısİslem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Müsteriadi, Me.MüsteriSoyadı, Me.TcKimlik, Me.CepTel, Me.EvTel, Me.Adres})
        Me.dgSatısİslem.Location = New System.Drawing.Point(33, 65)
        Me.dgSatısİslem.Name = "dgSatısİslem"
        Me.dgSatısİslem.Size = New System.Drawing.Size(750, 150)
        Me.dgSatısİslem.TabIndex = 4
        '
        'Müsteriadi
        '
        Me.Müsteriadi.HeaderText = "Müşteri Adı"
        Me.Müsteriadi.Name = "Müsteriadi"
        '
        'MüsteriSoyadı
        '
        Me.MüsteriSoyadı.HeaderText = "Müşteri Soyadı"
        Me.MüsteriSoyadı.Name = "MüsteriSoyadı"
        '
        'TcKimlik
        '
        Me.TcKimlik.HeaderText = "Tc Kimlik"
        Me.TcKimlik.Name = "TcKimlik"
        '
        'CepTel
        '
        Me.CepTel.HeaderText = "Cep Tel"
        Me.CepTel.Name = "CepTel"
        '
        'EvTel
        '
        Me.EvTel.HeaderText = "Ev Tel"
        Me.EvTel.Name = "EvTel"
        '
        'Adres
        '
        Me.Adres.HeaderText = "Adres"
        Me.Adres.Name = "Adres"
        '
        'txtFaturaNo
        '
        Me.txtFaturaNo.Location = New System.Drawing.Point(110, 249)
        Me.txtFaturaNo.Name = "txtFaturaNo"
        Me.txtFaturaNo.Size = New System.Drawing.Size(137, 20)
        Me.txtFaturaNo.TabIndex = 5
        '
        'txtMusteriAdi
        '
        Me.txtMusteriAdi.Location = New System.Drawing.Point(110, 275)
        Me.txtMusteriAdi.Name = "txtMusteriAdi"
        Me.txtMusteriAdi.Size = New System.Drawing.Size(137, 20)
        Me.txtMusteriAdi.TabIndex = 6
        '
        'txtMusteriSoyadi
        '
        Me.txtMusteriSoyadi.Location = New System.Drawing.Point(110, 301)
        Me.txtMusteriSoyadi.Name = "txtMusteriSoyadi"
        Me.txtMusteriSoyadi.Size = New System.Drawing.Size(137, 20)
        Me.txtMusteriSoyadi.TabIndex = 7
        '
        'txtTcKimlik
        '
        Me.txtTcKimlik.Location = New System.Drawing.Point(110, 327)
        Me.txtTcKimlik.Name = "txtTcKimlik"
        Me.txtTcKimlik.Size = New System.Drawing.Size(137, 20)
        Me.txtTcKimlik.TabIndex = 8
        '
        'txtSatisFiyatı
        '
        Me.txtSatisFiyatı.Location = New System.Drawing.Point(110, 392)
        Me.txtSatisFiyatı.Name = "txtSatisFiyatı"
        Me.txtSatisFiyatı.Size = New System.Drawing.Size(137, 20)
        Me.txtSatisFiyatı.TabIndex = 9
        '
        'cmbxUrunAdi
        '
        Me.cmbxUrunAdi.FormattingEnabled = True
        Me.cmbxUrunAdi.Location = New System.Drawing.Point(110, 365)
        Me.cmbxUrunAdi.Name = "cmbxUrunAdi"
        Me.cmbxUrunAdi.Size = New System.Drawing.Size(137, 21)
        Me.cmbxUrunAdi.TabIndex = 10
        '
        'cmbxTarih
        '
        Me.cmbxTarih.FormattingEnabled = True
        Me.cmbxTarih.Items.AddRange(New Object() {"10.12.2019", "07.07.2019"})
        Me.cmbxTarih.Location = New System.Drawing.Point(390, 326)
        Me.cmbxTarih.Name = "cmbxTarih"
        Me.cmbxTarih.Size = New System.Drawing.Size(140, 21)
        Me.cmbxTarih.TabIndex = 11
        '
        'txtAdı
        '
        Me.txtAdı.Location = New System.Drawing.Point(390, 249)
        Me.txtAdı.Name = "txtAdı"
        Me.txtAdı.Size = New System.Drawing.Size(140, 20)
        Me.txtAdı.TabIndex = 12
        '
        'txtToplamTutar
        '
        Me.txtToplamTutar.Location = New System.Drawing.Point(390, 275)
        Me.txtToplamTutar.Name = "txtToplamTutar"
        Me.txtToplamTutar.Size = New System.Drawing.Size(140, 20)
        Me.txtToplamTutar.TabIndex = 13
        '
        'txtKasaNo
        '
        Me.txtKasaNo.Location = New System.Drawing.Point(390, 300)
        Me.txtKasaNo.Name = "txtKasaNo"
        Me.txtKasaNo.Size = New System.Drawing.Size(140, 20)
        Me.txtKasaNo.TabIndex = 14
        '
        'lblFaturaNo
        '
        Me.lblFaturaNo.AutoSize = True
        Me.lblFaturaNo.Location = New System.Drawing.Point(35, 256)
        Me.lblFaturaNo.Name = "lblFaturaNo"
        Me.lblFaturaNo.Size = New System.Drawing.Size(63, 13)
        Me.lblFaturaNo.TabIndex = 15
        Me.lblFaturaNo.Text = "Fatura No"
        '
        'lblMusteriAdı
        '
        Me.lblMusteriAdı.AutoSize = True
        Me.lblMusteriAdı.Location = New System.Drawing.Point(28, 282)
        Me.lblMusteriAdı.Name = "lblMusteriAdı"
        Me.lblMusteriAdı.Size = New System.Drawing.Size(70, 13)
        Me.lblMusteriAdı.TabIndex = 16
        Me.lblMusteriAdı.Text = "Müşteri Adı"
        '
        'lblMusteriSoyadı
        '
        Me.lblMusteriSoyadı.AutoSize = True
        Me.lblMusteriSoyadı.Location = New System.Drawing.Point(8, 308)
        Me.lblMusteriSoyadı.Name = "lblMusteriSoyadı"
        Me.lblMusteriSoyadı.Size = New System.Drawing.Size(90, 13)
        Me.lblMusteriSoyadı.TabIndex = 17
        Me.lblMusteriSoyadı.Text = "Müşteri Soyadı"
        '
        'lblTckimlik
        '
        Me.lblTckimlik.AutoSize = True
        Me.lblTckimlik.Location = New System.Drawing.Point(39, 334)
        Me.lblTckimlik.Name = "lblTckimlik"
        Me.lblTckimlik.Size = New System.Drawing.Size(59, 13)
        Me.lblTckimlik.TabIndex = 18
        Me.lblTckimlik.Text = "Tc Kimlik"
        '
        'lblUrunAdı
        '
        Me.lblUrunAdı.AutoSize = True
        Me.lblUrunAdı.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblUrunAdı.Location = New System.Drawing.Point(42, 373)
        Me.lblUrunAdı.Name = "lblUrunAdı"
        Me.lblUrunAdı.Size = New System.Drawing.Size(56, 13)
        Me.lblUrunAdı.TabIndex = 19
        Me.lblUrunAdı.Text = "Ürün Adı"
        '
        'lblSatısFiyatı
        '
        Me.lblSatısFiyatı.AutoSize = True
        Me.lblSatısFiyatı.Location = New System.Drawing.Point(29, 399)
        Me.lblSatısFiyatı.Name = "lblSatısFiyatı"
        Me.lblSatısFiyatı.Size = New System.Drawing.Size(69, 13)
        Me.lblSatısFiyatı.TabIndex = 20
        Me.lblSatısFiyatı.Text = "Satış Fiyatı"
        '
        'lblAdet
        '
        Me.lblAdet.AutoSize = True
        Me.lblAdet.Location = New System.Drawing.Point(336, 252)
        Me.lblAdet.Name = "lblAdet"
        Me.lblAdet.Size = New System.Drawing.Size(33, 13)
        Me.lblAdet.TabIndex = 21
        Me.lblAdet.Text = "Adet"
        '
        'lblToplamTutar
        '
        Me.lblToplamTutar.AutoSize = True
        Me.lblToplamTutar.Location = New System.Drawing.Point(287, 278)
        Me.lblToplamTutar.Name = "lblToplamTutar"
        Me.lblToplamTutar.Size = New System.Drawing.Size(82, 13)
        Me.lblToplamTutar.TabIndex = 22
        Me.lblToplamTutar.Text = "Toplam Tutar"
        '
        'lblKasaNo
        '
        Me.lblKasaNo.AutoSize = True
        Me.lblKasaNo.Location = New System.Drawing.Point(316, 307)
        Me.lblKasaNo.Name = "lblKasaNo"
        Me.lblKasaNo.Size = New System.Drawing.Size(53, 13)
        Me.lblKasaNo.TabIndex = 23
        Me.lblKasaNo.Text = "Kasa no"
        '
        'lblTarih
        '
        Me.lblTarih.AutoSize = True
        Me.lblTarih.Location = New System.Drawing.Point(333, 334)
        Me.lblTarih.Name = "lblTarih"
        Me.lblTarih.Size = New System.Drawing.Size(36, 13)
        Me.lblTarih.TabIndex = 24
        Me.lblTarih.Text = "Tarih"
        '
        'btnSatısYap
        '
        Me.btnSatısYap.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSatısYap.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSatısYap.ImageKey = "indir (1).png"
        Me.btnSatısYap.ImageList = Me.ımageList1
        Me.btnSatısYap.Location = New System.Drawing.Point(669, 301)
        Me.btnSatısYap.Name = "btnSatısYap"
        Me.btnSatısYap.Size = New System.Drawing.Size(75, 63)
        Me.btnSatısYap.TabIndex = 25
        Me.btnSatısYap.Text = "Satış Yap"
        Me.btnSatısYap.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSatısYap.UseVisualStyleBackColor = False
        '
        'btnKapat
        '
        Me.btnKapat.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnKapat.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnKapat.ImageKey = "indir (7).jpg"
        Me.btnKapat.ImageList = Me.ımageList1
        Me.btnKapat.Location = New System.Drawing.Point(778, 301)
        Me.btnKapat.Name = "btnKapat"
        Me.btnKapat.Size = New System.Drawing.Size(75, 63)
        Me.btnKapat.TabIndex = 26
        Me.btnKapat.Text = "Kapat"
        Me.btnKapat.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnKapat.UseVisualStyleBackColor = False
        '
        'Satışİşlemleri
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(994, 424)
        Me.Controls.Add(Me.btnKapat)
        Me.Controls.Add(Me.btnSatısYap)
        Me.Controls.Add(Me.lblTarih)
        Me.Controls.Add(Me.lblKasaNo)
        Me.Controls.Add(Me.lblToplamTutar)
        Me.Controls.Add(Me.lblAdet)
        Me.Controls.Add(Me.lblSatısFiyatı)
        Me.Controls.Add(Me.lblUrunAdı)
        Me.Controls.Add(Me.lblTckimlik)
        Me.Controls.Add(Me.lblMusteriSoyadı)
        Me.Controls.Add(Me.lblMusteriAdı)
        Me.Controls.Add(Me.lblFaturaNo)
        Me.Controls.Add(Me.txtKasaNo)
        Me.Controls.Add(Me.txtToplamTutar)
        Me.Controls.Add(Me.txtAdı)
        Me.Controls.Add(Me.cmbxTarih)
        Me.Controls.Add(Me.cmbxUrunAdi)
        Me.Controls.Add(Me.txtSatisFiyatı)
        Me.Controls.Add(Me.txtTcKimlik)
        Me.Controls.Add(Me.txtMusteriSoyadi)
        Me.Controls.Add(Me.txtMusteriAdi)
        Me.Controls.Add(Me.txtFaturaNo)
        Me.Controls.Add(Me.dgSatısİslem)
        Me.Controls.Add(Me.btnAra)
        Me.Controls.Add(Me.cmbxKisiler)
        Me.Controls.Add(Me.TextBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Name = "Satışİşlemleri"
        Me.Text = "Satışİşlemleri"
        CType(Me.dgSatısİslem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents cmbxKisiler As ComboBox
    Friend WithEvents btnAra As Button
    Friend WithEvents dgSatısİslem As DataGridView
    Friend WithEvents ımageList1 As ImageList
    Friend WithEvents Müsteriadi As DataGridViewTextBoxColumn
    Friend WithEvents MüsteriSoyadı As DataGridViewTextBoxColumn
    Friend WithEvents TcKimlik As DataGridViewTextBoxColumn
    Friend WithEvents CepTel As DataGridViewTextBoxColumn
    Friend WithEvents EvTel As DataGridViewTextBoxColumn
    Friend WithEvents Adres As DataGridViewTextBoxColumn
    Friend WithEvents txtFaturaNo As TextBox
    Friend WithEvents txtMusteriAdi As TextBox
    Friend WithEvents txtMusteriSoyadi As TextBox
    Friend WithEvents txtTcKimlik As TextBox
    Friend WithEvents txtSatisFiyatı As TextBox
    Friend WithEvents cmbxUrunAdi As ComboBox
    Friend WithEvents cmbxTarih As ComboBox
    Friend WithEvents txtAdı As TextBox
    Friend WithEvents txtToplamTutar As TextBox
    Friend WithEvents txtKasaNo As TextBox
    Friend WithEvents lblFaturaNo As Label
    Friend WithEvents lblMusteriAdı As Label
    Friend WithEvents lblMusteriSoyadı As Label
    Friend WithEvents lblTckimlik As Label
    Friend WithEvents lblUrunAdı As Label
    Friend WithEvents lblSatısFiyatı As Label
    Friend WithEvents lblAdet As Label
    Friend WithEvents lblToplamTutar As Label
    Friend WithEvents lblKasaNo As Label
    Friend WithEvents lblTarih As Label
    Friend WithEvents btnSatısYap As Button
    Friend WithEvents btnKapat As Button
End Class
