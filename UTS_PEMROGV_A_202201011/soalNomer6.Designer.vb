<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class soalNomer6
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
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Button1 = New Button()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(40, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nama"' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(199, 49)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(439, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(40, 87)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 15)
        Label2.TabIndex = 2
        Label2.Text = "Tanggal Lahir"' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(199, 87)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(40, 153)
        Label3.Name = "Label3"
        Label3.Size = New Size(33, 15)
        Label3.TabIndex = 4
        Label3.Text = "Hasil"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(40, 189)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 15)
        Label4.TabIndex = 5
        Label4.Text = "Nama Anda : "' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(40, 214)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 15)
        Label5.TabIndex = 6
        Label5.Text = "Umur Anda : "' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(40, 238)
        Label6.Name = "Label6"
        Label6.Size = New Size(83, 15)
        Label6.TabIndex = 7
        Label6.Text = "Zodiak Anda : "' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(351, 227)
        Button1.Name = "Button1"
        Button1.Size = New Size(270, 66)
        Button1.TabIndex = 8
        Button1.Text = "Hitung"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(135, 189)
        Label7.Name = "Label7"
        Label7.Size = New Size(12, 15)
        Label7.TabIndex = 9
        Label7.Text = "-"' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(135, 214)
        Label8.Name = "Label8"
        Label8.Size = New Size(12, 15)
        Label8.TabIndex = 10
        Label8.Text = "-"' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(135, 238)
        Label9.Name = "Label9"
        Label9.Size = New Size(12, 15)
        Label9.TabIndex = 11
        Label9.Text = "-"' 
        ' soalNomer6
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(719, 331)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Button1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "soalNomer6"
        Text = "soalNomer6"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
