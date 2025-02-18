﻿Imports System
Imports System.Windows.Forms

Module Module1

    Public GAMEPATH As String = Application.StartupPath
    Public positions() As Double = {2.25, 1.15, 0.0, -1.15, -2.25}
    Public FPS As Double = 200
    Public TARGETIP As String = "assigned inside setContextValues()"

    Public currentSub As Subject
    Public currentSong As Song
    Public trialStr As String = ""
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
        'subjects
        If (Not System.IO.Directory.Exists(GAMEPATH & "Subjects")) Then
            System.IO.Directory.CreateDirectory(GAMEPATH & "Subjects")
            Console.WriteLine("made subjects dir")
        End If
        If (Not System.IO.File.Exists(GAMEPATH & "Subjects\" & "allSubjects.txt")) Then
            Dim allSubjectsFile As New System.IO.StreamWriter(GAMEPATH & "Subjects\" & "allSubjects.txt")
            allSubjectsFile.WriteLine("default")
            allSubjectsFile.Close()
        End If
        'studies (saved settings)
        If (Not System.IO.Directory.Exists(GAMEPATH & "Studies")) Then
            System.IO.Directory.CreateDirectory(GAMEPATH & "Studies")
            Console.WriteLine("made studies dir")
        End If
        If (Not System.IO.File.Exists(GAMEPATH & "Studies\" & "allStudies.txt")) Then
            Dim allStudiesFile As New System.IO.StreamWriter(GAMEPATH & "Studies\" & "allStudies.txt")
            allStudiesFile.WriteLine("default")
            allStudiesFile.Close()
        End If

    End Sub


    ''------------------------- complete context specific setup ------------------------''
    '' Setup context specific values (like the IP address of the target computer)
    Sub setContextValues()
        If My.Computer.Name = "FINGER-HOSTUCI" Then
            TARGETIP = "129.101.53.73"
        ElseIf My.Computer.Name = "HOST2" Then
            TARGETIP = "169.254.201.253" ' New York BCI setup
        Else
            TARGETIP = "129.101.53.73"
        End If
    End Sub

End Module
