Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mp, dis As Double
        mp = TextBox1.Text
        dis = TextBox2.Text
        TextBox3.Text = (1 - (dis / 100)) * mp
    End Sub
End Class
