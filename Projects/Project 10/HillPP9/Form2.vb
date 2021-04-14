Public Class Form2
    Dim teamNumber As Integer = 0

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTeamName.Select()
        Text = "Bowling Match Scores for Team #"
        Text += (teamNumber).ToString()

    End Sub

    Private Sub btnRecordScores_Click(sender As Object, e As EventArgs) Handles btnRecordScores.Click
        Form1.TEAM_NAMES(teamNumber) = txtTeamName.Text
        For i As Integer = 0 To 3
            For j As Integer = 0 To 2
                Form1.SCORES(teamNumber, i, j) = Convert.ToInt32(CType(Controls.Find($"txtB{i}G{j}", False)(0), TextBox).Text)
            Next
        Next
        If teamNumber = 3 Then
            Close()
        Else
            ClearForm()
            teamNumber += 1
        End If
    End Sub
    Private Sub ClearForm()
        txtTeamName.Clear()
        For i As Integer = 0 To 3
            For j As Integer = 0 To 2
                CType(Controls.Find($"txtB{i}G{j}", False)(0), TextBox).Clear()
            Next
        Next
        Text = "Bowling Match Scores for Team #"
        Text += (teamNumber + 1).ToString()
    End Sub
End Class
