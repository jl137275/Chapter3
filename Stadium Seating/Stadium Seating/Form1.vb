Public Class Form1

    Private Sub btnCalculateRevenue_Click(sender As Object, e As EventArgs) Handles btnCalculateRevenue.Click
        Dim dblClassA, dblClassB, dblClassC, total As Double
        dblClassA = CDbl(txtClassA.Text) * 15
        dblClassB = CDbl(txtClassB.Text) * 12
        dblClassC = CDbl(txtClassC.Text) * 9

        lblClassA.Text = dblClassA
        lblClassB.Text = dblClassB
        lblClassC.Text = dblClassC
        total = dblClassA + dblClassB + dblClassC
        lblTotalRevenue.Text = total.ToString("c")
        lblClassA.Text = dblClassA.ToString("c")
        lblClassB.Text = dblClassB.ToString("c")
        lblClassC.Text = dblClassC.ToString("c")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblClassA.Text = ""
        lblClassB.Text = ""
        lblClassC.Text = ""
        txtClassA.Text = ""
        txtClassB.Text = ""
        txtClassC.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
