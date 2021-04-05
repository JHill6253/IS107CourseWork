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
        Me.lstData = New System.Windows.Forms.ListBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtOriginal = New System.Windows.Forms.TextBox()
        Me.txtDesired = New System.Windows.Forms.TextBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.lblConvert = New System.Windows.Forms.Label()
        Me.lblOriginal = New System.Windows.Forms.Label()
        Me.lblDesired = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstData
        '
        Me.lstData.FormattingEnabled = True
        Me.lstData.Location = New System.Drawing.Point(12, 12)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(120, 225)
        Me.lstData.TabIndex = 0
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(239, 13)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtAmount.TabIndex = 1
        '
        'txtOriginal
        '
        Me.txtOriginal.Location = New System.Drawing.Point(298, 39)
        Me.txtOriginal.Name = "txtOriginal"
        Me.txtOriginal.Size = New System.Drawing.Size(41, 20)
        Me.txtOriginal.TabIndex = 2
        '
        'txtDesired
        '
        Me.txtDesired.Location = New System.Drawing.Point(298, 65)
        Me.txtDesired.Name = "txtDesired"
        Me.txtDesired.Size = New System.Drawing.Size(41, 20)
        Me.txtDesired.TabIndex = 3
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(167, 103)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(172, 23)
        Me.btnConvert.TabIndex = 4
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(254, 147)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(85, 20)
        Me.txtOutput.TabIndex = 5
        '
        'lblConvert
        '
        Me.lblConvert.AutoSize = True
        Me.lblConvert.Location = New System.Drawing.Point(139, 13)
        Me.lblConvert.Name = "lblConvert"
        Me.lblConvert.Size = New System.Drawing.Size(97, 13)
        Me.lblConvert.TabIndex = 6
        Me.lblConvert.Text = "Amount to convert:"
        '
        'lblOriginal
        '
        Me.lblOriginal.AutoSize = True
        Me.lblOriginal.Location = New System.Drawing.Point(164, 42)
        Me.lblOriginal.Name = "lblOriginal"
        Me.lblOriginal.Size = New System.Drawing.Size(113, 13)
        Me.lblOriginal.TabIndex = 7
        Me.lblOriginal.Text = "Original currency (1-9):"
        '
        'lblDesired
        '
        Me.lblDesired.AutoSize = True
        Me.lblDesired.Location = New System.Drawing.Point(163, 68)
        Me.lblDesired.Name = "lblDesired"
        Me.lblDesired.Size = New System.Drawing.Size(114, 13)
        Me.lblDesired.TabIndex = 8
        Me.lblDesired.Text = "Desired currency (1-9):"
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(164, 150)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(84, 13)
        Me.lblOutput.TabIndex = 9
        Me.lblOutput.Text = "Desired amount:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 265)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.lblDesired)
        Me.Controls.Add(Me.lblOriginal)
        Me.Controls.Add(Me.lblConvert)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.txtDesired)
        Me.Controls.Add(Me.txtOriginal)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.lstData)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstData As ListBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents txtOriginal As TextBox
    Friend WithEvents txtDesired As TextBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents lblConvert As Label
    Friend WithEvents lblOriginal As Label
    Friend WithEvents lblDesired As Label
    Friend WithEvents lblOutput As Label
End Class
