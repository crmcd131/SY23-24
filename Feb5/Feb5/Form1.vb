Public Class Form1
    Dim c As New Clicker
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        c.click()
        TextBox1.Text = c.count
    End Sub
End Class
