Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class Contact
    Private Sub Contact_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim connectionString As String = "server=localhost;user=forum_paluhangku;password=kelompok4;database=dbpaluhangku"
        Dim query As String = "SELECT Judul FROM tbedukasi WHERE Id_edukasi = 9" ' Ganti id sesuai dengan id konten yang ingin ditampilkan

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