Public Class frmMain

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCalcGrossPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcGrossPay.Click
        Dim sngGrossPay As Single

        sngGrossPay = CSng(txtHoursWorked.Text) * CSng(txtPayRate.Text)
        lblGrossPay.Text = FormatCurrency(sngGrossPay)
    End Sub
End Class
