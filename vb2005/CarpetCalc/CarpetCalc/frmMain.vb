Public Class frmMain

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        Dim CarpetArea As Single

        CarpetArea = CSng(txtLength.Text) * CSng(txtWidth.Text)
        txtArea.Text = CarpetArea.ToString
    End Sub
End Class
