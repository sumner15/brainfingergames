<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manualIPForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ManualIPTB = New System.Windows.Forms.TextBox()
        Me.AcceptBtn = New System.Windows.Forms.Button()
        Me.LoadDefaultBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ManualIPTB
        '
        Me.ManualIPTB.Location = New System.Drawing.Point(12, 12)
        Me.ManualIPTB.Name = "ManualIPTB"
        Me.ManualIPTB.Size = New System.Drawing.Size(260, 20)
        Me.ManualIPTB.TabIndex = 0
        Me.ManualIPTB.Text = "Enter manual IP number here [xxx.xxx.x.xxx]"
        '
        'AcceptBtn
        '
        Me.AcceptBtn.Location = New System.Drawing.Point(12, 38)
        Me.AcceptBtn.Name = "AcceptBtn"
        Me.AcceptBtn.Size = New System.Drawing.Size(260, 23)
        Me.AcceptBtn.TabIndex = 1
        Me.AcceptBtn.Text = "Accept"
        Me.AcceptBtn.UseVisualStyleBackColor = True
        '
        'LoadDefaultBtn
        '
        Me.LoadDefaultBtn.Location = New System.Drawing.Point(12, 67)
        Me.LoadDefaultBtn.Name = "LoadDefaultBtn"
        Me.LoadDefaultBtn.Size = New System.Drawing.Size(260, 23)
        Me.LoadDefaultBtn.TabIndex = 2
        Me.LoadDefaultBtn.Text = "Load Default IP"
        Me.LoadDefaultBtn.UseVisualStyleBackColor = True
        '
        'manualIPForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 100)
        Me.Controls.Add(Me.LoadDefaultBtn)
        Me.Controls.Add(Me.AcceptBtn)
        Me.Controls.Add(Me.ManualIPTB)
        Me.Name = "manualIPForm"
        Me.Text = "manualIPForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ManualIPTB As System.Windows.Forms.TextBox
    Friend WithEvents AcceptBtn As System.Windows.Forms.Button
    Friend WithEvents LoadDefaultBtn As System.Windows.Forms.Button
End Class
