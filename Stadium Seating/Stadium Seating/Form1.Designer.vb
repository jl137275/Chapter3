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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblClass1 = New System.Windows.Forms.Label()
        Me.lblClass2 = New System.Windows.Forms.Label()
        Me.lblClass3 = New System.Windows.Forms.Label()
        Me.txtClassA = New System.Windows.Forms.TextBox()
        Me.txtClassB = New System.Windows.Forms.TextBox()
        Me.txtClassC = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblClassA = New System.Windows.Forms.Label()
        Me.lblClassB = New System.Windows.Forms.Label()
        Me.lblClassC = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTotalRevenue = New System.Windows.Forms.Label()
        Me.btnCalculateRevenue = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtClassA)
        Me.GroupBox1.Controls.Add(Me.txtClassB)
        Me.GroupBox1.Controls.Add(Me.txtClassC)
        Me.GroupBox1.Controls.Add(Me.lblClass3)
        Me.GroupBox1.Controls.Add(Me.lblClass2)
        Me.GroupBox1.Controls.Add(Me.lblClass1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(277, 217)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tickets Sold"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTotalRevenue)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.lblClassC)
        Me.GroupBox2.Controls.Add(Me.lblClassB)
        Me.GroupBox2.Controls.Add(Me.lblClassA)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(310, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(217, 205)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Revenue Generated"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the number of tickets sold for each class of seats"
        '
        'lblClass1
        '
        Me.lblClass1.AutoSize = True
        Me.lblClass1.Location = New System.Drawing.Point(12, 78)
        Me.lblClass1.Name = "lblClass1"
        Me.lblClass1.Size = New System.Drawing.Size(45, 13)
        Me.lblClass1.TabIndex = 1
        Me.lblClass1.Text = "Class A:"
        '
        'lblClass2
        '
        Me.lblClass2.AutoSize = True
        Me.lblClass2.Location = New System.Drawing.Point(12, 111)
        Me.lblClass2.Name = "lblClass2"
        Me.lblClass2.Size = New System.Drawing.Size(45, 13)
        Me.lblClass2.TabIndex = 2
        Me.lblClass2.Text = "Class B:"
        '
        'lblClass3
        '
        Me.lblClass3.AutoSize = True
        Me.lblClass3.Location = New System.Drawing.Point(12, 148)
        Me.lblClass3.Name = "lblClass3"
        Me.lblClass3.Size = New System.Drawing.Size(45, 13)
        Me.lblClass3.TabIndex = 3
        Me.lblClass3.Text = "Class C:"
        '
        'txtClassA
        '
        Me.txtClassA.Location = New System.Drawing.Point(100, 75)
        Me.txtClassA.Name = "txtClassA"
        Me.txtClassA.Size = New System.Drawing.Size(100, 20)
        Me.txtClassA.TabIndex = 2
        '
        'txtClassB
        '
        Me.txtClassB.Location = New System.Drawing.Point(100, 108)
        Me.txtClassB.Name = "txtClassB"
        Me.txtClassB.Size = New System.Drawing.Size(100, 20)
        Me.txtClassB.TabIndex = 3
        '
        'txtClassC
        '
        Me.txtClassC.Location = New System.Drawing.Point(100, 148)
        Me.txtClassC.Name = "txtClassC"
        Me.txtClassC.Size = New System.Drawing.Size(100, 20)
        Me.txtClassC.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Class A:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Class B:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Class C:"
        '
        'lblClassA
        '
        Me.lblClassA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClassA.Location = New System.Drawing.Point(111, 38)
        Me.lblClassA.Name = "lblClassA"
        Me.lblClassA.Size = New System.Drawing.Size(100, 23)
        Me.lblClassA.TabIndex = 7
        '
        'lblClassB
        '
        Me.lblClassB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClassB.Location = New System.Drawing.Point(111, 85)
        Me.lblClassB.Name = "lblClassB"
        Me.lblClassB.Size = New System.Drawing.Size(100, 23)
        Me.lblClassB.TabIndex = 8
        '
        'lblClassC
        '
        Me.lblClassC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClassC.Location = New System.Drawing.Point(111, 125)
        Me.lblClassC.Name = "lblClassC"
        Me.lblClassC.Size = New System.Drawing.Size(100, 23)
        Me.lblClassC.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 161)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Total Revenue:"
        '
        'lblTotalRevenue
        '
        Me.lblTotalRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalRevenue.Location = New System.Drawing.Point(111, 160)
        Me.lblTotalRevenue.Name = "lblTotalRevenue"
        Me.lblTotalRevenue.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalRevenue.TabIndex = 10
        '
        'btnCalculateRevenue
        '
        Me.btnCalculateRevenue.Location = New System.Drawing.Point(100, 249)
        Me.btnCalculateRevenue.Name = "btnCalculateRevenue"
        Me.btnCalculateRevenue.Size = New System.Drawing.Size(114, 31)
        Me.btnCalculateRevenue.TabIndex = 11
        Me.btnCalculateRevenue.Text = "Calculate Revenue"
        Me.btnCalculateRevenue.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(245, 249)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(102, 31)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(376, 249)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(99, 31)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 307)
        Me.Controls.Add(Me.btnCalculateRevenue)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Stadium Seating"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblClass3 As System.Windows.Forms.Label
    Friend WithEvents lblClass2 As System.Windows.Forms.Label
    Friend WithEvents lblClass1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtClassA As System.Windows.Forms.TextBox
    Friend WithEvents txtClassB As System.Windows.Forms.TextBox
    Friend WithEvents txtClassC As System.Windows.Forms.TextBox
    Friend WithEvents lblClassA As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblClassC As System.Windows.Forms.Label
    Friend WithEvents lblClassB As System.Windows.Forms.Label
    Friend WithEvents lblTotalRevenue As System.Windows.Forms.Label
    Friend WithEvents btnCalculateRevenue As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
