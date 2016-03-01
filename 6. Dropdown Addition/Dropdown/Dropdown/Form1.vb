Public Class Form1

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim a As Double = TextBox1.Text
        Dim b As Double = TextBox2.Text
        If ComboBox1.SelectedItem = "+" Then
            TextBox3.Text = Val(a) + Val(b)
        ElseIf ComboBox1.SelectedItem = "-" Then
            TextBox3.Text = Val(a) - Val(b)
        ElseIf ComboBox1.SelectedItem = "*" Then
            TextBox3.Text = Val(a) * Val(b)
        ElseIf ComboBox1.SelectedItem = "/" Then
            TextBox3.Text = Val(a) / Val(b)
        End If
    End Sub
End Class
