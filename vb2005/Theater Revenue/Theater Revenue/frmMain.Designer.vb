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
        Me.grpAdult = New System.Windows.Forms.GroupBox
        Me.txtASold = New System.Windows.Forms.TextBox
        Me.txtAPrice = New System.Windows.Forms.TextBox
        Me.lblASold = New System.Windows.Forms.Label
        Me.lblAPrice = New System.Windows.Forms.Label
        Me.grpChild = New System.Windows.Forms.GroupBox
        Me.txtCSold = New System.Windows.Forms.TextBox
        Me.txtCPrice = New System.Windows.Forms.TextBox
        Me.lblCSold = New System.Windows.Forms.Label
        Me.lblCPrice = New System.Windows.Forms.Label
        Me.grpGross = New System.Windows.Forms.GroupBox
        Me.txtGTotal = New System.Windows.Forms.TextBox
        Me.txtGChild = New System.Windows.Forms.TextBox
        Me.txtGAdult = New System.Windows.Forms.TextBox
        Me.lblGTotal = New System.Windows.Forms.Label
        Me.lblGChild = New System.Windows.Forms.Label
        Me.lblGAdult = New System.Windows.Forms.Label
        Me.grpNet = New System.Windows.Forms.GroupBox
        Me.txtNTotal = New System.Windows.Forms.TextBox
        Me.txtNChild = New System.Windows.Forms.TextBox
        Me.txtNAdult = New System.Windows.Forms.TextBox
        Me.lblNTotal = New System.Windows.Forms.Label
        Me.lblNChild = New System.Windows.Forms.Label
        Me.lblNAdult = New System.Windows.Forms.Label
        Me.btnCalc = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.grpAdult.SuspendLayout()
        Me.grpChild.SuspendLayout()
        Me.grpGross.SuspendLayout()
        Me.grpNet.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpAdult
        '
        Me.grpAdult.Controls.Add(Me.txtASold)
        Me.grpAdult.Controls.Add(Me.txtAPrice)
        Me.grpAdult.Controls.Add(Me.lblASold)
        Me.grpAdult.Controls.Add(Me.lblAPrice)
        Me.grpAdult.Location = New System.Drawing.Point(12, 12)
        Me.grpAdult.Name = "grpAdult"
        Me.grpAdult.Size = New System.Drawing.Size(200, 84)
        Me.grpAdult.TabIndex = 0
        Me.grpAdult.TabStop = False
        Me.grpAdult.Text = "Adult Ticket Sales"
        '
        'txtASold
        '
        Me.txtASold.Location = New System.Drawing.Point(105, 49)
        Me.txtASold.Name = "txtASold"
        Me.txtASold.Size = New System.Drawing.Size(89, 20)
        Me.txtASold.TabIndex = 4
        Me.txtASold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAPrice
        '
        Me.txtAPrice.Location = New System.Drawing.Point(105, 23)
        Me.txtAPrice.Name = "txtAPrice"
        Me.txtAPrice.Size = New System.Drawing.Size(89, 20)
        Me.txtAPrice.TabIndex = 3
        Me.txtAPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblASold
        '
        Me.lblASold.AutoSize = True
        Me.lblASold.Location = New System.Drawing.Point(6, 52)
        Me.lblASold.Name = "lblASold"
        Me.lblASold.Size = New System.Drawing.Size(66, 13)
        Me.lblASold.TabIndex = 2
        Me.lblASold.Text = "Tickets Sold"
        '
        'lblAPrice
        '
        Me.lblAPrice.AutoSize = True
        Me.lblAPrice.Location = New System.Drawing.Point(6, 26)
        Me.lblAPrice.Name = "lblAPrice"
        Me.lblAPrice.Size = New System.Drawing.Size(83, 13)
        Me.lblAPrice.TabIndex = 1
        Me.lblAPrice.Text = "Price Per Ticket"
        '
        'grpChild
        '
        Me.grpChild.Controls.Add(Me.txtCSold)
        Me.grpChild.Controls.Add(Me.txtCPrice)
        Me.grpChild.Controls.Add(Me.lblCSold)
        Me.grpChild.Controls.Add(Me.lblCPrice)
        Me.grpChild.Location = New System.Drawing.Point(231, 12)
        Me.grpChild.Name = "grpChild"
        Me.grpChild.Size = New System.Drawing.Size(200, 84)
        Me.grpChild.TabIndex = 1
        Me.grpChild.TabStop = False
        Me.grpChild.Text = "Child Ticket Sales"
        '
        'txtCSold
        '
        Me.txtCSold.Location = New System.Drawing.Point(104, 49)
        Me.txtCSold.Name = "txtCSold"
        Me.txtCSold.Size = New System.Drawing.Size(90, 20)
        Me.txtCSold.TabIndex = 6
        Me.txtCSold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCPrice
        '
        Me.txtCPrice.Location = New System.Drawing.Point(104, 23)
        Me.txtCPrice.Name = "txtCPrice"
        Me.txtCPrice.Size = New System.Drawing.Size(90, 20)
        Me.txtCPrice.TabIndex = 5
        Me.txtCPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCSold
        '
        Me.lblCSold.AutoSize = True
        Me.lblCSold.Location = New System.Drawing.Point(6, 52)
        Me.lblCSold.Name = "lblCSold"
        Me.lblCSold.Size = New System.Drawing.Size(66, 13)
        Me.lblCSold.TabIndex = 4
        Me.lblCSold.Text = "Tickets Sold"
        '
        'lblCPrice
        '
        Me.lblCPrice.AutoSize = True
        Me.lblCPrice.Location = New System.Drawing.Point(6, 26)
        Me.lblCPrice.Name = "lblCPrice"
        Me.lblCPrice.Size = New System.Drawing.Size(83, 13)
        Me.lblCPrice.TabIndex = 3
        Me.lblCPrice.Text = "Price Per Ticket"
        '
        'grpGross
        '
        Me.grpGross.Controls.Add(Me.txtGTotal)
        Me.grpGross.Controls.Add(Me.txtGChild)
        Me.grpGross.Controls.Add(Me.txtGAdult)
        Me.grpGross.Controls.Add(Me.lblGTotal)
        Me.grpGross.Controls.Add(Me.lblGChild)
        Me.grpGross.Controls.Add(Me.lblGAdult)
        Me.grpGross.Location = New System.Drawing.Point(12, 102)
        Me.grpGross.Name = "grpGross"
        Me.grpGross.Size = New System.Drawing.Size(200, 113)
        Me.grpGross.TabIndex = 1
        Me.grpGross.TabStop = False
        Me.grpGross.Text = "Gross Ticket Revenue"
        '
        'txtGTotal
        '
        Me.txtGTotal.Location = New System.Drawing.Point(104, 78)
        Me.txtGTotal.Name = "txtGTotal"
        Me.txtGTotal.ReadOnly = True
        Me.txtGTotal.Size = New System.Drawing.Size(89, 20)
        Me.txtGTotal.TabIndex = 5
        Me.txtGTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGChild
        '
        Me.txtGChild.Location = New System.Drawing.Point(104, 52)
        Me.txtGChild.Name = "txtGChild"
        Me.txtGChild.ReadOnly = True
        Me.txtGChild.Size = New System.Drawing.Size(89, 20)
        Me.txtGChild.TabIndex = 4
        Me.txtGChild.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGAdult
        '
        Me.txtGAdult.Location = New System.Drawing.Point(105, 26)
        Me.txtGAdult.Name = "txtGAdult"
        Me.txtGAdult.ReadOnly = True
        Me.txtGAdult.Size = New System.Drawing.Size(89, 20)
        Me.txtGAdult.TabIndex = 3
        Me.txtGAdult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblGTotal
        '
        Me.lblGTotal.Location = New System.Drawing.Point(6, 75)
        Me.lblGTotal.Name = "lblGTotal"
        Me.lblGTotal.Size = New System.Drawing.Size(100, 29)
        Me.lblGTotal.TabIndex = 2
        Me.lblGTotal.Text = "Total Gross Revenue for Ticket"
        '
        'lblGChild
        '
        Me.lblGChild.AutoSize = True
        Me.lblGChild.Location = New System.Drawing.Point(6, 55)
        Me.lblGChild.Name = "lblGChild"
        Me.lblGChild.Size = New System.Drawing.Size(92, 13)
        Me.lblGChild.TabIndex = 1
        Me.lblGChild.Text = "Child Ticket Sales"
        '
        'lblGAdult
        '
        Me.lblGAdult.AutoSize = True
        Me.lblGAdult.Location = New System.Drawing.Point(6, 29)
        Me.lblGAdult.Name = "lblGAdult"
        Me.lblGAdult.Size = New System.Drawing.Size(93, 13)
        Me.lblGAdult.TabIndex = 0
        Me.lblGAdult.Text = "Adult Ticket Sales"
        '
        'grpNet
        '
        Me.grpNet.Controls.Add(Me.txtNTotal)
        Me.grpNet.Controls.Add(Me.txtNChild)
        Me.grpNet.Controls.Add(Me.txtNAdult)
        Me.grpNet.Controls.Add(Me.lblNTotal)
        Me.grpNet.Controls.Add(Me.lblNChild)
        Me.grpNet.Controls.Add(Me.lblNAdult)
        Me.grpNet.Location = New System.Drawing.Point(231, 102)
        Me.grpNet.Name = "grpNet"
        Me.grpNet.Size = New System.Drawing.Size(200, 113)
        Me.grpNet.TabIndex = 1
        Me.grpNet.TabStop = False
        Me.grpNet.Text = "Net Ticket Revenue"
        '
        'txtNTotal
        '
        Me.txtNTotal.Location = New System.Drawing.Point(104, 78)
        Me.txtNTotal.Name = "txtNTotal"
        Me.txtNTotal.ReadOnly = True
        Me.txtNTotal.Size = New System.Drawing.Size(89, 20)
        Me.txtNTotal.TabIndex = 11
        Me.txtNTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNChild
        '
        Me.txtNChild.Location = New System.Drawing.Point(104, 52)
        Me.txtNChild.Name = "txtNChild"
        Me.txtNChild.ReadOnly = True
        Me.txtNChild.Size = New System.Drawing.Size(89, 20)
        Me.txtNChild.TabIndex = 10
        Me.txtNChild.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNAdult
        '
        Me.txtNAdult.Location = New System.Drawing.Point(105, 26)
        Me.txtNAdult.Name = "txtNAdult"
        Me.txtNAdult.ReadOnly = True
        Me.txtNAdult.Size = New System.Drawing.Size(89, 20)
        Me.txtNAdult.TabIndex = 9
        Me.txtNAdult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNTotal
        '
        Me.lblNTotal.Location = New System.Drawing.Point(6, 75)
        Me.lblNTotal.Name = "lblNTotal"
        Me.lblNTotal.Size = New System.Drawing.Size(100, 29)
        Me.lblNTotal.TabIndex = 5
        Me.lblNTotal.Text = "Total Gross Revenue for Ticket"
        '
        'lblNChild
        '
        Me.lblNChild.AutoSize = True
        Me.lblNChild.Location = New System.Drawing.Point(6, 55)
        Me.lblNChild.Name = "lblNChild"
        Me.lblNChild.Size = New System.Drawing.Size(92, 13)
        Me.lblNChild.TabIndex = 4
        Me.lblNChild.Text = "Child Ticket Sales"
        '
        'lblNAdult
        '
        Me.lblNAdult.AutoSize = True
        Me.lblNAdult.Location = New System.Drawing.Point(6, 26)
        Me.lblNAdult.Name = "lblNAdult"
        Me.lblNAdult.Size = New System.Drawing.Size(93, 13)
        Me.lblNAdult.TabIndex = 3
        Me.lblNAdult.Text = "Adult Ticket Sales"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(12, 221)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(148, 23)
        Me.btnCalc.TabIndex = 2
        Me.btnCalc.Text = "Calculate &Ticket Revenue"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(356, 221)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(184, 221)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 254)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.grpNet)
        Me.Controls.Add(Me.grpGross)
        Me.Controls.Add(Me.grpChild)
        Me.Controls.Add(Me.grpAdult)
        Me.Name = "frmMain"
        Me.Text = "Theater Revenue"
        Me.grpAdult.ResumeLayout(False)
        Me.grpAdult.PerformLayout()
        Me.grpChild.ResumeLayout(False)
        Me.grpChild.PerformLayout()
        Me.grpGross.ResumeLayout(False)
        Me.grpGross.PerformLayout()
        Me.grpNet.ResumeLayout(False)
        Me.grpNet.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpAdult As System.Windows.Forms.GroupBox
    Friend WithEvents grpChild As System.Windows.Forms.GroupBox
    Friend WithEvents grpGross As System.Windows.Forms.GroupBox
    Friend WithEvents grpNet As System.Windows.Forms.GroupBox
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblAPrice As System.Windows.Forms.Label
    Friend WithEvents lblASold As System.Windows.Forms.Label
    Friend WithEvents lblCSold As System.Windows.Forms.Label
    Friend WithEvents lblCPrice As System.Windows.Forms.Label
    Friend WithEvents txtASold As System.Windows.Forms.TextBox
    Friend WithEvents txtAPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtCSold As System.Windows.Forms.TextBox
    Friend WithEvents txtCPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblGTotal As System.Windows.Forms.Label
    Friend WithEvents lblGChild As System.Windows.Forms.Label
    Friend WithEvents lblGAdult As System.Windows.Forms.Label
    Friend WithEvents lblNTotal As System.Windows.Forms.Label
    Friend WithEvents lblNChild As System.Windows.Forms.Label
    Friend WithEvents lblNAdult As System.Windows.Forms.Label
    Friend WithEvents txtGTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtGChild As System.Windows.Forms.TextBox
    Friend WithEvents txtGAdult As System.Windows.Forms.TextBox
    Friend WithEvents txtNTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtNChild As System.Windows.Forms.TextBox
    Friend WithEvents txtNAdult As System.Windows.Forms.TextBox

End Class
