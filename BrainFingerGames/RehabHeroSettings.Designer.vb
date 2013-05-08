<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RehabHeroSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RehabHeroSettings))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.hitWindowValLbl = New System.Windows.Forms.Label()
        Me.hitWindowSizeHSB = New System.Windows.Forms.HScrollBar()
        Me.hitWindowSizeLbl = New System.Windows.Forms.Label()
        Me.useBCICbox = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.allowedReactionTimeLbl = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(71, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 16)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "Note Timing"
        '
        'hitWindowValLbl
        '
        Me.hitWindowValLbl.AutoSize = True
        Me.hitWindowValLbl.Location = New System.Drawing.Point(178, 100)
        Me.hitWindowValLbl.Name = "hitWindowValLbl"
        Me.hitWindowValLbl.Size = New System.Drawing.Size(25, 13)
        Me.hitWindowValLbl.TabIndex = 84
        Me.hitWindowValLbl.Text = "500"
        '
        'hitWindowSizeHSB
        '
        Me.hitWindowSizeHSB.Location = New System.Drawing.Point(14, 100)
        Me.hitWindowSizeHSB.Maximum = 1000
        Me.hitWindowSizeHSB.Minimum = 50
        Me.hitWindowSizeHSB.Name = "hitWindowSizeHSB"
        Me.hitWindowSizeHSB.Size = New System.Drawing.Size(161, 13)
        Me.hitWindowSizeHSB.TabIndex = 83
        Me.hitWindowSizeHSB.Value = 500
        '
        'hitWindowSizeLbl
        '
        Me.hitWindowSizeLbl.AutoSize = True
        Me.hitWindowSizeLbl.Location = New System.Drawing.Point(11, 87)
        Me.hitWindowSizeLbl.Name = "hitWindowSizeLbl"
        Me.hitWindowSizeLbl.Size = New System.Drawing.Size(150, 13)
        Me.hitWindowSizeLbl.TabIndex = 82
        Me.hitWindowSizeLbl.Text = "Hit Window Size (milliseconds)"
        '
        'useBCICbox
        '
        Me.useBCICbox.AutoSize = True
        Me.useBCICbox.BackColor = System.Drawing.Color.Transparent
        Me.useBCICbox.Location = New System.Drawing.Point(81, 6)
        Me.useBCICbox.Name = "useBCICbox"
        Me.useBCICbox.Size = New System.Drawing.Size(63, 17)
        Me.useBCICbox.TabIndex = 81
        Me.useBCICbox.Text = "use BCI"
        Me.useBCICbox.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 16)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Assistance Mode Settings"
        '
        'explicitGainsLbl
        '
        Me.explicitGainsLbl.AutoSize = True
        Me.explicitGainsLbl.Location = New System.Drawing.Point(163, 106)
        Me.explicitGainsLbl.Name = "explicitGainsLbl"
        Me.explicitGainsLbl.Size = New System.Drawing.Size(13, 13)
        Me.explicitGainsLbl.TabIndex = 79
        Me.explicitGainsLbl.Text = "0"
        Me.explicitGainsLbl.Visible = False
        '
        'useExplicitGainsBtn
        '
        Me.useExplicitGainsBtn.AutoSize = True
        Me.useExplicitGainsBtn.Location = New System.Drawing.Point(27, 86)
        Me.useExplicitGainsBtn.Name = "useExplicitGainsBtn"
        Me.useExplicitGainsBtn.Size = New System.Drawing.Size(111, 17)
        Me.useExplicitGainsBtn.TabIndex = 78
        Me.useExplicitGainsBtn.Text = "Use Explicit Gains"
        Me.useExplicitGainsBtn.UseVisualStyleBackColor = True
        '
        'GainsHSB
        '
        Me.GainsHSB.LargeChange = 15
        Me.GainsHSB.Location = New System.Drawing.Point(28, 109)
        Me.GainsHSB.Maximum = 45
        Me.GainsHSB.Name = "GainsHSB"
        Me.GainsHSB.Size = New System.Drawing.Size(138, 10)
        Me.GainsHSB.SmallChange = 5
        Me.GainsHSB.TabIndex = 77
        Me.GainsHSB.Visible = False
        '
        'successRateLbl
        '
        Me.successRateLbl.AutoSize = True
        Me.successRateLbl.Location = New System.Drawing.Point(163, 55)
        Me.successRateLbl.Name = "successRateLbl"
        Me.successRateLbl.Size = New System.Drawing.Size(19, 13)
        Me.successRateLbl.TabIndex = 74
        Me.successRateLbl.Text = "50"
        '
        'SucRateHSB
        '
        Me.SucRateHSB.Location = New System.Drawing.Point(28, 58)
        Me.SucRateHSB.Maximum = 99
        Me.SucRateHSB.Minimum = 50
        Me.SucRateHSB.Name = "SucRateHSB"
        Me.SucRateHSB.Size = New System.Drawing.Size(138, 10)
        Me.SucRateHSB.TabIndex = 71
        Me.SucRateHSB.Value = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Set Success Rate"
        '
        'updateLstBtn
        '
        Me.updateLstBtn.Location = New System.Drawing.Point(243, 15)
        Me.updateLstBtn.Name = "updateLstBtn"
        Me.updateLstBtn.Size = New System.Drawing.Size(186, 60)
        Me.updateLstBtn.TabIndex = 70
        Me.updateLstBtn.Text = "Save and Add New Study"
        Me.updateLstBtn.UseVisualStyleBackColor = True
        '
        'addNewStudyLbl
        '
        Me.addNewStudyLbl.AutoSize = True
        Me.addNewStudyLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addNewStudyLbl.Location = New System.Drawing.Point(36, 271)
        Me.addNewStudyLbl.Name = "addNewStudyLbl"
        Me.addNewStudyLbl.Size = New System.Drawing.Size(118, 20)
        Me.addNewStudyLbl.TabIndex = 69
        Me.addNewStudyLbl.Text = "Add New Study"
        '
        'studyIDLbl
        '
        Me.studyIDLbl.AutoSize = True
        Me.studyIDLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studyIDLbl.Location = New System.Drawing.Point(21, 291)
        Me.studyIDLbl.Name = "studyIDLbl"
        Me.studyIDLbl.Size = New System.Drawing.Size(71, 20)
        Me.studyIDLbl.TabIndex = 68
        Me.studyIDLbl.Text = "Study ID"
        '
        'studyIdTb
        '
        Me.studyIdTb.Location = New System.Drawing.Point(111, 294)
        Me.studyIdTb.Name = "studyIdTb"
        Me.studyIdTb.Size = New System.Drawing.Size(69, 20)
        Me.studyIdTb.TabIndex = 67
        '
        'StudySettingsLbl
        '
        Me.StudySettingsLbl.AutoSize = True
        Me.StudySettingsLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudySettingsLbl.Location = New System.Drawing.Point(289, 28)
        Me.StudySettingsLbl.Name = "StudySettingsLbl"
        Me.StudySettingsLbl.Size = New System.Drawing.Size(142, 24)
        Me.StudySettingsLbl.TabIndex = 66
        Me.StudySettingsLbl.Text = "Study Settings"
        '
        'studyList
        '
        Me.studyList.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studyList.FormattingEnabled = True
        Me.studyList.ItemHeight = 18
        Me.studyList.Location = New System.Drawing.Point(278, 66)
        Me.studyList.Name = "studyList"
        Me.studyList.Size = New System.Drawing.Size(157, 202)
        Me.studyList.TabIndex = 65
        '
        'saveSettingsBtn
        '
        Me.saveSettingsBtn.Location = New System.Drawing.Point(6, 15)
        Me.saveSettingsBtn.Name = "saveSettingsBtn"
        Me.saveSettingsBtn.Size = New System.Drawing.Size(202, 60)
        Me.saveSettingsBtn.TabIndex = 64
        Me.saveSettingsBtn.Text = "Save Current Selection"
        Me.saveSettingsBtn.UseVisualStyleBackColor = True
        '
        'reactionTimeValLbl
        '
        Me.reactionTimeValLbl.AutoSize = True
        Me.reactionTimeValLbl.Location = New System.Drawing.Point(178, 64)
        Me.reactionTimeValLbl.Name = "reactionTimeValLbl"
        Me.reactionTimeValLbl.Size = New System.Drawing.Size(31, 13)
        Me.reactionTimeValLbl.TabIndex = 63
        Me.reactionTimeValLbl.Text = "1000"
        '
        'reactionTimeHSB
        '
        Me.reactionTimeHSB.Location = New System.Drawing.Point(14, 64)
        Me.reactionTimeHSB.Maximum = 5000
        Me.reactionTimeHSB.Minimum = 200
        Me.reactionTimeHSB.Name = "reactionTimeHSB"
        Me.reactionTimeHSB.Size = New System.Drawing.Size(161, 13)
        Me.reactionTimeHSB.TabIndex = 62
        Me.reactionTimeHSB.Value = 1000
        '
        'allowedReactionTimeLbl
        '
        Me.allowedReactionTimeLbl.AutoSize = True
        Me.allowedReactionTimeLbl.Location = New System.Drawing.Point(11, 45)
        Me.allowedReactionTimeLbl.Name = "allowedReactionTimeLbl"
        Me.allowedReactionTimeLbl.Size = New System.Drawing.Size(197, 13)
        Me.allowedReactionTimeLbl.TabIndex = 61
        Me.allowedReactionTimeLbl.Text = "Reaction time (time notes are on screen)"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.addNewStudyLbl)
        Me.Panel1.Controls.Add(Me.studyIdTb)
        Me.Panel1.Controls.Add(Me.studyIDLbl)
        Me.Panel1.Location = New System.Drawing.Point(255, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 328)
        Me.Panel1.TabIndex = 86
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.hitWindowValLbl)
        Me.Panel2.Controls.Add(Me.allowedReactionTimeLbl)
        Me.Panel2.Controls.Add(Me.hitWindowSizeHSB)
        Me.Panel2.Controls.Add(Me.reactionTimeHSB)
        Me.Panel2.Controls.Add(Me.hitWindowSizeLbl)
        Me.Panel2.Controls.Add(Me.reactionTimeValLbl)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(237, 138)
        Me.Panel2.TabIndex = 70
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.successRateLbl)
        Me.Panel3.Controls.Add(Me.explicitGainsLbl)
        Me.Panel3.Controls.Add(Me.SucRateHSB)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.useExplicitGainsBtn)
        Me.Panel3.Controls.Add(Me.GainsHSB)
        Me.Panel3.Location = New System.Drawing.Point(12, 156)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(237, 152)
        Me.Panel3.TabIndex = 70
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.useBCICbox)
        Me.Panel4.Location = New System.Drawing.Point(12, 312)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(237, 28)
        Me.Panel4.TabIndex = 70
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.saveSettingsBtn)
        Me.Panel5.Controls.Add(Me.updateLstBtn)
        Me.Panel5.Location = New System.Drawing.Point(12, 346)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(443, 88)
        Me.Panel5.TabIndex = 87
        '
        'RehabHeroSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(473, 448)
        Me.Controls.Add(Me.StudySettingsLbl)
        Me.Controls.Add(Me.studyList)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Name = "RehabHeroSettings"
        Me.Text = "RehabHeroSettings"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents hitWindowValLbl As System.Windows.Forms.Label
    Friend WithEvents hitWindowSizeHSB As System.Windows.Forms.HScrollBar
    Friend WithEvents hitWindowSizeLbl As System.Windows.Forms.Label
    Friend WithEvents useBCICbox As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
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
    Friend WithEvents allowedReactionTimeLbl As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
End Class
