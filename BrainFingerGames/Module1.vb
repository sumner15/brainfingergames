Imports System
Imports System.Windows.Forms

Module Module1

    Public GAMEPATH As String = Application.StartupPath
    Public TARGETIP As String = "assigned inside setContextValues()"

    Public currentSub As Subject
    Public currentSong As Song
    Public trialStr As String = ""
    Public addSubjID As String
    Public currentGame As String
    Public currentDevice As String = "fingerbot"

    Public rehabHeroSets As GuitarSettings
    Public riffHeroSets As GuitarSettings
    Public useExplicitGains As Boolean = False

    Public menu As Menu

    Sub Main()
        GAMEPATH = GAMEPATH.Substring(0, GAMEPATH.LastIndexOf("\"))
        GAMEPATH = GAMEPATH.Substring(0, GAMEPATH.LastIndexOf("\") + 1)
        setContextValues()
        makeAbsentDirectories()

        rehabHeroSets = New GuitarSettings("default")
        riffHeroSets = New GuitarSettings("default")

        Application.EnableVisualStyles()
        menu = New Menu
        Application.Run(menu)
    End Sub

    ''------------------------------- make absent directories ---------------------------''
    '' HG will not track empty directories, and we don't want it to track folders full of
    '' data. As such, we need to make our data directories if they do not exist
    Sub makeAbsentDirectories()
        If (Not System.IO.Directory.Exists(GAMEPATH & "Subjects")) Then
            System.IO.Directory.CreateDirectory(GAMEPATH & "Subjects")
            Console.WriteLine("made subjects dir")
        End If

        If (Not System.IO.File.Exists(GAMEPATH & "Subjects\" & "default.txt")) Then
        End If

        If (Not System.IO.File.Exists(GAMEPATH & "Subjects\" & "allSubjects.txt")) Then
            Dim allSubjectFile As New System.IO.StreamWriter(GAMEPATH & "Subjects\" & "allSubjects.txt")
            allSubjectFile.WriteLine("default")
            allSubjectFile.Close()
        End If

    End Sub


    ''------------------------- complete context specific settup ------------------------''
    '' Setup context specific values (like the IP address of the target computer)
    Sub setContextValues()
        If My.Computer.Name = "FINGER-HOSTUCI" Then
            TARGETIP = "129.101.53.73"
        ElseIf My.Computer.Name = "HOST2" Then
            TARGETIP = "169.254.201.253" ' Wadsworth BCI setup
        Else
            TARGETIP = "129.101.53.73"
        End If
    End Sub

End Module
