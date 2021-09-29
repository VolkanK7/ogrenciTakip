Public Class ogrTakip6

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAdi.CheckedChanged

    End Sub
    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSoyadi.CheckedChanged

    End Sub
    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSinifi.CheckedChanged

    End Sub
    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbNumarasi.CheckedChanged

    End Sub
    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBolumu.CheckedChanged

    End Sub
    Private Sub DateTimePicker3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker3.ValueChanged

    End Sub
    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbOdevDers.CheckedChanged

    End Sub
    Private Sub CheckBox7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbOdevKonu.CheckedChanged

    End Sub
    Private Sub CheckBox8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbOdevVerTarih.CheckedChanged

    End Sub
    Private Sub txtAdi_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdi.TextChanged

    End Sub
    Private Sub txtSoyadi_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSoyadi.TextChanged

    End Sub
    Private Sub txtSinifi_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSinifi.TextChanged

    End Sub
    Private Sub txtNumarasi_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumarasi.TextChanged

    End Sub
    Private Sub cmbBolumu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBolumu.SelectedIndexChanged

    End Sub
    Private Sub CheckBox9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbOdevTesTarih.CheckedChanged

    End Sub
    Private Sub CheckBox10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbOdevNot.CheckedChanged

    End Sub
    Private Sub cmbOdevDers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOdevDers.SelectedIndexChanged

    End Sub
    Private Sub txtOdevKonu_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOdevKonu.TextChanged

    End Sub
    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub
    Private Sub txtNot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNot.TextChanged

    End Sub
    Private Sub CheckBox11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSinavDers.CheckedChanged

    End Sub
    Private Sub CheckBox12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSinavTarih.CheckedChanged

    End Sub
    Private Sub CheckBox13_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSinavNot.CheckedChanged

    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNot2.TextChanged

    End Sub
    Private Sub cmbSinavDersi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSinavDersi.SelectedIndexChanged

    End Sub
    Private Sub ogrTakip6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnKapat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKapat.Click
        ogrTakip1.Show()
        Me.Hide()
    End Sub

    Private Sub btnKayitAra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtOgrNumarasi.Text = "" Then
            MsgBox("Lütfen Bir Kayıt Giriniz.", MsgBoxStyle.Critical, Title:="Hata")
        Else
            MsgBox("Kayıt Bulundu.", MsgBoxStyle.Information, Title:="Bilgi")
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbHepsiniSec.CheckedChanged

        If cbHepsiniSec.Checked = True Then
            cbAdi.Checked = True
            cbBolumu.Checked = True
            cbNumarasi.Checked = True
            cbResim.Checked = True
            cbOdevDers.Checked = True
            cbOdevKonu.Checked = True
            cbOdevNot.Checked = True
            cbOdevTesTarih.Checked = True
            cbOdevVerTarih.Checked = True
            cbSinavDers.Checked = True
            cbSinavNot.Checked = True
            cbSinavTarih.Checked = True
            cbSinifi.Checked = True
            cbSoyadi.Checked = True
        Else
            cbAdi.Checked = False
            cbBolumu.Checked = False
            cbNumarasi.Checked = False
            cbResim.Checked = False
            cbOdevDers.Checked = False
            cbOdevKonu.Checked = False
            cbOdevNot.Checked = False
            cbOdevTesTarih.Checked = False
            cbOdevVerTarih.Checked = False
            cbSinavDers.Checked = False
            cbSinavNot.Checked = False
            cbSinavTarih.Checked = False
            cbSinifi.Checked = False
            cbSoyadi.Checked = False
        End If

    End Sub

    Private Sub btnGuncelle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuncelle.Click

        If cbAdi.Checked = False And
            cbBolumu.Checked = False And
            cbNumarasi.Checked = False And
            cbResim.Checked = False And
            cbOdevDers.Checked = False And
            cbOdevKonu.Checked = False And
            cbOdevNot.Checked = False And
            cbOdevTesTarih.Checked = False And
            cbOdevVerTarih.Checked = False And
            cbSinavDers.Checked = False And
            cbSinavNot.Checked = False And
            cbSinavTarih.Checked = False And
            cbSinifi.Checked = False And
            cbSoyadi.Checked = False Then
            MsgBox("Lütfen Güncellemek İstediğiniz Alanı veya Alanları İşaretleyiniz.", MsgBoxStyle.Critical, "Hata")
        Else
            MsgBox("Seçili Alanlar Başarıyla Güncellendi.", MsgBoxStyle.Information, Title:="Bilgi")

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

    Private Sub txtNot_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNot.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
             Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtNot2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNot2.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
             Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtOgrNumarasi_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOgrNumarasi.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
             Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub btnResimSec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResimSec.Click
        Dim opfl As New OpenFileDialog
        opfl.Title = "Resim Dosyası Seç"
        opfl.Filter = "Jpeg Dosyaları (*.jpg)|*.jpg | Png Dosyaları (*.png)|*.png"
        opfl.ShowDialog()
        pbxOgrResmi.ImageLocation = opfl.FileName
        pbxOgrResmi.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub txtOgrNumarasi_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOgrNumarasi.TextChanged

        dgOgrenci.Rows.Clear()
        Dim dtOgrenci As DataTable = dtGetir("select * from ogrenci where ogr_no like '%" & txtOgrNumarasi.Text & "%' order by ogr_no")
        For i = 0 To dtOgrenci.Rows.Count - 1
            dgOgrenci.Rows.Add(dtOgrenci.Rows(i)("ogr_id").ToString(),
           dtOgrenci.Rows(i)("ogr_no").ToString(), dtOgrenci.Rows(i)("ad").ToString(),
           dtOgrenci.Rows(i)("soyad").ToString(), dtOgrenci.Rows(i)("sinif").ToString(),
           dtOgrenci.Rows(i)("bolum").ToString())
        Next

    End Sub
End Class