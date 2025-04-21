Imports Microsoft.Data.Sqlite

Public Class AddEditTaskForm
    Private connectionString As String = "tasks.db"

    Private Sub checkJam_CheckedChanged(sender As Object, e As EventArgs) Handles checkJam.CheckedChanged
        jam.Enabled = checkJam.Checked
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If String.IsNullOrWhiteSpace(boxJudul.Text) Then
            MessageBox.Show("Judul tidak boleh kosong.")
            Return
        End If

        Dim judul As String = boxJudul.Text
        Dim Tanggal As Date = Tanggal.Date
        Dim jamValue As String = If(checkJam.Checked, jam.SelectedItem?.ToString(), Nothing)
        Dim pentingValue As Boolean = penting.SelectedItem.ToString() = "Penting"
        Dim isCompleted As Boolean = False
        Dim deskripsi As String = boxDeskripsi.Text

        Using connection As New SqliteConnection(connectionString)
            connection.Open()
            Dim query As String = "INSERT INTO Tasks (Judul, Tanggal, Jam, Penting, IsCompleted) VALUES (@Judul, @Tanggal, @Jam, @Penting, @IsCompleted)"
            Using command As New SqliteCommand(query, connection)
                command.Parameters.AddWithValue("@Judul", judul)
                command.Parameters.AddWithValue("@Tanggal", tanggal.ToString("yyyy-MM-dd"))
                command.Parameters.AddWithValue("@Jam", If(jamValue IsNot Nothing, jamValue, DBNull.Value))
                command.Parameters.AddWithValue("@Penting", pentingValue)
                command.Parameters.AddWithValue("@IsCompleted", isCompleted)
                command.ExecuteNonQuery()
            End Using
        End Using

        Me.Close()
    End Sub
End Class