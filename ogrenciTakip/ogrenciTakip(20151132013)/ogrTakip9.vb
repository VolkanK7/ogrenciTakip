Public Class ogrTakip9

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ogrTakip9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dtOgrenci As DataTable = dtGetir("select * from odev")
        For i = 0 To dtOgrenci.Rows.Count - 1
            dgOgrenci.Rows.Add(dtOgrenci.Rows(i)("odev_id").ToString(), dtOgrenci.Rows(i)("ogr_no").ToString(),
           dtOgrenci.Rows(i)("ders").ToString(), dtOgrenci.Rows(i)("konu").ToString(),
           dtOgrenci.Rows(i)("verilis_tarih").ToString(), dtOgrenci.Rows(i)("teslim_tarih").ToString(), dtOgrenci.Rows(i)("odev_not").ToString())
        Next
    End Sub

    Private Sub btnKapat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKapat.Click
        ogrTakip7.Show()
        Me.Hide()
    End Sub

    Private Sub txtOgrNumarasi_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOgrNumarasi.TextChanged
        dgOgrenci.Rows.Clear()
        Dim dtOgrenci As DataTable = dtGetir("select * from odev where ogr_no like '%" & txtOgrNumarasi.Text & "%' order by ogr_no")
        For i = 0 To dtOgrenci.Rows.Count - 1
            dgOgrenci.Rows.Add(dtOgrenci.Rows(i)("odev_id").ToString(), dtOgrenci.Rows(i)("ogr_no").ToString(),
           dtOgrenci.Rows(i)("ders").ToString(), dtOgrenci.Rows(i)("konu").ToString(),
           dtOgrenci.Rows(i)("verilis_tarih").ToString(), dtOgrenci.Rows(i)("teslim_tarih").ToString(), dtOgrenci.Rows(i)("odev_not").ToString())
        Next
    End Sub

    Private Sub btnKaydet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGüncelle.Click
        Dim kayId As Integer = dgOgrenci.CurrentRow.Cells(0).Value

        If txtOdevKonu.Text = "" Or txtNot.Text = "" Or cmbOdevDers.Text = "" Then
            MsgBox("Lütfen Tüm Alanları Doldurunuz.", MsgBoxStyle.Critical, Title:="Hata")
            Return
        End If

        Dim verilis_tarih As Integer = dtVerilis.Value.ToShortDateString()
        Dim teslim_tarih As Integer = dtTeslim.Value.ToShortDateString()

        sqlCalistir("update odev set ders='" & cmbOdevDers.Text & "',konu='" & txtOdevKonu.Text & "',verilis_tarih=" & verilis_tarih & ",teslim_tarih=" & teslim_tarih & ",odev_not='" & txtNot.Text & "' where odev_id=" & kayId)
        MsgBox("Kayıt Güncellendi", MsgBoxStyle.Information, "İşlem Tamam")

        dgOgrenci.Rows.Clear()
        Dim dtOgrenci As DataTable = dtGetir("select * from odev")
        For i = 0 To dtOgrenci.Rows.Count - 1
            dgOgrenci.Rows.Add(dtOgrenci.Rows(i)("odev_id").ToString(), dtOgrenci.Rows(i)("ogr_no").ToString(),
           dtOgrenci.Rows(i)("ders").ToString(), dtOgrenci.Rows(i)("konu").ToString(),
           dtOgrenci.Rows(i)("verilis_tarih").ToString(), dtOgrenci.Rows(i)("teslim_tarih").ToString(), dtOgrenci.Rows(i)("odev_not").ToString())
        Next

    End Sub

    Private Sub dgOgrenci_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgOgrenci.CellClick
        txtOdevKonu.Text = dgOgrenci.CurrentRow.Cells(3).Value.ToString()
        txtNot.Text = dgOgrenci.CurrentRow.Cells(6).Value.ToString()
        cmbOdevDers.Text = dgOgrenci.CurrentRow.Cells(2).Value.ToString()
        'dtVerilis.Text = dgOgrenci.CurrentRow.Cells(4).Value.ToString()
        'dtTeslim.Text = dgOgrenci.CurrentRow.Cells(5).Value.ToString()
    End Sub
End Class