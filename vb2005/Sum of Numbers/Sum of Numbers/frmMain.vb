Public Class frmMain

    Private Sub btnInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInput.Click
        Dim strInput As String
        Dim intInput As Double
        Try
            strInput = InputBox("Enter a positive integer value.", _
                "Input Needed", "10")
            intInput = CDbl(strInput)
            If Not intInput > 0 Then
                MessageBox.Show("Input must contain a positiver Integer", _
                    "Input Error")
                Return
            ElseIf intInput > 20000000 Then
                MessageBox.Show("What are you crazy?", _
                    "Input Error")
                Return
            End If

            ' 10
            ' 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10
            Dim intCount As Double = 0
            Dim tmpInput As Double = 0

            Do While intCount < intInput
                intCount += 1
                tmpInput += intCount
            Loop
            MessageBox.Show("The sum of the numbers 1 through " & strInput & _
                " is " & tmpInput.ToString, "Sum of Numbers")
        Catch
            MessageBox.Show("Input must be an integer.", _
                "Error")
        End Try
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
