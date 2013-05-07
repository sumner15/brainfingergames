'----------------------------------------------------------------------------------'
'---------------------------------- Robot class -----------------------------------'
'----------------------------------------------------------------------------------'
' this class deals with all communications between the tapperrobot and the VB game

Imports XPCAPICOMLib
Imports GUITAR2COMIFACELib

Imports System.Math
Imports OpenTK
Imports OpenTK.Platform
Imports OpenTK.Graphics.OpenGL
Imports OpenTK.Graphics
Imports System.IO

Public Class FingerBot
    Private protocol_obj As XPCAPICOMLib.xPCProtocol

    Private target_obj As XPCAPICOMLib.xPCTarget
    Private scope_obj As XPCAPICOMLib.xPCScopes
    Private parameters_obj As guitar2pt
    Private signals_obj As guitar2bio
    Private stat As Integer

    Private modelRunning As Boolean = True
    Private forceOn As Boolean = True

    Private Const scopeNum As Integer = 3
    Public rightHandMode As Boolean

    Public posF1 As Single = 0
    Public posF2 As Single = 0
    Public velF1 As Single = 0
    Public velF2 As Single = 0

    Private Kp1 As Single = 8
    Private Kp2 As Single = 8
    Private Kv1 As Single = 0.8
    Private Kv2 As Single = 0.8
    Private Kdcap() As Single = {0, 7}
    Private Kpcap() As Single = {0, 70}

    Public hand As String = "R"
    Public trial As Single = 1

    Private dataFile As StreamWriter
    Private dataFileOpen As Boolean = 0
    Private fileTimer As New Stopwatch

    Private zeroPos1 As Single = 0
    Private zeroPos2 As Single = 0

    Public targetTime As Single = 0

    Private movementSet As Boolean = False
    Public destination As Single = 0.105 ' 0.175
    Private reachtime As Single = 0
    Public startTime As Double = 0


#Region "constructors"
    '--------------------------------------------------------------------------------'
    '------------------------------ default contructor ------------------------------'
    '--------------------------------------------------------------------------------'
    Public Sub New()
        protocol_obj = New xPCProtocol
        target_obj = New xPCTarget
        scope_obj = New xPCScopes
        parameters_obj = New guitar2pt
        signals_obj = New guitar2bio

        stat = protocol_obj.Init
        If stat < 0 Then
            MsgBox("Could not load api") 'We can no longer continue.
            End
        End If
        stat = protocol_obj.TcpIpConnect(TARGETIP, "22222") ' 129.101.53.73
        If (stat = 0) Then MsgBox("failed to connect to xpc target computer" & vbNewLine)
        stat = target_obj.Init(protocol_obj)
        stat = scope_obj.Init(protocol_obj)
        stat = parameters_obj.Init(protocol_obj.Ref)
        stat = signals_obj.Init(protocol_obj.Ref)

        ' now actually load the model to the xpc computer
        stat = target_obj.LoadApp(GAMEPATH, "guitar2")

        Dim setVal(0) As Double
        setVal(0) = -5
        stat = target_obj.SetParam(parameters_obj.learning_rate, setVal)
        setVal(0) = -1
        stat = target_obj.SetParam(parameters_obj.forgetting_rate, setVal)
        setVal(0) = 0.15
        stat = target_obj.SetParam(parameters_obj.gcRate, setVal)

        initializeGains()
    End Sub


#End Region

#Region "settup and shutdown functions"

    '--------------------------------------------------------------------------------'
    '------------------------------- start the model --------------------------------'
    '--------------------------------------------------------------------------------'
    ' actually start the robot
    Public Sub startR()
        createDataFile()
        stat = target_obj.StartApp
        fileTimer.Start()
        checkGravityDir() ' used to determine whether the robot is configured for left hand mode or right hand mode

    End Sub

    '--------------------------------------------------------------------------------'
    '------------------------------- stop the robot ---------------------------------'
    '--------------------------------------------------------------------------------'
    ' actually start the robot
    Public Sub stopR()
        stat = target_obj.StopApp
    End Sub


    '--------------------------------------------------------------------------------'
    '--------------------------- close the communication ----------------------------'
    '--------------------------------------------------------------------------------'
    ' actually start the robot
    Public Sub close()
        closeDataFile()
        protocol_obj.Close()
    End Sub

#End Region

