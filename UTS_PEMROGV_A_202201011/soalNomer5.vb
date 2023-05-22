Public Class soalNomer5
    Dim jumlahKend, masihBerlaku, hampirHabis, habis As Integer

    Private Sub Process(ByVal selisihKend As Integer, ByVal comboBox As ComboBox, ByVal textBox As TextBox, ByVal label As Label)
        If comboBox.Text = "" Or textBox.Text = "" Then
            label.Text = "Data harus valid!"
        Else
            If selisihKend > 30 Then
                label.Text = "Masih Berlaku"
                label.ForeColor = Color.Green
                masihBerlaku += 1
            ElseIf selisihKend > 0 And selisihKend <= 30 Then
                label.Text = "Hampir Habis"
                label.ForeColor = Color.Yellow
                hampirHabis += 1
            Else
                label.Text = "Habis"
                label.ForeColor = Color.Red
                habis += 1
            End If

            jumlahKend += 1
        End If
    End Sub

    Private Sub Process1()
        Dim selisiKend1 As Integer = DateDiff(DateInterval.Day, Now, DateTimePicker1.Value)
        Process(selisiKend1, ComboBox1, TextBox1, Label8)
    End Sub

    Private Sub Process2()
        Dim selisihKend2 As Integer = DateDiff(DateInterval.Day, Now, DateTimePicker2.Value)
        Process(selisihKend2, ComboBox2, TextBox2, Label9)
    End Sub

    Private Sub Process3()
        Dim selisihKend3 As Integer = DateDiff(DateInterval.Day, Now, DateTimePicker3.Value)
        Process(selisihKend3, ComboBox3, TextBox3, Label10)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        jumlahKend = 0
        masihBerlaku = 0
        hampirHabis = 0
        habis = 0

        Process1()
        Process2()
        Process3()

        Label18.Text = jumlahKend.ToString()
        Label15.Text = masihBerlaku.ToString()
        Label16.Text = hampirHabis.ToString()
        Label17.Text = habis.ToString()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Process1()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        Process2()
    End Sub

    Private Sub DateTimePicker3_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker3.ValueChanged
        Process3()
    End Sub
End Class