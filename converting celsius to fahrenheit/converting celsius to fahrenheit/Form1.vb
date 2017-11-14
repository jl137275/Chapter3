Public Class Form1

    Private Sub btnShowCalculation_Click(sender As Object, e As EventArgs) Handles btnShowCalculation.Click
        Dim dblCelsius As Double
        Dim dblFahrenheit As Double

        dblCelsius = CDbl(txtCelsius.Text)
        dblFahrenheit = 1.8 * dblCelsius + 32
        txtFahrenheit.Text = dblFahrenheit.ToString("n")

    End Sub
End Class
