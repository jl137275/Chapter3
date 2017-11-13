Public Class Form1

    Private Sub btnCalculateMPG_Click(sender As Object, e As EventArgs) Handles btnCalculateMPG.Click
        Dim dblMPG As Double
        dblMPG = CDbl(txtGallonsOfGasInput.Text) / CDbl(txtNumberOfMilesInput.Text)
        lblMilesPerGallonTotal.Text = dblMPG

    End Sub
End Class
