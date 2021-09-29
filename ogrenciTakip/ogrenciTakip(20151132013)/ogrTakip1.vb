Public Class ogrTakip1

    Private Sub btnKapat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKapat.Click
        Application.Exit()
    End Sub

    Private Sub btnKayitIslemleri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKayitIslemleri.Click
        ogrTakip2.Show()
        Me.Hide()

    End Sub

    Private Sub btnKayitListe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKayitListe.Click
        ogrTakip3.Show()
        Me.Hide()

    End Sub

    Private Sub btnOdevIslemleri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOdevIslemleri.Click
        ogrTakip4.Show()
        Me.Hide()
    End Sub

    Private Sub btnNotIslemleri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotIslemleri.Click
        ogrTakip5.Show()
        Me.Hide()
    End Sub

    Private Sub btnGüncellemeIslemleri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGüncellemeIslemleri.Click
        ogrTakip7.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ogrTakip11.Show()
        Me.Hide()
    End Sub
End Class