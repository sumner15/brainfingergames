﻿Public Class RiffHeroSettings
    Private studyPop As StudyPop

    '--------------------------------------------------------------------------------'
    '---------------------- constructor for the settings screen ---------------------'
    '--------------------------------------------------------------------------------'
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.                  
        studyPop = New studyPop()
        studyList.DataSource = studyPop.studyIds
        riffHeroSets.readGameSetFile()
        set_allLabels()
    End Sub


    '--------------------------------------------------------------------------------'
    '---------------------- reset the labels when a HSB is used ---------------------'
    '--------------------------------------------------------------------------------'
#Region "HSB value labels"
    Private Sub minMsecBetweenBurstsHSB_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles minMsecBetweenBurstsHSB.Scroll
        minBurstValLbl.Text = CStr(CSng(minMsecBetweenBurstsHSB.Value))
    End Sub

    Private Sub maxMsecBetweenBurstsHSB_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles maxMsecBetweenBurstsHSB.Scroll
        maxBurstValLbl.Text = CStr(CSng(maxMsecBetweenBurstsHSB.Value))
    End Sub

    Private Sub maxNotesPerRiffHSB_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles maxNotesPerRiffHSB.Scroll
        maxNotesValLbl.Text = CStr(CSng(maxNotesPerRiffHSB.Value))
    End Sub

    Private Sub reactionTimeHSB_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles reactionTimeHSB.Scroll
        reactionTimeValLbl.Text = CStr(CSng(reactionTimeHSB.Value))
    End Sub

    Private Sub hitWindowSizeHSB_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles hitWindowSizeHSB.Scroll
        hitWindowValLbl.Text = CStr(CSng(hitWindowSizeHSB.Value))
    End Sub

    Private Sub GainsHSB_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles GainsHSB.Scroll
        explicitGainsLbl.Text = CStr(CSng(GainsHSB.Value))
    End Sub

