Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            TextBox1.Text = "Java"
        ElseIf RadioButton2.Checked = True Then
            TextBox1.Text = "C++"
        ElseIf RadioButton3.Checked = True Then
            TextBox1.Text = "Oracle"
        ElseIf RadioButton4.Checked = True Then
            TextBox1.Text = "Visual Basic"
        ElseIf RadioButton5.Checked = True Then
            TextBox1.Text = "Javascript"
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
