<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblDayOfDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblNights = New System.Windows.Forms.Label()
        Me.lblNightlyCharge = New System.Windows.Forms.Label()
        Me.lblRoomService = New System.Windows.Forms.Label()
        Me.lblTelephone = New System.Windows.Forms.Label()
        Me.lblMisc = New System.Windows.Forms.Label()
        Me.lblDateInput = New System.Windows.Forms.Label()
        Me.lblTimeInput = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnCalculateCharges = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblRoomCharges = New System.Windows.Forms.Label()
        Me.lblAdditionalCharges = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblTotalCharges = New System.Windows.Forms.Label()
        Me.lblRoomChangeOutput = New System.Windows.Forms.Label()
        Me.lblAdditionalChargesOutput = New System.Windows.Forms.Label()
        Me.lblSubtotalOutput = New System.Windows.Forms.Label()
        Me.lblTaxOutput = New System.Windows.Forms.Label()
        Me.lblTotalChargesOutput = New System.Windows.Forms.Label()
        Me.txtNights = New System.Windows.Forms.TextBox()
        Me.txtNightlyCharge = New System.Windows.Forms.TextBox()
        Me.txtRoomService = New System.Windows.Forms.TextBox()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.txtMisc = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDayOfDate
        '
        Me.lblDayOfDate.AutoSize = True
        Me.lblDayOfDate.Location = New System.Drawing.Point(77, 91)
        Me.lblDayOfDate.Name = "lblDayOfDate"
        Me.lblDayOfDate.Size = New System.Drawing.Size(70, 13)
        Me.lblDayOfDate.TabIndex = 0
        Me.lblDayOfDate.Text = "Today's Date"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(95, 122)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(30, 13)
        Me.lblTime.TabIndex = 1
        Me.lblTime.Text = "Time"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNightlyCharge)
        Me.GroupBox1.Controls.Add(Me.lblNights)
        Me.GroupBox1.Controls.Add(Me.lblNightlyCharge)
        Me.GroupBox1.Controls.Add(Me.txtNights)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 173)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 107)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Room Information"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtRoomService)
        Me.GroupBox2.Controls.Add(Me.txtTelephone)
        Me.GroupBox2.Controls.Add(Me.txtMisc)
        Me.GroupBox2.Controls.Add(Me.lblMisc)
        Me.GroupBox2.Controls.Add(Me.lblRoomService)
        Me.GroupBox2.Controls.Add(Me.lblTelephone)
        Me.GroupBox2.Location = New System.Drawing.Point(234, 173)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 107)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Additional Charges"
        '
        'lblNights
        '
        Me.lblNights.AutoSize = True
        Me.lblNights.Location = New System.Drawing.Point(32, 30)
        Me.lblNights.Name = "lblNights"
        Me.lblNights.Size = New System.Drawing.Size(37, 13)
        Me.lblNights.TabIndex = 0
        Me.lblNights.Text = "Nights"
        '
        'lblNightlyCharge
        '
        Me.lblNightlyCharge.AutoSize = True
        Me.lblNightlyCharge.Location = New System.Drawing.Point(12, 77)
        Me.lblNightlyCharge.Name = "lblNightlyCharge"
        Me.lblNightlyCharge.Size = New System.Drawing.Size(76, 13)
        Me.lblNightlyCharge.TabIndex = 5
        Me.lblNightlyCharge.Text = "Nightly Charge"
        '
        'lblRoomService
        '
        Me.lblRoomService.AutoSize = True
        Me.lblRoomService.Location = New System.Drawing.Point(17, 30)
        Me.lblRoomService.Name = "lblRoomService"
        Me.lblRoomService.Size = New System.Drawing.Size(77, 13)
        Me.lblRoomService.TabIndex = 6
        Me.lblRoomService.Text = "Room Service:"
        '
        'lblTelephone
        '
        Me.lblTelephone.AutoSize = True
        Me.lblTelephone.Location = New System.Drawing.Point(17, 56)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(61, 13)
        Me.lblTelephone.TabIndex = 7
        Me.lblTelephone.Text = "Telephone:"
        '
        'lblMisc
        '
        Me.lblMisc.AutoSize = True
        Me.lblMisc.Location = New System.Drawing.Point(17, 84)
        Me.lblMisc.Name = "lblMisc"
        Me.lblMisc.Size = New System.Drawing.Size(32, 13)
        Me.lblMisc.TabIndex = 8
        Me.lblMisc.Text = "Misc:"
        '
        'lblDateInput
        '
        Me.lblDateInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDateInput.Location = New System.Drawing.Point(153, 90)
        Me.lblDateInput.Name = "lblDateInput"
        Me.lblDateInput.Size = New System.Drawing.Size(300, 23)
        Me.lblDateInput.TabIndex = 9
        '
        'lblTimeInput
        '
        Me.lblTimeInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTimeInput.Location = New System.Drawing.Point(153, 122)
        Me.lblTimeInput.Name = "lblTimeInput"
        Me.lblTimeInput.Size = New System.Drawing.Size(300, 23)
        Me.lblTimeInput.TabIndex = 10
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblTotalChargesOutput)
        Me.GroupBox3.Controls.Add(Me.lblTaxOutput)
        Me.GroupBox3.Controls.Add(Me.lblSubtotalOutput)
        Me.GroupBox3.Controls.Add(Me.lblAdditionalChargesOutput)
        Me.GroupBox3.Controls.Add(Me.lblRoomChangeOutput)
        Me.GroupBox3.Controls.Add(Me.lblTotalCharges)
        Me.GroupBox3.Controls.Add(Me.lblTax)
        Me.GroupBox3.Controls.Add(Me.lblSubtotal)
        Me.GroupBox3.Controls.Add(Me.lblAdditionalCharges)
        Me.GroupBox3.Controls.Add(Me.lblRoomCharges)
        Me.GroupBox3.Location = New System.Drawing.Point(47, 300)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(374, 161)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Total Charges"
        '
        'btnCalculateCharges
        '
        Me.btnCalculateCharges.Location = New System.Drawing.Point(78, 482)
        Me.btnCalculateCharges.Name = "btnCalculateCharges"
        Me.btnCalculateCharges.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculateCharges.TabIndex = 12
        Me.btnCalculateCharges.Text = "Calculate Charges"
        Me.btnCalculateCharges.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(196, 482)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(309, 482)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(139, 31)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(188, 25)
        Me.lblTitle.TabIndex = 15
        Me.lblTitle.Text = "Highlander Hotel"
        '
        'lblRoomCharges
        '
        Me.lblRoomCharges.AutoSize = True
        Me.lblRoomCharges.Location = New System.Drawing.Point(94, 16)
        Me.lblRoomCharges.Name = "lblRoomCharges"
        Me.lblRoomCharges.Size = New System.Drawing.Size(83, 13)
        Me.lblRoomCharges.TabIndex = 0
        Me.lblRoomCharges.Text = "Room Changes:"
        '
        'lblAdditionalCharges
        '
        Me.lblAdditionalCharges.AutoSize = True
        Me.lblAdditionalCharges.Location = New System.Drawing.Point(94, 41)
        Me.lblAdditionalCharges.Name = "lblAdditionalCharges"
        Me.lblAdditionalCharges.Size = New System.Drawing.Size(98, 13)
        Me.lblAdditionalCharges.TabIndex = 1
        Me.lblAdditionalCharges.Text = "Additional Charges:"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(103, 68)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(49, 13)
        Me.lblSubtotal.TabIndex = 2
        Me.lblSubtotal.Text = "Subtotal:"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(112, 102)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(28, 13)
        Me.lblTax.TabIndex = 3
        Me.lblTax.Text = "Tax:"
        '
        'lblTotalCharges
        '
        Me.lblTotalCharges.AutoSize = True
        Me.lblTotalCharges.Location = New System.Drawing.Point(94, 133)
        Me.lblTotalCharges.Name = "lblTotalCharges"
        Me.lblTotalCharges.Size = New System.Drawing.Size(76, 13)
        Me.lblTotalCharges.TabIndex = 4
        Me.lblTotalCharges.Text = "Total Charges:"
        '
        'lblRoomChangeOutput
        '
        Me.lblRoomChangeOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRoomChangeOutput.Location = New System.Drawing.Point(249, 16)
        Me.lblRoomChangeOutput.Name = "lblRoomChangeOutput"
        Me.lblRoomChangeOutput.Size = New System.Drawing.Size(100, 23)
        Me.lblRoomChangeOutput.TabIndex = 5
        '
        'lblAdditionalChargesOutput
        '
        Me.lblAdditionalChargesOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAdditionalChargesOutput.Location = New System.Drawing.Point(249, 41)
        Me.lblAdditionalChargesOutput.Name = "lblAdditionalChargesOutput"
        Me.lblAdditionalChargesOutput.Size = New System.Drawing.Size(100, 23)
        Me.lblAdditionalChargesOutput.TabIndex = 6
        '
        'lblSubtotalOutput
        '
        Me.lblSubtotalOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubtotalOutput.Location = New System.Drawing.Point(249, 68)
        Me.lblSubtotalOutput.Name = "lblSubtotalOutput"
        Me.lblSubtotalOutput.Size = New System.Drawing.Size(100, 23)
        Me.lblSubtotalOutput.TabIndex = 7
        '
        'lblTaxOutput
        '
        Me.lblTaxOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTaxOutput.Location = New System.Drawing.Point(249, 102)
        Me.lblTaxOutput.Name = "lblTaxOutput"
        Me.lblTaxOutput.Size = New System.Drawing.Size(100, 23)
        Me.lblTaxOutput.TabIndex = 8
        '
        'lblTotalChargesOutput
        '
        Me.lblTotalChargesOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalChargesOutput.Location = New System.Drawing.Point(249, 133)
        Me.lblTotalChargesOutput.Name = "lblTotalChargesOutput"
        Me.lblTotalChargesOutput.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalChargesOutput.TabIndex = 9
        '
        'txtNights
        '
        Me.txtNights.Location = New System.Drawing.Point(94, 27)
        Me.txtNights.Name = "txtNights"
        Me.txtNights.Size = New System.Drawing.Size(100, 20)
        Me.txtNights.TabIndex = 16
        '
        'txtNightlyCharge
        '
        Me.txtNightlyCharge.Location = New System.Drawing.Point(94, 77)
        Me.txtNightlyCharge.Name = "txtNightlyCharge"
        Me.txtNightlyCharge.Size = New System.Drawing.Size(100, 20)
        Me.txtNightlyCharge.TabIndex = 17
        '
        'txtRoomService
        '
        Me.txtRoomService.Location = New System.Drawing.Point(100, 30)
        Me.txtRoomService.Name = "txtRoomService"
        Me.txtRoomService.Size = New System.Drawing.Size(100, 20)
        Me.txtRoomService.TabIndex = 18
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(100, 55)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(100, 20)
        Me.txtTelephone.TabIndex = 19
        '
        'txtMisc
        '
        Me.txtMisc.Location = New System.Drawing.Point(100, 81)
        Me.txtMisc.Name = "txtMisc"
        Me.txtMisc.Size = New System.Drawing.Size(100, 20)
        Me.txtMisc.TabIndex = 20
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 517)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculateCharges)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lblDateInput)
        Me.Controls.Add(Me.lblTimeInput)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDayOfDate)
        Me.Name = "Form1"
        Me.Text = "Room Charge Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDayOfDate As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNights As System.Windows.Forms.Label
    Friend WithEvents lblNightlyCharge As System.Windows.Forms.Label
    Friend WithEvents lblMisc As System.Windows.Forms.Label
    Friend WithEvents lblRoomService As System.Windows.Forms.Label
    Friend WithEvents lblTelephone As System.Windows.Forms.Label
    Friend WithEvents lblDateInput As System.Windows.Forms.Label
    Friend WithEvents lblTimeInput As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCalculateCharges As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblTotalChargesOutput As System.Windows.Forms.Label
    Friend WithEvents lblTaxOutput As System.Windows.Forms.Label
    Friend WithEvents lblSubtotalOutput As System.Windows.Forms.Label
    Friend WithEvents lblAdditionalChargesOutput As System.Windows.Forms.Label
    Friend WithEvents lblRoomChangeOutput As System.Windows.Forms.Label
    Friend WithEvents lblTotalCharges As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents lblAdditionalCharges As System.Windows.Forms.Label
    Friend WithEvents lblRoomCharges As System.Windows.Forms.Label
    Friend WithEvents txtNights As System.Windows.Forms.TextBox
    Friend WithEvents txtNightlyCharge As System.Windows.Forms.TextBox
    Friend WithEvents txtRoomService As System.Windows.Forms.TextBox
    Friend WithEvents txtTelephone As System.Windows.Forms.TextBox
    Friend WithEvents txtMisc As System.Windows.Forms.TextBox

End Class
