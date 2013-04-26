Imports System.IO
'================================================================================'
'---------------------- Population class for the Game list ---------------------'
'================================================================================'

Public Class GamePop
    Private gameList As String = "gameList.txt"
    Public popSize As Integer
    Public games() As game
    Public gameIds() As String

    '--------------------------------------------------------------------------------'
    '------------------------- constructor for population ---------------------------'
    '--------------------------------------------------------------------------------'
    Public Sub New()
        Dim fileReader As StreamReader
        Dim idstring As String
        'need to find out how many games we have
        fileReader = My.Computer.FileSystem.OpenTextFileReader(GAMEPATH & "Games\" & gameList)
        popSize = 0
        While (Not fileReader.EndOfStream)
            idstring = fileReader.ReadLine()
            If (Not (idstring = "") And Not (idstring = " ")) Then popSize += 1
        End While

        'now we can actually read in the subject's data
        ReDim subjects(popSize - 1)
        ReDim gameIds(popSize - 1)
        If popSize > 0 Then
            fileReader.Close()
            fileReader = My.Computer.FileSystem.OpenTextFileReader(GAMEPATH & "Games\" & gameList)

            For i As Integer = 0 To (popSize - 1) Step 1
                gameIds(i) = ""
                While gameIds(i) = "" Or gameIds(i) = " "
                    gameIds(i) = fileReader.ReadLine()
                End While
                subjects(i) = New Subject(gameIds(i))
            Next i

            fileReader.Close()
        End If

    End Sub

    '--------------------------------------------------------------------------------'
    '------------------------- add subject to the population ------------------------'
    '--------------------------------------------------------------------------------'
    Public Sub addSubject(ByRef subject As Subject)
        Dim idLine = vbNewLine & subject.ID
        Dim oldSubjects() As Subject
        Dim oldSubIds() As String
        My.Computer.FileSystem.WriteAllText(GAMEPATH & "Subjects\" & gameList, idLine, True)

        oldSubjects = subjects
        oldSubIds = gameIds
        ReDim subjects(popSize)
        ReDim gameIds(popSize)

        For i = 0 To (popSize - 1) Step 1
            subjects(i) = oldSubjects(i)
            gameIds(i) = oldSubIds(i)
        Next i

        popSize += 1

        subjects(popSize - 1) = subject
        gameIds(popSize - 1) = subject.ID
        subject.update()
    End Sub

End Class
