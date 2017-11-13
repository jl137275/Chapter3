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
        Me.txtGallonsOfGasInput = New System.Windows.Forms.TextBox()
        Me.txtNumberOfMilesInput = New System.Windows.Forms.TextBox()
        Me.lblGallonsOfGas = New System.Windows.Forms.Label()
        Me.lblNumberOfMiles = New System.Windows.Forms.Label()
        Me.lblMilesPerGallon = New System.Windows.Forms.Label()
        Me.lblMilesPerGallonTotal = New System.Windows.Forms.Label()
        Me.btnCalculateMPG = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtGallonsOfGasInput
        '
        Me.txtGallonsOfGasInput.Location = New System.Drawing.Point(265, 33)
        Me.txtGallonsOfGasInput.Name = "txtGallonsOfGasInput"
        Me.txtGallonsOfGasInput.Size = New System.Drawing.Size(100, 20)
        Me.txtGallonsOfGasInput.TabIndex = 0
        '
        'txtNumberOfMilesInput
        '
        Me.txtNumberOfMilesInput.Location = New System.Drawing.Point(265, 89)
        Me.txtNumberOfMilesInput.Name = "txtNumberOfMilesInput"
        Me.txtNumberOfMilesInput.Size = New System.Drawing.Size(100, 20)
        Me.txtNumberOfMilesInput.TabIndex = 1
        '
        'lblGallonsOfGas
        '
        Me.lblGallonsOfGas.AutoSize = True
        Me.lblGallonsOfGas.Location = New System.Drawing.Point(1, 36)
        Me.lblGallonsOfGas.Name = "lblGallonsOfGas"
        Me.lblGallonsOfGas.Size = New System.Drawing.Size(160, 13)
        Me.lblGallonsOfGas.TabIndex = 2
        Me.lblGallonsOfGas.Text = "Gallons of gas that car can hold:"
        '
        'lblNumberOfMiles
        '
        Me.lblNumberOfMiles.AutoSize = True
        Me.lblNumberOfMiles.Location = New System.Drawing.Point(1, 89)
        Me.lblNumberOfMiles.Name = "lblNumberOfMiles"
        Me.lblNumberOfMiles.Size = New System.Drawing.Size(225, 13)
        Me.lblNumberOfMiles.TabIndex = 3
        Me.lblNumberOfMiles.Text = "Number of miles it can be driven on a full tank:"
        '
        'lblMilesPerGallon
        '
        Me.lblMilesPerGallon.AutoSize = True
        Me.lblMilesPerGallon.Location = New System.Drawing.Point(40, 157)
        Me.lblMilesPerGallon.Name = "lblMilesPerGallon"
        Me.lblMilesPerGallon.Size = New System.Drawing.Size(83, 13)
        Me.lblMilesPerGallon.TabIndex = 4
        Me.lblMilesPerGallon.Text = "Miles per gallon:"
        '
        'lblMilesPerGallonTotal
        '
        Me.lblMilesPerGallonTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMilesPerGallonTotal.Location = New System.Drawing.Point(265, 147)
        Me.lblMilesPerGallonTotal.Name = "lblMilesPerGallonTotal"
        Me.lblMilesPerGallonTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblMilesPerGallonTotal.TabIndex = 5
        '
        'btnCalculateMPG
        '
        Me.btnCalculateMPG.Location = New System.Drawing.Point(21, 215)
        Me.btnCalculateMPG.Name = "btnCalculateMPG"
        Me.btnCalculateMPG.Size = New System.Drawing.Size(91, 23)
        Me.btnCalculateMPG.TabIndex = 6
        Me.btnCalculateMPG.Text = "Calculate MPG"
        Me.btnCalculateMPG.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(151, 215)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(265, 215)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 262)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculateMPG)
        Me.Controls.Add(Me.lblMilesPerGallonTotal)
        Me.Controls.Add(Me.lblMilesPerGallon)
        Me.Controls.Add(Me.lblNumberOfMiles)
        Me.Controls.Add(Me.lblGallonsOfGas)
        Me.Controls.Add(Me.txtNumberOfMilesInput)
        Me.Controls.Add(Me.txtGallonsOfGasInput)
        Me.Name = "Form1"
        Me.Text = "Miles Per Gallon Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtGallonsOfGasInput As System.Windows.Forms.TextBox
    Friend WithEvents txtNumberOfMilesInput As System.Windows.Forms.TextBox
    Friend WithEvents lblGallonsOfGas As System.Windows.Forms.Label
    Friend WithEvents lblNumberOfMiles As System.Windows.Forms.Label
    Friend WithEvents lblMilesPerGallon As System.Windows.Forms.Label
    Friend WithEvents lblMilesPerGallonTotal As System.Windows.Forms.Label
    Friend WithEvents btnCalculateMPG As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
