<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RehabHeroPrep
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
        Me.songList = New System.Windows.Forms.ListBox()
        Me.thumbnail = New System.Windows.Forms.PictureBox()
        Me.songPnl = New System.Windows.Forms.Panel()
        Me.songNameLbl = New System.Windows.Forms.Label()
        Me.playSongBtn = New System.Windows.Forms.Button()
        Me.difficultyList = New System.Windows.Forms.ListBox()
        CType(Me.thumbnail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.songPnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'songList
        '
        Me.songList.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.songList.FormattingEnabled = True
        Me.songList.ItemHeight = 18
        Me.songList.Location = New System.Drawing.Point(14, 12)
        Me.songList.Name = "songList"
        Me.songList.Size = New System.Drawing.Size(159, 292)
        Me.songList.TabIndex = 46
        '
        'thumbnail
        '
        Me.thumbnail.Location = New System.Drawing.Point(3, 3)
        Me.thumbnail.Name = "thumbnail"
        Me.thumbnail.Size = New System.Drawing.Size(245, 245)
        Me.thumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.thumbnail.TabIndex = 0
        Me.thumbnail.TabStop = False
        '
        'songPnl
        '
        Me.songPnl.Controls.Add(Me.songNameLbl)
        Me.songPnl.Controls.Add(Me.thumbnail)
        Me.songPnl.Location = New System.Drawing.Point(180, 12)
        Me.songPnl.Name = "songPnl"
        Me.songPnl.Size = New System.Drawing.Size(251, 281)
        Me.songPnl.TabIndex = 47
        '
        'songNameLbl
        '
        Me.songNameLbl.AutoSize = True
        Me.songNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.songNameLbl.Location = New System.Drawing.Point(-1, 251)
        Me.songNameLbl.Name = "songNameLbl"
        Me.songNameLbl.Size = New System.Drawing.Size(111, 24)
        Me.songNameLbl.TabIndex = 2
        Me.songNameLbl.Text = "Song Name"
        '
        'playSongBtn
        '
        Me.playSongBtn.Location = New System.Drawing.Point(180, 299)
        Me.playSongBtn.Name = "playSongBtn"
        Me.playSongBtn.Size = New System.Drawing.Size(251, 54)
        Me.playSongBtn.TabIndex = 48
        Me.playSongBtn.Text = "Play Song"
        Me.playSongBtn.UseVisualStyleBackColor = True
        '
        'difficultyList
        '
        Me.difficultyList.FormattingEnabled = True
        Me.difficultyList.Items.AddRange(New Object() {"easy", "medium", "hard"})
        Me.difficultyList.Location = New System.Drawing.Point(14, 310)
        Me.difficultyList.Name = "difficultyList"
        Me.difficultyList.Size = New System.Drawing.Size(160, 43)
        Me.difficultyList.TabIndex = 49
        '
        'RehabHeroPrep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 369)
        Me.Controls.Add(Me.songList)
        Me.Controls.Add(Me.songPnl)
        Me.Controls.Add(Me.playSongBtn)
        Me.Controls.Add(Me.difficultyList)
        Me.Name = "RehabHeroPrep"
        Me.Text = "RehabHeroPrep"
        CType(Me.thumbnail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.songPnl.ResumeLayout(False)
        Me.songPnl.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents songList As System.Windows.Forms.ListBox
    Friend WithEvents thumbnail As System.Windows.Forms.PictureBox
    Friend WithEvents songPnl As System.Windows.Forms.Panel
    Friend WithEvents songNameLbl As System.Windows.Forms.Label
    Friend WithEvents playSongBtn As System.Windows.Forms.Button
    Friend WithEvents difficultyList As System.Windows.Forms.ListBox
End Class