#Region "file writing functions"

    '--------------------------------------------------------------------------------'
    '------------------------------- create data file -------------------------------'
    '--------------------------------------------------------------------------------'
    Private Sub createDataFile()
        dataFileOpen = 1
        scope_obj.ScopeSetNumSamples(scopeNum, 4.5 * 60 * 1000)
        scope_obj.ScopeSetDecimation(scopeNum, 1)
        dataFile = New System.IO.StreamWriter(GAMEPATH & "dataFiles\" & "positions" & "_" & currentSub.ID & trialStr & String.Format("{0:yyyyMMddhhmmss}", Now) & ".txt")
        dataFile.WriteLine("Pos1" & vbTab & "vel1" & vbTab & "Pos2" & vbTab & "vel2" & vbTab & "pos1d" & vbTab & "pos2d" & vbTab & "kp1" & vbTab & "kd1" & vbTab & "Kp2" & vbTab & "kd2" & vbTab & "time")
    End Sub

    '--------------------------------------------------------------------------------'
    '-------------------------------- close data file -------------------------------'
    '--------------------------------------------------------------------------------'
    Private Sub closeDataFile()
        saveDataChunk()
        dataFileOpen = 0
        dataFile.Close()
    End Sub

    '--------------------------------------------------------------------------------'
    '-------------------------------- save Data chunk -------------------------------'
    '--------------------------------------------------------------------------------'
    Private Sub saveDataChunk()
        If dataFileOpen Then
            Dim scopeState As String
            Dim numSamples As Integer
            Dim signals(12) As Int16
            Dim posGold() As Double
            Dim velGold() As Double
            Dim posBlue() As Double
            Dim velBlue() As Double
            Dim posGoldd() As Double
            Dim posBlued() As Double
            Dim kpGold() As Double
            Dim kvGold() As Double
            Dim kpBlue() As Double
            Dim kvBlue() As Double
            Dim time() As Double
            'Dim scopeNum As Integer = 3 ' I made this availabele to the whole class

            scopeState = scope_obj.ScopeGetState(scopeNum)
            If scopeState = "Acquiring" Then
                stat = scope_obj.ScopeStop(scopeNum)
            End If

            numSamples = scope_obj.ScopeGetNumSamples(scopeNum)
            signals = scope_obj.ScopeGetSignals(scopeNum, 11)

            'Console.Write("signals are ")
            'For Each signal In signals
            'Console.Write(CStr(signal) & vbTab)
            'Next

            posBlue = scope_obj.ScopeGetData(scopeNum, signals(0), 0, numSamples, 1)
            velBlue = scope_obj.ScopeGetData(scopeNum, signals(1), 0, numSamples, 1)
            posGold = scope_obj.ScopeGetData(scopeNum, signals(2), 0, numSamples, 1)
            velGold = scope_obj.ScopeGetData(scopeNum, signals(3), 0, numSamples, 1)
            posBlued = scope_obj.ScopeGetData(scopeNum, signals(4), 0, numSamples, 1)
            posGoldd = scope_obj.ScopeGetData(scopeNum, signals(5), 0, numSamples, 1)
            kpBlue = scope_obj.ScopeGetData(scopeNum, signals(6), 0, numSamples, 1)
            kvBlue = scope_obj.ScopeGetData(scopeNum, signals(7), 0, numSamples, 1)
            kpGold = scope_obj.ScopeGetData(scopeNum, signals(8), 0, numSamples, 1)
            kvGold = scope_obj.ScopeGetData(scopeNum, signals(9), 0, numSamples, 1)
            time = scope_obj.ScopeGetData(scopeNum, signals(10), 0, numSamples, 1)

            For i As Integer = 0 To (numSamples - 1) Step 1
                If rightHandMode Then
                    'dataFile.WriteLine(posGold(i) & vbTab & posBlue(i) & vbTab & posGoldd(i) & vbTab & posBlued(i) & vbTab & forceGold(i) & vbTab & forceBlue(i) & vbTab & time(i))
                    dataFile.WriteLine(posGold(i) & vbTab & velGold(i) & vbTab & posBlue(i) & vbTab & velBlue(i) & vbTab & _
                                       posGoldd(i) & vbTab & posBlued(i) & vbTab & kpGold(i) & vbTab & kvGold(i) & vbTab & kpBlue(i) & vbTab & kvBlue(i) & vbTab & time(i))
                Else
                    'dataFile.WriteLine(posBlue(i) & vbTab & posGold(i) & vbTab & posBlued(i) & vbTab & posGoldd(i) & vbTab & forceBlue(i) & vbTab & forceGold(i) & vbTab & time(i))
                    dataFile.WriteLine(posBlue(i) & vbTab & velBlue(i) & vbTab & posGold(i) & vbTab & velGold(i) & vbTab & _
                                       posBlued(i) & vbTab & posGoldd(i) & vbTab & kpBlue(i) & vbTab & kvBlue(i) & vbTab & kpGold(i) & vbTab & kvGold(i) & vbTab & time(i))
                End If

            Next

            stat = scope_obj.ScopeStart(scopeNum)

        End If
    End Sub

    '--------------------------------------------------------------------------------'
    '---------------------- check if the scope is ready to reset --------------------'
    '--------------------------------------------------------------------------------'
    ' the xpc host scope will only collect data for a specified period of time before it resets. 
    ' I need to catch the scope just before it resets and write the data to a file.
    Public Sub checkScopeReset()
        'Dim scopeNum As Integer = 3   ' made this availabelt to the whole calss
        Dim numSamples As Single
        numSamples = scope_obj.ScopeGetNumSamples(scopeNum)

        If fileTimer.ElapsedMilliseconds > (numSamples - 20) Then
            saveDataChunk()
            fileTimer.Restart()
        End If

    End Sub
#End Region

#Region "functions to set finger movements"
    '--------------------------------------------------------------------------------'
    '-------------------------- set finger 1 movement -------------------------------'
    '--------------------------------------------------------------------------------'
    Public Sub moveFinger1(ByVal targetHitTime As Single)

        Dim setVal(0) As Double
        startTime = targetHitTime
        setVal(0) = targetHitTime

        If rightHandMode Then
            stat = target_obj.SetParam(parameters_obj.hitTimeGold, setVal)
            setVal(0) = reachtime
            stat = target_obj.SetParam(parameters_obj.durationGold, setVal)
            setVal(0) = destination
            stat = target_obj.SetParam(parameters_obj.finalPosGold, setVal)
        Else
            stat = target_obj.SetParam(parameters_obj.hitTimeBlue, setVal)
            setVal(0) = reachtime
            stat = target_obj.SetParam(parameters_obj.durationBlue, setVal)
            setVal(0) = destination
            stat = target_obj.SetParam(parameters_obj.finalPosBlue, setVal)
        End If

    End Sub

    '--------------------------------------------------------------------------------'
    '-------------------------- set finger 2 movement -------------------------------'
    '--------------------------------------------------------------------------------'
    Public Sub moveFinger2(ByVal targetHitTime As Single)

        Dim setVal(0) As Double
        startTime = targetHitTime
        setVal(0) = targetHitTime

        If rightHandMode Then
            stat = target_obj.SetParam(parameters_obj.hitTimeBlue, setVal)
            setVal(0) = reachtime
            stat = target_obj.SetParam(parameters_obj.durationBlue, setVal)
            setVal(0) = destination
            stat = target_obj.SetParam(parameters_obj.finalPosBlue, setVal)
        Else
            stat = target_obj.SetParam(parameters_obj.hitTimeGold, setVal)
            setVal(0) = reachtime
            stat = target_obj.SetParam(parameters_obj.durationGold, setVal)
            setVal(0) = destination
            stat = target_obj.SetParam(parameters_obj.finalPosGold, setVal)
        End If

    End Sub

    Public Sub moveFingersToCurrent(ByVal turnBlockOn As Boolean)

        Dim setVal(0) As Double
        If turnBlockOn Then
            setVal(0) = posF1
            stat = target_obj.SetParam(parameters_obj.blockoffset1, setVal)
            setVal(0) = posF2
            stat = target_obj.SetParam(parameters_obj.blockoffset2, setVal)
        Else
            setVal(0) = 0
            stat = target_obj.SetParam(parameters_obj.blockoffset1, setVal)
            setVal(0) = 0
            stat = target_obj.SetParam(parameters_obj.blockoffset2, setVal)
        End If

    End Sub

    '--------------------------------------------------------------------------------'
    '------------------------ set finger both fingers to move -----------------------'
    '--------------------------------------------------------------------------------'
    Public Sub moveFingers(ByVal targetHitTime As Single)
        Dim setVal(0) As Double
        startTime = targetHitTime
        setVal(0) = targetHitTime
        stat = target_obj.SetParam(parameters_obj.hitTimeBlue, setVal)
        stat = target_obj.SetParam(parameters_obj.hitTimeGold, setVal)
        setVal(0) = reachtime
        stat = target_obj.SetParam(parameters_obj.durationBlue, setVal)
        stat = target_obj.SetParam(parameters_obj.durationGold, setVal)
        setVal(0) = destination
        stat = target_obj.SetParam(parameters_obj.finalPosBlue, setVal)
        stat = target_obj.SetParam(parameters_obj.finalPosGold, setVal)
    End Sub
#End Region

#Region "update gains"

    '--------------------------------------------------------------------------------'
    '------------------------------- initialize gains -------------------------------'
    '--------------------------------------------------------------------------------'
    Public Sub initializeGains()
        Dim setVal(0) As Double
        setVal(0) = Kp1
        target_obj.SetParam(parameters_obj.Kp1, setVal)
        setVal(0) = Kp2
        target_obj.SetParam(parameters_obj.Kp2, setVal)
        setVal(0) = Kv1
        target_obj.SetParam(parameters_obj.Kd1, setVal)
        setVal(0) = Kv2
        target_obj.SetParam(parameters_obj.Kd2, setVal)
    End Sub

    '--------------------------------------------------------------------------------'
    '---------------------------- set gains explicitly ------------------------------'
    '--------------------------------------------------------------------------------'
    ' this function will allow us explicitly set our gains to specific values.
    ' for simplicity, we will allow the user to set only the proporetional gains.
    ' we will set the differential gains to 1/10 of the value of the proportional gains
    ' as we have been doing in the past.
    Public Sub setGainsExplicitly(ByRef propGains As Single())
        Dim setVal(0) As Double
        ' check
        If (propGains(0) < Kpcap(1)) Then
            Kp1 = propGains(0)
        Else
            Kp1 = Kpcap(1)
        End If

        If (propGains(1) < Kpcap(1)) Then
            Kp2 = propGains(1)
        Else
            Kp2 = Kpcap(1)
        End If

        Kv1 = Kp1 / 10
        Kv2 = Kp2 / 10
        If rightHandMode Then
            setVal(0) = Kp1
            stat = target_obj.SetParam(parameters_obj.Kp2, setVal) ' backwards in right hand mode (gold is Kp2 and Kd2)
            setVal(0) = Kp2
            stat = target_obj.SetParam(parameters_obj.Kp1, setVal) ' backwards in right hand mode (gold is Kp2 and Kd2)
            setVal(0) = Kv1
            stat = target_obj.SetParam(parameters_obj.Kd2, setVal)
            setVal(0) = Kv2
            stat = target_obj.SetParam(parameters_obj.Kd1, setVal)
        Else
            setVal(0) = Kp1
            stat = target_obj.SetParam(parameters_obj.Kp1, setVal)
            setVal(0) = Kp2
            stat = target_obj.SetParam(parameters_obj.Kp2, setVal)
            setVal(0) = Kv1
            stat = target_obj.SetParam(parameters_obj.Kd1, setVal)
            setVal(0) = Kv2
            stat = target_obj.SetParam(parameters_obj.Kd2, setVal)
        End If
    End Sub


    '--------------------------------------------------------------------------------'
    '-------------------------- incrament gains for both fingers --------------------'
    '--------------------------------------------------------------------------------'
    Public Sub incrementGains(ByVal increaseStepKp1 As Single, ByVal increaseStepKp2 As Single)
        Dim setVal1(0) As Double
        Dim setVal2(0) As Double

        If (Kp1 + increaseStepKp1 < Kpcap(1)) Then : Kp1 += increaseStepKp1
        Else : Kp1 = Kpcap(1) : End If

        If (Kp2 + increaseStepKp2 < Kpcap(1)) Then : Kp2 += increaseStepKp2
        Else : Kp2 = Kpcap(1) : End If

        Kv1 = Kp1 / 10
        Kv2 = Kp2 / 10

        setVal1(0) = Kp1
        setVal2(0) = Kp2

        If rightHandMode Then
            stat = target_obj.SetParam(parameters_obj.Kp2, setVal1) ' backwards in right hand mode (gold is Kp2 and Kd2)
            setVal1(0) = Kv1
            stat = target_obj.SetParam(parameters_obj.Kd2, setVal1)
            'Console.WriteLine("gain incramented to " & Kp1)

            setVal2(0) = Kp2
            stat = target_obj.SetParam(parameters_obj.Kp1, setVal2) ' kp1 and kd1 corespond to the blue finger this is the bottom finger in righthand mode
            setVal2(0) = Kv2
            stat = target_obj.SetParam(parameters_obj.Kd1, setVal2)
            'Console.WriteLine("gain 2 incramented to " & Kp2)
        Else
            stat = target_obj.SetParam(parameters_obj.Kp1, setVal1)
            setVal1(0) = Kv1
            stat = target_obj.SetParam(parameters_obj.Kd1, setVal1)
            'Console.WriteLine("gain incramented to " & Kp1)

            setVal2(0) = Kp2
            stat = target_obj.SetParam(parameters_obj.Kp2, setVal2)
            setVal2(0) = Kv2
            stat = target_obj.SetParam(parameters_obj.Kd2, setVal2)
            'Console.WriteLine("gain 2 incramented to " & Kp2)
        End If

    End Sub

    '--------------------------------------------------------------------------------'
    '----------------------- decrement gains for both fingers -----------------------'
    '--------------------------------------------------------------------------------'
    Public Sub decrementGains(ByVal decreaseStepKp1 As Single, ByVal decreaseStepKp2 As Single)
        Dim setVal1(0) As Double
        Dim setVal2(0) As Double

        If (Kp1 - decreaseStepKp1 > Kpcap(0)) Then Kp1 -= decreaseStepKp1
        If (Kp2 - decreaseStepKp2 > Kpcap(0)) Then Kp2 -= decreaseStepKp2

        Kv1 = Kp1 / 10
        Kv2 = Kp2 / 10

        setVal1(0) = Kp1
        setVal2(0) = Kp2

        If rightHandMode Then
            stat = target_obj.SetParam(parameters_obj.Kp2, setVal1) ' backwards in right hand mode (gold is Kp2 and Kd2)
            setVal1(0) = Kv1
            stat = target_obj.SetParam(parameters_obj.Kd2, setVal1)
            'Console.WriteLine("gain incramented to " & Kp1)

            stat = target_obj.SetParam(parameters_obj.Kp1, setVal2) ' backwards in right hand mode (gold is Kp2 and Kd2)
            setVal2(0) = Kv2
            stat = target_obj.SetParam(parameters_obj.Kd1, setVal2)
            'Console.WriteLine("gain incramented to " & Kp2)
        Else
            stat = target_obj.SetParam(parameters_obj.Kp1, setVal1)
            setVal1(0) = Kv1
            stat = target_obj.SetParam(parameters_obj.Kd1, setVal1)
            'Console.WriteLine("gain incramented to " & Kp1)

            stat = target_obj.SetParam(parameters_obj.Kp2, setVal2)
            setVal2(0) = Kv2
            stat = target_obj.SetParam(parameters_obj.Kd2, setVal2)
            'Console.WriteLine("gain incramented to " & Kp2)
        End If

    End Sub

    '--------------------------------------------------------------------------------'
    '------------------------------ turn on noteblock signal ------------------------'
    '--------------------------------------------------------------------------------'
    ' turn on the note blocker (put blocked region inside of a trajectory)
    Public Sub noteBlockerOn(ByVal fNum As Integer)
        Dim setVal() As Double = {1}
        If fNum = 1 And rightHandMode Then
            stat = target_obj.SetParam(parameters_obj.blockComGold, setVal)
        ElseIf fNum = 2 And rightHandMode Then
            stat = target_obj.SetParam(parameters_obj.blockComBlue, setVal)
        ElseIf fNum = 1 And Not rightHandMode Then
            stat = target_obj.SetParam(parameters_obj.blockComBlue, setVal)
        Else
            stat = target_obj.SetParam(parameters_obj.blockComGold, setVal)
        End If
    End Sub

    '--------------------------------------------------------------------------------'
    '--------------------------------- set noteblock amount -------------------------'
    '--------------------------------------------------------------------------------'
    ' this controls how long the blocked period is. smaller numbers mean a longer block ... sorry about that, that was kind of dumb
    Private Sub setNoteBlockDur(ByVal num As Double)
        Dim setVal(0) As Double
        setVal(0) = num
        stat = target_obj.SetParam(parameters_obj.blockThresh, setVal)
    End Sub

    '--------------------------------------------------------------------------------'
    '----------------------------- turn off noteblock signal ------------------------'
    '--------------------------------------------------------------------------------'
    ' turn off the note blocker (removes blocked region inside of a trajectory)
    Public Sub noteBlockerOff()
        Dim setVal() As Double = {0}
        stat = target_obj.SetParam(parameters_obj.blockComBlue, setVal)
        stat = target_obj.SetParam(parameters_obj.blockComGold, setVal)
    End Sub

    '--------------------------------------------------------------------------------'
    '---------------- get the proportional gains (they're private) ------------------'
    '--------------------------------------------------------------------------------'
    Public Function getPropGains() As Single()
        Return {Kp1, Kp2}
    End Function

