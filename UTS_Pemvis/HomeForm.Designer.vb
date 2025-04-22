<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomeForm
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
        Label1 = New Label()
        Label2 = New Label()
        btnTambah = New Button()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(15, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(146, 31)
        Label1.TabIndex = 0
        Label1.Text = "Selamat pagi,"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(15, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(147, 31)
        Label2.TabIndex = 1
        Label2.Text = "Kelompok11!"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(369, 40)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(112, 34)
        btnTambah.TabIndex = 2
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Location = New Point(15, 113)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(466, 335)
        FlowLayoutPanel1.TabIndex = 10
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Location = New Point(12, 512)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(466, 151)
        FlowLayoutPanel2.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Sylfaen", 10F)
        Label3.Location = New Point(217, 483)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 26)
        Label3.TabIndex = 12
        Label3.Text = "Selesai"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' HomeForm
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.White
        ClientSize = New Size(493, 675)
        Controls.Add(Label3)
        Controls.Add(FlowLayoutPanel2)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(btnTambah)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "HomeForm"
        Text = "11's To-do"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Label3 As Label

End Class
