Public Class frmMain

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnShowInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowInfo.Click
        lblName.Text = "Derek Wood"
        lblStreet.Text = "Street"
        lblCityStateZip.Text = "City, State Zip"
    End Sub

End Class