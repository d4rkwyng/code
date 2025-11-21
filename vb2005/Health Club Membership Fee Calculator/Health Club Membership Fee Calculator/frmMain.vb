Public Class frmMain
    Const decDiscount4to6 As Decimal = 0.05D ' 4 to 6 months
    Const decDiscount7to9 As Decimal = 0.08D ' 7 to 9 months
    Const decDiscount10orMore As Decimal = 0.1D ' 10 or more

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        Dim decBaseFee, decDiscount, decTotalFee As Decimal
        Dim intMonths As Integer

        Try
            intMonths = CInt(txtMonths.Text)
        Catch ex As Exception
            MessageBox.Show("Months must be a valid integer", _
                "Input Error")
            Return
        End Try

        If (intMonths < 1) Or (intMonths > 24) Then
            MessageBox.Show("Months must be a valid integer", _
                "Input Error")
            Return
        End If

        If radAdult.Checked = True Then
            decBaseFee = 40
        ElseIf radChild.Checked = True Then
            decBaseFee = 20
        ElseIf radStudent.Checked = True Then
            decBaseFee = 25
        ElseIf radSenior.Checked = True Then
            decBaseFee = 30
        End If

        If chkYoga.Checked = True Then
            decBaseFee += 10
        End If
        If chkKarate.Checked = True Then
            decBaseFee += 30
        End If
        If chkTrainer.Checked = True Then
            decBaseFee += 50
        End If

        Select Case intMonths
            Case Is <= 3
                decDiscount = 0
            Case 4 To 6
                decDiscount = decBaseFee * decDiscount4to6
            Case 7 To 9
                decDiscount = decBaseFee * decDiscount7to9
            Case Is >= 10
                decDiscount = decBaseFee * decDiscount10orMore
        End Select

        decBaseFee -= decDiscount
        decTotalFee = decBaseFee * intMonths

        lblMonthlyFee.Text = FormatCurrency(decBaseFee)
        lblTotalFee.Text = FormatCurrency(decTotalFee)
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'Clear the form, reset the buttons and check boxes.
        radAdult.Checked = True
        chkYoga.Checked = False
        chkKarate.Checked = False
        chkTrainer.Checked = False
        txtMonths.Clear()
        lblMonthlyFee.Text = String.Empty
        lblTotalFee.Text = String.Empty
    End Sub
End Class
