Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblAddress.Click

    End Sub

    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click
        Dim num As Double = 10
        Do While num > 1
            lstOutput.Items.Add(num)
            num = num - 3
        Loop

    End Sub
    Public Sub InputData(ByRef name() As String, ByRef address As String, ByRef city As String, ByRef chairs As Integer, ByRef sofas As Integer)
        name = txtCustomerName.Text.Split(","c)
        address = txtAddress.Text
        city = txtCity.Text
        chairs = CInt(txtChairs.Text)
        sofas = CInt(txtSofas.Text)
    End Sub
    Public Sub ProcessData(ByVal name() As String, ByRef lastName As String, ByRef firstname As String, ByVal city As String, ByRef invoiceID As String)
        lastName = name(0)
        firstname = name(1)
        Dim length = city.Length
        invoiceID = lastName.Substring(0, 2).ToUpper
        invoiceID += city.Substring(length - 4, 4)
    End Sub

    Public Sub CalculateCost(ByVal chairs As Integer, ByVal sofas As Integer, ByRef cost As Double, ByRef salesTax As Double, ByRef TotalCost As Double)
        Dim chairCost As Double = 350
        Dim sofaCost As Double = 925
        cost = (chairs * chairCost) + (sofas * sofaCost)
        salesTax = cost * 0.05
        TotalCost = cost + salesTax
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        txtCustomerName.Clear()
        txtAddress.Clear()
        txtCity.Clear()
        txtChairs.Clear()
        txtSofas.Clear()
        lstOutput.Items.Clear()
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub lblName_Click(sender As Object, e As EventArgs) Handles lblName.Click

    End Sub
End Class
