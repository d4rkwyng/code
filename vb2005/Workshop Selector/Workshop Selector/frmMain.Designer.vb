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
        Me.components = New System.ComponentModel.Container
        Me.grpWorkshop = New System.Windows.Forms.GroupBox
        Me.lstWorkshop = New System.Windows.Forms.ListBox
        Me.grpLocation = New System.Windows.Forms.GroupBox
        Me.lstLocation = New System.Windows.Forms.ListBox
        Me.grpCosts = New System.Windows.Forms.GroupBox
        Me.lstCost = New System.Windows.Forms.ListBox
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnCalc = New System.Windows.Forms.Button
        Me.btnReset = New System.Windows.Forms.Button
        Me.lblTotal = New System.Windows.Forms.Label
        Me.lblCost = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpWorkshop.SuspendLayout()
        Me.grpLocation.SuspendLayout()
        Me.grpCosts.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpWorkshop
        '
        Me.grpWorkshop.Controls.Add(Me.lstWorkshop)
        Me.grpWorkshop.Location = New System.Drawing.Point(12, 12)
        Me.grpWorkshop.Name = "grpWorkshop"
        Me.grpWorkshop.Size = New System.Drawing.Size(133, 111)
        Me.grpWorkshop.TabIndex = 0
        Me.grpWorkshop.TabStop = False
        Me.grpWorkshop.Text = "Pick a Workshop"
        '
        'lstWorkshop
        '
        Me.lstWorkshop.FormattingEnabled = True
        Me.lstWorkshop.Items.AddRange(New Object() {"Handling Stress", "Time Management", "Supervision Skills", "Negotiation", "How to Interview"})
        Me.lstWorkshop.Location = New System.Drawing.Point(7, 28)
        Me.lstWorkshop.Name = "lstWorkshop"
        Me.lstWorkshop.Size = New System.Drawing.Size(120, 69)
        Me.lstWorkshop.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.lstWorkshop, "Available Workshops")
        '
        'grpLocation
        '
        Me.grpLocation.Controls.Add(Me.lstLocation)
        Me.grpLocation.Location = New System.Drawing.Point(151, 12)
        Me.grpLocation.Name = "grpLocation"
        Me.grpLocation.Size = New System.Drawing.Size(133, 111)
        Me.grpLocation.TabIndex = 1
        Me.grpLocation.TabStop = False
        Me.grpLocation.Text = "Pick a Location"
        '
        'lstLocation
        '
        Me.lstLocation.FormattingEnabled = True
        Me.lstLocation.Items.AddRange(New Object() {"Austin", "Chicago", "Dallas", "Orlando", "Phoenix", "Raleigh"})
        Me.lstLocation.Location = New System.Drawing.Point(7, 28)
        Me.lstLocation.Name = "lstLocation"
        Me.lstLocation.Size = New System.Drawing.Size(120, 69)
        Me.lstLocation.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.lstLocation, "Location")
        '
        'grpCosts
        '
        Me.grpCosts.Controls.Add(Me.lstCost)
        Me.grpCosts.Location = New System.Drawing.Point(290, 12)
        Me.grpCosts.Name = "grpCosts"
        Me.grpCosts.Size = New System.Drawing.Size(133, 111)
        Me.grpCosts.TabIndex = 2
        Me.grpCosts.TabStop = False
        Me.grpCosts.Text = "List of Costs"
        '
        'lstCost
        '
        Me.lstCost.FormattingEnabled = True
        Me.lstCost.Location = New System.Drawing.Point(6, 28)
        Me.lstCost.Name = "lstCost"
        Me.lstCost.Size = New System.Drawing.Size(120, 69)
        Me.lstCost.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.lstCost, "Costs")
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(55, 183)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 44)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "&Add Workshop"
        Me.ToolTip1.SetToolTip(Me.btnAdd, "Add the Workshop and Locations Costs")
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(298, 183)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 44)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Exit the Application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(136, 183)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 44)
        Me.btnCalc.TabIndex = 7
        Me.btnCalc.Text = "Calculate &Total"
        Me.ToolTip1.SetToolTip(Me.btnCalc, "Calculate the total")
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(217, 183)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 44)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "&Reset"
        Me.ToolTip1.SetToolTip(Me.btnReset, "Reset all the entries")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(148, 145)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(58, 13)
        Me.lblTotal.TabIndex = 9
        Me.lblTotal.Text = "Total Cost:"
        '
        'lblCost
        '
        Me.lblCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCost.Location = New System.Drawing.Point(212, 145)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(72, 19)
        Me.lblCost.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.lblCost, "Total Cost")
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 236)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.grpCosts)
        Me.Controls.Add(Me.grpLocation)
        Me.Controls.Add(Me.grpWorkshop)
        Me.Name = "frmMain"
        Me.Text = "Workshop Selector"
        Me.grpWorkshop.ResumeLayout(False)
        Me.grpLocation.ResumeLayout(False)
        Me.grpCosts.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpWorkshop As System.Windows.Forms.GroupBox
    Friend WithEvents lstWorkshop As System.Windows.Forms.ListBox
    Friend WithEvents grpLocation As System.Windows.Forms.GroupBox
    Friend WithEvents lstLocation As System.Windows.Forms.ListBox
    Friend WithEvents grpCosts As System.Windows.Forms.GroupBox
    Friend WithEvents lstCost As System.Windows.Forms.ListBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblCost As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
