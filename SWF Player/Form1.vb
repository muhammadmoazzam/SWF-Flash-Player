Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        TextBox1.Text = OpenFileDialog1.FileName
        'After you input a file name and you have selected a directory and click ok, we snap out the
        'Filename to work with
        Dim fullPath As String = OpenFileDialog1.FileName

        'Find the length of the full string
        Dim FullStringLength As Integer = fullPath.Length

        'Find out how many characters you will have to remove
        Dim FileNameStart As Integer = fullPath.LastIndexOf("\") + 1

        'Now we need to know how long the file name is so we can tell the sub string where to stop
        Dim FileNameStop As Integer = FullStringLength - FileNameStart

        'Now we know how long the string is, and how long the filename portion of it is. We also know
        'where to start the substring and where to end it

        Dim fileName As String = fullPath.Substring(FileNameStart, FileNameStop)
        TextBox2.Text = fileName
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Refresh()
        If TextBox1.Text = "" Then
            MsgBox("Please Browse SWF File First...")
        Else
            Me.Hide()
            Form2.Show()
            Form2.Text = TextBox2.Text
            Form2.WebBrowser1.Refresh()
            Form2.WebBrowser1.Navigate(TextBox1.Text)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Hide()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        'After you input a file name and you have selected a directory and click ok, we snap out the
        'Filename to work with
        Dim fullPath As String = OpenFileDialog1.FileName

        'Find the length of the full string
        Dim FullStringLength As Integer = fullPath.Length

        'Find out how many characters you will have to remove
        Dim FileNameStart As Integer = fullPath.LastIndexOf("\") + 1

        'Now we need to know how long the file name is so we can tell the sub string where to stop
        Dim FileNameStop As Integer = FullStringLength - FileNameStart

        'Now we know how long the string is, and how long the filename portion of it is. We also know
        'where to start the substring and where to end it

        Dim fileName As String = fullPath.Substring(FileNameStart, FileNameStop)
        TextBox2.Text = fileName
    End Sub
End Class
