﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RiffHeroSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RiffHeroSettings))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.hitWindowValLbl = New System.Windows.Forms.Label()
        Me.hitWindowSizeHSB = New System.Windows.Forms.HScrollBar()
        Me.hitWindowSizeLbl = New System.Windows.Forms.Label()
        Me.useBCICbox = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RiffTimingLbl = New System.Windows.Forms.Label()
        Me.explicitGainsLbl = New System.Windows.Forms.Label()
        Me.useExplicitGainsBtn = New System.Windows.Forms.CheckBox()
        Me.GainsHSB = New System.Windows.Forms.HScrollBar()
        Me.successRateLbl = New System.Windows.Forms.Label()
        Me.SucRateHSB = New System.Windows.Forms.HScrollBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.updateLstBtn = New System.Windows.Forms.Button()
        Me.addNewStudyLbl = New System.Windows.Forms.Label()
        Me.studyIDLbl = New System.Windows.Forms.Label()
        Me.studyIdTb = New System.Windows.Forms.TextBox()
        Me.StudySettingsLbl = New System.Windows.Forms.Label()
        Me.studyList = New System.Windows.Forms.ListBox()
        Me.saveSettingsBtn = New System.Windows.Forms.Button()
        Me.reactionTimeValLbl = New System.Windows.Forms.Label()
        Me.reactionTimeHSB = New System.Windows.Forms.HScrollBar()
        Me.maxNotesValLbl = New System.Windows.Forms.Label()
        Me.maxBurstValLbl = New System.Windows.Forms.Label()
        Me.minBurstValLbl = New System.Windows.Forms.Label()
        Me.maxNotesPerRiffHSB = New System.Windows.Forms.HScrollBar()
        Me.maxMsecBetweenBurstsHSB = New System.Windows.Forms.HScrollBar()
        Me.minMsecBetweenBurstsHSB = New System.Windows.Forms.HScrollBar()
        Me.allowedReactionTimeLbl = New System.Windows.Forms.Label()
        Me.maxNumberNotesPerBurstLbl = New System.Windows.Forms.Label()
        Me.maxMsecBetweenBurstsLbl = New System.Windows.Forms.Label()
        Me.minMsecBetweenBurstsLbl = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.takeNthNoteLbl = New System.Windows.Forms.Label()
        Me.takeNthNoteHSB = New System.Windows.Forms.HScrollBar()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(94, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 16)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "Note Timing"
        '
        'hitWindowValLbl
        '
        Me.hitWindowValLbl.AutoSize = True
        Me.hitWindowValLbl.Location = New System.Drawing.Point(179, 82)
        Me.hitWindowValLbl.Name = "hitWindowValLbl"
        Me.hitWindowValLbl.Size = New System.Drawing.Size(25, 13)
        Me.hitWindowValLbl.TabIndex = 94
        Me.hitWindowValLbl.Text = "500"
        '
        'hitWindowSizeHSB
        '
        Me.hitWindowSizeHSB.Location = New System.Drawing.Point(15, 82)
        Me.hitWindowSizeHSB.Maximum = 1000
        Me.hitWindowSizeHSB.Minimum = 50
        Me.hitWindowSizeHSB.Name = "hitWindowSizeHSB"
        Me.hitWindowSizeHSB.Size = New System.Drawing.Size(161, 13)
        Me.hitWindowSizeHSB.TabIndex = 93
        Me.hitWindowSizeHSB.Value = 500
        '
        'hitWindowSizeLbl
        '
        Me.hitWindowSizeLbl.AutoSize = True
        Me.hitWindowSizeLbl.Location = New System.Drawing.Point(12, 69)
        Me.hitWindowSizeLbl.Name = "hitWindowSizeLbl"
        Me.hitWindowSizeLbl.Size = New System.Drawing.Size(150, 13)
        Me.hitWindowSizeLbl.TabIndex = 92
        Me.hitWindowSizeLbl.Text = "Hit Window Size (milliseconds)"
        '
        'useBCICbox
        '
        Me.useBCICbox.AutoSize = True
        Me.useBCICbox.BackColor = System.Drawing.Color.Transparent
        Me.useBCICbox.Location = New System.Drawing.Point(81, 10)
        Me.useBCICbox.Name = "useBCICbox"
        Me.useBCICbox.Size = New System.Drawing.Size(63, 17)
        Me.useBCICbox.TabIndex = 91
        Me.useBCICbox.Text = "use BCI"
        Me.useBCICbox.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 16)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Assistance Mode Settings"
        '
        'RiffTimingLbl
        '
        Me.RiffTimingLbl.AutoSize = True
        Me.RiffTimingLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RiffTimingLbl.Location = New System.Drawing.Point(94, 31)
        Me.RiffTimingLbl.Name = "RiffTimingLbl"
        Me.RiffTimingLbl.Size = New System.Drawing.Size(82, 16)
        Me.RiffTimingLbl.TabIndex = 89
        Me.RiffTimingLbl.Text = "Riff Timing"
        '
        'explicitGainsLbl
        '
        Me.explicitGainsLbl.AutoSize = True
        Me.explicitGainsLbl.Location = New System.Drawing.Point(151, 98)
        Me.explicitGainsLbl.Name = "explicitGainsLbl"
        Me.explicitGainsLbl.Size = New System.Drawing.Size(13, 13)
        Me.explicitGainsLbl.TabIndex = 88
        Me.explicitGainsLbl.Text = "0"
        Me.explicitGainsLbl.Visible = False
        '
        'useExplicitGainsBtn
        '
        Me.useExplicitGainsBtn.AutoSize = True
        Me.useExplicitGainsBtn.Location = New System.Drawing.Point(15, 78)
        Me.useExplicitGainsBtn.Name = "useExplicitGainsBtn"
        Me.useExplicitGainsBtn.Size = New System.Drawing.Size(111, 17)
        Me.useExplicitGainsBtn.TabIndex = 87
        Me.useExplicitGainsBtn.Text = "Use Explicit Gains"
        Me.useExplicitGainsBtn.UseVisualStyleBackColor = True
        '
        'GainsHSB
        '
        Me.GainsHSB.LargeChange = 15
        Me.GainsHSB.Location = New System.Drawing.Point(16, 101)
        Me.GainsHSB.Maximum = 45
        Me.GainsHSB.Name = "GainsHSB"
        Me.GainsHSB.Size = New System.Drawing.Size(138, 10)
        Me.GainsHSB.SmallChange = 5
        Me.GainsHSB.TabIndex = 86
        Me.GainsHSB.Visible = False
        '
        'successRateLbl
        '
        Me.successRateLbl.AutoSize = True
        Me.successRateLbl.Location = New System.Drawing.Point(154, 54)
        Me.successRateLbl.Name = "successRateLbl"
        Me.successRateLbl.Size = New System.Drawing.Size(19, 13)
        Me.successRateLbl.TabIndex = 83
        Me.successRateLbl.Text = "50"
        '
        'SucRateHSB
        '
        Me.SucRateHSB.Location = New System.Drawing.Point(19, 57)
        Me.SucRateHSB.Maximum = 99
        Me.SucRateHSB.Minimum = 50
        Me.SucRateHSB.Name = "SucRateHSB"
        Me.SucRateHSB.Size = New System.Drawing.Size(138, 10)
        Me.SucRateHSB.TabIndex = 80
        Me.SucRateHSB.Value = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Set Success Rate"
        '
        'updateLstBtn
        '
        Me.updateLstBtn.Location = New System.Drawing.Point(252, 13)
        Me.updateLstBtn.Name = "updateLstBtn"
        Me.updateLstBtn.Size = New System.Drawing.Size(200, 60)
        Me.updateLstBtn.TabIndex = 79
        Me.updateLstBtn.Text = "Save and Add New Study"
        Me.updateLstBtn.UseVisualStyleBackColor = True
        '
        'addNewStudyLbl
        '
        Me.addNewStudyLbl.AutoSize = True
        Me.addNewStudyLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addNewStudyLbl.Location = New System.Drawing.Point(48, 395)
        Me.addNewStudyLbl.Name = "addNewStudyLbl"
        Me.addNewStudyLbl.Size = New System.Drawing.Size(118, 20)
        Me.addNewStudyLbl.TabIndex = 78
        Me.addNewStudyLbl.Text = "Add New Study"
        '
        'studyIDLbl
        '
        Me.studyIDLbl.AutoSize = True
        Me.studyIDLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studyIDLbl.Location = New System.Drawing.Point(33, 415)
        Me.studyIDLbl.Name = "studyIDLbl"
        Me.studyIDLbl.Size = New System.Drawing.Size(71, 20)
        Me.studyIDLbl.TabIndex = 77
        Me.studyIDLbl.Text = "Study ID"
        '
        'studyIdTb
        '
        Me.studyIdTb.Location = New System.Drawing.Point(123, 418)
        Me.studyIdTb.Name = "studyIdTb"
        Me.studyIdTb.Size = New System.Drawing.Size(69, 20)
        Me.studyIdTb.TabIndex = 76
        '
        'StudySettingsLbl
        '
        Me.StudySettingsLbl.AutoSize = True
        Me.StudySettingsLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudySettingsLbl.Location = New System.Drawing.Point(297, 23)
        Me.StudySettingsLbl.Name = "StudySettingsLbl"
        Me.StudySettingsLbl.Size = New System.Drawing.Size(142, 24)
        Me.StudySettingsLbl.TabIndex = 75
        Me.StudySettingsLbl.Text = "Study Settings"
        '
        'studyList
        '
        Me.studyList.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studyList.FormattingEnabled = True
        Me.studyList.ItemHeight = 18
        Me.studyList.Location = New System.Drawing.Point(286, 61)
        Me.studyList.Name = "studyList"
        Me.studyList.Size = New System.Drawing.Size(178, 328)
        Me.studyList.TabIndex = 74
        '
        'saveSettingsBtn
        '
        Me.saveSettingsBtn.Location = New System.Drawing.Point(15, 13)
        Me.saveSettingsBtn.Name = "saveSettingsBtn"
        Me.saveSettingsBtn.Size = New System.Drawing.Size(202, 60)
        Me.saveSettingsBtn.TabIndex = 73
        Me.saveSettingsBtn.Text = "Save Current Selection"
        Me.saveSettingsBtn.UseVisualStyleBackColor = True
        '
        'reactionTimeValLbl
        '
        Me.reactionTimeValLbl.AutoSize = True
        Me.reactionTimeValLbl.Location = New System.Drawing.Point(179, 46)
        Me.reactionTimeValLbl.Name = "reactionTimeValLbl"
        Me.reactionTimeValLbl.Size = New System.Drawing.Size(31, 13)
        Me.reactionTimeValLbl.TabIndex = 72
        Me.reactionTimeValLbl.Text = "1000"
        '
        'reactionTimeHSB
        '
        Me.reactionTimeHSB.Location = New System.Drawing.Point(15, 46)
        Me.reactionTimeHSB.Maximum = 5000
        Me.reactionTimeHSB.Minimum = 200
        Me.reactionTimeHSB.Name = "reactionTimeHSB"
        Me.reactionTimeHSB.Size = New System.Drawing.Size(161, 13)
        Me.reactionTimeHSB.TabIndex = 71
        Me.reactionTimeHSB.Value = 1000
        '
        'maxNotesValLbl
        '
        Me.maxNotesValLbl.AutoSize = True
        Me.maxNotesValLbl.Location = New System.Drawing.Point(191, 129)
        Me.maxNotesValLbl.Name = "maxNotesValLbl"
        Me.maxNotesValLbl.Size = New System.Drawing.Size(13, 13)
        Me.maxNotesValLbl.TabIndex = 70
        Me.maxNotesValLbl.Text = "1"
        '
        'maxBurstValLbl
        '
        Me.maxBurstValLbl.AutoSize = True
        Me.maxBurstValLbl.Location = New System.Drawing.Point(191, 100)
        Me.maxBurstValLbl.Name = "maxBurstValLbl"
        Me.maxBurstValLbl.Size = New System.Drawing.Size(13, 13)
        Me.maxBurstValLbl.TabIndex = 69
        Me.maxBurstValLbl.Text = "7"
        '
        'minBurstValLbl
        '
        Me.minBurstValLbl.AutoSize = True
        Me.minBurstValLbl.Location = New System.Drawing.Point(191, 74)
        Me.minBurstValLbl.Name = "minBurstValLbl"
        Me.minBurstValLbl.Size = New System.Drawing.Size(13, 13)
        Me.minBurstValLbl.TabIndex = 68
        Me.minBurstValLbl.Text = "3"
        '
        'maxNotesPerRiffHSB
        '
        Me.maxNotesPerRiffHSB.LargeChange = 1
        Me.maxNotesPerRiffHSB.Location = New System.Drawing.Point(27, 129)
        Me.maxNotesPerRiffHSB.Maximum = 5
        Me.maxNotesPerRiffHSB.Minimum = 1
        Me.maxNotesPerRiffHSB.Name = "maxNotesPerRiffHSB"
        Me.maxNotesPerRiffHSB.Size = New System.Drawing.Size(161, 13)
        Me.maxNotesPerRiffHSB.TabIndex = 67
        Me.maxNotesPerRiffHSB.Value = 1
        '
        'maxMsecBetweenBurstsHSB
        '
        Me.maxMsecBetweenBurstsHSB.Location = New System.Drawing.Point(27, 100)
        Me.maxMsecBetweenBurstsHSB.Maximum = 10000
        Me.maxMsecBetweenBurstsHSB.Minimum = 4000
        Me.maxMsecBetweenBurstsHSB.Name = "maxMsecBetweenBurstsHSB"
        Me.maxMsecBetweenBurstsHSB.Size = New System.Drawing.Size(161, 13)
        Me.maxMsecBetweenBurstsHSB.SmallChange = 10
        Me.maxMsecBetweenBurstsHSB.TabIndex = 66
        Me.maxMsecBetweenBurstsHSB.Value = 7000
        '
        'minMsecBetweenBurstsHSB
        '
        Me.minMsecBetweenBurstsHSB.Location = New System.Drawing.Point(27, 74)
        Me.minMsecBetweenBurstsHSB.Maximum = 6000
        Me.minMsecBetweenBurstsHSB.Minimum = 1
        Me.minMsecBetweenBurstsHSB.Name = "minMsecBetweenBurstsHSB"
        Me.minMsecBetweenBurstsHSB.Size = New System.Drawing.Size(161, 13)
        Me.minMsecBetweenBurstsHSB.SmallChange = 10
        Me.minMsecBetweenBurstsHSB.TabIndex = 65
        Me.minMsecBetweenBurstsHSB.Value = 3000
        '
        'allowedReactionTimeLbl
        '
        Me.allowedReactionTimeLbl.AutoSize = True
        Me.allowedReactionTimeLbl.Location = New System.Drawing.Point(12, 33)
        Me.allowedReactionTimeLbl.Name = "allowedReactionTimeLbl"
        Me.allowedReactionTimeLbl.Size = New System.Drawing.Size(197, 13)
        Me.allowedReactionTimeLbl.TabIndex = 64
        Me.allowedReactionTimeLbl.Text = "Reaction time (time notes are on screen)"
        '
        'maxNumberNotesPerBurstLbl
        '
        Me.maxNumberNotesPerBurstLbl.AutoSize = True
        Me.maxNumberNotesPerBurstLbl.Location = New System.Drawing.Point(24, 116)
        Me.maxNumberNotesPerBurstLbl.Name = "maxNumberNotesPerBurstLbl"
        Me.maxNumberNotesPerBurstLbl.Size = New System.Drawing.Size(132, 13)
        Me.maxNumberNotesPerBurstLbl.TabIndex = 63
        Me.maxNumberNotesPerBurstLbl.Text = "Maximum # notes per ""riff"""
        '
        'maxMsecBetweenBurstsLbl
        '
        Me.maxMsecBetweenBurstsLbl.AutoSize = True
        Me.maxMsecBetweenBurstsLbl.Location = New System.Drawing.Point(24, 87)
        Me.maxMsecBetweenBurstsLbl.Name = "maxMsecBetweenBurstsLbl"
        Me.maxMsecBetweenBurstsLbl.Size = New System.Drawing.Size(144, 13)
        Me.maxMsecBetweenBurstsLbl.TabIndex = 62
        Me.maxMsecBetweenBurstsLbl.Text = "Maximum sec between ""riffs"""
        '
        'minMsecBetweenBurstsLbl
        '
        Me.minMsecBetweenBurstsLbl.AutoSize = True
        Me.minMsecBetweenBurstsLbl.Location = New System.Drawing.Point(24, 61)
        Me.minMsecBetweenBurstsLbl.Name = "minMsecBetweenBurstsLbl"
        Me.minMsecBetweenBurstsLbl.Size = New System.Drawing.Size(141, 13)
        Me.minMsecBetweenBurstsLbl.TabIndex = 61
        Me.minMsecBetweenBurstsLbl.Text = "Minimum sec between ""riffs"""
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.addNewStudyLbl)
        Me.Panel1.Controls.Add(Me.studyIdTb)
        Me.Panel1.Controls.Add(Me.studyIDLbl)
        Me.Panel1.Location = New System.Drawing.Point(264, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(223, 460)
        Me.Panel1.TabIndex = 96
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(246, 146)
        Me.Panel2.TabIndex = 97
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.takeNthNoteLbl)
        Me.Panel3.Controls.Add(Me.takeNthNoteHSB)
        Me.Panel3.Controls.Add(Me.allowedReactionTimeLbl)
        Me.Panel3.Controls.Add(Me.hitWindowValLbl)
        Me.Panel3.Controls.Add(Me.reactionTimeHSB)
        Me.Panel3.Controls.Add(Me.hitWindowSizeHSB)
        Me.Panel3.Controls.Add(Me.reactionTimeValLbl)
        Me.Panel3.Controls.Add(Me.hitWindowSizeLbl)
        Me.Panel3.Location = New System.Drawing.Point(12, 162)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(246, 143)
        Me.Panel3.TabIndex = 98
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 13)
        Me.Label5.TabIndex = 97
        Me.Label5.Text = "Take every Nth note"
        '
        'takeNthNoteLbl
        '
        Me.takeNthNoteLbl.AutoSize = True
        Me.takeNthNoteLbl.Location = New System.Drawing.Point(179, 115)
        Me.takeNthNoteLbl.Name = "takeNthNoteLbl"
        Me.takeNthNoteLbl.Size = New System.Drawing.Size(25, 13)
        Me.takeNthNoteLbl.TabIndex = 96
        Me.takeNthNoteLbl.Text = "500"
        '
        'takeNthNoteHSB
        '
        Me.takeNthNoteHSB.LargeChange = 1
        Me.takeNthNoteHSB.Location = New System.Drawing.Point(15, 115)
        Me.takeNthNoteHSB.Maximum = 5
        Me.takeNthNoteHSB.Minimum = 1
        Me.takeNthNoteHSB.Name = "takeNthNoteHSB"
        Me.takeNthNoteHSB.Size = New System.Drawing.Size(161, 13)
        Me.takeNthNoteHSB.TabIndex = 95
        Me.takeNthNoteHSB.Value = 5
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.useBCICbox)
        Me.Panel4.Location = New System.Drawing.Point(12, 439)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(246, 33)
        Me.Panel4.TabIndex = 99
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.saveSettingsBtn)
        Me.Panel5.Controls.Add(Me.updateLstBtn)
        Me.Panel5.Location = New System.Drawing.Point(12, 478)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(475, 89)
        Me.Panel5.TabIndex = 100
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.SucRateHSB)
        Me.Panel6.Controls.Add(Me.successRateLbl)
        Me.Panel6.Controls.Add(Me.explicitGainsLbl)
        Me.Panel6.Controls.Add(Me.useExplicitGainsBtn)
        Me.Panel6.Controls.Add(Me.GainsHSB)
        Me.Panel6.Location = New System.Drawing.Point(12, 311)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(246, 122)
        Me.Panel6.TabIndex = 99
        '
        'RiffHeroSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(503, 582)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RiffTimingLbl)
        Me.Controls.Add(Me.StudySettingsLbl)
        Me.Controls.Add(Me.studyList)
        Me.Controls.Add(Me.maxNotesValLbl)
        Me.Controls.Add(Me.maxBurstValLbl)
        Me.Controls.Add(Me.minBurstValLbl)
        Me.Controls.Add(Me.maxNotesPerRiffHSB)
        Me.Controls.Add(Me.maxMsecBetweenBurstsHSB)
        Me.Controls.Add(Me.minMsecBetweenBurstsHSB)
        Me.Controls.Add(Me.maxNumberNotesPerBurstLbl)
        Me.Controls.Add(Me.maxMsecBetweenBurstsLbl)
        Me.Controls.Add(Me.minMsecBetweenBurstsLbl)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "RiffHeroSettings"
        Me.Text = "RiffHeroSettings"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents hitWindowValLbl As System.Windows.Forms.Label
    Friend WithEvents hitWindowSizeHSB As System.Windows.Forms.HScrollBar
    Friend WithEvents hitWindowSizeLbl As System.Windows.Forms.Label
    Friend WithEvents useBCICbox As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RiffTimingLbl As System.Windows.Forms.Label
    Friend WithEvents explicitGainsLbl As System.Windows.Forms.Label
    Friend WithEvents useExplicitGainsBtn As System.Windows.Forms.CheckBox
    Friend WithEvents GainsHSB As System.Windows.Forms.HScrollBar
    Friend WithEvents successRateLbl As System.Windows.Forms.Label
    Friend WithEvents SucRateHSB As System.Windows.Forms.HScrollBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents updateLstBtn As System.Windows.Forms.Button
    Friend WithEvents addNewStudyLbl As System.Windows.Forms.Label
    Friend WithEvents studyIDLbl As System.Windows.Forms.Label
    Friend WithEvents studyIdTb As System.Windows.Forms.TextBox
    Friend WithEvents StudySettingsLbl As System.Windows.Forms.Label
    Friend WithEvents studyList As System.Windows.Forms.ListBox
    Friend WithEvents saveSettingsBtn As System.Windows.Forms.Button
    Friend WithEvents reactionTimeValLbl As System.Windows.Forms.Label
    Friend WithEvents reactionTimeHSB As System.Windows.Forms.HScrollBar
    Friend WithEvents maxNotesValLbl As System.Windows.Forms.Label
    Friend WithEvents maxBurstValLbl As System.Windows.Forms.Label
    Friend WithEvents minBurstValLbl As System.Windows.Forms.Label
    Friend WithEvents maxNotesPerRiffHSB As System.Windows.Forms.HScrollBar
    Friend WithEvents maxMsecBetweenBurstsHSB As System.Windows.Forms.HScrollBar
    Friend WithEvents minMsecBetweenBurstsHSB As System.Windows.Forms.HScrollBar
    Friend WithEvents allowedReactionTimeLbl As System.Windows.Forms.Label
    Friend WithEvents maxNumberNotesPerBurstLbl As System.Windows.Forms.Label
    Friend WithEvents maxMsecBetweenBurstsLbl As System.Windows.Forms.Label
    Friend WithEvents minMsecBetweenBurstsLbl As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents takeNthNoteLbl As System.Windows.Forms.Label
    Friend WithEvents takeNthNoteHSB As System.Windows.Forms.HScrollBar
End Class
