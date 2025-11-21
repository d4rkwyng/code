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
        Me.grpReg = New System.Windows.Forms.GroupBox
        Me.lblState = New System.Windows.Forms.Label
        Me.lblZip = New System.Windows.Forms.Label
        Me.lblEmail = New System.Windows.Forms.Label
        Me.lblPhone = New System.Windows.Forms.Label
        Me.lblCity = New System.Windows.Forms.Label
        Me.lblAddress = New System.Windows.Forms.Label
        Me.lblCompany = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.txtState = New System.Windows.Forms.TextBox
        Me.txtZip = New System.Windows.Forms.TextBox
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.txtPhone = New System.Windows.Forms.TextBox
        Me.txtCity = New System.Windows.Forms.TextBox
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.txtCompany = New System.Windows.Forms.TextBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.lblCost = New System.Windows.Forms.Label
        Me.btnOptions = New System.Windows.Forms.Button
        Me.btnReset = New System.Windows.Forms.Button
        Me.brnExit = New System.Windows.Forms.Button
        Me.lblOutput = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.grpReg.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpReg
        '
        Me.grpReg.Controls.Add(Me.lblState)
        Me.grpReg.Controls.Add(Me.lblZip)
        Me.grpReg.Controls.Add(Me.lblEmail)
        Me.grpReg.Controls.Add(Me.lblPhone)
        Me.grpReg.Controls.Add(Me.lblCity)
        Me.grpReg.Controls.Add(Me.lblAddress)
        Me.grpReg.Controls.Add(Me.lblCompany)
        Me.grpReg.Controls.Add(Me.lblName)
        Me.grpReg.Controls.Add(Me.txtState)
        Me.grpReg.Controls.Add(Me.txtZip)
        Me.grpReg.Controls.Add(Me.txtEmail)
        Me.grpReg.Controls.Add(Me.txtPhone)
        Me.grpReg.Controls.Add(Me.txtCity)
        Me.grpReg.Controls.Add(Me.txtAddress)
        Me.grpReg.Controls.Add(Me.txtCompany)
        Me.grpReg.Controls.Add(Me.txtName)
        Me.grpReg.Location = New System.Drawing.Point(8, 27)
        Me.grpReg.Name = "grpReg"
        Me.grpReg.Size = New System.Drawing.Size(366, 128)
        Me.grpReg.TabIndex = 0
        Me.grpReg.TabStop = False
        Me.grpReg.Text = "Registrant"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(169, 103)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(32, 13)
        Me.lblState.TabIndex = 15
        Me.lblState.Text = "State"
        Me.ToolTip1.SetToolTip(Me.lblState, "State")
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Location = New System.Drawing.Point(262, 103)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(22, 13)
        Me.lblZip.TabIndex = 14
        Me.lblZip.Text = "Zip"
        Me.ToolTip1.SetToolTip(Me.lblZip, "Zip Code")
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(188, 49)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 13
        Me.lblEmail.Text = "Email"
        Me.ToolTip1.SetToolTip(Me.lblEmail, "Email Address")
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(188, 22)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(38, 13)
        Me.lblPhone.TabIndex = 12
        Me.lblPhone.Text = "Phone"
        Me.ToolTip1.SetToolTip(Me.lblPhone, "Phone Number")
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(9, 103)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(24, 13)
        Me.lblCity.TabIndex = 11
        Me.lblCity.Text = "City"
        Me.ToolTip1.SetToolTip(Me.lblCity, "City")
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(9, 76)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(45, 13)
        Me.lblAddress.TabIndex = 10
        Me.lblAddress.Text = "Address"
        Me.ToolTip1.SetToolTip(Me.lblAddress, "Address")
        '
        'lblCompany
        '
        Me.lblCompany.AutoSize = True
        Me.lblCompany.Location = New System.Drawing.Point(9, 49)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(51, 13)
        Me.lblCompany.TabIndex = 9
        Me.lblCompany.Text = "Company"
        Me.ToolTip1.SetToolTip(Me.lblCompany, "Company (Optional)")
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(9, 22)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "Name"
        Me.ToolTip1.SetToolTip(Me.lblName, "Name")
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(201, 100)
        Me.txtState.MaxLength = 2
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(40, 20)
        Me.txtState.TabIndex = 6
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(290, 100)
        Me.txtZip.MaxLength = 12
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(69, 20)
        Me.txtZip.TabIndex = 7
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(233, 46)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtEmail.TabIndex = 5
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(234, 19)
        Me.txtPhone.MaxLength = 15
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(100, 20)
        Me.txtPhone.TabIndex = 4
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(63, 100)
        Me.txtCity.MaxLength = 50
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(100, 20)
        Me.txtCity.TabIndex = 3
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(63, 73)
        Me.txtAddress.MaxLength = 100
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(100, 20)
        Me.txtAddress.TabIndex = 2
        '
        'txtCompany
        '
        Me.txtCompany.Location = New System.Drawing.Point(63, 46)
        Me.txtCompany.MaxLength = 50
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(100, 20)
        Me.txtCompany.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(63, 19)
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 0
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(220, 168)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(58, 13)
        Me.lblCost.TabIndex = 2
        Me.lblCost.Text = "Total Cost:"
        Me.ToolTip1.SetToolTip(Me.lblCost, "Total Cost")
        '
        'btnOptions
        '
        Me.btnOptions.Location = New System.Drawing.Point(8, 208)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(115, 45)
        Me.btnOptions.TabIndex = 8
        Me.btnOptions.Text = "&Select Conference Options"
        Me.ToolTip1.SetToolTip(Me.btnOptions, "Open the Conference Options")
        Me.btnOptions.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(134, 208)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(115, 45)
        Me.btnReset.TabIndex = 9
        Me.btnReset.Text = "&Reset"
        Me.ToolTip1.SetToolTip(Me.btnReset, "Clear this Form")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'brnExit
        '
        Me.brnExit.Location = New System.Drawing.Point(259, 208)
        Me.brnExit.Name = "brnExit"
        Me.brnExit.Size = New System.Drawing.Size(115, 45)
        Me.brnExit.TabIndex = 10
        Me.brnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.brnExit, "Exit the Application")
        Me.brnExit.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Location = New System.Drawing.Point(284, 167)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(72, 16)
        Me.lblOutput.TabIndex = 6
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(386, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetToolStripMenuItem, Me.ToolStripMenuItem1, Me.OptionsToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ResetToolStripMenuItem.Text = "&Reset"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(119, 6)
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 264)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.brnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnOptions)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.grpReg)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Conference Registration System"
        Me.grpReg.ResumeLayout(False)
        Me.grpReg.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpReg As System.Windows.Forms.GroupBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblCompany As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtCompany As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblCost As System.Windows.Forms.Label
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents lblZip As System.Windows.Forms.Label
    Friend WithEvents btnOptions As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents brnExit As System.Windows.Forms.Button
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
