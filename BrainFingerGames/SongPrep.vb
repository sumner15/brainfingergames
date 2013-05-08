Public Class SongPrep
    Private library As Library
    Dim gameSets As GuitarSettings
    Private gameRunning As Boolean
    Public ourWindowRehab As RehabHeroGame
    Public ourWindowRiff As RiffHeroGame

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
        Dim difficulties() As Integer = {level.superEasy, level.easy, level.medium}
        If difficultyList.SelectedIndex = -1 Then MsgBox("choose a difficulty level") : Return


        If Not gameRunning Then
            If useExplicitGains Then
                Dim propGains() As Single = {gameSets.get_gains, gameSets.get_gains}
                gameRunning = True
                trialStr = currentSong.name & "_" & "_"
                Select Case currentGame
                    Case "Rehab_Hero"
                        ourWindowRehab = New RehabHeroGame(currentSong, successRate, propGains, difficulties(difficultyList.SelectedIndex))
                        ourWindowRehab.Run(FPS)
                        ourWindowRehab.Dispose()                        
                    Case "Riff_Hero"
                        ourWindowRiff = New RiffHeroGame(currentSong, successRate, propGains, difficulties(difficultyList.SelectedIndex))
                        ourWindowRiff.Run()
                        ourWindowRiff.Dispose()
                End Select                
                gameRunning = False
            Else
                gameRunning = True
                trialStr = currentSong.name & "_" & "_"
                Select Case currentGame
                    Case "Rehab_Hero"
                        ourWindowRehab = New RehabHeroGame(currentSong, successRate, difficulties(difficultyList.SelectedIndex))
                        ourWindowRehab.Run(FPS)
                        ourWindowRehab.Dispose()
                    Case "Riff_Hero"
                        ourWindowRiff = New RiffHeroGame(currentSong, successRate, difficulties(difficultyList.SelectedIndex))
                        ourWindowRiff.Run()
                        ourWindowRiff.Dispose()
                End Select
                gameRunning = False
            End If

        End If
    End Sub    
End Class
