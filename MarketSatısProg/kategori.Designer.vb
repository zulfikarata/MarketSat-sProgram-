<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class kategori
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(kategori))
        Me.dgKategori = New System.Windows.Forms.DataGridView()
        Me.KategoriAdi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LstbxYeniKategoriEkle = New System.Windows.Forms.ListBox()
        Me.txtEkle = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSil = New System.Windows.Forms.Button()
        Me.ımageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnKapat = New System.Windows.Forms.Button()
        CType(Me.dgKategori, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgKategori
        '
        Me.dgKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgKategori.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KategoriAdi})
        Me.dgKategori.Location = New System.Drawing.Point(12, 27)
        Me.dgKategori.Name = "dgKategori"
        Me.dgKategori.Size = New System.Drawing.Size(567, 150)
        Me.dgKategori.TabIndex = 0
        '
        'KategoriAdi
        '
        Me.KategoriAdi.HeaderText = "Kategori Adı"
        Me.KategoriAdi.Name = "KategoriAdi"
        '
        'LstbxYeniKategoriEkle
        '
        Me.LstbxYeniKategoriEkle.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.LstbxYeniKategoriEkle.FormattingEnabled = True
        Me.LstbxYeniKategoriEkle.Items.AddRange(New Object() {"Yeni Kategori Ekle"})
        Me.LstbxYeniKategoriEkle.Location = New System.Drawing.Point(23, 198)
        Me.LstbxYeniKategoriEkle.Name = "LstbxYeniKategoriEkle"
        Me.LstbxYeniKategoriEkle.Size = New System.Drawing.Size(229, 95)
        Me.LstbxYeniKategoriEkle.TabIndex = 1
        '
        'txtEkle
        '
        Me.txtEkle.Location = New System.Drawing.Point(71, 233)
        Me.txtEkle.Name = "txtEkle"
        Me.txtEkle.Size = New System.Drawing.Size(124, 20)
        Me.txtEkle.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(100, 259)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Ekle"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnSil
        '
        Me.btnSil.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSil.ImageKey = "images.jpg"
        Me.btnSil.ImageList = Me.ımageList1
        Me.btnSil.Location = New System.Drawing.Point(312, 233)
        Me.btnSil.Name = "btnSil"
        Me.btnSil.Size = New System.Drawing.Size(94, 60)
        Me.btnSil.TabIndex = 4
        Me.btnSil.Text = "Sil"
        Me.btnSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSil.UseVisualStyleBackColor = False
        '
        'ımageList1
        '
        Me.ımageList1.ImageStream = CType(resources.GetObject("ımageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ımageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ımageList1.Images.SetKeyName(0, "images.jpg")
        Me.ımageList1.Images.SetKeyName(1, "close-icon-41.jpg")
        '
        'btnKapat
        '
        Me.btnKapat.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnKapat.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnKapat.ImageKey = "close-icon-41.jpg"
        Me.btnKapat.ImageList = Me.ımageList1
        Me.btnKapat.Location = New System.Drawing.Point(437, 233)
        Me.btnKapat.Name = "btnKapat"
        Me.btnKapat.Size = New System.Drawing.Size(93, 60)
        Me.btnKapat.TabIndex = 5
        Me.btnKapat.Text = "Kapat"
        Me.btnKapat.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnKapat.UseVisualStyleBackColor = False
        '
        'kategori
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(638, 336)
        Me.Controls.Add(Me.btnKapat)
        Me.Controls.Add(Me.btnSil)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtEkle)
        Me.Controls.Add(Me.LstbxYeniKategoriEkle)
        Me.Controls.Add(Me.dgKategori)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Name = "kategori"
        Me.Text = "kategori"
        CType(Me.dgKategori, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgKategori As DataGridView
    Friend WithEvents KategoriAdi As DataGridViewTextBoxColumn
    Friend WithEvents LstbxYeniKategoriEkle As ListBox
    Friend WithEvents txtEkle As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnSil As Button
    Friend WithEvents ımageList1 As ImageList
    Friend WithEvents btnKapat As Button
End Class
