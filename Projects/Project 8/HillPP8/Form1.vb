Public Class frmBaseball

    Dim baseballData As XElement
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        baseballData = XElement.Load("Baseball.xml")
        Dim data = From player In
                       baseballData.Descendants("player")
                   Let team = player.<team>.Value
                   Order By team Ascending
                   Select team
                   Distinct
        lstTeams.DataSource = data.ToList
    End Sub

    Private Sub lstTeams_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTeams.SelectedIndexChanged
        Dim data = From player In
                       baseballData.Descendants("player")
                   Let name = player.<name>.Value
                   Let team = player.<team>.Value
                   Let atBats = CDbl(player.<atBats>.Value)
                   Let hits = CDbl(player.<hits>.Value)
                   Let avg = hits / atBats
                   Where team = lstTeams.Text And
                       IsAboveTheAverage(name, team, avg) = True
                   Let frmtAvg = FormatNumber(avg, 3)
                   Order By avg Descending
                   Select name, frmtAvg

        dgvDisplay.DataSource = data.ToList
        dgvDisplay.CurrentCell = Nothing
        dgvDisplay.Columns("name").HeaderText = "player"
        dgvDisplay.Columns("frmtAvg").HeaderText = "Batting Average"

    End Sub

    Function IsAboveTheAverage(ByVal playerName As String, ByVal playerTeam As String, ByVal playerAvg As Double) As Boolean
        Dim query = From player In baseballData.Descendants("player")
                    Let teamateName = player.<name>.Value
                    Let teamateTeam = player.<team>.Value
                    Let atBats = CDbl(player.<atBats>.Value)
                    Let hits = CDbl(player.<hits>.Value)
                    Let teamateAvg = hits / atBats
                    Where teamateTeam = playerTeam And teamateTeam IsNot playerName
                    Select teamateAvg

        Dim teamatesAvg As Double = query.Sum / query.Count
        If playerAvg > teamatesAvg Then
            Return True
        End If
        Return False
    End Function
End Class
