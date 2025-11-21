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
        Me.lblName = New System.Windows.Forms.Label
        Me.btnShowInfo = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.lblStreet = New System.Windows.Forms.Label
        Me.lblCityStateZip = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(12, 19)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(222, 22)
        Me.lblName.TabIndex = 0
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnShowInfo
        '
        Me.btnShowInfo.Location = New System.Drawing.Point(12, 108)
        Me.btnShowInfo.Name = "btnShowInfo"
        Me.btnShowInfo.Size = New System.Drawing.Size(75, 23)
        Me.btnShowInfo.TabIndex = 1
        Me.btnShowInfo.Text = "Show Info"
        Me.btnShowInfo.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(159, 108)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblStreet
        '
        Me.lblStreet.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStreet.Location = New System.Drawing.Point(8, 50)
        Me.lblStreet.Name = "lblStreet"
        Me.lblStreet.Size = New System.Drawing.Size(226, 19)
        Me.lblStreet.TabIndex = 3
        Me.lblStreet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCityStateZip
        '
        Me.lblCityStateZip.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCityStateZip.Location = New System.Drawing.Point(12, 69)
        Me.lblCityStateZip.Name = "lblCityStateZip"
        Me.lblCityStateZip.Size = New System.Drawing.Size(222, 19)
        Me.lblCityStateZip.TabIndex = 4
        Me.lblCityStateZip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(246, 143)
        Me.Controls.Add(Me.lblCityStateZip)
        Me.Controls.Add(Me.lblStreet)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnShowInfo)
        Me.Controls.Add(Me.lblName)
        Me.Name = "frmMain"
        Me.Text = "Name and Address"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents btnShowInfo As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblStreet As System.Windows.Forms.Label
    Friend WithEvents lblCityStateZip As System.Windows.Forms.Label

End Class