#End Region


    '--------------------------------------------------------------------------------'
    '---------------------------- flip the on/off switch ----------------------------'
    '--------------------------------------------------------------------------------'
    Public Sub stopModel()
        Dim setVal(0) As Double

        If modelRunning Then
            modelRunning = Not modelRunning
            setVal(0) = 1
            stat = target_obj.SetParam(parameters_obj.onSwitch, setVal)
        Else
            modelRunning = Not modelRunning
            setVal(0) = 0
            stat = target_obj.SetParam(parameters_obj.onSwitch, setVal)
        End If

    End Sub

    '--------------------------------------------------------------------------------'
    '------------------------ get positions and velocities --------------------------'
    '--------------------------------------------------------------------------------'
    Public Sub getPos()
        checkScopeReset()

        'Dim val As Single
        'val = target_obj.GetSignal(signals_obj.posBlue)
        'If val > 0.05 Then Console.WriteLine("Blue: " & val)
        'val = target_obj.GetSignal(signals_obj.posGold)
        'If val > 0.05 Then Console.WriteLine("Gold: " & val)

        If rightHandMode Then
            posF2 = target_obj.GetSignal(signals_obj.posBlue) - zeroPos2
            velF2 = target_obj.GetSignal(signals_obj.velBlue)
            posF1 = target_obj.GetSignal(signals_obj.posGold) - zeroPos1
            velF1 = target_obj.GetSignal(signals_obj.velGold)
        Else
            posF1 = target_obj.GetSignal(signals_obj.posBlue) - zeroPos1
            velF1 = target_obj.GetSignal(signals_obj.velBlue)
            posF2 = target_obj.GetSignal(signals_obj.posGold) - zeroPos2
            velF2 = target_obj.GetSignal(signals_obj.velGold)
        End If

    End Sub

    '--------------------------------------------------------------------------------'
    '-------------------------- get frelling target time ----------------------------'
    '--------------------------------------------------------------------------------'
    Public Sub getTargetTime()
        targetTime = (target_obj.GetSignal(signals_obj.targetTime) - 5) * 1000 ' subtract off the zeroing time and convert to miliseconds
    End Sub

    '--------------------------------------------------------------------------------'
    '------------------------------- set pos offset ---------------------------------'
    '--------------------------------------------------------------------------------'
    Public Sub setPosOffset()
        Dim setVal(0) As Double
        setVal(0) = -0.06
        stat = target_obj.SetParam(parameters_obj.posoffset, setVal)
    End Sub

    '--------------------------------------------------------------------------------'
    '---------------------------------- Tore the game -------------------------------'
    '--------------------------------------------------------------------------------'
    Public Sub toreGame()
        getPos()
        zeroPos1 = posF1
        zeroPos2 = posF2
    End Sub


    '--------------------------------------------------------------------------------'
    '------------------------------ turn forces on/off ------------------------------'
    '--------------------------------------------------------------------------------'
    Public Sub setForceOnOff()
        Dim setVal(0) As Double

        If forceOn Then
            forceOn = Not forceOn
            setVal(0) = 1
            stat = target_obj.SetParam(parameters_obj.stopForces, setVal)
        Else
            forceOn = Not forceOn
            setVal(0) = 0
            stat = target_obj.SetParam(parameters_obj.stopForces, setVal)
        End If

    End Sub


    '--------------------------------------------------------------------------------'
    '---------------------------- check gravity direction ---------------------------'
    '--------------------------------------------------------------------------------'
    Public Sub checkGravityDir()
        Dim gDir As Single = target_obj.GetSignal(signals_obj.gDirection) '= -0.05 '
        'uncomment this line to see what the raw accelerometer values are in left and right hand modes.
        'Console.WriteLine("gravity direction value " & CStr(gDir))

        hand = currentSub.hand 'this looks like a valid call to the subjects file, but the files have no hand entry (yet)?
        If currentSub.hand.ToUpper().StartsWith("L") Then
            MsgBox("This subject usually uses the left hand... Turn robot over?")
            rightHandMode = False
        ElseIf currentSub.hand.ToUpper().StartsWith("R") Then
            MsgBox("This subject usually uses the right hand.")
            rightHandMode = True
        Else
            MsgBox("Subject handedness not set. Assuming right handed.")
            rightHandMode = True
        End If

        Console.WriteLine("right hand mode is " & CStr(rightHandMode) & vbTab & CStr(gDir))
    End Sub


End Class
