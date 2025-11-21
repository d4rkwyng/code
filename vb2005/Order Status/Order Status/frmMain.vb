Public Class frmMain
    ' Constants
    Const intCopperSpool As Integer = 100
    Const intNormDelivery As Integer = 10
    Const intRushDelivery As Integer = 15

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' You guessed it, it clears it all ;)
        ResetSpools()
        ResetDelivery()
    End Sub

    Private Sub ResetSpools()
        ' Clears the text box and the check box.
        txtInput.Clear()
        chkRush.Checked = False
    End Sub

    Private Sub ResetDelivery()
        ' Clears the labels that display the delivery information
        lblToShip.Text = String.Empty
        lblBackOrder.Text = String.Empty
        lblHandling.Text = String.Empty
        lblDue.Text = String.Empty
    End Sub

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        Try
            ' Intialize Variables
            If Not CDbl(txtInput.Text) >= 0 Then
                MessageBox.Show("Input must be greater than or equal to 0.")
                txtInput.Text = String.Empty
                txtInput.Focus()
                Return
            End If

            Dim dblNumOrdered As Double = CDbl(txtInput.Text)     ' Sets the inputed text
            Dim strNumOfSpools As String = GetInStock()           ' Retrieves the Spools in Stock

            If CInt(strNumOfSpools) < 0 Then
                Do
                    MessageBox.Show("Input must be greater than or equal to 0.")
                    strNumOfSpools = GetInStock()
                Loop While CInt(strNumOfSpools) < 0
            End If

            Dim dblNumOfSpools As Double = CDbl(strNumOfSpools)   ' Converts string to double
            Dim intDelivery As Integer = intNormDelivery          ' Sets the Default Delivery

            If chkRush.Checked Then intDelivery = intRushDelivery ' Checks for Rush Delivery

            Dim dblReadyToShip As Double = ReadyToShip(dblNumOfSpools, dblNumOrdered)
            Dim dblBackOrdered As Double = BackOrdered(dblNumOfSpools, dblNumOrdered)
            Dim dblTotalDue As Double = ShippingCharges(dblReadyToShip, intDelivery)

            ' Output Results
            lblToShip.Text = dblReadyToShip
            lblBackOrder.Text = dblBackOrdered
            lblHandling.Text = FormatCurrency(intDelivery)
            lblDue.Text = FormatCurrency(dblTotalDue)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Calculation Error")
        End Try
    End Sub

    Private Function GetInStock() As String
        Return InputBox("Enter the number of spools in stock:", "Spool Inventory", "150")
    End Function

    Private Function ReadyToShip(ByVal dblNumOfSpools As Double, ByVal dblNumOrdered As Integer) As Double
        If dblNumOfSpools > dblNumOrdered Then
            Return dblNumOrdered
        Else
            Return dblNumOfSpools
        End If
    End Function

    Private Function BackOrdered(ByVal dblNumOfSpools As Double, ByVal dblNumOrdered As Double) As Double
        If dblNumOrdered > dblNumOfSpools Then
            Return dblNumOrdered - dblNumOfSpools
        Else
            Return 0
        End If
    End Function

    Private Function ShippingCharges(ByVal dblNumReady As Double, ByVal intDelivery As Integer) As Double
        Return (dblNumReady * intCopperSpool) + (dblNumReady * intDelivery)
    End Function
End Class
