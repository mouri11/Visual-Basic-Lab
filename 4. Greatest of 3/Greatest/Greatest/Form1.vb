Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c As Double
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = Val(TextBox3.Text)

        If a >= b And a >= c Then
            TextBox4.Text = "Greatest is " & a
        ElseIf b >= a And b >= c Then
            TextBox4.Text = "Greatest is " & b
        Else
            TextBox4.Text = "Greatest is " & c
        End If
    End Sub
End Class
