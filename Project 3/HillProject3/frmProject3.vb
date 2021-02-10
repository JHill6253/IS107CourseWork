Public Class frmName
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
        'First we need to declare the variables we will be using 
        Dim customerName As String
        Dim labor, parts, total, laborCost, partsCost As Double
        'grabbbing values from txt
        customerName = txtCustomer.Text
        labor = CDbl(txtLabor.Text)
        parts = CDbl(txtParts.Text)
        'calculation of costs
        laborCost = labor * 35
        partsCost = parts + parts * 0.05
        total = laborCost + partsCost

        'Display results 
        lstOutput.Items.Clear()
        lstOutput.Items.Add("Customer     " + customerName)
        lstOutput.Items.Add("Labor Cost     " + FormatCurrency(laborCost))
        lstOutput.Items.Add("Parts Cost     " + FormatCurrency(partsCost))
        lstOutput.Items.Add("Total     " + FormatCurrency(total))

    End Sub

    Private Sub lblParts_Click(sender As Object, e As EventArgs) Handles lblParts.Click

    End Sub
End Class
