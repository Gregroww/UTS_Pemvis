Imports Microsoft.Data.Sqlite

Public Class HomeForm
    Private connectionString As String = "tasks.db"

    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configure DataGridView1 columns
        ConfigureDataGridView()
        ' Load tasks into DataGridView1
        LoadTasks()
    End Sub

    Private Sub ConfigureDataGridView()
        ' Clear existing columns
        DataGridView1.Columns.Clear()

        ' Add checkbox column for task completion
        Dim checkboxColumn As New DataGridViewCheckBoxColumn()
        checkboxColumn.Name = "IsCompleted"
        checkboxColumn.HeaderText = "Done"
        DataGridView1.Columns.Add(checkboxColumn)

        ' Add text columns for Judul, Tanggal, and Prioritas
        DataGridView1.Columns.Add("Judul", "Judul")
        DataGridView1.Columns.Add("Tanggal", "Tanggal")
        DataGridView1.Columns.Add("Prioritas", "Prioritas")
    End Sub

    Private Sub LoadTasks()
        ' Ensure the table exists
        Dim DDLry As String = "CREATE TABLE IF NOT EXISTS Tasks (Judul TEXT, Tanggal TEXT, Jam TEXT, Penting BOOLEAN, IsCompleted BOOLEAN)"
        Using connection As New SqliteConnection(connectionString)
            connection.Open()
            Using command As New SqliteCommand(DDLry, connection)
                command.ExecuteNonQuery() ' Execute the table creation command
            End Using
        End Using

        ' Clear existing items in DataGridView1
        DataGridView1.Rows.Clear()

        ' Query to fetch tasks from the database
        Dim query As String = "SELECT Judul, Tanggal, Jam, Penting, IsCompleted FROM Tasks"
        Using connection As New SqliteConnection(connectionString)
            connection.Open()
            Using command As New SqliteCommand(query, connection)
                Using reader As SqliteDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim judul As String = reader("Judul").ToString()
                        Dim tanggal As String = Convert.ToDateTime(reader("Tanggal")).ToString("yyyy-MM-dd")
                        Dim jam As String = If(IsDBNull(reader("Jam")), "", reader("Jam").ToString())
                        Dim penting As String = If(Convert.ToBoolean(reader("Penting")), "Penting", "Tidak Penting")
                        Dim isCompleted As Boolean = Convert.ToBoolean(reader("IsCompleted"))

                        ' Add row to DataGridView1
                        DataGridView1.Rows.Add(isCompleted, judul, tanggal, penting)
                    End While
                End Using
            End Using
        End Using
    End Sub


    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        ' Update task completion status in the database when checkbox is changed
        If e.ColumnIndex = DataGridView1.Columns("IsCompleted").Index AndAlso e.RowIndex >= 0 Then
            Dim isCompleted As Boolean = Convert.ToBoolean(DataGridView1.Rows(e.RowIndex).Cells("IsCompleted").Value)
            Dim judul As String = DataGridView1.Rows(e.RowIndex).Cells("Judul").Value.ToString()

            Dim query As String = "UPDATE Tasks SET IsCompleted = @IsCompleted WHERE Judul = @Judul"
            Using connection As New SqliteConnection(connectionString)
                connection.Open()
                Using command As New SqliteCommand(query, connection)
                    command.Parameters.AddWithValue("@IsCompleted", isCompleted)
                    command.Parameters.AddWithValue("@Judul", judul)
                    command.ExecuteNonQuery()
                End Using
            End Using
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim addEditForm As New AddEditTaskForm()
        addEditForm.ShowDialog()
        LoadTasks() ' Refresh tasks after adding/editing
    End Sub
End Class