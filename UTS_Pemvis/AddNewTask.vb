Imports Microsoft.Data.Sqlite

Public Class AddNewTask
    Dim conn As SqliteConnection
    Dim cmd As SqliteCommand

    Private Sub koneksi()
        conn = New SqliteConnection("Data Source=tasks.db")
        conn.Open()
    End Sub

    Private Sub checkJam_CheckedChanged(sender As Object, e As EventArgs) Handles checkJam.CheckedChanged
        jam.Enabled = checkJam.Checked
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        HomeForm.Show()
        HomeForm.tampilkanTask()
        Me.Close()
    End Sub

    Private Sub btnTambahTask_Click(sender As Object, e As EventArgs) Handles btnTambahTask.Click
        If textJudul.Text = "" Or comboPrioritas.Text = "" Then
            MsgBox("Judul dan Prioritas wajib diisi!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        koneksi()

        Dim tanggal As String = tgl.Value.ToString("dd-MM-yyyy")
        Dim jamValue As String = If(checkJam.Checked, jam.Value.ToString("HH:mm"), "")

        Dim sql As String = "
            INSERT INTO task_list (judul, tanggal, jam, prioritas, deskripsi, selesai)
            VALUES (@judul, @tanggal, @jam, @prioritas, @deskripsi, 0)"
        cmd = conn.CreateCommand()
        cmd.CommandText = sql
        cmd.Parameters.AddWithValue("@judul", textJudul.Text)
        cmd.Parameters.AddWithValue("@tanggal", tanggal)
        cmd.Parameters.AddWithValue("@jam", jamValue)
        cmd.Parameters.AddWithValue("@prioritas", comboPrioritas.Text)
        cmd.Parameters.AddWithValue("@deskripsi", textDeskripsi.Text)
        cmd.ExecuteNonQuery()

        MsgBox("Task berhasil ditambahkan!", MsgBoxStyle.Information)
        conn.Close()

        HomeForm.Show()
        HomeForm.tampilkanTask()
        Me.Close()
    End Sub
End Class
