<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewSubjectForm
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
        Me.subHandList = New System.Windows.Forms.ListBox()
        Me.handLbl = New System.Windows.Forms.Label()
        Me.updateLstBtn = New System.Windows.Forms.Button()
        Me.subIDLbl = New System.Windows.Forms.Label()
        Me.subIdTb = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'subHandList
        '
        Me.subHandList.FormattingEnabled = True
        Me.subHandList.Items.AddRange(New Object() {"R", "L"})
        Me.subHandList.Location = New System.Drawing.Point(95, 66)
        Me.subHandList.Name = "subHandList"
        Me.subHandList.Size = New System.Drawing.Size(17, 30)
        Me.subHandList.TabIndex = 18
        '
        'handLbl
        '
        Me.handLbl.AutoSize = True
        Me.handLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.handLbl.Location = New System.Drawing.Point(41, 73)
        Me.handLbl.Name = "handLbl"
        Me.handLbl.Size = New System.Drawing.Size(48, 20)
        Me.handLbl.TabIndex = 17
        Me.handLbl.Text = "Hand"
        '
        'updateLstBtn
        '
        Me.updateLstBtn.Location = New System.Drawing.Point(5, 102)
        Me.updateLstBtn.Name = "updateLstBtn"
        Me.updateLstBtn.Size = New System.Drawing.Size(141, 43)
        Me.updateLstBtn.TabIndex = 16
        Me.updateLstBtn.Text = "Update Subject List"
        Me.updateLstBtn.UseVisualStyleBackColor = True
        '
        'subIDLbl
        '
        Me.subIDLbl.AutoSize = True
        Me.subIDLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subIDLbl.Location = New System.Drawing.Point(12, 9)
        Me.subIDLbl.Name = "subIDLbl"
        Me.subIDLbl.Size = New System.Drawing.Size(123, 20)
        Me.subIDLbl.TabIndex = 15
        Me.subIDLbl.Text = "New Subject ID:"
        '
        'subIdTb
        '
        Me.subIdTb.Location = New System.Drawing.Point(33, 32)
        Me.subIdTb.Name = "subIdTb"
        Me.subIdTb.Size = New System.Drawing.Size(91, 20)
        Me.subIdTb.TabIndex = 14
        '
        'NewSubjectForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(159, 155)
        Me.Controls.Add(Me.subHandList)
        Me.Controls.Add(Me.handLbl)
        Me.Controls.Add(Me.updateLstBtn)
        Me.Controls.Add(Me.subIDLbl)
        Me.Controls.Add(Me.subIdTb)
        Me.Name = "NewSubjectForm"
        Me.Text = "NewSubjectForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents subHandList As System.Windows.Forms.ListBox
    Friend WithEvents handLbl As System.Windows.Forms.Label
    Friend WithEvents updateLstBtn As System.Windows.Forms.Button
    Friend WithEvents subIDLbl As System.Windows.Forms.Label
    Friend WithEvents subIdTb As System.Windows.Forms.TextBox
End Class
