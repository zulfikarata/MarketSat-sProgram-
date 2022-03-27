<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MüsteriArama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MüsteriArama))
        Me.txtArama = New System.Windows.Forms.TextBox()
        Me.cmbxMusteriler = New System.Windows.Forms.ComboBox()
        Me.btnAra = New System.Windows.Forms.Button()
        Me.ımageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.dgMusteriArama = New System.Windows.Forms.DataGridView()
        Me.MüsteriAdı = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MüsteriSoyadı = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TcKimlik = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CepTel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EvTel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Adres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEkle = New System.Windows.Forms.Button()
        Me.btnSil = New System.Windows.Forms.Button()
        Me.btnKapat = New System.Windows.Forms.Button()
        CType(Me.dgMusteriArama, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtArama
        '
        Me.txtArama.Location = New System.Drawing.Point(112, 35)
        Me.txtArama.Name = "txtArama"
        Me.txtArama.Size = New System.Drawing.Size(116, 20)
        Me.txtArama.TabIndex = 0
        '
        'cmbxMusteriler
        '
        Me.cmbxMusteriler.FormattingEnabled = True
        Me.cmbxMusteriler.Items.AddRange(New Object() {"Tümü"})
        Me.cmbxMusteriler.Location = New System.Drawing.Point(284, 35)
        Me.cmbxMusteriler.Name = "cmbxMusteriler"
        Me.cmbxMusteriler.Size = New System.Drawing.Size(140, 21)
        Me.cmbxMusteriler.TabIndex = 1
        '
        'btnAra
        '
        Me.btnAra.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAra.ImageKey = "indir (5).jpg"
        Me.btnAra.ImageList = Me.ımageList1
        Me.btnAra.Location = New System.Drawing.Point(493, 35)
        Me.btnAra.Name = "btnAra"
        Me.btnAra.Size = New System.Drawing.Size(93, 33)
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
        Me.ımageList1.Images.SetKeyName(3, "indir (7).jpg")
        '
        'dgMusteriArama
        '
        Me.dgMusteriArama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMusteriArama.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MüsteriAdı, Me.MüsteriSoyadı, Me.TcKimlik, Me.CepTel, Me.EvTel, Me.Adres})
        Me.dgMusteriArama.Location = New System.Drawing.Point(52, 92)
        Me.dgMusteriArama.Name = "dgMusteriArama"
        Me.dgMusteriArama.Size = New System.Drawing.Size(645, 150)
        Me.dgMusteriArama.TabIndex = 3
        '
        'MüsteriAdı
        '
        Me.MüsteriAdı.HeaderText = "Müşteri Adı"
        Me.MüsteriAdı.Name = "MüsteriAdı"
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
        'btnEkle
        '
        Me.btnEkle.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEkle.ImageKey = "indir (6).jpg"
        Me.btnEkle.ImageList = Me.ımageList1
        Me.btnEkle.Location = New System.Drawing.Point(425, 258)
        Me.btnEkle.Name = "btnEkle"
        Me.btnEkle.Size = New System.Drawing.Size(69, 54)
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
        Me.btnSil.Location = New System.Drawing.Point(521, 258)
        Me.btnSil.Name = "btnSil"
        Me.btnSil.Size = New System.Drawing.Size(75, 54)
        Me.btnSil.TabIndex = 5
        Me.btnSil.Text = "Sil"
        Me.btnSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSil.UseVisualStyleBackColor = False
        '
        'btnKapat
        '
        Me.btnKapat.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnKapat.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnKapat.ImageKey = "indir (7).jpg"
        Me.btnKapat.ImageList = Me.ımageList1
        Me.btnKapat.Location = New System.Drawing.Point(622, 258)
        Me.btnKapat.Name = "btnKapat"
        Me.btnKapat.Size = New System.Drawing.Size(75, 54)
        Me.btnKapat.TabIndex = 6
        Me.btnKapat.Text = "Kapat"
        Me.btnKapat.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnKapat.UseVisualStyleBackColor = False
        '
        'MüsteriArama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(939, 337)
        Me.Controls.Add(Me.btnKapat)
        Me.Controls.Add(Me.btnSil)
        Me.Controls.Add(Me.btnEkle)
        Me.Controls.Add(Me.dgMusteriArama)
        Me.Controls.Add(Me.btnAra)
        Me.Controls.Add(Me.cmbxMusteriler)
        Me.Controls.Add(Me.txtArama)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Name = "MüsteriArama"
        Me.Text = "MüsteriArama"
        CType(Me.dgMusteriArama, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtArama As TextBox
    Friend WithEvents cmbxMusteriler As ComboBox
    Friend WithEvents btnAra As Button
    Friend WithEvents ımageList1 As ImageList
    Friend WithEvents dgMusteriArama As DataGridView
    Friend WithEvents MüsteriAdı As DataGridViewTextBoxColumn
    Friend WithEvents MüsteriSoyadı As DataGridViewTextBoxColumn
    Friend WithEvents TcKimlik As DataGridViewTextBoxColumn
    Friend WithEvents CepTel As DataGridViewTextBoxColumn
    Friend WithEvents EvTel As DataGridViewTextBoxColumn
    Friend WithEvents Adres As DataGridViewTextBoxColumn
    Friend WithEvents btnEkle As Button
    Friend WithEvents btnSil As Button
    Friend WithEvents btnKapat As Button
End Class
