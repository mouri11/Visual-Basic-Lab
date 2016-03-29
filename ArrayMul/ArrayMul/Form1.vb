Public Class Form1
    Dim a(,), b(,), c(,), r1, c1, r2, c2 As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i, j As Integer
        r1 = InputBox("Enter no. of rows of first list.")
        c1 = InputBox("Enter no. of columns of first list.")
        ReDim a(r1 - 1, c1 - 1)
        For i = 0 To (r1 - 1)
            For j = 0 To (c1 - 1)
                a(i, j) = InputBox("Enter the elements for 1st list.")
            Next j
        Next i
        For i = 0 To r1 - 1
            For j = 0 To c1 - 1
                ListView1.Items.Add(a(i, j))
            Next j
        Next i
        ListView1.Visible = True
        r2 = InputBox("Enter no. of rows of second list.")
        c2 = InputBox("Enter no. of columns of second list.")
        ReDim b(r2 - 1, c2 - 1)
        For i = 0 To (r2 - 1)
            For j = 0 To (c2 - 1)
                b(i, j) = InputBox("Enter the elements for 2nd list.")
            Next j
        Next i
        For i = 0 To r2 - 1
            For j = 0 To c2 - 1
                ListView2.Items.Add(b(i, j))
            Next j
        Next i
        ListView2.Visible = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, j, k, m, n, sum As Integer
        ReDim c(r1 - 1, c2 - 1)
        If (c1 = r2) Then
            For m = 0 To (r1 - 1)
                For n = 0 To (c2 - 1)
                    For k = 0 To (c1 - 1)
                        sum = sum + a(m, k) * b(k, n)
                    Next k
                    c(m, n) = sum
                    sum = 0
                Next n
            Next m
        End If
        For i = 0 To r1 - 1
            For j = 0 To c2 - 1
                ListView3.Items.Add(c(i, j))
            Next j
        Next i
        ListView3.Visible = True
    End Sub
End Class
