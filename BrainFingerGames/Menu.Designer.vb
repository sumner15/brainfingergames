﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MusicGlovePB = New System.Windows.Forms.ProgressBar()
        Me.FingerPB = New System.Windows.Forms.ProgressBar()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lastGameLbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.gamePnl.SuspendLayout()
        CType(Me.thumbnail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'gamePnl
        '
        Me.gamePnl.Controls.Add(Me.gameNameLbl)
        Me.gamePnl.Controls.Add(Me.thumbnail)
        Me.gamePnl.Location = New System.Drawing.Point(610, 71)
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
        Me.gameList.Location = New System.Drawing.Point(227, 81)
        Me.gameList.Name = "gameList"
        Me.gameList.Size = New System.Drawing.Size(180, 238)
        Me.gameList.TabIndex = 7
        '
        'titleBrainFingerGamesLbl
        '
        Me.titleBrainFingerGamesLbl.AutoSize = True
        Me.titleBrainFingerGamesLbl.BackColor = System.Drawing.Color.Transparent
        Me.titleBrainFingerGamesLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleBrainFingerGamesLbl.ForeColor = System.Drawing.Color.Red
        Me.titleBrainFingerGamesLbl.Location = New System.Drawing.Point(68, 36)
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
        Me.subjectList.Location = New System.Drawing.Point(27, 81)
        Me.subjectList.Name = "subjectList"
        Me.subjectList.Size = New System.Drawing.Size(178, 238)
        Me.subjectList.TabIndex = 5
        '
        'gameSettingsBtn
        '
        Me.gameSettingsBtn.Location = New System.Drawing.Point(13, 156)
        Me.gameSettingsBtn.Name = "gameSettingsBtn"
        Me.gameSettingsBtn.Size = New System.Drawing.Size(125, 64)
        Me.gameSettingsBtn.TabIndex = 15
        Me.gameSettingsBtn.Text = "Game Settings:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "None Selected Yet!"
        Me.gameSettingsBtn.UseVisualStyleBackColor = True
        '
        'runBtn
        '
        Me.runBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.runBtn.Location = New System.Drawing.Point(607, 376)
        Me.runBtn.Name = "runBtn"
        Me.runBtn.Size = New System.Drawing.Size(251, 76)
        Me.runBtn.TabIndex = 16
        Me.runBtn.Text = "RUN"
        Me.runBtn.UseVisualStyleBackColor = True
        '
        'FingerBtn
        '
        Me.FingerBtn.Location = New System.Drawing.Point(51, 89)
        Me.FingerBtn.Name = "FingerBtn"
        Me.FingerBtn.Size = New System.Drawing.Size(87, 61)
        Me.FingerBtn.TabIndex = 17
        Me.FingerBtn.Text = "FINGER"
        Me.FingerBtn.UseVisualStyleBackColor = True
        '
        'MusicGloveBtn
        '
        Me.MusicGloveBtn.Location = New System.Drawing.Point(51, 18)
        Me.MusicGloveBtn.Name = "MusicGloveBtn"
        Me.MusicGloveBtn.Size = New System.Drawing.Size(87, 65)
        Me.MusicGloveBtn.TabIndex = 18
        Me.MusicGloveBtn.Text = "Music Glove"
        Me.MusicGloveBtn.UseVisualStyleBackColor = True
        '
        'LastMeasurementLbl
        '
        Me.LastMeasurementLbl.AutoSize = True
        Me.LastMeasurementLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastMeasurementLbl.Location = New System.Drawing.Point(62, 53)
        Me.LastMeasurementLbl.Name = "LastMeasurementLbl"
        Me.LastMeasurementLbl.Size = New System.Drawing.Size(134, 16)
        Me.LastMeasurementLbl.TabIndex = 22
        Me.LastMeasurementLbl.Text = "last measurement:"
        '
        'lastSessionLabel
        '
        Me.lastSessionLabel.AutoSize = True
        Me.lastSessionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastSessionLabel.Location = New System.Drawing.Point(39, 69)
        Me.lastSessionLabel.Name = "lastSessionLabel"
        Me.lastSessionLabel.Size = New System.Drawing.Size(94, 15)
        Me.lastSessionLabel.TabIndex = 20
        Me.lastSessionLabel.Text = "last session info"
        '
        'sessionNumberTB
        '
        Me.sessionNumberTB.Location = New System.Drawing.Point(98, 26)
        Me.sessionNumberTB.Name = "sessionNumberTB"
        Me.sessionNumberTB.Size = New System.Drawing.Size(91, 20)
        Me.sessionNumberTB.TabIndex = 21
        '
        'trialNumTextLbl
        '
        Me.trialNumTextLbl.AutoSize = True
        Me.trialNumTextLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trialNumTextLbl.Location = New System.Drawing.Point(94, 3)
        Me.trialNumTextLbl.Name = "trialNumTextLbl"
        Me.trialNumTextLbl.Size = New System.Drawing.Size(102, 20)
        Me.trialNumTextLbl.TabIndex = 19
        Me.trialNumTextLbl.Text = "Trial Number:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubjectToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(907, 24)
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
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'SummaryToolStripMenuItem
        '
        Me.SummaryToolStripMenuItem.Name = "SummaryToolStripMenuItem"
        Me.SummaryToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
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
        Me.RefreshBtn.Location = New System.Drawing.Point(38, 286)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(154, 24)
        Me.RefreshBtn.TabIndex = 25
        Me.RefreshBtn.Text = "Refresh List"
        Me.RefreshBtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.MusicGlovePB)
        Me.Panel1.Controls.Add(Me.FingerPB)
        Me.Panel1.Controls.Add(Me.MusicGloveBtn)
        Me.Panel1.Controls.Add(Me.gameSettingsBtn)
        Me.Panel1.Controls.Add(Me.FingerBtn)
        Me.Panel1.Location = New System.Drawing.Point(429, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(150, 238)
        Me.Panel1.TabIndex = 26
        '
        'MusicGlovePB
        '
        Me.MusicGlovePB.BackColor = System.Drawing.Color.Red
        Me.MusicGlovePB.Location = New System.Drawing.Point(13, 18)
        Me.MusicGlovePB.Name = "MusicGlovePB"
        Me.MusicGlovePB.Size = New System.Drawing.Size(32, 61)
        Me.MusicGlovePB.TabIndex = 20
        '
        'FingerPB
        '
        Me.FingerPB.BackColor = System.Drawing.Color.Red
        Me.FingerPB.Location = New System.Drawing.Point(13, 89)
        Me.FingerPB.MarqueeAnimationSpeed = 25
        Me.FingerPB.Name = "FingerPB"
        Me.FingerPB.Size = New System.Drawing.Size(32, 61)
        Me.FingerPB.TabIndex = 19
        Me.FingerPB.Value = 100
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LastMeasurementLbl)
        Me.Panel2.Controls.Add(Me.trialNumTextLbl)
        Me.Panel2.Controls.Add(Me.lastSessionLabel)
        Me.Panel2.Controls.Add(Me.sessionNumberTB)
        Me.Panel2.Location = New System.Drawing.Point(293, 358)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(286, 94)
        Me.Panel2.TabIndex = 27
        '
        'lastGameLbl
        '
        Me.lastGameLbl.AutoSize = True
        Me.lastGameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastGameLbl.Location = New System.Drawing.Point(71, 53)
        Me.lastGameLbl.Name = "lastGameLbl"
        Me.lastGameLbl.Size = New System.Drawing.Size(78, 20)
        Me.lastGameLbl.TabIndex = 23
        Me.lastGameLbl.Text = "lastGame"
        Me.lastGameLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 20)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Last Game Played:"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.lastGameLbl)
        Me.Panel3.Location = New System.Drawing.Point(27, 358)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(234, 94)
        Me.Panel3.TabIndex = 28
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(907, 499)
        Me.Controls.Add(Me.RefreshBtn)
        Me.Controls.Add(Me.runBtn)
        Me.Controls.Add(Me.gamePnl)
        Me.Controls.Add(Me.gameList)
        Me.Controls.Add(Me.titleBrainFingerGamesLbl)
        Me.Controls.Add(Me.subjectList)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.gamePnl.ResumeLayout(False)
        Me.gamePnl.PerformLayout()
        CType(Me.thumbnail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MusicGlovePB As System.Windows.Forms.ProgressBar
    Friend WithEvents FingerPB As System.Windows.Forms.ProgressBar
    Friend WithEvents lastGameLbl As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
End Class
