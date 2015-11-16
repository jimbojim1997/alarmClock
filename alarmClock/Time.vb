<Serializable>
Public Class Time
    Public hour As Integer
    Public minute As Integer

    Public Sub New(hour As Integer, minute As Integer)
        Me.hour = hour
        Me.minute = minute
    End Sub

    Public Overrides Function ToString() As String
        Return Me.hour & ":" & Me.minute
    End Function
End Class
