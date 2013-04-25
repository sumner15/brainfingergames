Public Class Menu

    Private pop As Population
    'Private library As Library
    Private gameRunning As Boolean    

    '--------------------------------------------------------------------------------'
    '------------------------- constructor for the menu screen ----------------------'
    '--------------------------------------------------------------------------------'
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        pop = New Population()
        'library = New Library()
        subjectList.DataSource = pop.subIds
        'gameList.DataSource = library.gameNames
        gameRunning = 0
        currentSub = pop.subjects(0)
        'currentGame = library.games(0)
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
        currentSub = pop.subjects(selected)
        updateSubjectInfoGUI()
    End Sub

    Private Sub updateSubjectInfoGUI()
        lastSessionLabel.Text = currentSub.getSessionString()
        sessionNumberTB.Text = currentSub.getExpectedSessionNumber()
    End Sub

    '--------------------------------------------------------------------------------'
    '------------------------------ click song list event ---------------------------'
    '--------------------------------------------------------------------------------'
    Private Sub gameList_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim selected As Integer
        selected = gameList.SelectedIndex
        'currentGame = library.game(selected)
        'thumbnail.ImageLocation = currentGame.gamePath & "thumbnail.jpg"
        'gameNameLbl.Text = currentGame.name
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
    End Sub

    '--------------------------------------------------------------------------------'
    '--------------------------- Game Settings Btn press ----------------------------'
    '--------------------------------------------------------------------------------'
    Private Sub gameSettingsBtn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles gameSettingsBtn.Click
        ''opens a new settings form
        'settingsMenu = New settingsForm
        'settingsMenu.Show()
    End Sub


End Class