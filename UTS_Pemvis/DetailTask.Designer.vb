<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetailTask
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
        detailJudul = New Label()
        detailTanggal = New Label()
        richDeskripsi = New RichTextBox()
        btnEdit = New Button()
        btnKembali = New Button()
        SuspendLayout()
        ' 
        ' detailJudul
        ' 
        detailJudul.AutoSize = True
        detailJudul.Font = New Font("Sylfaen", 12F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        detailJudul.Location = New Point(12, 90)
        detailJudul.Name = "detailJudul"
        detailJudul.Size = New Size(189, 31)
        detailJudul.TabIndex = 2
        detailJudul.Text = "Tambah Kegiatan"
        detailJudul.TextAlign = ContentAlignment.TopCenter
        ' 
        ' detailTanggal
        ' 
        detailTanggal.AutoSize = True
        detailTanggal.BorderStyle = BorderStyle.Fixed3D
        detailTanggal.Font = New Font("Sylfaen", 10F)
        detailTanggal.Location = New Point(12, 175)
        detailTanggal.Name = "detailTanggal"
        detailTanggal.Size = New Size(86, 28)
        detailTanggal.TabIndex = 5
        detailTanggal.Text = "12/12/12"
        detailTanggal.TextAlign = ContentAlignment.TopCenter
        ' 
        ' richDeskripsi
        ' 
        richDeskripsi.Location = New Point(12, 206)
        richDeskripsi.Name = "richDeskripsi"
        richDeskripsi.ReadOnly = True
        richDeskripsi.Size = New Size(452, 228)
        richDeskripsi.TabIndex = 7
        richDeskripsi.Text = ""
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(352, 37)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(112, 34)
        btnEdit.TabIndex = 14
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnKembali
        ' 
        btnKembali.Location = New Point(234, 37)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(112, 34)
        btnKembali.TabIndex = 15
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = True
        ' 
        ' DetailTask
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(493, 544)
        Controls.Add(btnKembali)
        Controls.Add(btnEdit)
        Controls.Add(richDeskripsi)
        Controls.Add(detailTanggal)
        Controls.Add(detailJudul)
        Name = "DetailTask"
        Text = "DetailTask"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents detailJudul As Label
    Friend WithEvents detailTanggal As Label
    Friend WithEvents detailPrioritas As Label
    Friend WithEvents richDeskripsi As RichTextBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnKembali As Button
End Class
