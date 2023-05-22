Public Class soalNomer1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tglPinjam = Val(DateTimePicker1.Value.Date.Day)
        Dim tglKembali = Val(DateTimePicker2.Value.Date.Day)
        Dim tanggalPeminjaman As DateTime = DateTimePicker1.Value
        Dim tanggalPengembalian As DateTime = DateTimePicker2.Value

        Dim keterlambatan As Integer = (tanggalPengembalian - tanggalPeminjaman).Days - 7
        Dim denda As Integer = 0

        If TextBox2.Text > 3 Then
            MsgBox("Jumlah buku hanya dapat dipinjam sebanyak 3 buku!")
        End If

        If keterlambatan > 0 Then
            denda = keterlambatan * 1000
        Else
            keterlambatan = 0
        End If

        MsgBox("Nama : " & TextBox1.Text & vbCrLf & "Tanggal Pinjam : " &
               DateTimePicker1.Value & vbCrLf & "Tanggal Kembali : " &
               DateTimePicker2.Value & vbCrLf & "Terlambat : " & keterlambatan &
               vbCrLf & "Denda = " & denda)
    End Sub
End Class
