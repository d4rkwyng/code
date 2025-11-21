<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtHoursWorked = New System.Windows.Forms.TextBox
        Me.lblPayRate = New System.Windows.Forms.Label
        Me.lblGrossPayEarned = New System.Windows.Forms.Label
        Me.txtPayRate = New System.Windows.Forms.TextBox
        Me.lblGrossPay = New System.Windows.Forms.Label
        Me.btnCalcGrossPay = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.lblM = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number of Hours Worked"
        '
        'txtHoursWorked
        '
        Me.txtHoursWorked.Location = New System.Drawing.Point(170, 9)
        Me.txtHoursWorked.Name = "txtHoursWorked"
        Me.txtHoursWorked.Size = New System.Drawing.Size(60, 20)
        Me.txtHoursWorked.TabIndex = 1
        '
        'lblPayRate
        '
        Me.lblPayRate.AutoSize = True
        Me.lblPayRate.Location = New System.Drawing.Point(12, 49)
        Me.lblPayRate.Name = "lblPayRate"
        Me.lblPayRate.Size = New System.Drawing.Size(84, 13)
        Me.lblPayRate.TabIndex = 2
        Me.lblPayRate.Text = "Hourly Pay Rate"
        '
        'lblGrossPayEarned
        '
        Me.lblGrossPayEarned.AutoSize = True
        Me.lblGrossPayEarned.Location = New System.Drawing.Point(12, 111)
        Me.lblGrossPayEarned.Name = "lblGrossPayEarned"
        Me.lblGrossPayEarned.Size = New System.Drawing.Size(92, 13)
        Me.lblGrossPayEarned.TabIndex = 3
        Me.lblGrossPayEarned.Text = "Gross Pay Earned"
        '
        'txtPayRate
        '
        Me.txtPayRate.Location = New System.Drawing.Point(170, 46)
        Me.txtPayRate.Name = "txtPayRate"
        Me.txtPayRate.Size = New System.Drawing.Size(60, 20)
        Me.txtPayRate.TabIndex = 4
        '
        'lblGrossPay
        '
        Me.lblGrossPay.AutoSize = True
        Me.lblGrossPay.Location = New System.Drawing.Point(167, 111)
        Me.lblGrossPay.Name = "lblGrossPay"
        Me.lblGrossPay.Size = New System.Drawing.Size(34, 13)
        Me.lblGrossPay.TabIndex = 5
        Me.lblGrossPay.Text = "$0.00"
        '
        'btnCalcGrossPay
        '
        Me.btnCalcGrossPay.Location = New System.Drawing.Point(15, 149)
        Me.btnCalcGrossPay.Name = "btnCalcGrossPay"
        Me.btnCalcGrossPay.Size = New System.Drawing.Size(119, 23)
        Me.btnCalcGrossPay.TabIndex = 6
        Me.btnCalcGrossPay.Text = "Calculate Gross Pay"
        Me.btnCalcGrossPay.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(155, 149)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblM
        '
        Me.lblM.AutoSize = True
        Me.lblM.Location = New System.Drawing.Point(151, 49)
        Me.lblM.Name = "lblM"
        Me.lblM.Size = New System.Drawing.Size(13, 13)
        Me.lblM.TabIndex = 8
        Me.lblM.Text = "$"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(243, 184)
        Me.Controls.Add(Me.lblM)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCalcGrossPay)
        Me.Controls.Add(Me.lblGrossPay)
        Me.Controls.Add(Me.txtPayRate)
        Me.Controls.Add(Me.lblGrossPayEarned)
        Me.Controls.Add(Me.lblPayRate)
        Me.Controls.Add(Me.txtHoursWorked)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Wage Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtHoursWorked As System.Windows.Forms.TextBox
    Friend WithEvents lblPayRate As System.Windows.Forms.Label
    Friend WithEvents lblGrossPayEarned As System.Windows.Forms.Label
    Friend WithEvents txtPayRate As System.Windows.Forms.TextBox
    Friend WithEvents lblGrossPay As System.Windows.Forms.Label
    Friend WithEvents btnCalcGrossPay As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblM As System.Windows.Forms.Label

End Class
