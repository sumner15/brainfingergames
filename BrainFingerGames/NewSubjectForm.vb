Public Class NewSubjectForm

    '--------------------------------------------------------------------------------'
    '--------------------------- add subject button event ---------------------------'
    '--------------------------------------------------------------------------------'
    Private Sub updateLstBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updateLstBtn.Click

        If Not (subIdTb.Text = "") Then
            Dim hand As String            
            Dim num As Integer      ' number corresponding to subject            
            Dim subj As Subject     ' subject

            If (subHandList.SelectedIndex = 1) Then hand = "L" Else hand = "R"
            num = Module1.menu.subPopulation.popSize + 1
            subj = New Subject(num, subIdTb.Text, 1)
            subj.hand = hand
            Module1.menu.subPopulation.addSubject(subj)

            Module1.menu.subjectList.DataSource = Module1.menu.subPopulation.subIds
            Module1.menu.subjectList.Update()

            Close()
        Else
            MsgBox("Enter the subject's information before trying to save the subject.")
        End If

    End Sub

End Class