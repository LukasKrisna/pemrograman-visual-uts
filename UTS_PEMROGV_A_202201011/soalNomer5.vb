Public Class soalNomer5
    Dim jumlahKend, masihBerlaku, hampirHabis, habis
    Private Sub Process1()
        Dim selisiKend1
        selisiKend1 = DateDiff(DateInterval.Day, Now, DateTimePicker1.Value)

        If ComboBox1.Text And TextBox1.Text = " " Then
            Label8.Text = "Data harus valid!"
        Else
            If selisiKend1 > 30 Then
                Label8.Text = "Masih Berlaku"
                Label8.ForeColor = Color.Green
                masihBerlaku += 1
            ElseIf selisiKend1 > 0 And selisiKend1 <= 30 Then
                Label8.Text = "Hampir Habis"
                Label8.ForeColor = Color.Yellow
                hampirHabis += 1
            Else
                Label8.Text = "Habis"
                Label8.ForeColor = Color.Red
                habis += 1
            End If

            jumlahKend += 1
        End If

    End Sub
    Private Sub Process2()
        Dim selisihKend2
        selisihKend2 = DateDiff(DateInterval.Day, Now, DateTimePicker2.Value)

        If ComboBox2.Text And TextBox2.Text = " " Then
            Label9.Text = "Data harus valid!"
        Else
            If selisihKend2 > 30 Then
                Label9.Text = "Masih Berlaku"
                Label9.ForeColor = Color.Green
                masihBerlaku += 1
            ElseIf selisihKend2 > 0 And selisihKend2 <= 30 Then
                Label9.Text = "Hampir Habis"
                Label9.ForeColor = Color.Yellow
                hampirHabis += 1
            Else
                Label9.Text = "Habis"
                Label9.ForeColor = Color.Red
                habis += 1
            End If

            jumlahKend += 1
        End If
    End Sub
    Private Sub Process3()
        Dim selisihKend3
        selisihKend3 = DateDiff(DateInterval.Day, Now, DateTimePicker3.Value)

        If ComboBox3.Text And TextBox3.Text = " " Then
            Label10.Text = "Data harus valid!"
        Else
            If selisihKend3 > 30 Then
                Label10.Text = "Masih Berlaku"
                Label10.ForeColor = Color.Green
                masihBerlaku += 1
            ElseIf selisihKend3 > 0 And selisihKend3 <= 30 Then
                Label10.Text = "Hampir Habis"
                Label10.ForeColor = Color.Yellow
                hampirHabis += 1
            Else
                Label10.Text = "Habis"
                Label10.ForeColor = Color.Red
                habis += 1
            End If

            jumlahKend += 1
        End If
    End Sub
    Private Sub bt_hitung_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process1()
        Process2()
        Process3()

        Label18.Text = jumlahKend
        Label15.Text = masihBerlaku
        Label16.Text = hampirHabis
        Label17.Text = habis
    End Sub

    Private Sub dtp_1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Process1()
    End Sub

    Private Sub dtp_2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        Process2()
    End Sub

    Private Sub dtp_3_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker3.ValueChanged
        Process3()
    End Sub
End Class