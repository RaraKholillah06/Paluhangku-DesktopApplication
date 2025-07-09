Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class formSignUp
    ' Informasi koneksi ke MySQL
    Dim connectionString As String = "server=localhost;user=forum_paluhangku;password=kelompok4;database=dbpaluhangku"

    Structure Pengguna
        Dim nama As String
        Dim email As String
        Dim username As String
        Dim password As String
        Dim konfirmasipassword As String
        Dim jeniskelamin As String
    End Structure

    Dim DaftarPengguna(100) As Pengguna

    Private Sub formSignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Atur TextBox password agar menggunakan karakter password sistem saat form dimuat
        tbPassword.UseSystemPasswordChar = True
        txtKonPass.UseSystemPasswordChar = True
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Dim nama As String = txtNama.Text
        Dim email As String = tbEmail.Text
        Dim username As String = txtUsername.Text
        Dim password As String = tbPassword.Text
        Dim konfirmasipassword As String = txtKonPass.Text
        Dim jeniskelamin As String = If(RadButLaki.Checked, "Laki-Laki", "Perempuan")
        Dim idJenisKelamin As Integer = If(jeniskelamin = "Laki-Laki", 1, 2)
        Dim idKategori As Integer = 1

        If String.IsNullOrWhiteSpace(nama) OrElse
            String.IsNullOrWhiteSpace(email) OrElse
            String.IsNullOrWhiteSpace(username) OrElse
            String.IsNullOrWhiteSpace(password) OrElse
            String.IsNullOrWhiteSpace(konfirmasipassword) OrElse
            (Not RadButLaki.Checked AndAlso Not RadButPerem.Checked) Then

            MessageBox.Show("Mohon lengkapi semua data sebelum melakukan SignUp.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Pengecekan apakah password mengandung setidaknya satu angka
        If Not password.Any(Function(c) Char.IsDigit(c)) Then
            MessageBox.Show("Password harus mengandung setidaknya satu angka.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If password <> konfirmasipassword Then
            MessageBox.Show("Konfirmasi password tidak sesuai dengan password yang dimasukkan. Silakan coba lagi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim hashedPassword As String = GetSHA256Hash(password)

        ' Simpan pengguna ke database dan dapatkan IdAnggota
        Dim idAnggota As Integer = SimpanKeDatabase(nama, email, username, hashedPassword, idJenisKelamin, idKategori)

        ' Periksa apakah IdAnggota berhasil diambil
        If idAnggota <> -1 Then
            Dim indexKosong As Integer = CariIndexKosongDaftarPengguna()

            If indexKosong <> -1 Then
                DaftarPengguna(indexKosong).nama = nama
                DaftarPengguna(indexKosong).email = email
                DaftarPengguna(indexKosong).username = username
                DaftarPengguna(indexKosong).password = password
                DaftarPengguna(indexKosong).konfirmasipassword = konfirmasipassword
                DaftarPengguna(indexKosong).jeniskelamin = jeniskelamin

                MessageBox.Show("Pengguna berhasil didaftarkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide() ' Tutup form setelah pendaftaran berhasil
                Dim forumForm As New ForumForm() ' Buka ForumForm tanpa parameter
                forumForm.IdAnggota = idAnggota ' Atur IdAnggota setelah pembuatan objek
                forumForm.ShowDialog()
            Else
                MessageBox.Show("Maaf, tidak ada ruang kosong untuk menambahkan pengguna baru.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Terjadi kesalahan saat menyimpan data pengguna.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Public Function IsValidPassword(password As String) As Boolean
        If Len(password) < 8 Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Function CariIndexKosongDaftarPengguna() As Integer
        For i As Integer = 0 To DaftarPengguna.Length - 1
            If String.IsNullOrEmpty(DaftarPengguna(i).nama) Then
                Return i
            End If
        Next
        Return -1
    End Function

    Private Function SimpanKeDatabase(nama As String, email As String, username As String, hashedPassword As String, idJenisKelamin As Integer, idKategori As Integer) As Integer
        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "INSERT INTO tbanggota (Nama, Email, Username, Password, Id_jenis_kelamin, Id_kategori) VALUES (@nama, @Email, @Username, @Password, @Id_jenis_kelamin, @Id_kategori); SELECT LAST_INSERT_ID();"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@nama", nama)
                command.Parameters.AddWithValue("@Email", email)
                command.Parameters.AddWithValue("@Username", username)
                command.Parameters.AddWithValue("@Password", hashedPassword)
                command.Parameters.AddWithValue("@Id_jenis_kelamin", idJenisKelamin)
                command.Parameters.AddWithValue("@Id_kategori", idKategori)

                Try
                    connection.Open()
                    Dim idAnggota As Integer = Convert.ToInt32(command.ExecuteScalar())
                    Return idAnggota
                Catch ex As Exception
                    MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return -1
                End Try
            End Using
        End Using
    End Function

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        ' Saat checkbox untuk melihat password dicentang atau tidak
        ' Atur karakter password sistem sesuai dengan status checkbox
        tbPassword.UseSystemPasswordChar = Not CheckBox1.Checked
        txtKonPass.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub

    Private Function GetSHA256Hash(input As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(input))
            Dim builder As New StringBuilder()
            For Each b As Byte In bytes
                builder.Append(b.ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function
End Class