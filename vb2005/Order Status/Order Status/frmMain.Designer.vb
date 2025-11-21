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
        Me.grpOrder = New System.Windows.Forms.GroupBox
        Me.chkRush = New System.Windows.Forms.CheckBox
        Me.txtInput = New System.Windows.Forms.TextBox
        Me.lblNumSpools = New System.Windows.Forms.Label
        Me.grpDelivery = New System.Windows.Forms.GroupBox
        Me.lblTotal = New System.Windows.Forms.Label
        Me.lblShipping = New System.Windows.Forms.Label
        Me.lblSpoolsOn = New System.Windows.Forms.Label
        Me.lblSpoolsReady = New System.Windows.Forms.Label
        Me.lblDue = New System.Windows.Forms.Label
        Me.lblHandling = New System.Windows.Forms.Label
        Me.lblBackOrder = New System.Windows.Forms.Label
        Me.lblToShip = New System.Windows.Forms.Label
        Me.btnCalc = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpOrder.SuspendLayout()
        Me.grpDelivery.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpOrder
        '
        Me.grpOrder.Controls.Add(Me.chkRush)
        Me.grpOrder.Controls.Add(Me.txtInput)
        Me.grpOrder.Controls.Add(Me.lblNumSpools)
        Me.grpOrder.Location = New System.Drawing.Point(12, 12)
        Me.grpOrder.Name = "grpOrder"
        Me.grpOrder.Size = New System.Drawing.Size(235, 100)
        Me.grpOrder.TabIndex = 0
        Me.grpOrder.TabStop = False
        Me.grpOrder.Text = "Order Information"
        '
        'chkRush
        '
        Me.chkRush.AutoSize = True
        Me.chkRush.Location = New System.Drawing.Point(13, 66)
        Me.chkRush.Name = "chkRush"
        Me.chkRush.Size = New System.Drawing.Size(92, 17)
        Me.chkRush.TabIndex = 2
        Me.chkRush.Text = "&Rush Delivery"
        Me.ToolTip1.SetToolTip(Me.chkRush, "Schedule rush delivery ($15)")
        Me.chkRush.UseVisualStyleBackColor = True
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(97, 38)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 20)
        Me.txtInput.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtInput, "Enter the Number of Spools you wish to order.")
        '
        'lblNumSpools
        '
        Me.lblNumSpools.Location = New System.Drawing.Point(13, 32)
        Me.lblNumSpools.Name = "lblNumSpools"
        Me.lblNumSpools.Size = New System.Drawing.Size(81, 26)
        Me.lblNumSpools.TabIndex = 0
        Me.lblNumSpools.Text = "Number of Spools Ordered"
        Me.lblNumSpools.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'grpDelivery
        '
        Me.grpDelivery.Controls.Add(Me.lblTotal)
        Me.grpDelivery.Controls.Add(Me.lblShipping)
        Me.grpDelivery.Controls.Add(Me.lblSpoolsOn)
        Me.grpDelivery.Controls.Add(Me.lblSpoolsReady)
        Me.grpDelivery.Controls.Add(Me.lblDue)
        Me.grpDelivery.Controls.Add(Me.lblHandling)
        Me.grpDelivery.Controls.Add(Me.lblBackOrder)
        Me.grpDelivery.Controls.Add(Me.lblToShip)
        Me.grpDelivery.Location = New System.Drawing.Point(12, 118)
        Me.grpDelivery.Name = "grpDelivery"
        Me.grpDelivery.Size = New System.Drawing.Size(235, 94)
        Me.grpDelivery.TabIndex = 1
        Me.grpDelivery.TabStop = False
        Me.grpDelivery.Text = "Delivery Information"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(6, 71)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(57, 13)
        Me.lblTotal.TabIndex = 7
        Me.lblTotal.Text = "Total Due:"
        '
        'lblShipping
        '
        Me.lblShipping.AutoSize = True
        Me.lblShipping.Location = New System.Drawing.Point(6, 54)
        Me.lblShipping.Name = "lblShipping"
        Me.lblShipping.Size = New System.Drawing.Size(105, 13)
        Me.lblShipping.TabIndex = 6
        Me.lblShipping.Text = "Shipping && Handling:"
        '
        'lblSpoolsOn
        '
        Me.lblSpoolsOn.AutoSize = True
        Me.lblSpoolsOn.Location = New System.Drawing.Point(6, 37)
        Me.lblSpoolsOn.Name = "lblSpoolsOn"
        Me.lblSpoolsOn.Size = New System.Drawing.Size(114, 13)
        Me.lblSpoolsOn.TabIndex = 5
        Me.lblSpoolsOn.Text = "Spools on Back Order:"
        '
        'lblSpoolsReady
        '
        Me.lblSpoolsReady.AutoSize = True
        Me.lblSpoolsReady.Location = New System.Drawing.Point(6, 18)
        Me.lblSpoolsReady.Name = "lblSpoolsReady"
        Me.lblSpoolsReady.Size = New System.Drawing.Size(112, 13)
        Me.lblSpoolsReady.TabIndex = 4
        Me.lblSpoolsReady.Text = "Spools Ready to Ship:"
        '
        'lblDue
        '
        Me.lblDue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDue.Location = New System.Drawing.Point(129, 70)
        Me.lblDue.Name = "lblDue"
        Me.lblDue.Size = New System.Drawing.Size(100, 17)
        Me.lblDue.TabIndex = 3
        '
        'lblHandling
        '
        Me.lblHandling.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHandling.Location = New System.Drawing.Point(129, 53)
        Me.lblHandling.Name = "lblHandling"
        Me.lblHandling.Size = New System.Drawing.Size(100, 17)
        Me.lblHandling.TabIndex = 2
        '
        'lblBackOrder
        '
        Me.lblBackOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBackOrder.Location = New System.Drawing.Point(129, 36)
        Me.lblBackOrder.Name = "lblBackOrder"
        Me.lblBackOrder.Size = New System.Drawing.Size(100, 17)
        Me.lblBackOrder.TabIndex = 1
        '
        'lblToShip
        '
        Me.lblToShip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblToShip.Location = New System.Drawing.Point(129, 17)
        Me.lblToShip.Name = "lblToShip"
        Me.lblToShip.Size = New System.Drawing.Size(100, 19)
        Me.lblToShip.TabIndex = 0
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(31, 218)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 2
        Me.btnCalc.Text = "&Calculate Total"
        Me.ToolTip1.SetToolTip(Me.btnCalc, "Calculate the totals")
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(151, 218)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "C&lear Form"
        Me.ToolTip1.SetToolTip(Me.btnClear, "Clear the forms")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(87, 247)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Exit the Application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 281)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.grpDelivery)
        Me.Controls.Add(Me.grpOrder)
        Me.Name = "frmMain"
        Me.Text = "Order Status"
        Me.grpOrder.ResumeLayout(False)
        Me.grpOrder.PerformLayout()
        Me.grpDelivery.ResumeLayout(False)
        Me.grpDelivery.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpOrder As System.Windows.Forms.GroupBox
    Friend WithEvents chkRush As System.Windows.Forms.CheckBox
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents lblNumSpools As System.Windows.Forms.Label
    Friend WithEvents grpDelivery As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblShipping As System.Windows.Forms.Label
    Friend WithEvents lblSpoolsOn As System.Windows.Forms.Label
    Friend WithEvents lblSpoolsReady As System.Windows.Forms.Label
    Friend WithEvents lblDue As System.Windows.Forms.Label
    Friend WithEvents lblHandling As System.Windows.Forms.Label
    Friend WithEvents lblBackOrder As System.Windows.Forms.Label
    Friend WithEvents lblToShip As System.Windows.Forms.Label
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
