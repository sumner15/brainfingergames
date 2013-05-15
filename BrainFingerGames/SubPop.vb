Imports System.IO
'================================================================================'
'-------------------- Population class for the Subject list ---------------------'
'================================================================================'
Public Class SubPop    
    Private subList As String = "allSubjects.txt"
    Public popSize As Integer
    Public subjects() As Subject
    Public subIds() As String

    '--------------------------------------------------------------------------------'
    '------------------------- constructor for population ---------------------------'
    '--------------------------------------------------------------------------------'
    Public Sub New()
        Dim fileReader As StreamReader
        Dim idstring As String
        'need to find out how many subjects we have
        fileReader = My.Computer.FileSystem.OpenTextFileReader(GAMEPATH & "Subjects\" & subList)
        popSize = 0
        While (Not fileReader.EndOfStream)
            idstring = fileReader.ReadLine()
            If (Not (idstring = "") And Not (idstring = " ")) Then popSize += 1
        End While

        'now we can actually read in the subject's data
        ReDim subjects(popSize - 1)
        ReDim subIds(popSize - 1)
        If popSize > 0 Then
            fileReader.Close()
            fileReader = My.Computer.FileSystem.OpenTextFileReader(GAMEPATH & "Subjects\" & subList)

            For i As Integer = 0 To (popSize - 1) Step 1
                subIds(i) = fileReader.ReadLine()
                subjects(i) = New Subject(subIds(i))
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
        My.Computer.FileSystem.WriteAllText(GAMEPATH & "Subjects\" & subList, idLine, True)

        oldSubjects = subjects
        oldSubIds = subIds
        ReDim subjects(popSize)
        ReDim subIds(popSize)

        For i = 0 To (popSize - 1) Step 1
            subjects(i) = oldSubjects(i)
            subIds(i) = oldSubIds(i)
        Next i

        popSize += 1

        subjects(popSize - 1) = subject
        subIds(popSize - 1) = subject.ID        
        subject.update()
    End Sub

    '--------------------------------------------------------------------------------'
    '---------------------- delete subject from the population ----------------------'
    '--------------------------------------------------------------------------------'
    Public Sub deleteSubject(ByRef subject As Subject)
        If (subject.ID = "Default") Then
            MsgBox("You cannot delete the Default Subject") : Return
        End If

        Dim oldSubjects() As Subject = subjects
        Dim oldSubIds() As String = subIds

        ReDim subjects(popSize - 2)
        ReDim subIds(popSize - 2)

        Dim allSubjectsFile As New System.IO.StreamWriter(GAMEPATH & "Subjects\" & "allSubjects.txt")        

        Dim j As Integer = 0
        For i = 0 To (popSize - 2) Step 1
            If Not oldSubIds(i) = subject.ID Then

                subjects(j) = oldSubjects(i)
                subIds(j) = oldSubIds(i)

                Dim currentID As String = subIds(j)
                If (i = popSize - 2) Then                    
                    allSubjectsFile.Write(currentID)
                Else
                    allSubjectsFile.WriteLine(currentID)
                End If

                j += 1
            End If
        Next i

        popSize -= 1


        
        allSubjectsFile.Close()

    End Sub
End Class
