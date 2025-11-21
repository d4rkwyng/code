Public Class frmMain
    Const decChecks20orLess As Decimal = 0.1D   '$0.10 each for less than 20 checks
    Const decChecks20to39 As Decimal = 0.08D    '$0.08 each for 20 through 39 checks
    Const decChecks40to59 As Decimal = 0.06D    '$0.06 each for 40 through 59 checks
    Const decChecks60orMore As Decimal = 0.04D  '$0.04 each for 60 or more checks
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtNumChecks.Clear()
        txtTotalFees.Clear()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        Dim NumChecks, MonthlyFee, Result As Double

        'Set Variables
        MonthlyFee = 10.0
        Result = 0

        Try
            NumChecks = CDbl(txtNumChecks.Text)

            Select Case NumChecks
                Case 0 To 19
                    Result = NumChecks * decChecks20orLess
                Case 20 To 39
                    Result = NumChecks * decChecks20to39
                Case 40 To 59
                    Result = NumChecks * decChecks40to59
                Case Is >= 60
                    Result = NumChecks * decChecks60orMore
            End Select
            Result += MonthlyFee
            txtTotalFees.Text = FormatCurrency(Result)

        Catch ex As Exception
            MessageBox.Show("Checks must be a valid integer", _
                "Input Error")
            Return
        End Try
    End Sub
End Class
