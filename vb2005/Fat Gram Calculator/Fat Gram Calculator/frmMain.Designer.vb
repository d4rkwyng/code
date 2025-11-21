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
        Me.btnCalc = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.lblCalories = New System.Windows.Forms.Label
        Me.lblPercentage = New System.Windows.Forms.Label
        Me.lblFat = New System.Windows.Forms.Label
        Me.txtCal = New System.Windows.Forms.TextBox
        Me.txtFat = New System.Windows.Forms.TextBox
        Me.txtPercentage = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(15, 165)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 0
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(96, 165)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(177, 165)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblCalories
        '
        Me.lblCalories.Location = New System.Drawing.Point(12, 9)
        Me.lblCalories.Name = "lblCalories"
        Me.lblCalories.Size = New System.Drawing.Size(117, 31)
        Me.lblCalories.TabIndex = 3
        Me.lblCalories.Text = "Enter the &number of calories in the food:"
        '
        'lblPercentage
        '
        Me.lblPercentage.Location = New System.Drawing.Point(12, 109)
        Me.lblPercentage.Name = "lblPercentage"
        Me.lblPercentage.Size = New System.Drawing.Size(117, 36)
        Me.lblPercentage.TabIndex = 4
        Me.lblPercentage.Text = "Percentage of calories that come from fat:"
        '
        'lblFat
        '
        Me.lblFat.Location = New System.Drawing.Point(12, 44)
        Me.lblFat.Name = "lblFat"
        Me.lblFat.Size = New System.Drawing.Size(117, 39)
        Me.lblFat.TabIndex = 5
        Me.lblFat.Text = "Enter the number of &fat grams in the food."
        '
        'txtCal
        '
        Me.txtCal.Location = New System.Drawing.Point(151, 12)
        Me.txtCal.Name = "txtCal"
        Me.txtCal.Size = New System.Drawing.Size(100, 20)
        Me.txtCal.TabIndex = 6
        '
        'txtFat
        '
        Me.txtFat.Location = New System.Drawing.Point(151, 44)
        Me.txtFat.Name = "txtFat"
        Me.txtFat.Size = New System.Drawing.Size(100, 20)
        Me.txtFat.TabIndex = 7
        '
        'txtPercentage
        '
        Me.txtPercentage.Location = New System.Drawing.Point(151, 109)
        Me.txtPercentage.Name = "txtPercentage"
        Me.txtPercentage.ReadOnly = True
        Me.txtPercentage.Size = New System.Drawing.Size(100, 20)
        Me.txtPercentage.TabIndex = 8
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 195)
        Me.Controls.Add(Me.txtPercentage)
        Me.Controls.Add(Me.txtFat)
        Me.Controls.Add(Me.txtCal)
        Me.Controls.Add(Me.lblFat)
        Me.Controls.Add(Me.lblPercentage)
        Me.Controls.Add(Me.lblCalories)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Name = "frmMain"
        Me.Text = "Fat Gram Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblCalories As System.Windows.Forms.Label
    Friend WithEvents lblPercentage As System.Windows.Forms.Label
    Friend WithEvents lblFat As System.Windows.Forms.Label
    Friend WithEvents txtCal As System.Windows.Forms.TextBox
    Friend WithEvents txtFat As System.Windows.Forms.TextBox
    Friend WithEvents txtPercentage As System.Windows.Forms.TextBox

End Class
