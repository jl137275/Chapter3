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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFahrenheitHere = New System.Windows.Forms.Label()
        Me.txtCelsius = New System.Windows.Forms.TextBox()
        Me.txtFahrenheit = New System.Windows.Forms.TextBox()
        Me.btnShowCalculation = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Type Celsius here:"
        '
        'lblFahrenheitHere
        '
        Me.lblFahrenheitHere.AutoSize = True
        Me.lblFahrenheitHere.Location = New System.Drawing.Point(12, 96)
        Me.lblFahrenheitHere.Name = "lblFahrenheitHere"
        Me.lblFahrenheitHere.Size = New System.Drawing.Size(111, 13)
        Me.lblFahrenheitHere.TabIndex = 1
        Me.lblFahrenheitHere.Text = "Type Fahrenheit here:"
        '
        'txtCelsius
        '
        Me.txtCelsius.Location = New System.Drawing.Point(158, 24)
        Me.txtCelsius.Name = "txtCelsius"
        Me.txtCelsius.Size = New System.Drawing.Size(100, 20)
        Me.txtCelsius.TabIndex = 2
        '
        'txtFahrenheit
        '
        Me.txtFahrenheit.Location = New System.Drawing.Point(158, 93)
        Me.txtFahrenheit.Name = "txtFahrenheit"
        Me.txtFahrenheit.Size = New System.Drawing.Size(100, 20)
        Me.txtFahrenheit.TabIndex = 3
        '
        'btnShowCalculation
        '
        Me.btnShowCalculation.Location = New System.Drawing.Point(15, 203)
        Me.btnShowCalculation.Name = "btnShowCalculation"
        Me.btnShowCalculation.Size = New System.Drawing.Size(85, 35)
        Me.btnShowCalculation.TabIndex = 4
        Me.btnShowCalculation.Text = "Show calculation"
        Me.btnShowCalculation.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(106, 203)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 35)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(197, 203)
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
        Me.Controls.Add(Me.btnShowCalculation)
        Me.Controls.Add(Me.txtFahrenheit)
        Me.Controls.Add(Me.txtCelsius)
        Me.Controls.Add(Me.lblFahrenheitHere)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblFahrenheitHere As System.Windows.Forms.Label
    Friend WithEvents txtCelsius As System.Windows.Forms.TextBox
    Friend WithEvents txtFahrenheit As System.Windows.Forms.TextBox
    Friend WithEvents btnShowCalculation As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
