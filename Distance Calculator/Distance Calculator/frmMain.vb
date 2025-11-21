Public Class frmMain

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        Dim strInput As String = String.Empty
        Dim strOutput As String = String.Empty
        Dim intSpeed As Integer = 0
        Dim intHours As Integer = 0
        Dim intCount As Integer = 0
        Dim n As String = ControlChars.NewLine

        Try
            'Stores End User's input for intSpeed
            strInput = InputBox("Enter the speed of the vehicle.", _
                "Input Needed", "60")

            'Check input to make sure its a number
            If Not IsNumeric(strInput) Then
                MessageBox.Show("Input must be an integer.", "Input Error")
                Return
            End If

            intSpeed = CInt(strInput)

            'Check input to make sure its not less than 1 
            If intSpeed < 1 Then
                MessageBox.Show("Input must be greater than 0.", "Input Error")
                Return
            End If

            strInput = String.Empty 'Clears the variable

            'Stores End User's input for intHours
            strInput = InputBox("Enter amount of time traveled (in hours).", _
                "Input Needed", "7")
            intHours = CInt(strInput)

            Do
                intCount += 1
                strOutput = strOutput & intCount.ToString & ControlChars.Tab & _
                    (intSpeed * intCount).ToString & n
            Loop While intCount < intHours

            strOutput = "Vehicle speed: " & intSpeed.ToString & " MPH" & n & _
                "Time traveled: " & intHours.ToString & " hours" & n & _
                "Hour" & ControlChars.Tab & "Distance Traveled" & n & _
                "---------------------------------------------" & n & _
                strOutput & "Total Distance: " & (intSpeed * intCount).ToString

            rtbPane.Text = strOutput
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub
End Class
