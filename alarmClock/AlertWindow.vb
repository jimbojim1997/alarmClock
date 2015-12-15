Imports System.Threading
Public Class AlertWindow

    Private runnerThread As Thread

    Public Sub New(name As String, text As String, time As Time, timeOut As Integer, fadeIn As Integer, fadeOut As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lblName.Text = name
        lblTime.Text = time.ToString()
        tbText.Text = text

        Me.Height = 30 + (tbText.Lines.Length * tbText.Font.Height)

        Me.Top = Screen.PrimaryScreen.Bounds.Height - Me.Height
        Me.Left = Screen.PrimaryScreen.Bounds.Width - Me.Width
        Me.Show()

        tbText.DeselectAll()
        lblName.Focus()

        runnerThread = New Thread(Sub() Me.runner(timeOut, fadeIn, fadeOut))
        runnerThread.Start()
    End Sub

    Private Sub AlertWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If runnerThread.IsAlive Then runnerThread.Abort()
        Me.Close()
    End Sub

    Private Sub runner(timeOut As Integer, fadeIn As Integer, fadeOut As Integer)
        'fade in
        While True
            Dim newOpacity = Math.Min(1, Me.Opacity + 0.01)
            setOpacity(newOpacity)

            If Me.Opacity >= 1 Then
                Exit While
            End If
            If fadeIn > 0 Then
                Thread.Sleep(fadeIn * 0.01)
            End If
        End While

        'sleep
        Thread.Sleep(timeOut)

        'fade out
        While True
            Dim newOpacity = Math.Min(1, Me.Opacity - 0.01)
            setOpacity(newOpacity)

            If Me.Opacity <= 0 Then
                Exit While
            End If
            If fadeOut > 0 Then
                Thread.Sleep(fadeOut * 0.01)
            End If
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