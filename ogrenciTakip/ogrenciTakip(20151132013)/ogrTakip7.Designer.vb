<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ogrTakip7
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
        Me.btnNotIslemleri = New System.Windows.Forms.Button()
        Me.btnOdevIslemleri = New System.Windows.Forms.Button()
        Me.btnKayitListe = New System.Windows.Forms.Button()
        Me.btnKapat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnNotIslemleri
        '
        Me.btnNotIslemleri.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnNotIslemleri.Image = Global.ogrenciTakip.My.Resources.Resources._1479766259_document_03
        Me.btnNotIslemleri.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNotIslemleri.Location = New System.Drawing.Point(76, 139)
        Me.btnNotIslemleri.Name = "btnNotIslemleri"
        Me.btnNotIslemleri.Size = New System.Drawing.Size(135, 67)
        Me.btnNotIslemleri.TabIndex = 8
        Me.btnNotIslemleri.Text = "Öğrenci Sınav Bilgieri Güncelle"
        Me.btnNotIslemleri.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNotIslemleri.UseVisualStyleBackColor = False
        '
        'btnOdevIslemleri
        '
        Me.btnOdevIslemleri.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnOdevIslemleri.Image = Global.ogrenciTakip.My.Resources.Resources._1479766259_document_03
        Me.btnOdevIslemleri.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnOdevIslemleri.Location = New System.Drawing.Point(234, 139)
        Me.btnOdevIslemleri.Name = "btnOdevIslemleri"
        Me.btnOdevIslemleri.Size = New System.Drawing.Size(135, 67)
        Me.btnOdevIslemleri.TabIndex = 7
        Me.btnOdevIslemleri.Text = "Öğrenci Ödev Bilgieri Güncelle"
        Me.btnOdevIslemleri.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnOdevIslemleri.UseVisualStyleBackColor = False
        '
        'btnKayitListe
        '
        Me.btnKayitListe.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnKayitListe.Image = Global.ogrenciTakip.My.Resources.Resources._1479766764_preferences_contact_list
        Me.btnKayitListe.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnKayitListe.Location = New System.Drawing.Point(137, 57)
        Me.btnKayitListe.Name = "btnKayitListe"
        Me.btnKayitListe.Size = New System.Drawing.Size(173, 66)
        Me.btnKayitListe.TabIndex = 6
        Me.btnKayitListe.Text = "Öğrenci Bilgileri Güncelle"
        Me.btnKayitListe.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnKayitListe.UseVisualStyleBackColor = False
        '
        'btnKapat
        '
        Me.btnKapat.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnKapat.Image = Global.ogrenciTakip.My.Resources.Resources._1478968096_Close_Box_Red
        Me.btnKapat.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnKapat.Location = New System.Drawing.Point(180, 221)
        Me.btnKapat.Name = "btnKapat"
        Me.btnKapat.Size = New System.Drawing.Size(84, 57)
        Me.btnKapat.TabIndex = 9
        Me.btnKapat.Text = "Kapat"
        Me.btnKapat.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnKapat.UseVisualStyleBackColor = False
        '
        'ogrTakip7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ogrenciTakip.My.Resources.Resources.chalkboard_01
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(445, 338)
        Me.Controls.Add(Me.btnKapat)
        Me.Controls.Add(Me.btnNotIslemleri)
        Me.Controls.Add(Me.btnOdevIslemleri)
        Me.Controls.Add(Me.btnKayitListe)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ogrTakip7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ogrTakip7"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnNotIslemleri As System.Windows.Forms.Button
    Friend WithEvents btnOdevIslemleri As System.Windows.Forms.Button
    Friend WithEvents btnKayitListe As System.Windows.Forms.Button
    Friend WithEvents btnKapat As System.Windows.Forms.Button
End Class
