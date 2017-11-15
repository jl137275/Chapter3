﻿Public Class Form1

    Private Sub btnShowCalculation_Click(sender As Object, e As EventArgs) Handles btnShowCalculation.Click
        Dim dblCelsius As Double
        Dim dblFahrenheit As Double

        dblCelsius = CDbl(txtCelsius.Text)
        dblFahrenheit = 1.8 * dblCelsius + 32
        txtFahrenheit.Text = dblFahrenheit.ToString("n")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCelsius.Text = ""
        txtFahrenheit.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
