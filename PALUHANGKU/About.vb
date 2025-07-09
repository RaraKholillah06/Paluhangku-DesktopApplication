Imports MySql.Data.MySqlClient
Imports MySqlConnector
Imports System.IO
Public Class AboutForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Alamat email tujuan
        Dim email As String = "knnabila2@gmail.com"

        ' Membuat URL mailto
        Dim mailtoURL As String = "mailto:" & email

        Try
            ' Membuka aplikasi email default dengan alamat email yang telah diisi
            Process.Start(New ProcessStartInfo(mailtoURL) With {
            .UseShellExecute = True
        })
        Catch ex As Exception
            MessageBox.Show("Gagal membuka email client: " & ex.Message)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Dim url = "https://bakrie.ac.id/"

        ' Buka URL dalam browser default pengguna
        Process.Start("cmd", "/c start " & url)
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        ' Ganti username Instagram dengan yang diinginkan
        Dim instagramURL As String = "https://www.instagram.com/kvnsss12/"
        Try
            ' Membuka URL di browser default
            Process.Start(New ProcessStartInfo(instagramURL) With {
            .UseShellExecute = True
        })
        Catch ex As Exception
            MessageBox.Show("Gagal membuka link: " & ex.Message)
        End Try
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        ' Ganti username Instagram dengan yang diinginkan
        Dim instagramURL As String = "https://www.instagram.com/miraaaaanr_/"
        Try
            ' Membuka URL di browser default
            Process.Start(New ProcessStartInfo(instagramURL) With {
            .UseShellExecute = True
        })
        Catch ex As Exception
            MessageBox.Show("Gagal membuka link: " & ex.Message)
        End Try
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        ' Ganti username Instagram dengan yang diinginkan
        Dim instagramURL As String = "https://www.instagram.com/nabilaaaakn/"
        Try
            ' Membuka URL di browser default
            Process.Start(New ProcessStartInfo(instagramURL) With {
            .UseShellExecute = True
        })
        Catch ex As Exception
            MessageBox.Show("Gagal membuka link: " & ex.Message)
        End Try
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        ' Ganti username Instagram dengan yang diinginkan
        Dim instagramURL As String = "https://www.instagram.com/hafizhahdeaa/"
        Try
            ' Membuka URL di browser default
            Process.Start(New ProcessStartInfo(instagramURL) With {
            .UseShellExecute = True
        })
        Catch ex As Exception
            MessageBox.Show("Gagal membuka link: " & ex.Message)
        End Try
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        ' Ganti username Instagram dengan yang diinginkan
        Dim instagramURL As String = "https://www.instagram.com/raraklh._/"
        Try
            ' Membuka URL di browser default
            Process.Start(New ProcessStartInfo(instagramURL) With {
            .UseShellExecute = True
        })
        Catch ex As Exception
            MessageBox.Show("Gagal membuka link: " & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim connectionString As String = "server=localhost;user=forum_paluhangku;password=kelompok4;database=dbpaluhangku"
        Dim query As String = "SELECT Deskripsi FROM tbabout_paluhangku WHERE Id_about_paluhangku = 1" ' Ganti id sesuai dengan id konten yang ingin ditampilkan

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    Label4.Text = reader("Deskripsi").ToString()
                End If
                reader.Close()
            End Using
        End Using
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim connectionString As String = "server=localhost;user=forum_paluhangku;password=kelompok4;database=dbpaluhangku"
        Dim query As String = "SELECT Judul FROM tbabout_paluhangku"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    Label1.Text = reader("Judul").ToString()
                End If
                reader.Close()
            End Using
        End Using
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ' Koneksi ke database
        Dim connectionString As String = "server=localhost;user=forum_paluhangku;password=kelompok4;database=dbpaluhangku"
        Dim query As String = "SELECT Logo FROM tbabout_paluhangku"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    ' Mengambil data gambar sebagai byte array
                    Dim imageData As Byte() = CType(reader("Logo"), Byte())
                    ' Menggunakan MemoryStream untuk mengubah byte array menjadi image
                    Using ms As New MemoryStream(imageData)
                        PictureBox1.Image = Image.FromStream(ms)
                    End Using
                End If
                reader.Close()
            End Using
        End Using
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim connectionString = "server=localhost;user=forum_paluhangku;password=kelompok4;database=dbpaluhangku"
        Dim query = "SELECT Image_admin FROM tbadmin WHERE Id_admin = 4"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Dim reader = command.ExecuteReader
                If reader.Read Then
                    ' Mengambil data gambar sebagai byte array
                    Dim imageData = CType(reader("Image_admin"), Byte())
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
        Dim query = "SELECT Image_admin FROM tbadmin WHERE Id_admin = 5"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Dim reader = command.ExecuteReader
                If reader.Read Then
                    ' Mengambil data gambar sebagai byte array
                    Dim imageData = CType(reader("Image_admin"), Byte())
                    ' Menggunakan MemoryStream untuk mengubah byte array menjadi image
                    Using ms As New MemoryStream(imageData)
                        PictureBox4.Image = Image.FromStream(ms)
                    End Using
                End If
                reader.Close()
            End Using
        End Using
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim connectionString = "server=localhost;user=forum_paluhangku;password=kelompok4;database=dbpaluhangku"
        Dim query = "SELECT Image_admin FROM tbadmin WHERE Id_admin = 2"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Dim reader = command.ExecuteReader
                If reader.Read Then
                    ' Mengambil data gambar sebagai byte array
                    Dim imageData = CType(reader("Image_admin"), Byte())
                    ' Menggunakan MemoryStream untuk mengubah byte array menjadi image
                    Using ms As New MemoryStream(imageData)
                        PictureBox5.Image = Image.FromStream(ms)
                    End Using
                End If
                reader.Close()
            End Using
        End Using
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim connectionString As String = "server=localhost;user=forum_paluhangku;password=kelompok4;database=dbpaluhangku"
        Dim query As String = "SELECT Tagline FROM tbabout_paluhangku"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    Label3.Text = reader("Tagline").ToString()
                End If
                reader.Close()
            End Using
        End Using
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Dim connectionString = "server=localhost;user=forum_paluhangku;password=kelompok4;database=dbpaluhangku"
        Dim query = "SELECT Image_admin FROM tbadmin WHERE Id_admin = 1"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Dim reader = command.ExecuteReader
                If reader.Read Then
                    ' Mengambil data gambar sebagai byte array
                    Dim imageData = CType(reader("Image_admin"), Byte())
                    ' Menggunakan MemoryStream untuk mengubah byte array menjadi image
                    Using ms As New MemoryStream(imageData)
                        PictureBox6.Image = Image.FromStream(ms)
                    End Using
                End If
                reader.Close()
            End Using
        End Using
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Dim connectionString = "server=localhost;user=forum_paluhangku;password=kelompok4;database=dbpaluhangku"
        Dim query = "SELECT Image_admin FROM tbadmin WHERE Id_admin = 3"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Dim reader = command.ExecuteReader
                If reader.Read Then
                    ' Mengambil data gambar sebagai byte array
                    Dim imageData = CType(reader("Image_admin"), Byte())
                    ' Menggunakan MemoryStream untuk mengubah byte array menjadi image
                    Using ms As New MemoryStream(imageData)
                        PictureBox7.Image = Image.FromStream(ms)
                    End Using
                End If
                reader.Close()
            End Using
        End Using
    End Sub

    Private Sub AboutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class