Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s
        s = TextBox1.Text
        Dim i, c As Integer
        c = 0
        For i = 0 To Len(s) - 1
            c = c + 1
        Next i
        MsgBox("The given string contains " & c & " characters")
    End Sub
End Class
