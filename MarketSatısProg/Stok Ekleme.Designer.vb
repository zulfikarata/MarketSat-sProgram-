<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stok_Ekleme
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stok_Ekleme))
        Me.cmbxUrunAdi = New System.Windows.Forms.ComboBox()
        Me.txtBirimFiyat = New System.Windows.Forms.TextBox()
        Me.txtKdv = New System.Windows.Forms.TextBox()
        Me.txtAdet = New System.Windows.Forms.TextBox()
        Me.lblUrunAdı = New System.Windows.Forms.Label()
        Me.lblBirimFiyat = New System.Windows.Forms.Label()
        Me.lblKdv = New System.Windows.Forms.Label()
        Me.lblAdet = New System.Windows.Forms.Label()
        Me.btnKaydet = New System.Windows.Forms.Button()
        Me.ımageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnKapat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbxUrunAdi
        '
        Me.cmbxUrunAdi.FormattingEnabled = True
        Me.cmbxUrunAdi.Location = New System.Drawing.Point(117, 43)
        Me.cmbxUrunAdi.Name = "cmbxUrunAdi"
        Me.cmbxUrunAdi.Size = New System.Drawing.Size(121, 21)
        Me.cmbxUrunAdi.TabIndex = 0
        '
        'txtBirimFiyat
        '
        Me.txtBirimFiyat.Location = New System.Drawing.Point(117, 70)
        Me.txtBirimFiyat.Name = "txtBirimFiyat"
        Me.txtBirimFiyat.Size = New System.Drawing.Size(121, 20)
        Me.txtBirimFiyat.TabIndex = 1
        '
        'txtKdv
        '
        Me.txtKdv.Location = New System.Drawing.Point(117, 96)
        Me.txtKdv.Name = "txtKdv"
        Me.txtKdv.Size = New System.Drawing.Size(121, 20)
        Me.txtKdv.TabIndex = 2
        '
        'txtAdet
        '
        Me.txtAdet.Location = New System.Drawing.Point(117, 122)
        Me.txtAdet.Name = "txtAdet"
        Me.txtAdet.Size = New System.Drawing.Size(121, 20)
        Me.txtAdet.TabIndex = 3
        '
        'lblUrunAdı
        '
        Me.lblUrunAdı.AutoSize = True
        Me.lblUrunAdı.Location = New System.Drawing.Point(38, 51)
        Me.lblUrunAdı.Name = "lblUrunAdı"
        Me.lblUrunAdı.Size = New System.Drawing.Size(56, 13)
        Me.lblUrunAdı.TabIndex = 4
        Me.lblUrunAdı.Text = "Ürün Adı"
        '
        'lblBirimFiyat
        '
        Me.lblBirimFiyat.AutoSize = True
        Me.lblBirimFiyat.Location = New System.Drawing.Point(29, 77)
        Me.lblBirimFiyat.Name = "lblBirimFiyat"
        Me.lblBirimFiyat.Size = New System.Drawing.Size(65, 13)
        Me.lblBirimFiyat.TabIndex = 5
        Me.lblBirimFiyat.Text = "Birim Fiyat"
        '
        'lblKdv
        '
        Me.lblKdv.AutoSize = True
        Me.lblKdv.Location = New System.Drawing.Point(65, 103)
        Me.lblKdv.Name = "lblKdv"
        Me.lblKdv.Size = New System.Drawing.Size(29, 13)
        Me.lblKdv.TabIndex = 6
        Me.lblKdv.Text = "Kdv"
        '
        'lblAdet
        '
        Me.lblAdet.AutoSize = True
        Me.lblAdet.Location = New System.Drawing.Point(61, 129)
        Me.lblAdet.Name = "lblAdet"
        Me.lblAdet.Size = New System.Drawing.Size(33, 13)
        Me.lblAdet.TabIndex = 7
        Me.lblAdet.Text = "Adet"
        '
        'btnKaydet
        '
        Me.btnKaydet.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnKaydet.ImageKey = "indir (4).jpg"
        Me.btnKaydet.ImageList = Me.ımageList1
        Me.btnKaydet.Location = New System.Drawing.Point(86, 174)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(75, 59)
        Me.btnKaydet.TabIndex = 8
        Me.btnKaydet.Text = "Kaydet"
        Me.btnKaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnKaydet.UseVisualStyleBackColor = False
        '
        'ımageList1
        '
        Me.ımageList1.ImageStream = CType(resources.GetObject("ımageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ımageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ımageList1.Images.SetKeyName(0, "indir (4).jpg")
        Me.ımageList1.Images.SetKeyName(1, "close-icon-41.jpg")
        '
        'btnKapat
        '
        Me.btnKapat.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnKapat.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnKapat.ImageKey = "close-icon-41.jpg"
        Me.btnKapat.ImageList = Me.ımageList1
        Me.btnKapat.Location = New System.Drawing.Point(182, 174)
        Me.btnKapat.Name = "btnKapat"
        Me.btnKapat.Size = New System.Drawing.Size(75, 59)
        Me.btnKapat.TabIndex = 9
        Me.btnKapat.Text = "Kapat"
        Me.btnKapat.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnKapat.UseVisualStyleBackColor = False
        '
        'Stok_Ekleme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(312, 286)
        Me.Controls.Add(Me.btnKapat)
        Me.Controls.Add(Me.btnKaydet)
        Me.Controls.Add(Me.lblAdet)
        Me.Controls.Add(Me.lblKdv)
        Me.Controls.Add(Me.lblBirimFiyat)
        Me.Controls.Add(Me.lblUrunAdı)
        Me.Controls.Add(Me.txtAdet)
        Me.Controls.Add(Me.txtKdv)
        Me.Controls.Add(Me.txtBirimFiyat)
        Me.Controls.Add(Me.cmbxUrunAdi)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Name = "Stok_Ekleme"
        Me.Text = "Stok Ekleme"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbxUrunAdi As ComboBox
    Friend WithEvents txtBirimFiyat As TextBox
    Friend WithEvents txtKdv As TextBox
    Friend WithEvents txtAdet As TextBox
    Friend WithEvents lblUrunAdı As Label
    Friend WithEvents lblBirimFiyat As Label
    Friend WithEvents lblKdv As Label
    Friend WithEvents lblAdet As Label
    Friend WithEvents btnKaydet As Button
    Friend WithEvents ımageList1 As ImageList
    Friend WithEvents btnKapat As Button
End Class
