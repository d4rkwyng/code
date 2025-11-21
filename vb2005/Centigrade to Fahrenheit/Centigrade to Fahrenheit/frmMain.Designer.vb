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
        Me.btnConvert = New System.Windows.Forms.Button
        Me.txtInput = New System.Windows.Forms.TextBox
        Me.txtResult = New System.Windows.Forms.TextBox
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.lblInput = New System.Windows.Forms.Label
        Me.lblResult = New System.Windows.Forms.Label
        Me.cboOptions = New System.Windows.Forms.ComboBox
        Me.cboOptions2 = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(140, 82)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnConvert.TabIndex = 5
        Me.btnConvert.Text = "&Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(12, 29)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 20)
        Me.txtInput.TabIndex = 1
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(140, 29)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(100, 20)
        Me.txtResult.TabIndex = 3
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(12, 114)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Cl&ear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(166, 114)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.Location = New System.Drawing.Point(9, 13)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(89, 13)
        Me.lblInput.TabIndex = 7
        Me.lblInput.Text = "Value to Convert:"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(137, 13)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(89, 13)
        Me.lblResult.TabIndex = 8
        Me.lblResult.Text = "Converted Value:"
        '
        'cboOptions
        '
        Me.cboOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOptions.FormattingEnabled = True
        Me.cboOptions.Items.AddRange(New Object() {"Centigrade (C)", "Fahrenheit (F)", "Kelvin (K)"})
        Me.cboOptions.Location = New System.Drawing.Point(12, 55)
        Me.cboOptions.Name = "cboOptions"
        Me.cboOptions.Size = New System.Drawing.Size(100, 21)
        Me.cboOptions.TabIndex = 2
        '
        'cboOptions2
        '
        Me.cboOptions2.DisplayMember = "Centingrade"
        Me.cboOptions2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOptions2.FormattingEnabled = True
        Me.cboOptions2.Items.AddRange(New Object() {"Centigrade (C)", "Fahrenheit (F)", "Kelvin (K)"})
        Me.cboOptions2.Location = New System.Drawing.Point(140, 55)
        Me.cboOptions2.Name = "cboOptions2"
        Me.cboOptions2.Size = New System.Drawing.Size(100, 21)
        Me.cboOptions2.TabIndex = 4
        Me.cboOptions2.ValueMember = "Centingrade"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(253, 149)
        Me.Controls.Add(Me.cboOptions2)
        Me.Controls.Add(Me.cboOptions)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblInput)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.btnConvert)
        Me.Name = "frmMain"
        Me.Text = "Centigrade to Fahrenheit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblInput As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents cboOptions As System.Windows.Forms.ComboBox
    Friend WithEvents cboOptions2 As System.Windows.Forms.ComboBox

End Class
