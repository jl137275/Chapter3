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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblAnnualSalary = New System.Windows.Forms.Label()
        Me.lblPayPeriodsPerYear = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSalaryResult = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(104, 186)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblAnnualSalary
        '
        Me.lblAnnualSalary.AutoSize = True
        Me.lblAnnualSalary.Location = New System.Drawing.Point(38, 45)
        Me.lblAnnualSalary.Name = "lblAnnualSalary"
        Me.lblAnnualSalary.Size = New System.Drawing.Size(72, 13)
        Me.lblAnnualSalary.TabIndex = 1
        Me.lblAnnualSalary.Text = "Annual Salary"
        '
        'lblPayPeriodsPerYear
        '
        Me.lblPayPeriodsPerYear.AutoSize = True
        Me.lblPayPeriodsPerYear.Location = New System.Drawing.Point(38, 93)
        Me.lblPayPeriodsPerYear.Name = "lblPayPeriodsPerYear"
        Me.lblPayPeriodsPerYear.Size = New System.Drawing.Size(103, 13)
        Me.lblPayPeriodsPerYear.TabIndex = 2
        Me.lblPayPeriodsPerYear.Text = "Pay periods per year"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Salary per pay period"
        '
        'lblSalaryResult
        '
        Me.lblSalaryResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSalaryResult.Location = New System.Drawing.Point(172, 143)
        Me.lblSalaryResult.Name = "lblSalaryResult"
        Me.lblSalaryResult.Size = New System.Drawing.Size(100, 23)
        Me.lblSalaryResult.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(2, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Label5"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblSalaryResult)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblPayPeriodsPerYear)
        Me.Controls.Add(Me.lblAnnualSalary)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblAnnualSalary As System.Windows.Forms.Label
    Friend WithEvents lblPayPeriodsPerYear As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblSalaryResult As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
