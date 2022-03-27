<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kasiyerler
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kasiyerler))
        Me.txtKasiyerler = New System.Windows.Forms.TextBox()
        Me.cboxKasiyerler = New System.Windows.Forms.ComboBox()
        Me.btnAra = New System.Windows.Forms.Button()
        Me.ımageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.dgKasiyerler = New System.Windows.Forms.DataGridView()
        Me.Adı = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Soyadı = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TcKimlik = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CepTel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EvTel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Adres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Maas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GörevliOldKasa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEkle = New System.Windows.Forms.Button()
        Me.btnSil = New System.Windows.Forms.Button()
        Me.btnKapat = New System.Windows.Forms.Button()
        CType(Me.dgKasiyerler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtKasiyerler
        '
        Me.txtKasiyerler.Location = New System.Drawing.Point(199, 35)
        Me.txtKasiyerler.Name = "txtKasiyerler"
        Me.txtKasiyerler.Size = New System.Drawing.Size(122, 20)
        Me.txtKasiyerler.TabIndex = 0
        '
        'cboxKasiyerler
        '
        Me.cboxKasiyerler.FormattingEnabled = True
        Me.cboxKasiyerler.Items.AddRange(New Object() {"Ayşe", "Fatma", "Ali"})
        Me.cboxKasiyerler.Location = New System.Drawing.Point(371, 35)
        Me.cboxKasiyerler.Name = "cboxKasiyerler"
        Me.cboxKasiyerler.Size = New System.Drawing.Size(121, 21)
        Me.cboxKasiyerler.TabIndex = 1
        '
        'btnAra
        '
        Me.btnAra.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAra.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAra.ImageKey = "indir (5).jpg"
        Me.btnAra.ImageList = Me.ımageList1
        Me.btnAra.Location = New System.Drawing.Point(574, 24)
        Me.btnAra.Name = "btnAra"
        Me.btnAra.Size = New System.Drawing.Size(82, 52)
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
        Me.ımageList1.Images.SetKeyName(1, "images.jpg")
        Me.ımageList1.Images.SetKeyName(2, "indir (5).jpg")
        Me.ımageList1.Images.SetKeyName(3, "indir (6).jpg")
        '
        'dgKasiyerler
        '
        Me.dgKasiyerler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgKasiyerler.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Adı, Me.Soyadı, Me.TcKimlik, Me.CepTel, Me.EvTel, Me.Adres, Me.Maas, Me.GörevliOldKasa})
        Me.dgKasiyerler.Location = New System.Drawing.Point(12, 105)
        Me.dgKasiyerler.Name = "dgKasiyerler"
        Me.dgKasiyerler.Size = New System.Drawing.Size(821, 150)
        Me.dgKasiyerler.TabIndex = 3
        '
        'Adı
        '
        Me.Adı.HeaderText = "Adı"
        Me.Adı.Name = "Adı"
        '
        'Soyadı
        '
        Me.Soyadı.HeaderText = "Soyadı"
        Me.Soyadı.Name = "Soyadı"
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
        'Maas
        '
        Me.Maas.HeaderText = "Maaş"
        Me.Maas.Name = "Maas"
        '
        'GörevliOldKasa
        '
        Me.GörevliOldKasa.HeaderText = "Görevli old. Kasa"
        Me.GörevliOldKasa.Name = "GörevliOldKasa"
        '
        'btnEkle
        '
        Me.btnEkle.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEkle.ImageKey = "indir (6).jpg"
        Me.btnEkle.ImageList = Me.ımageList1
        Me.btnEkle.Location = New System.Drawing.Point(448, 279)
        Me.btnEkle.Name = "btnEkle"
        Me.btnEkle.Size = New System.Drawing.Size(75, 56)
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
        Me.btnSil.Location = New System.Drawing.Point(557, 279)
        Me.btnSil.Name = "btnSil"
        Me.btnSil.Size = New System.Drawing.Size(75, 56)
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
        Me.btnKapat.Location = New System.Drawing.Point(669, 279)
        Me.btnKapat.Name = "btnKapat"
        Me.btnKapat.Size = New System.Drawing.Size(75, 56)
        Me.btnKapat.TabIndex = 6
        Me.btnKapat.Text = "Kapat"
        Me.btnKapat.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnKapat.UseVisualStyleBackColor = False
        '
        'Kasiyerler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(861, 380)
        Me.Controls.Add(Me.btnKapat)
        Me.Controls.Add(Me.btnSil)
        Me.Controls.Add(Me.btnEkle)
        Me.Controls.Add(Me.dgKasiyerler)
        Me.Controls.Add(Me.btnAra)
        Me.Controls.Add(Me.cboxKasiyerler)
        Me.Controls.Add(Me.txtKasiyerler)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Name = "Kasiyerler"
        Me.Text = "Kasiyerler"
        CType(Me.dgKasiyerler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtKasiyerler As TextBox
    Friend WithEvents cboxKasiyerler As ComboBox
    Friend WithEvents btnAra As Button
    Friend WithEvents ımageList1 As ImageList
    Friend WithEvents dgKasiyerler As DataGridView
    Friend WithEvents Adı As DataGridViewTextBoxColumn
    Friend WithEvents Soyadı As DataGridViewTextBoxColumn
    Friend WithEvents TcKimlik As DataGridViewTextBoxColumn
    Friend WithEvents CepTel As DataGridViewTextBoxColumn
    Friend WithEvents EvTel As DataGridViewTextBoxColumn
    Friend WithEvents Adres As DataGridViewTextBoxColumn
    Friend WithEvents Maas As DataGridViewTextBoxColumn
    Friend WithEvents GörevliOldKasa As DataGridViewTextBoxColumn
    Friend WithEvents btnEkle As Button
    Friend WithEvents btnSil As Button
    Friend WithEvents btnKapat As Button
End Class
