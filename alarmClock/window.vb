Imports System.Threading
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Public Class window
    Private alarms As New List(Of Alarm)
    Private alarmThread As Thread
    Private Const alarmFileName As String = "alarms.dat"

    Private Sub addAlarm(alarm As Alarm)
        alarms.Add(alarm)
        clbAlarms.Items.Add(alarm.getName(), True)
    End Sub

    Private Sub editAlarm(alarm As Alarm)
        Dim index As Integer = alarms.IndexOf(getAlarmByName(alarm.getName()))
        Dim newAlarm = alarm
        newAlarm.setActive(alarms(index).isActive())
        alarms(index) = newAlarm
    End Sub

    Private Sub removeAlarm(alarm As Alarm)
        alarms.Remove(alarm)
        clbAlarms.Items.Remove(alarm.getName())
    End Sub

    Private Function alarmExists(name As String) As Boolean
        Dim exists As Boolean = False
        For Each alarm As Alarm In alarms
            If alarm.getName() = name Then
                exists = True
                Exit For
            End If
        Next
        Return exists
    End Function

    Private Function getAlarmByName(name As String) As Alarm
        Dim alarm As Alarm
        For Each temp As Alarm In alarms
            If temp.getName() = name Then
                alarm = temp
                Exit For
            End If
        Next
        Return alarm
    End Function

    Private Sub checkAlarms()
        Dim tempAlarms As List(Of Alarm)
        Dim time As Time
        Dim day As Integer
        Dim hour As Integer
        Dim min As Integer

        While True

            tempAlarms = alarms
            day = DateTime.Now.DayOfWeek
            hour = DateTime.Now.Hour
            min = DateTime.Now.Minute

            For Each alarm As Alarm In tempAlarms
                time = alarm.getTime()


                If (alarm.getDays()(day) Or Not alarm.daySet()) And time.hour = hour And time.minute = min And alarm.isActive() Then

                    If Not alarm.isBaloonVisble() Then
                        showTrayIconAlert(alarm.getName(),
                                      time.hour & ":" & time.minute & vbCrLf & alarm.getText(),
                                      10000) '10 sec
                        alarm.setBaloonVisible(True)

                        If Not alarm.daySet() Then
                            alarm.setActive(False)
                            Dim index As Integer = clbAlarms.Items.IndexOf(alarm.getName())
                            setClbCheckedState(index, False)
                            saveAlarms()
                        End If
                    End If

                ElseIf alarm.isBaloonVisble()
                    alarm.setBaloonVisible(False)
                End If
            Next

            Thread.Sleep(1000)
        End While
    End Sub

    Private Delegate Sub setClbCheckedStateDelegate(index As Integer, state As Boolean)
    Private Sub setClbCheckedState(index As Integer, state As Boolean)
        If Me.InvokeRequired Then
            Dim del As New setClbCheckedStateDelegate(AddressOf setClbCheckedState)
            Me.Invoke(del, New Object() {index, state})
        Else
            clbAlarms.SetItemCheckState(index, state)
        End If
    End Sub

    Private Sub showTrayIconAlert(title As String, text As String, time As Integer)
        niTray.ShowBalloonTip(time, title, text, ToolTipIcon.Info)
    End Sub

    Private Sub killProgram()
        alarmThread.Abort()
        Application.Exit()
    End Sub

    Private Sub saveAlarms()
        Dim fs = New FileStream(alarmFileName, FileMode.Create)
        Dim bf = New BinaryFormatter()
        bf.Serialize(fs, alarms)
        fs.Close()

    End Sub

    Private Sub loadAlarms()
        If File.Exists(alarmFileName) Then
            Dim fs = New FileStream(alarmFileName, FileMode.Open)
            Dim bf = New BinaryFormatter()
            alarms = CType(bf.Deserialize(fs), List(Of Alarm))
            fs.Close()

            For Each alarm As Alarm In alarms
                clbAlarms.Items.Add(alarm.getName(), alarm.isActive())
            Next
        End If
    End Sub

    Private Sub window_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadAlarms()
        alarmThread = New Thread(AddressOf checkAlarms)
        alarmThread.Start()
        Me.Opacity = 0
    End Sub

    Private Sub btnNewAlarm_Click(sender As Object, e As EventArgs) Handles btnNewAlarm.Click
        Dim alarm As Alarm

        Dim name As String = tbAlarmName.Text
        Dim text As String = tbAlarmText.Text
        Dim hour As Integer = numAlarmHour.Value
        Dim minute As Integer = numAlarmMin.Value
        Dim days = New Boolean() {cbAlarmDaySun.Checked,
                                  cbAlarmDayMon.Checked,
                                  cbAlarmDayTue.Checked,
                                  cbAlarmDayWed.Checked,
                                  cbAlarmDayThur.Checked,
                                  cbAlarmDayFri.Checked,
                                  cbAlarmDaySat.Checked}
        Dim active As Boolean = True

        alarm = New Alarm(name,
                          text,
                          New Time(hour, minute),
                          days,
                          active)
        If alarmExists(name) Then
            MessageBox.Show("An alarm of that name already exists.")
        Else
            addAlarm(alarm)
        End If

        saveAlarms()
    End Sub

    Private Sub btnUpdateAlarm_Click(sender As Object, e As EventArgs) Handles btnUpdateAlarm.Click
        Dim alarm As Alarm

        Dim name As String = tbAlarmName.Text
        Dim text As String = tbAlarmText.Text
        Dim hour As Integer = numAlarmHour.Value
        Dim minute As Integer = numAlarmMin.Value
        Dim days = New Boolean() {cbAlarmDaySun.Checked,
                                  cbAlarmDayMon.Checked,
                                  cbAlarmDayTue.Checked,
                                  cbAlarmDayWed.Checked,
                                  cbAlarmDayThur.Checked,
                                  cbAlarmDayFri.Checked,
                                  cbAlarmDaySat.Checked}
        Dim active As Boolean = True

        alarm = New Alarm(name,
                          text,
                          New Time(hour, minute),
                          days,
                          active)
        If alarmExists(name) Then
            editAlarm(alarm)
        Else
            MessageBox.Show("An alarm of that name doesn't exist.")
        End If
        saveAlarms()
    End Sub

    Private Sub btnRemoveAlarm_Click(sender As Object, e As EventArgs) Handles btnRemoveAlarm.Click
        If clbAlarms.SelectedIndex >= 0 Then
            Dim name As String = clbAlarms.SelectedItem.ToString()
            Dim alarm As Alarm = getAlarmByName(name)
            removeAlarm(alarm)
        End If
        saveAlarms()
    End Sub

    Private Sub window_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Me.Hide()
        Else
            killProgram()
        End If
    End Sub

    Private Sub ShowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowToolStripMenuItem.Click
        If Me.Visible Then
            Me.Hide()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        killProgram()
    End Sub

    Private Sub btnTopExit_Click(sender As Object, e As EventArgs) Handles btnTopExit.Click
        killProgram()
    End Sub

    Private Sub clbAlarms_Click(sender As Object, e As EventArgs) Handles clbAlarms.Click
        If clbAlarms.SelectedItem <> Nothing Then
            Dim name As String = clbAlarms.SelectedItem.ToString()
            Dim alarm As Alarm = getAlarmByName(name)

            tbAlarmName.Text = alarm.getName()
            tbAlarmText.Text = alarm.getText()
            numAlarmHour.Value = alarm.getTime().hour
            numAlarmMin.Value = alarm.getTime().minute

            cbAlarmDaySun.Checked = alarm.getDays()(0)
            cbAlarmDayMon.Checked = alarm.getDays()(1)
            cbAlarmDayTue.Checked = alarm.getDays()(2)
            cbAlarmDayWed.Checked = alarm.getDays()(3)
            cbAlarmDayThur.Checked = alarm.getDays()(4)
            cbAlarmDayFri.Checked = alarm.getDays()(5)
            cbAlarmDaySat.Checked = alarm.getDays()(6)
        End If
    End Sub

    Private Sub clbAlarms_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles clbAlarms.ItemCheck
        Dim index As Integer = e.Index
        Dim name As String = clbAlarms.Items.Item(index)
        Dim alarm As Alarm = getAlarmByName(name)
        alarm.setActive(e.NewValue)
        saveAlarms()
    End Sub

    Private Sub tHide_Tick(sender As Object, e As EventArgs) Handles tHide.Tick
        Me.Hide()
        tHide.Enabled = False
        Me.Opacity = 1
    End Sub
End Class