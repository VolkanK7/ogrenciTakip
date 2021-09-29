Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub btnKapat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKapat.Click
        Application.Exit()
    End Sub

    Private Sub btnGiris_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGiris.Click

        If txtKullaniciAdi.Text = "a" And txtSifre.Text = "a" Then
            ogrTakip1.Show()
            Me.Hide()

        ElseIf txtKullaniciAdi.Text = "" And txtSifre.Text = "" Then
            MsgBox("Kullanıcı Adı ve Şifre Boş Bırakılamaz.", MsgBoxStyle.Critical, Title:="Hata")

        Else
            MsgBox("Hatalı Giriş Yaptınız ! Lütfen Bilgilerinizi Kontrol Ediniz.", MsgBoxStyle.Critical, Title:="Hata")

        End If
    End Sub

    Private Sub txtSifre_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSifre.KeyDown
        If e.KeyCode = Keys.Enter Then
            ogrTakip1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub txtKullaniciAdi_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKullaniciAdi.KeyDown
        If e.KeyCode = Keys.Enter Then
            ogrTakip1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Application.Exit()
        End If
    End Sub
End Class
