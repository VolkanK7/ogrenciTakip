Public Class ogrTakip4

    Private Sub btnKapat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKapat.Click
        ogrTakip1.Show()
        Me.Hide()
    End Sub

    Private Sub btnKaydet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKaydet.Click
        If txtOdevKonu.Text = "" Or txtNot.Text = "" Or cmbOdevDers.Text = "" Then
            MsgBox("Lütfen Tüm Alanları Doldurunuz.", MsgBoxStyle.Critical, Title:="Hata")
            Return
        End If

        Dim numara As Integer = Convert.ToInt32(txtOgrNo.Text)
        Dim odevNot As Integer = Convert.ToInt32(txtNot.Text)
        Dim verilis_tarih As Integer = dtVerilis.Value.ToShortDateString()
        Dim teslim_tarih As Integer = dtTeslim.Value.ToShortDateString()

        sqlCalistir("insert into odev(ogr_no,verilis_tarih,teslim_tarih,odev_not,ders,konu) values(" & numara & "," & verilis_tarih & "," & teslim_tarih & "," & odevNot & ",'" & cmbOdevDers.Text & "','" & txtOdevKonu.Text & "')")
        MsgBox("Kayıt Eklendi", MsgBoxStyle.Information, "İşlem Tamam")

        txtOdevKonu.Clear()
        txtNot.Clear()
        cmbOdevDers.ResetText()

        'dgOdev.Rows.Clear()
        'Dim dtOdev As DataTable = dtGetir("select * from odev")
        'For i = 0 To dtOdev.Rows.Count - 1
        '    dgOdev.Rows.Add(dtOdev.Rows(i)("odev_id").ToString(),
        '   dtOdev.Rows(i)("ogr_no").ToString(), dtOdev.Rows(i)("ders").ToString(),
        '   dtOdev.Rows(i)("konu").ToString(), dtOdev.Rows(i)("verilis_tarih").ToString(),
        '   dtOdev.Rows(i)("teslim_tarih").ToString(), dtOdev.Rows(i)("not").ToString())
        'Next

    End Sub

    Private Sub btnKayitAra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtOgrNumarasi.Text = "" Then
            MsgBox("Lütfen Bir Kayıt Giriniz.", MsgBoxStyle.Critical, Title:="Hata")
        Else
            MsgBox("Kayıt Bulundu.", MsgBoxStyle.Information, Title:="Bilgi")
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

    Private Sub txtNot_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNot.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
             Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub ogrTakip4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim dtOgrenci As DataTable = dtGetir("select * from ogrenci")
        For i = 0 To dtOgrenci.Rows.Count - 1
            dgOgrenci.Rows.Add(dtOgrenci.Rows(i)("ogr_id").ToString(), dtOgrenci.Rows(i)("ogr_no").ToString(), dtOgrenci.Rows(i)("ad").ToString(),
           dtOgrenci.Rows(i)("soyad").ToString(), dtOgrenci.Rows(i)("sinif").ToString(),
           dtOgrenci.Rows(i)("bolum").ToString(), dtOgrenci.Rows(i)("resim").ToString())
        Next

        'Dim dtOdev As DataTable = dtGetir("select * from odev")
        'For i = 0 To dtOdev.Rows.Count - 1
        '    dgOdev.Rows.Add(dtOdev.Rows(i)("odev_id").ToString(),
        '   dtOdev.Rows(i)("ogr_no").ToString(), dtOdev.Rows(i)("ders").ToString(),
        '   dtOdev.Rows(i)("konu").ToString(), dtOdev.Rows(i)("verilis_tarih").ToString(),
        '   dtOdev.Rows(i)("teslim_tarih").ToString(), dtOdev.Rows(i)("not").ToString())
        'Next

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

    Private Sub dgOgrenci_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgOgrenci.CellClick
        txtOgrNo.Text = dgOgrenci.CurrentRow.Cells(1).Value.ToString()
        txtOgrAdi.Text = dgOgrenci.CurrentRow.Cells(2).Value.ToString()
        txtOgrSinifi.Text = dgOgrenci.CurrentRow.Cells(4).Value.ToString()
        pbxResim.ImageLocation = dgOgrenci.CurrentRow.Cells(6).Value.ToString()
    End Sub
End Class