<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnMusIslem = New System.Windows.Forms.Button()
        Me.ımageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnUrunIslem = New System.Windows.Forms.Button()
        Me.btnKasiyerIslem = New System.Windows.Forms.Button()
        Me.btnStokIslem = New System.Windows.Forms.Button()
        Me.btnSatısIslem = New System.Windows.Forms.Button()
        Me.btnCikis = New System.Windows.Forms.Button()
        Me.dgMusteri = New System.Windows.Forms.DataGridView()
        Me.FaturaNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MüşteriAdı = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MüşteriSoyadı = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCKimlik = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ÜrünAdı = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SatışFiyatı = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Adet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sütun1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgMusteri, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMusIslem
        '
        Me.btnMusIslem.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMusIslem.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMusIslem.ImageKey = "indir.jpg"
        Me.btnMusIslem.ImageList = Me.ımageList1
        Me.btnMusIslem.Location = New System.Drawing.Point(25, 20)
        Me.btnMusIslem.Name = "btnMusIslem"
        Me.btnMusIslem.Size = New System.Drawing.Size(115, 52)
        Me.btnMusIslem.TabIndex = 0
        Me.btnMusIslem.Text = "Müşteri İşlemleri"
        Me.btnMusIslem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMusIslem.UseVisualStyleBackColor = False
        '
        'ımageList1
        '
        Me.ımageList1.ImageStream = CType(resources.GetObject("ımageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ımageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ımageList1.Images.SetKeyName(0, "indir.jpg")
        Me.ımageList1.Images.SetKeyName(1, "indir.jpg")
        Me.ımageList1.Images.SetKeyName(2, "indir (1).jpg")
        Me.ımageList1.Images.SetKeyName(3, "depositphotos_180019674-stock-illustration-cashier-icon-with-job-title.jpg")
        Me.ımageList1.Images.SetKeyName(4, "e-defter_logo_yazilim-e1478598885549.jpg")
        Me.ımageList1.Images.SetKeyName(5, "indir (3).jpg")
        Me.ımageList1.Images.SetKeyName(6, "indir.png")
        '
        'btnUrunIslem
        '
        Me.btnUrunIslem.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnUrunIslem.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUrunIslem.ImageKey = "indir (1).jpg"
        Me.btnUrunIslem.ImageList = Me.ımageList1
        Me.btnUrunIslem.Location = New System.Drawing.Point(155, 20)
        Me.btnUrunIslem.Name = "btnUrunIslem"
        Me.btnUrunIslem.Size = New System.Drawing.Size(130, 52)
        Me.btnUrunIslem.TabIndex = 1
        Me.btnUrunIslem.Text = "Ürün İşlemleri"
        Me.btnUrunIslem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUrunIslem.UseVisualStyleBackColor = False
        '
        'btnKasiyerIslem
        '
        Me.btnKasiyerIslem.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnKasiyerIslem.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnKasiyerIslem.ImageKey = "depositphotos_180019674-stock-illustration-cashier-icon-with-job-title.jpg"
        Me.btnKasiyerIslem.ImageList = Me.ımageList1
        Me.btnKasiyerIslem.Location = New System.Drawing.Point(324, 20)
        Me.btnKasiyerIslem.Name = "btnKasiyerIslem"
        Me.btnKasiyerIslem.Size = New System.Drawing.Size(130, 52)
        Me.btnKasiyerIslem.TabIndex = 2
        Me.btnKasiyerIslem.Text = "Kasiyer İşlemleri"
        Me.btnKasiyerIslem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnKasiyerIslem.UseVisualStyleBackColor = False
        '
        'btnStokIslem
        '
        Me.btnStokIslem.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnStokIslem.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnStokIslem.ImageKey = "e-defter_logo_yazilim-e1478598885549.jpg"
        Me.btnStokIslem.ImageList = Me.ımageList1
        Me.btnStokIslem.Location = New System.Drawing.Point(484, 21)
        Me.btnStokIslem.Name = "btnStokIslem"
        Me.btnStokIslem.Size = New System.Drawing.Size(128, 51)
        Me.btnStokIslem.TabIndex = 3
        Me.btnStokIslem.Text = "Stok İşlemleri"
        Me.btnStokIslem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnStokIslem.UseVisualStyleBackColor = False
        '
        'btnSatısIslem
        '
        Me.btnSatısIslem.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSatısIslem.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSatısIslem.ImageKey = "indir (3).jpg"
        Me.btnSatısIslem.ImageList = Me.ımageList1
        Me.btnSatısIslem.Location = New System.Drawing.Point(635, 21)
        Me.btnSatısIslem.Name = "btnSatısIslem"
        Me.btnSatısIslem.Size = New System.Drawing.Size(169, 51)
        Me.btnSatısIslem.TabIndex = 4
        Me.btnSatısIslem.Text = "Satış İşlemleri"
        Me.btnSatısIslem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSatısIslem.UseVisualStyleBackColor = False
        '
        'btnCikis
        '
        Me.btnCikis.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCikis.ImageKey = "indir.png"
        Me.btnCikis.ImageList = Me.ımageList1
        Me.btnCikis.Location = New System.Drawing.Point(820, 21)
        Me.btnCikis.Name = "btnCikis"
        Me.btnCikis.Size = New System.Drawing.Size(138, 51)
        Me.btnCikis.TabIndex = 5
        Me.btnCikis.Text = "Çıkış"
        Me.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCikis.UseVisualStyleBackColor = False
        '
        'dgMusteri
        '
        Me.dgMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMusteri.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FaturaNo, Me.MüşteriAdı, Me.MüşteriSoyadı, Me.TCKimlik, Me.ÜrünAdı, Me.SatışFiyatı, Me.Adet, Me.Sütun1})
        Me.dgMusteri.Location = New System.Drawing.Point(100, 121)
        Me.dgMusteri.Name = "dgMusteri"
        Me.dgMusteri.Size = New System.Drawing.Size(720, 188)
        Me.dgMusteri.TabIndex = 6
        '
        'FaturaNo
        '
        Me.FaturaNo.HeaderText = "Fatura No"
        Me.FaturaNo.Name = "FaturaNo"
        '
        'MüşteriAdı
        '
        Me.MüşteriAdı.HeaderText = "Müşteri Adı"
        Me.MüşteriAdı.Name = "MüşteriAdı"
        '
        'MüşteriSoyadı
        '
        Me.MüşteriSoyadı.HeaderText = "Müşteri Soyadı"
        Me.MüşteriSoyadı.Name = "MüşteriSoyadı"
        '
        'TCKimlik
        '
        Me.TCKimlik.HeaderText = "Tc Kimlik"
        Me.TCKimlik.Name = "TCKimlik"
        '
        'ÜrünAdı
        '
        Me.ÜrünAdı.HeaderText = "Ürün Adı"
        Me.ÜrünAdı.Name = "ÜrünAdı"
        '
        'SatışFiyatı
        '
        Me.SatışFiyatı.HeaderText = "Satış Fiyatı"
        Me.SatışFiyatı.Name = "SatışFiyatı"
        '
        'Adet
        '
        Me.Adet.HeaderText = "Adet"
        Me.Adet.Name = "Adet"
        '
        'Sütun1
        '
        Me.Sütun1.HeaderText = "sütun1"
        Me.Sütun1.Name = "Sütun1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(958, 336)
        Me.Controls.Add(Me.dgMusteri)
        Me.Controls.Add(Me.btnCikis)
        Me.Controls.Add(Me.btnSatısIslem)
        Me.Controls.Add(Me.btnStokIslem)
        Me.Controls.Add(Me.btnKasiyerIslem)
        Me.Controls.Add(Me.btnUrunIslem)
        Me.Controls.Add(Me.btnMusIslem)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgMusteri, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMusIslem As Button
    Friend WithEvents ımageList1 As ImageList
    Friend WithEvents btnUrunIslem As Button
    Friend WithEvents btnKasiyerIslem As Button
    Friend WithEvents btnStokIslem As Button
    Friend WithEvents btnSatısIslem As Button
    Friend WithEvents btnCikis As Button
    Friend WithEvents dgMusteri As DataGridView
    Friend WithEvents FaturaNo As DataGridViewTextBoxColumn
    Friend WithEvents MüşteriAdı As DataGridViewTextBoxColumn
    Friend WithEvents MüşteriSoyadı As DataGridViewTextBoxColumn
    Friend WithEvents TCKimlik As DataGridViewTextBoxColumn
    Friend WithEvents ÜrünAdı As DataGridViewTextBoxColumn
    Friend WithEvents SatışFiyatı As DataGridViewTextBoxColumn
    Friend WithEvents Adet As DataGridViewTextBoxColumn
    Friend WithEvents Sütun1 As DataGridViewTextBoxColumn
End Class
