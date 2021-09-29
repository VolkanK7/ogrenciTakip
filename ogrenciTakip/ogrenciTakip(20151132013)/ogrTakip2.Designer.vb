<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ogrTakip2
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
        Me.btnKapat = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAdi = New System.Windows.Forms.TextBox()
        Me.txtSoyadi = New System.Windows.Forms.TextBox()
        Me.txtSinifi = New System.Windows.Forms.TextBox()
        Me.txtNumarasi = New System.Windows.Forms.TextBox()
        Me.cmbBolumu = New System.Windows.Forms.ComboBox()
        Me.pbxOgrResmi = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnKaydet = New System.Windows.Forms.Button()
        Me.btnResimSec = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtResimYolu = New System.Windows.Forms.TextBox()
        CType(Me.pbxOgrResmi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnKapat
        '
        Me.btnKapat.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnKapat.Image = Global.ogrenciTakip.My.Resources.Resources._1478968096_Close_Box_Red
        Me.btnKapat.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnKapat.Location = New System.Drawing.Point(450, 192)
        Me.btnKapat.Name = "btnKapat"
        Me.btnKapat.Size = New System.Drawing.Size(79, 58)
        Me.btnKapat.TabIndex = 0
        Me.btnKapat.Text = "Kapat"
        Me.btnKapat.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnKapat.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Baskerville Old Face", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(121, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "OGRENCI KAYIT ISLEMLERI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(53, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Adı :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(53, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Soyadı :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(53, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Sınıfı :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(53, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Numarası :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(53, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Bölümü :"
        '
        'txtAdi
        '
        Me.txtAdi.Location = New System.Drawing.Point(126, 128)
        Me.txtAdi.Name = "txtAdi"
        Me.txtAdi.Size = New System.Drawing.Size(134, 20)
        Me.txtAdi.TabIndex = 7
        '
        'txtSoyadi
        '
        Me.txtSoyadi.Location = New System.Drawing.Point(126, 155)
        Me.txtSoyadi.Name = "txtSoyadi"
        Me.txtSoyadi.Size = New System.Drawing.Size(134, 20)
        Me.txtSoyadi.TabIndex = 8
        '
        'txtSinifi
        '
        Me.txtSinifi.Location = New System.Drawing.Point(126, 183)
        Me.txtSinifi.Name = "txtSinifi"
        Me.txtSinifi.Size = New System.Drawing.Size(134, 20)
        Me.txtSinifi.TabIndex = 9
        '
        'txtNumarasi
        '
        Me.txtNumarasi.Location = New System.Drawing.Point(126, 212)
        Me.txtNumarasi.Name = "txtNumarasi"
        Me.txtNumarasi.Size = New System.Drawing.Size(134, 20)
        Me.txtNumarasi.TabIndex = 10
        '
        'cmbBolumu
        '
        Me.cmbBolumu.FormattingEnabled = True
        Me.cmbBolumu.Items.AddRange(New Object() {"Bilgisayar Programcılığı", "İnşaat Teknolojileri", "Elektrik Elektronik Teknolojileri", "Makina Teknolojileri"})
        Me.cmbBolumu.Location = New System.Drawing.Point(126, 240)
        Me.cmbBolumu.Name = "cmbBolumu"
        Me.cmbBolumu.Size = New System.Drawing.Size(134, 21)
        Me.cmbBolumu.TabIndex = 11
        '
        'pbxOgrResmi
        '
        Me.pbxOgrResmi.Location = New System.Drawing.Point(282, 107)
        Me.pbxOgrResmi.Name = "pbxOgrResmi"
        Me.pbxOgrResmi.Size = New System.Drawing.Size(151, 171)
        Me.pbxOgrResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxOgrResmi.TabIndex = 12
        Me.pbxOgrResmi.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(315, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Öğrenci Resmi :"
        '
        'btnKaydet
        '
        Me.btnKaydet.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnKaydet.Image = Global.ogrenciTakip.My.Resources.Resources._1478967829_save
        Me.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnKaydet.Location = New System.Drawing.Point(450, 120)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(79, 58)
        Me.btnKaydet.TabIndex = 14
        Me.btnKaydet.Text = "Kaydet"
        Me.btnKaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnKaydet.UseVisualStyleBackColor = False
        '
        'btnResimSec
        '
        Me.btnResimSec.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnResimSec.Image = Global.ogrenciTakip.My.Resources.Resources._1478968766_Import
        Me.btnResimSec.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnResimSec.Location = New System.Drawing.Point(318, 284)
        Me.btnResimSec.Name = "btnResimSec"
        Me.btnResimSec.Size = New System.Drawing.Size(75, 52)
        Me.btnResimSec.TabIndex = 15
        Me.btnResimSec.Text = "Resim Seç"
        Me.btnResimSec.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnResimSec.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtResimYolu
        '
        Me.txtResimYolu.Location = New System.Drawing.Point(399, 300)
        Me.txtResimYolu.Name = "txtResimYolu"
        Me.txtResimYolu.Size = New System.Drawing.Size(82, 20)
        Me.txtResimYolu.TabIndex = 16
        Me.txtResimYolu.Visible = False
        '
        'ogrTakip2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ogrenciTakip.My.Resources.Resources.green_307835_640
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(591, 380)
        Me.Controls.Add(Me.txtResimYolu)
        Me.Controls.Add(Me.btnResimSec)
        Me.Controls.Add(Me.btnKaydet)
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
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnKapat)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ogrTakip2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ogrTakip2"
        CType(Me.pbxOgrResmi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnKapat As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAdi As System.Windows.Forms.TextBox
    Friend WithEvents txtSoyadi As System.Windows.Forms.TextBox
    Friend WithEvents txtSinifi As System.Windows.Forms.TextBox
    Friend WithEvents txtNumarasi As System.Windows.Forms.TextBox
    Friend WithEvents cmbBolumu As System.Windows.Forms.ComboBox
    Friend WithEvents pbxOgrResmi As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnKaydet As System.Windows.Forms.Button
    Friend WithEvents btnResimSec As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtResimYolu As System.Windows.Forms.TextBox
End Class
