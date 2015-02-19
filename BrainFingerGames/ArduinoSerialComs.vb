Imports System.IO.Ports

Public Class ArduinoSerialComs


    ''------------------------------------------------------------------------------------------------''
    ''------------------------- class for read/write to a serial port / arduino ----------------------''
    ''------------------------------------------------------------------------------------------------''

    Private ser As SerialPort
    Private port As String = "com4"
    Private nChans As Integer
    Private baudR As Integer = 9600
    Public value As Single = 0

    ''------------------------------------------- constructor ------------------------------------''
    Public Sub initialize()
        Try
            ser = New SerialPort(port, baudR)
            nChans = 1
            ser.ReadTimeout = 200
            ser.DataBits = 8
            ser.StopBits = 1
            ser.ReadTimeout = 1500
            ser.ReceivedBytesThreshold = 1
            ser.Open()
            'ser.ReadExisting() ' flush the read buffer
            Console.WriteLine("Connected to arduino")
        Catch ex As Exception
            MsgBox("bad com port or no Arduino (comment out arduino coms in RehabHeroGame if necessary)")
        End Try

    End Sub

    ''-------------------------------------------- close port ------------------------------------''
    Public Sub closePort()
        Try
            ser.Close()
        Catch ex As Exception

        End Try

    End Sub

    '----------------------------------------- check for incoming --------------------------------''
    Public Sub writeData()
        Console.WriteLine("Arduino Write")
        ser.Write("g")
    End Sub

End Class
