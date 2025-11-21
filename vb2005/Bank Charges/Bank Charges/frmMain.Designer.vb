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
        Me.txtNumChecks = New System.Windows.Forms.TextBox
        Me.btnCalc = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblTotalFees = New System.Windows.Forms.Label
        Me.txtTotalFees = New System.Windows.Forms.TextBox
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtNumChecks
        '
        Me.txtNumChecks.Location = New System.Drawing.Point(15, 25)
        Me.txtNumChecks.Name = "txtNumChecks"
        Me.txtNumChecks.Size = New System.Drawing.Size(100, 20)
        Me.txtNumChecks.TabIndex = 0
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(121, 22)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 1
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Number of Checks"
        '
        'lblTotalFees
        '
        Me.lblTotalFees.AutoSize = True
        Me.lblTotalFees.Location = New System.Drawing.Point(12, 57)
        Me.lblTotalFees.Name = "lblTotalFees"
        Me.lblTotalFees.Size = New System.Drawing.Size(57, 13)
        Me.lblTotalFees.TabIndex = 4
        Me.lblTotalFees.Text = "Total Fees"
        '
        'txtTotalFees
        '
        Me.txtTotalFees.Location = New System.Drawing.Point(15, 73)
        Me.txtTotalFees.Name = "txtTotalFees"
        Me.txtTotalFees.ReadOnly = True
        Me.txtTotalFees.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalFees.TabIndex = 2
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(15, 121)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Cl&ear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(121, 121)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "C&lose"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(204, 155)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtTotalFees)
        Me.Controls.Add(Me.lblTotalFees)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtNumChecks)
        Me.Name = "frmMain"
        Me.Text = "Bank Charges"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNumChecks As System.Windows.Forms.TextBox
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTotalFees As System.Windows.Forms.Label
    Friend WithEvents txtTotalFees As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button

End Class
