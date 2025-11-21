Public Class frmMain

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        Try
            lstWorkshop.SelectedIndex = -1
            lstLocation.SelectedIndex = -1
            lstCost.Items.Clear()
            lblCost.Text = String.Empty
            lstWorkshop.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Clear Error")
        End Try
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim intPrice As Integer = 0
        Dim intDay As Integer = 3

        Try
            Select Case lstWorkshop.SelectedIndex
                Case 0 : intPrice = 595
                Case 1 : intPrice = 695
                Case 2 : intPrice = 995
                Case 3
                    intPrice = 1295
                    intDay = 5
                Case 4
                    intPrice = 395
                    intDay = 1
            End Select

            Select Case lstLocation.SelectedIndex
                Case 0 : intPrice += 95 * intDay
                Case 1 : intPrice += 125 * intDay
                Case 2 : intPrice += 110 * intDay
                Case 3 : intPrice += 100 * intDay
                Case 4 : intPrice += 92 * intDay
                Case 5 : intPrice += 90 * intDay
            End Select
            lstCost.Items.Add(FormatCurrency(intPrice))
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Add Error")
        End Try
    End Sub

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        Dim i As Integer = 0
        Dim dblTotal As Double = 0
        Try
            Do While i < lstCost.Items.Count
                dblTotal += CDbl(lstCost.Items.Item(i))
                i += 1
            Loop
            lblCost.Text = FormatCurrency(dblTotal)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Calculation Error")
        End Try
    End Sub
End Class
