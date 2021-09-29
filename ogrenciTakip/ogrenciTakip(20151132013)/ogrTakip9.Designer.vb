<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ogrTakip9
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
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnKapat = New System.Windows.Forms.Button()
        Me.btnGüncelle = New System.Windows.Forms.Button()
        Me.txtNot = New System.Windows.Forms.TextBox()
        Me.dtTeslim = New System.Windows.Forms.DateTimePicker()
        Me.dtVerilis = New System.Windows.Forms.DateTimePicker()
        Me.txtOdevKonu = New System.Windows.Forms.TextBox()
        Me.cmbOdevDers = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dgOgrenci, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Baskerville Old Face", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(204, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(418, 27)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "KAYIT GUNCELLEME ISLEMLERI"
        '
        'txtOgrNumarasi
        '
        Me.txtOgrNumarasi.Location = New System.Drawing.Point(160, 83)
        Me.txtOgrNumarasi.Name = "txtOgrNumarasi"
        Me.txtOgrNumarasi.Size = New System.Drawing.Size(125, 20)
        Me.txtOgrNumarasi.TabIndex = 42
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(69, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 16)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Öğrenci Ara :"
        '
        'dgOgrenci
        '
        Me.dgOgrenci.AllowUserToAddRows = False
        Me.dgOgrenci.AllowUserToDeleteRows = False
        Me.dgOgrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgOgrenci.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column2, Me.Column1, Me.Column6, Me.Column3, Me.Column4, Me.Column5})
        Me.dgOgrenci.Location = New System.Drawing.Point(72, 112)
        Me.dgOgrenci.Name = "dgOgrenci"
        Me.dgOgrenci.ReadOnly = True
        Me.dgOgrenci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgOgrenci.Size = New System.Drawing.Size(624, 183)
        Me.dgOgrenci.TabIndex = 40
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
        'Column6
        '
        Me.Column6.HeaderText = "Konu"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Veriliş Tarih"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Teslim Tarih"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Not"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'btnKapat
        '
        Me.btnKapat.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnKapat.Image = Global.ogrenciTakip.My.Resources.Resources._1478968096_Close_Box_Red
        Me.btnKapat.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnKapat.Location = New System.Drawing.Point(530, 405)
        Me.btnKapat.Name = "btnKapat"
        Me.btnKapat.Size = New System.Drawing.Size(92, 55)
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
        Me.btnGüncelle.Location = New System.Drawing.Point(530, 329)
        Me.btnGüncelle.Name = "btnGüncelle"
        Me.btnGüncelle.Size = New System.Drawing.Size(92, 55)
        Me.btnGüncelle.TabIndex = 54
        Me.btnGüncelle.Text = "Güncelle"
        Me.btnGüncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGüncelle.UseVisualStyleBackColor = False
        '
        'txtNot
        '
        Me.txtNot.Location = New System.Drawing.Point(329, 459)
        Me.txtNot.Name = "txtNot"
        Me.txtNot.Size = New System.Drawing.Size(125, 20)
        Me.txtNot.TabIndex = 53
        '
        'dtTeslim
        '
        Me.dtTeslim.Location = New System.Drawing.Point(302, 424)
        Me.dtTeslim.Name = "dtTeslim"
        Me.dtTeslim.Size = New System.Drawing.Size(174, 20)
        Me.dtTeslim.TabIndex = 52
        '
        'dtVerilis
        '
        Me.dtVerilis.Location = New System.Drawing.Point(302, 389)
        Me.dtVerilis.Name = "dtVerilis"
        Me.dtVerilis.Size = New System.Drawing.Size(174, 20)
        Me.dtVerilis.TabIndex = 51
        '
        'txtOdevKonu
        '
        Me.txtOdevKonu.Location = New System.Drawing.Point(302, 357)
        Me.txtOdevKonu.Name = "txtOdevKonu"
        Me.txtOdevKonu.Size = New System.Drawing.Size(174, 20)
        Me.txtOdevKonu.TabIndex = 50
        '
        'cmbOdevDers
        '
        Me.cmbOdevDers.FormattingEnabled = True
        Me.cmbOdevDers.Items.AddRange(New Object() {"Bilgisayar Programcılığı", "İnşaat Teknolojileri", "Elektrik Elektronik Teknolojileri", "Makina Teknolojileri"})
        Me.cmbOdevDers.Location = New System.Drawing.Point(302, 324)
        Me.cmbOdevDers.Name = "cmbOdevDers"
        Me.cmbOdevDers.Size = New System.Drawing.Size(174, 21)
        Me.cmbOdevDers.TabIndex = 49
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label11.Location = New System.Drawing.Point(178, 460)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 16)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Not :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label10.Location = New System.Drawing.Point(157, 428)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 16)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Teslim Tarihi :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(156, 393)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 16)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Veriliş Tarihi :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(155, 358)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 16)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Ödev Konusu :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(155, 325)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 16)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Ödev Verilen Ders :"
        '
        'ogrTakip9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ogrenciTakip.My.Resources.Resources.green_307835_640
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(765, 577)
        Me.Controls.Add(Me.btnKapat)
        Me.Controls.Add(Me.btnGüncelle)
        Me.Controls.Add(Me.txtNot)
        Me.Controls.Add(Me.dtTeslim)
        Me.Controls.Add(Me.dtVerilis)
        Me.Controls.Add(Me.txtOdevKonu)
        Me.Controls.Add(Me.cmbOdevDers)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtOgrNumarasi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgOgrenci)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ogrTakip9"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ogrTakip9"
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
    Friend WithEvents dtTeslim As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtVerilis As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtOdevKonu As System.Windows.Forms.TextBox
    Friend WithEvents cmbOdevDers As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
