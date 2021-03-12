﻿Public Class Form2
    Dim score As Integer

    Private Sub Timer1_Tick(ByVal sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        PictureBox1.Top += 10
        'thePlayerSprite.Top -= 10
        PictureBox3.Top += 10
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        If PictureBox1.Location.Y < -60 Or thePlayerSprite.Location.Y < -60 Or PictureBox3.Location.Y < -60 Then
            Me.Dispose()
            MsgBox("Game Over")
            Form1.Show()
        End If
        Label1.Text = score
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        score = score + 1
        Label1.Text = score
        PictureBox1.Location = New Point(90, 400)

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        score = score + 1
        Label1.Text = score
        PictureBox3.Location = New Point(500, 400)
    End Sub

    'the player:
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles thePlayerSprite.Click
        score = score + 1
        Label1.Text = score
        thePlayerSprite.Location = New Point(200, 700)
    End Sub

    Private Sub Form2_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp

        'move player to the left
        If e.KeyCode = Keys.Left Then
            thePlayerSprite.Left += 10
            'move player to the right
        ElseIf e.KeyCode = Keys.Right Then
            thePlayerSprite.Left += 10
        End If

    End Sub
End Class