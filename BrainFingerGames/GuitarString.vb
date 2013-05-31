﻿'----------------------------------------------------------------------------------'
'------------------------------ guitar string class -------------------------------'
'----------------------------------------------------------------------------------'
' this class describes  a guitar string. it is responsible for drawing the notes 
' for the string at the correct time and registering and recording hits.
Imports System.Math
Imports OpenTK
Imports OpenTK.Platform
Imports OpenTK.Graphics.OpenGL

Public Class GuitarString
    Public noteTimes() As Double
    Public hitTimes(0, 1) As Double  ' first column indicates whether or not the note was hit, the second column gives the time at which it was hit
    Public nextNote As Integer = 0
    Public farNote As Integer
    Public previousNote As Integer = 0
    Private hitLast As Boolean = False
    Private winSizeU As Double = 18    ' how far away the object is when it appears
    Public xPos As Double

    Private winSizeS As Double ' how early the object appears in miliseconds 
    Private hitWin As Double ' range in which hits are counted as sucessful 

    Public Note As New MeshVbo(poly.TRIS)

#Region "constructorz"
    Public Sub New()
        getGameSettings()
        noteTimes = {5000, 10000, 15000, 20000, 22500, 25000, 17500, 30000}
        ReDim hitTimes(noteTimes.Length - 1, 1)
        xPos = 1.45
        Note.readWavefront("note3.obj")
        Note.loadTexture("note1.bmp")
        Note.loadVbo()
    End Sub

    Public Sub New(ByRef noteT() As Double)
        getGameSettings()
        noteTimes = noteT
        ReDim hitTimes(noteTimes.Length - 1, 1)
        xPos = 1.45
        Note.readWavefront("note3.obj")
        Note.loadTexture("note1.bmp")
        Note.loadVbo()
    End Sub

    Public Sub New(ByVal noteT() As Double, ByVal strNum As Integer)
        getGameSettings()
        noteTimes = noteT
        ReDim hitTimes(noteTimes.Length - 1, 1)
        If (strNum < 5) Then
            xPos = positions(strNum)
        Else
            Console.Write("invalid string number: " & strNum & vbNewLine)
            'ourWindow.Exit()
        End If
        Note.readWavefront("note3.obj")
        Select Case strNum
            Case 0 : Note.loadTexture("note1.bmp") : Exit Select
            Case 1 : Note.loadTexture("note2.bmp") : Exit Select
            Case 2 : Note.loadTexture("note3.bmp") : Exit Select
            Case 3 : Note.loadTexture("note4.bmp") : Exit Select
            Case 4 : Note.loadTexture("note5.bmp") : Exit Select
        End Select

        Note.loadVbo()
    End Sub
#End Region

    Public Sub freeMemory()
        Note.freeBuffers()
        GL.DeleteTextures(TextureTarget.Texture2D, Note.textureID)
    End Sub

    '----------------------------------------------------------------------------------'
    '-------------------------- get game specific settings ----------------------------'
    '----------------------------------------------------------------------------------'
    Public Sub getGameSettings()
        Select Case currentGame
            Case "Rehab_Hero"
                winSizeS = rehabHeroSets.get_allowedReactionTime ' how early the object appears in miliseconds (5000 originally)    
                hitWin = rehabHeroSets.get_hitWindowSize ' range in which hits are counted as sucessful (500 originally)
            Case "Riff_Hero"
                winSizeS = riffHeroSets.get_allowedReactionTime ' how early the object appears in miliseconds (5000 originally)    
                hitWin = riffHeroSets.get_hitWindowSize ' range in which hits are counted as sucessful (500 originally)
            Case Else : MsgBox("No game selected") : End Select
    End Sub


    '----------------------------------------------------------------------------------'
    '------------------------------ draw upcoming notes -------------------------------'
    '----------------------------------------------------------------------------------'
    Public Sub drawNotes(ByVal gameTime As Double, ByVal noteControl As Boolean)        
        Dim farNote As Integer
        Dim riffLength = riffHeroSets.get_maxNumberNotesPerBurst
        Dim reactionTime = riffHeroSets.get_allowedReactionTime

        Select Case currentGame
            Case "Rehab_Hero"
                For i = nextNote To (noteTimes.Length - 1) Step 1
                    If ((noteTimes(i) - gameTime) > reactionTime) Then
                        farNote = i - 1
                        Exit For
                    Else
                        farNote = noteTimes.Length - 1
                    End If
                Next i
                'Console.WriteLine("Rehab_Hero ::::  nextNote: " & nextNote & "   farNote: " & farNote)
            Case "Riff_Hero"                
                If nextNote + riffLength < noteTimes.Length - 1 Then
                    farNote = nextNote  '+ riffLength  - 1
                Else
                    farNote = noteTimes.Length - 1
                End If
                'Console.WriteLine("Riff_Hero ::::  nextNote: " & nextNote & "   farNote: " & farNote)
        End Select

        Dim showNotes(farNote - nextNote) As Integer
        Dim notePos As Double

        If noteControl Then
            'now we can actually draw the upcoming notes
            GL.Enable(EnableCap.Texture2D)
            GL.BindTexture(TextureTarget.Texture2D, Note.textureID)
            For i = nextNote To farNote Step 1
                notePos = (noteTimes(i) - gameTime) * winSizeU / winSizeS
                GL.PushMatrix()
                GL.Translate(xPos, 0.125, -notePos)
                Note.drawVbo()
                GL.PopMatrix()
                ' we want to draw the previous note if it was missed, but not if it was hit.
                If Not hitLast Then
                    notePos = (noteTimes(previousNote) - gameTime) * winSizeU / winSizeS
                    GL.PushMatrix()
                    GL.Translate(xPos, 0.125, -notePos)
                    Note.drawVbo()
                    GL.PopMatrix()
                End If
            Next i
        End If

        ' advance next note and previous note
        If (noteTimes(nextNote) - gameTime < -(hitWin / 2)) And ((nextNote + 1) < (noteTimes.Length)) Then
            previousNote = nextNote
            nextNote = nextNote + 1
        End If

    End Sub

    '----------------------------------------------------------------------------------'
    '--------------------------------- check for hit ----------------------------------'
    '----------------------------------------------------------------------------------'
    Public Function checkHit(ByVal gameTime As Double) As Boolean
        If Abs(noteTimes(nextNote) - gameTime) < hitWin / 2 Then
            hitTimes(nextNote, 0) = 1.0
            hitTimes(nextNote, 1) = noteTimes(nextNote) - gameTime
            hitLast = True
            Return True
        Else
            hitTimes(nextNote, 0) = 0.0
            hitTimes(nextNote, 1) = noteTimes(nextNote) - gameTime
            hitLast = False
            Return False
        End If
    End Function

    '----------------------------------------------------------------------------------'
    '-------------------------- get the time of the next note -------------------------'
    '----------------------------------------------------------------------------------'
    Public Function getNextNoteTime() As Single
        Return noteTimes(nextNote)
    End Function

    '----------------------------------------------------------------------------------'
    '---------------------- check if we have passed the last note ---------------------'
    '----------------------------------------------------------------------------------'
    ' check if we have pass the last note in this array. If so, return true
    Public Function checkIfLast() As Boolean
        If (nextNote + 1) < (noteTimes.Length) Then
            Return False
        Else
            Return True
        End If
    End Function

End Class
