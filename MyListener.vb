Public Class MyListener
    Inherits NativeWindow
    Public Event MyScroll(ByVal sender As Object, ByVal e As EventArgs)
    Const WM_MOUSEACTIVATE = &H21
    Const WM_MOUSEMOVE = &H200
    Private ctrl As Control

    Public Sub New(ByVal ctrl As Control)
        AssignHandle(ctrl.Handle)
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        ' Listen for operating system messages
        Const WM_HSCROLL = &H114
        Const WM_VSCROLL = &H115

        If m.Msg = WM_Hscroll Or m.Msg = wm_vscroll Then

            RaiseEvent MyScroll(ctrl, New EventArgs)

        End If
        MyBase.WndProc(m)

    End Sub

    Protected Overrides Sub Finalize()
        ReleaseHandle()
        MyBase.Finalize()
    End Sub
End Class
