Public Class Form1
    Dim a(100), b(100), r1, r2, i As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pos As Integer
        pos = ListBox1.SelectedIndex
        ListBox2.Items.Add(ListBox1.SelectedItem())
        ListBox1.Items.RemoveAt(pos)
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        End
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        r1 = InputBox("Enter length of first string.")
        For i = 0 To (r1 - 1)
            a(i) = InputBox("Enter the elements for 1st list.")
            ListBox1.Items.Add(a(i))
        Next i
        r2 = InputBox("Enter length of first string.")
        For i = 0 To (r2 - 1)
            b(i) = InputBox("Enter the elements for 2nd list.")
            ListBox2.Items.Add(b(i))
        Next i
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim pos As Integer
        pos = ListBox2.SelectedIndex
        ListBox1.Items.Add(ListBox2.SelectedItem())
        ListBox2.Items.RemoveAt(pos)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim c, n As Integer
        c = ListBox1.Items.Count
        If c = 0 Then
            MsgBox("List is empty.")
        Else
            i = 0
            n = c - 1
            Do While i <= n
                If (ListBox1.GetSelected(i) = True) Then
                    ListBox2.Items.Add(ListBox1.SelectedItem())
                    ListBox1.Items.RemoveAt(i)
                    i = i - 1
                    n = n - 1
                End If
                i = i + 1
            Loop
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim c, n As Integer
        c = ListBox2.Items.Count
        If c = 0 Then
            MsgBox("List is empty.")
        Else
            i = 0
            n = c - 1
            Do While i <= n
                If (ListBox2.GetSelected(i) = True) Then
                    ListBox1.Items.Add(ListBox2.SelectedItem())
                    ListBox2.Items.RemoveAt(i)
                    i = i - 1
                    n = n - 1
                End If
                i = i + 1
            Loop
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim c, n, k As Integer
        c = ListBox1.Items.Count
        If (c = 0) Then
            MsgBox("List is empty")
        Else
            i = 0
            n = c - 1
            Do While i <= n
                ListBox2.Items.Add(ListBox1.Items(i))
                i = i + 1
            Loop
            ListBox1.Items.Clear()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim c, n, k As Integer
        c = ListBox2.Items.Count
        If (c = 0) Then
            MsgBox("List is empty")
        Else
            i = 0
            n = c - 1
            Do While i <= n
                ListBox1.Items.Add(ListBox2.Items(i))
                i = i + 1
            Loop
            ListBox2.Items.Clear()
        End If
    End Sub
End Class
