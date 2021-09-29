Public Class ogrTakip3

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

    Private Sub txtOgrNumarasi_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOgrNumarasi.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
             Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub ogrTakip3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        Dim numara As Integer = Convert.ToInt32(txtOgrNumarasi.Text)
        Dim dtOgrenci As DataTable = dtGetir("select * from ogrenci,odev where ogrenci.ogr_no=odev.ogr_no")
        For i = 0 To dtOgrenci.Rows.Count - 1
            dgOgrenci.Rows.Add(dtOgrenci.Rows(i)("ogr_no").ToString(), dtOgrenci.Rows(i)("ad").ToString(),
           dtOgrenci.Rows(i)("soyad").ToString(), dtOgrenci.Rows(i)("sinif").ToString(),
           dtOgrenci.Rows(i)("bolum").ToString(), dtOgrenci.Rows(i)("ders").ToString(), dtOgrenci.Rows(i)("konu").ToString())
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

    Private Sub btnKayitSil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKayitSil.Click

        Dim kayId As Integer = dgOgrenci.CurrentRow.Cells(0).Value
        Dim ogrNo As Integer = dgOgrenci.CurrentRow.Cells(1).Value
        Dim ad As String = dgOgrenci.CurrentRow.Cells(2).Value.ToString()

        If MsgBox(ogrNo & " nolu " & ad & " isimli öğrenci silinecektir! Onaylıyor musunuz?",
                  vbYesNo, "Silme Onayı") = MsgBoxResult.No Then
            Return
        End If

        sqlCalistir("delete from ogrenci where ogr_id=" & kayId)
        MsgBox("Kayıt Silindi", MsgBoxStyle.Information, "İşlem Tamam")
        Dim dtOgrenci As DataTable = dtGetir("select * from ogrenci")
        dgOgrenci.Rows.Clear()

        For i = 0 To dtOgrenci.Rows.Count - 1
            dgOgrenci.Rows.Add(dtOgrenci.Rows(i)("ogr_id").ToString(),
           dtOgrenci.Rows(i)("ogr_no").ToString(), dtOgrenci.Rows(i)("ad").ToString(),
           dtOgrenci.Rows(i)("soyad").ToString(), dtOgrenci.Rows(i)("sinif").ToString(),
           dtOgrenci.Rows(i)("bolum").ToString())
        Next

    End Sub

End Class