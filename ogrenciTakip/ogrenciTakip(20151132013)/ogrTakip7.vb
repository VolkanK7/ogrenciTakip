Public Class ogrTakip7

    Private Sub btnKapat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKapat.Click
        ogrTakip1.Show()
        Me.Hide()
    End Sub

    Private Sub btnKayitListe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKayitListe.Click
        ogrTakip8.Show()
        Me.Hide()
    End Sub

    Private Sub btnOdevIslemleri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOdevIslemleri.Click
        ogrTakip9.Show()
        Me.Hide()
    End Sub

    Private Sub btnNotIslemleri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotIslemleri.Click
        ogrTakip10.Show()
        Me.Hide()
    End Sub
End Class