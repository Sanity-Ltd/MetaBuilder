﻿Module Parse
    'Module is for parsing data.  Combining and seperating strings

    'Public Vars for passing data for Any/All DataTable
    Public AnyAllString As String
    Public MultipleString As String


    Function CombineTwoVal(ByVal String1 As String, ByVal String2 As String, ByVal Result As String) As String
        Result = String1 + ";" + String2
        Return (Result)
    End Function
    Function SplitTwoVal(ByVal TwoValues As Array) As Array

        'Cant get this to work, and easy to do in code

        Dim String1 As String = TwoValues(0)
        'Dim cData As String = selectedRow.Cells(2).Value
        'Dim StringSplit() As String
        TwoValues = Split(String1, ";")
        'txtBoxCData.Text = StringSplit(0)
        'txtBoxCData2.Text = StringSplit(1)
        'Result1 = ""
        'result2 = ""
        Return (TwoValues)
    End Function

    Function CombineThreeVal(ByVal String1 As String, ByVal String2 As String, ByVal Result As String) As String
        Result = String1 + ";" + String2 + ";" + Result
        Return (Result)
    End Function

    Sub CombineAnyAll()
        Dim tempdata As String = ""

        For Each r As DataGridViewRow In frmMain.dgvAnyAll.Rows

            If (r.Cells(0).Value IsNot Nothing) Then
                tempdata = tempdata & (r.Cells(0).Value.ToString) & "{" & (r.Cells(1).Value.ToString) & "}"
            Else
                'MsgBox("Value is Nothing - Parse.CombineAnyAll")
            End If

        Next
        AnyAllString = tempdata
    End Sub
    Sub CombineMultiple()
        Dim tempdata As String = ""

        For Each r As DataGridViewRow In frmMain.dgvATMultiple.Rows

            If (r.Cells(0).Value IsNot Nothing) Then
                tempdata = tempdata & (r.Cells(0).Value.ToString) & "{" & (r.Cells(1).Value.ToString) & "}"
            Else
                'MsgBox("Value is Nothing - Parse.CombineAnyAll")
            End If

        Next
        MultipleString = tempdata
    End Sub
    Function NestedMultiple(MultiOne As String) As String



        Return MultiOne
    End Function

    Sub SplitingStrings()
        Dim StringSplit As String = ""

        For Each s As String In StringSplit
            Dim tempstring() As String
            tempstring = Split(s, "{")
            ' Spliting Mulitples
            If tempstring(0) = "Multiple" Then
                's = s.Length - 1
                'TableATMultiple.Rows.Add("Multiple", Adata.Remove(0, 9))
                Exit For
            ElseIf tempstring(0) = "" Then
                Exit For
            Else
                'TableATMultiple.Rows.Add(tempstring(0), tempstring(1))
            End If
        Next


    End Sub
End Module
