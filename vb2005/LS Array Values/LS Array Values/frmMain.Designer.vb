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
        Me.btnInput = New System.Windows.Forms.Button
        Me.btnMinMax = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.lstArray = New System.Windows.Forms.ListBox
        Me.lblSmallText = New System.Windows.Forms.Label
        Me.lblLargeText = New System.Windows.Forms.Label
        Me.lblSmall = New System.Windows.Forms.Label
        Me.lblLarge = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnChangeSize = New System.Windows.Forms.Button
        Me.lblArraySizeText = New System.Windows.Forms.Label
        Me.lblArraySize = New System.Windows.Forms.Label
        Me.btnRandom = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(12, 191)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(75, 24)
        Me.btnInput.TabIndex = 0
        Me.btnInput.Text = "&Input Values"
        Me.ToolTip1.SetToolTip(Me.btnInput, "Input the values into the Array")
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'btnMinMax
        '
        Me.btnMinMax.Location = New System.Drawing.Point(109, 191)
        Me.btnMinMax.Name = "btnMinMax"
        Me.btnMinMax.Size = New System.Drawing.Size(104, 22)
        Me.btnMinMax.TabIndex = 1
        Me.btnMinMax.Text = "&Display Min && Max"
        Me.ToolTip1.SetToolTip(Me.btnMinMax, "Display the Smallest and Largest value in the Array")
        Me.btnMinMax.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(306, 193)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 22)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "C&lear"
        Me.ToolTip1.SetToolTip(Me.btnClear, "Reset and Clear Values")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(306, 221)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 22)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Exit the Application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lstArray
        '
        Me.lstArray.FormattingEnabled = True
        Me.lstArray.Location = New System.Drawing.Point(12, 12)
        Me.lstArray.Name = "lstArray"
        Me.lstArray.Size = New System.Drawing.Size(201, 173)
        Me.lstArray.TabIndex = 4
        '
        'lblSmallText
        '
        Me.lblSmallText.Location = New System.Drawing.Point(219, 12)
        Me.lblSmallText.Name = "lblSmallText"
        Me.lblSmallText.Size = New System.Drawing.Size(118, 19)
        Me.lblSmallText.TabIndex = 5
        Me.lblSmallText.Text = "The smallest number is: "
        '
        'lblLargeText
        '
        Me.lblLargeText.Location = New System.Drawing.Point(219, 43)
        Me.lblLargeText.Name = "lblLargeText"
        Me.lblLargeText.Size = New System.Drawing.Size(118, 17)
        Me.lblLargeText.TabIndex = 6
        Me.lblLargeText.Text = "The largest number is: "
        '
        'lblSmall
        '
        Me.lblSmall.Location = New System.Drawing.Point(343, 12)
        Me.lblSmall.Name = "lblSmall"
        Me.lblSmall.Size = New System.Drawing.Size(38, 23)
        Me.lblSmall.TabIndex = 7
        '
        'lblLarge
        '
        Me.lblLarge.Location = New System.Drawing.Point(343, 43)
        Me.lblLarge.Name = "lblLarge"
        Me.lblLarge.Size = New System.Drawing.Size(38, 23)
        Me.lblLarge.TabIndex = 8
        '
        'btnChangeSize
        '
        Me.btnChangeSize.Location = New System.Drawing.Point(12, 221)
        Me.btnChangeSize.Name = "btnChangeSize"
        Me.btnChangeSize.Size = New System.Drawing.Size(75, 23)
        Me.btnChangeSize.TabIndex = 9
        Me.btnChangeSize.Text = "&Array Size"
        Me.ToolTip1.SetToolTip(Me.btnChangeSize, "Change the Array Size")
        Me.btnChangeSize.UseVisualStyleBackColor = True
        '
        'lblArraySizeText
        '
        Me.lblArraySizeText.AutoSize = True
        Me.lblArraySizeText.Location = New System.Drawing.Point(222, 113)
        Me.lblArraySizeText.Name = "lblArraySizeText"
        Me.lblArraySizeText.Size = New System.Drawing.Size(121, 13)
        Me.lblArraySizeText.TabIndex = 10
        Me.lblArraySizeText.Text = "Number of Input Values:"
        '
        'lblArraySize
        '
        Me.lblArraySize.Location = New System.Drawing.Point(346, 113)
        Me.lblArraySize.Name = "lblArraySize"
        Me.lblArraySize.Size = New System.Drawing.Size(35, 23)
        Me.lblArraySize.TabIndex = 11
        '
        'btnRandom
        '
        Me.btnRandom.Location = New System.Drawing.Point(109, 220)
        Me.btnRandom.Name = "btnRandom"
        Me.btnRandom.Size = New System.Drawing.Size(104, 23)
        Me.btnRandom.TabIndex = 12
        Me.btnRandom.Text = "&Generate Random"
        Me.ToolTip1.SetToolTip(Me.btnRandom, "Generate random numbers and print everything out.")
        Me.btnRandom.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 256)
        Me.Controls.Add(Me.btnRandom)
        Me.Controls.Add(Me.lblArraySize)
        Me.Controls.Add(Me.lblArraySizeText)
        Me.Controls.Add(Me.btnChangeSize)
        Me.Controls.Add(Me.lblLarge)
        Me.Controls.Add(Me.lblSmall)
        Me.Controls.Add(Me.lblLargeText)
        Me.Controls.Add(Me.lblSmallText)
        Me.Controls.Add(Me.lstArray)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnMinMax)
        Me.Controls.Add(Me.btnInput)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMain"
        Me.Text = "Largest/Smallest Array Values"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnInput As System.Windows.Forms.Button
    Friend WithEvents btnMinMax As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lstArray As System.Windows.Forms.ListBox
    Friend WithEvents lblSmallText As System.Windows.Forms.Label
    Friend WithEvents lblLargeText As System.Windows.Forms.Label
    Friend WithEvents lblSmall As System.Windows.Forms.Label
    Friend WithEvents lblLarge As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnChangeSize As System.Windows.Forms.Button
    Friend WithEvents lblArraySizeText As System.Windows.Forms.Label
    Friend WithEvents lblArraySize As System.Windows.Forms.Label
    Friend WithEvents btnRandom As System.Windows.Forms.Button

End Class
