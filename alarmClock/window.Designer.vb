<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class window
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(window))
        Me.niTray = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.cmsTray = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.clbAlarms = New System.Windows.Forms.CheckedListBox()
        Me.msTop = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnTopExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnNewAlarm = New System.Windows.Forms.Button()
        Me.btnUpdateAlarm = New System.Windows.Forms.Button()
        Me.btnRemoveAlarm = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.tbAlarmName = New System.Windows.Forms.TextBox()
        Me.lblText = New System.Windows.Forms.Label()
        Me.tbAlarmText = New System.Windows.Forms.TextBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.numAlarmHour = New System.Windows.Forms.NumericUpDown()
        Me.lblTimeSplit = New System.Windows.Forms.Label()
        Me.numAlarmMin = New System.Windows.Forms.NumericUpDown()
        Me.pnlDays = New System.Windows.Forms.Panel()
        Me.cbAlarmDaySat = New System.Windows.Forms.CheckBox()
        Me.cbAlarmDaySun = New System.Windows.Forms.CheckBox()
        Me.cbAlarmDayFri = New System.Windows.Forms.CheckBox()
        Me.cbAlarmDayMon = New System.Windows.Forms.CheckBox()
        Me.cbAlarmDayThur = New System.Windows.Forms.CheckBox()
        Me.cbAlarmDayTue = New System.Windows.Forms.CheckBox()
        Me.cbAlarmDayWed = New System.Windows.Forms.CheckBox()
        Me.tHide = New System.Windows.Forms.Timer(Me.components)
        Me.cmsTray.SuspendLayout()
        Me.msTop.SuspendLayout()
        CType(Me.numAlarmHour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAlarmMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDays.SuspendLayout()
        Me.SuspendLayout()
        '
        'niTray
        '
        Me.niTray.ContextMenuStrip = Me.cmsTray
        Me.niTray.Icon = CType(resources.GetObject("niTray.Icon"), System.Drawing.Icon)
        Me.niTray.Text = "Alarm Clock"
        Me.niTray.Visible = True
        '
        'cmsTray
        '
        Me.cmsTray.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.cmsTray.Name = "cmsTray"
        Me.cmsTray.Size = New System.Drawing.Size(134, 54)
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ShowToolStripMenuItem.Text = "Show/Hide"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(130, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'clbAlarms
        '
        Me.clbAlarms.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.clbAlarms.FormattingEnabled = True
        Me.clbAlarms.Location = New System.Drawing.Point(0, 27)
        Me.clbAlarms.Name = "clbAlarms"
        Me.clbAlarms.Size = New System.Drawing.Size(159, 319)
        Me.clbAlarms.TabIndex = 1
        '
        'msTop
        '
        Me.msTop.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.msTop.Location = New System.Drawing.Point(0, 0)
        Me.msTop.Name = "msTop"
        Me.msTop.Size = New System.Drawing.Size(365, 24)
        Me.msTop.TabIndex = 2
        Me.msTop.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnTopExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'btnTopExit
        '
        Me.btnTopExit.Name = "btnTopExit"
        Me.btnTopExit.Size = New System.Drawing.Size(92, 22)
        Me.btnTopExit.Text = "Exit"
        '
        'btnNewAlarm
        '
        Me.btnNewAlarm.Location = New System.Drawing.Point(160, 27)
        Me.btnNewAlarm.Name = "btnNewAlarm"
        Me.btnNewAlarm.Size = New System.Drawing.Size(68, 23)
        Me.btnNewAlarm.TabIndex = 3
        Me.btnNewAlarm.Text = "New"
        Me.btnNewAlarm.UseVisualStyleBackColor = True
        '
        'btnUpdateAlarm
        '
        Me.btnUpdateAlarm.Location = New System.Drawing.Point(227, 27)
        Me.btnUpdateAlarm.Name = "btnUpdateAlarm"
        Me.btnUpdateAlarm.Size = New System.Drawing.Size(68, 23)
        Me.btnUpdateAlarm.TabIndex = 4
        Me.btnUpdateAlarm.Text = "Update"
        Me.btnUpdateAlarm.UseVisualStyleBackColor = True
        '
        'btnRemoveAlarm
        '
        Me.btnRemoveAlarm.Location = New System.Drawing.Point(294, 27)
        Me.btnRemoveAlarm.Name = "btnRemoveAlarm"
        Me.btnRemoveAlarm.Size = New System.Drawing.Size(68, 23)
        Me.btnRemoveAlarm.TabIndex = 5
        Me.btnRemoveAlarm.Text = "Remove"
        Me.btnRemoveAlarm.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(165, 66)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "Name:"
        '
        'tbAlarmName
        '
        Me.tbAlarmName.Location = New System.Drawing.Point(204, 63)
        Me.tbAlarmName.Name = "tbAlarmName"
        Me.tbAlarmName.Size = New System.Drawing.Size(158, 20)
        Me.tbAlarmName.TabIndex = 7
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Location = New System.Drawing.Point(165, 89)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(31, 13)
        Me.lblText.TabIndex = 9
        Me.lblText.Text = "Text:"
        '
        'tbAlarmText
        '
        Me.tbAlarmText.Location = New System.Drawing.Point(205, 86)
        Me.tbAlarmText.Multiline = True
        Me.tbAlarmText.Name = "tbAlarmText"
        Me.tbAlarmText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbAlarmText.Size = New System.Drawing.Size(157, 59)
        Me.tbAlarmText.TabIndex = 10
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(165, 154)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(33, 13)
        Me.lblTime.TabIndex = 11
        Me.lblTime.Text = "Time:"
        '
        'numAlarmHour
        '
        Me.numAlarmHour.Location = New System.Drawing.Point(205, 151)
        Me.numAlarmHour.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.numAlarmHour.Name = "numAlarmHour"
        Me.numAlarmHour.Size = New System.Drawing.Size(37, 20)
        Me.numAlarmHour.TabIndex = 12
        '
        'lblTimeSplit
        '
        Me.lblTimeSplit.AutoSize = True
        Me.lblTimeSplit.BackColor = System.Drawing.SystemColors.Control
        Me.lblTimeSplit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeSplit.Location = New System.Drawing.Point(238, 150)
        Me.lblTimeSplit.Name = "lblTimeSplit"
        Me.lblTimeSplit.Size = New System.Drawing.Size(14, 20)
        Me.lblTimeSplit.TabIndex = 13
        Me.lblTimeSplit.Text = ":"
        '
        'numAlarmMin
        '
        Me.numAlarmMin.Location = New System.Drawing.Point(248, 152)
        Me.numAlarmMin.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.numAlarmMin.Name = "numAlarmMin"
        Me.numAlarmMin.Size = New System.Drawing.Size(37, 20)
        Me.numAlarmMin.TabIndex = 14
        '
        'pnlDays
        '
        Me.pnlDays.Controls.Add(Me.cbAlarmDaySat)
        Me.pnlDays.Controls.Add(Me.cbAlarmDaySun)
        Me.pnlDays.Controls.Add(Me.cbAlarmDayFri)
        Me.pnlDays.Controls.Add(Me.cbAlarmDayMon)
        Me.pnlDays.Controls.Add(Me.cbAlarmDayThur)
        Me.pnlDays.Controls.Add(Me.cbAlarmDayTue)
        Me.pnlDays.Controls.Add(Me.cbAlarmDayWed)
        Me.pnlDays.Location = New System.Drawing.Point(168, 178)
        Me.pnlDays.Name = "pnlDays"
        Me.pnlDays.Size = New System.Drawing.Size(90, 168)
        Me.pnlDays.TabIndex = 16
        '
        'cbAlarmDaySat
        '
        Me.cbAlarmDaySat.AutoSize = True
        Me.cbAlarmDaySat.Location = New System.Drawing.Point(4, 141)
        Me.cbAlarmDaySat.Name = "cbAlarmDaySat"
        Me.cbAlarmDaySat.Size = New System.Drawing.Size(68, 17)
        Me.cbAlarmDaySat.TabIndex = 5
        Me.cbAlarmDaySat.Text = "Saturday"
        Me.cbAlarmDaySat.UseVisualStyleBackColor = True
        '
        'cbAlarmDaySun
        '
        Me.cbAlarmDaySun.AutoSize = True
        Me.cbAlarmDaySun.Location = New System.Drawing.Point(3, 3)
        Me.cbAlarmDaySun.Name = "cbAlarmDaySun"
        Me.cbAlarmDaySun.Size = New System.Drawing.Size(62, 17)
        Me.cbAlarmDaySun.TabIndex = 6
        Me.cbAlarmDaySun.Text = "Sunday"
        Me.cbAlarmDaySun.UseVisualStyleBackColor = True
        '
        'cbAlarmDayFri
        '
        Me.cbAlarmDayFri.AutoSize = True
        Me.cbAlarmDayFri.Location = New System.Drawing.Point(4, 118)
        Me.cbAlarmDayFri.Name = "cbAlarmDayFri"
        Me.cbAlarmDayFri.Size = New System.Drawing.Size(54, 17)
        Me.cbAlarmDayFri.TabIndex = 4
        Me.cbAlarmDayFri.Text = "Friday"
        Me.cbAlarmDayFri.UseVisualStyleBackColor = True
        '
        'cbAlarmDayMon
        '
        Me.cbAlarmDayMon.AutoSize = True
        Me.cbAlarmDayMon.Location = New System.Drawing.Point(3, 26)
        Me.cbAlarmDayMon.Name = "cbAlarmDayMon"
        Me.cbAlarmDayMon.Size = New System.Drawing.Size(64, 17)
        Me.cbAlarmDayMon.TabIndex = 0
        Me.cbAlarmDayMon.Text = "Monday"
        Me.cbAlarmDayMon.UseVisualStyleBackColor = True
        '
        'cbAlarmDayThur
        '
        Me.cbAlarmDayThur.AutoSize = True
        Me.cbAlarmDayThur.Location = New System.Drawing.Point(3, 95)
        Me.cbAlarmDayThur.Name = "cbAlarmDayThur"
        Me.cbAlarmDayThur.Size = New System.Drawing.Size(70, 17)
        Me.cbAlarmDayThur.TabIndex = 3
        Me.cbAlarmDayThur.Text = "Thursday"
        Me.cbAlarmDayThur.UseVisualStyleBackColor = True
        '
        'cbAlarmDayTue
        '
        Me.cbAlarmDayTue.AutoSize = True
        Me.cbAlarmDayTue.Location = New System.Drawing.Point(3, 49)
        Me.cbAlarmDayTue.Name = "cbAlarmDayTue"
        Me.cbAlarmDayTue.Size = New System.Drawing.Size(67, 17)
        Me.cbAlarmDayTue.TabIndex = 1
        Me.cbAlarmDayTue.Text = "Tuseday"
        Me.cbAlarmDayTue.UseVisualStyleBackColor = True
        '
        'cbAlarmDayWed
        '
        Me.cbAlarmDayWed.AutoSize = True
        Me.cbAlarmDayWed.Location = New System.Drawing.Point(3, 72)
        Me.cbAlarmDayWed.Name = "cbAlarmDayWed"
        Me.cbAlarmDayWed.Size = New System.Drawing.Size(83, 17)
        Me.cbAlarmDayWed.TabIndex = 2
        Me.cbAlarmDayWed.Text = "Wednesday"
        Me.cbAlarmDayWed.UseVisualStyleBackColor = True
        '
        'tHide
        '
        Me.tHide.Enabled = True
        Me.tHide.Interval = 1
        '
        'window
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 347)
        Me.Controls.Add(Me.pnlDays)
        Me.Controls.Add(Me.numAlarmHour)
        Me.Controls.Add(Me.numAlarmMin)
        Me.Controls.Add(Me.lblTimeSplit)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.tbAlarmText)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.tbAlarmName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnRemoveAlarm)
        Me.Controls.Add(Me.btnUpdateAlarm)
        Me.Controls.Add(Me.btnNewAlarm)
        Me.Controls.Add(Me.clbAlarms)
        Me.Controls.Add(Me.msTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.msTop
        Me.MaximumSize = New System.Drawing.Size(381, 385)
        Me.MinimumSize = New System.Drawing.Size(381, 385)
        Me.Name = "window"
        Me.Text = "Alarm Clock"
        Me.cmsTray.ResumeLayout(False)
        Me.msTop.ResumeLayout(False)
        Me.msTop.PerformLayout()
        CType(Me.numAlarmHour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAlarmMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDays.ResumeLayout(False)
        Me.pnlDays.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents niTray As NotifyIcon
    Friend WithEvents cmsTray As ContextMenuStrip
    Friend WithEvents ShowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents clbAlarms As CheckedListBox
    Friend WithEvents msTop As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnTopExit As ToolStripMenuItem
    Friend WithEvents btnNewAlarm As Button
    Friend WithEvents btnUpdateAlarm As Button
    Friend WithEvents btnRemoveAlarm As Button
    Friend WithEvents lblName As Label
    Friend WithEvents tbAlarmName As TextBox
    Friend WithEvents lblText As Label
    Friend WithEvents tbAlarmText As TextBox
    Friend WithEvents lblTime As Label
    Friend WithEvents numAlarmHour As NumericUpDown
    Friend WithEvents lblTimeSplit As Label
    Friend WithEvents numAlarmMin As NumericUpDown
    Friend WithEvents pnlDays As Panel
    Friend WithEvents cbAlarmDaySat As CheckBox
    Friend WithEvents cbAlarmDaySun As CheckBox
    Friend WithEvents cbAlarmDayFri As CheckBox
    Friend WithEvents cbAlarmDayMon As CheckBox
    Friend WithEvents cbAlarmDayThur As CheckBox
    Friend WithEvents cbAlarmDayTue As CheckBox
    Friend WithEvents cbAlarmDayWed As CheckBox
    Friend WithEvents tHide As Timer
End Class
