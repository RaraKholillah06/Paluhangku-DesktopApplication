Imports MySqlConnector
Imports System.IO

Public Class KonsultasiForm
    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Dim connectionString As String = "server=localhost;user=forum_paluhangku;password=kelompok4;database=dbpaluhangku"
        Dim query As String = "SELECT Link_konsultasi FROM tbkonsultasi WHERE Id_konsultasi = 3"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        LinkLabel5.Text = reader("Link_konsultasi").ToString()
                    End If
                    reader.Close()
                Catch ex As Exception
                    MessageBox.Show("Terjadi kesalahan: " & ex.Message)
                End Try
            End Using
        End Using

        Dim HaloDocURL As String = "https://www.halodoc.com/tanya-dokter/anis-ansyori-s-psi-mmrs-psikolog"
        Try
            ' Membuka URL di browser default
            Process.Start(New ProcessStartInfo(HaloDocURL) With {
            .UseShellExecute = True
        })
        Catch ex As Exception
            MessageBox.Show("Gagal membuka link: " & ex.Message)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim connectionString As String = "server=localhost;user=forum_paluhangku;password=kelompok4;database=dbpaluhangku"
        Dim query As String = "SELECT Link_konsultasi FROM tbkonsultasi WHERE Id_konsultasi = 4"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        LinkLabel1.Text = reader("Link_konsultasi").ToString()
                    End If
                    reader.Close()
                Catch ex As Exception
                    MessageBox.Show("Terjadi kesalahan: " & ex.Message)
                End Try
            End Using
        End Using

        Dim HaloDocURL As String = "https://www.halodoc.com/tanya-dokter/dra-grace-christiane-m-psi-t-psikolog"
        Try
            ' Membuka URL di browser default
            Process.Start(New ProcessStartInfo(HaloDocURL) With {
            .UseShellExecute = True
        })
        Catch ex As Exception
            MessageBox.Show("Gagal membuka link: " & ex.Message)
        End Try
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim connectionString As String = "server=localhost;user=forum_paluhangku;password=kelompok4;database=dbpaluhangku"
        Dim query As String = "SELECT Judul FROM tbkonsultasi WHERE Id_konsultasi = 3" ' Ganti id sesuai dengan id konten yang ingin ditampilkan

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    Label4.Text = reader("Judul").ToString()
                End If
                reader.Close()
            End Using
        End Using
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim connectionString As String = "server=localhost;user=forum_paluhangku;password=kelompok4;database=dbpaluhangku"
        Dim query As String = "SELECT Image_konsultasi FROM tbkonsultasi WHERE Id_konsultasi = 1"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    ' Mengambil data gambar sebagai byte array
                    Dim imageData As Byte() = CType(reader("Image_konsultasi"), Byte())
                    ' Menggunakan MemoryStream untuk mengubah byte array menjadi image
                    Using ms As New MemoryStream(imageData)
                        PictureBox1.Image = Image.FromStream(ms)
                    End Using
                End If
                reader.Close()
            End Using
        End Using
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim connectionString As String = "server=localhost;user=forum_paluhangku;password=kelompok4;database=dbpaluhangku"
        Dim query As String = "SELECT Image_konsultasi FROM tbkonsultasi WHERE Id_konsultasi = 4"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    ' Mengambil data gambar sebagai byte array
                    Dim imageData As Byte() = CType(reader("Image_konsultasi"), Byte())
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
        Dim connectionString As String = "server=localhost;user=forum_paluhangku;password=kelompok4;database=dbpaluhangku"
        Dim query As String = "SELECT Image_konsultasi FROM tbkonsultasi WHERE Id_konsultasi = 3"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    ' Mengambil data gambar sebagai byte array
                    Dim imageData As Byte() = CType(reader("Image_konsultasi"), Byte())
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
        Dim connectionString As String = "server=localhost;user=forum_paluhangku;password=kelompok4;database=dbpaluhangku"
        Dim query As String = "SELECT Image_konsultasi FROM tbkonsultasi WHERE Id_konsultasi = 2"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    ' Mengambil data gambar sebagai byte array
                    Dim imageData As Byte() = CType(reader("Image_konsultasi"), Byte())
                    ' Menggunakan MemoryStream untuk mengubah byte array menjadi image
                    Using ms As New MemoryStream(imageData)
                        PictureBox1.Image = Image.FromStream(ms)
                    End Using
                End If
                reader.Close()
            End Using
        End Using
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim connectionString As String = "server=localhost;user=forum_paluhangku;password=kelompok4;database=dbpaluhangku"
        Dim query As String = "SELECT Link_konsultasi FROM tbkonsultasi WHERE Id_konsultasi = 1"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        LinkLabel2.Text = reader("Link_konsultasi").ToString()
                    End If
                    reader.Close()
                Catch ex As Exception
                    MessageBox.Show("Terjadi kesalahan: " & ex.Message)
                End Try
            End Using
        End Using

        Dim HaloDocURL As String = "https://www.halodoc.com/tanya-dokter/subiantoro-s-psi-psikolog"
        Try
            ' Membuka URL di browser default
            Process.Start(New ProcessStartInfo(HaloDocURL) With {
            .UseShellExecute = True
        })
        Catch ex As Exception
            MessageBox.Show("Gagal membuka link: " & ex.Message)
        End Try
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Dim connectionString As String = "server=localhost;user=forum_paluhangku;password=kelompok4;database=dbpaluhangku"
        Dim query As String = "SELECT Link_konsultasi FROM tbkonsultasi WHERE Id_konsultasi = 2"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        LinkLabel3.Text = reader("Link_konsultasi").ToString()
                    End If
                    reader.Close()
                Catch ex As Exception
                    MessageBox.Show("Terjadi kesalahan: " & ex.Message)
                End Try
            End Using
        End Using

        Dim HaloDocURL As String = "https://www.halodoc.com/tanya-dokter/gentur-anto-judho-s-psi-m-psi-psikolog"
        Try
            ' Membuka URL di browser default
            Process.Start(New ProcessStartInfo(HaloDocURL) With {
            .UseShellExecute = True
        })
        Catch ex As Exception
            MessageBox.Show("Gagal membuka link: " & ex.Message)
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim connectionString As String = "server=localhost;user=forum_paluhangku;password=kelompok4;database=dbpaluhangku"
        Dim query As String = "SELECT Judul FROM tbkonsultasi WHERE Id_konsultasi = 1" ' Ganti id sesuai dengan id konten yang ingin ditampilkan

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    Label2.Text = reader("Judul").ToString()
                End If
                reader.Close()
            End Using
        End Using
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim connectionString As String = "server=localhost;user=forum_paluhangku;password=kelompok4;database=dbpaluhangku"
        Dim query As String = "SELECT Judul FROM tbkonsultasi WHERE Id_konsultasi = 4" ' Ganti id sesuai dengan id konten yang ingin ditampilkan

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    Label3.Text = reader("Judul").ToString()
                End If
                reader.Close()
            End Using
        End Using
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim connectionString As String = "server=localhost;user=forum_paluhangku;password=kelompok4;database=dbpaluhangku"
        Dim query As String = "SELECT Judul FROM tbkonsultasi WHERE Id_konsultasi = 2" ' Ganti id sesuai dengan id konten yang ingin ditampilkan

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    Label5.Text = reader("Judul").ToString()
                End If
                reader.Close()
            End Using
        End Using
    End Sub
End Class