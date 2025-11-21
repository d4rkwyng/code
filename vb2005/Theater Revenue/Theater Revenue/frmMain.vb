Public Class frmMain

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtAPrice.Clear()
        txtASold.Clear()

        txtCPrice.Clear()
        txtCSold.Clear()

        txtGAdult.Clear()
        txtGChild.Clear()
        txtGTotal.Clear()

        txtNAdult.Clear()
        txtNChild.Clear()
        txtNTotal.Clear()
    End Sub

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        Dim APrice As Single    'APrice = Adult Price Per Ticket
        Dim ASold As Single     'ASold = Ammount of Adult tickets sold
        Dim ATotal As Single    'ATotal = APrice * ASold
        Dim GTotal As Single    'GTotal = Gross total of ATotal + CTotal
        Dim CPrice As Single    'CPrice = Child Price Per Ticket
        Dim CSold As Single     'CSold = Ammount of Child tickets sold
        Dim CTotal As Single    'CTotal = CPrice * CSold
        Dim Profit As Single = 0.2

        Try
            APrice = CSng(txtAPrice.Text)
            ASold = CSng(txtASold.Text)
            CPrice = CSng(txtCPrice.Text)
            CSold = CSng(txtCSold.Text)
        Catch ex As Exception
            MessageBox.Show("Input(s) must be a valid integer", _
                "Input Error")
            Return
        End Try

        ' Calculate all the Gross totals
        ATotal = APrice * ASold
        CTotal = CPrice * CSold
        GTotal = ATotal + CTotal

        txtGAdult.Text = FormatCurrency(ATotal.ToString)
        txtGChild.Text = FormatCurrency(CTotal.ToString)
        txtGTotal.Text = FormatCurrency(GTotal.ToString)

        ' Calculate the Net totals
        ATotal *= Profit
        CTotal *= Profit
        GTotal *= Profit

        txtNAdult.Text = FormatCurrency(ATotal.ToString)
        txtNChild.Text = FormatCurrency(CTotal.ToString)
        txtNTotal.Text = FormatCurrency(GTotal.ToString)
    End Sub
End Class
