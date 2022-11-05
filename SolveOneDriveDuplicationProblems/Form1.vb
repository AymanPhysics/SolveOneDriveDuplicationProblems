Public Class Form1

    Dim path As String = "D:\OneDrive"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        Dim ar() As String = IO.Directory.GetFiles(path, "*-Physics-PC*.*", IO.SearchOption.AllDirectories)
        For Each f In ar
            ListBox1.Items.Add(f)
        Next
        MessageBox.Show("Done")
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ar() As String = IO.Directory.GetFiles(path, "*-Physics-PC*.*", IO.SearchOption.AllDirectories)
        For Each f In ar
            IO.File.Delete(f.Replace("-Physics-PC", ""))
            IO.File.Move(f, f.Replace("-Physics-PC", ""))
        Next
        MessageBox.Show("Done")
    End Sub

End Class
