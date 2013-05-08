Public Class Menu

    Private subPopulation As SubPop
    Private gamePopulation As GamePop        
    Private gameRunning As Boolean
    Public rehabSettingsMenu As RehabHeroSettings    
    Public riffSettingsMenu As RiffHeroSettings
    Public newSubjMenu As NewSubjectForm
    Public rehabHeroPrep As SongPrep
    Public riffHeroPrep As SongPrep

    '--------------------------------------------------------------------------------'
    '------------------------- constructor for the menu screen ----------------------'
    '--------------------------------------------------------------------------------'
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        subPopulation = New SubPop()
        gamePopulation = New GamePop()
        subjectList.DataSource = subPopulation.subIds
        gameList.DataSource = gamePopulation.gameIds
        gameRunning = 0
        currentSub = subPopulation.subjects(0)
        currentGame = gamePopulation.gameIds(0)
        lastGameLbl.Text = "n/a"
    End Sub

    '--------------------------------------------------------------------------------'
    '-------------------------- add subject menu item event -------------------------'
    '--------------------------------------------------------------------------------'    
    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        'open a new form that takes the subject ID and has an add button
        newSubjMenu = New NewSubjectForm
        newSubjMenu.Show()
    End Sub

    '--------------------------------------------------------------------------------'
    '--------------------------- click subject list event ---------------------------'
    '--------------------------------------------------------------------------------'
    Private Sub subjectList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subjectList.SelectedIndexChanged
        Dim selected As Integer
        selected = subjectList.SelectedIndex
        currentSub = subPopulation.subjects(selected)
        updateSubjectInfoGUI()
    End Sub

    Private Sub updateSubjectInfoGUI()
        lastSessionLabel.Text = currentSub.getSessionString()
        lastGameLbl.Text = currentSub.lastGame
        sessionNumberTB.Text = currentSub.getExpectedSessionNumber()
    End Sub

    '--------------------------------------------------------------------------------'
    '-------------- refresh the subject list after adding a new subject -------------'
    '--------------------------------------------------------------------------------'
    Private Sub RefreshBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshBtn.Click
        If Not (addSubjID = "") Then
            'refresh the subject list
            Dim num As Integer      ' number corresponding to subject            
            Dim subj As Subject     ' subject

            num = subPopulation.popSize + 1
            subj = New Subject(num, addSubjID, 1)
            subj.hand = addSubjHand
            subPopulation.addSubject(subj)

            subjectList.DataSource = subPopulation.subIds
            subjectList.Update()

            addSubjID = ""
        Else
            subjectList.DataSource = subPopulation.subIds
            subjectList.Update()
        End If
    End Sub

    '--------------------------------------------------------------------------------'
    '------------------------------ click game list event ---------------------------'
    '--------------------------------------------------------------------------------'
    Private Sub gameList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gameList.SelectedIndexChanged
        Dim selected As Integer
        selected = gameList.SelectedIndex
        currentGame = gamePopulation.gameIds(selected)
        thumbnail.ImageLocation = (GAMEPATH & "Games\" & currentGame & "\thumbnail.jpg")
        gameNameLbl.Text = currentGame
    End Sub



    '--------------------------------------------------------------------------------'
    '---------------------------------- run game button -----------------------------'
    '--------------------------------------------------------------------------------'
    Private Sub runBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles runBtn.Click

        If currentSub.ID = "default" Or currentGame = "default" Then : MsgBox("Please select a subject and game") : Return : End If                

        Select Case currentGame
            Case "Rehab_Hero"
                rehabHeroPrep = New SongPrep
                rehabHeroPrep.Show()
            Case "Riff_Hero"
                riffHeroPrep = New SongPrep
                riffHeroPrep.Show()
            Case Else
                Return
        End Select

        currentSub.trial += 1
        currentSub.lastSessionDate = Now()
        currentSub.lastSessionNumber = sessionNumberTB.Text
        currentSub.update()

    End Sub

    '--------------------------------------------------------------------------------'
    '--------------------------- Game Settings Btn press ----------------------------'
    '--------------------------------------------------------------------------------'
    Private Sub gameSettingsBtn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles gameSettingsBtn.Click
        Select Case currentGame
            Case "Rehab_Hero"
                rehabSettingsMenu = New RehabHeroSettings
                rehabSettingsMenu.Show()
            Case "Riff_Hero"
                riffSettingsMenu = New RiffHeroSettings
                riffSettingsMenu.Show()
            Case Else
                MsgBox("Please select a valid game type")
        End Select
    End Sub

    '--------------------------------------------------------------------------------'
    '-------------------------- robot selection btn press ---------------------------'
    '--------------------------------------------------------------------------------'
    Private Sub FingerBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FingerBtn.Click
        currentDevice = "fingerbot"
        FingerPB.Value = 100
        MusicGlovePB.Value = 0
    End Sub
    Private Sub MusicGloveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MusicGloveBtn.Click
        currentDevice = "musicglove"
        FingerPB.Value = 0
        MusicGlovePB.Value = 100
    End Sub

End Class