<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ürünİşlemleri
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ürünİşlemleri))
        Me.txtUrunler = New System.Windows.Forms.TextBox()
        Me.cmbxUrunler = New System.Windows.Forms.ComboBox()
        Me.btnAra = New System.Windows.Forms.Button()
        Me.ımageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.dgUrunIslem = New System.Windows.Forms.DataGridView()
        Me.UrunAdı = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UrunKodu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirmaAdi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlisFiyatı = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SatısFiyati = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kategori = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEkle = New System.Windows.Forms.Button()
        Me.btnSil = New System.Windows.Forms.Button()
        Me.btnKapat = New System.Windows.Forms.Button()
        CType(Me.dgUrunIslem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUrunler
        '
        Me.txtUrunler.Location = New System.Drawing.Point(282, 26)
        Me.txtUrunler.Name = "txtUrunler"
        Me.txtUrunler.Size = New System.Drawing.Size(116, 20)
        Me.txtUrunler.TabIndex = 0
        '
        'cmbxUrunler
        '
        Me.cmbxUrunler.FormattingEnabled = True
        Me.cmbxUrunler.Items.AddRange(New Object() {"Kola", "Fanta", "Yoğurt", "Peynir", "Ekmek"})
        Me.cmbxUrunler.Location = New System.Drawing.Point(453, 25)
        Me.cmbxUrunler.Name = "cmbxUrunler"
        Me.cmbxUrunler.Size = New System.Drawing.Size(140, 21)
        Me.cmbxUrunler.TabIndex = 1
        '
        'btnAra
        '
        Me.btnAra.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAra.ImageKey = "indir (5).jpg"
        Me.btnAra.ImageList = Me.ımageList1
        Me.btnAra.Location = New System.Drawing.Point(645, 11)
        Me.btnAra.Name = "btnAra"
        Me.btnAra.Size = New System.Drawing.Size(70, 46)
        Me.btnAra.TabIndex = 2
        Me.btnAra.Text = "Ara"
        Me.btnAra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAra.UseVisualStyleBackColor = False
        '
        'ımageList1
        '
        Me.ımageList1.ImageStream = CType(resources.GetObject("ımageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ımageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ımageList1.Images.SetKeyName(0, "indir (5).jpg")
        Me.ımageList1.Images.SetKeyName(1, "indir (6).jpg")
        Me.ımageList1.Images.SetKeyName(2, "images.jpg")
        Me.ımageList1.Images.SetKeyName(3, "close-icon-41.jpg")
        '
        'dgUrunIslem
        '
        Me.dgUrunIslem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUrunIslem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UrunAdı, Me.UrunKodu, Me.FirmaAdi, Me.AlisFiyatı, Me.SatısFiyati, Me.Kategori})
        Me.dgUrunIslem.Location = New System.Drawing.Point(146, 73)
        Me.dgUrunIslem.Name = "dgUrunIslem"
        Me.dgUrunIslem.Size = New System.Drawing.Size(629, 191)
        Me.dgUrunIslem.TabIndex = 3
        '
        'UrunAdı
        '
        Me.UrunAdı.HeaderText = "Ürün Adı"
        Me.UrunAdı.Name = "UrunAdı"
        '
        'UrunKodu
        '
        Me.UrunKodu.HeaderText = "Ürün Kodu"
        Me.UrunKodu.Name = "UrunKodu"
        '
        'FirmaAdi
        '
        Me.FirmaAdi.HeaderText = "Firma Adı"
        Me.FirmaAdi.Name = "FirmaAdi"
        '
        'AlisFiyatı
        '
        Me.AlisFiyatı.HeaderText = "Alış Fiyatı"
        Me.AlisFiyatı.Name = "AlisFiyatı"
        '
        'SatısFiyati
        '
        Me.SatısFiyati.HeaderText = "Satış Fiyatı"
        Me.SatısFiyati.Name = "SatısFiyati"
        '
        'Kategori
        '
        Me.Kategori.HeaderText = "Kategori"
        Me.Kategori.Name = "Kategori"
        '
        'btnEkle
        '
        Me.btnEkle.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEkle.ImageKey = "indir (6).jpg"
        Me.btnEkle.ImageList = Me.ımageList1
        Me.btnEkle.Location = New System.Drawing.Point(464, 295)
        Me.btnEkle.Name = "btnEkle"
        Me.btnEkle.Size = New System.Drawing.Size(91, 50)
        Me.btnEkle.TabIndex = 4
        Me.btnEkle.Text = "Ekle"
        Me.btnEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEkle.UseVisualStyleBackColor = False
        '
        'btnSil
        '
        Me.btnSil.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSil.ImageKey = "images.jpg"
        Me.btnSil.ImageList = Me.ımageList1
        Me.btnSil.Location = New System.Drawing.Point(589, 295)
        Me.btnSil.Name = "btnSil"
        Me.btnSil.Size = New System.Drawing.Size(75, 50)
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
        Me.btnKapat.Location = New System.Drawing.Point(700, 295)
        Me.btnKapat.Name = "btnKapat"
        Me.btnKapat.Size = New System.Drawing.Size(75, 50)
        Me.btnKapat.TabIndex = 6
        Me.btnKapat.Text = "Kapat"
        Me.btnKapat.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnKapat.UseVisualStyleBackColor = False
        '
        'Ürünİşlemleri
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(917, 380)
        Me.Controls.Add(Me.btnKapat)
        Me.Controls.Add(Me.btnSil)
        Me.Controls.Add(Me.btnEkle)
        Me.Controls.Add(Me.dgUrunIslem)
        Me.Controls.Add(Me.btnAra)
        Me.Controls.Add(Me.cmbxUrunler)
        Me.Controls.Add(Me.txtUrunler)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Name = "Ürünİşlemleri"
        Me.Text = "Ürünİşlemleri"
        CType(Me.dgUrunIslem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUrunler As TextBox
    Friend WithEvents cmbxUrunler As ComboBox
    Friend WithEvents btnAra As Button
    Friend WithEvents dgUrunIslem As DataGridView
    Friend WithEvents ımageList1 As ImageList
    Friend WithEvents UrunAdı As DataGridViewTextBoxColumn
    Friend WithEvents UrunKodu As DataGridViewTextBoxColumn
    Friend WithEvents FirmaAdi As DataGridViewTextBoxColumn
    Friend WithEvents AlisFiyatı As DataGridViewTextBoxColumn
    Friend WithEvents SatısFiyati As DataGridViewTextBoxColumn
    Friend WithEvents Kategori As DataGridViewTextBoxColumn
    Friend WithEvents btnEkle As Button
    Friend WithEvents btnSil As Button
    Friend WithEvents btnKapat As Button
End Class
