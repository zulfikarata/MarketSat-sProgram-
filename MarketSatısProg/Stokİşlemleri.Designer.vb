<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stokİşlemleri
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stokİşlemleri))
        Me.cmbxUrunler = New System.Windows.Forms.ComboBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnAra = New System.Windows.Forms.Button()
        Me.ımageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.dgStokİslem = New System.Windows.Forms.DataGridView()
        Me.UrunAdı = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Adet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirimFiyat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kdv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SatısFiyatı = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnSil = New System.Windows.Forms.Button()
        Me.btnKapat = New System.Windows.Forms.Button()
        Me.txtUrunAdi = New System.Windows.Forms.TextBox()
        Me.txtAdet = New System.Windows.Forms.TextBox()
        Me.btnEkle = New System.Windows.Forms.Button()
        Me.lblUrunAdı = New System.Windows.Forms.Label()
        Me.lblAdet = New System.Windows.Forms.Label()
        CType(Me.dgStokİslem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbxUrunler
        '
        Me.cmbxUrunler.FormattingEnabled = True
        Me.cmbxUrunler.Location = New System.Drawing.Point(269, 48)
        Me.cmbxUrunler.Name = "cmbxUrunler"
        Me.cmbxUrunler.Size = New System.Drawing.Size(121, 21)
        Me.cmbxUrunler.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(101, 48)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(130, 20)
        Me.TextBox1.TabIndex = 1
        '
        'btnAra
        '
        Me.btnAra.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAra.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAra.ImageKey = "indir (5).jpg"
        Me.btnAra.ImageList = Me.ımageList1
        Me.btnAra.Location = New System.Drawing.Point(440, 31)
        Me.btnAra.Name = "btnAra"
        Me.btnAra.Size = New System.Drawing.Size(75, 51)
        Me.btnAra.TabIndex = 2
        Me.btnAra.Text = "Ara"
        Me.btnAra.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAra.UseVisualStyleBackColor = False
        '
        'ımageList1
        '
        Me.ımageList1.ImageStream = CType(resources.GetObject("ımageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ımageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ımageList1.Images.SetKeyName(0, "close-icon-41.jpg")
        Me.ımageList1.Images.SetKeyName(1, "indir (6).jpg")
        Me.ımageList1.Images.SetKeyName(2, "indir (5).jpg")
        Me.ımageList1.Images.SetKeyName(3, "images.jpg")
        '
        'dgStokİslem
        '
        Me.dgStokİslem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgStokİslem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UrunAdı, Me.Adet, Me.BirimFiyat, Me.Kdv, Me.SatısFiyatı})
        Me.dgStokİslem.Location = New System.Drawing.Point(30, 106)
        Me.dgStokİslem.Name = "dgStokİslem"
        Me.dgStokİslem.Size = New System.Drawing.Size(535, 150)
        Me.dgStokİslem.TabIndex = 3
        '
        'UrunAdı
        '
        Me.UrunAdı.HeaderText = "Ürün Adı"
        Me.UrunAdı.Name = "UrunAdı"
        '
        'Adet
        '
        Me.Adet.HeaderText = "Adet"
        Me.Adet.Name = "Adet"
        '
        'BirimFiyat
        '
        Me.BirimFiyat.HeaderText = "Birim Fiyat"
        Me.BirimFiyat.Name = "BirimFiyat"
        '
        'Kdv
        '
        Me.Kdv.HeaderText = "Kdv"
        Me.Kdv.Name = "Kdv"
        '
        'SatısFiyatı
        '
        Me.SatısFiyatı.HeaderText = "Satış Fiyatı"
        Me.SatısFiyatı.Name = "SatısFiyatı"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.ImageKey = "indir (6).jpg"
        Me.Button2.ImageList = Me.ımageList1
        Me.Button2.Location = New System.Drawing.Point(269, 285)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 47)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Ekle"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnSil
        '
        Me.btnSil.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSil.ImageKey = "images.jpg"
        Me.btnSil.ImageList = Me.ımageList1
        Me.btnSil.Location = New System.Drawing.Point(368, 285)
        Me.btnSil.Name = "btnSil"
        Me.btnSil.Size = New System.Drawing.Size(75, 47)
        Me.btnSil.TabIndex = 5
        Me.btnSil.Text = "Sil"
        Me.btnSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSil.UseVisualStyleBackColor = False
        '
        'btnKapat
        '
        Me.btnKapat.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnKapat.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnKapat.ImageKey = "close-icon-41.jpg"
        Me.btnKapat.ImageList = Me.ımageList1
        Me.btnKapat.Location = New System.Drawing.Point(475, 285)
        Me.btnKapat.Name = "btnKapat"
        Me.btnKapat.Size = New System.Drawing.Size(75, 47)
        Me.btnKapat.TabIndex = 6
        Me.btnKapat.Text = "Kapat"
        Me.btnKapat.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnKapat.UseVisualStyleBackColor = False
        '
        'txtUrunAdi
        '
        Me.txtUrunAdi.Location = New System.Drawing.Point(668, 95)
        Me.txtUrunAdi.Name = "txtUrunAdi"
        Me.txtUrunAdi.Size = New System.Drawing.Size(100, 20)
        Me.txtUrunAdi.TabIndex = 7
        '
        'txtAdet
        '
        Me.txtAdet.Location = New System.Drawing.Point(668, 121)
        Me.txtAdet.Name = "txtAdet"
        Me.txtAdet.Size = New System.Drawing.Size(100, 20)
        Me.txtAdet.TabIndex = 8
        '
        'btnEkle
        '
        Me.btnEkle.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEkle.ImageKey = "indir (6).jpg"
        Me.btnEkle.ImageList = Me.ımageList1
        Me.btnEkle.Location = New System.Drawing.Point(681, 174)
        Me.btnEkle.Name = "btnEkle"
        Me.btnEkle.Size = New System.Drawing.Size(75, 48)
        Me.btnEkle.TabIndex = 9
        Me.btnEkle.Text = "Ekle"
        Me.btnEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEkle.UseVisualStyleBackColor = False
        '
        'lblUrunAdı
        '
        Me.lblUrunAdı.AutoSize = True
        Me.lblUrunAdı.Location = New System.Drawing.Point(596, 102)
        Me.lblUrunAdı.Name = "lblUrunAdı"
        Me.lblUrunAdı.Size = New System.Drawing.Size(56, 13)
        Me.lblUrunAdı.TabIndex = 10
        Me.lblUrunAdı.Text = "Ürün Adı"
        '
        'lblAdet
        '
        Me.lblAdet.AutoSize = True
        Me.lblAdet.Location = New System.Drawing.Point(619, 128)
        Me.lblAdet.Name = "lblAdet"
        Me.lblAdet.Size = New System.Drawing.Size(33, 13)
        Me.lblAdet.TabIndex = 11
        Me.lblAdet.Text = "Adet"
        '
        'Stokİşlemleri
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(808, 357)
        Me.Controls.Add(Me.lblAdet)
        Me.Controls.Add(Me.lblUrunAdı)
        Me.Controls.Add(Me.btnEkle)
        Me.Controls.Add(Me.txtAdet)
        Me.Controls.Add(Me.txtUrunAdi)
        Me.Controls.Add(Me.btnKapat)
        Me.Controls.Add(Me.btnSil)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dgStokİslem)
        Me.Controls.Add(Me.btnAra)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.cmbxUrunler)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Name = "Stokİşlemleri"
        Me.Text = "Stokİşlemleri"
        CType(Me.dgStokİslem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbxUrunler As ComboBox
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnAra As Button
    Friend WithEvents dgStokİslem As DataGridView
    Friend WithEvents ımageList1 As ImageList
    Friend WithEvents Button2 As Button
    Friend WithEvents btnSil As Button
    Friend WithEvents btnKapat As Button
    Friend WithEvents txtUrunAdi As TextBox
    Friend WithEvents txtAdet As TextBox
    Friend WithEvents btnEkle As Button
    Friend WithEvents lblUrunAdı As Label
    Friend WithEvents lblAdet As Label
    Friend WithEvents UrunAdı As DataGridViewTextBoxColumn
    Friend WithEvents Adet As DataGridViewTextBoxColumn
    Friend WithEvents BirimFiyat As DataGridViewTextBoxColumn
    Friend WithEvents Kdv As DataGridViewTextBoxColumn
    Friend WithEvents SatısFiyatı As DataGridViewTextBoxColumn
End Class
