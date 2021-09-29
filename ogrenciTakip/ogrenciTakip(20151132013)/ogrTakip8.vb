Public Class ogrTakip8

    Private Sub ogrTakip8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dtOgrenci As DataTable = dtGetir("select * from ogrenci")
        For i = 0 To dtOgrenci.Rows.Count - 1
            dgOgrenci.Rows.Add(dtOgrenci.Rows(i)("ogr_id").ToString(), dtOgrenci.Rows(i)("ogr_no").ToString(), dtOgrenci.Rows(i)("ad").ToString(),
           dtOgrenci.Rows(i)("soyad").ToString(), dtOgrenci.Rows(i)("sinif").ToString(),
           dtOgrenci.Rows(i)("bolum").ToString(), dtOgrenci.Rows(i)("resim").ToString())
        Next
    End Sub

    Private Sub txtOgrNumarasi_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOgrNumarasi.TextChanged
        dgOgrenci.Rows.Clear()
        Dim dtOgrenci As DataTable = dtGetir("select * from ogrenci where ogr_no like '%" & txtOgrNumarasi.Text & "%' order by ogr_no")
        For i = 0 To dtOgrenci.Rows.Count - 1
            dgOgrenci.Rows.Add(dtOgrenci.Rows(i)("ogr_id").ToString(), dtOgrenci.Rows(i)("ogr_no").ToString(), dtOgrenci.Rows(i)("ad").ToString(),
           dtOgrenci.Rows(i)("soyad").ToString(), dtOgrenci.Rows(i)("sinif").ToString(),
           dtOgrenci.Rows(i)("bolum").ToString(), dtOgrenci.Rows(i)("resim").ToString())
        Next
    End Sub

    Private Sub btnKapat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKapat.Click
        ogrTakip7.Show()
        Me.Hide()
    End Sub

    Private Sub dgOgrenci_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgOgrenci.CellClick
        txtAdi.Text = dgOgrenci.CurrentRow.Cells(2).Value.ToString()
        txtSoyadi.Text = dgOgrenci.CurrentRow.Cells(3).Value.ToString()
        txtSinifi.Text = dgOgrenci.CurrentRow.Cells(4).Value.ToString()
        txtNumarasi.Text = dgOgrenci.CurrentRow.Cells(1).Value.ToString()
        cmbBolumu.Text = dgOgrenci.CurrentRow.Cells(5).Value.ToString()
        pbxOgrResmi.ImageLocation = dgOgrenci.CurrentRow.Cells(6).Value.ToString()
    End Sub

    Private Sub btnResimSec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResimSec.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            pbxOgrResmi.ImageLocation = OpenFileDialog1.FileName
            txtResimYolu.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btnGuncelle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuncelle.Click
        Dim kayId As Integer = dgOgrenci.CurrentRow.Cells(0).Value
        If txtAdi.Text = "" Or txtNumarasi.Text = "" Or txtSinifi.Text = "" Or txtSoyadi.Text = "" Or cmbBolumu.Text = "" Then
            MsgBox("Lütfen Tüm Alanları Doldurunuz.", MsgBoxStyle.Critical, Title:="Hata")
            Return
        End If
        sqlCalistir("update ogrenci set ogr_no='" & txtNumarasi.Text & "',ad='" & txtAdi.Text & "',soyad='" & txtSoyadi.Text & "',sinif='" & txtSinifi.Text & "',bolum='" & cmbBolumu.Text & "',resim='" & txtResimYolu.Text & "' where ogr_id=" & kayId)
        MsgBox("Kayıt Güncellendi", MsgBoxStyle.Information, "İşlem Tamam")
        dgOgrenci.Rows.Clear()
        Dim dtOgrenci As DataTable = dtGetir("select * from ogrenci")
        For i = 0 To dtOgrenci.Rows.Count - 1
            dgOgrenci.Rows.Add(dtOgrenci.Rows(i)("ogr_id").ToString(), dtOgrenci.Rows(i)("ogr_no").ToString(), dtOgrenci.Rows(i)("ad").ToString(),
           dtOgrenci.Rows(i)("soyad").ToString(), dtOgrenci.Rows(i)("sinif").ToString(),
           dtOgrenci.Rows(i)("bolum").ToString(), dtOgrenci.Rows(i)("resim").ToString())
        Next


        txtAdi.Clear()
        txtNumarasi.Clear()
        txtSinifi.Clear()
        txtSoyadi.Clear()
        cmbBolumu.ResetText()
        pbxOgrResmi.Image = Nothing
    End Sub

End Class