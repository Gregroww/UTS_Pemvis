<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewTask
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        labelTambah = New Label()
        dayLabel = New Label()
        textJudul = New TextBox()
        tgl = New DateTimePicker()
        jam = New DateTimePicker()
        checkJam = New CheckBox()
        labelJam = New Label()
        comboPrioritas = New ComboBox()
        Label1 = New Label()
        textDeskripsi = New TextBox()
        btnTambahTask = New Button()
        btnBatal = New Button()
        SuspendLayout()
        ' 
        ' labelTambah
        ' 
        labelTambah.AutoSize = True
        labelTambah.Font = New Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        labelTambah.Location = New Point(12, 30)
        labelTambah.Name = "labelTambah"
        labelTambah.Size = New Size(189, 31)
        labelTambah.TabIndex = 1
        labelTambah.Text = "Tambah Kegiatan"
        labelTambah.TextAlign = ContentAlignment.TopCenter
        ' 
        ' dayLabel
        ' 
        dayLabel.AutoSize = True
        dayLabel.Font = New Font("Sylfaen", 10F)
        dayLabel.Location = New Point(23, 100)
        dayLabel.Name = "dayLabel"
        dayLabel.Size = New Size(59, 26)
        dayLabel.TabIndex = 4
        dayLabel.Text = "Judul"
        dayLabel.TextAlign = ContentAlignment.TopCenter
        ' 
        ' textJudul
        ' 
        textJudul.BackColor = Color.WhiteSmoke
        textJudul.Location = New Point(25, 130)
        textJudul.Name = "textJudul"
        textJudul.Size = New Size(442, 31)
        textJudul.TabIndex = 5
        ' 
        ' tgl
        ' 
        tgl.Format = DateTimePickerFormat.Short
        tgl.Location = New Point(91, 182)
        tgl.Name = "tgl"
        tgl.Size = New Size(136, 31)
        tgl.TabIndex = 6
        ' 
        ' jam
        ' 
        jam.Format = DateTimePickerFormat.Time
        jam.Location = New Point(348, 182)
        jam.Name = "jam"
        jam.Size = New Size(119, 31)
        jam.TabIndex = 7
        ' 
        ' checkJam
        ' 
        checkJam.AutoSize = True
        checkJam.Location = New Point(28, 238)
        checkJam.Name = "checkJam"
        checkJam.Size = New Size(22, 21)
        checkJam.TabIndex = 8
        checkJam.UseVisualStyleBackColor = True
        ' 
        ' labelJam
        ' 
        labelJam.AutoSize = True
        labelJam.Font = New Font("Sylfaen", 8F)
        labelJam.Location = New Point(56, 236)
        labelJam.Name = "labelJam"
        labelJam.Size = New Size(94, 22)
        labelJam.TabIndex = 9
        labelJam.Text = "Sertakan jam"
        labelJam.TextAlign = ContentAlignment.TopCenter
        ' 
        ' comboPrioritas
        ' 
        comboPrioritas.DisplayMember = "Penting, Tidak Penting"
        comboPrioritas.FormattingEnabled = True
        comboPrioritas.Location = New Point(91, 286)
        comboPrioritas.Name = "comboPrioritas"
        comboPrioritas.Size = New Size(376, 33)
        comboPrioritas.TabIndex = 10
        comboPrioritas.Text = "Penting"
        comboPrioritas.ValueMember = "Penting, Tidak Penting"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sylfaen", 10F)
        Label1.Location = New Point(23, 340)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 26)
        Label1.TabIndex = 11
        Label1.Text = "Judul"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' textDeskripsi
        ' 
        textDeskripsi.BackColor = Color.WhiteSmoke
        textDeskripsi.Location = New Point(23, 378)
        textDeskripsi.Multiline = True
        textDeskripsi.Name = "textDeskripsi"
        textDeskripsi.Size = New Size(442, 184)
        textDeskripsi.TabIndex = 12
        ' 
        ' btnTambahTask
        ' 
        btnTambahTask.Location = New Point(355, 585)
        btnTambahTask.Name = "btnTambahTask"
        btnTambahTask.Size = New Size(112, 34)
        btnTambahTask.TabIndex = 13
        btnTambahTask.Text = "Tambah"
        btnTambahTask.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(237, 585)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(112, 34)
        btnBatal.TabIndex = 14
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' AddNewTask
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(493, 675)
        Controls.Add(btnBatal)
        Controls.Add(btnTambahTask)
        Controls.Add(textDeskripsi)
        Controls.Add(Label1)
        Controls.Add(comboPrioritas)
        Controls.Add(labelJam)
        Controls.Add(checkJam)
        Controls.Add(jam)
        Controls.Add(tgl)
        Controls.Add(textJudul)
        Controls.Add(dayLabel)
        Controls.Add(labelTambah)
        Name = "AddNewTask"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents labelTambah As Label
    Friend WithEvents dayLabel As Label
    Friend WithEvents textJudul As TextBox
    Friend WithEvents tgl As DateTimePicker
    Friend WithEvents jam As DateTimePicker
    Friend WithEvents checkJam As CheckBox
    Friend WithEvents labelJam As Label
    Friend WithEvents comboPrioritas As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents textDeskripsi As TextBox
    Friend WithEvents btnTambahTask As Button
    Friend WithEvents btnBatal As Button
End Class
