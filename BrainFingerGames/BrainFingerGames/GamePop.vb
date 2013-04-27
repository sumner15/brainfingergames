Imports System.IO
'================================================================================'
'---------------------- Population class for the Game list ---------------------'
'================================================================================'

Public Class GamePop
    Private gameList As String = "gameList.txt"
    Public popSize As Integer    
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

        'now we can actually read in the game's data        
        ReDim gameIds(popSize - 1)
        If popSize > 0 Then
            fileReader.Close()
            fileReader = My.Computer.FileSystem.OpenTextFileReader(GAMEPATH & "Games\" & gameList)

            For i As Integer = 0 To (popSize - 1) Step 1
                gameIds(i) = ""
                While gameIds(i) = "" Or gameIds(i) = " "
                    gameIds(i) = fileReader.ReadLine()
                End While                
            Next i

            fileReader.Close()
        End If

    End Sub


End Class
