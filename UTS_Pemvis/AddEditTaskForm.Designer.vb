<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddEditTaskForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        boxJudul = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        checkJam = New CheckBox()
        jam = New ComboBox()
        Tanggal = New DateTimePicker()
        btnBatal = New Button()
        btnSimpan = New Button()
        penting = New ComboBox()
        boxDeskripsi = New RichTextBox()
        Label3 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' boxJudul
        ' 
        boxJudul.Location = New Point(49, 119)
        boxJudul.Name = "boxJudul"
        boxJudul.Size = New Size(662, 31)
        boxJudul.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(49, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(282, 37)
        Label1.TabIndex = 1
        Label1.Text = "Tambah Kegiatan"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(49, 91)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 25)
        Label2.TabIndex = 2
        Label2.Text = "Judul"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(49, 183)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(79, 75)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Location = New Point(468, 183)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(74, 75)
        PictureBox2.TabIndex = 4
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Location = New Point(49, 369)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(79, 75)
        PictureBox3.TabIndex = 5
        PictureBox3.TabStop = False
        ' 
        ' checkJam
        ' 
        checkJam.AutoSize = True
        checkJam.Location = New Point(49, 304)
        checkJam.Name = "checkJam"
        checkJam.Size = New Size(142, 29)
        checkJam.TabIndex = 6
        checkJam.Text = "Sertakan Jam"
        checkJam.UseVisualStyleBackColor = True
        ' 
        ' jam
        ' 
        jam.FormattingEnabled = True
        jam.Location = New Point(548, 205)
        jam.Name = "jam"
        jam.Size = New Size(163, 33)
        jam.TabIndex = 7
        ' 
        ' Tanggal
        ' 
        Tanggal.Location = New Point(149, 203)
        Tanggal.Name = "Tanggal"
        Tanggal.Size = New Size(300, 31)
        Tanggal.TabIndex = 9
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(432, 710)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(112, 34)
        btnBatal.TabIndex = 10
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(580, 710)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(112, 34)
        btnSimpan.TabIndex = 11
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' penting
        ' 
        penting.FormattingEnabled = True
        penting.Location = New Point(149, 393)
        penting.Name = "penting"
        penting.Size = New Size(562, 33)
        penting.TabIndex = 12
        ' 
        ' boxDeskripsi
        ' 
        boxDeskripsi.Location = New Point(49, 526)
        boxDeskripsi.Name = "boxDeskripsi"
        boxDeskripsi.Size = New Size(662, 144)
        boxDeskripsi.TabIndex = 14
        boxDeskripsi.Text = ""
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(49, 498)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 25)
        Label3.TabIndex = 15
        Label3.Text = "Deskripsi"
        ' 
        ' AddEditTaskForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(765, 772)
        Controls.Add(Label3)
        Controls.Add(boxDeskripsi)
        Controls.Add(penting)
        Controls.Add(btnSimpan)
        Controls.Add(btnBatal)
        Controls.Add(Tanggal)
        Controls.Add(jam)
        Controls.Add(checkJam)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(boxJudul)
        Name = "AddEditTaskForm"
        Text = "Tambah Kegiatan"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents boxJudul As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents checkJam As CheckBox
    Friend WithEvents jam As ComboBox
    Friend WithEvents Tanggal As DateTimePicker
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents penting As ComboBox
    Friend WithEvents boxDeskripsi As RichTextBox
    Friend WithEvents Label3 As Label

End Class
