Public Class Form1

    Private Sub btnCalculateTax_Click(sender As Object, e As EventArgs) Handles btnCalculateTax.Click
        Dim propertyValue, Sixtypercentvalue, taxvalue As Double
        Const TAX_RATE As Double = 0.64

        Try
            propertyValue = txtValueProperty.Text()
            Sixtypercentvalue = propertyValue * 0.6
            taxvalue = (Sixtypercentvalue / 100) * TAX_RATE
            lblAssessmentandTax.Text = taxvalue.ToString("c")
        Catch
            MessageBox.Show("Error please enter values")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtValueProperty.Text = ""
        lblAssessmentandTax.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
