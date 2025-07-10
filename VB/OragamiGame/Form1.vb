Public Class Form1
    Private Sub OrigamiButton_Click(sender As Object, e As EventArgs) Handles OrigamiButton.Click

        Label1.Text = Val(Label1.Text) + 1
        If Label1.Text = "4" Then
            Label1.Text = "3"
        End If
        My.Settings.TurnCount = Label1.Text


        If OrigamiButton.Text = "1" Then
            MsgBox("Counted 1 open.", MsgBoxStyle.OkOnly, "Origami Game")
            OrigamiButton.Text = "5"
            OrigamiButton2.Text = "6"
            OrigamiButton3.Text = "7"
            OrigamiButton4.Text = "8"
        ElseIf OrigamiButton.Text = "5" Then
            MsgBox("Counted 5 opens.", MsgBoxStyle.OkOnly, "Origami Game")
            OrigamiButton.Text = "Red"
            OrigamiButton2.Text = "Green"
            OrigamiButton3.Text = "Blue"
            OrigamiButton4.Text = "Yellow"
        End If

        If Label1.Text = 3 & OrigamiButton.Text = "5" Then
            MsgBox("Result: You're a cutie~ <3", MsgBoxStyle.OkOnly, "Origami Game")
        End If

        If Label1.Text = "3" & OrigamiButton.Text = "Red" Then
            MsgBox("Counted 3 opens.", MsgBoxStyle.OkOnly, "Origami Game")

        End If
    End Sub



    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("Origami Game" + Application.ProductVersion & vbNewLine & vbNewLine & "Made by WindowsLogic Productions", MsgBoxStyle.OkOnly, "About Origami Game")
    End Sub





    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        MsgBox("Reset all counted opens.", MsgBoxStyle.OkOnly, "Origami Game")
        OrigamiButton.Text = "1"
        OrigamiButton2.Text = "4"
        OrigamiButton3.Text = "2"
        OrigamiButton4.Text = "3"
    End Sub

#Region "First Open"
    Private Sub OrigamiButton3_Click(sender As Object, e As EventArgs) Handles OrigamiButton3.Click
        If OrigamiButton3.Text = "2" Then
            MsgBox("Counted 2 opens.", MsgBoxStyle.OkOnly, "Origami Game")
            OrigamiButton.Text = "Red"
            OrigamiButton2.Text = "Green"
            OrigamiButton3.Text = "Blue"
            OrigamiButton4.Text = "Yellow"
        End If
    End Sub

    Private Sub OrigamiButton4_Click(sender As Object, e As EventArgs) Handles OrigamiButton4.Click
        If OrigamiButton4.Text = "3" Then
            MsgBox("Counted 3 opens.", MsgBoxStyle.OkOnly, "Origami Game")
            OrigamiButton.Text = "5"
            OrigamiButton2.Text = "6"
            OrigamiButton3.Text = "7"
            OrigamiButton4.Text = "8"
        End If
    End Sub

    Private Sub OrigamiButton2_Click(sender As Object, e As EventArgs) Handles OrigamiButton2.Click
        If OrigamiButton2.Text = "4" Then
            MsgBox("Counted 4 opens.", MsgBoxStyle.OkOnly, "Origami Game")
            OrigamiButton.Text = "Red"
            OrigamiButton2.Text = "Green"
            OrigamiButton3.Text = "Blue"
            OrigamiButton4.Text = "Yellow"
        End If
    End Sub
#End Region
End Class
