Option Strict On
Imports System.IO

Public Class frmMain

    ' Define Employee Data Structure
    Structure empData
        Dim strFirstName As String
        Dim strMidName As String
        Dim strLastName As String
        Dim strEmpNum As String
        Dim strDepartment As String
        Dim strTelephone As String
        Dim strExtension As String
        Dim strEmail As String
    End Structure

    Dim blFileNotSaved As Boolean = False
    Dim strFileName As String = "empData.txt"

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Check for File and Open If Capable
        LoadFile(strFileName)
        blFileNotSaved = False
    End Sub

    'Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.ComponentModel.FormClosingEventArgs) Handles MyBase.FormClosing
    '    If blFileNotSaved Then
    '        If MessageBox.Show("The current file has not been saved.  Are you sure?", _
    '            "Opened File", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
    '            SaveFile()
    '        End If
    '    Else
    '        SaveFile()
    '    End If
    'End Sub

    Public Sub LoadFile(ByVal strFile As String)
        If File.Exists(strFile) Then
            Dim inputFile As StreamReader
            Dim strValues(8) As String
            Dim i As Integer
            Dim tmpData As empData

            inputFile = File.OpenText(strFile)
            For i = 0 To (strValues.Length - 1)
                strValues(i) = inputFile.ReadLine
            Next i
            inputFile.Close()

            With tmpData
                .strFirstName = strValues(0)
                .strMidName = strValues(1)
                .strLastName = strValues(2)
                .strEmpNum = strValues(3)
                .strDepartment = strValues(4)
                .strTelephone = strValues(5)
                .strExtension = strValues(6)
                .strEmail = strValues(7)
            End With

            txtFirstName.Text = tmpData.strFirstName
            txtMidName.Text = tmpData.strMidName
            txtLastName.Text = tmpData.strLastName
            txtEmpNum.Text = tmpData.strEmpNum
            cboDepartment.SelectedItem = tmpData.strDepartment
            txtTelephone.Text = tmpData.strTelephone
            txtExtension.Text = tmpData.strExtension
            txtEmail.Text = tmpData.strEmail
        End If
    End Sub

    Public Sub OpenFile()
        With ofdOpenFile
            .Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
            .FileName = "empData.txt"
        End With

        If ofdOpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            strFileName = ofdOpenFile.FileName
            LoadFile(strFileName)
        End If
        blFileNotSaved = False
    End Sub

    Public Sub SaveFile()
        Dim outputFile As StreamWriter
        Dim tmpData As empData
        Dim n As String = ControlChars.NewLine

        With tmpData
            .strFirstName = txtFirstName.Text
            .strMidName = txtMidName.Text
            .strLastName = txtLastName.Text
            .strEmpNum = txtEmpNum.Text
            .strDepartment = cboDepartment.SelectedItem.tostring
            .strTelephone = txtTelephone.Text
            .strExtension = txtExtension.Text
            .strEmail = txtEmail.Text
        End With

        outputFile = File.CreateText(strFileName)

        outputFile.Write(tmpData.strFirstName & n)
        outputFile.Write(tmpData.strMidName & n)
        outputFile.Write(tmpData.strLastName & n)
        outputFile.Write(tmpData.strEmpNum & n)
        outputFile.Write(tmpData.strDepartment & n)
        outputFile.Write(tmpData.strTelephone & n)
        outputFile.Write(tmpData.strExtension & n)
        outputFile.Write(tmpData.strEmail & n)

        outputFile.Close()

        MessageBox.Show("File Saved", "Saved")
        blFileNotSaved = False
    End Sub

    Public Sub Clear()
        txtFirstName.Text = String.Empty
        txtMidName.Text = String.Empty
        txtLastName.Text = String.Empty
        txtEmpNum.Text = String.Empty
        cboDepartment.SelectedIndex = -1
        txtTelephone.Text = String.Empty
        txtExtension.Text = String.Empty
        txtEmail.Text = String.Empty
        blFileNotSaved = False
    End Sub

    Private Sub mnuFileNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileNew.Click
        If blFileNotSaved Then
            If MessageBox.Show("The current file has not been saved.  Are you sure?", _
                "Opened File", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Clear()
            End If
        Else
            Clear()
        End If
    End Sub

    Private Sub mnuFileOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileOpen.Click
        If blFileNotSaved Then
            If MessageBox.Show("The current file has not been saved.  Are you sure?", _
                "Opened File", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                OpenFile()
            End If
        Else
            OpenFile()
        End If
    End Sub

    Private Sub mnuFileSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileSave.Click
        If blFileNotSaved Then
            With sfdSaveFile
                .Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    strFileName = sfdSaveFile.FileName
                    SaveFile()
                End If
            End With
        Else
            SaveFile()
        End If
    End Sub

    Private Sub mnuFileSaveAs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileSaveAs.Click
        With sfdSaveFile
            .Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
            .Title = "Save File As"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                strFileName = sfdSaveFile.FileName
                SaveFile()
            End If
        End With
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub menuFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    Private Sub mnuFileClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuToolsClear.Click
        Clear()
    End Sub

    Private Sub mnuHelpAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelpAbout.Click
        frmAbout.Show()
    End Sub

    Private Sub TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFirstName.TextChanged, _
        txtMidName.TextChanged, txtLastName.TextChanged, txtEmpNum.TextChanged, cboDepartment.SelectedIndexChanged, _
        txtTelephone.TextChanged, txtExtension.TextChanged, txtEmail.TextChanged
        blFileNotSaved = True
    End Sub
End Class