#End Region

    '--------------------------------------------------------------------------------'
    '--------------------------- click save set list event --------------------------'
    '--------------------------------------------------------------------------------'
    Private Sub saveSettingsBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saveSettingsBtn.Click
        'make sure we have set real-life-possible values before we set anything
        If CSng(maxMsecBetweenBurstsHSB.Value) > CSng(minMsecBetweenBurstsHSB.Value) Then
            '---set all the settings from the scrollbars---'
            set_allSettings()
            Me.Close() 'close the setting window'
        Else
            MsgBox("please set the maximum time between bursts larger than the minimum time between bursts")
        End If

    End Sub


    '--------------------------------------------------------------------------------'
    '--------------------------- click study list event -----------------------------'
    '--------------------------------------------------------------------------------'
    Private Sub studyList_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles studyList.SelectedValueChanged
        Dim selected As Integer
        selected = studyList.SelectedIndex

        riffHeroSets.settingsFileName = studyList.SelectedValue
        riffHeroSets.readGameSetFile()

        'first, check if there is an existing settings file. Otherwise, the default values will be set
        If My.Computer.FileSystem.FileExists(GAMEPATH & "gameSettings\" & riffHeroSets.settingsFileName & ".txt") Then
            get_allSettings()
        End If
        set_allLabels()
    End Sub

    '--------------------------------------------------------------------------------'
    '---------------------------- add study button event ----------------------------'
    '--------------------------------------------------------------------------------'
    Private Sub updateLstBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updateLstBtn.Click
        If Not (studyIdTb.Text = "") Then
            riffHeroSets.settingsFileName = studyIdTb.Text
            ' make sure we have set real-life-possible values before we set anything
            If CSng(maxMsecBetweenBurstsHSB.Value) > CSng(minMsecBetweenBurstsHSB.Value) Then
                '---set all the settings from the scrollbars---'
                set_allSettings()
            Else
                MsgBox("please set the maximum time between bursts larger than the minimum time between bursts")
            End If

            'update the studies list'
            studyPop.addStudy(studyIdTb.Text)
            studyList.DataSource = studyPop.studyIds
            studyList.Update()

            Me.Close() 'close the setting window'
        Else
            MsgBox("Enter the subject's information before trying to save the subject.")
        End If
    End Sub


    '--------------------------------------------------------------------------------'
    '------------------------ update success rate scroll bars -----------------------'
    '--------------------------------------------------------------------------------'
    Private Sub SucRateHSB_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles SucRateHSB.Scroll
        ' I want this slider to be discrete
        If SucRateHSB.Value >= 80 Then
            SucRateHSB.Value = 99
        ElseIf SucRateHSB.Value < 80 And SucRateHSB.Value > 60 Then
            SucRateHSB.Value = 75
        ElseIf SucRateHSB.Value <= 60 Then
            SucRateHSB.Value = 50
        End If

        successRateLbl.Text = CStr(CSng(SucRateHSB.Value) / 100)
    End Sub

    Private Sub FakeSucRateHSB_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles FakeSucRateHSB.Scroll
        If FakeSucRateHSB.Value >= 80 Then
            FakeSucRateHSB.Value = 99
        ElseIf FakeSucRateHSB.Value < 80 And FakeSucRateHSB.Value > 60 Then
            FakeSucRateHSB.Value = 75
        ElseIf FakeSucRateHSB.Value <= 60 Then
            FakeSucRateHSB.Value = 50
        End If

        fakeSuccessRateLbl.Text = CStr(CSng(FakeSucRateHSB.Value) / 100)
    End Sub

    '--------------------------------------------------------------------------------'
    '----------------- toggle explicit gains settings visibility --------------------'
    '--------------------------------------------------------------------------------'
    Private Sub useExplicitGainsBtn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles useExplicitGainsBtn.CheckedChanged
        GainsHSB.Visible = useExplicitGainsBtn.Checked
        explicitGainsLbl.Visible = useExplicitGainsBtn.Checked
        useExplicitGains = useExplicitGainsBtn.Checked 'set the global var

        If useExplicitGainsBtn.Checked Then
            successRateLbl.Text = "not used"
            fakeSuccessRateLbl.Text = "not used"
        Else
            successRateLbl.Text = "please set"
            fakeSuccessRateLbl.Text = "please set"
        End If
    End Sub

    '--------------------------------------------------------------------------------'
    '-------------------- common use functions (get/set values) ---------------------'
    '--------------------------------------------------------------------------------'
#Region "get and set"
    Private Sub set_allSettings()
        'this function's purpose is to set all values from the scroll bars to the riffHeroSets object
        riffHeroSets.set_minMsecBetweenBursts(CSng(minMsecBetweenBurstsHSB.Value))
        riffHeroSets.set_maxMsecBetweenBursts(CSng(maxMsecBetweenBurstsHSB.Value))
        riffHeroSets.set_maxNumberNotesPerBurst(CSng(maxNotesPerRiffHSB.Value))
        riffHeroSets.set_allowedReactionTime(CSng(reactionTimeHSB.Value))
        riffHeroSets.set_hitWindowSize(CSng(hitWindowSizeHSB.Value))
        riffHeroSets.set_useExplicitGains(CSng(useExplicitGainsBtn.Checked))
        riffHeroSets.set_sucRate(CSng(SucRateHSB.Value))
        riffHeroSets.set_fakeSucRate(CSng(FakeSucRateHSB.Value))
        riffHeroSets.set_gains(CSng(GainsHSB.Value))
        riffHeroSets.set_useBCI(CSng(useBCICbox.Checked))
        riffHeroSets.writeGameSetFile()
    End Sub

    Private Sub get_allSettings()
        'this function's purpose is to retrieve the settings from the riffHeroSets object
        'in order to set those values on the scroll bars
        minMsecBetweenBurstsHSB.Value = riffHeroSets.get_minMsecBetweenBursts
        maxMsecBetweenBurstsHSB.Value = riffHeroSets.get_maxMsecBetweenBursts
        maxNotesPerRiffHSB.Value = riffHeroSets.get_maxNumberNotesPerBurst
        reactionTimeHSB.Value = riffHeroSets.get_allowedReactionTime
        hitWindowSizeHSB.Value = riffHeroSets.get_hitWindowSize
        useExplicitGainsBtn.Checked = riffHeroSets.get_useExplicitGains
        SucRateHSB.Value = riffHeroSets.get_sucRate
        FakeSucRateHSB.Value = riffHeroSets.get_fakeSucRate
        GainsHSB.Value = riffHeroSets.get_gains
        useBCICbox.Checked = riffHeroSets.get_useBCI
    End Sub

    Private Sub set_allLabels()
        'this function's purpose is to refresh the labels next to each scroll bar
        minBurstValLbl.Text = CStr(CSng(minMsecBetweenBurstsHSB.Value))
        maxBurstValLbl.Text = CStr(CSng(maxMsecBetweenBurstsHSB.Value))
        maxNotesValLbl.Text = CStr(CSng(maxNotesPerRiffHSB.Value))
        reactionTimeValLbl.Text = CStr(CSng(reactionTimeHSB.Value))
        hitWindowValLbl.Text = CStr(CSng(hitWindowSizeHSB.Value))
        successRateLbl.Text = CStr(CSng(SucRateHSB.Value))
        fakeSuccessRateLbl.Text = CStr(CSng(FakeSucRateHSB.Value))
        explicitGainsLbl.Text = CStr(CSng(GainsHSB.Value))
    End Sub
#End Region
End Class