Public Class NewSubjectForm

    Dim subj As Subject

    '--------------------------------------------------------------------------------'
    '--------------------------- add subject button event ---------------------------'
    '--------------------------------------------------------------------------------'
    Private Sub updateLstBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updateLstBtn.Click

        If Not (subIdTb.Text = "") Then
            addSubjID = subIdTb.Text
            If (subHandList.SelectedIndex = 1) Then addSubjHand = "L" Else addSubjHand = "R"
            Close()
            MsgBox("Please refresh the subject list now")
        Else
            MsgBox("Enter the subject's information before trying to save the subject.")
        End If

    End Sub

End Class