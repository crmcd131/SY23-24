Public Class Form1
    Dim WithEvents cs As New coinslot
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cs.insertdollars()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cs.insertquarter()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cs.insertdimes()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cs.insertnickels()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cs.coinreturn()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub cs_coinreturnevent(d As Integer, q As Integer, di As Integer, n As Integer) Handles cs.coinreturnevent
        If d > 0 Then
            dollarcoin.Visible = True
        Else
            dollarcoin.Visible = False
        End If
        If q > 0 Then
            quartercoin.Visible = True
        Else
            quartercoin.Visible = False
        End If
        If di > 0 Then
            dimecoin.Visible = True
        Else
            dimecoin.Visible = False
        End If
        If n > 0 Then
            nickelcoin.Visible = True
        Else
            nickelcoin.Visible = False
        End If
    End Sub
End Class
