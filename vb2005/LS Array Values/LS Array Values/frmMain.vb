Public Class frmMain

    Private Sub btnInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInput.Click
        modFunctions.inputArrays(False)
    End Sub

    Private Sub btnMinMax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinMax.Click
        lblSmall.Text = getSmall().ToString
        lblLarge.Text = getLarge().ToString
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        modFunctions.Clear()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnChangeSize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeSize.Click
        modFunctions.changeMaxNumber()
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblArraySize.Text = (ARRAY_SIZE + 1).ToString
    End Sub

    Private Sub btnRandom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRandom.Click
        modFunctions.Clear()
        modFunctions.inputArrays(True)
        lblSmall.Text = getSmall().ToString
        lblLarge.Text = getLarge().ToString
    End Sub
End Class
