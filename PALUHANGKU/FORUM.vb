Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class ForumForm
    ' Informasi koneksi ke MySQL
    Dim connectionString As String = "server=localhost;user=forum_paluhangku;password=kelompok4;database=dbpaluhangku"

    ' Properti untuk menyimpan Id_anggota
    Public Property IdAnggota As Integer

    ' Konstruktor default tanpa parameter
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnKirim_Click(sender As Object, e As EventArgs) Handles btnKirim.Click
        Dim pesan As String = TextBoxPesanBaru.Text

        ' Pastikan pesan tidak kosong sebelum mengirimkannya
        If pesan <> "" Then
            ' Tambahkan pesan ke dalam List Box
            ListBoxDiskusiUmum.Items.Add(pesan)

            ' Simpan pesan ke dalam database MySQL
            SimpanKeDatabase(pesan)

            ' Kosongkan TextBox setelah mengirim pesan
            TextBoxPesanBaru.Text = ""
        Else
            MessageBox.Show("Silakan tulis pesan terlebih dahulu.")
        End If
    End Sub

    ' Fungsi untuk menyimpan pesan ke database MySQL
    Private Sub SimpanKeDatabase(pesan As String)
        Using connection As New MySqlConnection(connectionString)
            ' Cek apakah IdAnggota ada di tabel tbanggota
            Dim checkQuery As String = "SELECT COUNT(*) FROM tbanggota WHERE Id_anggota = @IdAnggota"
            Using checkCommand As New MySqlCommand(checkQuery, connection)
                checkCommand.Parameters.AddWithValue("@IdAnggota", IdAnggota)
                Try
                    connection.Open()
                    Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())
                    If count = 0 Then
                        MessageBox.Show("IdAnggota tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
                Catch ex As Exception
                    MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End Try
            End Using

            ' Simpan pesan ke dalam tabel tbforum
            Dim query As String = "INSERT INTO tbforum (Id_anggota, Isi_cerita, Waktu) VALUES (@IdAnggota, @pesan, @Waktu)"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@IdAnggota", IdAnggota)
                command.Parameters.AddWithValue("@pesan", pesan)
                command.Parameters.AddWithValue("@Waktu", DateTime.Now)
                Try
                    command.ExecuteNonQuery()
                    MessageBox.Show("Cerita anda sudah berhasil dikirim!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub ForumForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Event handler untuk form load
    End Sub
End Class