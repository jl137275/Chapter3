Public Class Form1



    Private Sub btnCalculateRevenue_Click(sender As Object, e As EventArgs) Handles btnCalculateAverage.Click
        Dim dblScore1, dblScore2, dblScore3, dblAverage

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
