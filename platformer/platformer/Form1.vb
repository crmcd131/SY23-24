Imports System.Diagnostics.Eventing.Reader

Public Class frm2DPlatformer
    Dim moveSpeed As Integer = 15
    Dim isJumping As Boolean
    Dim coin As Integer = 2
    Dim coinloss As Integer = -1

    Private Sub frm2DPlatformer_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Start()
            Case Keys.Left
                tmrLeft.Start()
            Case Keys.Up
                tmrUp.Start()
                isJumping = True
        End Select
    End Sub

    Private Sub tmrRight_Tick(sender As System.Object, e As System.EventArgs) Handles tmrRight.Tick
        picPlayer.Left += moveSpeed
    End Sub

    Private Sub frm2DPlatformer_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Stop()
            Case Keys.Left
                tmrLeft.Stop()
            Case Keys.Up
                tmrUp.Stop()
                isJumping = False
        End Select
    End Sub

    Private Sub tmrLeft_Tick(sender As System.Object, e As System.EventArgs) Handles tmrLeft.Tick
        picPlayer.Left -= moveSpeed
    End Sub

    Private Sub tmrUp_Tick(sender As System.Object, e As System.EventArgs) Handles tmrUp.Tick
        picPlayer.Top -= moveSpeed
    End Sub

    Private Sub frm2DPlatformer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        tmrGameLogic.Start()
    End Sub

    Private Sub tmrGameLogic_Tick(sender As System.Object, e As System.EventArgs) Handles tmrGameLogic.Tick
        If picPlayer.Bounds.IntersectsWith(picGround.Bounds) Then
            tmrGravity.Stop()
        Else
            If isJumping = False Then
                tmrGravity.Start()
            End If
        End If

        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "bound" Then
                    If picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        tmrGravity.Stop()
                    End If
                End If
                If b.Tag = "coin" Then
                    If b.Visible And picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        b.Visible = False
                        coin += 1
                        ScoreLabel.Text = coin
                    End If
                End If
                If b.Tag = "gameover" And picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                    MsgBox("Game Over")
                    coin = 0
                    ScoreLabel.Text = coin
                    tmrGameLogic.Stop()
                End If
            End If
            If b.Tag = "coinloss" Then
                If b.Visible And picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                    b.Visible = False
                    coin -= 1
                    ScoreLabel.Text = coinloss
                End If
            End If

        Next

    End Sub

    Private Sub tmrGravity_Tick(sender As System.Object, e As System.EventArgs) Handles tmrGravity.Tick
        picPlayer.Top += moveSpeed
    End Sub

End Class



