<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.lblTeam = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblHighScore = New System.Windows.Forms.Label()
        Me.txtWinningTeamName = New System.Windows.Forms.TextBox()
        Me.txtTotalScore = New System.Windows.Forms.TextBox()
        Me.lstHighestScore = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(12, 12)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(257, 23)
        Me.btnDisplay.TabIndex = 0
        Me.btnDisplay.Text = "Display Match Results"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'lblTeam
        '
        Me.lblTeam.AutoSize = True
        Me.lblTeam.Location = New System.Drawing.Point(37, 50)
        Me.lblTeam.Name = "lblTeam"
        Me.lblTeam.Size = New System.Drawing.Size(107, 13)
        Me.lblTeam.TabIndex = 1
        Me.lblTeam.Text = "Winning Team Name"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(178, 50)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(92, 13)
        Me.lblScore.TabIndex = 3
        Me.lblScore.Text = "Total Team Score"
        '
        'lblHighScore
        '
        Me.lblHighScore.AutoSize = True
        Me.lblHighScore.Location = New System.Drawing.Point(71, 106)
        Me.lblHighScore.Name = "lblHighScore"
        Me.lblHighScore.Size = New System.Drawing.Size(137, 13)
        Me.lblHighScore.TabIndex = 4
        Me.lblHighScore.Text = "Highest Single Game Score"
        '
        'txtWinningTeamName
        '
        Me.txtWinningTeamName.Location = New System.Drawing.Point(12, 66)
        Me.txtWinningTeamName.Name = "txtWinningTeamName"
        Me.txtWinningTeamName.Size = New System.Drawing.Size(157, 20)
        Me.txtWinningTeamName.TabIndex = 5
        '
        'txtTotalScore
        '
        Me.txtTotalScore.Location = New System.Drawing.Point(193, 66)
        Me.txtTotalScore.Name = "txtTotalScore"
        Me.txtTotalScore.Size = New System.Drawing.Size(77, 20)
        Me.txtTotalScore.TabIndex = 6
        '
        'lstHighestScore
        '
        Me.lstHighestScore.FormattingEnabled = True
        Me.lstHighestScore.Location = New System.Drawing.Point(12, 132)
        Me.lstHighestScore.Name = "lstHighestScore"
        Me.lstHighestScore.Size = New System.Drawing.Size(257, 56)
        Me.lstHighestScore.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 206)
        Me.Controls.Add(Me.lstHighestScore)
        Me.Controls.Add(Me.txtTotalScore)
        Me.Controls.Add(Me.txtWinningTeamName)
        Me.Controls.Add(Me.lblHighScore)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblTeam)
        Me.Controls.Add(Me.btnDisplay)
        Me.Name = "Form1"
        Me.Text = "Bowling Match Results "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDisplay As Button
    Friend WithEvents lblTeam As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents lblHighScore As Label
    Friend WithEvents txtWinningTeamName As TextBox
    Friend WithEvents txtTotalScore As TextBox
    Friend WithEvents lstHighestScore As ListBox
End Class
