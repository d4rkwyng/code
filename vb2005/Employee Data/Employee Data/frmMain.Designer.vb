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
        Me.grpEmpData = New System.Windows.Forms.GroupBox
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.lblEmail = New System.Windows.Forms.Label
        Me.txtExtension = New System.Windows.Forms.TextBox
        Me.lblExtension = New System.Windows.Forms.Label
        Me.txtTelephone = New System.Windows.Forms.TextBox
        Me.lblTelephone = New System.Windows.Forms.Label
        Me.cboDepartment = New System.Windows.Forms.ComboBox
        Me.lblDepartment = New System.Windows.Forms.Label
        Me.txtEmpNum = New System.Windows.Forms.TextBox
        Me.lblEmpNum = New System.Windows.Forms.Label
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.lblLastName = New System.Windows.Forms.Label
        Me.txtMidName = New System.Windows.Forms.TextBox
        Me.lblMidName = New System.Windows.Forms.Label
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.lblFirstName = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFileNew = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFileOpen = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFileSaveAs = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuToolsClear = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem
        Me.btnExit = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ofdOpenFile = New System.Windows.Forms.OpenFileDialog
        Me.sfdSaveFile = New System.Windows.Forms.SaveFileDialog
        Me.grpEmpData.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpEmpData
        '
        Me.grpEmpData.Controls.Add(Me.txtEmail)
        Me.grpEmpData.Controls.Add(Me.lblEmail)
        Me.grpEmpData.Controls.Add(Me.txtExtension)
        Me.grpEmpData.Controls.Add(Me.lblExtension)
        Me.grpEmpData.Controls.Add(Me.txtTelephone)
        Me.grpEmpData.Controls.Add(Me.lblTelephone)
        Me.grpEmpData.Controls.Add(Me.cboDepartment)
        Me.grpEmpData.Controls.Add(Me.lblDepartment)
        Me.grpEmpData.Controls.Add(Me.txtEmpNum)
        Me.grpEmpData.Controls.Add(Me.lblEmpNum)
        Me.grpEmpData.Controls.Add(Me.txtLastName)
        Me.grpEmpData.Controls.Add(Me.lblLastName)
        Me.grpEmpData.Controls.Add(Me.txtMidName)
        Me.grpEmpData.Controls.Add(Me.lblMidName)
        Me.grpEmpData.Controls.Add(Me.txtFirstName)
        Me.grpEmpData.Controls.Add(Me.lblFirstName)
        Me.grpEmpData.Location = New System.Drawing.Point(12, 27)
        Me.grpEmpData.Name = "grpEmpData"
        Me.grpEmpData.Size = New System.Drawing.Size(246, 253)
        Me.grpEmpData.TabIndex = 0
        Me.grpEmpData.TabStop = False
        Me.grpEmpData.Text = "Enter Employee Data"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(136, 212)
        Me.txtEmail.MaxLength = 255
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtEmail.TabIndex = 8
        '
        'lblEmail
        '
        Me.lblEmail.Location = New System.Drawing.Point(30, 215)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(100, 14)
        Me.lblEmail.TabIndex = 8
        Me.lblEmail.Text = "E-mail Address:"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtExtension
        '
        Me.txtExtension.Location = New System.Drawing.Point(136, 186)
        Me.txtExtension.MaxLength = 32
        Me.txtExtension.Name = "txtExtension"
        Me.txtExtension.Size = New System.Drawing.Size(100, 20)
        Me.txtExtension.TabIndex = 7
        '
        'lblExtension
        '
        Me.lblExtension.Location = New System.Drawing.Point(30, 189)
        Me.lblExtension.Name = "lblExtension"
        Me.lblExtension.Size = New System.Drawing.Size(100, 14)
        Me.lblExtension.TabIndex = 0
        Me.lblExtension.Text = "Extension:"
        Me.lblExtension.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(136, 160)
        Me.txtTelephone.MaxLength = 16
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(100, 20)
        Me.txtTelephone.TabIndex = 6
        '
        'lblTelephone
        '
        Me.lblTelephone.Location = New System.Drawing.Point(30, 163)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(100, 14)
        Me.lblTelephone.TabIndex = 0
        Me.lblTelephone.Text = "Telephone:"
        Me.lblTelephone.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cboDepartment
        '
        Me.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDepartment.FormattingEnabled = True
        Me.cboDepartment.Items.AddRange(New Object() {"Accounting", "Administration", "Marketing", "MIS", "Sales"})
        Me.cboDepartment.Location = New System.Drawing.Point(136, 133)
        Me.cboDepartment.Name = "cboDepartment"
        Me.cboDepartment.Size = New System.Drawing.Size(100, 21)
        Me.cboDepartment.TabIndex = 5
        '
        'lblDepartment
        '
        Me.lblDepartment.Location = New System.Drawing.Point(30, 136)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(100, 14)
        Me.lblDepartment.TabIndex = 0
        Me.lblDepartment.Text = "Department:"
        Me.lblDepartment.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtEmpNum
        '
        Me.txtEmpNum.Location = New System.Drawing.Point(136, 107)
        Me.txtEmpNum.MaxLength = 255
        Me.txtEmpNum.Name = "txtEmpNum"
        Me.txtEmpNum.Size = New System.Drawing.Size(100, 20)
        Me.txtEmpNum.TabIndex = 4
        '
        'lblEmpNum
        '
        Me.lblEmpNum.Location = New System.Drawing.Point(30, 110)
        Me.lblEmpNum.Name = "lblEmpNum"
        Me.lblEmpNum.Size = New System.Drawing.Size(100, 14)
        Me.lblEmpNum.TabIndex = 0
        Me.lblEmpNum.Text = "Employee Number:"
        Me.lblEmpNum.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(136, 81)
        Me.txtLastName.MaxLength = 32
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 3
        '
        'lblLastName
        '
        Me.lblLastName.Location = New System.Drawing.Point(30, 84)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(100, 14)
        Me.lblLastName.TabIndex = 0
        Me.lblLastName.Text = "Last Name:"
        Me.lblLastName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtMidName
        '
        Me.txtMidName.Location = New System.Drawing.Point(136, 55)
        Me.txtMidName.MaxLength = 32
        Me.txtMidName.Name = "txtMidName"
        Me.txtMidName.Size = New System.Drawing.Size(100, 20)
        Me.txtMidName.TabIndex = 2
        '
        'lblMidName
        '
        Me.lblMidName.Location = New System.Drawing.Point(30, 58)
        Me.lblMidName.Name = "lblMidName"
        Me.lblMidName.Size = New System.Drawing.Size(100, 14)
        Me.lblMidName.TabIndex = 0
        Me.lblMidName.Text = "Middle Name:"
        Me.lblMidName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(136, 29)
        Me.txtFirstName.MaxLength = 32
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 1
        '
        'lblFirstName
        '
        Me.lblFirstName.Location = New System.Drawing.Point(30, 32)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(100, 14)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "First Name:"
        Me.lblFirstName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(274, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileNew, Me.mnuFileOpen, Me.mnuFileSave, Me.mnuFileSaveAs, Me.ToolStripMenuItem1, Me.mnuFileExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'mnuFileNew
        '
        Me.mnuFileNew.Name = "mnuFileNew"
        Me.mnuFileNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuFileNew.Size = New System.Drawing.Size(163, 22)
        Me.mnuFileNew.Text = "New"
        '
        'mnuFileOpen
        '
        Me.mnuFileOpen.Name = "mnuFileOpen"
        Me.mnuFileOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuFileOpen.Size = New System.Drawing.Size(163, 22)
        Me.mnuFileOpen.Text = "Open..."
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Name = "mnuFileSave"
        Me.mnuFileSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuFileSave.Size = New System.Drawing.Size(163, 22)
        Me.mnuFileSave.Text = "Save"
        '
        'mnuFileSaveAs
        '
        Me.mnuFileSaveAs.Name = "mnuFileSaveAs"
        Me.mnuFileSaveAs.Size = New System.Drawing.Size(163, 22)
        Me.mnuFileSaveAs.Text = "Save As..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(160, 6)
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(163, 22)
        Me.mnuFileExit.Text = "Exit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuToolsClear})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'mnuToolsClear
        '
        Me.mnuToolsClear.Name = "mnuToolsClear"
        Me.mnuToolsClear.Size = New System.Drawing.Size(110, 22)
        Me.mnuToolsClear.Text = "Clear"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpAbout})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.Size = New System.Drawing.Size(114, 22)
        Me.mnuHelpAbout.Text = "About"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(183, 286)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'ofdOpenFile
        '
        Me.ofdOpenFile.FileName = "OpenFileDialog1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 320)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.grpEmpData)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Employee Data"
        Me.grpEmpData.ResumeLayout(False)
        Me.grpEmpData.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpEmpData As System.Windows.Forms.GroupBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents txtMidName As System.Windows.Forms.TextBox
    Friend WithEvents lblMidName As System.Windows.Forms.Label
    Friend WithEvents cboDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
    Friend WithEvents txtEmpNum As System.Windows.Forms.TextBox
    Friend WithEvents lblEmpNum As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents txtTelephone As System.Windows.Forms.TextBox
    Friend WithEvents lblTelephone As System.Windows.Forms.Label
    Friend WithEvents txtExtension As System.Windows.Forms.TextBox
    Friend WithEvents lblExtension As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileSaveAs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuToolsClear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ofdOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sfdSaveFile As System.Windows.Forms.SaveFileDialog

End Class
