Imports MySql.Data.MySqlClient

Module connection_setting
    Public FFAcountInfo As New frmAccntInfo()
    Public FFAdminRight As New frmAdminRights()

    Public FFContacts As New frmContacts()
    Public FFContactsImport As New frmContactsImport()
    Public FFContactsProfile As New frmContactsProfile()

    Public FFBranchFooter As New frmUserBranchFooter()
    Public FFUserAccess As New frmUserAccess()
    Public FFUserAccessGroup As New frmUserAccessGroup()
    Public FFUserUpdateProfile As New frmUserUpdateProfile()
    Public FFUserAdd As New frmUserAdd()

    Public FFBirthday As New frmSMSBirthday()
    Public FFLogin As New frmLogin()
    Public FFFullBlastSMS As New frmSMSFullBlast()
    Public FFPatientsSMS As New frmPatientSMS()

    Public FFEmployeeSMS As New frmEmployee()

    Public FFSMSUpdate As New frmSMSUpdate()

    Public FFNewSMS As New frmSMSNew()
    Public FFResend As New frmSMSResend()
    Public FFSendSMS As New frmSMSSend()
    Public FFReplySMS As New frmSMSReply()
    Public FFPatients As New frmPatientsList()
    Public FFSMS As New frmSMS()
    Public FFPxProfile As New frmPatientProfile()
    Public FFMain As New frmMain()

    Public Host As String = "192.168.100.172" ' "192.168.100.250"
    Public UserName As String ="root"         ' "admin"
    Public Password As String = "belo"        ' "webdeveoper"

    'User Information
    Public ClientName As String = "Belo"
    Public ClientUsername As String
    Public ClientPassword As String
    Public ClientDepartment As String
    Public ClientDepartmentKey As String
    Public ClientBranch As String
    Public ClientBranchName As String
    Public ClientBranchContact As String
    Public ClientBranchAddress As String
    Public ClientBranchDBName As String

    'User Access Setting
    Public ClientAccAdmin As String
    Public ClientSMSAdmin As String
    Public ClientSMSInbox As String
    Public ClientFullBlast As String
    Public ClientPxList As String
    Public ClientContacts As String
    Public ClientSendSMS As String
    Public ClientBirthday As String
    Public ClientAsDept As String
    Public ClientUserAccessGroup As String

    'Computer Information
    Public ClientHostIP As String
    Public ClientHostName As String

    'End Footer
    Public Branch_End_Footer As String
    Public Department_End_Footer As String

    Public connStrSMS As String = "Database=Messages_tester;Data Source=" & Host & ";User Id=" & UserName & ";Password=" & Password & ";UseCompression=True;Connection Timeout=28800"
    Public connStrBMG As String = " Database=belo_database_test;Data Source=" & Host & ";User Id=" & UserName & ";Password=" & Password & ";UseCompression=True;Connection Timeout=28800;Convert Zero Datetime=True"
       
 Public Structure UsertInformation
        Dim username As String
        Dim password As String
        Dim name As String
        Dim branch As String
    End Structure


    Function UserClientIformation(ByVal lg_username As String, ByVal lg_password As String) As Integer
        Try
            lg_username = Replace(lg_username, "'", "\'")
            FFLogin.lbDBconnection.Text = ""

            Dim sql As String = "SELECT username, PASSWORD,user_access_group,branch, (SELECT NAME FROM `ref_branch` WHERE CODE=branch) AS branchName, (SELECT db_name FROM `ref_branch` WHERE CODE=branch) AS db_name," _
            & " firstname AS ClietName,IFNULL(acc_admin,'0') acc_admin,acc_sms,acc_sms_admin,acc_sms_fullblast,acc_sms_pxlist,acc_sms_send,as_dept, " _
            & " (SELECT contact_number FROM `ref_branch` WHERE CODE=branch) AS contact_number  FROM `user_account_backend` WHERE username ='" & lg_username & "'"

            sql = "SELECT username, PASSWORD,user_access_group,branch,(SELECT NAME FROM `ref_branch` WHERE CODE=branch) AS branchName, " _
            & " IFNULL((SELECT department_name FROM ref_user_access WHERE group_name=user_access_group),'') AS department, " _
            & " IFNULL((SELECT department_key FROM ref_user_access WHERE group_name=user_access_group),'') AS department_key, " _
            & " (SELECT db_name FROM `ref_branch` WHERE CODE=branch) AS db_name, firstname AS ClientName,IFNULL(acc_admin,'0') acc_admin,acc_sms, " _
            & " acc_sms_admin,acc_sms_fullblast,acc_sms_pxlist,acc_sms_contacts,acc_sms_send,acc_sms_birthday,as_dept, (SELECT contact_number FROM `ref_branch` WHERE CODE=branch) AS contact_number  FROM `user_account_backend` WHERE username ='" & lg_username & "'"

            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(sql, connection)
            Dim reader As MySqlDataReader
            connection.Open()
            reader = cmd.ExecuteReader()

            If reader.HasRows = True Then
                While reader.Read
                    ClientUsername = reader.Item("username").ToString.Trim()
                    ClientPassword = reader.Item("PASSWORD").ToString.Trim()
                    ClientDepartment = reader.Item("department").ToString.Trim()
                    ClientDepartmentKey = reader.Item("department_key").ToString.Trim()
                    ClientUserAccessGroup = reader.Item("user_access_group").ToString.Trim()
                    ClientBranch = reader.Item("branch").ToString.Trim()
                    ClientBranchDBName = reader.Item("db_name").ToString.Trim()
                    ClientName = reader.Item("ClientName").ToString.Trim()
                    ClientBranchName = reader.Item("branchName").ToString.Trim()
                    ClientBranchContact = reader.Item("contact_number").ToString.Trim()
                    ClientAccAdmin = reader.Item("acc_admin").ToString.Trim()
                    ClientSMSAdmin = reader.Item("acc_sms_admin").ToString.Trim()
                    ClientSMSInbox = reader.Item("acc_sms").ToString.Trim()
                    ClientFullBlast = reader.Item("acc_sms_fullblast").ToString.Trim()
                    ClientPxList = reader.Item("acc_sms_pxlist").ToString.Trim()
                    ClientContacts = reader.Item("acc_sms_contacts").ToString.Trim()
                    ClientSendSMS = reader.Item("acc_sms_send").ToString.Trim()
                    ClientBirthday = reader.Item("acc_sms_birthday").ToString.Trim()
                    ClientAsDept = reader.Item("as_dept").ToString.Trim()
                End While

                If lg_password = ClientPassword Then
                    UserClientIformation = 1
                Else
                    UserClientIformation = 2
                End If
            Else
                UserClientIformation = 0
            End If
            connection.Close()
        Catch ex As Exception
            UserClientIformation = 88
            'MsgBox(ex.Message, MsgBoxStyle.Information, "Belo SMS:Login")
        End Try
    End Function
    Function ResultSQL(ByVal SQL As String) As String
        Try

            Dim connection As New MySqlConnection(connStrSMS)
            Dim cmd As New MySqlCommand(SQL, connection)
            Dim reader As MySqlDataReader
            connection.Open()
            reader = cmd.ExecuteReader()

            If reader.HasRows = True Then
                While reader.Read
                    ResultSQL = reader.Item("TTL").ToString()
                End While
            Else
                ResultSQL = "0"
            End If
            connection.Close()
        Catch ex As Exception
            ResultSQL = "0"
        End Try
    End Function


    Function ResultCount(ByVal SQL As String) As Integer
        Try
            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(SQL, connection)
            Dim reader As MySqlDataReader
            connection.Open()
            reader = cmd.ExecuteReader()

            If reader.HasRows = True Then
                While reader.Read
                    ResultCount = reader.Item("TTL").ToString()
                End While

            Else
                ResultCount = "0"
            End If
            connection.Close()
        Catch ex As Exception
            ResultCount = "0"
        End Try
    End Function
    Function CommandXpertSMS(ByVal msg As String, ByVal Validity As Integer, ByVal PatientID As String, ByVal EmpMobile As String) As Integer
        Try
            Dim SMSmsg As String
            Dim query As String
            Dim MBchk As String = EmpMobile
            MBchk = Mid(MBchk, 1, 4)

            SMSmsg = Replace(msg, "'", "\'")

            Dim _DeptKey As String = FFMain.KeyToolStrip.Text.Trim

            If MBchk = "+639" Then

                If Len(EmpMobile) = 13 Then
                    'query = "INSERT INTO Messages SET DirectionID=2, TypeID=2, StatusDetails=200, Status=1, ChannelID=0, Recipient='" & EmpMobile & "', " _
                    '& " Body='" & SMSmsg & "',validity=" & Validity & ", branch='" & _DeptKey & "', PatientID='" & PatientID & "', Username='" & ClientUsername & "', UserHostName='" & ClientHostName & "', UserHostIP='" & ClientHostIP & "'"
                    
                    
                    'SEND DETAILS
                    'TYPE = SMS(1)
                    'STATUS = PENDING(1)
                    'DIRECTION = OUT(2)
                    'FromAddress = Sender : ToAddress = Recipient

                    query = "INSERT INTO Messages SET DirectionID=2, TypeID=1, StatusDetailsID=200, StatusID=1, ChannelID=0, FromAddress = '+639479956255', ToAddress='" & EmpMobile & "', " _
                    & " Body='" & SMSmsg & "',validity=" & Validity & ", branch='" & _DeptKey & "', PatientID='" & PatientID & "', Username='" & ClientUsername & "', UserHostName='" & ClientHostName & "', UserHostIP='" & ClientHostIP & "'"

                    Dim rowsEffected As Integer = 0
                    Dim connection As New MySqlConnection(connStrSMS)
                    Dim cmd As New MySqlCommand(query, connection)

                    connection.Open()

                    rowsEffected = cmd.ExecuteNonQuery()

                    connection.Close()

                    Return rowsEffected

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function
    Function CommandXpertSMS_Birthday(ByVal msg As String, ByVal Validity As Integer, ByVal PatientID As String, ByVal branch As String, ByVal EmpMobile As String) As Integer
        Dim SMSmsg As String
        Dim query As String
        Dim MBchk As String = EmpMobile
        MBchk = Mid(MBchk, 1, 4)

        SMSmsg = Replace(msg, "'", "\'")

        Try
            If MBchk = "+639" Then

                If Len(EmpMobile) = 13 Then
                    'query = "INSERT INTO Messages SET DirectionID=2, TypeID=2, StatusDetails=200, Status=1, ChannelID=0, Recipient='" & EmpMobile & "', " _
                    '& " Body='" & SMSmsg & "',validity=" & Validity & ", branch='" & branch & "', PatientID='" & PatientID & "', Username='" & ClientUsername & "', UserHostName='" & ClientHostName & "', UserHostIP='" & ClientHostIP & "'"

                    query = "INSERT INTO Messages SET DirectionID=2, TypeID=1, StatusDetailsID=200, StatusID=1, ChannelID=0, FromAddress = '+639479956255', ToAddress='" & EmpMobile & "', " _
                    & " Body='" & SMSmsg & "',validity=" & Validity & ", branch='" & branch & "', PatientID='" & PatientID & "', Username='" & ClientUsername & "', UserHostName='" & ClientHostName & "', UserHostIP='" & ClientHostIP & "'"

                    Dim rowsEffected As Integer = 0
                    Dim connection As New MySqlConnection(connStrSMS)
                    Dim cmd As New MySqlCommand(query, connection)

                    connection.Open()

                    rowsEffected = cmd.ExecuteNonQuery()

                    connection.Close()

                    Return rowsEffected

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function
    Function SMS_DELETE(ByVal id As String)

        Try
            Dim query As String = "DELETE FROM Messages WHERE id='" & id & "'"
            Dim rowsEffected As Integer = 0
            Dim connection As New MySqlConnection(connStrSMS)
            Dim cmd As New MySqlCommand(query, connection)

            connection.Open()

            rowsEffected = cmd.ExecuteNonQuery()

            connection.Close()

            Return rowsEffected
        Catch ex As Exception
            MsgBox(ex.Message)
            Console.WriteLine(ex.Message)
        End Try

    End Function
    Function SMS_FORCE_ON_QUE(ByVal id As String)

        Try
            Dim query As String = "UPDATE Messages SET sysLock='0' WHERE id='" & id & "'"
            Dim rowsEffected As Integer = 0
            Dim connection As New MySqlConnection(connStrSMS)
            Dim cmd As New MySqlCommand(query, connection)

            connection.Open()

            rowsEffected = cmd.ExecuteNonQuery()

            connection.Close()

            Return rowsEffected
        Catch ex As Exception
            MsgBox(ex.Message)
            Console.WriteLine(ex.Message)
        End Try

    End Function
    Function SMS_UPDATE(ByVal query As String)

        Try
            Dim rowsEffected As Integer = 0
            Dim connection As New MySqlConnection(connStrSMS)
            Dim cmd As New MySqlCommand(query, connection)

            connection.Open()

            rowsEffected = cmd.ExecuteNonQuery()

            connection.Close()

            Return rowsEffected
        Catch ex As Exception
            MsgBox(ex.Message)
            Console.WriteLine(ex.Message)
        End Try

    End Function
    Function SMS_FORCEque(ByVal id As String)

        Try
            Dim query As String = "UPDATE Messages SET sysLock='0' WHERE id='" & id & "'"
            Dim rowsEffected As Integer = 0
            Dim connection As New MySqlConnection(connStrSMS)
            Dim cmd As New MySqlCommand(query, connection)

            connection.Open()

            rowsEffected = cmd.ExecuteNonQuery()

            connection.Close()

            Return rowsEffected
        Catch ex As Exception
            MsgBox(ex.Message)
            Console.WriteLine(ex.Message)
        End Try

    End Function
    Function Department_Reply_Branch(ByVal branch_code As String) As String
        Try
            branch_code = Replace(branch_code, "'", "\'")

            Dim sql As String = "SELECT department_first_footer FROM ref_user_access WHERE department_key='" & branch_code & "'"
            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(sql, connection)
            Dim reader As MySqlDataReader
            connection.Open()
            reader = cmd.ExecuteReader()

            If reader.HasRows = True Then
                While reader.Read
                    Department_Reply_Branch = reader.Item("department_first_footer").ToString.Trim() & vbNewLine & vbNewLine
                End While
            Else
                Department_Reply_Branch = ""
            End If
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "::department_first_footer", MsgBoxStyle.Information, "Belo SMS:Login")
        End Try
    End Function
    Function Branch_First_Footer(ByVal branch_code As String) As String
        Try
            branch_code = Replace(branch_code, "'", "\'")

            Dim sql As String = "SELECT branch_first_footer,branch_end_footer FROM sms_branch_footer WHERE branch_code LIKE '" & branch_code & "'"
            'MsgBox(sql)
            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(sql, connection)
            Dim reader As MySqlDataReader
            connection.Open()
            reader = cmd.ExecuteReader()

            If reader.HasRows = True Then
                While reader.Read
                    Branch_First_Footer = reader.Item("branch_first_footer").ToString.Trim() & vbNewLine & vbNewLine
                    Branch_End_Footer = reader.Item("branch_end_footer").ToString.Trim()
                End While
            Else
                Branch_First_Footer = ""
                Branch_End_Footer = ""
            End If
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "::Branch_Reply_Footer", MsgBoxStyle.Information, "Belo SMS:Login")
        End Try
    End Function
    Function Department_First_Footer(ByVal department_key As String) As String
        Try
            department_key = Replace(department_key, "'", "\'")

            Dim sql As String = "SELECT department_first_footer,department_end_footer FROM ref_user_access WHERE department_key='" & department_key & "'"
            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(sql, connection)
            Dim reader As MySqlDataReader
            connection.Open()
            reader = cmd.ExecuteReader()

            If reader.HasRows = True Then
                While reader.Read
                    Department_First_Footer = reader.Item("department_first_footer").ToString.Trim() & vbNewLine & vbNewLine
                    Department_End_Footer = reader.Item("department_end_footer").ToString.Trim()
                End While
            Else
                Department_First_Footer = ""
                Department_End_Footer = ""
            End If
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "::Department_First_Footer", MsgBoxStyle.Information, "Belo SMS:Login")
        End Try
    End Function
    Function px_name(ByVal px_id As String) As String

        On Error Resume Next

        Dim sql As String = "SELECT CONCAT(firstname,' ',lastname) pxName FROM patient_info WHERE PatientID='" & px_id & "'"
        Dim connection As New MySqlConnection(connStrBMG)
        Dim cmd As New MySqlCommand(sql, connection)
        Dim reader As MySqlDataReader
        connection.Open()
        reader = cmd.ExecuteReader()

        If reader.HasRows = True Then
            While reader.Read
                px_name = reader.Item("pxName").ToString.Trim()
            End While
        End If
        connection.Close()

    End Function
    Function BranchName(ByVal branchCode As String) As String

        If Len(branchCode) < 1 Then
            Exit Function

        End If

        On Error Resume Next

        Dim sql As String = "SELECT name FROM ref_branch WHERE code='" & branchCode & "'"
        Dim connection As New MySqlConnection(connStrBMG)
        Dim cmd As New MySqlCommand(sql, connection)
        Dim reader As MySqlDataReader
        connection.Open()
        reader = cmd.ExecuteReader()

        If reader.HasRows = True Then
            While reader.Read
                BranchName = reader.Item("name").ToString.Trim()
            End While
        Else
            BranchName = branchCode
        End If
        connection.Close()

    End Function
End Module
