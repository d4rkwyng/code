Public Class frmMain

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtInput.Clear()
        txtResult.Clear()
    End Sub

    Private Sub btnConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvert.Click
        ' Declare C, F, and K to make it easier for calculations
        Dim temp, C, F, K As Single
        Dim o1, o2 As Integer

        Try
            temp = CSng(txtInput.Text)
            Select Case cboOptions.Text
                Case "Centigrade (C)"
                    o1 = 0
                    C = temp
                Case "Fahrenheit (F)"
                    o1 = 1
                    F = temp
                Case "Kelvin (K)"
                    o1 = 2
                    K = temp
            End Select

            Select Case cboOptions2.Text
                Case "Centigrade (C)"
                    o2 = 0
                Case "Fahrenheit (F)"
                    o2 = 1
                Case "Kelvin (K)"
                    o2 = 2
            End Select

            If (o1 = 0) And (o2 = 0) Then
                'No change
                txtResult.Text = txtInput.Text
            ElseIf (o1 = 0) And (o2 = 1) Then
                'F = (C * 1.8) + 32
                txtResult.Text = (C * 1.8) + 32
            ElseIf (o1 = 0) And (o2 = 2) Then
                txtResult.Text = (C + 273.15)
            ElseIf (o1 = 1) And (o2 = 0) Then
                txtResult.Text = (F - 32) / 1.8
            ElseIf (o1 = 1) And (o2 = 1) Then
                'No change
                txtResult.Text = txtInput.Text
            ElseIf (o1 = 1) And (o2 = 2) Then
                'K = (F + 459.67) / 1.8
                txtResult.Text = (F + 459.67) / 1.8
            ElseIf (o1 = 2) And (o2 = 0) Then
                'K = C + 273.15
                txtResult.Text = C + 273.15
            ElseIf (o1 = 2) And (o2 = 1) Then
                '°F = (K * 1.8) - 459.67
                txtResult.Text = (K * 1.8) - 459.67
            ElseIf (o1 = 2) And (o2 = 2) Then
                'No change
                txtResult.Text = txtInput.Text
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Input Error")
        End Try
    End Sub
End Class
