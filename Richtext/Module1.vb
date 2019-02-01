Imports System.Data.SqlClient
Module Module1
    Public Con As New SqlConnection

    Public BranchName, BrName, PgAccess, ErFlag As String
    Public Sub OpenCon()
        If Con.State = ConnectionState.Closed Then

            Con.ConnectionString = "Data Source=IP;Initial Catalog=NDA_DATABASECBT;Integrated Security=True;MultipleActiveResultSets=true"
            'Con.ConnectionString = "Data Source=162.222.225.88;Initial Catalog=POS_PGM;Persist Security Info=True;User ID=pgm;Password=Prime2018@;MultipleActiveResultSets=true;"
            Con.Open()
        End If
    End Sub
    Public Sub CloseCon()
        If Con.State = ConnectionState.Open Then
            Con.Close()
            Con.Dispose()
        End If
    End Sub
    Public Sub GetPageAccess(ByVal PGName As String, UNAccess As String, PWAccess As String)
        Dim CMD As New SqlCommand
        If Con.State = ConnectionState.Closed Then
            OpenCon()
        End If
        CMD.Connection = Con
        CMD.CommandText = ("Select *FROM UserMenu_Tbl Where UsName='" & UNAccess & "' And PWord='" & PWAccess & "'  And PageName='" & PGName & "'")
        Dim Reader As SqlDataReader
        Reader = CMD.ExecuteReader
        If Reader.HasRows Then
            Reader.Read()
            BranchName = Reader.Item("Branch").ToString
            BrName = Reader.Item("Branch").ToString
            Reader.Close()
            CloseCon()
            PgAccess = "YES"
            Exit Sub
        Else
            PgAccess = "NO"
            BranchName = ""
            Reader.Close()
        End If
    End Sub
    Public Function CheckNumbers(ByVal TxtBox As String)
        Dim iQ As Integer
        For iQ = 1 To Len(TxtBox)
            If IsNumeric(Mid(TxtBox, iQ, 1)) Then
                ErFlag = "Digit Value Is Not Allowed. Please, Verify And Try Again."
                Exit For
            End If
        Next
        Return 0
    End Function
    Public Function CheckNChar(ByVal TxtBox As String)
        Dim iQ As Integer
        For iQ = 1 To Len(TxtBox)
            If Not IsNumeric(Mid(TxtBox, iQ, 1)) Then
                ErFlag = "Alphabet Is Not Allowed. Please, Verify And Try Again."
                Exit For
            End If
        Next
        Return 0
    End Function
    Public Function CheckXter(ByVal TxtBox As String)
        Dim iQ As Integer
        For iQ = 1 To Len(TxtBox)
            If Mid(TxtBox, iQ, 1) = "@" Then
                ErFlag = "Invalid Characters : @, £, %, *, +, #, ', &, $, !, =, ;, |, ?, -, /"
                Exit For
            ElseIf Mid(TxtBox, iQ, 1) = "£" Then
                ErFlag = "Invalid Characters : @, £, %, *, +, #, ', &, $, !, =, ;, |, ?, -, /"
                Exit For
            ElseIf Mid(TxtBox, iQ, 1) = "%" Then
                ErFlag = "Invalid Characters : @, £, %, *, +, #, ', &, $, !, =, ;, |, ?, -, /"
                Exit For
            ElseIf Mid(TxtBox, iQ, 1) = "*" Then
                ErFlag = "Invalid Characters : @, £, %, *, +, #, ', &, $, !, =, ;, |, ?, -, /"
                Exit For
            ElseIf Mid(TxtBox, iQ, 1) = "+" Then
                ErFlag = "Invalid Characters : @, £, %, *, +, #, ', &, $, !, =, ;, |, ?, -, /"
                Exit For
            ElseIf Mid(TxtBox, iQ, 1) = "#" Then
                ErFlag = "Invalid Characters : @, £, %, *, +, #, ', &, $, !, =, ;, |, ?, -, /"
                Exit For
            ElseIf Mid(TxtBox, iQ, 1) = "'" Then
                ErFlag = "Invalid Characters : @, £, %, *, +, #, ', &, $, !, =, ;, |, ?, -, /"
                Exit For
            ElseIf Mid(TxtBox, iQ, 1) = "&" Then
                ErFlag = "Invalid Characters : @, £, %, *, +, #, ', &, $, !, =, ;, |, ?, -, /"
                Exit For
            ElseIf Mid(TxtBox, iQ, 1) = "$" Then
                ErFlag = "Invalid Characters : @, £, %, *, +, #, ', &, $, !, =, ;, |, ?, -, /"
                Exit For
            ElseIf Mid(TxtBox, iQ, 1) = "=" Then
                ErFlag = "Invalid Characters : @, £, %, *, +, #, ', &, $, !, =, ;, |, ?, -, /"
                Exit For
            ElseIf Mid(TxtBox, iQ, 1) = "!" Then
                ErFlag = "Invalid Characters : @, £, %, *, +, #, ', &, $, !, =, ;, |, ?, -, /"
                Exit For
            ElseIf Mid(TxtBox, iQ, 1) = ";" Then
                ErFlag = "Invalid Characters : @, £, %, *, +, #, ', &, $, !, =, ;, |, ?, -, /"
                Exit For
            ElseIf Mid(TxtBox, iQ, 1) = "|" Then
                ErFlag = "Invalid Characters : @, £, %, *, +, #, ', &, $, !, =, ;, |, ?, -, /"
                Exit For
            ElseIf Mid(TxtBox, iQ, 1) = "?" Then
                ErFlag = "Invalid Characters : @, £, %, *, +, #, ', &, $, !, =, ;, |, ?, -, /"
                Exit For
            ElseIf Mid(TxtBox, iQ, 1) = "-" Then
                ErFlag = "Invalid Characters : @, £, %, *, +, #, ', &, $, !, =, ;, |, ?, -, /"
                Exit For
            ElseIf Mid(TxtBox, iQ, 1) = "=" Then
                ErFlag = "Invalid Characters : @, £, %, *, +, #, ', &, $, !, =, ;, |, ?, -, /"
                Exit For
            ElseIf Mid(TxtBox, iQ, 1) = "=" Then
                ErFlag = "Invalid Characters : @, £, %, *, +, #, ', &, $, !, =, ;, |, ?, -, /"
                Exit For
            Else
                ErFlag = ""
            End If
        Next
        Return ErFlag
    End Function

End Module
