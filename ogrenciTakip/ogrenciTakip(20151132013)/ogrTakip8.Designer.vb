<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ogrTakip8
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
        Me.dgOgrenci = New System.Windows.Forms.DataGridView()
        Me.txtOgrNumarasi = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtResimYolu = New System.Windows.Forms.TextBox()
        Me.btnResimSec = New System.Windows.Forms.Button()
        Me.btnGuncelle = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pbxOgrResmi = New System.Windows.Forms.PictureBox()
        Me.cmbBolumu = New System.Windows.Forms.ComboBox()
        Me.txtNumarasi = New System.Windows.Forms.TextBox()
        Me.txtSinifi = New System.Windows.Forms.TextBox()
        Me.txtSoyadi = New System.Windows.Forms.TextBox()
        Me.txtAdi = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnKapat = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgOgrenci, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxOgrResmi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgOgrenci
        '
        Me.dgOgrenci.AllowUserToAddRows = False
        Me.dgOgrenci.AllowUserToDeleteRows = False
        Me.dgOgrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgOgrenci.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column1})
        Me.dgOgrenci.Location = New System.Drawing.Point(65, 116)
        Me.dgOgrenci.Name = "dgOgrenci"
        Me.dgOgrenci.ReadOnly = True
        Me.dgOgrenci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgOgrenci.Size = New System.Drawing.Size(624, 183)
        Me.dgOgrenci.TabIndex = 36
        '
        'txtOgrNumarasi
        '
        Me.txtOgrNumarasi.Location = New System.Drawing.Point(153, 87)
        Me.txtOgrNumarasi.Name = "txtOgrNumarasi"
        Me.txtOgrNumarasi.Size = New System.Drawing.Size(125, 20)
        Me.txtOgrNumarasi.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(62, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 16)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Öğrenci Ara :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Baskerville Old Face", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(197, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(418, 27)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "KAYIT GUNCELLEME ISLEMLERI"
        '
        'txtResimYolu
        '
        Me.txtResimYolu.Location = New System.Drawing.Point(457, 525)
        Me.txtResimYolu.Name = "txtResimYolu"
        Me.txtResimYolu.Size = New System.Drawing.Size(82, 20)
        Me.txtResimYolu.TabIndex = 55
        Me.txtResimYolu.Visible = False
        '
        'btnResimSec
        '
        Me.btnResimSec.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnResimSec.Image = Global.ogrenciTakip.My.Resources.Resources._1478968766_Import
        Me.btnResimSec.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnResimSec.Location = New System.Drawing.Point(371, 509)
        Me.btnResimSec.Name = "btnResimSec"
        Me.btnResimSec.Size = New System.Drawing.Size(75, 52)
        Me.btnResimSec.TabIndex = 54
        Me.btnResimSec.Text = "Resim Seç"
        Me.btnResimSec.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnResimSec.UseVisualStyleBackColor = False
        '
        'btnGuncelle
        '
        Me.btnGuncelle.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnGuncelle.Image = Global.ogrenciTakip.My.Resources.Resources._1478969498_update
        Me.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuncelle.Location = New System.Drawing.Point(503, 345)
        Me.btnGuncelle.Name = "btnGuncelle"
        Me.btnGuncelle.Size = New System.Drawing.Size(79, 58)
        Me.btnGuncelle.TabIndex = 53
        Me.btnGuncelle.Text = "Güncelle"
        Me.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuncelle.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(369, 316)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Öğrenci Resmi :"
        '
        'pbxOgrResmi
        '
        Me.pbxOgrResmi.Location = New System.Drawing.Point(335, 332)
        Me.pbxOgrResmi.Name = "pbxOgrResmi"
        Me.pbxOgrResmi.Size = New System.Drawing.Size(151, 171)
        Me.pbxOgrResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxOgrResmi.TabIndex = 51
        Me.pbxOgrResmi.TabStop = False
        '
        'cmbBolumu
        '
        Me.cmbBolumu.FormattingEnabled = True
        Me.cmbBolumu.Items.AddRange(New Object() {"Bilgisayar Programcılığı", "İnşaat Teknolojileri", "Elektrik Elektronik Teknolojileri", "Makina Teknolojileri"})
        Me.cmbBolumu.Location = New System.Drawing.Point(179, 465)
        Me.cmbBolumu.Name = "cmbBolumu"
        Me.cmbBolumu.Size = New System.Drawing.Size(134, 21)
        Me.cmbBolumu.TabIndex = 50
        '
        'txtNumarasi
        '
        Me.txtNumarasi.Location = New System.Drawing.Point(179, 437)
        Me.txtNumarasi.Name = "txtNumarasi"
        Me.txtNumarasi.Size = New System.Drawing.Size(134, 20)
        Me.txtNumarasi.TabIndex = 49
        '
        'txtSinifi
        '
        Me.txtSinifi.Location = New System.Drawing.Point(179, 408)
        Me.txtSinifi.Name = "txtSinifi"
        Me.txtSinifi.Size = New System.Drawing.Size(134, 20)
        Me.txtSinifi.TabIndex = 48
        '
        'txtSoyadi
        '
        Me.txtSoyadi.Location = New System.Drawing.Point(179, 380)
        Me.txtSoyadi.Name = "txtSoyadi"
        Me.txtSoyadi.Size = New System.Drawing.Size(134, 20)
        Me.txtSoyadi.TabIndex = 47
        '
        'txtAdi
        '
        Me.txtAdi.Location = New System.Drawing.Point(179, 353)
        Me.txtAdi.Name = "txtAdi"
        Me.txtAdi.Size = New System.Drawing.Size(134, 20)
        Me.txtAdi.TabIndex = 46
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(106, 468)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Bölümü :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(106, 440)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Numarası :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(106, 411)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Sınıfı :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(106, 383)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Soyadı :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(106, 356)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Adı :"
        '
        'btnKapat
        '
        Me.btnKapat.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnKapat.Image = Global.ogrenciTakip.My.Resources.Resources._1478968096_Close_Box_Red
        Me.btnKapat.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnKapat.Location = New System.Drawing.Point(503, 417)
        Me.btnKapat.Name = "btnKapat"
        Me.btnKapat.Size = New System.Drawing.Size(79, 58)
        Me.btnKapat.TabIndex = 40
        Me.btnKapat.Text = "Kapat"
        Me.btnKapat.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnKapat.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Id"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "Numarası"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Adı"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Soyadı"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Sınıfı"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Bölümü"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Resim"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'ogrTakip8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ogrenciTakip.My.Resources.Resources.green_307835_640
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(751, 635)
        Me.Controls.Add(Me.txtResimYolu)
        Me.Controls.Add(Me.btnResimSec)
        Me.Controls.Add(Me.btnGuncelle)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.pbxOgrResmi)
        Me.Controls.Add(Me.cmbBolumu)
        Me.Controls.Add(Me.txtNumarasi)
        Me.Controls.Add(Me.txtSinifi)
        Me.Controls.Add(Me.txtSoyadi)
        Me.Controls.Add(Me.txtAdi)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnKapat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtOgrNumarasi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgOgrenci)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ogrTakip8"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ogrTakip8"
        CType(Me.dgOgrenci, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxOgrResmi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgOgrenci As System.Windows.Forms.DataGridView
    Friend WithEvents txtOgrNumarasi As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtResimYolu As System.Windows.Forms.TextBox
    Friend WithEvents btnResimSec As System.Windows.Forms.Button
    Friend WithEvents btnGuncelle As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents pbxOgrResmi As System.Windows.Forms.PictureBox
    Friend WithEvents cmbBolumu As System.Windows.Forms.ComboBox
    Friend WithEvents txtNumarasi As System.Windows.Forms.TextBox
    Friend WithEvents txtSinifi As System.Windows.Forms.TextBox
    Friend WithEvents txtSoyadi As System.Windows.Forms.TextBox
    Friend WithEvents txtAdi As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnKapat As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
