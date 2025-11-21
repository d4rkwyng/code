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
        Me.grpType = New System.Windows.Forms.GroupBox
        Me.grpOptions = New System.Windows.Forms.GroupBox
        Me.grpMembLength = New System.Windows.Forms.GroupBox
        Me.grpMembFees = New System.Windows.Forms.GroupBox
        Me.btnCalc = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.radAdult = New System.Windows.Forms.RadioButton
        Me.radChild = New System.Windows.Forms.RadioButton
        Me.radStudent = New System.Windows.Forms.RadioButton
        Me.radSenior = New System.Windows.Forms.RadioButton
        Me.chkYoga = New System.Windows.Forms.CheckBox
        Me.chkKarate = New System.Windows.Forms.CheckBox
        Me.chkTrainer = New System.Windows.Forms.CheckBox
        Me.txtMonths = New System.Windows.Forms.TextBox
        Me.lblNumMonths = New System.Windows.Forms.Label
        Me.lblMontly = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.lblMonthlyFee = New System.Windows.Forms.Label
        Me.lblTotalFee = New System.Windows.Forms.Label
        Me.grpType.SuspendLayout()
        Me.grpOptions.SuspendLayout()
        Me.grpMembLength.SuspendLayout()
        Me.grpMembFees.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpType
        '
        Me.grpType.Controls.Add(Me.radSenior)
        Me.grpType.Controls.Add(Me.radStudent)
        Me.grpType.Controls.Add(Me.radChild)
        Me.grpType.Controls.Add(Me.radAdult)
        Me.grpType.Location = New System.Drawing.Point(12, 12)
        Me.grpType.Name = "grpType"
        Me.grpType.Size = New System.Drawing.Size(120, 110)
        Me.grpType.TabIndex = 0
        Me.grpType.TabStop = False
        Me.grpType.Text = "Type of Membership"
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.chkTrainer)
        Me.grpOptions.Controls.Add(Me.chkKarate)
        Me.grpOptions.Controls.Add(Me.chkYoga)
        Me.grpOptions.Location = New System.Drawing.Point(138, 12)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(173, 110)
        Me.grpOptions.TabIndex = 1
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'grpMembLength
        '
        Me.grpMembLength.Controls.Add(Me.lblNumMonths)
        Me.grpMembLength.Controls.Add(Me.txtMonths)
        Me.grpMembLength.Location = New System.Drawing.Point(12, 128)
        Me.grpMembLength.Name = "grpMembLength"
        Me.grpMembLength.Size = New System.Drawing.Size(120, 100)
        Me.grpMembLength.TabIndex = 2
        Me.grpMembLength.TabStop = False
        Me.grpMembLength.Text = "Membership Length"
        '
        'grpMembFees
        '
        Me.grpMembFees.Controls.Add(Me.lblTotalFee)
        Me.grpMembFees.Controls.Add(Me.lblMonthlyFee)
        Me.grpMembFees.Controls.Add(Me.lblTotal)
        Me.grpMembFees.Controls.Add(Me.lblMontly)
        Me.grpMembFees.Location = New System.Drawing.Point(138, 128)
        Me.grpMembFees.Name = "grpMembFees"
        Me.grpMembFees.Size = New System.Drawing.Size(173, 100)
        Me.grpMembFees.TabIndex = 3
        Me.grpMembFees.TabStop = False
        Me.grpMembFees.Text = "Membership Fees"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(39, 246)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 4
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(120, 246)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(201, 246)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'radAdult
        '
        Me.radAdult.AutoSize = True
        Me.radAdult.Location = New System.Drawing.Point(7, 20)
        Me.radAdult.Name = "radAdult"
        Me.radAdult.Size = New System.Drawing.Size(95, 17)
        Me.radAdult.TabIndex = 0
        Me.radAdult.TabStop = True
        Me.radAdult.Text = "Standard &Adult"
        Me.radAdult.UseVisualStyleBackColor = True
        '
        'radChild
        '
        Me.radChild.AutoSize = True
        Me.radChild.Location = New System.Drawing.Point(7, 43)
        Me.radChild.Name = "radChild"
        Me.radChild.Size = New System.Drawing.Size(108, 17)
        Me.radChild.TabIndex = 1
        Me.radChild.TabStop = True
        Me.radChild.Text = "Chil&d (12 && under)"
        Me.radChild.UseVisualStyleBackColor = True
        '
        'radStudent
        '
        Me.radStudent.AutoSize = True
        Me.radStudent.Location = New System.Drawing.Point(6, 66)
        Me.radStudent.Name = "radStudent"
        Me.radStudent.Size = New System.Drawing.Size(62, 17)
        Me.radStudent.TabIndex = 2
        Me.radStudent.TabStop = True
        Me.radStudent.Text = "&Student"
        Me.radStudent.UseVisualStyleBackColor = True
        '
        'radSenior
        '
        Me.radSenior.AutoSize = True
        Me.radSenior.Location = New System.Drawing.Point(7, 89)
        Me.radSenior.Name = "radSenior"
        Me.radSenior.Size = New System.Drawing.Size(89, 17)
        Me.radSenior.TabIndex = 3
        Me.radSenior.TabStop = True
        Me.radSenior.Text = "S&enior Citizen"
        Me.radSenior.UseVisualStyleBackColor = True
        '
        'chkYoga
        '
        Me.chkYoga.AutoSize = True
        Me.chkYoga.Location = New System.Drawing.Point(16, 21)
        Me.chkYoga.Name = "chkYoga"
        Me.chkYoga.Size = New System.Drawing.Size(51, 17)
        Me.chkYoga.TabIndex = 1
        Me.chkYoga.Text = "&Yoga"
        Me.chkYoga.UseVisualStyleBackColor = True
        '
        'chkKarate
        '
        Me.chkKarate.AutoSize = True
        Me.chkKarate.Location = New System.Drawing.Point(16, 44)
        Me.chkKarate.Name = "chkKarate"
        Me.chkKarate.Size = New System.Drawing.Size(57, 17)
        Me.chkKarate.TabIndex = 2
        Me.chkKarate.Text = "&Karate"
        Me.chkKarate.UseVisualStyleBackColor = True
        '
        'chkTrainer
        '
        Me.chkTrainer.AutoSize = True
        Me.chkTrainer.Location = New System.Drawing.Point(16, 66)
        Me.chkTrainer.Name = "chkTrainer"
        Me.chkTrainer.Size = New System.Drawing.Size(103, 17)
        Me.chkTrainer.TabIndex = 3
        Me.chkTrainer.Text = "&Personal Trainer"
        Me.chkTrainer.UseVisualStyleBackColor = True
        '
        'txtMonths
        '
        Me.txtMonths.Location = New System.Drawing.Point(7, 74)
        Me.txtMonths.Name = "txtMonths"
        Me.txtMonths.Size = New System.Drawing.Size(108, 20)
        Me.txtMonths.TabIndex = 0
        '
        'lblNumMonths
        '
        Me.lblNumMonths.Location = New System.Drawing.Point(6, 32)
        Me.lblNumMonths.Name = "lblNumMonths"
        Me.lblNumMonths.Size = New System.Drawing.Size(96, 38)
        Me.lblNumMonths.TabIndex = 1
        Me.lblNumMonths.Text = "Enter the Number of &Months:"
        '
        'lblMontly
        '
        Me.lblMontly.AutoSize = True
        Me.lblMontly.Location = New System.Drawing.Point(13, 32)
        Me.lblMontly.Name = "lblMontly"
        Me.lblMontly.Size = New System.Drawing.Size(68, 13)
        Me.lblMontly.TabIndex = 8
        Me.lblMontly.Text = "Monthly Fee:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(13, 56)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblTotal.TabIndex = 9
        Me.lblTotal.Text = "Total:"
        '
        'lblMonthlyFee
        '
        Me.lblMonthlyFee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMonthlyFee.Location = New System.Drawing.Point(87, 31)
        Me.lblMonthlyFee.Name = "lblMonthlyFee"
        Me.lblMonthlyFee.Size = New System.Drawing.Size(81, 14)
        Me.lblMonthlyFee.TabIndex = 10
        '
        'lblTotalFee
        '
        Me.lblTotalFee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalFee.Location = New System.Drawing.Point(87, 55)
        Me.lblTotalFee.Name = "lblTotalFee"
        Me.lblTotalFee.Size = New System.Drawing.Size(81, 14)
        Me.lblTotalFee.TabIndex = 11
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 278)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.grpMembFees)
        Me.Controls.Add(Me.grpMembLength)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.grpType)
        Me.Name = "frmMain"
        Me.Text = "Health Club Membership Fee Calculator"
        Me.grpType.ResumeLayout(False)
        Me.grpType.PerformLayout()
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.grpMembLength.ResumeLayout(False)
        Me.grpMembLength.PerformLayout()
        Me.grpMembFees.ResumeLayout(False)
        Me.grpMembFees.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpType As System.Windows.Forms.GroupBox
    Friend WithEvents grpOptions As System.Windows.Forms.GroupBox
    Friend WithEvents grpMembLength As System.Windows.Forms.GroupBox
    Friend WithEvents grpMembFees As System.Windows.Forms.GroupBox
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents radSenior As System.Windows.Forms.RadioButton
    Friend WithEvents radStudent As System.Windows.Forms.RadioButton
    Friend WithEvents radChild As System.Windows.Forms.RadioButton
    Friend WithEvents radAdult As System.Windows.Forms.RadioButton
    Friend WithEvents chkTrainer As System.Windows.Forms.CheckBox
    Friend WithEvents chkKarate As System.Windows.Forms.CheckBox
    Friend WithEvents chkYoga As System.Windows.Forms.CheckBox
    Friend WithEvents lblNumMonths As System.Windows.Forms.Label
    Friend WithEvents txtMonths As System.Windows.Forms.TextBox
    Friend WithEvents lblMontly As System.Windows.Forms.Label
    Friend WithEvents lblTotalFee As System.Windows.Forms.Label
    Friend WithEvents lblMonthlyFee As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label

End Class
