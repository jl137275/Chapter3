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
        Me.lblTestScore1 = New System.Windows.Forms.Label()
        Me.lblTestScore2 = New System.Windows.Forms.Label()
        Me.lblTestScore3 = New System.Windows.Forms.Label()
        Me.lblTestScore4 = New System.Windows.Forms.Label()
        Me.lblTestScore5 = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.lblAverageResult = New System.Windows.Forms.Label()
        Me.txtTestScore2 = New System.Windows.Forms.TextBox()
        Me.txtTestScore1 = New System.Windows.Forms.TextBox()
        Me.txtTestScore5 = New System.Windows.Forms.TextBox()
        Me.txtTestScore4 = New System.Windows.Forms.TextBox()
        Me.txtTestScore3 = New System.Windows.Forms.TextBox()
        Me.btnCalculateRevenue = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTestScore1
        '
        Me.lblTestScore1.AutoSize = True
        Me.lblTestScore1.Location = New System.Drawing.Point(45, 22)
        Me.lblTestScore1.Name = "lblTestScore1"
        Me.lblTestScore1.Size = New System.Drawing.Size(71, 13)
        Me.lblTestScore1.TabIndex = 0
        Me.lblTestScore1.Text = "Test Score 1:"
        '
        'lblTestScore2
        '
        Me.lblTestScore2.AutoSize = True
        Me.lblTestScore2.Location = New System.Drawing.Point(45, 56)
        Me.lblTestScore2.Name = "lblTestScore2"
        Me.lblTestScore2.Size = New System.Drawing.Size(71, 13)
        Me.lblTestScore2.TabIndex = 1
        Me.lblTestScore2.Text = "Test Score 2:"
        '
        'lblTestScore3
        '
        Me.lblTestScore3.AutoSize = True
        Me.lblTestScore3.Location = New System.Drawing.Point(45, 89)
        Me.lblTestScore3.Name = "lblTestScore3"
        Me.lblTestScore3.Size = New System.Drawing.Size(71, 13)
        Me.lblTestScore3.TabIndex = 2
        Me.lblTestScore3.Text = "Test Score 3:"
        '
        'lblTestScore4
        '
        Me.lblTestScore4.AutoSize = True
        Me.lblTestScore4.Location = New System.Drawing.Point(45, 118)
        Me.lblTestScore4.Name = "lblTestScore4"
        Me.lblTestScore4.Size = New System.Drawing.Size(71, 13)
        Me.lblTestScore4.TabIndex = 3
        Me.lblTestScore4.Text = "Test Score 4:"
        '
        'lblTestScore5
        '
        Me.lblTestScore5.AutoSize = True
        Me.lblTestScore5.Location = New System.Drawing.Point(45, 149)
        Me.lblTestScore5.Name = "lblTestScore5"
        Me.lblTestScore5.Size = New System.Drawing.Size(71, 13)
        Me.lblTestScore5.TabIndex = 4
        Me.lblTestScore5.Text = "Test Score 5:"
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Location = New System.Drawing.Point(45, 188)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(47, 13)
        Me.lblAverage.TabIndex = 5
        Me.lblAverage.Text = "Average"
        '
        'lblAverageResult
        '
        Me.lblAverageResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageResult.Location = New System.Drawing.Point(150, 187)
        Me.lblAverageResult.Name = "lblAverageResult"
        Me.lblAverageResult.Size = New System.Drawing.Size(100, 23)
        Me.lblAverageResult.TabIndex = 6
        '
        'txtTestScore2
        '
        Me.txtTestScore2.Location = New System.Drawing.Point(150, 49)
        Me.txtTestScore2.Name = "txtTestScore2"
        Me.txtTestScore2.Size = New System.Drawing.Size(100, 20)
        Me.txtTestScore2.TabIndex = 7
        '
        'txtTestScore1
        '
        Me.txtTestScore1.Location = New System.Drawing.Point(150, 22)
        Me.txtTestScore1.Name = "txtTestScore1"
        Me.txtTestScore1.Size = New System.Drawing.Size(100, 20)
        Me.txtTestScore1.TabIndex = 8
        '
        'txtTestScore5
        '
        Me.txtTestScore5.Location = New System.Drawing.Point(150, 149)
        Me.txtTestScore5.Name = "txtTestScore5"
        Me.txtTestScore5.Size = New System.Drawing.Size(100, 20)
        Me.txtTestScore5.TabIndex = 9
        '
        'txtTestScore4
        '
        Me.txtTestScore4.Location = New System.Drawing.Point(150, 118)
        Me.txtTestScore4.Name = "txtTestScore4"
        Me.txtTestScore4.Size = New System.Drawing.Size(100, 20)
        Me.txtTestScore4.TabIndex = 10
        '
        'txtTestScore3
        '
        Me.txtTestScore3.Location = New System.Drawing.Point(150, 89)
        Me.txtTestScore3.Name = "txtTestScore3"
        Me.txtTestScore3.Size = New System.Drawing.Size(100, 20)
        Me.txtTestScore3.TabIndex = 11
        '
        'btnCalculateRevenue
        '
        Me.btnCalculateRevenue.Location = New System.Drawing.Point(12, 262)
        Me.btnCalculateRevenue.Name = "btnCalculateRevenue"
        Me.btnCalculateRevenue.Size = New System.Drawing.Size(88, 37)
        Me.btnCalculateRevenue.TabIndex = 12
        Me.btnCalculateRevenue.Text = "Calculate Revenue"
        Me.btnCalculateRevenue.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(106, 262)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 37)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(197, 262)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 37)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 311)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculateRevenue)
        Me.Controls.Add(Me.txtTestScore3)
        Me.Controls.Add(Me.txtTestScore4)
        Me.Controls.Add(Me.txtTestScore5)
        Me.Controls.Add(Me.txtTestScore1)
        Me.Controls.Add(Me.txtTestScore2)
        Me.Controls.Add(Me.lblAverageResult)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lblTestScore5)
        Me.Controls.Add(Me.lblTestScore4)
        Me.Controls.Add(Me.lblTestScore3)
        Me.Controls.Add(Me.lblTestScore2)
        Me.Controls.Add(Me.lblTestScore1)
        Me.Name = "Form1"
        Me.Text = "Test Score Average"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTestScore1 As System.Windows.Forms.Label
    Friend WithEvents lblTestScore2 As System.Windows.Forms.Label
    Friend WithEvents lblTestScore3 As System.Windows.Forms.Label
    Friend WithEvents lblTestScore4 As System.Windows.Forms.Label
    Friend WithEvents lblTestScore5 As System.Windows.Forms.Label
    Friend WithEvents lblAverage As System.Windows.Forms.Label
    Friend WithEvents lblAverageResult As System.Windows.Forms.Label
    Friend WithEvents txtTestScore2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTestScore1 As System.Windows.Forms.TextBox
    Friend WithEvents txtTestScore5 As System.Windows.Forms.TextBox
    Friend WithEvents txtTestScore4 As System.Windows.Forms.TextBox
    Friend WithEvents txtTestScore3 As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculateRevenue As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
