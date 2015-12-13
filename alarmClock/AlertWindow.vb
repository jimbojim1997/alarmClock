Imports System.Threading
Public Class AlertWindow

    Private fadeThread As New Thread(AddressOf fade)

    Public Sub New(name As String, text As String, time As Time, timeOut As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lblName.Text = name
        lblTime.Text = time.ToString()
        tbText.Text = text
        If timeOut > 2000 Then
            tTimeOut.Interval = timeOut
            tTimeOut.Start()
        Else
            startFade()
        End If

        Me.Height = 30 + (tbText.Lines.Length * tbText.Font.Height)

        Me.Top = Screen.PrimaryScreen.Bounds.Height - Me.Height
        Me.Left = Screen.PrimaryScreen.Bounds.Width - Me.Width
        Me.Show()

        tbText.DeselectAll()
        lblName.Focus()
    End Sub

    Private Sub AlertWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If fadeThread.IsAlive Then fadeThread.Abort()
        Me.Close()
    End Sub

    Private Sub tTimeOut_Tick(sender As Object, e As EventArgs) Handles tTimeOut.Tick
        tTimeOut.Stop()
        startFade()
    End Sub

    Private Sub startFade()
        fadeThread.Start()
    End Sub

    Private Sub fade()
        While True
            Dim newOpacity = Math.Max(0, Me.Opacity - 0.01)
            setOpacity(newOpacity)

            If Me.Opacity = 0 Then
                Exit While
            End If
            Thread.Sleep(20) 'fade over 2Seconds
        End While
        closeForm()
    End Sub

    Private Delegate Sub setOpacityDelegate(opacity As Double)
    Private Sub setOpacity(opacity As Double)
        If Me.InvokeRequired Then
            Dim del As New setOpacityDelegate(AddressOf setOpacity)
            Me.Invoke(del, New Object() {opacity})
        Else
            Me.Opacity = opacity
        End If
    End Sub

    Private Delegate Sub closeFormDelegate()
    Private Sub closeForm()
        If Me.InvokeRequired Then
            Dim del As New closeFormDelegate(AddressOf closeForm)
            Me.Invoke(del)
        Else
            Me.Close()
        End If
    End Sub
End Class