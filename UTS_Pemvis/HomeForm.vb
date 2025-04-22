Imports Microsoft.Data.Sqlite
Imports System.IO

Public Class HomeForm
    Dim conn As SqliteConnection
    Dim cmd As SqliteCommand
    Dim reader As SqliteDataReader

    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SQLitePCL.Batteries.Init()

        ' cek dan buat database kalau belum ada
        If Not File.Exists("tasks.db") Then
            conn = New SqliteConnection("Data Source=tasks.db")
            conn.Open()

            Dim sqlCreate As String = "
                CREATE TABLE task_list (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    judul TEXT,
                    tanggal TEXT,
                    jam TEXT,
                    prioritas TEXT,
                    deskripsi TEXT,
                    selesai INTEGER
                )"
            cmd = conn.CreateCommand()
            cmd.CommandText = sqlCreate
            cmd.ExecuteNonQuery()
            conn.Close()
        End If

        tampilkanTask()
    End Sub

    ' koneksi SQLite
    Private Sub koneksi()
        conn = New SqliteConnection("Data Source=tasks.db")
        conn.Open()
    End Sub

    ' tampilkan task ke FlowLayoutPanel status selesai
    Public Sub tampilkanTask()
        koneksi()
        FlowLayoutPanel1.Controls.Clear()
        FlowLayoutPanel2.Controls.Clear()

        ' ambil data terurut dari yang paling dekat waktunya
        Dim sql As String = "SELECT * FROM task_list ORDER BY tanggal ASC, jam ASC"
        cmd = conn.CreateCommand()
        cmd.CommandText = sql
        reader = cmd.ExecuteReader()

        While reader.Read()
            Dim selesai As Boolean = reader.GetInt32(reader.GetOrdinal("selesai")) = 1

            Dim groupTask As New GroupBox With {
                .Width = 459,
                .Height = 76
            }

            Dim idTask As Integer = reader.GetInt32(reader.GetOrdinal("id"))

            Dim chk As New CheckBox With {
                .Location = New Point(10, 20),
                .Checked = selesai,
                .Width = 44,
                .Height = 44,
                .Tag = idTask
            }
            AddHandler chk.CheckedChanged, AddressOf taskSelesai

            Dim labelJudul As New Label With {
                .Text = reader("judul").ToString(),
                .Location = New Point(60, 26),
                .AutoSize = True,
                .Tag = idTask
            }
            AddHandler labelJudul.Click, AddressOf labelJudul_Click

            Dim labelJam As New Label
            Dim jamText As String = reader("tanggal").ToString()
            If Not reader.IsDBNull(reader.GetOrdinal("jam")) AndAlso reader("jam").ToString() <> "" Then
                jamText &= " - " & reader("jam").ToString()
            End If
            labelJam.Text = jamText
            labelJam.Location = New Point(283, 15)
            labelJam.AutoSize = True
            labelJam.BorderStyle = BorderStyle.FixedSingle

            Dim labelPrioritas As New Label With {
                .Text = reader("prioritas").ToString(),
                .Location = New Point(283, 43),
                .AutoSize = True,
                .BorderStyle = BorderStyle.FixedSingle
            }

            groupTask.Controls.Add(chk)
            groupTask.Controls.Add(labelJudul)
            groupTask.Controls.Add(labelJam)
            groupTask.Controls.Add(labelPrioritas)

            ' tambahkan ke panel 2 yang selesai
            If selesai Then
                FlowLayoutPanel2.Controls.Add(groupTask)
            Else
                FlowLayoutPanel1.Controls.Add(groupTask)
            End If
        End While

        conn.Close()
    End Sub

    ' Event saat checkbox task dicentang
    Private Sub taskSelesai(sender As Object, e As EventArgs)
        Dim checkbox As CheckBox = CType(sender, CheckBox)
        Dim idTask As Integer = CInt(checkbox.Tag)

        koneksi()
        Dim sql As String = "UPDATE task_list SET selesai = @selesai WHERE id = @id"
        cmd = conn.CreateCommand()
        cmd.CommandText = sql
        cmd.Parameters.AddWithValue("@selesai", If(checkbox.Checked, 1, 0))
        cmd.Parameters.AddWithValue("@id", idTask)
        cmd.ExecuteNonQuery()
        conn.Close()

        tampilkanTask()
    End Sub

    ' tombol tambah task baru
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        AddNewTask.Show()
        Me.Hide()
    End Sub

    ' klik judul, buka detail
    Private Sub labelJudul_Click(sender As Object, e As EventArgs)
        Dim label As Label = CType(sender, Label)
        Dim idTask As Integer = CInt(label.Tag)

        Dim detailForm As New DetailTask
        detailForm.idTask = idTask
        detailForm.Show()
        Me.Hide()
    End Sub
End Class
