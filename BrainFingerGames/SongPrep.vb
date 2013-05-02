Public Class SongPrep
    Private library As Library
    Dim gameSets As GuitarSettings
    Private gameRunning As Boolean
    'Public ourWindow As SongGame FIXME

    Enum level As Integer
        superEasy = 1
        easy = 2
        medium = 3
        Amazing = 4
    End Enum

    '--------------------------------------------------------------------------------'
    '------------------------- constructor for the prep screen ----------------------'
    '--------------------------------------------------------------------------------'
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        library = New Library()        
        songList.DataSource = Library.songNames
        gameRunning = 0
        currentSong = Library.songs(0)
    End Sub

    '--------------------------------------------------------------------------------'
    '------------------------------ click song list event ---------------------------'
    '--------------------------------------------------------------------------------'    
    Private Sub songList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles songList.SelectedIndexChanged
        Dim selected As Integer
        selected = songList.SelectedIndex
        currentSong = Library.songs(selected)
        thumbnail.ImageLocation = currentSong.songPath & "thumbnail.jpg"
        songNameLbl.Text = currentSong.name
    End Sub

    '--------------------------------------------------------------------------------'
    '---------------------------------- play song button ----------------------------'
    '--------------------------------------------------------------------------------'
    Private Sub playSongBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles playSongBtn.Click        

        Select Case currentGame
            Case "Rehab_Hero"
                gameSets = rehabHeroSets
            Case "Riff_Hero"
                gameSets = riffHeroSets
            Case Else
                MsgBox("Please select proper game type") : Close() : Return                
        End Select

        Dim successRate As Single
        Dim perceivedSuccessRate As Single
        Dim difficulties() As Integer = {level.superEasy, level.easy, level.medium}
        If Not difficultyList.SelectedIndex >= level.superEasy Then
            difficultyList.SelectedIndex = level.superEasy
        End If

        successRate = CSng(gameSets.get_sucRate) / 100.0
        perceivedSuccessRate = CSng(gameSets.get_fakeSucRate) / 100.0

        If successRate = 0 Then successRate = 0.75
        If perceivedSuccessRate = 0 Then perceivedSuccessRate = 0.75

        If Not gameRunning Then
            If useExplicitGains Then

                Dim propGains() As Single = {gameSets.get_gains, gameSets.get_gains}

                gameRunning = True
                trialStr = currentSong.name & "_" & CStr(CInt(perceivedSuccessRate * 100)) & "_"
                'ourWindow = New SongGame(currentSong, perceivedSuccessRate, propGains, difficulties(difficultyList.SelectedIndex))
                'ourWindow.Run(FPS)
                'ourWindow.Dispose()
                gameRunning = False
            Else
                gameRunning = True
                trialStr = currentSong.name & "_" & CStr(CInt(perceivedSuccessRate * 100)) & "_"
                'ourWindow = New SongGame(currentSong, successRate, perceivedSuccessRate, difficulties(difficultyList.SelectedIndex))
                'ourWindow.Run(FPS)
                'ourWindow.Dispose()
                'gameRunning = False
            End If

        End If
    End Sub    
End Class