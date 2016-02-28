Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Double = TextBox1.Text
        Dim b As Double = TextBox2.Text

        TextBox3.Text = Val(a) + Val(b)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a As Double = TextBox1.Text
        Dim b As Double = TextBox2.Text

        TextBox3.Text = Val(a) * Val(b)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a As Double = TextBox1.Text
        Dim b As Double = TextBox2.Text

        TextBox3.Text = Val(a) - Val(b)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim a As Double = TextBox1.Text
        Dim b As Double = TextBox2.Text

        If b = 0 Then
            TextBox3.Text = "Grow up Kid, You can't do that !"
        Else
            TextBox3.Text = Val(a) / Val(b)
        End If

    End Sub



End Class
