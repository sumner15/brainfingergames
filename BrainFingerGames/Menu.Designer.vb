<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gamePnl = New System.Windows.Forms.Panel()
        Me.gameNameLbl = New System.Windows.Forms.Label()
        Me.thumbnail = New System.Windows.Forms.PictureBox()
        Me.gameList = New System.Windows.Forms.ListBox()
        Me.titleBrainFingerGamesLbl = New System.Windows.Forms.Label()
        Me.subjectList = New System.Windows.Forms.ListBox()
        Me.gameSettingsBtn = New System.Windows.Forms.Button()
        Me.runBtn = New System.Windows.Forms.Button()
        Me.FingerBtn = New System.Windows.Forms.Button()
        Me.MusicGloveBtn = New System.Windows.Forms.Button()
        Me.LastMeasurementLbl = New System.Windows.Forms.Label()
        Me.lastSessionLabel = New System.Windows.Forms.Label()
        Me.sessionNumberTB = New System.Windows.Forms.TextBox()
        Me.trialNumTextLbl = New System.Windows.Forms.Label()
        Me.GameHistoryList = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SubjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommunicationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetIPManuallyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshBtn = New System.Windows.Forms.Button()
        Me.gamePnl.SuspendLayout()
        CType(Me.thumbnail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gamePnl
        '
        Me.gamePnl.Controls.Add(Me.gameNameLbl)
        Me.gamePnl.Controls.Add(Me.thumbnail)
        Me.gamePnl.Location = New System.Drawing.Point(576, 49)
        Me.gamePnl.Name = "gamePnl"
        Me.gamePnl.Size = New System.Drawing.Size(251, 281)
        Me.gamePnl.TabIndex = 8
        '
        'gameNameLbl
        '
        Me.gameNameLbl.AutoSize = True
        Me.gameNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gameNameLbl.Location = New System.Drawing.Point(3, 251)
        Me.gameNameLbl.Name = "gameNameLbl"
        Me.gameNameLbl.Size = New System.Drawing.Size(117, 24)
        Me.gameNameLbl.TabIndex = 2
        Me.gameNameLbl.Text = "Game Name"
        '
        'thumbnail
        '
        Me.thumbnail.Location = New System.Drawing.Point(3, 3)
        Me.thumbnail.Name = "thumbnail"
        Me.thumbnail.Size = New System.Drawing.Size(245, 245)
        Me.thumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.thumbnail.TabIndex = 0
        Me.thumbnail.TabStop = False
        '
        'gameList
        '
        Me.gameList.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gameList.FormattingEnabled = True
        Me.gameList.ItemHeight = 18
        Me.gameList.Location = New System.Drawing.Point(201, 62)
        Me.gameList.Name = "gameList"
        Me.gameList.Size = New System.Drawing.Size(180, 346)
        Me.gameList.TabIndex = 7
        '
        'titleBrainFingerGamesLbl
        '
        Me.titleBrainFingerGamesLbl.AutoSize = True
        Me.titleBrainFingerGamesLbl.BackColor = System.Drawing.Color.Transparent
        Me.titleBrainFingerGamesLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleBrainFingerGamesLbl.ForeColor = System.Drawing.Color.White
        Me.titleBrainFingerGamesLbl.Location = New System.Drawing.Point(12, 24)
        Me.titleBrainFingerGamesLbl.Name = "titleBrainFingerGamesLbl"
        Me.titleBrainFingerGamesLbl.Size = New System.Drawing.Size(286, 33)
        Me.titleBrainFingerGamesLbl.TabIndex = 6
        Me.titleBrainFingerGamesLbl.Text = "BrainFinger Games"
        '
        'subjectList
        '
        Me.subjectList.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subjectList.FormattingEnabled = True
        Me.subjectList.ItemHeight = 18
        Me.subjectList.Location = New System.Drawing.Point(18, 62)
        Me.subjectList.Name = "subjectList"
        Me.subjectList.Size = New System.Drawing.Size(178, 346)
        Me.subjectList.TabIndex = 5
        '
        'gameSettingsBtn
        '
        Me.gameSettingsBtn.Location = New System.Drawing.Point(576, 336)
        Me.gameSettingsBtn.Name = "gameSettingsBtn"
        Me.gameSettingsBtn.Size = New System.Drawing.Size(248, 94)
        Me.gameSettingsBtn.TabIndex = 15
        Me.gameSettingsBtn.Text = "game settings"
        Me.gameSettingsBtn.UseVisualStyleBackColor = True
        '
        'runBtn
        '
        Me.runBtn.Location = New System.Drawing.Point(576, 436)
        Me.runBtn.Name = "runBtn"
        Me.runBtn.Size = New System.Drawing.Size(248, 94)
        Me.runBtn.TabIndex = 16
        Me.runBtn.Text = "RUN"
        Me.runBtn.UseVisualStyleBackColor = True
        '
        'FingerBtn
        '
        Me.FingerBtn.Location = New System.Drawing.Point(410, 172)
        Me.FingerBtn.Name = "FingerBtn"
        Me.FingerBtn.Size = New System.Drawing.Size(125, 94)
        Me.FingerBtn.TabIndex = 17
        Me.FingerBtn.Text = "FINGER"
        Me.FingerBtn.UseVisualStyleBackColor = True
        '
        'MusicGloveBtn
        '
        Me.MusicGloveBtn.Location = New System.Drawing.Point(410, 62)
        Me.MusicGloveBtn.Name = "MusicGloveBtn"
        Me.MusicGloveBtn.Size = New System.Drawing.Size(125, 94)
        Me.MusicGloveBtn.TabIndex = 18
        Me.MusicGloveBtn.Text = "Music Glove"
        Me.MusicGloveBtn.UseVisualStyleBackColor = True
        '
        'LastMeasurementLbl
        '
        Me.LastMeasurementLbl.AutoSize = True
        Me.LastMeasurementLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastMeasurementLbl.Location = New System.Drawing.Point(230, 487)
        Me.LastMeasurementLbl.Name = "LastMeasurementLbl"
        Me.LastMeasurementLbl.Size = New System.Drawing.Size(134, 16)
        Me.LastMeasurementLbl.TabIndex = 22
        Me.LastMeasurementLbl.Text = "last measurement:"
        '
        'lastSessionLabel
        '
        Me.lastSessionLabel.AutoSize = True
        Me.lastSessionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastSessionLabel.Location = New System.Drawing.Point(207, 503)
        Me.lastSessionLabel.Name = "lastSessionLabel"
        Me.lastSessionLabel.Size = New System.Drawing.Size(94, 15)
        Me.lastSessionLabel.TabIndex = 20
        Me.lastSessionLabel.Text = "last session info"
        '
        'sessionNumberTB
        '
        Me.sessionNumberTB.Location = New System.Drawing.Point(253, 453)
        Me.sessionNumberTB.Name = "sessionNumberTB"
        Me.sessionNumberTB.Size = New System.Drawing.Size(91, 20)
        Me.sessionNumberTB.TabIndex = 21
        '
        'trialNumTextLbl
        '
        Me.trialNumTextLbl.AutoSize = True
        Me.trialNumTextLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trialNumTextLbl.Location = New System.Drawing.Point(249, 430)
        Me.trialNumTextLbl.Name = "trialNumTextLbl"
        Me.trialNumTextLbl.Size = New System.Drawing.Size(102, 20)
        Me.trialNumTextLbl.TabIndex = 19
        Me.trialNumTextLbl.Text = "Trial Number:"
        '
        'GameHistoryList
        '
        Me.GameHistoryList.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameHistoryList.FormattingEnabled = True
        Me.GameHistoryList.ItemHeight = 18
        Me.GameHistoryList.Location = New System.Drawing.Point(18, 424)
        Me.GameHistoryList.Name = "GameHistoryList"
        Me.GameHistoryList.Size = New System.Drawing.Size(178, 112)
        Me.GameHistoryList.TabIndex = 23
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubjectToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(847, 24)
        Me.MenuStrip1.TabIndex = 24
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SubjectToolStripMenuItem
        '
        Me.SubjectToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.RemoveToolStripMenuItem, Me.SummaryToolStripMenuItem})
        Me.SubjectToolStripMenuItem.Name = "SubjectToolStripMenuItem"
        Me.SubjectToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.SubjectToolStripMenuItem.Text = "Subject"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'SummaryToolStripMenuItem
        '
        Me.SummaryToolStripMenuItem.Name = "SummaryToolStripMenuItem"
        Me.SummaryToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.SummaryToolStripMenuItem.Text = "Summary"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CommunicationsToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'CommunicationsToolStripMenuItem
        '
        Me.CommunicationsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetIPManuallyToolStripMenuItem})
        Me.CommunicationsToolStripMenuItem.Name = "CommunicationsToolStripMenuItem"
        Me.CommunicationsToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.CommunicationsToolStripMenuItem.Text = "Communications"
        '
        'SetIPManuallyToolStripMenuItem
        '
        Me.SetIPManuallyToolStripMenuItem.Name = "SetIPManuallyToolStripMenuItem"
        Me.SetIPManuallyToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.SetIPManuallyToolStripMenuItem.Text = "Set IP manually"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'RefreshBtn
        '
        Me.RefreshBtn.Location = New System.Drawing.Point(26, 365)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(163, 37)
        Me.RefreshBtn.TabIndex = 25
        Me.RefreshBtn.Text = "Refresh List"
        Me.RefreshBtn.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 548)
        Me.Controls.Add(Me.RefreshBtn)
        Me.Controls.Add(Me.GameHistoryList)
        Me.Controls.Add(Me.LastMeasurementLbl)
        Me.Controls.Add(Me.lastSessionLabel)
        Me.Controls.Add(Me.sessionNumberTB)
        Me.Controls.Add(Me.trialNumTextLbl)
        Me.Controls.Add(Me.MusicGloveBtn)
        Me.Controls.Add(Me.FingerBtn)
        Me.Controls.Add(Me.runBtn)
        Me.Controls.Add(Me.gameSettingsBtn)
        Me.Controls.Add(Me.gamePnl)
        Me.Controls.Add(Me.gameList)
        Me.Controls.Add(Me.titleBrainFingerGamesLbl)
        Me.Controls.Add(Me.subjectList)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.gamePnl.ResumeLayout(False)
        Me.gamePnl.PerformLayout()
        CType(Me.thumbnail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gamePnl As System.Windows.Forms.Panel
    Friend WithEvents gameNameLbl As System.Windows.Forms.Label
    Friend WithEvents thumbnail As System.Windows.Forms.PictureBox
    Friend WithEvents gameList As System.Windows.Forms.ListBox
    Friend WithEvents titleBrainFingerGamesLbl As System.Windows.Forms.Label
    Friend WithEvents subjectList As System.Windows.Forms.ListBox
    Friend WithEvents gameSettingsBtn As System.Windows.Forms.Button
    Friend WithEvents runBtn As System.Windows.Forms.Button
    Friend WithEvents FingerBtn As System.Windows.Forms.Button
    Friend WithEvents MusicGloveBtn As System.Windows.Forms.Button
    Friend WithEvents LastMeasurementLbl As System.Windows.Forms.Label
    Friend WithEvents lastSessionLabel As System.Windows.Forms.Label
    Friend WithEvents sessionNumberTB As System.Windows.Forms.TextBox
    Friend WithEvents trialNumTextLbl As System.Windows.Forms.Label
    Friend WithEvents GameHistoryList As System.Windows.Forms.ListBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SubjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CommunicationsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetIPManuallyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshBtn As System.Windows.Forms.Button
End Class
