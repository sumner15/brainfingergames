Public Class DeleteSubjectForm

    Dim subPopulation As SubPop
    Dim selected As Integer = 0

    '--------------------------------------------------------------------------------'
    '--------------------- constructor for the delete subject menu ------------------'
    '--------------------------------------------------------------------------------'
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        subPopulation = New SubPop()
        subjectList.DataSource = subPopulation.subIds        
    End Sub


    '--------------------------------------------------------------------------------'
    '--------------------------- click subject list event ---------------------------'
    '--------------------------------------------------------------------------------'
    Private Sub subjectList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subjectList.SelectedIndexChanged
        selected = subjectList.SelectedIndex
    End Sub


    '--------------------------------------------------------------------------------'
    '-------------------------- delete subject button event -------------------------'
    '--------------------------------------------------------------------------------'
    Private Sub DeleteBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteBtn.Click
        Dim currentSub As Subject
        currentSub = subPopulation.subjects(selected)

        If Not (selected = 0) Then            
            Module1.menu.subPopulation.deleteSubject(currentSub)

            Module1.menu.subjectList.DataSource = Module1.menu.subPopulation.subIds
            Module1.menu.subjectList.Update()

            Close()
        Else
            MsgBox("You cannot delete the Default Subject") : Return
        End If

        'update menu subject list
        Module1.menu.subjectList.DataSource = Module1.menu.subPopulation.subIds
        Module1.menu.subjectList.Update()

        Close()
    End Sub


    '--------------------------------------------------------------------------------'
    '----------------------------- cancel button event ------------------------------'
    '--------------------------------------------------------------------------------'
    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        Close()
    End Sub
End Class