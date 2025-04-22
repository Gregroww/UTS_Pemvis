Imports Microsoft.Data.Sqlite

Public Class DetailTask
    ' property ID 
    Public idTask As Integer

    Dim conn As SqliteConnection
    Dim cmd As SqliteCommand
    Dim reader As SqliteDataReader

    Private Sub DetailTask_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' debug2
        If idTask = 0 Then
            MessageBox.Show("Task tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        SQLitePCL.Batteries.Init()
        conn = New SqliteConnection("Data Source=tasks.db")
        conn.Open()

        Dim sql As String = "SELECT * FROM task_list WHERE id=@id"
        cmd = conn.CreateCommand()
        cmd.CommandText = sql
        cmd.Parameters.AddWithValue("@id", idTask)

        reader = cmd.ExecuteReader()

        If reader.Read() Then
            detailJudul.Text = reader("judul").ToString() & " - " & reader("prioritas").ToString()
            detailTanggal.Text = reader("tanggal").ToString()
            If Not reader.IsDBNull(reader.GetOrdinal("jam")) AndAlso reader("jam").ToString() <> "" Then
                detailTanggal.Text &= " - " & reader("jam").ToString()
            End If

            richDeskripsi.Text = reader("deskripsi").ToString()
        Else
            MessageBox.Show("Task tidak ditemukan di database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If

        conn.Close()
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        HomeForm.Show()
        HomeForm.tampilkanTask()
        Me.Close()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        ' debug1
        If idTask = 0 Then
            MessageBox.Show("Task tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Buka EditTask, kirim idTask
        Dim editForm As New EditTask
        editForm.idTask = Me.idTask
        editForm.Show()
        Me.Hide()
    End Sub
End Class
