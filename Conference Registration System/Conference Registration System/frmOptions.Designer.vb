<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOptions
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
        Me.grpConf = New System.Windows.Forms.GroupBox
        Me.chkDinner = New System.Windows.Forms.CheckBox
        Me.chkConfReg = New System.Windows.Forms.CheckBox
        Me.grpPreConf = New System.Windows.Forms.GroupBox
        Me.lblSelect = New System.Windows.Forms.Label
        Me.lstWorkshop = New System.Windows.Forms.ListBox
        Me.btnReset = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpConf.SuspendLayout()
        Me.grpPreConf.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpConf
        '
        Me.grpConf.Controls.Add(Me.chkDinner)
        Me.grpConf.Controls.Add(Me.chkConfReg)
        Me.grpConf.Location = New System.Drawing.Point(13, 13)
        Me.grpConf.Name = "grpConf"
        Me.grpConf.Size = New System.Drawing.Size(200, 89)
        Me.grpConf.TabIndex = 0
        Me.grpConf.TabStop = False
        Me.grpConf.Text = "Conference"
        '
        'chkDinner
        '
        Me.chkDinner.Location = New System.Drawing.Point(17, 43)
        Me.chkDinner.Name = "chkDinner"
        Me.chkDinner.Size = New System.Drawing.Size(146, 35)
        Me.chkDinner.TabIndex = 1
        Me.chkDinner.Text = "Opening Night Dinner && Keynote: $30"
        Me.ToolTip1.SetToolTip(Me.chkDinner, "Opening Night Dinner & KeyNote")
        Me.chkDinner.UseVisualStyleBackColor = True
        '
        'chkConfReg
        '
        Me.chkConfReg.AutoSize = True
        Me.chkConfReg.Location = New System.Drawing.Point(17, 20)
        Me.chkConfReg.Name = "chkConfReg"
        Me.chkConfReg.Size = New System.Drawing.Size(170, 17)
        Me.chkConfReg.TabIndex = 0
        Me.chkConfReg.Text = "Conference Registration: $895"
        Me.ToolTip1.SetToolTip(Me.chkConfReg, "Conference Registration Fee")
        Me.chkConfReg.UseVisualStyleBackColor = True
        '
        'grpPreConf
        '
        Me.grpPreConf.Controls.Add(Me.lblSelect)
        Me.grpPreConf.Controls.Add(Me.lstWorkshop)
        Me.grpPreConf.Location = New System.Drawing.Point(220, 13)
        Me.grpPreConf.Name = "grpPreConf"
        Me.grpPreConf.Size = New System.Drawing.Size(169, 89)
        Me.grpPreConf.TabIndex = 1
        Me.grpPreConf.TabStop = False
        Me.grpPreConf.Text = "Preconference Workshops"
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Location = New System.Drawing.Point(12, 20)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(60, 13)
        Me.lblSelect.TabIndex = 1
        Me.lblSelect.Text = "Select One"
        '
        'lstWorkshop
        '
        Me.lstWorkshop.Enabled = False
        Me.lstWorkshop.FormattingEnabled = True
        Me.lstWorkshop.Items.AddRange(New Object() {"Intro to E-Commerce", "The Future of the Web", "Advanced Visual Basic", "Network Security"})
        Me.lstWorkshop.Location = New System.Drawing.Point(15, 36)
        Me.lstWorkshop.Name = "lstWorkshop"
        Me.lstWorkshop.Size = New System.Drawing.Size(143, 43)
        Me.lstWorkshop.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.lstWorkshop, "Available Workshops")
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(233, 108)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "&Reset"
        Me.ToolTip1.SetToolTip(Me.btnReset, "Clear this Form")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(314, 108)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "&Close"
        Me.ToolTip1.SetToolTip(Me.btnClose, "Calculate the Total and Close this Form")
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 137)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.grpPreConf)
        Me.Controls.Add(Me.grpConf)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmOptions"
        Me.Text = "Conference Options"
        Me.grpConf.ResumeLayout(False)
        Me.grpConf.PerformLayout()
        Me.grpPreConf.ResumeLayout(False)
        Me.grpPreConf.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpConf As System.Windows.Forms.GroupBox
    Friend WithEvents chkDinner As System.Windows.Forms.CheckBox
    Friend WithEvents chkConfReg As System.Windows.Forms.CheckBox
    Friend WithEvents grpPreConf As System.Windows.Forms.GroupBox
    Friend WithEvents lblSelect As System.Windows.Forms.Label
    Friend WithEvents lstWorkshop As System.Windows.Forms.ListBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
