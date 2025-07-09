Imports MySql.Data.MySqlClient
Imports MySqlConnector
Imports System.Security.Cryptography
Imports System.Text

Public Class AdminLogin
    ' Koneksi ke database
    Dim connectionString As String = "server=localhost;user=forum_paluhangku;password=kelompok4;database=dbpaluhangku"

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim email As String = tbUser.Text
        Dim password As String = txtPassword.Text

        ' Debug: Tampilkan password asli untuk memastikan input tidak kosong
        Debug.WriteLine("Original Password: " & password)

        ' Pastikan password tidak kosong sebelum hashing
        If String.IsNullOrEmpty(password) Then
            MessageBox.Show("Password tidak boleh kosong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim hashedPassword As String = GetSHA256Hash(password)
        ' Debug: Tampilkan hashedPassword
        Debug.WriteLine("Hashed Password: " & hashedPassword)

        Try
            Using connection As New MySqlConnection(connectionString)
                ' Query untuk memeriksa apakah username dan password ada di database
                Dim query As String = "SELECT COUNT(*) FROM tbadmin WHERE Email = @Email AND Password = @Password"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Email", email)
                    command.Parameters.AddWithValue("@Password", hashedPassword)

                    connection.Open()

                    Dim count As Object = command.ExecuteScalar()

                    Dim loginSuccess As Boolean = False

                    If count IsNot Nothing AndAlso Integer.TryParse(count.ToString(), Nothing) AndAlso Convert.ToInt32(count) > 0 AndAlso Not String.IsNullOrEmpty(email) AndAlso Not String.IsNullOrEmpty(hashedPassword) Then
                        MessageBox.Show("Login berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        loginSuccess = True
                        Me.Hide()

                        ' Masukkan data login ke tblogin
                        Dim insertQuery As String = "INSERT INTO tblogin (Id_kategori, Email, Password, Waktu) VALUES (@Id_kategori, @InsertEmail, @InsertPassword, @Waktu)"
                        Using insertCommand As New MySqlCommand(insertQuery, connection)
                            insertCommand.Parameters.AddWithValue("@Id_kategori", 2)
                            insertCommand.Parameters.AddWithValue("@InsertEmail", email)
                            insertCommand.Parameters.AddWithValue("@InsertPassword", hashedPassword)
                            insertCommand.Parameters.AddWithValue("@Waktu", DateTime.Now)
                            insertCommand.ExecuteNonQuery()
                        End Using
                    End If

                    If Not loginSuccess Then
                        MessageBox.Show("Login gagal. Username atau password salah.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        txtPassword.PasswordChar = "•" ' Menggunakan karakter bullet sebagai mask 
    End Sub

    Private Function GetSHA256Hash(input As String) As String
        If String.IsNullOrEmpty(input) Then
            Return Nothing
        End If
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(input))
            Dim builder As New StringBuilder()
            For Each b As Byte In bytes
                builder.Append(b.ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function

    Private Sub AdminLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class