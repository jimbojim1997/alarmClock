<Serializable>
Public Class Alarm
    Private name As String
    Private text As String
    Private time As Time
    '                             0Sun   1Mon   2Tue   3Wed   4Thur  5Fri   6Sat    Who starts on a sunday?
    Private days = New Boolean() {False, False, False, False, False, False, False}
    Private sound As String
    Private active As Boolean
    Private baloonVisible As Boolean = False

    Public Sub New(name As String, text As String, time As Time, sound As String, days As Boolean(), active As Boolean)
        Me.name = name
        Me.text = text
        Me.time = time
        Me.sound = sound
        Me.days = days
        Me.active = active
    End Sub

    Public Sub setName(name As String)
        Me.name = name
    End Sub
    Public Function getName() As String
        Return Me.name
    End Function

    Public Sub setText(text As String)
        Me.text = text
    End Sub
    Public Function getText() As String
        Return Me.text
    End Function

    Public Sub setTime(time As Time)
        Me.time = time
    End Sub
    Public Function getTime() As Time
        Return Me.time
    End Function

    Public Sub setDays(days As Boolean())
        Me.days = days
    End Sub
    Public Sub setDay(day As Integer, isSet As Boolean)
        Me.days(day) = isSet
    End Sub
    Public Function getDays() As Boolean()
        Return Me.days
    End Function
    Public Function daySet() As Boolean
        Dim isSet As Boolean = False

        For Each el As Boolean In Me.days
            If el Then
                isSet = True
                Exit For
            End If
        Next

        Return isSet
    End Function

    Public Sub setSound(sound As String)
        Me.sound = sound
    End Sub
    Public Function getSound() As String
        Return Me.sound
    End Function

    Public Sub setActive(active As Boolean)
        Me.active = active
    End Sub
    Public Function isActive() As Boolean
        Return Me.active
    End Function

    Public Sub setBaloonVisible(visible As Boolean)
        Me.baloonVisible = visible
    End Sub
    Public Function isBaloonVisble() As Boolean
        Return Me.baloonVisible
    End Function
End Class
