Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblConvert.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblDesired.Click

    End Sub
    Dim amounts As New List(Of Double)
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim original, desired As Integer
        original = CInt(txtOriginal.Text)
        desired = CInt(txtDesired.Text)
        Dim originalAmount, amountToConvert As Double
        amountToConvert = CDbl(txtAmount.Text)
        originalAmount = amounts(original - 1) * amountToConvert
        Dim result As Double
        result = originalAmount / amounts(desired - 1)
        txtOutput.Text = FormatCurrency(result, 2)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim intValue As New List(Of Double)
        Dim i As Integer = 1
        For Each line As String In IO.File.ReadAllLines("Currencies.txt")
            Dim parts As String() = line.Split(","c)
            lstData.Items.Add(i.ToString + "." + parts(0))
            intValue.Add(parts(1))
            i += 1
        Next
        amounts = intValue

    End Sub

    Private Sub lstData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstData.SelectedIndexChanged

    End Sub
End Class
