Public Class Form1
    Dim a(), n As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i, j As Integer
        n = InputBox("Enter length of array:")
        ReDim a(n - 1)
        For i = 0 To n - 1
            a(i) = InputBox("Enter elements of array:")
        Next i
        Dim temp As Integer
        For i = 1 To n - 1
            For j = 0 To n - i - 1
                If (a(j) > a(j + 1)) Then
                    temp = a(j)
                    a(j) = a(j + 1)
                    a(j + 1) = temp
                End If
            Next
        Next
        For i = 0 To n - 1
            ListView1.Items.Add(a(i))
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim key, mid, start, last, flag As Integer
        mid = 0
        flag = 0
        start = 0
        last = n - 1
        key = InputBox("Enter value to be searched")
        mid = (start + last) / 2
        While start <= last
            If (a(mid) = key) Then
                flag = 1
                Exit While
            ElseIf (key < a(mid)) Then
                last = mid - 1
            ElseIf (key > a(mid)) Then
                start = mid + 1
            End If
            mid = (start + last) / 2
        End While
        If (flag = 1) Then
            MsgBox("Your key " & key & " is found at " & mid)
            TextBox1.Text = key
        Else : MsgBox("Sorry! Key not Found!!")
        End If
    End Sub
End Class
