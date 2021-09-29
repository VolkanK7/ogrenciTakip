<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ogrTakip6
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgOgrenci = New System.Windows.Forms.DataGridView()
        Me.txtOgrNumarasi = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNot2 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.cmbSinavDersi = New System.Windows.Forms.ComboBox()
        Me.cbAdi = New System.Windows.Forms.CheckBox()
        Me.cbSoyadi = New System.Windows.Forms.CheckBox()
        Me.cbSinifi = New System.Windows.Forms.CheckBox()
        Me.cbNumarasi = New System.Windows.Forms.CheckBox()
        Me.cbBolumu = New System.Windows.Forms.CheckBox()
        Me.cbOdevDers = New System.Windows.Forms.CheckBox()
        Me.cbOdevKonu = New System.Windows.Forms.CheckBox()
        Me.cbOdevVerTarih = New System.Windows.Forms.CheckBox()
        Me.txtAdi = New System.Windows.Forms.TextBox()
        Me.txtSoyadi = New System.Windows.Forms.TextBox()
        Me.txtSinifi = New System.Windows.Forms.TextBox()
        Me.txtNumarasi = New System.Windows.Forms.TextBox()
        Me.cmbBolumu = New System.Windows.Forms.ComboBox()
        Me.cbOdevTesTarih = New System.Windows.Forms.CheckBox()
        Me.cbOdevNot = New System.Windows.Forms.CheckBox()
        Me.cmbOdevDers = New System.Windows.Forms.ComboBox()
        Me.txtOdevKonu = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.txtNot = New System.Windows.Forms.TextBox()
        Me.cbSinavDers = New System.Windows.Forms.CheckBox()
        Me.cbSinavTarih = New System.Windows.Forms.CheckBox()
        Me.cbSinavNot = New System.Windows.Forms.CheckBox()
        Me.btnKapat = New System.Windows.Forms.Button()
        Me.btnGuncelle = New System.Windows.Forms.Button()
        Me.cbHepsiniSec = New System.Windows.Forms.CheckBox()
        Me.btnResimSec = New System.Windows.Forms.Button()
        Me.pbxOgrResmi = New System.Windows.Forms.PictureBox()
        Me.cbResim = New System.Windows.Forms.CheckBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.dgOgrenci, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxOgrResmi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Baskerville Old Face", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(436, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(418, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "KAYIT GUNCELLEME ISLEMLERI"
        '
        'dgOgrenci
        '
        Me.dgOgrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgOgrenci.Location = New System.Drawing.Point(58, 83)
        Me.dgOgrenci.Name = "dgOgrenci"
        Me.dgOgrenci.Size = New System.Drawing.Size(963, 173)
        Me.dgOgrenci.TabIndex = 11
        '
        'txtOgrNumarasi
        '
        Me.txtOgrNumarasi.Location = New System.Drawing.Point(1062, 136)
        Me.txtOgrNumarasi.Name = "txtOgrNumarasi"
        Me.txtOgrNumarasi.Size = New System.Drawing.Size(125, 20)
        Me.txtOgrNumarasi.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(1059, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Öğrenci Ara :"
        '
        'txtNot2
        '
        Me.txtNot2.Location = New System.Drawing.Point(1054, 338)
        Me.txtNot2.Name = "txtNot2"
        Me.txtNot2.Size = New System.Drawing.Size(125, 20)
        Me.txtNot2.TabIndex = 40
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Location = New System.Drawing.Point(1054, 304)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(145, 20)
        Me.DateTimePicker3.TabIndex = 42
        '
        'cmbSinavDersi
        '
        Me.cmbSinavDersi.FormattingEnabled = True
        Me.cmbSinavDersi.Items.AddRange(New Object() {"Bilgisayar Programcılığı", "İnşaat Teknolojileri", "Elektrik Elektronik Teknolojileri", "Makina Teknolojileri"})
        Me.cmbSinavDersi.Location = New System.Drawing.Point(1054, 275)
        Me.cmbSinavDersi.Name = "cmbSinavDersi"
        Me.cmbSinavDersi.Size = New System.Drawing.Size(125, 21)
        Me.cmbSinavDersi.TabIndex = 41
        '
        'cbAdi
        '
        Me.cbAdi.AutoSize = True
        Me.cbAdi.BackColor = System.Drawing.Color.Transparent
        Me.cbAdi.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cbAdi.Location = New System.Drawing.Point(64, 277)
        Me.cbAdi.Name = "cbAdi"
        Me.cbAdi.Size = New System.Drawing.Size(47, 17)
        Me.cbAdi.TabIndex = 17
        Me.cbAdi.Text = "Adı :"
        Me.cbAdi.UseVisualStyleBackColor = False
        '
        'cbSoyadi
        '
        Me.cbSoyadi.AutoSize = True
        Me.cbSoyadi.BackColor = System.Drawing.Color.Transparent
        Me.cbSoyadi.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cbSoyadi.Location = New System.Drawing.Point(64, 309)
        Me.cbSoyadi.Name = "cbSoyadi"
        Me.cbSoyadi.Size = New System.Drawing.Size(64, 17)
        Me.cbSoyadi.TabIndex = 18
        Me.cbSoyadi.Text = "Soyadı :"
        Me.cbSoyadi.UseVisualStyleBackColor = False
        '
        'cbSinifi
        '
        Me.cbSinifi.AutoSize = True
        Me.cbSinifi.BackColor = System.Drawing.Color.Transparent
        Me.cbSinifi.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cbSinifi.Location = New System.Drawing.Point(64, 340)
        Me.cbSinifi.Name = "cbSinifi"
        Me.cbSinifi.Size = New System.Drawing.Size(54, 17)
        Me.cbSinifi.TabIndex = 19
        Me.cbSinifi.Text = "Sınıfı :"
        Me.cbSinifi.UseVisualStyleBackColor = False
        '
        'cbNumarasi
        '
        Me.cbNumarasi.AutoSize = True
        Me.cbNumarasi.BackColor = System.Drawing.Color.Transparent
        Me.cbNumarasi.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cbNumarasi.Location = New System.Drawing.Point(64, 373)
        Me.cbNumarasi.Name = "cbNumarasi"
        Me.cbNumarasi.Size = New System.Drawing.Size(76, 17)
        Me.cbNumarasi.TabIndex = 20
        Me.cbNumarasi.Text = "Numarası :"
        Me.cbNumarasi.UseVisualStyleBackColor = False
        '
        'cbBolumu
        '
        Me.cbBolumu.AutoSize = True
        Me.cbBolumu.BackColor = System.Drawing.Color.Transparent
        Me.cbBolumu.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cbBolumu.Location = New System.Drawing.Point(64, 407)
        Me.cbBolumu.Name = "cbBolumu"
        Me.cbBolumu.Size = New System.Drawing.Size(67, 17)
        Me.cbBolumu.TabIndex = 21
        Me.cbBolumu.Text = "Bölümü :"
        Me.cbBolumu.UseVisualStyleBackColor = False
        '
        'cbOdevDers
        '
        Me.cbOdevDers.AutoSize = True
        Me.cbOdevDers.BackColor = System.Drawing.Color.Transparent
        Me.cbOdevDers.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cbOdevDers.Location = New System.Drawing.Point(533, 277)
        Me.cbOdevDers.Name = "cbOdevDers"
        Me.cbOdevDers.Size = New System.Drawing.Size(118, 17)
        Me.cbOdevDers.TabIndex = 22
        Me.cbOdevDers.Text = "Ödev Verilen Ders :"
        Me.cbOdevDers.UseVisualStyleBackColor = False
        '
        'cbOdevKonu
        '
        Me.cbOdevKonu.AutoSize = True
        Me.cbOdevKonu.BackColor = System.Drawing.Color.Transparent
        Me.cbOdevKonu.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cbOdevKonu.Location = New System.Drawing.Point(533, 309)
        Me.cbOdevKonu.Name = "cbOdevKonu"
        Me.cbOdevKonu.Size = New System.Drawing.Size(97, 17)
        Me.cbOdevKonu.TabIndex = 23
        Me.cbOdevKonu.Text = "Ödev Konusu :"
        Me.cbOdevKonu.UseVisualStyleBackColor = False
        '
        'cbOdevVerTarih
        '
        Me.cbOdevVerTarih.AutoSize = True
        Me.cbOdevVerTarih.BackColor = System.Drawing.Color.Transparent
        Me.cbOdevVerTarih.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cbOdevVerTarih.Location = New System.Drawing.Point(533, 340)
        Me.cbOdevVerTarih.Name = "cbOdevVerTarih"
        Me.cbOdevVerTarih.Size = New System.Drawing.Size(117, 17)
        Me.cbOdevVerTarih.TabIndex = 24
        Me.cbOdevVerTarih.Text = "Ödev Veriliş Tarihi :"
        Me.cbOdevVerTarih.UseVisualStyleBackColor = False
        '
        'txtAdi
        '
        Me.txtAdi.Location = New System.Drawing.Point(159, 275)
        Me.txtAdi.Name = "txtAdi"
        Me.txtAdi.Size = New System.Drawing.Size(134, 20)
        Me.txtAdi.TabIndex = 25
        '
        'txtSoyadi
        '
        Me.txtSoyadi.Location = New System.Drawing.Point(159, 307)
        Me.txtSoyadi.Name = "txtSoyadi"
        Me.txtSoyadi.Size = New System.Drawing.Size(134, 20)
        Me.txtSoyadi.TabIndex = 26
        '
        'txtSinifi
        '
        Me.txtSinifi.Location = New System.Drawing.Point(159, 338)
        Me.txtSinifi.Name = "txtSinifi"
        Me.txtSinifi.Size = New System.Drawing.Size(134, 20)
        Me.txtSinifi.TabIndex = 27
        '
        'txtNumarasi
        '
        Me.txtNumarasi.Location = New System.Drawing.Point(159, 371)
        Me.txtNumarasi.Name = "txtNumarasi"
        Me.txtNumarasi.Size = New System.Drawing.Size(134, 20)
        Me.txtNumarasi.TabIndex = 28
        '
        'cmbBolumu
        '
        Me.cmbBolumu.FormattingEnabled = True
        Me.cmbBolumu.Items.AddRange(New Object() {"Bilgisayar Programcılığı", "İnşaat Teknolojileri", "Elektrik Elektronik Teknolojileri", "Makina Teknolojileri"})
        Me.cmbBolumu.Location = New System.Drawing.Point(159, 405)
        Me.cmbBolumu.Name = "cmbBolumu"
        Me.cmbBolumu.Size = New System.Drawing.Size(134, 21)
        Me.cmbBolumu.TabIndex = 29
        '
        'cbOdevTesTarih
        '
        Me.cbOdevTesTarih.AutoSize = True
        Me.cbOdevTesTarih.BackColor = System.Drawing.Color.Transparent
        Me.cbOdevTesTarih.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cbOdevTesTarih.Location = New System.Drawing.Point(533, 373)
        Me.cbOdevTesTarih.Name = "cbOdevTesTarih"
        Me.cbOdevTesTarih.Size = New System.Drawing.Size(120, 17)
        Me.cbOdevTesTarih.TabIndex = 30
        Me.cbOdevTesTarih.Text = "Ödev Teslim Tarihi :"
        Me.cbOdevTesTarih.UseVisualStyleBackColor = False
        '
        'cbOdevNot
        '
        Me.cbOdevNot.AutoSize = True
        Me.cbOdevNot.BackColor = System.Drawing.Color.Transparent
        Me.cbOdevNot.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cbOdevNot.Location = New System.Drawing.Point(533, 407)
        Me.cbOdevNot.Name = "cbOdevNot"
        Me.cbOdevNot.Size = New System.Drawing.Size(49, 17)
        Me.cbOdevNot.TabIndex = 31
        Me.cbOdevNot.Text = "Not :"
        Me.cbOdevNot.UseVisualStyleBackColor = False
        '
        'cmbOdevDers
        '
        Me.cmbOdevDers.FormattingEnabled = True
        Me.cmbOdevDers.Items.AddRange(New Object() {"Bilgisayar Programcılığı", "İnşaat Teknolojileri", "Elektrik Elektronik Teknolojileri", "Makina Teknolojileri"})
        Me.cmbOdevDers.Location = New System.Drawing.Point(688, 275)
        Me.cmbOdevDers.Name = "cmbOdevDers"
        Me.cmbOdevDers.Size = New System.Drawing.Size(125, 21)
        Me.cmbOdevDers.TabIndex = 32
        '
        'txtOdevKonu
        '
        Me.txtOdevKonu.Location = New System.Drawing.Point(688, 307)
        Me.txtOdevKonu.Name = "txtOdevKonu"
        Me.txtOdevKonu.Size = New System.Drawing.Size(125, 20)
        Me.txtOdevKonu.TabIndex = 33
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(688, 335)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(166, 20)
        Me.DateTimePicker1.TabIndex = 34
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(688, 368)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(166, 20)
        Me.DateTimePicker2.TabIndex = 35
        '
        'txtNot
        '
        Me.txtNot.Location = New System.Drawing.Point(688, 405)
        Me.txtNot.Name = "txtNot"
        Me.txtNot.Size = New System.Drawing.Size(125, 20)
        Me.txtNot.TabIndex = 36
        '
        'cbSinavDers
        '
        Me.cbSinavDers.AutoSize = True
        Me.cbSinavDers.BackColor = System.Drawing.Color.Transparent
        Me.cbSinavDers.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cbSinavDers.Location = New System.Drawing.Point(899, 277)
        Me.cbSinavDers.Name = "cbSinavDers"
        Me.cbSinavDers.Size = New System.Drawing.Size(122, 17)
        Me.cbSinavDers.TabIndex = 37
        Me.cbSinavDers.Text = "Sınav Yapılan Ders :"
        Me.cbSinavDers.UseVisualStyleBackColor = False
        '
        'cbSinavTarih
        '
        Me.cbSinavTarih.AutoSize = True
        Me.cbSinavTarih.BackColor = System.Drawing.Color.Transparent
        Me.cbSinavTarih.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cbSinavTarih.Location = New System.Drawing.Point(899, 309)
        Me.cbSinavTarih.Name = "cbSinavTarih"
        Me.cbSinavTarih.Size = New System.Drawing.Size(88, 17)
        Me.cbSinavTarih.TabIndex = 38
        Me.cbSinavTarih.Text = "Sınav Tarihi :"
        Me.cbSinavTarih.UseVisualStyleBackColor = False
        '
        'cbSinavNot
        '
        Me.cbSinavNot.AutoSize = True
        Me.cbSinavNot.BackColor = System.Drawing.Color.Transparent
        Me.cbSinavNot.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cbSinavNot.Location = New System.Drawing.Point(899, 340)
        Me.cbSinavNot.Name = "cbSinavNot"
        Me.cbSinavNot.Size = New System.Drawing.Size(49, 17)
        Me.cbSinavNot.TabIndex = 39
        Me.cbSinavNot.Text = "Not :"
        Me.cbSinavNot.UseVisualStyleBackColor = False
        '
        'btnKapat
        '
        Me.btnKapat.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnKapat.Image = Global.ogrenciTakip.My.Resources.Resources._1478968096_Close_Box_Red
        Me.btnKapat.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnKapat.Location = New System.Drawing.Point(1110, 407)
        Me.btnKapat.Name = "btnKapat"
        Me.btnKapat.Size = New System.Drawing.Size(82, 58)
        Me.btnKapat.TabIndex = 43
        Me.btnKapat.Text = "Kapat"
        Me.btnKapat.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnKapat.UseVisualStyleBackColor = False
        '
        'btnGuncelle
        '
        Me.btnGuncelle.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnGuncelle.Image = Global.ogrenciTakip.My.Resources.Resources._1478969498_update
        Me.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuncelle.Location = New System.Drawing.Point(959, 407)
        Me.btnGuncelle.Name = "btnGuncelle"
        Me.btnGuncelle.Size = New System.Drawing.Size(125, 58)
        Me.btnGuncelle.TabIndex = 44
        Me.btnGuncelle.Text = "Güncelle"
        Me.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuncelle.UseVisualStyleBackColor = False
        '
        'cbHepsiniSec
        '
        Me.cbHepsiniSec.AutoSize = True
        Me.cbHepsiniSec.BackColor = System.Drawing.Color.Transparent
        Me.cbHepsiniSec.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cbHepsiniSec.Location = New System.Drawing.Point(959, 382)
        Me.cbHepsiniSec.Name = "cbHepsiniSec"
        Me.cbHepsiniSec.Size = New System.Drawing.Size(218, 17)
        Me.cbHepsiniSec.TabIndex = 45
        Me.cbHepsiniSec.Text = "Tüm Alanları İşaretle / Tüm Alanları Sıfırla"
        Me.cbHepsiniSec.UseVisualStyleBackColor = False
        '
        'btnResimSec
        '
        Me.btnResimSec.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnResimSec.Image = Global.ogrenciTakip.My.Resources.Resources._1478968766_Import
        Me.btnResimSec.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnResimSec.Location = New System.Drawing.Point(395, 418)
        Me.btnResimSec.Name = "btnResimSec"
        Me.btnResimSec.Size = New System.Drawing.Size(75, 52)
        Me.btnResimSec.TabIndex = 47
        Me.btnResimSec.Text = "Resim Seç"
        Me.btnResimSec.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnResimSec.UseVisualStyleBackColor = False
        '
        'pbxOgrResmi
        '
        Me.pbxOgrResmi.Location = New System.Drawing.Point(328, 275)
        Me.pbxOgrResmi.Name = "pbxOgrResmi"
        Me.pbxOgrResmi.Size = New System.Drawing.Size(151, 137)
        Me.pbxOgrResmi.TabIndex = 46
        Me.pbxOgrResmi.TabStop = False
        '
        'cbResim
        '
        Me.cbResim.AutoSize = True
        Me.cbResim.BackColor = System.Drawing.Color.Transparent
        Me.cbResim.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cbResim.Location = New System.Drawing.Point(328, 436)
        Me.cbResim.Name = "cbResim"
        Me.cbResim.Size = New System.Drawing.Size(61, 17)
        Me.cbResim.TabIndex = 48
        Me.cbResim.Text = "Resim :"
        Me.cbResim.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ogrTakip6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ogrenciTakip.My.Resources.Resources.green_307835_640
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1267, 558)
        Me.Controls.Add(Me.cbResim)
        Me.Controls.Add(Me.btnResimSec)
        Me.Controls.Add(Me.pbxOgrResmi)
        Me.Controls.Add(Me.cbHepsiniSec)
        Me.Controls.Add(Me.btnGuncelle)
        Me.Controls.Add(Me.btnKapat)
        Me.Controls.Add(Me.DateTimePicker3)
        Me.Controls.Add(Me.cmbSinavDersi)
        Me.Controls.Add(Me.txtNot2)
        Me.Controls.Add(Me.cbSinavNot)
        Me.Controls.Add(Me.cbSinavTarih)
        Me.Controls.Add(Me.cbSinavDers)
        Me.Controls.Add(Me.txtNot)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtOdevKonu)
        Me.Controls.Add(Me.cmbOdevDers)
        Me.Controls.Add(Me.cbOdevNot)
        Me.Controls.Add(Me.cbOdevTesTarih)
        Me.Controls.Add(Me.cmbBolumu)
        Me.Controls.Add(Me.txtNumarasi)
        Me.Controls.Add(Me.txtSinifi)
        Me.Controls.Add(Me.txtSoyadi)
        Me.Controls.Add(Me.txtAdi)
        Me.Controls.Add(Me.cbOdevVerTarih)
        Me.Controls.Add(Me.cbOdevKonu)
        Me.Controls.Add(Me.cbOdevDers)
        Me.Controls.Add(Me.cbBolumu)
        Me.Controls.Add(Me.cbNumarasi)
        Me.Controls.Add(Me.cbSinifi)
        Me.Controls.Add(Me.cbSoyadi)
        Me.Controls.Add(Me.cbAdi)
        Me.Controls.Add(Me.txtOgrNumarasi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgOgrenci)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ogrTakip6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ogrTakip6"
        CType(Me.dgOgrenci, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxOgrResmi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgOgrenci As System.Windows.Forms.DataGridView
    Friend WithEvents txtOgrNumarasi As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNot2 As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbSinavDersi As System.Windows.Forms.ComboBox
    Friend WithEvents cbAdi As System.Windows.Forms.CheckBox
    Friend WithEvents cbSoyadi As System.Windows.Forms.CheckBox
    Friend WithEvents cbSinifi As System.Windows.Forms.CheckBox
    Friend WithEvents cbNumarasi As System.Windows.Forms.CheckBox
    Friend WithEvents cbBolumu As System.Windows.Forms.CheckBox
    Friend WithEvents cbOdevDers As System.Windows.Forms.CheckBox
    Friend WithEvents cbOdevKonu As System.Windows.Forms.CheckBox
    Friend WithEvents cbOdevVerTarih As System.Windows.Forms.CheckBox
    Friend WithEvents txtAdi As System.Windows.Forms.TextBox
    Friend WithEvents txtSoyadi As System.Windows.Forms.TextBox
    Friend WithEvents txtSinifi As System.Windows.Forms.TextBox
    Friend WithEvents txtNumarasi As System.Windows.Forms.TextBox
    Friend WithEvents cmbBolumu As System.Windows.Forms.ComboBox
    Friend WithEvents cbOdevTesTarih As System.Windows.Forms.CheckBox
    Friend WithEvents cbOdevNot As System.Windows.Forms.CheckBox
    Friend WithEvents cmbOdevDers As System.Windows.Forms.ComboBox
    Friend WithEvents txtOdevKonu As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNot As System.Windows.Forms.TextBox
    Friend WithEvents cbSinavDers As System.Windows.Forms.CheckBox
    Friend WithEvents cbSinavTarih As System.Windows.Forms.CheckBox
    Friend WithEvents cbSinavNot As System.Windows.Forms.CheckBox
    Friend WithEvents btnKapat As System.Windows.Forms.Button
    Friend WithEvents btnGuncelle As System.Windows.Forms.Button
    Friend WithEvents cbHepsiniSec As System.Windows.Forms.CheckBox
    Friend WithEvents btnResimSec As System.Windows.Forms.Button
    Friend WithEvents pbxOgrResmi As System.Windows.Forms.PictureBox
    Friend WithEvents cbResim As System.Windows.Forms.CheckBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
