Public Class ogrTakip2

    Private Sub btnKapat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKapat.Click
        ogrTakip1.Show()
        Me.Hide()
    End Sub

    Private Sub ogrTakip2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnKaydet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKaydet.Click

        If txtAdi.Text = "" Or txtNumarasi.Text = "" Or txtSinifi.Text = "" Or txtSoyadi.Text = "" Or cmbBolumu.Text = "" Then
            MsgBox("Lütfen Tüm Alanları Doldurunuz.", MsgBoxStyle.Critical, Title:="Hata")
            Return
        End If

        Dim numara As Integer = Convert.ToInt64(txtNumarasi.Text)
        sqlCalistir("insert into ogrenci(ad,soyad,sinif,ogr_no,bolum,resim) values('" & txtAdi.Text & "','" & txtSoyadi.Text & "','" & txtSinifi.Text & "'," & numara & ",'" & cmbBolumu.Text & "','" & txtResimYolu.Text & "')")
        MsgBox("Kayıt Eklendi", MsgBoxStyle.Information, "İşlem Tamam")

        txtAdi.Clear()
        txtNumarasi.Clear()
        txtSinifi.Clear()
        txtSoyadi.Clear()
        cmbBolumu.ResetText()
        pbxOgrResmi.Image = Nothing

    End Sub

    Private Sub btnResimSec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResimSec.Click
       If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            pbxOgrResmi.ImageLocation = OpenFileDialog1.FileName
            txtResimYolu.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub txtNumarasi_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumarasi.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
             Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub pbxOgrResmi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxOgrResmi.Click

    End Sub
End Class