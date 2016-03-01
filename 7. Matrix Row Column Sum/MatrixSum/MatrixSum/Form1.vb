Public Class Form1
    Dim arr(,), r, i, j As Integer
    Private Sub Form1_Load(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles MyBase.Load
        r = InputBox("Enter number of rows")
        ReDim arr(r - 1, r - 1)
        For i = 0 To r - 1
            For j = 0 To r - 1
                arr(i, j) = InputBox("Enter the element")
            Next j
        Next i
        Dim s
        s = ""
        For i = 0 To r - 1
            For j = 0 To r - 1
                s = s & " " & arr(i, j)
            Next j
            ListView1.Items.Add(s)
            s = ""
        Next i
        ListView1.Visible = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ld As Integer
        For i = 0 To r - 1
            ld = ld + arr(i, i)
        Next i
        TextBox1.Text = ld
        Dim rd As Integer
        For i = 0 To r - 1
            rd = rd + arr(i, r - i - 1)
        Next i
        TextBox2.Text = rd

        Dim rs As Integer
        For i = 0 To r - 1
            rs = 0
            For j = 0 To r - 1
                rs = rs + arr(i, j)
            Next j
            ListView2.Items.Add(rs)
        Next i

        Dim cl As Integer
        For i = 0 To r - 1
            cl = 0
            For j = 0 To r - 1
                cl = cl + arr(j, i)
            Next j
            ListView3.Items.Add(cl)
        Next i
    End Sub
End Class
