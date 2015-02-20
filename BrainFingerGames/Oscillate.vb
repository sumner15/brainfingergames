''-----------------------------------------------------------------------------''
''----------------- Measure the tone in the subject's fingers -----------------''
''-----------------------------------------------------------------------------''
Imports System

Imports OpenTK
Imports OpenTK.Platform
Imports OpenTK.Graphics.OpenGL
Imports OpenTK.Input
Imports OpenTK.Graphics

Public Class Oscillate
    Inherits OpenTK.GameWindow

    Private myLights As Lights
    Private myCamera As Camera
    Private instructions As New TextSign("Relax your fingers")

    Public bci2000 As BCI2000Exchange = Nothing
    Public secondHand As FingerBot

    Private freqs As Single() = {4 6 8 10 12 14}  'frequencies to oscillate at
    Private freqDur As Single = 20000           'oscillation duration (msec)
    Private breakDur As Single = 8000           'break duration (msec)
    Private trialInd As Integer = 0             'trial index
    Private isActiveTrial As Boolean = False    'determine whether a block of data defines a break or an actual trial
    Private myAction As Stopwatch

    ''------------------------------ constructor ------------------------------''
    Public Sub New()
        myLights = New Lights({0.0F, -1.0F, 1.0F},
                             {-2.0F, 0.0F, -2.0F},
                             {0.0F, 0.0F, 0.0F})
        myCamera = New Camera({0.0F, 0.0F, 15.0F}, {0.0F, 0.0F, 0.0F})

        myAction = New Stopwatch()

        myCamera.ViewPerspective(Width, Height)
        myCamera.setViewPoint()
        initializeGL()

        myAction.Start()

        secondHand = New FingerBot()
        secondHand.setGainsExplicitly({0, 0})

        secondHand.startR()
    End Sub


#Region "graphics functions"
    '----------------------------------------------------------------------------------'
    '------------------------------ Initializes open GL -------------------------------'
    '----------------------------------------------------------------------------------'
    Public Sub initializeGL()
        GL.Hint(HintTarget.PerspectiveCorrectionHint, HintMode.Nicest)
        GL.ShadeModel(ShadingModel.Smooth)
        GL.Enable(EnableCap.DepthTest)
        GL.ClearDepth(1.0)
        GL.DepthFunc(DepthFunction.Lequal)
        GraphicsContext.CurrentContext.VSync = False ' if you don't set this to false then swapbuffers will wait for the monitor to refresh
    End Sub
#End Region

#Region "drawing events"
    '----------------------------------------------------------------------------------'
    '----------------------- drawing commands - render event --------------------------'
    '----------------------------------------------------------------------------------'
    ' put your drawing commands here
    Private Sub purdyWindow_RenderFrame(ByVal sender As Object, ByVal e As OpenTK.FrameEventArgs) Handles Me.RenderFrame

        myCamera.setViewPoint()
        GL.Clear(ClearBufferMask.ColorBufferBit Or ClearBufferMask.DepthBufferBit)

        ' put drawing commands here
        instructions.drawSign()
        instructions.scale = 6

        Me.SwapBuffers()
    End Sub

    '----------------------------------------------------------------------------------'
    '------------------------------ resize window event -------------------------------'
    '----------------------------------------------------------------------------------'
    Private Sub purdyWindow_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        GL.Viewport(0, 0, Width, Height)
        ViewPerspective()
    End Sub

    '----------------------------------------------------------------------------------'
    '--------------------- defines the perspective for our camera ---------------------'
    '----------------------------------------------------------------------------------'
    Public Sub ViewPerspective() ' Set Up A Perspective View
        GL.MatrixMode(MatrixMode.Projection) ' Select Projection
        GL.LoadIdentity()
        Dim perspective1 As Matrix4 = OpenTK.Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, _
                                             CSng((Width) / (Height)), 1, Width)
        GL.LoadMatrix(perspective1)
        GL.MatrixMode(MatrixMode.Modelview)
        GL.LoadIdentity()
        'GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.One)
    End Sub

#End Region

#Region "state machine"
    '---------------------------------------------------------------------------'
    '--------------------------- update frame event ----------------------------'
    '---------------------------------------------------------------------------'
    Private Sub purdyWindow_UpdateFrame(ByVal sender As Object, ByVal e As OpenTK.FrameEventArgs) Handles Me.UpdateFrame        

        If Mouse.Item(0) = True Then
            myCamera.pitch = Mouse.X / 1.25
            myCamera.roll = Mouse.Y / 1.25
        ElseIf Mouse.Item(1) = True Then
            'ball.pos(0) = (Mouse.X - Width / 2) / 100
            'ball.pos(1) = -(Mouse.Y - Height / 2) / 100
        End If

        secondHand.getPos()             'update state
        secondHand.getTargetTime()      'update state

        '--------------------------- GAME LOGIC ------------------------------'
        If myAction.ElapsedMilliseconds >= breakDur And Not isActiveTrial Then
            isActiveTrial = True
            Console.WriteLine("wiggle mode... ENABLE")
            myAction.Restart()
            If trialInd < freqs.Length Then
                secondHand.setFreq(freqs(trialInd))
                secondHand.setOscBool(1.0)
            Else
                'the program is over. You're done. Finito. Fin. End.
            End If
            trialInd += 1

        ElseIf myAction.ElapsedMilliseconds >= freqDur And isActiveTrial Then
            isActiveTrial = False
            Console.WriteLine("break mode... get a coffee")
            myAction.Restart()
            secondHand.setOscBool(0)
        End If
        '-------------------------------------------------------------------'

    End Sub


#End Region

#Region "other events"
    '------------------------- instructions executed on load -------------------'
    ' initialize your graphics objects here
    Private Sub purdyWindow_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        initializeGL()
        Try
            bci2000 = New BCI2000Exchange(Me)
            MsgBox("found amp")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Console.WriteLine("BCI compatible amp not found ")
            bci2000 = Nothing
        End Try
        'secondHand.startModel()
    End Sub

    ''------------------------------ unload event -----------------------------''
    Private Sub sensoryTest_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Dim testval = MsgBox("Save the collected data?", MsgBoxStyle.YesNo)
        Dim saveData As Boolean = False
        If testval = 6 Then saveData = True
        
        secondHand.stopR()
        secondHand.close()
        If Not (bci2000 Is Nothing) Then bci2000.Close()
        secondHand.stopModel()
    End Sub

    ''-------------------------- keyboard event handler -----------------------''
    Private Sub purdyWindow_KeyPress(ByVal sender As Object, ByVal e As OpenTK.KeyPressEventArgs) Handles Me.KeyPress
        'Dim hit As Boolean
        '
        Console.WriteLine(e.KeyChar)
        If (e.KeyChar = "i") Then
            MsgBox("Warning! Do not press i again. I'm serious!")        
        End If
    End Sub

#End Region

End Class
