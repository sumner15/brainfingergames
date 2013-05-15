Public Class manualIPForm

    Private Sub AcceptBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcceptBtn.Click
        TARGETIP = ManualIPTB.Text
        MsgBox("Target IP address set to: " & TARGETIP)
        Close()
    End Sub

    Private Sub LoadDefaultBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadDefaultBtn.Click
        Module1.setContextValues()
        MsgBox("Target IP address set to: " & TARGETIP)
        Close()
    End Sub
End Class