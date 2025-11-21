Module modFunctions

    Public Sub inputArrays(ByVal isRand As Boolean)
        Try
            Dim i As Integer
            For i = 0 To (intArray.Length - 1)
                If isRand Then
                    intArray(i) = rand.Next(100)
                Else
                    intArray(i) = CInt(InputBox("(" & (i + 1) & ") " & "Enter the number into the array:", "Input Values", _
                        rand.Next(100).ToString))
                End If
            Next i
            ListAdd()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Input Error")
        End Try
    End Sub

    ' To append to the Listbox
    Public Sub ListAdd()
        Try
            Dim i As Integer
            frmMain.lstArray.Items.Add("Input Values")
            For i = 0 To ARRAY_SIZE
                frmMain.lstArray.Items.Add(intArray(i))
            Next i
        Catch ex As Exception
            MessageBox.Show(ex.Message, "List Add Error")
        End Try
    End Sub

    Public Sub Clear()
        Try
            frmMain.lstArray.Items.Clear()
            frmMain.lblSmall.Text = String.Empty
            frmMain.lblLarge.Text = String.Empty

            ' Clear the Array
            Dim i As Integer
            For i = 0 To (intArray.Length - 1)
                intArray(i) = 0
            Next i
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Clear Error")
        End Try
    End Sub

    Public Sub changeMaxNumber()
        Try
            Clear()
            ARRAY_SIZE = CInt(InputBox("Enter the new maximum number of Input Values:", "Maximum Number"))

            If ARRAY_SIZE > 500 Then
                MessageBox.Show("Sorry the Max is 500")
                ARRAY_SIZE = 500
            End If

            ARRAY_SIZE -= 1
            ReDim Preserve intArray(ARRAY_SIZE)
            frmMain.lblArraySize.Text = (ARRAY_SIZE + 1).ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Array Size Error")
        End Try
    End Sub

    ' Determine the smallest value in the Array
    Public Function getSmall() As Integer
        Try
            Dim i As Integer
            Dim x As Integer = intArray(0)
            For i = 0 To (intArray.Length - 1)
                If intArray(i) < x Then
                    x = intArray(i)
                End If
            Next i
            Return x
        Catch ex As Exception
            Return 0
            MessageBox.Show(ex.Message, "Get Smallest Error")
        End Try
    End Function

    ' Determine the largest value in the Array
    Public Function getLarge() As Integer
        Try
            Dim i As Integer
            Dim x As Integer = intArray(0)
            For i = 0 To (intArray.Length - 1)
                If intArray(i) > x Then
                    x = intArray(i)
                End If
            Next i
            Return x
        Catch ex As Exception
            Return 0
            MessageBox.Show(ex.Message, "Get Largest Error")
        End Try
    End Function
End Module
