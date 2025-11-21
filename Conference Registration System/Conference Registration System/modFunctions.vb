Module modFunctions
    Public Sub Clear(ByVal intLoc As Integer)
        Try
            Select Case intLoc
                Case 0
                    frmMain.txtName.Clear()
                    frmMain.txtCompany.Clear()
                    frmMain.txtAddress.Clear()
                    frmMain.txtCity.Clear()
                    frmMain.txtPhone.Clear()
                    frmMain.txtEmail.Clear()
                    frmMain.txtState.Clear()
                    frmMain.txtZip.Clear()
                    frmMain.lblOutput.Text = String.Empty
                Case 1
                    frmOptions.chkConfReg.Checked = False
                    frmOptions.chkDinner.Checked = False
                    frmOptions.lstWorkshop.SelectedIndex = -1
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Clear Error")
        End Try
    End Sub

    Public Function Calc(ByVal blConfReg As Boolean, ByVal blDinner As Boolean, _
    ByVal intWorkshop As Integer) As Integer
        Try
            Dim intWrkshp As Integer = 0

            If blConfReg Then intWrkshp += 895
            If blDinner Then intWrkshp += 30

            If blConfReg Then ' Verify Conference is checked before applying Workshop
                Select Case intWorkshop
                    Case 0 : intWrkshp += 295 ' Intro to E-commerce
                    Case 1 : intWrkshp += 295 ' The Future of the Web
                    Case 2 : intWrkshp += 395 ' Advanced Visual Basic
                    Case 3 : intWrkshp += 395 ' Network Security
                End Select
            End If

            Return (intWrkshp)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Workshop Error")
        End Try
    End Function
End Module
