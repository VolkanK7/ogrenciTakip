Public Class ogrTakip10

    Private Sub btnKapat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKapat.Click
        ogrTakip7.Show()
        Me.Hide()
    End Sub

    Private Sub ogrTakip10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dtOgrenci As DataTable = dtGetir("select * from sinav")
        For i = 0 To dtOgrenci.Rows.Count - 1
            dgOgrenci.Rows.Add(dtOgrenci.Rows(i)("sinav_id").ToString(), dtOgrenci.Rows(i)("ogr_no").ToString(),
           dtOgrenci.Rows(i)("ders").ToString(), dtOgrenci.Rows(i)("tarih").ToString(), dtOgrenci.Rows(i)("sinav_not").ToString())
        Next
    End Sub

    Private Sub txtOgrNumarasi_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOgrNumarasi.TextChanged
        dgOgrenci.Rows.Clear()
        Dim dtOgrenci As DataTable = dtGetir("select * from sinav where ogr_no like '%" & txtOgrNumarasi.Text & "%' order by ogr_no")
        For i = 0 To dtOgrenci.Rows.Count - 1
            dgOgrenci.Rows.Add(dtOgrenci.Rows(i)("sinav_id").ToString(), dtOgrenci.Rows(i)("ogr_no").ToString(),
           dtOgrenci.Rows(i)("ders").ToString(), dtOgrenci.Rows(i)("tarih").ToString(), dtOgrenci.Rows(i)("sinav_not").ToString())
        Next
    End Sub

    Private Sub dgOgrenci_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgOgrenci.CellClick
        txtNot.Text = dgOgrenci.CurrentRow.Cells(4).Value.ToString()
        cmbSinavDersi.Text = dgOgrenci.CurrentRow.Cells(2).Value.ToString()
        'dtTarih.Text = dgOgrenci.CurrentRow.Cells(3).Value.ToString()
    End Sub

    Private Sub btnGüncelle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGüncelle.Click
        Dim kayId As Integer = dgOgrenci.CurrentRow.Cells(0).Value

        If txtNot.Text = "" Or cmbSinavDersi.Text = "" Then
            MsgBox("Lütfen Tüm Alanları Doldurunuz.", MsgBoxStyle.Critical, Title:="Hata")
            Return
        End If

        Dim tarih As Integer = dtTarih.Value.ToShortDateString()

        sqlCalistir("update sinav set ders='" & cmbSinavDersi.Text & "',tarih=" & tarih & ",sinav_not='" & txtNot.Text & "' where sinav_id=" & kayId)
        MsgBox("Kayıt Güncellendi", MsgBoxStyle.Information, "İşlem Tamam")

        dgOgrenci.Rows.Clear()
        Dim dtOgrenci As DataTable = dtGetir("select * from sinav")
        For i = 0 To dtOgrenci.Rows.Count - 1
            dgOgrenci.Rows.Add(dtOgrenci.Rows(i)("sinav_id").ToString(), dtOgrenci.Rows(i)("ogr_no").ToString(),
           dtOgrenci.Rows(i)("ders").ToString(), dtOgrenci.Rows(i)("tarih").ToString(), dtOgrenci.Rows(i)("sinav_not").ToString())
        Next
    End Sub
End Class