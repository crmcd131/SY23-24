Public Class Form1
    Private Money As Integer = 100
    Private SpinCost As Integer = 50

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateMoneyLabel()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CanAffordSpin() Then
            DeductSpinCost()
            Reelcontrol1.spin()
            Reelcontrol2.spin()
            Reelcontrol3.spin()
        Else
            LabelResult.Text = "You don't have enough money to spin!"
        End If
    End Sub

    Private Function CanAffordSpin() As Boolean
        Return Money >= SpinCost
    End Function

    Private Sub DeductSpinCost()
        Money -= SpinCost
        UpdateMoneyLabel()
    End Sub

    Public Sub UpdateLabels()
        Label1.Text = Reelcontrol1.ItemValue
        Label2.Text = Reelcontrol2.ItemValue
        Label3.Text = Reelcontrol3.ItemValue
        CheckWin()
    End Sub

    Private Sub CheckWin()
        If Reelcontrol1.ItemValue = Reelcontrol2.ItemValue AndAlso Reelcontrol2.ItemValue = Reelcontrol3.ItemValue Then
            Money += 100
            LabelResult.Text = "You won!"
            UpdateMoneyLabel()
        Else
            LabelResult.Text = "You lost!"
        End If
    End Sub

    Private Sub UpdateMoneyLabel()
        LabelMoney.Text = "Money: " & Money.ToString()
    End Sub

    Private Sub ButtonAddMoney_Click(sender As Object, e As EventArgs) Handles ButtonAddMoney.Click
        Money += 50
        UpdateMoneyLabel()
    End Sub
End Class