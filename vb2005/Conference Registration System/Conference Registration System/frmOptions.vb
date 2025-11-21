Public Class frmOptions

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Hide()
        frmMain.lblOutput.Text = FormatCurrency(modFunctions.Calc(chkConfReg.Checked, _
            chkDinner.Checked, lstWorkshop.SelectedIndex))
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        modFunctions.Clear(1)
    End Sub

    Private Sub chkConfReg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkConfReg.CheckedChanged
        isChecked(chkConfReg.Checked)
    End Sub

    Private Sub chkDinner_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDinner.CheckedChanged
        isChecked(chkDinner.Checked)
    End Sub

    Private Sub isChecked(ByVal blCheck As Boolean)
        lstWorkshop.Enabled = False
        If blCheck Then lstWorkshop.Enabled = True
    End Sub
End Class