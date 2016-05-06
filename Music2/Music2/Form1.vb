Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Music_ArchiveDataSet1.Album' table. You can move, or remove it, as needed.
        Me.AlbumTableAdapter.Fill(Me.Music_ArchiveDataSet.Album)
        With DataGridView1
            .ClearSelection()
            .ReadOnly = True
            .MultiSelect = False
        End With
        Dim colors() As String = [Enum].GetNames(GetType(KnownColor))
        ComboBox1.Items.AddRange(colors)
        ComboBox2.Items.AddRange(colors)
        Me.reset()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AlbumBindingSource.MovePrevious()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AlbumBindingSource.AddNew()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AlbumBindingSource.MoveNext()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        On Error GoTo SaveErr
        AlbumBindingSource.EndEdit()
        AlbumTableAdapter.Update(Music_ArchiveDataSet.Album)
        MessageBox.Show("Your record is saved!!")
ErrEx:
        Exit Sub
SaveErr:
        MsgBox("Error Number " & Err.Number & vbNewLine & _
               "Error Description" & Err.Description, MsgBoxStyle.Critical, _
               "Reset Error!")
        Resume ErrEx
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If MessageBox.Show("Are you sure?", "Delete Record", MessageBoxButtons.YesNo, _
                           MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = _
                       Windows.Forms.DialogResult.Yes Then
            AlbumBindingSource.RemoveCurrent()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim msg As String = "Do you want to exit?"
        Dim title As String = "Exit Application"
        If MessageBox.Show(msg, title, MessageBoxButtons.YesNo, _
                           MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = _
                       Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox1.BackColor = Color.FromName(ComboBox1.SelectedItem)
        TextBox6.Select()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ComboBox2.BackColor = Color.FromName(ComboBox2.SelectedItem)
        TextBox6.Select()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        On Error GoTo ErrRe
        TextBox6.Select()
        AlbumBindingSource.Filter = Nothing
        With DataGridView1
            .ClearSelection()
            .ReadOnly = True
            .MultiSelect = False
            .DataSource = AlbumBindingSource
        End With
        Me.reset()
ErrEx:
        Exit Sub
ErrRe:
        MsgBox("Error Number" & Err.Number & vbNewLine & _
               "Error Description" & Err.Description, MsgBoxStyle.Critical, _
               "Reset Error!")
        Resume ErrEx
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        On Error GoTo SearchErr
        If TextBox6.Text = "" Then
            Call notFound()
            Exit Sub
        Else
            Dim cantFind As String = TextBox6.Text
            Me.dgvFill()
            AlbumBindingSource.Filter = "(Convert(ID,'System.String') LIKE '" & TextBox6.Text & "')" & _
                "OR (Title LIKE '" & TextBox6.Text & "') OR (Album LIKE '" & TextBox6.Text & "')" & _
                "OR (Artist LIKE '" & TextBox6.Text & "') OR (Genre LIKE '" & TextBox6.Text & "')" & _
                "OR (Convert(Year_Of_Release,'System.String') LIKE '" & TextBox6.Text & "')"
            If AlbumBindingSource.Count <> 0 Then
                With DataGridView1
                    .DataSource = AlbumBindingSource
                End With
            Else
                Me.notFound()
                MsgBox("-->" & cantFind & vbNewLine & _
                       "The item you wish to search is not found!!", _
                       MsgBoxStyle.Information, "Hi")
                AlbumBindingSource.Filter = Nothing
                With DataGridView1
                    .ClearSelection()
                    .ReadOnly = True
                    .MultiSelect = False
                    .DataSource = AlbumBindingSource
                End With
            End If
        End If
ErrExit:
        Exit Sub
SearchErr:
        MsgBox("Error Number: " & Err.Number & vbNewLine & _
               "Error Description: " & Err.Description & "Error line:" & Err.Erl, MsgBoxStyle.Critical, _
               "Reset Error")
        Resume ErrExit
    End Sub
    Private Sub reset()
        Dim txts As TextBox = TextBox6
        With txts
            .Text = ""
            .Select()
            .BackColor = Color.LightCyan
        End With
        ComboBox1.SelectedItem = "White"
        ComboBox2.SelectedItem = "MistyRose"
        ComboBox1.BackColor = Color.LightCyan
        ComboBox2.BackColor = Color.LightCyan
        If DataGridView1.DataSource Is Nothing Then
            Exit Sub
        End If
        Dim dgv1 As DataGridView = DataGridView1
        With dgv1
            .RowsDefaultCellStyle.BackColor = Color.FromName(ComboBox1.SelectedItem)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromName(ComboBox2.SelectedItem)
        End With
    End Sub
    Private Sub dgvFill()
        TextBox6.BackColor = Color.LightBlue
        If DataGridView1.DataSource Is Nothing Then
            Exit Sub
        End If
        Dim myDGV1 As DataGridView = DataGridView1
        With myDGV1
            .RowsDefaultCellStyle.BackColor = Color.FromName(ComboBox1.SelectedItem)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromName(ComboBox2.SelectedItem)
        End With
    End Sub
    Private Sub notFound()
        Dim txtS As TextBox = TextBox6
        With txtS
            .BackColor = Color.White
            .Select()
            .SelectAll()
        End With
        If DataGridView1.DataSource Is Nothing Then
            Exit Sub
        End If
        Dim dgv As DataGridView = DataGridView1
        With dgv
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White
        End With
    End Sub
End Class
