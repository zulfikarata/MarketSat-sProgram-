<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MüşteriKayıt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MüşteriKayıt))
        Me.lblAdı = New System.Windows.Forms.Label()
        Me.lblSoyadı = New System.Windows.Forms.Label()
        Me.lblTcKimlik = New System.Windows.Forms.Label()
        Me.lblCepTel = New System.Windows.Forms.Label()
        Me.lblEvTel = New System.Windows.Forms.Label()
        Me.lblAdres = New System.Windows.Forms.Label()
        Me.txtAdi = New System.Windows.Forms.TextBox()
        Me.txtSoyadi = New System.Windows.Forms.TextBox()
        Me.txtTcKimlik = New System.Windows.Forms.TextBox()
        Me.txtCepTel = New System.Windows.Forms.TextBox()
        Me.txtEvTel = New System.Windows.Forms.TextBox()
        Me.txtAdres = New System.Windows.Forms.TextBox()
        Me.btnKaydet = New System.Windows.Forms.Button()
        Me.ımageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnKapat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAdı
        '
        Me.lblAdı.AutoSize = True
        Me.lblAdı.Location = New System.Drawing.Point(45, 21)
        Me.lblAdı.Name = "lblAdı"
        Me.lblAdı.Size = New System.Drawing.Size(25, 13)
        Me.lblAdı.TabIndex = 0
        Me.lblAdı.Text = "Adı"
        '
        'lblSoyadı
        '
        Me.lblSoyadı.AutoSize = True
        Me.lblSoyadı.Location = New System.Drawing.Point(25, 54)
        Me.lblSoyadı.Name = "lblSoyadı"
        Me.lblSoyadı.Size = New System.Drawing.Size(45, 13)
        Me.lblSoyadı.TabIndex = 1
        Me.lblSoyadı.Text = "Soyadı"
        '
        'lblTcKimlik
        '
        Me.lblTcKimlik.AutoSize = True
        Me.lblTcKimlik.Location = New System.Drawing.Point(11, 80)
        Me.lblTcKimlik.Name = "lblTcKimlik"
        Me.lblTcKimlik.Size = New System.Drawing.Size(59, 13)
        Me.lblTcKimlik.TabIndex = 2
        Me.lblTcKimlik.Text = "Tc Kimlik"
        '
        'lblCepTel
        '
        Me.lblCepTel.AutoSize = True
        Me.lblCepTel.Location = New System.Drawing.Point(19, 106)
        Me.lblCepTel.Name = "lblCepTel"
        Me.lblCepTel.Size = New System.Drawing.Size(51, 13)
        Me.lblCepTel.TabIndex = 3
        Me.lblCepTel.Text = "Cep Tel"
        '
        'lblEvTel
        '
        Me.lblEvTel.AutoSize = True
        Me.lblEvTel.Location = New System.Drawing.Point(26, 132)
        Me.lblEvTel.Name = "lblEvTel"
        Me.lblEvTel.Size = New System.Drawing.Size(44, 13)
        Me.lblEvTel.TabIndex = 4
        Me.lblEvTel.Text = "Ev Tel"
        '
        'lblAdres
        '
        Me.lblAdres.AutoSize = True
        Me.lblAdres.Location = New System.Drawing.Point(31, 158)
        Me.lblAdres.Name = "lblAdres"
        Me.lblAdres.Size = New System.Drawing.Size(39, 13)
        Me.lblAdres.TabIndex = 5
        Me.lblAdres.Text = "Adres"
        '
        'txtAdi
        '
        Me.txtAdi.Location = New System.Drawing.Point(109, 21)
        Me.txtAdi.Name = "txtAdi"
        Me.txtAdi.Size = New System.Drawing.Size(100, 20)
        Me.txtAdi.TabIndex = 6
        '
        'txtSoyadi
        '
        Me.txtSoyadi.Location = New System.Drawing.Point(109, 51)
        Me.txtSoyadi.Name = "txtSoyadi"
        Me.txtSoyadi.Size = New System.Drawing.Size(100, 20)
        Me.txtSoyadi.TabIndex = 7
        '
        'txtTcKimlik
        '
        Me.txtTcKimlik.Location = New System.Drawing.Point(109, 80)
        Me.txtTcKimlik.Name = "txtTcKimlik"
        Me.txtTcKimlik.Size = New System.Drawing.Size(100, 20)
        Me.txtTcKimlik.TabIndex = 8
        '
        'txtCepTel
        '
        Me.txtCepTel.Location = New System.Drawing.Point(109, 106)
        Me.txtCepTel.Name = "txtCepTel"
        Me.txtCepTel.Size = New System.Drawing.Size(100, 20)
        Me.txtCepTel.TabIndex = 9
        '
        'txtEvTel
        '
        Me.txtEvTel.Location = New System.Drawing.Point(109, 132)
        Me.txtEvTel.Name = "txtEvTel"
        Me.txtEvTel.Size = New System.Drawing.Size(100, 20)
        Me.txtEvTel.TabIndex = 10
        '
        'txtAdres
        '
        Me.txtAdres.Location = New System.Drawing.Point(109, 158)
        Me.txtAdres.Name = "txtAdres"
        Me.txtAdres.Size = New System.Drawing.Size(100, 20)
        Me.txtAdres.TabIndex = 11
        '
        'btnKaydet
        '
        Me.btnKaydet.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnKaydet.ImageKey = "indir (4).jpg"
        Me.btnKaydet.ImageList = Me.ımageList1
        Me.btnKaydet.Location = New System.Drawing.Point(44, 208)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(85, 52)
        Me.btnKaydet.TabIndex = 12
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
        Me.btnKapat.Location = New System.Drawing.Point(198, 208)
        Me.btnKapat.Name = "btnKapat"
        Me.btnKapat.Size = New System.Drawing.Size(81, 52)
        Me.btnKapat.TabIndex = 13
        Me.btnKapat.Text = "Kapat"
        Me.btnKapat.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnKapat.UseVisualStyleBackColor = False
        '
        'MüşteriKayıt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(369, 293)
        Me.Controls.Add(Me.btnKapat)
        Me.Controls.Add(Me.btnKaydet)
        Me.Controls.Add(Me.txtAdres)
        Me.Controls.Add(Me.txtEvTel)
        Me.Controls.Add(Me.txtCepTel)
        Me.Controls.Add(Me.txtTcKimlik)
        Me.Controls.Add(Me.txtSoyadi)
        Me.Controls.Add(Me.txtAdi)
        Me.Controls.Add(Me.lblAdres)
        Me.Controls.Add(Me.lblEvTel)
        Me.Controls.Add(Me.lblCepTel)
        Me.Controls.Add(Me.lblTcKimlik)
        Me.Controls.Add(Me.lblSoyadı)
        Me.Controls.Add(Me.lblAdı)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Name = "MüşteriKayıt"
        Me.Text = "MüşteriKayıt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAdı As Label
    Friend WithEvents lblSoyadı As Label
    Friend WithEvents lblTcKimlik As Label
    Friend WithEvents lblCepTel As Label
    Friend WithEvents lblEvTel As Label
    Friend WithEvents lblAdres As Label
    Friend WithEvents txtAdi As TextBox
    Friend WithEvents txtSoyadi As TextBox
    Friend WithEvents txtTcKimlik As TextBox
    Friend WithEvents txtCepTel As TextBox
    Friend WithEvents txtEvTel As TextBox
    Friend WithEvents txtAdres As TextBox
    Friend WithEvents btnKaydet As Button
    Friend WithEvents ımageList1 As ImageList
    Friend WithEvents btnKapat As Button
    Private txtAdsoyad As Object

    Private Sub MüşteriKayıt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        If txtAdsoyad.Text = "" Or txtAdres.Text = "" Or txtCepTel.Text = "" Then
            MsgBox("Lütfen Tüm Alanları Doldurunuz",
           MsgBoxStyle.Critical, "Hata")
            Return
        End If
    End Sub

    Private Sub btnKapat_Click(sender As Object, e As EventArgs) Handles btnKapat.Click
        Me.Close()
    End Sub
End Class
