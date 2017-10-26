Imports System.Threading
Imports System.IO
Imports System.Net

Public Class frmSMSUpdate
    Dim i As Integer = 0
    Private Sub DownloadUpdate()

        Dim FileToCopy As String
        Dim FileToCopyUpdate As String
        Dim path As String

        If Host = "192.168.200.100" Then
            FileToCopyUpdate = "\\192.168.200.100\Belo SMS\update\BeloSMSUpdate.exe"
            FileToCopy = "\\192.168.200.100\Belo SMS\update\BeloSMS.exe"
            path = "\\192.168.200.100\Belo SMS\update\version.txt"
        Else
            FileToCopyUpdate = "\\192.168.100.41\Belo SMS\update\BeloSMSUpdate.exe"
            FileToCopy = "\\192.168.100.41\Belo SMS\update\BeloSMS.exe"
            path = "\\192.168.100.41\Belo SMS\update\version.txt"
        End If

        lbStatus.Text = "Downloading new update....."

        If File.Exists(path) = True Then
            ' Open the file to read from. 
            Dim target As String = Directory.GetCurrentDirectory & "\temp"

            If Directory.Exists(target) = False Then
                Directory.CreateDirectory(target)
            End If

            Dim Filetarget As String = Application.StartupPath() & "\temp\BeloSMS.exe"

            If Directory.Exists(target) = True Then
                My.Computer.Network.DownloadFile(FileToCopy, Filetarget, "", "", True, 1800000, True)

                If File.Exists(FileToCopyUpdate) = True Then
                    My.Computer.Network.DownloadFile(FileToCopyUpdate, Application.StartupPath() & "\BeloSMSUpdate.exe", "", "", True, 1800000, True)
                End If

                Process.Start(Directory.GetCurrentDirectory & "\BeloSMSUpdate.exe")
                lbStatus.Text = "Download Completed!"
                Thread.Sleep(2000)
                Application.Exit()
            End If

        End If
    End Sub

    Private Sub btUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btUpdate.Click
        DownloadUpdate()
    End Sub

    Private Sub btShutdown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btShutdown.Click
        Dim proc = Process.GetProcessesByName("BeloSMS")
        For i As Integer = 0 To proc.Count - 1
            proc(i).Kill()
        Next i

        Thread.Sleep(100)
        Application.DoEvents()
    End Sub

    Private Sub frmSMSUpdate_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Timer1.Enabled = True
    End Sub

    Private Sub frmBeloSMSUpdate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbStatus.Text = "Downloading new update"
    End Sub

    Private Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel.Click
        Application.Exit()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        i += 1
        Select Case i
            Case 1
                lbStatus.Text = "Downloading new update."
            Case 2
                lbStatus.Text = "Downloading new update.."
            Case 3
                lbStatus.Text = "Downloading new update..."
            Case 4
                DownloadUpdate()
        End Select
    End Sub

End Class
