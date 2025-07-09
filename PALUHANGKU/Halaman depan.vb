Imports Windows.Win32.UI.Input

Public Class Form1

    Private Sub HOMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HOMEToolStripMenuItem.Click
        Dim Form1 As New Form1()
        Form1.Show()
    End Sub

    Private Sub FORUMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FORUMToolStripMenuItem.Click
        Dim formLogin As New FormLogin()
        formLogin.Show()
    End Sub

    Private Sub btnJoinUs_Click(sender As Object, e As EventArgs) Handles btnJoinUs.Click
        Dim formSignUp As New formSignUp
        formSignUp.Show()
    End Sub

    Private Sub PengertianBullyingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengertianBullyingToolStripMenuItem.Click
        Dim PengertianBullying As New PengertianBullying
        PengertianBullying.Show()
    End Sub
    Private Sub KasusBullyingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KasusBullyingToolStripMenuItem.Click
        Dim KasusBullying As New KasusBullying()
        KasusBullying.Show()
    End Sub

    Private Sub PenangananBullyingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenangananBullyingToolStripMenuItem.Click
        Dim beritaForm As New BeritaForm()
        beritaForm.Show()
    End Sub

    Private Sub JenisjenisBullyingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JenisjenisBullyingToolStripMenuItem.Click
        Dim JenisBullying As New JenisBullying()
        JenisBullying.Show()
    End Sub

    Private Sub DampakBullyingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DampakBullyingToolStripMenuItem.Click
        Dim DampakBullying As New DampakBullying()
        DampakBullying.Show()
    End Sub

    Private Sub HakSebagaiKorbanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HakSebagaiKorbanToolStripMenuItem.Click
        Dim HakKorban As New HakKorban()
        HakKorban.Show()
    End Sub

    Private Sub CaraMencegahBullyingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CaraMencegahBullyingToolStripMenuItem.Click
        Dim CegahBullying As New CegahBullying()
        CegahBullying.Show()
    End Sub

    Private Sub SaatMengalamiBullyingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaatMengalamiBullyingToolStripMenuItem.Click
        Dim AlamiBullying As New AlamiBullying()
        AlamiBullying.Show()
    End Sub

    Private Sub SaatMelihatBullyingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaatMelihatBullyingToolStripMenuItem.Click
        Dim LihatBullying As New LihatBullying()
        LihatBullying.Show()
    End Sub

    Private Sub KontakPelaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KontakPelaporanToolStripMenuItem.Click
        Dim Contact As New Contact()
        Contact.Show()
    End Sub

    Private Sub RekomendasiPsikologToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RekomendasiPsikologToolStripMenuItem.Click
        Dim konsultasiForm As New KonsultasiForm()
        konsultasiForm.Show()
    End Sub

    Private Sub SiapaKitaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SiapaKitaToolStripMenuItem.Click
        Dim aboutForm As New AboutForm()
        aboutForm.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim result As String = InputBox("Pilih mode login:" & vbCrLf & "1. Admin" & vbCrLf & "2. Anggota Community", "Pilihan Login")

        If result = "1" Then
            ' Login sebagai admin
            Dim formAdminLogin As New AdminLogin
            formAdminLogin.ShowDialog()
        ElseIf result = "2" Then
            ' Login sebagai anggota community
            Dim formLogin As New FormLogin()
            formLogin.ShowDialog()
        End If
    End Sub

End Class
