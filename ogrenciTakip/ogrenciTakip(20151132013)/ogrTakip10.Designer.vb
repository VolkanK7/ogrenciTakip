<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ogrTakip10
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
        Me.txtOgrNumarasi = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgOgrenci = New System.Windows.Forms.DataGridView()
        Me.btnKapat = New System.Windows.Forms.Button()
        Me.btnGüncelle = New System.Windows.Forms.Button()
        Me.txtNot = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtTarih = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbSinavDersi = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgOgrenci, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Baskerville Old Face", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(144, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(418, 27)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "KAYIT GUNCELLEME ISLEMLERI"
        '
        'txtOgrNumarasi
        '
        Me.txtOgrNumarasi.Location = New System.Drawing.Point(160, 81)
        Me.txtOgrNumarasi.Name = "txtOgrNumarasi"
        Me.txtOgrNumarasi.Size = New System.Drawing.Size(125, 20)
        Me.txtOgrNumarasi.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(69, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 16)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Öğrenci Ara :"
        '
        'dgOgrenci
        '
        Me.dgOgrenci.AllowUserToAddRows = False
        Me.dgOgrenci.AllowUserToDeleteRows = False
        Me.dgOgrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgOgrenci.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column2, Me.Column1, Me.Column3, Me.Column4})
        Me.dgOgrenci.Location = New System.Drawing.Point(72, 110)
        Me.dgOgrenci.Name = "dgOgrenci"
        Me.dgOgrenci.ReadOnly = True
        Me.dgOgrenci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgOgrenci.Size = New System.Drawing.Size(515, 183)
        Me.dgOgrenci.TabIndex = 44
        '
        'btnKapat
        '
        Me.btnKapat.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnKapat.Image = Global.ogrenciTakip.My.Resources.Resources._1478968096_Close_Box_Red
        Me.btnKapat.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnKapat.Location = New System.Drawing.Point(490, 386)
        Me.btnKapat.Name = "btnKapat"
        Me.btnKapat.Size = New System.Drawing.Size(97, 55)
        Me.btnKapat.TabIndex = 55
        Me.btnKapat.Text = "Kapat"
        Me.btnKapat.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnKapat.UseVisualStyleBackColor = False
        '
        'btnGüncelle
        '
        Me.btnGüncelle.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnGüncelle.Image = Global.ogrenciTakip.My.Resources.Resources._1478969498_update
        Me.btnGüncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGüncelle.Location = New System.Drawing.Point(490, 316)
        Me.btnGüncelle.Name = "btnGüncelle"
        Me.btnGüncelle.Size = New System.Drawing.Size(97, 55)
        Me.btnGüncelle.TabIndex = 54
        Me.btnGüncelle.Text = "Güncelle"
        Me.btnGüncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGüncelle.UseVisualStyleBackColor = False
        '
        'txtNot
        '
        Me.txtNot.Location = New System.Drawing.Point(268, 404)
        Me.txtNot.Name = "txtNot"
        Me.txtNot.Size = New System.Drawing.Size(125, 20)
        Me.txtNot.TabIndex = 53
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label11.Location = New System.Drawing.Point(100, 405)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 16)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "Not :"
        '
        'dtTarih
        '
        Me.dtTarih.Location = New System.Drawing.Point(242, 370)
        Me.dtTarih.Name = "dtTarih"
        Me.dtTarih.Size = New System.Drawing.Size(200, 20)
        Me.dtTarih.TabIndex = 51
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(100, 374)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 16)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Sınav Tarihi :"
        '
        'cmbSinavDersi
        '
        Me.cmbSinavDersi.FormattingEnabled = True
        Me.cmbSinavDersi.Items.AddRange(New Object() {"Bilgisayar Programcılığı", "İnşaat Teknolojileri", "Elektrik Elektronik Teknolojileri", "Makina Teknolojileri"})
        Me.cmbSinavDersi.Location = New System.Drawing.Point(242, 338)
        Me.cmbSinavDersi.Name = "cmbSinavDersi"
        Me.cmbSinavDersi.Size = New System.Drawing.Size(200, 21)
        Me.cmbSinavDersi.TabIndex = 49
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(100, 339)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 16)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Sınav Yapılan Ders :"
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
        'Column1
        '
        Me.Column1.HeaderText = "Ders"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Sınav Tarihi"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Sınav Notu"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'ogrTakip10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ogrenciTakip.My.Resources.Resources.green_307835_640
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(672, 537)
        Me.Controls.Add(Me.btnKapat)
        Me.Controls.Add(Me.btnGüncelle)
        Me.Controls.Add(Me.txtNot)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dtTarih)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbSinavDersi)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtOgrNumarasi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgOgrenci)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ogrTakip10"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ogrTakip10"
        CType(Me.dgOgrenci, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtOgrNumarasi As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgOgrenci As System.Windows.Forms.DataGridView
    Friend WithEvents btnKapat As System.Windows.Forms.Button
    Friend WithEvents btnGüncelle As System.Windows.Forms.Button
    Friend WithEvents txtNot As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtTarih As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbSinavDersi As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
