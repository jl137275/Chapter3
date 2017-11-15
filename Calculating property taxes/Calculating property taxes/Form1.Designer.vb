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
        Me.lblValuePropertyTitle = New System.Windows.Forms.Label()
        Me.lblAssessmentTaxTitle = New System.Windows.Forms.Label()
        Me.lblAssessmentandTax = New System.Windows.Forms.Label()
        Me.txtValueProperty = New System.Windows.Forms.TextBox()
        Me.btnCalculateTax = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblValuePropertyTitle
        '
        Me.lblValuePropertyTitle.AutoSize = True
        Me.lblValuePropertyTitle.Location = New System.Drawing.Point(3, 60)
        Me.lblValuePropertyTitle.Name = "lblValuePropertyTitle"
        Me.lblValuePropertyTitle.Size = New System.Drawing.Size(161, 13)
        Me.lblValuePropertyTitle.TabIndex = 0
        Me.lblValuePropertyTitle.Text = "Enter actual value property here:"
        '
        'lblAssessmentTaxTitle
        '
        Me.lblAssessmentTaxTitle.AutoSize = True
        Me.lblAssessmentTaxTitle.Location = New System.Drawing.Point(12, 138)
        Me.lblAssessmentTaxTitle.Name = "lblAssessmentTaxTitle"
        Me.lblAssessmentTaxTitle.Size = New System.Drawing.Size(108, 13)
        Me.lblAssessmentTaxTitle.TabIndex = 1
        Me.lblAssessmentTaxTitle.Text = "Assessment and Tax:"
        '
        'lblAssessmentandTax
        '
        Me.lblAssessmentandTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAssessmentandTax.Location = New System.Drawing.Point(172, 137)
        Me.lblAssessmentandTax.Name = "lblAssessmentandTax"
        Me.lblAssessmentandTax.Size = New System.Drawing.Size(100, 23)
        Me.lblAssessmentandTax.TabIndex = 2
        '
        'txtValueProperty
        '
        Me.txtValueProperty.Location = New System.Drawing.Point(172, 60)
        Me.txtValueProperty.Name = "txtValueProperty"
        Me.txtValueProperty.Size = New System.Drawing.Size(100, 20)
        Me.txtValueProperty.TabIndex = 3
        '
        'btnCalculateTax
        '
        Me.btnCalculateTax.Location = New System.Drawing.Point(6, 215)
        Me.btnCalculateTax.Name = "btnCalculateTax"
        Me.btnCalculateTax.Size = New System.Drawing.Size(75, 35)
        Me.btnCalculateTax.TabIndex = 4
        Me.btnCalculateTax.Text = "Calculate Tax"
        Me.btnCalculateTax.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(105, 215)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 35)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(197, 215)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 35)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculateTax)
        Me.Controls.Add(Me.txtValueProperty)
        Me.Controls.Add(Me.lblAssessmentandTax)
        Me.Controls.Add(Me.lblAssessmentTaxTitle)
        Me.Controls.Add(Me.lblValuePropertyTitle)
        Me.Name = "Form1"
        Me.Text = "Property Taxes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblValuePropertyTitle As System.Windows.Forms.Label
    Friend WithEvents lblAssessmentTaxTitle As System.Windows.Forms.Label
    Friend WithEvents lblAssessmentandTax As System.Windows.Forms.Label
    Friend WithEvents txtValueProperty As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculateTax As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
