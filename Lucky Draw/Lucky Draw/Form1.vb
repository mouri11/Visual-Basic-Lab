Public Class Form1
    Dim rand As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        rand = CInt(Int((8 * Rnd()) + 0))
        MsgBox(rand)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lol()
        If (Button1.Text = rand) Then
            Button1.Text = "You got the prize!!"
        Else
            laab()
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lol()
        If (Button2.Text = rand) Then
            Button2.Text = "You got the prize!!"
        Else
            laab()
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        lol()
        If (Button3.Text = rand) Then
            Button3.Text = "You got the prize!!"
        Else
            laab()
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        lol()
        If (Button4.Text = rand) Then
            Button4.Text = "You got the prize!!"
        Else
            laab()
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        lol()
        If (Button5.Text = rand) Then
            Button5.Text = "You got the prize!!"
        Else
            laab()
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        lol()
        If (Button6.Text = rand) Then
            Button6.Text = "You got the prize!!"
        Else
            laab()
        End If
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        lol()
        If (Button7.Text = rand) Then
            Button7.Text = "You got the prize!!"
        Else
            laab()
        End If
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        lol()
        If (Button8.Text = rand) Then
            Button8.Text = "You got the prize!!"
        Else
            laab()
        End If
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        lol()
        If (Button9.Text = rand) Then
            Button9.Text = "You got the prize!!"
        Else
            laab()
        End If
    End Sub
    Private Sub lol()
        Button1.Text = "0"
        Button2.Text = "1"
        Button3.Text = "2"
        Button4.Text = "3"
        Button5.Text = "4"
        Button6.Text = "5"
        Button7.Text = "6"
        Button8.Text = "7"
        Button9.Text = "8"

        Randomize()
        rand = CInt(Int((8 * Rnd()) + 0))
    End Sub
    Private Sub laab()
        If (Button1.Text = rand) Then
            Button1.Text = "Sorry!!Prize was here!!!"
        ElseIf (Button2.Text = rand) Then
            Button2.Text = "Sorry!!Prize was here!!!"
        ElseIf (Button3.Text = rand) Then
            Button3.Text = "Sorry!!Prize was here!!!"
        ElseIf (Button4.Text = rand) Then
            Button4.Text = "Sorry!!Prize was here!!!"
        ElseIf (Button5.Text = rand) Then
            Button5.Text = "Sorry!!Prize was here!!!"
        ElseIf (Button6.Text = rand) Then
            Button6.Text = "Sorry!!Prize was here!!!"
        ElseIf (Button7.Text = rand) Then
            Button7.Text = "Sorry!!Prize was here!!!"
        ElseIf (Button8.Text = rand) Then
            Button8.Text = "Sorry!!Prize was here!!!"
        ElseIf (Button9.Text = rand) Then
            Button9.Text = "Sorry!!Prize was here!!!"
        End If
    End Sub
End Class
