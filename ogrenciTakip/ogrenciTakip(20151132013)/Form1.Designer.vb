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
        Me.btnKapat = New System.Windows.Forms.Button()
        Me.txtKullaniciAdi = New System.Windows.Forms.TextBox()
        Me.txtSifre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGiris = New System.Windows.Forms.Button()
        Me.btnSifremiUnuttum = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnKapat
        '
        Me.btnKapat.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnKapat.Image = Global.ogrenciTakip.My.Resources.Resources._1478968096_Close_Box_Red
        Me.btnKapat.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnKapat.Location = New System.Drawing.Point(214, 237)
        Me.btnKapat.Name = "btnKapat"
        Me.btnKapat.Size = New System.Drawing.Size(105, 55)
        Me.btnKapat.TabIndex = 0
        Me.btnKapat.Text = "Kapat"
        Me.btnKapat.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnKapat.UseVisualStyleBackColor = False
        '
        'txtKullaniciAdi
        '
        Me.txtKullaniciAdi.Location = New System.Drawing.Point(173, 92)
        Me.txtKullaniciAdi.Name = "txtKullaniciAdi"
        Me.txtKullaniciAdi.Size = New System.Drawing.Size(128, 20)
        Me.txtKullaniciAdi.TabIndex = 1
        '
        'txtSifre
        '
        Me.txtSifre.Location = New System.Drawing.Point(173, 129)
        Me.txtSifre.Name = "txtSifre"
        Me.txtSifre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSifre.Size = New System.Drawing.Size(128, 20)
        Me.txtSifre.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(74, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Kullanıcı Adı :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(110, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Şifre :"
        '
        'btnGiris
        '
        Me.btnGiris.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnGiris.Image = Global.ogrenciTakip.My.Resources.Resources._1478968886_4
        Me.btnGiris.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGiris.Location = New System.Drawing.Point(103, 176)
        Me.btnGiris.Name = "btnGiris"
        Me.btnGiris.Size = New System.Drawing.Size(216, 55)
        Me.btnGiris.TabIndex = 5
        Me.btnGiris.Text = "Giriş"
        Me.btnGiris.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGiris.UseVisualStyleBackColor = False
        '
        'btnSifremiUnuttum
        '
        Me.btnSifremiUnuttum.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSifremiUnuttum.Image = Global.ogrenciTakip.My.Resources.Resources._1478968970_Help
        Me.btnSifremiUnuttum.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSifremiUnuttum.Location = New System.Drawing.Point(103, 237)
        Me.btnSifremiUnuttum.Name = "btnSifremiUnuttum"
        Me.btnSifremiUnuttum.Size = New System.Drawing.Size(105, 55)
        Me.btnSifremiUnuttum.TabIndex = 6
        Me.btnSifremiUnuttum.Text = "Şifremi Unuttum"
        Me.btnSifremiUnuttum.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSifremiUnuttum.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Baskerville Old Face", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(108, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(213, 27)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "GOREVLI GIRISI"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ogrenciTakip.My.Resources.Resources.chalkboard_01
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(409, 344)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSifremiUnuttum)
        Me.Controls.Add(Me.btnGiris)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSifre)
        Me.Controls.Add(Me.txtKullaniciAdi)
        Me.Controls.Add(Me.btnKapat)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnKapat As System.Windows.Forms.Button
    Friend WithEvents txtKullaniciAdi As System.Windows.Forms.TextBox
    Friend WithEvents txtSifre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnGiris As System.Windows.Forms.Button
    Friend WithEvents btnSifremiUnuttum As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
