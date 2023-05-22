Public Class soalNomer7
    Private Sub hitungZodiakDanShio()
        Dim tglLahir As DateTime = DateTimePicker1.Value
        Dim zodiak As String = ""
        Dim shio As String = ""

        Select Case tglLahir.Month
            Case 1
                If tglLahir.Day <= 19 Then
                    zodiak = "Capricorn"
                Else
                    zodiak = "Aquarius"
                End If
            Case 2
                If tglLahir.Day <= 18 Then
                    zodiak = "Aquarius"
                Else
                    zodiak = "Pisces"
                End If
            Case 3
                If tglLahir.Day <= 20 Then
                    zodiak = "Pisces"
                Else
                    zodiak = "Aries"
                End If
            Case 4
                If tglLahir.Day <= 19 Then
                    zodiak = "Aries"
                Else
                    zodiak = "Taurus"
                End If
            Case 5
                If tglLahir.Day <= 20 Then
                    zodiak = "Taurus"
                Else
                    zodiak = "Gemini"
                End If
            Case 6
                If tglLahir.Day <= 20 Then
                    zodiak = "Gemini"
                Else
                    zodiak = "Cancer"
                End If
            Case 7
                If tglLahir.Day <= 22 Then
                    zodiak = "Cancer"
                Else
                    zodiak = "Leo"
                End If
            Case 8
                If tglLahir.Day <= 22 Then
                    zodiak = "Leo"
                Else
                    zodiak = "Virgo"
                End If
            Case 9
                If tglLahir.Day <= 22 Then
                    zodiak = "Virgo"
                Else
                    zodiak = "Libra"
                End If
            Case 10
                If tglLahir.Day <= 22 Then
                    zodiak = "Libra"
                Else
                    zodiak = "Scorpio"
                End If
            Case 11
                If tglLahir.Day <= 21 Then
                    zodiak = "Scorpio"
                Else
                    zodiak = "Sagittarius"
                End If
            Case 12
                If tglLahir.Day <= 21 Then
                    zodiak = "Sagittarius"
                Else
                    zodiak = "Capricorn"
                End If
        End Select

        Dim tahunLahir As Integer = tglLahir.Year
        Dim sisaBagi As Integer = tahunLahir Mod 12

        Select Case sisaBagi
            Case 0
                shio = "Monyet"
            Case 1
                shio = "Ayam"
            Case 2
                shio = "Anjing"
            Case 3
                shio = "Babi"
            Case 4
                shio = "Tikus"
            Case 5
                shio = "Sapi"
            Case 6
                shio = "Harimau"
            Case 7
                shio = "Kelinci"
            Case 8
                shio = "Naga"
            Case 9
                shio = "Ular"
            Case 10
                shio = "Kuda"
            Case 11
                shio = "Kambing"
        End Select

        Label9.Text = zodiak
        Label11.Text = shio
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label7.Text = TextBox1.Text
        Label8.Text = DateDiff(DateInterval.Year, DateTimePicker1.Value, Now)
        hitungZodiakDanShio()
    End Sub
End Class