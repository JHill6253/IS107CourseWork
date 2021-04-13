<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBaseball
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
        Me.lblTeam = New System.Windows.Forms.Label()
        Me.lstTeams = New System.Windows.Forms.ListBox()
        Me.dgvDisplay = New System.Windows.Forms.DataGridView()
        CType(Me.dgvDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTeam
        '
        Me.lblTeam.AutoSize = True
        Me.lblTeam.Location = New System.Drawing.Point(26, 25)
        Me.lblTeam.Name = "lblTeam"
        Me.lblTeam.Size = New System.Drawing.Size(80, 13)
        Me.lblTeam.TabIndex = 1
        Me.lblTeam.Text = "Click on a team"
        '
        'lstTeams
        '
        Me.lstTeams.FormattingEnabled = True
        Me.lstTeams.Location = New System.Drawing.Point(12, 41)
        Me.lstTeams.Name = "lstTeams"
        Me.lstTeams.Size = New System.Drawing.Size(120, 121)
        Me.lstTeams.TabIndex = 2
        '
        'dgvDisplay
        '
        Me.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDisplay.Location = New System.Drawing.Point(147, 13)
        Me.dgvDisplay.Name = "dgvDisplay"
        Me.dgvDisplay.RowHeadersVisible = False
        Me.dgvDisplay.Size = New System.Drawing.Size(240, 150)
        Me.dgvDisplay.TabIndex = 3
        '
        'frmBaseball
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(400, 190)
        Me.Controls.Add(Me.dgvDisplay)
        Me.Controls.Add(Me.lstTeams)
        Me.Controls.Add(Me.lblTeam)
        Me.Name = "frmBaseball"
        Me.Text = "Baseball"
        CType(Me.dgvDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTeam As Label
    Friend WithEvents lstTeams As ListBox
    Friend WithEvents dgvDisplay As DataGridView
End Class
