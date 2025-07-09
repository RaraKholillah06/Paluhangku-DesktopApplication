Imports MySql.Data.MySqlClient
Imports MySqlConnector
Imports System.Security.Cryptography
Imports System.Text

Public Class FormLogIn
    ' Informasi koneksi ke MySQL
    Dim connectionString As String = "server=localhost;user=forum_paluhangku;password=kelompok4;database=dbpaluhangku"

    ' Properti untuk menyimpan Id_anggota
    Public Property IdAnggota As Integer

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Ambil username dan password yang dimasukkan oleh pengguna
        Dim email As String = txtUsername.Text
        Dim password As String = tbPassword.Text

        ' Hash password yang dimasukkan pengguna
        Dim hashedPassword As String = GetSHA256Hash(password)

        ' Buat koneksi ke database
        Using connection As New MySqlConnection(connectionString)
            ' Buat query SQL untuk memeriksa keberadaan pengguna di database
            Dim query As String = "SELECT Id_anggota FROM tbanggota WHERE Email = @Email AND Password = @Password"
            Using command As New MySqlCommand(query, connection)
                ' Tambahkan parameter untuk username dan password
                command.Parameters.AddWithValue("@Email", email)
                command.Parameters.AddWithValue("@Password", hashedPassword)

                Try
                    ' Buka koneksi
                    connection.Open()
                    ' Eksekusi query dan baca hasilnya
                    Dim result As Object = command.ExecuteScalar()
                    ' Periksa hasil
                    If result IsNot Nothing Then
                        ' Jika pengguna terdaftar, simpan Id_anggota
                        IdAnggota = Convert.ToInt32(result)

                        ' Masukkan data ke tblogin
                        Dim insertQuery As String = "INSERT INTO tblogin (Id_kategori, Email, Password, Waktu) VALUES (@Id_kategori, @InsertEmail, @InsertPassword, @Waktu)"
                        Using insertCommand As New MySqlCommand(insertQuery, connection)
                            insertCommand.Parameters.AddWithValue("@Id_kategori", 1)
                            insertCommand.Parameters.AddWithValue("@InsertEmail", email)
                            insertCommand.Parameters.AddWithValue("@InsertPassword", hashedPassword)
                            insertCommand.Parameters.AddWithValue("@Waktu", DateTime.Now)
                            insertCommand.ExecuteNonQuery()
                        End Using

                        ' Jika pengguna terdaftar, munculkan ForumForm
                        MessageBox.Show("Login berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Hide()
                        Dim forumForm As New ForumForm()
                        forumForm.IdAnggota = IdAnggota ' Kirim Id_anggota ke ForumForm
                        forumForm.ShowDialog()
                    Else
                        ' Jika pengguna tidak terdaftar, tampilkan pesan
                        MessageBox.Show("Pengguna belum terdaftar, silahkan daftar terlebih dahulu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    ' Tangani kesalahan jika terjadi
                    MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ' Tutup form login
        Me.Close()
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Saat form dimuat, atur textbox password agar menggunakan karakter password sistem
        tbPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub cbLihat_CheckedChanged(sender As Object, e As EventArgs) Handles cbLihat.CheckedChanged
        ' Saat checkbox untuk melihat password dicentang atau tidak
        ' Atur karakter password sistem sesuai dengan status checkbox
        tbPassword.UseSystemPasswordChar = Not cbLihat.Checked
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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class

