Public Class Form1





    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDateInput.Text = Now.ToString("D")
        lblTimeInput.Text = Now.ToString("T")
    End Sub

    Private Sub btnCalculateCharges_Click(sender As Object, e As EventArgs) Handles btnCalculateCharges.Click
        Dim decRoomCharges As Decimal
        Dim decAddCharges As Decimal
        Dim decSubtotal As Decimal
        Dim decTax As Decimal
        Dim decTotal As Decimal
        Const decTAX_RATE As Decimal = 0.08D

        Try
            decRoomCharges = CDec(txtNights.Text) * CDec(txtNightlyCharge.Text)
            lblRoomCharges.Text = decRoomCharges.ToString("c")

            decAddCharges = CDec(txtRoomService.Text) +  CDec(txtTelephone.Text) +  CDec(txtMisc.Text)
            lblAdditionalChargesOutput.Text = decAddCharges.ToString("c")

            decSubtotal = decRoomCharges + decAddCharges
            lblSubtotalOutput.Text = decSubtotal.ToString("c")

            decTax = decSubtotal * decTAX_RATE
            lblTax.Text = decTax.ToString("c")

            decTotal = decSubtotal + decTax
            lblTotalChargesOutput.Text = decTotal.ToString("c")
        Catch
            MessageBox.Show("All input must be valid numeric values.")
        End Try




    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNights.Clear()
        txtNightlyCharge.Clear()
        txtRoomService.Clear()
        txtTelephone.Clear()
        txtMisc.Clear()

        lblRoomChangeOutput.Text = String.Empty
        lblAdditionalChargesOutput.Text = String.Empty
        lblSubtotalOutput.Text = String.Empty
        lblTaxOutput.Text = String.Empty
        lblTotalChargesOutput.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
