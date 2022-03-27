<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KasiyerEkleme
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KasiyerEkleme))
        Me.lblAdi = New System.Windows.Forms.Label()
        Me.lblSoyadı = New System.Windows.Forms.Label()
        Me.lblTcKimlik = New System.Windows.Forms.Label()
        Me.lblCeptel = New System.Windows.Forms.Label()
        Me.lblEvTel = New System.Windows.Forms.Label()
        Me.lblAdres = New System.Windows.Forms.Label()
        Me.lblMaas = New System.Windows.Forms.Label()
        Me.lblGorevliOldKasa = New System.Windows.Forms.Label()
        Me.lblGorevBastarih = New System.Windows.Forms.Label()
        Me.lblGorevBitimTarih = New System.Windows.Forms.Label()
        Me.cmbxGorevBasTarih = New System.Windows.Forms.ComboBox()
        Me.cmbxGorevBitimTarih = New System.Windows.Forms.ComboBox()
        Me.txtAdı = New System.Windows.Forms.TextBox()
        Me.txtSoyadi = New System.Windows.Forms.TextBox()
        Me.txtTcKimlik = New System.Windows.Forms.TextBox()
        Me.txtCepTel = New System.Windows.Forms.TextBox()
        Me.txtEvTel = New System.Windows.Forms.TextBox()
        Me.txtAdres = New System.Windows.Forms.TextBox()
        Me.txtMaas = New System.Windows.Forms.TextBox()
        Me.txtGorevliOldKasa = New System.Windows.Forms.TextBox()
        Me.ımageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnKaydet = New System.Windows.Forms.Button()
        Me.btnKapat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAdi
        '
        Me.lblAdi.AutoSize = True
        Me.lblAdi.Location = New System.Drawing.Point(136, 76)
        Me.lblAdi.Name = "lblAdi"
        Me.lblAdi.Size = New System.Drawing.Size(25, 13)
        Me.lblAdi.TabIndex = 0
        Me.lblAdi.Text = "Adı"
        '
        'lblSoyadı
        '
        Me.lblSoyadı.AutoSize = True
        Me.lblSoyadı.Location = New System.Drawing.Point(116, 109)
        Me.lblSoyadı.Name = "lblSoyadı"
        Me.lblSoyadı.Size = New System.Drawing.Size(45, 13)
        Me.lblSoyadı.TabIndex = 1
        Me.lblSoyadı.Text = "Soyadı"
        '
        'lblTcKimlik
        '
        Me.lblTcKimlik.AutoSize = True
        Me.lblTcKimlik.Location = New System.Drawing.Point(102, 137)
        Me.lblTcKimlik.Name = "lblTcKimlik"
        Me.lblTcKimlik.Size = New System.Drawing.Size(59, 13)
        Me.lblTcKimlik.TabIndex = 2
        Me.lblTcKimlik.Text = "Tc Kimlik"
        '
        'lblCeptel
        '
        Me.lblCeptel.AutoSize = True
        Me.lblCeptel.Location = New System.Drawing.Point(110, 164)
        Me.lblCeptel.Name = "lblCeptel"
        Me.lblCeptel.Size = New System.Drawing.Size(51, 13)
        Me.lblCeptel.TabIndex = 3
        Me.lblCeptel.Text = "Cep Tel"
        '
        'lblEvTel
        '
        Me.lblEvTel.AutoSize = True
        Me.lblEvTel.Location = New System.Drawing.Point(117, 196)
        Me.lblEvTel.Name = "lblEvTel"
        Me.lblEvTel.Size = New System.Drawing.Size(44, 13)
        Me.lblEvTel.TabIndex = 4
        Me.lblEvTel.Text = "Ev Tel"
        '
        'lblAdres
        '
        Me.lblAdres.AutoSize = True
        Me.lblAdres.Location = New System.Drawing.Point(122, 222)
        Me.lblAdres.Name = "lblAdres"
        Me.lblAdres.Size = New System.Drawing.Size(39, 13)
        Me.lblAdres.TabIndex = 5
        Me.lblAdres.Text = "Adres"
        '
        'lblMaas
        '
        Me.lblMaas.AutoSize = True
        Me.lblMaas.Location = New System.Drawing.Point(124, 248)
        Me.lblMaas.Name = "lblMaas"
        Me.lblMaas.Size = New System.Drawing.Size(37, 13)
        Me.lblMaas.TabIndex = 6
        Me.lblMaas.Text = "Maaş"
        '
        'lblGorevliOldKasa
        '
        Me.lblGorevliOldKasa.AutoSize = True
        Me.lblGorevliOldKasa.Location = New System.Drawing.Point(57, 276)
        Me.lblGorevliOldKasa.Name = "lblGorevliOldKasa"
        Me.lblGorevliOldKasa.Size = New System.Drawing.Size(104, 13)
        Me.lblGorevliOldKasa.TabIndex = 7
        Me.lblGorevliOldKasa.Text = "Görevli old. Kasa"
        '
        'lblGorevBastarih
        '
        Me.lblGorevBastarih.AutoSize = True
        Me.lblGorevBastarih.Location = New System.Drawing.Point(58, 299)
        Me.lblGorevBastarih.Name = "lblGorevBastarih"
        Me.lblGorevBastarih.Size = New System.Drawing.Size(103, 13)
        Me.lblGorevBastarih.TabIndex = 8
        Me.lblGorevBastarih.Text = "Görev Baş. Tarih"
        '
        'lblGorevBitimTarih
        '
        Me.lblGorevBitimTarih.AutoSize = True
        Me.lblGorevBitimTarih.Location = New System.Drawing.Point(53, 322)
        Me.lblGorevBitimTarih.Name = "lblGorevBitimTarih"
        Me.lblGorevBitimTarih.Size = New System.Drawing.Size(108, 13)
        Me.lblGorevBitimTarih.TabIndex = 9
        Me.lblGorevBitimTarih.Text = "Görev Bitim Tarihi"
        '
        'cmbxGorevBasTarih
        '
        Me.cmbxGorevBasTarih.FormattingEnabled = True
        Me.cmbxGorevBasTarih.Location = New System.Drawing.Point(179, 295)
        Me.cmbxGorevBasTarih.Name = "cmbxGorevBasTarih"
        Me.cmbxGorevBasTarih.Size = New System.Drawing.Size(121, 21)
        Me.cmbxGorevBasTarih.TabIndex = 10
        '
        'cmbxGorevBitimTarih
        '
        Me.cmbxGorevBitimTarih.FormattingEnabled = True
        Me.cmbxGorevBitimTarih.Location = New System.Drawing.Point(179, 322)
        Me.cmbxGorevBitimTarih.Name = "cmbxGorevBitimTarih"
        Me.cmbxGorevBitimTarih.Size = New System.Drawing.Size(121, 21)
        Me.cmbxGorevBitimTarih.TabIndex = 11
        '
        'txtAdı
        '
        Me.txtAdı.Location = New System.Drawing.Point(179, 73)
        Me.txtAdı.Name = "txtAdı"
        Me.txtAdı.Size = New System.Drawing.Size(121, 20)
        Me.txtAdı.TabIndex = 12
        '
        'txtSoyadi
        '
        Me.txtSoyadi.Location = New System.Drawing.Point(179, 104)
        Me.txtSoyadi.Name = "txtSoyadi"
        Me.txtSoyadi.Size = New System.Drawing.Size(121, 20)
        Me.txtSoyadi.TabIndex = 13
        '
        'txtTcKimlik
        '
        Me.txtTcKimlik.Location = New System.Drawing.Point(179, 130)
        Me.txtTcKimlik.Name = "txtTcKimlik"
        Me.txtTcKimlik.Size = New System.Drawing.Size(121, 20)
        Me.txtTcKimlik.TabIndex = 14
        '
        'txtCepTel
        '
        Me.txtCepTel.Location = New System.Drawing.Point(179, 157)
        Me.txtCepTel.Name = "txtCepTel"
        Me.txtCepTel.Size = New System.Drawing.Size(121, 20)
        Me.txtCepTel.TabIndex = 15
        '
        'txtEvTel
        '
        Me.txtEvTel.Location = New System.Drawing.Point(179, 189)
        Me.txtEvTel.Name = "txtEvTel"
        Me.txtEvTel.Size = New System.Drawing.Size(121, 20)
        Me.txtEvTel.TabIndex = 16
        '
        'txtAdres
        '
        Me.txtAdres.Location = New System.Drawing.Point(179, 215)
        Me.txtAdres.Name = "txtAdres"
        Me.txtAdres.Size = New System.Drawing.Size(121, 20)
        Me.txtAdres.TabIndex = 17
        '
        'txtMaas
        '
        Me.txtMaas.Location = New System.Drawing.Point(179, 241)
        Me.txtMaas.Name = "txtMaas"
        Me.txtMaas.Size = New System.Drawing.Size(121, 20)
        Me.txtMaas.TabIndex = 18
        '
        'txtGorevliOldKasa
        '
        Me.txtGorevliOldKasa.Location = New System.Drawing.Point(179, 269)
        Me.txtGorevliOldKasa.Name = "txtGorevliOldKasa"
        Me.txtGorevliOldKasa.Size = New System.Drawing.Size(121, 20)
        Me.txtGorevliOldKasa.TabIndex = 19
        '
        'ımageList1
        '
        Me.ımageList1.ImageStream = CType(resources.GetObject("ımageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ımageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ımageList1.Images.SetKeyName(0, "images (1).jpg")
        Me.ımageList1.Images.SetKeyName(1, "indir (4).jpg")
        Me.ımageList1.Images.SetKeyName(2, "close-icon-41.jpg")
        '
        'btnKaydet
        '
        Me.btnKaydet.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnKaydet.ImageKey = "indir (4).jpg"
        Me.btnKaydet.ImageList = Me.ımageList1
        Me.btnKaydet.Location = New System.Drawing.Point(139, 365)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(75, 54)
        Me.btnKaydet.TabIndex = 20
        Me.btnKaydet.Text = "Kaydet"
        Me.btnKaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnKaydet.UseVisualStyleBackColor = False
        '
        'btnKapat
        '
        Me.btnKapat.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnKapat.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnKapat.ImageKey = "close-icon-41.jpg"
        Me.btnKapat.ImageList = Me.ımageList1
        Me.btnKapat.Location = New System.Drawing.Point(234, 365)
        Me.btnKapat.Name = "btnKapat"
        Me.btnKapat.Size = New System.Drawing.Size(75, 54)
        Me.btnKapat.TabIndex = 21
        Me.btnKapat.Text = "Kapat"
        Me.btnKapat.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnKapat.UseVisualStyleBackColor = False
        '
        'KasiyerEkleme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(428, 447)
        Me.Controls.Add(Me.btnKapat)
        Me.Controls.Add(Me.btnKaydet)
        Me.Controls.Add(Me.txtGorevliOldKasa)
        Me.Controls.Add(Me.txtMaas)
        Me.Controls.Add(Me.txtAdres)
        Me.Controls.Add(Me.txtEvTel)
        Me.Controls.Add(Me.txtCepTel)
        Me.Controls.Add(Me.txtTcKimlik)
        Me.Controls.Add(Me.txtSoyadi)
        Me.Controls.Add(Me.txtAdı)
        Me.Controls.Add(Me.cmbxGorevBitimTarih)
        Me.Controls.Add(Me.cmbxGorevBasTarih)
        Me.Controls.Add(Me.lblGorevBitimTarih)
        Me.Controls.Add(Me.lblGorevBastarih)
        Me.Controls.Add(Me.lblGorevliOldKasa)
        Me.Controls.Add(Me.lblMaas)
        Me.Controls.Add(Me.lblAdres)
        Me.Controls.Add(Me.lblEvTel)
        Me.Controls.Add(Me.lblCeptel)
        Me.Controls.Add(Me.lblTcKimlik)
        Me.Controls.Add(Me.lblSoyadı)
        Me.Controls.Add(Me.lblAdi)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Name = "KasiyerEkleme"
        Me.Text = "KasiyerEkleme"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAdi As Label
    Friend WithEvents lblSoyadı As Label
    Friend WithEvents lblTcKimlik As Label
    Friend WithEvents lblCeptel As Label
    Friend WithEvents lblEvTel As Label
    Friend WithEvents lblAdres As Label
    Friend WithEvents lblMaas As Label
    Friend WithEvents lblGorevliOldKasa As Label
    Friend WithEvents lblGorevBastarih As Label
    Friend WithEvents lblGorevBitimTarih As Label
    Friend WithEvents cmbxGorevBasTarih As ComboBox
    Friend WithEvents cmbxGorevBitimTarih As ComboBox
    Friend WithEvents txtAdı As TextBox
    Friend WithEvents txtSoyadi As TextBox
    Friend WithEvents txtTcKimlik As TextBox
    Friend WithEvents txtCepTel As TextBox
    Friend WithEvents txtEvTel As TextBox
    Friend WithEvents txtAdres As TextBox
    Friend WithEvents txtMaas As TextBox
    Friend WithEvents txtGorevliOldKasa As TextBox
    Friend WithEvents ımageList1 As ImageList
    Friend WithEvents btnKaydet As Button
    Friend WithEvents btnKapat As Button
End Class
