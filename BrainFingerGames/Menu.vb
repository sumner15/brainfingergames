Public Class Menu

    Private subPopulation As SubPop
    Private gamePopulation As GamePop        
    Private gameRunning As Boolean
    Public rehabSettingsMenu As RehabHeroSettings    
    Public riffSettingsMenu As RiffHeroSettings

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
    End Sub

    '--------------------------------------------------------------------------------'
    '-------------------------- add subject menu item event -------------------------'
    '--------------------------------------------------------------------------------'    
    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        'open a new form that takes the subject ID and has an add button                                                                            FIXME
    End Sub

    '--------------------------------------------------------------------------------'
    '--------------------------- click subject list event ---------------------------'
    '--------------------------------------------------------------------------------'
    Private Sub subjectList_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim selected As Integer
        selected = subjectList.SelectedIndex
        currentSub = subPopulation.subjects(selected)
        updateSubjectInfoGUI()
    End Sub

    Private Sub updateSubjectInfoGUI()
        lastSessionLabel.Text = currentSub.getSessionString()
        sessionNumberTB.Text = currentSub.getExpectedSessionNumber()
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

        If currentSub.ID = "default" Then MsgBox("select a real subject name") : Return

        currentSub.trial += 1
        currentSub.lastSessionDate = Now()
        currentSub.lastSessionNumber = sessionNumberTB.Text
        currentSub.update()
        updateSubjectInfoGUI()


        Select Case currentGame
            Case "Rehab_Hero"
                'run this game                
            Case "Riff_Hero"
                'run this game                
            Case Else
                Return
        End Select

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

End Class