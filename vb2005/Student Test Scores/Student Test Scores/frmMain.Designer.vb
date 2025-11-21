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
        Me.mnuStrip = New System.Windows.Forms.MenuStrip
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFileNew = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFileOpen = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFileSaveAs = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuFilePrint = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuReport = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuReportPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuHelpDebug = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuHelpDebugOn = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuHelpDebugOff = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem
        Me.grpStudentData = New System.Windows.Forms.GroupBox
        Me.grpReport = New System.Windows.Forms.GroupBox
        Me.txtReport = New System.Windows.Forms.TextBox
        Me.lblAverage = New System.Windows.Forms.Label
        Me.lblTestScores = New System.Windows.Forms.Label
        Me.txtAvg6 = New System.Windows.Forms.TextBox
        Me.txtR6C5 = New System.Windows.Forms.TextBox
        Me.txtR6C4 = New System.Windows.Forms.TextBox
        Me.txtR6C3 = New System.Windows.Forms.TextBox
        Me.txtR6C2 = New System.Windows.Forms.TextBox
        Me.txtR6C1 = New System.Windows.Forms.TextBox
        Me.txtAvg5 = New System.Windows.Forms.TextBox
        Me.txtR5C5 = New System.Windows.Forms.TextBox
        Me.txtR5C4 = New System.Windows.Forms.TextBox
        Me.txtR5C3 = New System.Windows.Forms.TextBox
        Me.txtR5C2 = New System.Windows.Forms.TextBox
        Me.txtR5C1 = New System.Windows.Forms.TextBox
        Me.txtAvg4 = New System.Windows.Forms.TextBox
        Me.txtR4C5 = New System.Windows.Forms.TextBox
        Me.txtR4C4 = New System.Windows.Forms.TextBox
        Me.txtR4C3 = New System.Windows.Forms.TextBox
        Me.txtR4C2 = New System.Windows.Forms.TextBox
        Me.txtR4C1 = New System.Windows.Forms.TextBox
        Me.txtAvg3 = New System.Windows.Forms.TextBox
        Me.txtR3C5 = New System.Windows.Forms.TextBox
        Me.txtR3C4 = New System.Windows.Forms.TextBox
        Me.txtR3C3 = New System.Windows.Forms.TextBox
        Me.txtR3C2 = New System.Windows.Forms.TextBox
        Me.txtR3C1 = New System.Windows.Forms.TextBox
        Me.txtAvg2 = New System.Windows.Forms.TextBox
        Me.txtR2C5 = New System.Windows.Forms.TextBox
        Me.txtR2C4 = New System.Windows.Forms.TextBox
        Me.txtR2C3 = New System.Windows.Forms.TextBox
        Me.txtR2C2 = New System.Windows.Forms.TextBox
        Me.txtR2C1 = New System.Windows.Forms.TextBox
        Me.txtAvg1 = New System.Windows.Forms.TextBox
        Me.txtR1C5 = New System.Windows.Forms.TextBox
        Me.txtR1C4 = New System.Windows.Forms.TextBox
        Me.txtR1C3 = New System.Windows.Forms.TextBox
        Me.txtR1C2 = New System.Windows.Forms.TextBox
        Me.txtR1C1 = New System.Windows.Forms.TextBox
        Me.txtName6 = New System.Windows.Forms.TextBox
        Me.txtName5 = New System.Windows.Forms.TextBox
        Me.txtName4 = New System.Windows.Forms.TextBox
        Me.txtName3 = New System.Windows.Forms.TextBox
        Me.txtName2 = New System.Windows.Forms.TextBox
        Me.txtName1 = New System.Windows.Forms.TextBox
        Me.lblName = New System.Windows.Forms.Label
        Me.btnCalc = New System.Windows.Forms.Button
        Me.btnHide = New System.Windows.Forms.Button
        Me.ofdOpenFile = New System.Windows.Forms.OpenFileDialog
        Me.sfdSaveFile = New System.Windows.Forms.SaveFileDialog
        Me.btnTest = New System.Windows.Forms.Button
        Me.pdPrint = New System.Windows.Forms.PrintDialog
        Me.pdPrintDoc = New System.Drawing.Printing.PrintDocument
        Me.mnuStrip.SuspendLayout()
        Me.grpStudentData.SuspendLayout()
        Me.grpReport.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuStrip
        '
        Me.mnuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuReport, Me.mnuHelp})
        Me.mnuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuStrip.Name = "mnuStrip"
        Me.mnuStrip.Size = New System.Drawing.Size(401, 24)
        Me.mnuStrip.TabIndex = 0
        Me.mnuStrip.Text = "mnuStrip"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileNew, Me.mnuFileOpen, Me.mnuFileSave, Me.mnuFileSaveAs, Me.ToolStripMenuItem3, Me.mnuFilePrint, Me.ToolStripMenuItem1, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(35, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuFileNew
        '
        Me.mnuFileNew.Name = "mnuFileNew"
        Me.mnuFileNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuFileNew.Size = New System.Drawing.Size(163, 22)
        Me.mnuFileNew.Text = "&New"
        '
        'mnuFileOpen
        '
        Me.mnuFileOpen.Name = "mnuFileOpen"
        Me.mnuFileOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuFileOpen.Size = New System.Drawing.Size(163, 22)
        Me.mnuFileOpen.Text = "&Open..."
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Name = "mnuFileSave"
        Me.mnuFileSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuFileSave.Size = New System.Drawing.Size(163, 22)
        Me.mnuFileSave.Text = "&Save"
        '
        'mnuFileSaveAs
        '
        Me.mnuFileSaveAs.Name = "mnuFileSaveAs"
        Me.mnuFileSaveAs.Size = New System.Drawing.Size(163, 22)
        Me.mnuFileSaveAs.Text = "Save As..."
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(160, 6)
        '
        'mnuFilePrint
        '
        Me.mnuFilePrint.Name = "mnuFilePrint"
        Me.mnuFilePrint.Size = New System.Drawing.Size(163, 22)
        Me.mnuFilePrint.Text = "Print"
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
        'mnuReport
        '
        Me.mnuReport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuReportPrint})
        Me.mnuReport.Name = "mnuReport"
        Me.mnuReport.Size = New System.Drawing.Size(52, 20)
        Me.mnuReport.Text = "Report"
        '
        'mnuReportPrint
        '
        Me.mnuReportPrint.Name = "mnuReportPrint"
        Me.mnuReportPrint.Size = New System.Drawing.Size(152, 22)
        Me.mnuReportPrint.Text = "Show Report"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpDebug, Me.ToolStripMenuItem2, Me.mnuHelpAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(40, 20)
        Me.mnuHelp.Text = "Help"
        '
        'mnuHelpDebug
        '
        Me.mnuHelpDebug.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpDebugOn, Me.mnuHelpDebugOff})
        Me.mnuHelpDebug.Name = "mnuHelpDebug"
        Me.mnuHelpDebug.Size = New System.Drawing.Size(152, 22)
        Me.mnuHelpDebug.Text = "Debug"
        '
        'mnuHelpDebugOn
        '
        Me.mnuHelpDebugOn.Name = "mnuHelpDebugOn"
        Me.mnuHelpDebugOn.Size = New System.Drawing.Size(101, 22)
        Me.mnuHelpDebugOn.Text = "On"
        '
        'mnuHelpDebugOff
        '
        Me.mnuHelpDebugOff.Name = "mnuHelpDebugOff"
        Me.mnuHelpDebugOff.Size = New System.Drawing.Size(101, 22)
        Me.mnuHelpDebugOff.Text = "Off"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(149, 6)
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.Size = New System.Drawing.Size(152, 22)
        Me.mnuHelpAbout.Text = "About"
        '
        'grpStudentData
        '
        Me.grpStudentData.Controls.Add(Me.grpReport)
        Me.grpStudentData.Controls.Add(Me.lblAverage)
        Me.grpStudentData.Controls.Add(Me.lblTestScores)
        Me.grpStudentData.Controls.Add(Me.txtAvg6)
        Me.grpStudentData.Controls.Add(Me.txtR6C5)
        Me.grpStudentData.Controls.Add(Me.txtR6C4)
        Me.grpStudentData.Controls.Add(Me.txtR6C3)
        Me.grpStudentData.Controls.Add(Me.txtR6C2)
        Me.grpStudentData.Controls.Add(Me.txtR6C1)
        Me.grpStudentData.Controls.Add(Me.txtAvg5)
        Me.grpStudentData.Controls.Add(Me.txtR5C5)
        Me.grpStudentData.Controls.Add(Me.txtR5C4)
        Me.grpStudentData.Controls.Add(Me.txtR5C3)
        Me.grpStudentData.Controls.Add(Me.txtR5C2)
        Me.grpStudentData.Controls.Add(Me.txtR5C1)
        Me.grpStudentData.Controls.Add(Me.txtAvg4)
        Me.grpStudentData.Controls.Add(Me.txtR4C5)
        Me.grpStudentData.Controls.Add(Me.txtR4C4)
        Me.grpStudentData.Controls.Add(Me.txtR4C3)
        Me.grpStudentData.Controls.Add(Me.txtR4C2)
        Me.grpStudentData.Controls.Add(Me.txtR4C1)
        Me.grpStudentData.Controls.Add(Me.txtAvg3)
        Me.grpStudentData.Controls.Add(Me.txtR3C5)
        Me.grpStudentData.Controls.Add(Me.txtR3C4)
        Me.grpStudentData.Controls.Add(Me.txtR3C3)
        Me.grpStudentData.Controls.Add(Me.txtR3C2)
        Me.grpStudentData.Controls.Add(Me.txtR3C1)
        Me.grpStudentData.Controls.Add(Me.txtAvg2)
        Me.grpStudentData.Controls.Add(Me.txtR2C5)
        Me.grpStudentData.Controls.Add(Me.txtR2C4)
        Me.grpStudentData.Controls.Add(Me.txtR2C3)
        Me.grpStudentData.Controls.Add(Me.txtR2C2)
        Me.grpStudentData.Controls.Add(Me.txtR2C1)
        Me.grpStudentData.Controls.Add(Me.txtAvg1)
        Me.grpStudentData.Controls.Add(Me.txtR1C5)
        Me.grpStudentData.Controls.Add(Me.txtR1C4)
        Me.grpStudentData.Controls.Add(Me.txtR1C3)
        Me.grpStudentData.Controls.Add(Me.txtR1C2)
        Me.grpStudentData.Controls.Add(Me.txtR1C1)
        Me.grpStudentData.Controls.Add(Me.txtName6)
        Me.grpStudentData.Controls.Add(Me.txtName5)
        Me.grpStudentData.Controls.Add(Me.txtName4)
        Me.grpStudentData.Controls.Add(Me.txtName3)
        Me.grpStudentData.Controls.Add(Me.txtName2)
        Me.grpStudentData.Controls.Add(Me.txtName1)
        Me.grpStudentData.Controls.Add(Me.lblName)
        Me.grpStudentData.Location = New System.Drawing.Point(13, 28)
        Me.grpStudentData.Name = "grpStudentData"
        Me.grpStudentData.Size = New System.Drawing.Size(376, 213)
        Me.grpStudentData.TabIndex = 1
        Me.grpStudentData.TabStop = False
        Me.grpStudentData.Text = "Student Data"
        '
        'grpReport
        '
        Me.grpReport.Controls.Add(Me.txtReport)
        Me.grpReport.Location = New System.Drawing.Point(0, 0)
        Me.grpReport.Name = "grpReport"
        Me.grpReport.Size = New System.Drawing.Size(376, 213)
        Me.grpReport.TabIndex = 45
        Me.grpReport.TabStop = False
        Me.grpReport.Text = "Report"
        Me.grpReport.Visible = False
        '
        'txtReport
        '
        Me.txtReport.Location = New System.Drawing.Point(10, 20)
        Me.txtReport.Multiline = True
        Me.txtReport.Name = "txtReport"
        Me.txtReport.ReadOnly = True
        Me.txtReport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReport.Size = New System.Drawing.Size(352, 183)
        Me.txtReport.TabIndex = 0
        Me.txtReport.Text = "STUDENT DATA REPORT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-------------------------------------------------" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Location = New System.Drawing.Point(323, 37)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(47, 13)
        Me.lblAverage.TabIndex = 44
        Me.lblAverage.Text = "Average"
        '
        'lblTestScores
        '
        Me.lblTestScores.AutoSize = True
        Me.lblTestScores.Location = New System.Drawing.Point(188, 37)
        Me.lblTestScores.Name = "lblTestScores"
        Me.lblTestScores.Size = New System.Drawing.Size(64, 13)
        Me.lblTestScores.TabIndex = 43
        Me.lblTestScores.Text = "Test Scores"
        '
        'txtAvg6
        '
        Me.txtAvg6.Location = New System.Drawing.Point(326, 183)
        Me.txtAvg6.Name = "txtAvg6"
        Me.txtAvg6.ReadOnly = True
        Me.txtAvg6.Size = New System.Drawing.Size(36, 20)
        Me.txtAvg6.TabIndex = 42
        '
        'txtR6C5
        '
        Me.txtR6C5.Location = New System.Drawing.Point(284, 183)
        Me.txtR6C5.Name = "txtR6C5"
        Me.txtR6C5.Size = New System.Drawing.Size(36, 20)
        Me.txtR6C5.TabIndex = 41
        '
        'txtR6C4
        '
        Me.txtR6C4.Location = New System.Drawing.Point(242, 183)
        Me.txtR6C4.Name = "txtR6C4"
        Me.txtR6C4.Size = New System.Drawing.Size(36, 20)
        Me.txtR6C4.TabIndex = 40
        '
        'txtR6C3
        '
        Me.txtR6C3.Location = New System.Drawing.Point(200, 183)
        Me.txtR6C3.Name = "txtR6C3"
        Me.txtR6C3.Size = New System.Drawing.Size(36, 20)
        Me.txtR6C3.TabIndex = 39
        '
        'txtR6C2
        '
        Me.txtR6C2.Location = New System.Drawing.Point(158, 183)
        Me.txtR6C2.Name = "txtR6C2"
        Me.txtR6C2.Size = New System.Drawing.Size(36, 20)
        Me.txtR6C2.TabIndex = 38
        '
        'txtR6C1
        '
        Me.txtR6C1.Location = New System.Drawing.Point(116, 183)
        Me.txtR6C1.Name = "txtR6C1"
        Me.txtR6C1.Size = New System.Drawing.Size(36, 20)
        Me.txtR6C1.TabIndex = 37
        '
        'txtAvg5
        '
        Me.txtAvg5.Location = New System.Drawing.Point(326, 157)
        Me.txtAvg5.Name = "txtAvg5"
        Me.txtAvg5.ReadOnly = True
        Me.txtAvg5.Size = New System.Drawing.Size(36, 20)
        Me.txtAvg5.TabIndex = 35
        '
        'txtR5C5
        '
        Me.txtR5C5.Location = New System.Drawing.Point(284, 157)
        Me.txtR5C5.Name = "txtR5C5"
        Me.txtR5C5.Size = New System.Drawing.Size(36, 20)
        Me.txtR5C5.TabIndex = 34
        '
        'txtR5C4
        '
        Me.txtR5C4.Location = New System.Drawing.Point(242, 157)
        Me.txtR5C4.Name = "txtR5C4"
        Me.txtR5C4.Size = New System.Drawing.Size(36, 20)
        Me.txtR5C4.TabIndex = 33
        '
        'txtR5C3
        '
        Me.txtR5C3.Location = New System.Drawing.Point(200, 157)
        Me.txtR5C3.Name = "txtR5C3"
        Me.txtR5C3.Size = New System.Drawing.Size(36, 20)
        Me.txtR5C3.TabIndex = 32
        '
        'txtR5C2
        '
        Me.txtR5C2.Location = New System.Drawing.Point(158, 157)
        Me.txtR5C2.Name = "txtR5C2"
        Me.txtR5C2.Size = New System.Drawing.Size(36, 20)
        Me.txtR5C2.TabIndex = 31
        '
        'txtR5C1
        '
        Me.txtR5C1.Location = New System.Drawing.Point(116, 157)
        Me.txtR5C1.Name = "txtR5C1"
        Me.txtR5C1.Size = New System.Drawing.Size(36, 20)
        Me.txtR5C1.TabIndex = 30
        '
        'txtAvg4
        '
        Me.txtAvg4.Location = New System.Drawing.Point(326, 131)
        Me.txtAvg4.Name = "txtAvg4"
        Me.txtAvg4.ReadOnly = True
        Me.txtAvg4.Size = New System.Drawing.Size(36, 20)
        Me.txtAvg4.TabIndex = 28
        '
        'txtR4C5
        '
        Me.txtR4C5.Location = New System.Drawing.Point(284, 131)
        Me.txtR4C5.Name = "txtR4C5"
        Me.txtR4C5.Size = New System.Drawing.Size(36, 20)
        Me.txtR4C5.TabIndex = 27
        '
        'txtR4C4
        '
        Me.txtR4C4.Location = New System.Drawing.Point(242, 131)
        Me.txtR4C4.Name = "txtR4C4"
        Me.txtR4C4.Size = New System.Drawing.Size(36, 20)
        Me.txtR4C4.TabIndex = 26
        '
        'txtR4C3
        '
        Me.txtR4C3.Location = New System.Drawing.Point(200, 131)
        Me.txtR4C3.Name = "txtR4C3"
        Me.txtR4C3.Size = New System.Drawing.Size(36, 20)
        Me.txtR4C3.TabIndex = 25
        '
        'txtR4C2
        '
        Me.txtR4C2.Location = New System.Drawing.Point(158, 131)
        Me.txtR4C2.Name = "txtR4C2"
        Me.txtR4C2.Size = New System.Drawing.Size(36, 20)
        Me.txtR4C2.TabIndex = 24
        '
        'txtR4C1
        '
        Me.txtR4C1.Location = New System.Drawing.Point(116, 131)
        Me.txtR4C1.Name = "txtR4C1"
        Me.txtR4C1.Size = New System.Drawing.Size(36, 20)
        Me.txtR4C1.TabIndex = 23
        '
        'txtAvg3
        '
        Me.txtAvg3.Location = New System.Drawing.Point(326, 105)
        Me.txtAvg3.Name = "txtAvg3"
        Me.txtAvg3.ReadOnly = True
        Me.txtAvg3.Size = New System.Drawing.Size(36, 20)
        Me.txtAvg3.TabIndex = 21
        '
        'txtR3C5
        '
        Me.txtR3C5.Location = New System.Drawing.Point(284, 105)
        Me.txtR3C5.Name = "txtR3C5"
        Me.txtR3C5.Size = New System.Drawing.Size(36, 20)
        Me.txtR3C5.TabIndex = 20
        '
        'txtR3C4
        '
        Me.txtR3C4.Location = New System.Drawing.Point(242, 105)
        Me.txtR3C4.Name = "txtR3C4"
        Me.txtR3C4.Size = New System.Drawing.Size(36, 20)
        Me.txtR3C4.TabIndex = 19
        '
        'txtR3C3
        '
        Me.txtR3C3.Location = New System.Drawing.Point(200, 105)
        Me.txtR3C3.Name = "txtR3C3"
        Me.txtR3C3.Size = New System.Drawing.Size(36, 20)
        Me.txtR3C3.TabIndex = 18
        '
        'txtR3C2
        '
        Me.txtR3C2.Location = New System.Drawing.Point(158, 105)
        Me.txtR3C2.Name = "txtR3C2"
        Me.txtR3C2.Size = New System.Drawing.Size(36, 20)
        Me.txtR3C2.TabIndex = 17
        '
        'txtR3C1
        '
        Me.txtR3C1.Location = New System.Drawing.Point(116, 105)
        Me.txtR3C1.Name = "txtR3C1"
        Me.txtR3C1.Size = New System.Drawing.Size(36, 20)
        Me.txtR3C1.TabIndex = 16
        '
        'txtAvg2
        '
        Me.txtAvg2.Location = New System.Drawing.Point(326, 79)
        Me.txtAvg2.Name = "txtAvg2"
        Me.txtAvg2.ReadOnly = True
        Me.txtAvg2.Size = New System.Drawing.Size(36, 20)
        Me.txtAvg2.TabIndex = 14
        '
        'txtR2C5
        '
        Me.txtR2C5.Location = New System.Drawing.Point(284, 79)
        Me.txtR2C5.Name = "txtR2C5"
        Me.txtR2C5.Size = New System.Drawing.Size(36, 20)
        Me.txtR2C5.TabIndex = 13
        '
        'txtR2C4
        '
        Me.txtR2C4.Location = New System.Drawing.Point(242, 79)
        Me.txtR2C4.Name = "txtR2C4"
        Me.txtR2C4.Size = New System.Drawing.Size(36, 20)
        Me.txtR2C4.TabIndex = 12
        '
        'txtR2C3
        '
        Me.txtR2C3.Location = New System.Drawing.Point(200, 79)
        Me.txtR2C3.Name = "txtR2C3"
        Me.txtR2C3.Size = New System.Drawing.Size(36, 20)
        Me.txtR2C3.TabIndex = 11
        '
        'txtR2C2
        '
        Me.txtR2C2.Location = New System.Drawing.Point(158, 79)
        Me.txtR2C2.Name = "txtR2C2"
        Me.txtR2C2.Size = New System.Drawing.Size(36, 20)
        Me.txtR2C2.TabIndex = 10
        '
        'txtR2C1
        '
        Me.txtR2C1.Location = New System.Drawing.Point(116, 79)
        Me.txtR2C1.Name = "txtR2C1"
        Me.txtR2C1.Size = New System.Drawing.Size(36, 20)
        Me.txtR2C1.TabIndex = 9
        '
        'txtAvg1
        '
        Me.txtAvg1.Location = New System.Drawing.Point(326, 53)
        Me.txtAvg1.Name = "txtAvg1"
        Me.txtAvg1.ReadOnly = True
        Me.txtAvg1.Size = New System.Drawing.Size(36, 20)
        Me.txtAvg1.TabIndex = 7
        '
        'txtR1C5
        '
        Me.txtR1C5.Location = New System.Drawing.Point(284, 53)
        Me.txtR1C5.Name = "txtR1C5"
        Me.txtR1C5.Size = New System.Drawing.Size(36, 20)
        Me.txtR1C5.TabIndex = 6
        '
        'txtR1C4
        '
        Me.txtR1C4.Location = New System.Drawing.Point(242, 53)
        Me.txtR1C4.Name = "txtR1C4"
        Me.txtR1C4.Size = New System.Drawing.Size(36, 20)
        Me.txtR1C4.TabIndex = 5
        '
        'txtR1C3
        '
        Me.txtR1C3.Location = New System.Drawing.Point(200, 53)
        Me.txtR1C3.Name = "txtR1C3"
        Me.txtR1C3.Size = New System.Drawing.Size(36, 20)
        Me.txtR1C3.TabIndex = 4
        '
        'txtR1C2
        '
        Me.txtR1C2.Location = New System.Drawing.Point(158, 53)
        Me.txtR1C2.Name = "txtR1C2"
        Me.txtR1C2.Size = New System.Drawing.Size(36, 20)
        Me.txtR1C2.TabIndex = 3
        '
        'txtR1C1
        '
        Me.txtR1C1.Location = New System.Drawing.Point(116, 53)
        Me.txtR1C1.Name = "txtR1C1"
        Me.txtR1C1.Size = New System.Drawing.Size(36, 20)
        Me.txtR1C1.TabIndex = 2
        '
        'txtName6
        '
        Me.txtName6.Location = New System.Drawing.Point(10, 183)
        Me.txtName6.Name = "txtName6"
        Me.txtName6.Size = New System.Drawing.Size(100, 20)
        Me.txtName6.TabIndex = 36
        '
        'txtName5
        '
        Me.txtName5.Location = New System.Drawing.Point(10, 157)
        Me.txtName5.Name = "txtName5"
        Me.txtName5.Size = New System.Drawing.Size(100, 20)
        Me.txtName5.TabIndex = 29
        '
        'txtName4
        '
        Me.txtName4.Location = New System.Drawing.Point(10, 131)
        Me.txtName4.Name = "txtName4"
        Me.txtName4.Size = New System.Drawing.Size(100, 20)
        Me.txtName4.TabIndex = 22
        '
        'txtName3
        '
        Me.txtName3.Location = New System.Drawing.Point(10, 105)
        Me.txtName3.Name = "txtName3"
        Me.txtName3.Size = New System.Drawing.Size(100, 20)
        Me.txtName3.TabIndex = 15
        '
        'txtName2
        '
        Me.txtName2.Location = New System.Drawing.Point(10, 79)
        Me.txtName2.Name = "txtName2"
        Me.txtName2.Size = New System.Drawing.Size(100, 20)
        Me.txtName2.TabIndex = 8
        '
        'txtName1
        '
        Me.txtName1.Location = New System.Drawing.Point(10, 53)
        Me.txtName1.Name = "txtName1"
        Me.txtName1.Size = New System.Drawing.Size(100, 20)
        Me.txtName1.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(42, 37)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(314, 247)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 34)
        Me.btnCalc.TabIndex = 43
        Me.btnCalc.Text = "Calculate Averages"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnHide
        '
        Me.btnHide.Location = New System.Drawing.Point(314, 247)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(75, 34)
        Me.btnHide.TabIndex = 44
        Me.btnHide.Text = "Hide"
        Me.btnHide.UseVisualStyleBackColor = True
        Me.btnHide.Visible = False
        '
        'ofdOpenFile
        '
        Me.ofdOpenFile.FileName = "OpenFileDialog1"
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(13, 253)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(75, 23)
        Me.btnTest.TabIndex = 45
        Me.btnTest.Text = "Test Data"
        Me.btnTest.UseVisualStyleBackColor = True
        Me.btnTest.Visible = False
        '
        'pdPrint
        '
        Me.pdPrint.UseEXDialog = True
        '
        'pdPrintDoc
        '
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 288)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.grpStudentData)
        Me.Controls.Add(Me.mnuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.mnuStrip
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Student Test Scores"
        Me.mnuStrip.ResumeLayout(False)
        Me.mnuStrip.PerformLayout()
        Me.grpStudentData.ResumeLayout(False)
        Me.grpStudentData.PerformLayout()
        Me.grpReport.ResumeLayout(False)
        Me.grpReport.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grpStudentData As System.Windows.Forms.GroupBox
    Friend WithEvents lblAverage As System.Windows.Forms.Label
    Friend WithEvents lblTestScores As System.Windows.Forms.Label
    Friend WithEvents txtAvg6 As System.Windows.Forms.TextBox
    Friend WithEvents txtR6C5 As System.Windows.Forms.TextBox
    Friend WithEvents txtR6C4 As System.Windows.Forms.TextBox
    Friend WithEvents txtR6C3 As System.Windows.Forms.TextBox
    Friend WithEvents txtR6C2 As System.Windows.Forms.TextBox
    Friend WithEvents txtR6C1 As System.Windows.Forms.TextBox
    Friend WithEvents txtAvg5 As System.Windows.Forms.TextBox
    Friend WithEvents txtR5C5 As System.Windows.Forms.TextBox
    Friend WithEvents txtR5C4 As System.Windows.Forms.TextBox
    Friend WithEvents txtR5C3 As System.Windows.Forms.TextBox
    Friend WithEvents txtR5C2 As System.Windows.Forms.TextBox
    Friend WithEvents txtR5C1 As System.Windows.Forms.TextBox
    Friend WithEvents txtAvg4 As System.Windows.Forms.TextBox
    Friend WithEvents txtR4C5 As System.Windows.Forms.TextBox
    Friend WithEvents txtR4C4 As System.Windows.Forms.TextBox
    Friend WithEvents txtR4C3 As System.Windows.Forms.TextBox
    Friend WithEvents txtR4C2 As System.Windows.Forms.TextBox
    Friend WithEvents txtR4C1 As System.Windows.Forms.TextBox
    Friend WithEvents txtAvg3 As System.Windows.Forms.TextBox
    Friend WithEvents txtR3C5 As System.Windows.Forms.TextBox
    Friend WithEvents txtR3C4 As System.Windows.Forms.TextBox
    Friend WithEvents txtR3C3 As System.Windows.Forms.TextBox
    Friend WithEvents txtR3C2 As System.Windows.Forms.TextBox
    Friend WithEvents txtR3C1 As System.Windows.Forms.TextBox
    Friend WithEvents txtAvg2 As System.Windows.Forms.TextBox
    Friend WithEvents txtR2C5 As System.Windows.Forms.TextBox
    Friend WithEvents txtR2C4 As System.Windows.Forms.TextBox
    Friend WithEvents txtR2C3 As System.Windows.Forms.TextBox
    Friend WithEvents txtR2C2 As System.Windows.Forms.TextBox
    Friend WithEvents txtR2C1 As System.Windows.Forms.TextBox
    Friend WithEvents txtAvg1 As System.Windows.Forms.TextBox
    Friend WithEvents txtR1C5 As System.Windows.Forms.TextBox
    Friend WithEvents txtR1C4 As System.Windows.Forms.TextBox
    Friend WithEvents txtR1C3 As System.Windows.Forms.TextBox
    Friend WithEvents txtR1C2 As System.Windows.Forms.TextBox
    Friend WithEvents txtR1C1 As System.Windows.Forms.TextBox
    Friend WithEvents txtName6 As System.Windows.Forms.TextBox
    Friend WithEvents txtName5 As System.Windows.Forms.TextBox
    Friend WithEvents txtName4 As System.Windows.Forms.TextBox
    Friend WithEvents txtName3 As System.Windows.Forms.TextBox
    Friend WithEvents txtName2 As System.Windows.Forms.TextBox
    Friend WithEvents txtName1 As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents mnuFileNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileSaveAs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuReportPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grpReport As System.Windows.Forms.GroupBox
    Friend WithEvents txtReport As System.Windows.Forms.TextBox
    Friend WithEvents btnHide As System.Windows.Forms.Button
    Friend WithEvents ofdOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sfdSaveFile As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnTest As System.Windows.Forms.Button
    Friend WithEvents mnuHelpDebug As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuHelpDebugOn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelpDebugOff As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pdPrint As System.Windows.Forms.PrintDialog
    Friend WithEvents pdPrintDoc As System.Drawing.Printing.PrintDocument
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuFilePrint As System.Windows.Forms.ToolStripMenuItem

End Class
