Public Class frmMain

    Private Sub txtbox_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFat.KeyPress, txtCal.KeyPress
        If e.KeyChar = Chr(13) Then
            txtPercentage.Text = CalcFatPerc(txtFat.Text, txtCal.Text)
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtCal.Text = String.Empty
        txtFat.Text = String.Empty
        txtPercentage.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        txtPercentage.Text = CalcFatPerc(txtFat.Text, txtCal.Text)
    End Sub

    Private Function CalcFatPerc(ByVal inFat As String, ByVal inCal As String) As String
        Dim Fat, Cal, CalFat, PercFat As Single

        Try
            Fat = CSng(inFat)
            Cal = CSng(inCal)

            If (Fat > Cal) Then
                MessageBox.Show("Fat cannot be greater than Calories", _
                    "Input Error")
                Return "0"
            ElseIf (Cal <= 0) Or (Fat <= 0) Then
                MessageBox.Show("Calories and/or Fats cannot be less than or equal to 0", _
                    "Input Error")
                Return "0"
            End If

            ' Formulas
            ' Calories from fat = fat grams * 9
            ' Percentage of calories from fat = Calories from fat / total calories
            CalFat = Fat * 9
            PercFat = CalFat / Cal

            If PercFat <= 0.3 Then
                Return PercFat.ToString & " (low calories)"
            Else
                Return PercFat.ToString
            End If

        Catch ex As Exception
            MessageBox.Show("Calculating Error: Check input.", _
                "Input Error")
            Return "0"
        End Try
    End Function
End Class