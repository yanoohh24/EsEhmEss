Imports MySql.Data.MySqlClient

Module bmg_module
    Public DynamicBranchCode As String

    Public FooterSMS As String
    Public UserAndBranchName As String

    Function PX_MrMs(ByVal px_gender As String) As String
        Select Case px_gender
            Case "MALE"
                PX_MrMs = "Mr. "
            Case "FEMALE"
                PX_MrMs = "Ms. "
            Case Else
                PX_MrMs = ""
        End Select
    End Function
    Function PX_SMS_Status(ByVal SMSStatus As Integer) As String
        Select Case SMSStatus
            Case 0
                PX_SMS_Status = "OFF"
            Case 1
                PX_SMS_Status = "ON"
            Case Else
                PX_SMS_Status = "UNKNOW"
        End Select
    End Function
    Function DirectionType(ByVal Direction As Integer) As String
        Select Case Direction
            Case 1
                DirectionType = "IN"
            Case 2
                DirectionType = "OUT"
            Case Else
                DirectionType = "UNKNOW"
        End Select
    End Function
    Function DirectionFromTo(ByVal Direction As Integer) As String
        Select Case Direction
            Case 1
                DirectionFromTo = "From: "
            Case 2
                DirectionFromTo = "Sent to: "
            Case Else
                DirectionFromTo = "UNKNOW: "
        End Select
    End Function
    Function ServiceListName(ByVal id As String) As String
        Try
            id = Replace(id.Trim, "'", "\'")

            Dim sql As String = "SELECT full_description FROM `master_list` WHERE id='" & id & "'"
            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(sql, connection)
            Dim reader As MySqlDataReader
            connection.Open()
            reader = cmd.ExecuteReader()

            If reader.HasRows = True Then
                While reader.Read
                    ServiceListName = reader.Item("full_description").ToString.Trim()
                End While

            End If
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Function Pop_Out_SMS(ByVal SQL As String) As String
        Try
            Dim connection As New MySqlConnection(connStrSMS)
            Dim cmd As New MySqlCommand(SQL, connection)
            Dim reader As MySqlDataReader
            connection.Open()
            reader = cmd.ExecuteReader()

            If reader.HasRows = True Then
                While reader.Read
                    Pop_Out_SMS = reader.Item("TTL").ToString()
                End While

            Else
                Pop_Out_SMS = "0"
            End If

            connection.Close()
        Catch ex As Exception
            Pop_Out_SMS = "0"
            MsgBox(ex.Message)
        End Try
    End Function

End Module
