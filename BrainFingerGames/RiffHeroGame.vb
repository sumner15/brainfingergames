'================================================================================'
'------------------------------ Rehab Hero game class ---------------------------'
'================================================================================'
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Math
Imports System.IO
Imports System.Text

Imports OpenTK
Imports OpenTK.Platform
Imports OpenTK.Graphics.OpenGL
Imports OpenTK.Input
Imports System.Runtime.InteropServices
Imports OpenTK.Graphics

Public Class RiffHeroGame
    Inherits OpenTK.GameWindow
    Public thetaY As Single = 0.0
    Public thetaX As Single = 0.0
    Public camPos() = {0, 4.5, -5}
    Public sampTex As Bitmap
    Public texture As Integer

    Private lightAmbient() As Single = {1.0F, 1.0F, 1.0F, 1.0F}
    Private lightDiffuse() As Single = {0.75F, 0.75F, 0.75F, 1.0F}
    Private lightSpecular() As Single = {0.125F, 0.125F, 0.125F, 1.0F}
    Private lightPosition() As Single = {0.0F, 5.0F, 8.0F, 1.0F}
    Private lightPosition2() As Single = {0.0F, 5.0F, 4.0F, 1.0F}
    Private lightPosition3() As Single = {0.0F, 5.0F, 0.0F, 1.0F}

    Public cloudBox As New MeshVbo(poly.QUADS)

    Public fretboard As Fretboard
    Private hitAttempted As Boolean = False
    Private noteControl As Boolean = False
    Private brainOverRide As Boolean = False

    Public secondHand As FingerBot
    Public bci2000 As BCI2000Exchange = Nothing
    Private explicitGains() As Single = {0.0, 0.0} ' only used when in explicit gain mode
    Private useExplicitGains As Boolean = False

    Private sigmaKp As Single = 0.625 '0.5
    Private sigmaKd As Single = 0.05
    Public alpha As Single = 4 '4
    Private increaseStepKp As Single = alpha * sigmaKp
    Private decreaseStepKp As Single = sigmaKp
    Private increaseStepKd As Single = alpha * sigmaKd
    Private decreaseStepKd As Single = sigmaKd

    Private posHitWindow As Single = 0.02
    Private velThreshold As Single = 0.0035
    Public hitSetResetPos As Single = 0.045
    Public fixedDur As Single = 0.5

    Private hitSet As Boolean = False
    Public hitChanged As Boolean = False
    Public hitString As Integer = 0
    Public hitTime As Single = 0
    Public hitPos As Single = 0

    Public InPosWindow As Boolean = False
    Public InTimeWindow As Boolean = False

    Private zeroPosComplete As Boolean = False
    Private startupTimer As New Stopwatch
    Private trueStartUpDelay As Single
    Private zeroingInst As New TextSign("relax for a moment")
    Private scoreText As New TextSign("this is used to show your score")

    Private scorefile As New StreamWriter(GAMEPATH & "scoreFiles\" & "score_" & currentSub.ID & "_" & String.Format("{0:yyyyMMddhhmmss}", Now) & ".txt")
    Private hitTimeFile As StreamWriter
    Private greatSuccess As Boolean = False    
    Private possibleScore As Integer = 0
    Private score As Integer = 0

    Private debugFile As New StreamWriter(GAMEPATH & "scoreFiles\" & "whatsgoingon.txt")
    Private currentNote As Integer = 0

    Private state As Integer = -1

    Public mySong As Song
    Public gameClock2 As New Stopwatch()
    Public absoluteTimer As New Stopwatch()
    Private theEnd As Boolean = False

    Private legend As New Model("legend", "legendTile", {-Width / 50 + 5, 0.5 * (Height / 50), -6.0}, {90.0, 0.0, 0.0}, 1.5 * Width / Height)
    Private topPannel As New Model("topPannel", "topPannel", {0, Height / 50, -20.0}, {0.0, 180.0, 0.0}, Width / (50 * 10))
    Private progressbar As New Model("progressBar", {0, Height / 50, -20.0}, {0.0, 180.0, 0.0}, Width / (50 * 10))

    '---------------------- graphics related objects --------------------------------
    Private finger1Ball As New FingerBall("ballg", {0.0, 0.0, 0.0}, {0.0, 0.0, 0.0}, 0.25)
    Private finger2Ball As New FingerBall("bally", {0.0, 0.0, 0.0}, {0.0, 0.0, 0.0}, 0.25)
    Private fingers1Ball As New FingerBall("ballb", {0.0, 0.0, 0.0}, {0.0, 0.0, 0.0}, 0.25)
    Private fingers2Ball As New FingerBall("ballb", {0.0, 0.0, 0.0}, {0.0, 0.0, 0.0}, 0.25)
    Private fingerScale As Single = 10

    Private backLine As New Model("cubegreen", {0.0, 0.25, 0.0}, {0.0, 0.0, 0.0}, {2.5, 0.01, 0.01})
    Private targFrontLine As New Model("cube", {0.0, 0.25, 0.0}, {0.0, 0.0, 0.0}, {2.5, 0.01, 0.01})
    Private targBackLine As New Model("cube", {0.0, 0.25, 0.0}, {0.0, 0.0, 0.0}, {2.5, 0.01, 0.01})

#Region "constructors"
    '----------------------------------------------------------------------------------'
    '-------------------------------- the constructor ---------------------------------'
    '----------------------------------------------------------------------------------'
    Public Sub New()
        secondHand = New FingerBot()
        mySong = New Song(GAMEPATH & "songs\happy together\")
        mySong.createAudioPlayer()
        fretboard = New Fretboard(mySong, level.superEasy)
        cloudBox.readWavefront("cloudSphere.obj")

        initializeGL()

        cloudBox.loadVbo()
        cloudBox.loadTexture("clouds2.bmp")
        debugFile.WriteLine("status" & vbTab & "desirednote" & vbTab & "kp1" & vbTab & "kd1" & vbTab & "kp2" & vbTab & "kv2")

    End Sub

    '----------------------------------------------------------------------------------'
    '---------------------------- alternate constructor -------------------------------'
    '----------------------------------------------------------------------------------'    
    Public Sub New(ByRef currentSong As Song, ByVal successRate As Single, ByVal difficulty As Integer)
        secondHand = New FingerBot()
        updateGainStep(successRate)

        mySong = currentSong
        mySong.createAudioPlayer()
        fretboard = New Fretboard(mySong, difficulty)
        cloudBox.readWavefront("cloudSphere.obj")

        initializeGL()

        cloudBox.loadVbo()
        cloudBox.loadTexture("clouds2.bmp")
    End Sub

    '----------------------------------------------------------------------------------'
    '------------------ alternate constructor - set gains explicitly ------------------'
    '----------------------------------------------------------------------------------'    
    Public Sub New(ByRef currentSong As Song, ByVal successRate As Single, ByVal propGains As Single(), ByVal difficulty As Integer)
        secondHand = New FingerBot()

        useExplicitGains = True
        explicitGains = propGains

        mySong = currentSong
        mySong.createAudioPlayer()
        fretboard = New Fretboard(mySong, difficulty)

        cloudBox.readWavefront("cloudSphere.obj")

        initializeGL()

        cloudBox.loadVbo()
        cloudBox.loadTexture("clouds2.bmp")
    End Sub

#End Region

#Region "graphics functions"
    '----------------------------------------------------------------------------------'
    '--------------------- defines the perspective for our camera ---------------------'
    '----------------------------------------------------------------------------------'
    Public Sub ViewPerspective() ' Set Up A Perspective View
        GL.MatrixMode(MatrixMode.Projection) ' Select Projection
        GL.LoadIdentity()
        Dim perspective1 As Matrix4 = OpenTK.Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, _
                                             CSng((Width) / (Height)), 1, 640)
        GL.LoadMatrix(perspective1)
        GL.MatrixMode(MatrixMode.Modelview)
        GL.LoadIdentity()
        'GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.One)
    End Sub

    '----------------------------------------------------------------------------------'
    '-------------- defines the Orthographic perspective for our camera ---------------'
    '----------------------------------------------------------------------------------'
    Public Sub ViewOrtho() ' Set Up A Perspective View

        GL.MatrixMode(MatrixMode.Projection) ' Select Projection
        GL.LoadIdentity()

        GL.Ortho(-Width / 50, Width / 50, -Height / 50, Height / 50, 1, 50)

        GL.MatrixMode(MatrixMode.Modelview)
        GL.LoadIdentity()
    End Sub

    '----------------------------------------------------------------------------------'
    '-------------------- controls the orientation of the camera ----------------------'
    '----------------------------------------------------------------------------------'
    Public Sub setViewPoint()
        GL.MatrixMode(MatrixMode.Modelview)
        GL.LoadIdentity()

        Dim view_ = OpenTK.Matrix4.LookAt(camPos(0), camPos(1), camPos(2), 0, 0, -4, 0, 1, 0) ' Lookat(camPos,targetPos,upVector)

        GL.MatrixMode(MatrixMode.Modelview)
        GL.LoadMatrix(view_)
        GL.Rotate(thetaY, 0.0, 1.0, 0.0)
        GL.Rotate(thetaX, 1.0, 0.0, 0.0)

    End Sub

    '----------------------------------------------------------------------------------'
    '------------------------------ Initializes open GL -------------------------------'
    '----------------------------------------------------------------------------------'
    Public Sub initializeGL()

        GL.Hint(HintTarget.PerspectiveCorrectionHint, HintMode.Nicest)
        GL.ShadeModel(ShadingModel.Smooth)
        GL.Enable(EnableCap.DepthTest)
        GL.ClearDepth(1.0)
        GL.DepthFunc(DepthFunction.Lequal)

        'GL.ClearColor(Color.MidnightBlue)

        GL.Enable(EnableCap.Texture2D)

        GL.Light(LightName.Light0, LightParameter.Ambient, lightAmbient)
        GL.Light(LightName.Light0, LightParameter.Diffuse, lightDiffuse)
        GL.Light(LightName.Light0, LightParameter.Specular, lightSpecular)
        GL.Light(LightName.Light0, LightParameter.Position, lightPosition)

        GL.Light(LightName.Light1, LightParameter.Ambient, lightAmbient)
        GL.Light(LightName.Light1, LightParameter.Diffuse, lightDiffuse)
        GL.Light(LightName.Light1, LightParameter.Specular, lightSpecular)
        GL.Light(LightName.Light1, LightParameter.Position, lightPosition2)

        GL.Light(LightName.Light2, LightParameter.Ambient, lightAmbient)
        GL.Light(LightName.Light2, LightParameter.Diffuse, lightDiffuse)
        GL.Light(LightName.Light2, LightParameter.Specular, lightSpecular)
        GL.Light(LightName.Light2, LightParameter.Position, lightPosition2)

        GL.Enable(EnableCap.Lighting)
        GL.Enable(EnableCap.Light0)
        GL.Enable(EnableCap.Light1)
        GL.Enable(EnableCap.Light2)

        'GL.Enable(EnableCap.Blend)
        GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.One)
        setViewPoint()
        GraphicsContext.CurrentContext.VSync = False ' if you don't set this to false then swapbuffers will wait for the monitor to refresh
    End Sub
#End Region

#Region "gameflow related functions"

    '----------------------------------------------------------------------------------'
    '-------------------------------- check tapper hit --------------------------------'
    '----------------------------------------------------------------------------------'
    ' this checks to see if tapper has moved into a hit window at the correct time    
    Private Sub checkHit()        
        checkFingerHit(fretboard)

        ' check if it was on time
        If hitChanged And InTimeWindow Then
            greatSuccess = True
        End If

        If hitChanged Then
            If Not hitAttempted Then
                hitAttempted = True
                'Console.WriteLine("hit Attempted")
            End If
        End If

    End Sub

    '----------------------------------------------------------------------------------'
    '------------------------------ check brain states --------------------------------'
    '----------------------------------------------------------------------------------'
    ' this checks to see if the user is creating the proper brain states to bring notes onto the screen
    Private Sub checkBrain()
        'Write in brain logic here! tag: wadsworth
        'if brain state = event related desynchronization
        '   noteControl = True
        'end if
        If brainOverRide Then
            noteControl = True
            brainOverRide = False 'reset
        End If
    End Sub

    '----------------------------------------------------------------------------------'
    '------------------------------ update current note -------------------------------'
    '----------------------------------------------------------------------------------'
    ' this function checks if we have gone past the current note. If so, it sets the 
    ' next note as the current note and calculates the movements times for tapper.
    Private Sub updateCurrentNote()

        Dim success As Boolean = greatSuccess

        If (secondHand.targetTime > (fretboard.nextNoteTime + fixedDur * 1000 + 75) And (Not fretboard.songOver)) Then
            Dim previousNote As Single
            previousNote = fretboard.nextNotePos
            ' check if they attempted the hit and increases the gain if they didn't 
            If Not useExplicitGains Then
                Select Case previousNote
                    Case positions(0)
                        If Not hitAttempted Then secondHand.incrementGains(increaseStepKp, 0)
                        Exit Select
                    Case positions(1)
                        If Not hitAttempted Then
                            secondHand.incrementGains(increaseStepKp, increaseStepKp)
                        End If
                        Exit Select
                    Case positions(2)
                        If Not hitAttempted Then secondHand.incrementGains(0, increaseStepKp)
                        Exit Select
                End Select
            End If

            scorefile.WriteLine(fretboard.nextNotePos & vbTab & fretboard.nextNoteTime & vbTab & success & vbTab)
            If success And noteControl Then
                possibleScore += 1 : score += 1 : setProgrssBar(score / possibleScore)
            ElseIf noteControl Then
                possibleScore += 1 : setProgrssBar(score / possibleScore)
            End If

            currentNote += 1

            greatSuccess = False ' just resetting it            
            hitAttempted = False
            noteControl = False
            secondHand.moveFingersToCurrent()
            fretboard.getNextNote(secondHand.targetTime) 'FIXME

            Select Case (fretboard.nextNotePos)
                Case positions(0)
                    secondHand.moveFinger1((fretboard.nextNoteTime + trueStartUpDelay) / 1000)
                    Exit Select
                Case positions(1)
                    secondHand.moveFingers((fretboard.nextNoteTime + trueStartUpDelay) / 1000)
                    Exit Select
                Case positions(2)
                    secondHand.moveFinger2((fretboard.nextNoteTime + trueStartUpDelay) / 1000)
                    Exit Select
            End Select

        End If
    End Sub

    '--------------------------------------------------------------------------------'
    '-------------------------- check for a hit by finger  --------------------------'
    '--------------------------------------------------------------------------------'
    Public Sub checkFingerHit(ByRef fretBoard As Fretboard)
        Dim comboHitThresh As Single = 0.04

        If (secondHand.velF1 < velThreshold) And (secondHand.posF1 > hitSetResetPos) And Not hitSet Then
            hitChanged = True
            hitSet = True
            hitPos = secondHand.posF1
            hitTime = secondHand.targetTime

            ' is it a combo hit?
            If Abs(secondHand.posF1 - secondHand.posF2) < comboHitThresh Then  ' combo hit condition
                hitString = 1
            Else : hitString = 0 : End If

            InTimeWindow = fretBoard.checkHit(hitTime, hitString)
            hitTimeFile.WriteLine(fretBoard.nextNotePos & vbTab & fretBoard.nextNoteTime & vbTab & hitString & vbTab & hitTime)

            If Abs(hitPos - secondHand.destination) < posHitWindow Then
                InPosWindow = True
            Else : InPosWindow = False : End If

            If (InTimeWindow And InPosWindow) Then : fretBoard.triggerFlame(hitString) : End If

        ElseIf (secondHand.velF2 < velThreshold) And (secondHand.posF2 > hitSetResetPos) And Not hitSet Then
            hitChanged = True
            hitSet = True
            hitPos = secondHand.posF2
            hitTime = secondHand.targetTime

            ' is it a combo hit?
            If Abs(secondHand.posF1 - secondHand.posF2) < comboHitThresh Then  ' combo hit condition
                hitString = 1
            Else : hitString = 2 : End If

            InTimeWindow = fretBoard.checkHit(hitTime, hitString)
            hitTimeFile.WriteLine(fretBoard.nextNotePos & vbTab & fretBoard.nextNoteTime & vbTab & hitString & vbTab & hitTime)

            If Abs(hitPos - secondHand.destination) < posHitWindow Then
                InPosWindow = True
                'Console.WriteLine("hit attempt on string " & hitString & " in window")
            Else
                InPosWindow = False
                'Console.WriteLine("hit attempt on string " & hitString & " NOT in window")
            End If

            'Console.WriteLine("hit attempt on string " & hitString & " on time?" & " " & InTimeWindow & vbTab & "In target?" & " " & InPosWindow)

            If (InTimeWindow And InPosWindow) Then : fretBoard.triggerFlame(hitString) : End If

        Else : hitChanged = False : End If

        If (secondHand.posF1 <= hitSetResetPos) And (secondHand.posF2 <= hitSetResetPos) Then
            'If hitSet Then Console.WriteLine("hitSet flag reset")
            hitSet = False
            InPosWindow = False
            InTimeWindow = False
        End If
    End Sub

#End Region

#Region "purdyWindow's events"
    '----------------------------------------------------------------------------------'
    '------------------------------ keyboard event handler ----------------------------'
    '----------------------------------------------------------------------------------'
    Private Sub purdyWindow_KeyPress(ByVal sender As Object, ByVal e As OpenTK.KeyPressEventArgs) Handles Me.KeyPress
        'Dim hit As Boolean
        Dim key As Integer = 0
        If (e.KeyChar = "1" Or e.KeyChar = "2" Or e.KeyChar = "3" Or e.KeyChar = "4" Or e.KeyChar = "5") Then
            key = AscW(e.KeyChar) - 49
            fretboard.checkHit(secondHand.targetTime, key)
        ElseIf (e.KeyChar = "g") Then
            secondHand.moveFingersToCurrent()
        ElseIf (e.KeyChar = "i") Then
            scoreText.visable = Not scoreText.visable
        ElseIf (e.KeyChar = "s") Then
            secondHand.setForceOnOff()
            'Console.WriteLine("forcves toggled")
        ElseIf (AscW(e.KeyChar) = 27) Then
            Me.Exit()
        ElseIf (e.KeyChar = "b") Then 'bci override
            brainOverRide = True
        End If
    End Sub

    '----------------------------------------------------------------------------------'
    '---------------------------- instructions executed on load -----------------------'
    '----------------------------------------------------------------------------------'
    Private Sub purdyWindow_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        secondHand.startR()
        startupTimer.Start()
        absoluteTimer.Start()

        scorefile.WriteLine("stringNum" & vbTab & "noteStime" & vbTab & "TrueSuccess" & vbTab & "perceivedSuccess")
        hitTimeFile = New StreamWriter(GAMEPATH & "hitTimeFiles\" & "hittimes_" & currentSub.ID & String.Format("{0:yyyyMMddhhmmss}", Now) & ".txt")
        hitTimeFile.WriteLine("desiredNote" & vbTab & "desiredTime" & vbTab & "actualNote" & vbTab & "actualTime")

        secondHand.initializeGains()

        Select Case (fretboard.nextNotePos)
            Case positions(0)
                secondHand.moveFinger1((fretboard.nextNoteTime + trueStartUpDelay) / 1000)
                Exit Select
            Case positions(1)
                secondHand.moveFingers((fretboard.nextNoteTime + trueStartUpDelay) / 1000)
                Exit Select
            Case positions(2)
                secondHand.moveFinger2((fretboard.nextNoteTime + trueStartUpDelay) / 1000)
                Exit Select
        End Select

        If riffHeroSets.get_useBCI Then
            bci2000 = New BCI2000Exchange(Me)
        End If
    End Sub
    '----------------------------------------------------------------------------------'
    '----------------------- drawing commands - render event --------------------------'
    '----------------------------------------------------------------------------------'
    Private Sub purdyWindow_RenderFrame(ByVal sender As Object, ByVal e As OpenTK.FrameEventArgs) Handles Me.RenderFrame

        ViewPerspective()
        setViewPoint()
        GL.Clear(ClearBufferMask.ColorBufferBit Or ClearBufferMask.DepthBufferBit)

        GL.Enable(EnableCap.Texture2D)

        GL.PushMatrix()
        GL.Rotate(90, 0.0, 1.0, 0.0)
        GL.Translate(5.0, 0.0, -8.0)
        GL.BindTexture(TextureTarget.Texture2D, cloudBox.textureID)
        cloudBox.drawVbo()
        GL.PopMatrix()

        fretboard.draw(secondHand.targetTime, noteControl)
        drawModels()

        If Not zeroPosComplete Then zeroingInst.drawSign()
        If theEnd Then scoreText.drawSign()

        'now for the orthographic stuff
        ViewOrtho()
        legend.drawModel()
        topPannel.drawModel()
        progressbar.drawModel()

        Me.SwapBuffers()

    End Sub

    '----------------------------------------------------------------------------------'
    '------------------------------ resize window event -------------------------------'
    '----------------------------------------------------------------------------------'
    Private Sub purdyWindow_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        GL.Viewport(0, 0, Width, Height)
        ViewPerspective()

        ' need to reposition all of the orthographic objects
        topPannel.pos = {0.0, Height / 50, -30.0}
        topPannel.scale = {Width / (50 * 10), Width / (50 * 10), Width / (50 * 10)}
        legend.pos = {-Width / 50 + 3, 0.4 * (Height / 50), -30.0}
        legend.scale = {2 * Width / Height, 2 * Width / Height, 2 * Width / Height}
        progressbar.pos = {-0.975 * (Width / 50), (Height / 50) - 1.45 * (Width / 500), -30.0}
        progressbar.scale = {0.5 * Width / (50), Width / (500 * 3), Width / (50 * 10)}
        setProgrssBar(score / possibleScore)

        ' now we need to move the lights
        lightPosition = {0.0F, 0.0F, 4.0F, 1.0F}
        lightPosition2 = {Width / 50, Height / 100, 4.0F, 1.0F}
        lightPosition3 = {-Width / 50, Height / 100, 4.0F, 1.0F}

        GL.Light(LightName.Light0, LightParameter.Position, lightPosition)
        GL.Light(LightName.Light1, LightParameter.Position, lightPosition2)
        GL.Light(LightName.Light2, LightParameter.Position, lightPosition3)
    End Sub

    '----------------------------------------------------------------------------------'
    '------------------------------ update frame event --------------------------------'
    '----------------------------------------------------------------------------------'
    Private Sub purdyWindow_UpdateFrame(ByVal sender As Object, ByVal e As OpenTK.FrameEventArgs) Handles Me.UpdateFrame
        ' you can put your state code ( or anything else of a similar nature) here
        If Mouse.Item(0) = True Then
            thetaY = Mouse.X / 1.25
            thetaX = Mouse.Y / 1.25
        End If
        camPos(2) = Mouse.Wheel + 4

        secondHand.getPos()
        secondHand.getTargetTime()
        moveFingerBalls()
        If Not (bci2000 Is Nothing) Then bci2000.Update(Me)

        gameStates()

    End Sub

    '----------------------------------------------------------------------------------'
    '----------------------------- Here's my state machine ----------------------------'
    '----------------------------------------------------------------------------------'
    Private Sub gameStates()

        If Not zeroPosComplete Then ' check if we are currently zeroing the robot                                
            If startupTimer.ElapsedMilliseconds > 5000 Then
                secondHand.toreGame()
                startupTimer.Stop()
                'mySong.player.Play()
                mySong.player.Paused = False
                trueStartUpDelay = startupTimer.ElapsedMilliseconds
                zeroPosComplete = True
                If useExplicitGains Then
                    secondHand.setGainsExplicitly(explicitGains)
                End If
            End If
            Return
        End If

        If (mySong.player.Finished) And Not theEnd Then
            theEnd = True
            scoreText = New TextSign("you scored " & CStr(score) & " out of " & CStr(possibleScore))
        End If

        checkHit()
        checkBrain()
        updateCurrentNote()        

    End Sub

    '----------------------------------------------------------------------------------'
    '------------------------- unloading game window event ----------------------------'
    '----------------------------------------------------------------------------------'
    Private Sub purdyWindow_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        GL.DeleteTextures(TextureTarget.Texture2D, cloudBox.textureID)
        cloudBox.freeBuffers()

        scorefile.Close()

        fretboard.freeMemory()
        secondHand.stopR()
        secondHand.close()
        If zeroPosComplete Then
            mySong.player.Stop()
        End If

        mySong.player.Dispose()

        debugFile.Close()
        If Not (bci2000 Is Nothing) Then bci2000.Close()
    End Sub

#End Region

#Region "drawing commands"
    Public Sub drawModels()
        finger1Ball.drawModel()
        finger2Ball.drawModel()

        fingers1Ball.drawModel()
        fingers2Ball.drawModel()

        backLine.drawModel()
        'targFrontLine.drawModel()
        'targBackLine.drawModel()
    End Sub

    Public Sub moveFingerBalls()
        ' move the fingerballs
        Dim pf1 As Single
        Dim pf2 As Single

        pf1 = secondHand.posF1
        pf2 = secondHand.posF2

        finger1Ball.pos(0) = positions(0)
        finger1Ball.pos(1) = 0.25
        finger1Ball.pos(2) = -(secondHand.destination * fingerScale - pf1 * fingerScale)

        finger2Ball.pos(0) = positions(2)
        finger2Ball.pos(1) = 0.25
        finger2Ball.pos(2) = -(secondHand.destination * fingerScale - pf2 * fingerScale)

        fingers1Ball.pos(0) = positions(1) + 0.1
        fingers1Ball.pos(1) = 0.25
        fingers1Ball.pos(2) = -(secondHand.destination * fingerScale - pf1 * fingerScale)

        fingers2Ball.pos(0) = positions(1) - 0.1
        fingers2Ball.pos(1) = 0.25
        fingers2Ball.pos(2) = -(secondHand.destination * fingerScale - pf2 * fingerScale)

        If hitSet Then
            finger1Ball.RedMode = True
            finger2Ball.RedMode = True
            fingers1Ball.RedMode = True
            fingers2Ball.RedMode = True
        Else
            finger1Ball.RedMode = False
            finger2Ball.RedMode = False
            fingers1Ball.RedMode = False
            fingers2Ball.RedMode = False
        End If

    End Sub

#End Region

#Region "other functions"

    '----------------------------------------------------------------------------------'
    '----------- create random permutation by just shuffling the data------------------'
    '----------------------------------------------------------------------------------'
    Private Sub shuffler(ByRef seq() As Boolean)
        ' pick two values and switch them
        Dim ind1 As Integer
        Dim ind2 As Integer
        Dim myRand As New Random()
        Dim maxVal As Integer = seq.Length - 1 - 4 ' we don't want the last 4 to be blocked trials - just to make sure that all the blocked trals are asctually completed.
        Dim storage As Single
        For i As Integer = 0 To 1000
            ind1 = Floor(myRand.Next(0, maxVal))
            ind2 = Floor(myRand.Next(0, maxVal))

            storage = seq(ind1)
            seq(ind1) = seq(ind2)
            seq(ind2) = storage

        Next
    End Sub

    '----------------------------------------------------------------------------------'
    '------------------- set the scaling factor of the progress bar -------------------'
    '----------------------------------------------------------------------------------'
    Private Sub setProgrssBar(ByVal successRate As Single)
        ' success rate should be between 0 and 1
        progressbar.scale(0) = successRate * Width / (50)
    End Sub

    '--------------------------------------------------------------------------------'
    '----------------------------- update gain steps --------------------------------'
    '--------------------------------------------------------------------------------'
    Public Sub updateGainStep(ByVal successRate As Single)
        alpha = successRate / (1 - successRate)

        increaseStepKp = alpha * sigmaKp
        decreaseStepKp = sigmaKp
        increaseStepKd = alpha * sigmaKd
        decreaseStepKd = sigmaKd
        'MsgBox("increase step " & CStr(increaseStepKp))
    End Sub

#End Region

End Class
