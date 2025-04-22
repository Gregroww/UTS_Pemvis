Imports Microsoft.Data.Sqlite

Public Class EditTask
    Public idTask As Integer
    Dim conn As SqliteConnection
    Dim cmd As SqliteCommand
    Dim reader As SqliteDataReader

    Private Sub EditTask_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkJamEdit.Checked = False ' default
        jamEdit.Enabled = False
        loadTaskData()
    End Sub

    Public Sub loadTaskData()
        SQLitePCL.Batteries.Init()
        conn = New SqliteConnection("Data Source=tasks.db")
        conn.Open()

        Dim sql As String = "SELECT * FROM task_list WHERE id=@id"
        cmd = conn.CreateCommand()
        cmd.CommandText = sql
        cmd.Parameters.AddWithValue("@id", idTask)

        reader = cmd.ExecuteReader()

        If reader.Read() Then
            textJudulEdit.Text = reader("judul").ToString()
            tglEdit.Value = DateTime.Parse(reader("tanggal").ToString())

            If Not reader.IsDBNull(reader.GetOrdinal("jam")) AndAlso reader("jam").ToString() <> "" Then
                checkJamEdit.Checked = True
                jamEdit.Enabled = True
                jamEdit.Value = DateTime.Parse(reader("jam").ToString())
            Else
                jamEdit.Enabled = False
            End If

            comboPrioritasEdit.Text = reader("prioritas").ToString()
            textDeskripsiEdit.Text = reader("deskripsi").ToString()
        Else
            MessageBox.Show("Task tidak ditemukan.")
            Me.Close()
        End If

        conn.Close()
    End Sub

    Private Sub checkJamEdit_CheckedChanged(sender As Object, e As EventArgs) Handles checkJamEdit.CheckedChanged
        jamEdit.Enabled = checkJamEdit.Checked
    End Sub

    Private Sub btnEditTask_Click(sender As Object, e As EventArgs) Handles btnEditTask.Click
        If textJudulEdit.Text.Trim() = "" Then
            MessageBox.Show("Judul tidak boleh kosong.")
            Return
        End If

        koneksi()
        Dim sql As String = "
            UPDATE task_list SET
                judul = @judul,
                tanggal = @tanggal,
                jam = @jam,
                prioritas = @prioritas,
                deskripsi = @deskripsi
            WHERE id = @id"

        cmd = conn.CreateCommand()
        cmd.CommandText = sql
        cmd.Parameters.AddWithValue("@judul", textJudulEdit.Text)
        cmd.Parameters.AddWithValue("@tanggal", tglEdit.Value.ToString("yyyy-MM-dd"))
        cmd.Parameters.AddWithValue("@jam", If(checkJamEdit.Checked, jamEdit.Value.ToString("HH:mm"), ""))
        cmd.Parameters.AddWithValue("@prioritas", comboPrioritasEdit.Text)
        cmd.Parameters.AddWithValue("@deskripsi", textDeskripsiEdit.Text)
        cmd.Parameters.AddWithValue("@id", idTask)

        cmd.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Task berhasil diperbarui.")
        HomeForm.Show()
        HomeForm.tampilkanTask()
        Me.Close()
    End Sub

    Private Sub koneksi()
        conn = New SqliteConnection("Data Source=tasks.db")
        conn.Open()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        HomeForm.Show()
        Me.Close()
    End Sub
End Class
