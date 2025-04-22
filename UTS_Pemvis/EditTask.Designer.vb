<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditTask
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
        btnBatal = New Button()
        btnEditTask = New Button()
        textDeskripsiEdit = New TextBox()
        Label1 = New Label()
        comboPrioritasEdit = New ComboBox()
        labelJam = New Label()
        checkJamEdit = New CheckBox()
        jamEdit = New DateTimePicker()
        tglEdit = New DateTimePicker()
        textJudulEdit = New TextBox()
        editJudul = New Label()
        labelTambah = New Label()
        SuspendLayout()
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(244, 598)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(112, 34)
        btnBatal.TabIndex = 26
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' btnEditTask
        ' 
        btnEditTask.Location = New Point(362, 598)
        btnEditTask.Name = "btnEditTask"
        btnEditTask.Size = New Size(112, 34)
        btnEditTask.TabIndex = 25
        btnEditTask.Text = "Edit"
        btnEditTask.UseVisualStyleBackColor = True
        ' 
        ' textDeskripsiEdit
        ' 
        textDeskripsiEdit.BackColor = Color.WhiteSmoke
        textDeskripsiEdit.Location = New Point(30, 391)
        textDeskripsiEdit.Multiline = True
        textDeskripsiEdit.Name = "textDeskripsiEdit"
        textDeskripsiEdit.Size = New Size(442, 184)
        textDeskripsiEdit.TabIndex = 24
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sylfaen", 10F)
        Label1.Location = New Point(30, 353)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 26)
        Label1.TabIndex = 23
        Label1.Text = "Deskripsi"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' comboPrioritasEdit
        ' 
        comboPrioritasEdit.DisplayMember = "Penting, Tidak Penting"
        comboPrioritasEdit.FormattingEnabled = True
        comboPrioritasEdit.Location = New Point(98, 299)
        comboPrioritasEdit.Name = "comboPrioritasEdit"
        comboPrioritasEdit.Size = New Size(376, 33)
        comboPrioritasEdit.TabIndex = 22
        comboPrioritasEdit.Text = "Penting"
        comboPrioritasEdit.ValueMember = "Penting, Tidak Penting"
        ' 
        ' labelJam
        ' 
        labelJam.AutoSize = True
        labelJam.Font = New Font("Sylfaen", 8F)
        labelJam.Location = New Point(63, 249)
        labelJam.Name = "labelJam"
        labelJam.Size = New Size(94, 22)
        labelJam.TabIndex = 21
        labelJam.Text = "Sertakan jam"
        labelJam.TextAlign = ContentAlignment.TopCenter
        ' 
        ' checkJamEdit
        ' 
        checkJamEdit.AutoSize = True
        checkJamEdit.Location = New Point(35, 251)
        checkJamEdit.Name = "checkJamEdit"
        checkJamEdit.Size = New Size(22, 21)
        checkJamEdit.TabIndex = 20
        checkJamEdit.UseVisualStyleBackColor = True
        ' 
        ' jamEdit
        ' 
        jamEdit.Format = DateTimePickerFormat.Time
        jamEdit.Location = New Point(355, 195)
        jamEdit.Name = "jamEdit"
        jamEdit.Size = New Size(119, 31)
        jamEdit.TabIndex = 19
        ' 
        ' tglEdit
        ' 
        tglEdit.Format = DateTimePickerFormat.Short
        tglEdit.Location = New Point(98, 195)
        tglEdit.Name = "tglEdit"
        tglEdit.Size = New Size(136, 31)
        tglEdit.TabIndex = 18
        ' 
        ' textJudulEdit
        ' 
        textJudulEdit.BackColor = Color.WhiteSmoke
        textJudulEdit.Location = New Point(32, 143)
        textJudulEdit.Name = "textJudulEdit"
        textJudulEdit.Size = New Size(442, 31)
        textJudulEdit.TabIndex = 17
        ' 
        ' editJudul
        ' 
        editJudul.AutoSize = True
        editJudul.Font = New Font("Sylfaen", 10F)
        editJudul.Location = New Point(30, 113)
        editJudul.Name = "editJudul"
        editJudul.Size = New Size(59, 26)
        editJudul.TabIndex = 16
        editJudul.Text = "Judul"
        editJudul.TextAlign = ContentAlignment.TopCenter
        ' 
        ' labelTambah
        ' 
        labelTambah.AutoSize = True
        labelTambah.Font = New Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        labelTambah.Location = New Point(19, 43)
        labelTambah.Name = "labelTambah"
        labelTambah.Size = New Size(148, 31)
        labelTambah.TabIndex = 15
        labelTambah.Text = "Edit Kegiatan"
        labelTambah.TextAlign = ContentAlignment.TopCenter
        ' 
        ' EditTask
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(493, 675)
        Controls.Add(btnBatal)
        Controls.Add(btnEditTask)
        Controls.Add(textDeskripsiEdit)
        Controls.Add(Label1)
        Controls.Add(comboPrioritasEdit)
        Controls.Add(labelJam)
        Controls.Add(checkJamEdit)
        Controls.Add(jamEdit)
        Controls.Add(tglEdit)
        Controls.Add(textJudulEdit)
        Controls.Add(editJudul)
        Controls.Add(labelTambah)
        Name = "EditTask"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBatal As Button
    Friend WithEvents btnEditTask As Button
    Friend WithEvents textDeskripsiEdit As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents comboPrioritasEdit As ComboBox
    Friend WithEvents labelJam As Label
    Friend WithEvents checkJamEdit As CheckBox
    Friend WithEvents jamEdit As DateTimePicker
    Friend WithEvents tglEdit As DateTimePicker
    Friend WithEvents textJudulEdit As TextBox
    Friend WithEvents editJudul As Label
    Friend WithEvents labelTambah As Label
End Class
