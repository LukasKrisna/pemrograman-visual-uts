<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class soalNomer1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        DateTimePicker2 = New DateTimePicker()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(55, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 21)
        Label1.TabIndex = 0
        Label1.Text = "Nama"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(55, 116)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 21)
        Label2.TabIndex = 1
        Label2.Text = "Jumlah Buku"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(55, 169)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 21)
        Label3.TabIndex = 2
        Label3.Text = "Tanggal Pinjam"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(55, 226)
        Label4.Name = "Label4"
        Label4.Size = New Size(123, 21)
        Label4.TabIndex = 3
        Label4.Text = "Tanggal Kembali"' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(221, 59)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(159, 23)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(221, 118)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(159, 23)
        TextBox2.TabIndex = 5
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(221, 168)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(184, 23)
        DateTimePicker1.TabIndex = 6
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(221, 224)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(184, 23)
        DateTimePicker2.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(149, 279)
        Button1.Name = "Button1"
        Button1.Size = New Size(124, 38)
        Button1.TabIndex = 8
        Button1.Text = "Hitung"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(449, 378)
        Controls.Add(Button1)
        Controls.Add(DateTimePicker2)
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Button1 As Button
End Class
