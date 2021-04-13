Public Class Form1
    Public Shared SCORES(4, 3, 2) As Integer
    Public Shared TEAM_NAMES(4) As String 
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load 
        Dim frm As New Form2 
        frm.Show() 
    End Sub
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim teamScores(4) As Integer
        Dim winTeam As Integer = 0
        Dim winScore As Integer = 0
        Dim perfectFlag As Boolean = False
        Dim highScore As Integer = 0
        Dim highScoreBowler As Integer
        Dim highScoreGame As Integer
        For i = 0 To 3
            For j = 0 To 3
                For k = 0 To 2
                    teamScores(i) += SCORES(i, j, k)
                    If SCORES(i, j, k) = 300 Then
                        perfectFlag = True
                    End If
                    If SCORES(i, j, k) > highScore Then
                        highScore = SCORES(i, j, k)
                        highScoreBowler = j
                        highScoreGame = k
                    End If
                Next
            Next
            If teamScores(i) > winScore Then
                winScore = teamScores(i)
                winTeam = i
            End If
        Next
        txtWinningTeamName.Text = TEAM_NAMES(winTeam)
        txtTotalScore.Text = winScore
        If perfectFlag = True Then
            lstHighestScore.Items.Add($"High games score was by bowler {highScoreBowler + 1} from the {TEAM_NAMES(winTeam)}")
            lstHighestScore.Items.Add($"Ths high score was 300 in game {highScoreGame + 1}")
            lstHighestScore.Items.Add("Congratulations on bowling a perfect game!")
        Else
            lstHighestScore.Items.Add($"High games score was by bowler {highScoreBowler + 1 } from the {TEAM_NAMES(winTeam)}")
            lstHighestScore.Items.Add($"Ths high score was {highScore} in game {highScoreGame + 1 }")
        End If

    End Sub
End Class

