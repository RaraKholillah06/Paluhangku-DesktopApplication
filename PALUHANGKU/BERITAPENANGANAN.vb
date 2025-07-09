Imports MySql.Data.MySqlClient
Imports MySqlConnector
Imports System.IO
Imports System.Reflection.Emit

Public Class BeritaForm
    Private Sub BeritaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim connectionString As String = "server=localhost;user=forum_paluhangku;password=kelompok4;database=dbpaluhangku"
        Dim query As String = "SELECT Link_berita FROM tbberita WHERE Id_berita = 7"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        LinkLabel1.Text = reader("Link_berita").ToString()
                    End If
                    reader.Close()
                Catch ex As Exception
                    MessageBox.Show("Terjadi kesalahan: " & ex.Message)
                End Try
            End Using
        End Using

        ' Mengatur URL yang ingin dibuka saat link diklik
        Dim url As String = "https://www.akurat.co/nasional/amp/1304200362/kpai-penanganan-kasus-bullying-di-sekolah-belum-beri-efek-jera-ke-pelaku"

        ' Membuka URL di browser default
        System.Diagnostics.Process.Start("cmd", "/c start " & url)
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim connectionString As String = "server=localhost;user=forum_paluhangku;password=kelompok4;database=dbpaluhangku"
        Dim query As String = "SELECT Link_berita FROM tbberita WHERE Id_berita = 10"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        LinkLabel2.Text = reader("Link_berita").ToString()
                    End If
                    reader.Close()
                Catch ex As Exception
                    MessageBox.Show("Terjadi kesalahan: " & ex.Message)
                End Try
            End Using
        End Using
        ' Mengatur URL yang ingin dibuka saat link diklik
        Dim url As String = "https://www.liputan6.com/amp/5478472/babak-baru-kasus-bullying-anak-sd-di-sukabumi-keluarga-laporkan-orangtua-pelaku-dan-pihak-sekolah"

        ' Membuka URL di browser default
        System.Diagnostics.Process.Start("cmd", "/c start " & url)
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Dim connectionString As String = "server=localhost;user=forum_paluhangku;password=kelompok4;database=dbpaluhangku"
        Dim query As String = "SELECT Link_berita FROM tbberita WHERE Id_berita = 8"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        LinkLabel3.Text = reader("Link_berita").ToString()
                    End If
                    reader.Close()
                Catch ex As Exception
                    MessageBox.Show("Terjadi kesalahan: " & ex.Message)
                End Try
            End Using
        End Using
        ' Mengatur URL yang ingin dibuka saat link diklik
        Dim url As String = "https://news.detik.com/berita/d-7222210/polisi-tetapkan-4-pelaku-bullying-remaja-putri-di-batam-jadi-tersangka/amp"

        ' Membuka URL di browser default
        System.Diagnostics.Process.Start("cmd", "/c start " & url)
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Dim connectionString As String = "server=localhost;user=forum_paluhangku;password=kelompok4;database=dbpaluhangku"
        Dim query As String = "SELECT Link_berita FROM tbberita WHERE Id_berita = 11"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        LinkLabel4.Text = reader("Link_berita").ToString()
                    End If
                    reader.Close()
                Catch ex As Exception
                    MessageBox.Show("Terjadi kesalahan: " & ex.Message)
                End Try
            End Using
        End Using
        ' Mengatur URL yang ingin dibuka saat link diklik
        Dim url As String = "https://www.beritasatu.com/nusantara/2806846/10-pelaku-bullying-siswi-smp-di-bintan-ditangkap/amp"

        ' Membuka URL di browser default
        System.Diagnostics.Process.Start("cmd", "/c start " & url)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim connectionString As String = "server=localhost;user=forum_paluhangku;password=kelompok4;database=dbpaluhangku"
        Dim query As String = "SELECT Judul_berita FROM tbberita WHERE Id_berita = 7" ' Ganti id sesuai dengan id konten yang ingin ditampilkan

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    Label2.Text = reader("Judul_berita").ToString()
                End If
                reader.Close()
            End Using
        End Using
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim connectionString As String = "server=localhost;user=forum_paluhangku;password=kelompok4;database=dbpaluhangku"
        Dim query As String = "SELECT Judul_berita FROM tbberita WHERE Id_berita = 8" ' Ganti id sesuai dengan id konten yang ingin ditampilkan

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    Label3.Text = reader("Judul_berita").ToString()
                End If
                reader.Close()
            End Using
        End Using
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim connectionString As String = "server=localhost;user=forum_paluhangku;password=kelompok4;database=dbpaluhangku"
        Dim query As String = "SELECT Judul_berita FROM tbberita WHERE Id_berita = 10" ' Ganti id sesuai dengan id konten yang ingin ditampilkan

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    Label4.Text = reader("Judul_berita").ToString()
                End If
                reader.Close()
            End Using
        End Using
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim connectionString As String = "server=localhost;user=forum_paluhangku;password=kelompok4;database=dbpaluhangku"
        Dim query As String = "SELECT Judul_berita FROM tbberita WHERE Id_berita = 11" ' Ganti id sesuai dengan id konten yang ingin ditampilkan

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    Label5.Text = reader("Judul_berita").ToString()
                End If
                reader.Close()
            End Using
        End Using
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim connectionString = "server=localhost;user=forum_paluhangku;password=kelompok4;database=dbpaluhangku"
        Dim query = "SELECT Image_berita FROM tbberita WHERE Id_berita = 7"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Dim reader = command.ExecuteReader
                If reader.Read Then
                    ' Mengambil data gambar sebagai byte array
                    Dim imageData = CType(reader("Image_berita"), Byte())
                    ' Menggunakan MemoryStream untuk mengubah byte array menjadi image
                    Using ms As New MemoryStream(imageData)
                        PictureBox1.Image = Image.FromStream(ms)
                    End Using
                End If
                reader.Close()
            End Using
        End Using
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim connectionString = "server=localhost;user=forum_paluhangku;password=kelompok4;database=dbpaluhangku"
        Dim query = "SELECT Image_berita FROM tbberita WHERE Id_berita = 8"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Dim reader = command.ExecuteReader
                If reader.Read Then
                    ' Mengambil data gambar sebagai byte array
                    Dim imageData = CType(reader("Image_berita"), Byte())
                    ' Menggunakan MemoryStream untuk mengubah byte array menjadi image
                    Using ms As New MemoryStream(imageData)
                        PictureBox2.Image = Image.FromStream(ms)
                    End Using
                End If
                reader.Close()
            End Using
        End Using
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim connectionString = "server=localhost;user=forum_paluhangku;password=kelompok4;database=dbpaluhangku"
        Dim query = "SELECT Image_berita FROM tbberita WHERE Id_berita = 10"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Dim reader = command.ExecuteReader
                If reader.Read Then
                    ' Mengambil data gambar sebagai byte array
                    Dim imageData = CType(reader("Image_berita"), Byte())
                    ' Menggunakan MemoryStream untuk mengubah byte array menjadi image
                    Using ms As New MemoryStream(imageData)
                        PictureBox3.Image = Image.FromStream(ms)
                    End Using
                End If
                reader.Close()
            End Using
        End Using
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim connectionString = "server=localhost;user=forum_paluhangku;password=kelompok4;database=dbpaluhangku"
        Dim query = "SELECT Image_berita FROM tbberita WHERE Id_berita = 11"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Dim reader = command.ExecuteReader
                If reader.Read Then
                    ' Mengambil data gambar sebagai byte array
                    Dim imageData = CType(reader("Image_berita"), Byte())
                    ' Menggunakan MemoryStream untuk mengubah byte array menjadi image
                    Using ms As New MemoryStream(imageData)
                        PictureBox4.Image = Image.FromStream(ms)
                    End Using
                End If
                reader.Close()
            End Using
        End Using
    End Sub
End Class