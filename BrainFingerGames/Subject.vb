
Imports System.IO

'================================================================================'
'---------------------------------- Subject class -------------------------------'
'================================================================================'
Public Class Subject
    Public num As Integer           ' number corresponding to subject
    Public ID As String             ' the user's subject ID
    Public LoginDate As DateTime    ' date subject was created
    Public trial As Single
    Public lastSessionDate As DateTime
    Public lastSessionNumber As Integer
    Public lastGame As String
    Public hand As String

    Private epoch As DateTime = "1970-01-01 00:00:00"
    'Public dataFiles(10) As String  'array of file names for experimental dta files

    '--------------------------------------------------------------------------------'
    '------------------------- constructor for new subjects -------------------------'
    '--------------------------------------------------------------------------------'
    Public Sub New(ByRef subNum As Integer, ByRef subID As String, ByRef subTrial As Single)
        num = subNum
        ID = subID
        LoginDate = Now      
        trial = subTrial
        lastSessionDate = epoch
        lastSessionNumber = 0
        hand = "R"
        lastGame = "none"
        writeSubjectFile()
    End Sub

    Public Sub New(ByVal subID As String)
        readSubjectFile(subID)
    End Sub

    '--------------------------------------------------------------------------------'
    '----------------------------- write subject file -------------------------------'
    '--------------------------------------------------------------------------------'
    Private Sub writeSubjectFile()
        Dim subjectFile As StreamWriter = New StreamWriter(GAMEPATH & "Subjects\" & ID & ".txt")
        subjectFile.WriteLine("num: " & num)
        subjectFile.WriteLine("ID: " & ID)
        subjectFile.WriteLine("LoginDate: " & LoginDate.ToString("s").Replace("T", " "))
        subjectFile.WriteLine("trial: " & trial)
        subjectFile.WriteLine("lastSessionDate: " & lastSessionDate.ToString("s").Replace("T", " "))
        subjectFile.WriteLine("lastSessionNumber: " & lastSessionNumber)
        subjectFile.WriteLine("lastGame: " & currentGame)
        subjectFile.WriteLine("hand: " & hand)
        subjectFile.Close()
    End Sub

    '--------------------------------------------------------------------------------'
    '------------------------------ read subject file -------------------------------'
    '--------------------------------------------------------------------------------'
    Private Sub readSubjectFile(ByVal subId As String)
        Dim fromFile As FileDict = New FileDict(GAMEPATH & "Subjects\" & subId & ".txt")
        num = fromFile.Lookup("num", "0")
        ID = fromFile.Lookup("ID", subId)
        LoginDate = fromFile.Lookup("LoginDate", Now.ToString("s").Replace("T", " "))
        trial = fromFile.Lookup("trial", "0")
        lastSessionDate = fromFile.Lookup("lastSessionDate", epoch)
        lastSessionNumber = fromFile.Lookup("lastSessionNumber", 0)
        lastGame = fromFile.Lookup("lastGame", "none")
        hand = fromFile.Lookup("hand", "R")
    End Sub
    '--------------------------------------------------------------------------------'
    '------------------------------- update subject file ----------------------------'
    '--------------------------------------------------------------------------------'
    Public Sub update()
        writeSubjectFile()
    End Sub

    '--------------------------------------------------------------------------------'
    '------------------------------- make trial var public --------------------------'
    '--------------------------------------------------------------------------------'
    Public Function getSessionString() As String
        Dim today As Boolean = Math.Floor(lastSessionDate.Subtract(epoch).TotalDays) = Math.Floor(Now.Subtract(epoch).TotalDays)
        Dim never As Boolean = (lastSessionDate = epoch)
        If never Then Return "       no previous session"
        Dim result As String = "session " & lastSessionNumber.ToString("000.##")
        result = result & If(today, " today", " on " & lastSessionDate.ToString("yyyy-MM-dd") & vbNewLine)
        result = result & " at " & lastSessionDate.ToString("h:mm tt")
        Return result
    End Function

    Public Function getExpectedSessionNumber() As String
        Dim hrs As Double = Now.Subtract(lastSessionDate).TotalHours
        Dim number As Integer = If(hrs < 4, lastSessionNumber, lastSessionNumber + 1)
        Return number.ToString("000.##")
    End Function

End Class
