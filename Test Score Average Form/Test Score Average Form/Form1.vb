﻿Public Class Form1



    Private Sub btnCalculateRevenue_Click(sender As Object, e As EventArgs) Handles btnCalculateRevenue.Click
        Dim total, average As Double
        total = CDbl(txtTestScore1.Text) + CDbl(txtTestScore2.Text) + CDbl(txtTestScore3.Text) + CDbl(txtTestScore4.Text) + CDbl(txtTestScore5.Text)
        average = total / 5
        lblAverageResult.Text = average

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTestScore1.Text = ""
        txtTestScore2.Text = ""
        txtTestScore3.Text = ""
        txtTestScore4.Text = ""
        txtTestScore5.Text = ""
        lblAverageResult.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
