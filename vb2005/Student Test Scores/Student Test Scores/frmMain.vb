Option Strict On
Imports System.IO

' Student Test Scores
' Author: Derek Wood
' Created: 20 Apr 2007
' Edited: 28 Apr 2007

' Version History
' 1.0.0.9
' -changed saving sub to use for loops
' -changed show report sub to use for loops
' -removed showing report when printing
' -added clearing of data when opening file
' -cleaned coding

' 1.0.0.8
' -added printing options

' 1.0.0.7
' -added debug on/off ability
' -added more comments
' -cleaned coding

Public Class frmMain

    ' variables for calculations
    Dim STUDENT_COUNT As Integer = 5 ' 6 students (row)
    Dim SCORE_COUNT As Integer = 4 ' 5 scores (columns)
    Dim MAX_SCORE As Integer = 100 ' max score allowed
    Dim MIN_SCORE As Integer = 0 ' min score allowed

    ' main structure of data
    Structure studentData
        Dim name As String
        Dim score() As String
        Dim avg As String
    End Structure

    ' array of structures
    Dim students(STUDENT_COUNT) As studentData

    ' variables for saving features
    Dim blFileNotSaved As Boolean = False
    Dim strFileName As String = "studentData.txt"
    Dim n As String = ControlChars.NewLine

    ' booleans
    Dim blDebug As Boolean = False
    Dim blOverwriteCheck As Boolean = False
    Dim blReport As Boolean = False

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' check for file and open if desired
        If File.Exists(strFileName) Then
            If MessageBox.Show(strFileName.ToUpper & " was found. Would you like to load?", "File Found", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                LoadFile(strFileName)
            End If
        End If
        blFileNotSaved = False
    End Sub

    Private Sub Testing()
        ' test data for debugging/testing purposes
        ' 1
        txtName1.Text = "Student1"
        txtR1C1.Text = "96"
        txtR1C2.Text = "88"
        txtR1C3.Text = "72"
        txtR1C4.Text = "81"
        txtR1C5.Text = "95"

        ' 2
        txtName2.Text = "Student2"
        txtR2C1.Text = "81"
        txtR2C2.Text = "75"
        txtR2C3.Text = "87"
        txtR2C4.Text = "86"
        txtR2C5.Text = "81"

        ' 3
        txtName3.Text = "Student3"
        txtR3C1.Text = "70"
        txtR3C2.Text = "78"
        txtR3C3.Text = "67"
        txtR3C4.Text = "96"
        txtR3C5.Text = "74"

        ' 4
        txtName4.Text = "Student4"
        txtR4C1.Text = "89"
        txtR4C2.Text = "91"
        txtR4C3.Text = "78"
        txtR4C4.Text = "87"
        txtR4C5.Text = "84"

        ' 5
        txtName5.Text = "Student5"
        txtR5C1.Text = "76"
        txtR5C2.Text = "48"
        txtR5C3.Text = "65"
        txtR5C4.Text = "78"
        txtR5C5.Text = "84"

        ' 6
        txtName6.Text = "Student6"
        txtR6C1.Text = "89"
        txtR6C2.Text = "95"
        txtR6C3.Text = "97"
        txtR6C4.Text = "93"
        txtR6C5.Text = "93"
    End Sub

    Public Sub LoadFile(ByVal strFile As String)
        If File.Exists(strFile) Then ' check if file exists
            Dim inputFile As StreamReader
            Dim strArray(STUDENT_COUNT) As String
            Dim strData As String()
            Dim i As Integer

            inputFile = File.OpenText(strFile)

            ' read lines into array
            For i = 0 To (strArray.Length - 1)
                strArray(i) = inputFile.ReadLine
            Next i

            ' need an easier way to split/parse data
            ' first line
            strData = strArray(0).Split(Chr(Asc(",")))
            txtName1.Text = strData(0)
            txtR1C1.Text = strData(1)
            txtR1C2.Text = strData(2)
            txtR1C3.Text = strData(3)
            txtR1C4.Text = strData(4)
            txtR1C5.Text = strData(5)

            ' second line
            strData = strArray(1).Split(Chr(Asc(",")))
            txtName2.Text = strData(0)
            txtR2C1.Text = strData(1)
            txtR2C2.Text = strData(2)
            txtR2C3.Text = strData(3)
            txtR2C4.Text = strData(4)
            txtR2C5.Text = strData(5)

            ' third line
            strData = strArray(2).Split(Chr(Asc(",")))
            txtName3.Text = strData(0)
            txtR3C1.Text = strData(1)
            txtR3C2.Text = strData(2)
            txtR3C3.Text = strData(3)
            txtR3C4.Text = strData(4)
            txtR3C5.Text = strData(5)

            ' fourth line
            strData = strArray(3).Split(Chr(Asc(",")))
            txtName4.Text = strData(0)
            txtR4C1.Text = strData(1)
            txtR4C2.Text = strData(2)
            txtR4C3.Text = strData(3)
            txtR4C4.Text = strData(4)
            txtR4C5.Text = strData(5)

            ' fifth line
            strData = strArray(4).Split(Chr(Asc(",")))
            txtName5.Text = strData(0)
            txtR5C1.Text = strData(1)
            txtR5C2.Text = strData(2)
            txtR5C3.Text = strData(3)
            txtR5C4.Text = strData(4)
            txtR5C5.Text = strData(5)

            ' sixth line
            ' hopefully no more
            strData = strArray(5).Split(Chr(Asc(",")))
            txtName6.Text = strData(0)
            txtR6C1.Text = strData(1)
            txtR6C2.Text = strData(2)
            txtR6C3.Text = strData(3)
            txtR6C4.Text = strData(4)
            txtR6C5.Text = strData(5)

            inputFile.Close() ' close the file
        End If
    End Sub

    Public Sub OpenFile()
        Clear() ' clear boxes

        With ofdOpenFile
            .Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
            .FileName = "empData.txt"
        End With

        If ofdOpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            strFileName = ofdOpenFile.FileName
            LoadFile(strFileName)
        End If

        blFileNotSaved = False
        blOverwriteCheck = False
    End Sub

    Public Sub SaveFile()
        Dim outputFile As StreamWriter
        Dim x As Integer, y As Integer

        LoadStudentData() ' load data again to be certain

        outputFile = File.CreateText(strFileName)

        For x = 0 To students.Length - 1
            outputFile.Write(students(x).name)
            For y = 0 To students(x).score.Length - 1
                outputFile.Write(",") ' delimitor
                outputFile.Write(students(x).score(y))
            Next y
            outputFile.Write(n)
        Next x

        outputFile.Close()

        If blDebug Then MessageBox.Show("File Saved", "Saved") ' test info

        blFileNotSaved = False
        blOverwriteCheck = False
    End Sub

    Private Sub PrintResult()
        txtAvg1.Text = students(0).avg
        txtAvg2.Text = students(1).avg
        txtAvg3.Text = students(2).avg
        txtAvg4.Text = students(3).avg
        txtAvg5.Text = students(4).avg
        txtAvg6.Text = students(5).avg
    End Sub

    Private Sub CalcAverage()
        Dim i As Integer, x As Integer
        Dim intAvg As Integer = 0

        For i = 0 To STUDENT_COUNT
            With students(i)
                For x = 0 To SCORE_COUNT
                    If IsNumeric(.score(x)) = False Then
                        MessageBox.Show("The value [ " & .score(x) & " ] in the " & (x + 1) & " column for " & _
                            .name & " must be an integer.", "Input Invalid")
                        Return
                    End If
                    If CInt(.score(x)) > MAX_SCORE Or CInt(.score(x)) < MIN_SCORE Then
                        MessageBox.Show("The value [ " & .score(x) & " ]  in the " & (x + 1) & " column for " & _
                            .name & " must be between " & MIN_SCORE & " and " & MAX_SCORE & ".", "Input Invalid")
                        Return
                    End If
                    intAvg += CInt(.score(x))
                Next x
                .avg = CStr(intAvg / (SCORE_COUNT + 1))
                intAvg = 0 ' reset the data
            End With
        Next i
    End Sub

    Private Sub LoadStudentData()
        Try
            ' first student
            With students(0)
                .name = txtName1.Text
                ReDim .score(SCORE_COUNT)
                .score(0) = txtR1C1.Text
                .score(1) = txtR1C2.Text
                .score(2) = txtR1C3.Text
                .score(3) = txtR1C4.Text
                .score(4) = txtR1C5.Text
            End With

            ' second student
            With students(1)
                .name = txtName2.Text
                ReDim .score(SCORE_COUNT)
                .score(0) = txtR2C1.Text
                .score(1) = txtR2C2.Text
                .score(2) = txtR2C3.Text
                .score(3) = txtR2C4.Text
                .score(4) = txtR2C5.Text
            End With

            ' third student
            With students(2)
                .name = txtName3.Text
                ReDim .score(SCORE_COUNT)
                .score(0) = txtR3C1.Text
                .score(1) = txtR3C2.Text
                .score(2) = txtR3C3.Text
                .score(3) = txtR3C4.Text
                .score(4) = txtR3C5.Text
            End With

            ' fourth student
            With students(3)
                .name = txtName4.Text
                ReDim .score(SCORE_COUNT)
                .score(0) = txtR4C1.Text
                .score(1) = txtR4C2.Text
                .score(2) = txtR4C3.Text
                .score(3) = txtR4C4.Text
                .score(4) = txtR4C5.Text
            End With

            ' fifth student
            With students(4)
                .name = txtName5.Text
                ReDim .score(SCORE_COUNT)
                .score(0) = txtR5C1.Text
                .score(1) = txtR5C2.Text
                .score(2) = txtR5C3.Text
                .score(3) = txtR5C4.Text
                .score(4) = txtR5C5.Text
            End With

            ' sixth student
            With students(5)
                .name = txtName6.Text
                ReDim .score(SCORE_COUNT)
                .score(0) = txtR6C1.Text
                .score(1) = txtR6C2.Text
                .score(2) = txtR6C3.Text
                .score(3) = txtR6C4.Text
                .score(4) = txtR6C5.Text
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Load Error")
        End Try
    End Sub

    Private Sub Clear()
        ' clear the textboxes
        ' first row
        txtName1.Text = String.Empty
        txtR1C1.Text = String.Empty
        txtR1C2.Text = String.Empty
        txtR1C3.Text = String.Empty
        txtR1C4.Text = String.Empty
        txtR1C5.Text = String.Empty
        txtAvg1.Text = String.Empty

        ' second row
        txtName2.Text = String.Empty
        txtR2C1.Text = String.Empty
        txtR2C2.Text = String.Empty
        txtR2C3.Text = String.Empty
        txtR2C4.Text = String.Empty
        txtR2C5.Text = String.Empty
        txtAvg2.Text = String.Empty

        ' third row
        txtName3.Text = String.Empty
        txtR3C1.Text = String.Empty
        txtR3C2.Text = String.Empty
        txtR3C3.Text = String.Empty
        txtR3C4.Text = String.Empty
        txtR3C5.Text = String.Empty
        txtAvg3.Text = String.Empty

        ' fourth row
        txtName4.Text = String.Empty
        txtR4C1.Text = String.Empty
        txtR4C2.Text = String.Empty
        txtR4C3.Text = String.Empty
        txtR4C4.Text = String.Empty
        txtR4C5.Text = String.Empty
        txtAvg4.Text = String.Empty

        ' fifth row
        txtName5.Text = String.Empty
        txtR5C1.Text = String.Empty
        txtR5C2.Text = String.Empty
        txtR5C3.Text = String.Empty
        txtR5C4.Text = String.Empty
        txtR5C5.Text = String.Empty
        txtAvg5.Text = String.Empty

        ' sixth row
        txtName6.Text = String.Empty
        txtR6C1.Text = String.Empty
        txtR6C2.Text = String.Empty
        txtR6C3.Text = String.Empty
        txtR6C4.Text = String.Empty
        txtR6C5.Text = String.Empty
        txtAvg6.Text = String.Empty

        ' reset file saved boolean
        blFileNotSaved = False

        ' clear structures
        Dim i As Integer
        For i = 0 To STUDENT_COUNT
            ReDim students(i)
        Next i
    End Sub

    Private Sub PrintData()
        ' add information to the txtReport
        Dim x As Integer, y As Integer
        Dim intAvg As Integer

        txtReport.Text = String.Empty ' Clear

        txtReport.Text &= "STUDENT DATA REPORT" & n
        txtReport.Text &= "--------------------------------------------" & n & n

        For x = 0 To students.Length - 1
            txtReport.Text &= "Student Name: " & students(x).name & n
            txtReport.Text &= "Test Scores: "
            For y = 0 To students(x).score.Length - 1
                If Not y = 0 Then txtReport.Text &= ", " ' delimitor
                txtReport.Text &= students(x).score(y)
            Next y
            txtReport.Text &= n & "Average: " & students(x).avg & n & n
            intAvg += CInt(students(x).avg)
        Next x

        txtReport.Text &= "--------------------------------------------" & n
        txtReport.Text &= "Total Average: " & Format((intAvg / (STUDENT_COUNT + 1)), "0.00")
    End Sub

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        LoadStudentData() ' store textboxes into structures
        CalcAverage() ' calculate average
        PrintResult() ' set textbox averages
        blReport = True
    End Sub

    Private Sub mnuReportPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReportPrint.Click
        If blReport Then
            PrintData() ' print textbox information to result textbox
            grpReport.Visible = True
            btnHide.Visible = True
        Else
            MessageBox.Show("You have not calculated the averages yet", "Error")
        End If
    End Sub

    Private Sub btnHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHide.Click
        grpReport.Visible = False
        btnHide.Visible = False
    End Sub

    Private Sub mnuHelpAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelpAbout.Click
        frmAbout.Show()
    End Sub

    Private Sub mnuFileNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileNew.Click
        If blFileNotSaved Then
            If MessageBox.Show("The current file has not been saved.  Are you sure?", _
                "Opened File", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Clear()
                blOverwriteCheck = True
            End If
        Else
            Clear()
            blOverwriteCheck = True
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
        If blFileNotSaved Or blOverwriteCheck Then
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

    Private Sub btnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTest.Click
        Testing()
    End Sub

    Private Sub mnuFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileExit.Click
        If blFileNotSaved Then
            If MessageBox.Show("The current file has not been saved.  Are you sure?", _
                "Opened File", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub mnuHelpDebugOn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelpDebugOn.Click
        MessageBox.Show("You have enabled Debugging.  This is for testing purposes only.", "Debug Started")
        blDebug = True
        btnTest.Visible = True
    End Sub

    Private Sub mnuHelpDebugOff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelpDebugOff.Click
        blDebug = False
        btnTest.Visible = False
    End Sub


    Private Sub mnuFilePrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFilePrint.Click
        If blReport Then
            If pdPrint.ShowDialog = Windows.Forms.DialogResult.OK Then
                PrintData() ' print textbox information to result textbox
                pdPrintDoc.Print()
            End If

        Else
            MessageBox.Show("Please make sure input is entered and averages are calculated.", "Error")
        End If
    End Sub

    Private Sub pdPrint_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles pdPrintDoc.PrintPage
        ' Print contents of a text box
        e.Graphics.DrawString(txtReport.Text, New Font("MS Sans Serif", 12, FontStyle.Regular), Brushes.Black, 10, 10)
    End Sub

    Private Sub TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName1.TextChanged, _
        txtName2.TextChanged, txtName3.TextChanged, txtName4.TextChanged, txtName5.TextChanged

        blFileNotSaved = True
        blReport = False
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        txtR1C1.TextChanged, txtR1C2.TextChanged, txtR1C3.TextChanged, txtR1C4.TextChanged, txtR1C5.TextChanged, _
        txtR2C1.TextChanged, txtR2C2.TextChanged, txtR2C3.TextChanged, txtR2C4.TextChanged, txtR2C5.TextChanged, _
        txtR3C1.TextChanged, txtR3C2.TextChanged, txtR3C3.TextChanged, txtR3C4.TextChanged, txtR3C5.TextChanged, _
        txtR4C1.TextChanged, txtR4C2.TextChanged, txtR4C3.TextChanged, txtR4C4.TextChanged, txtR4C5.TextChanged, _
        txtR5C1.TextChanged, txtR5C2.TextChanged, txtR5C3.TextChanged, txtR5C4.TextChanged, txtR5C5.TextChanged, _
        txtR6C1.TextChanged, txtR6C2.TextChanged, txtR6C3.TextChanged, txtR6C4.TextChanged, txtR6C5.TextChanged

        ' possibly check for isNumeric or within MAX and MIN SCORE
        blFileNotSaved = True
        blReport = False
    End Sub
End Class
