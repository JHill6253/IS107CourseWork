<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmName
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
        Me.txtCustomer = New System.Windows.Forms.TextBox()
        Me.txtLabor = New System.Windows.Forms.TextBox()
        Me.txtParts = New System.Windows.Forms.TextBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.lblParts = New System.Windows.Forms.Label()
        Me.lblLabor = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtCustomer
        '
        Me.txtCustomer.Location = New System.Drawing.Point(94, 12)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(193, 23)
        Me.txtCustomer.TabIndex = 0
        '
        'txtLabor
        '
        Me.txtLabor.Location = New System.Drawing.Point(94, 50)
        Me.txtLabor.Name = "txtLabor"
        Me.txtLabor.Size = New System.Drawing.Size(117, 23)
        Me.txtLabor.TabIndex = 1
        '
        'txtParts
        '
        Me.txtParts.Location = New System.Drawing.Point(94, 94)
        Me.txtParts.Name = "txtParts"
        Me.txtParts.Size = New System.Drawing.Size(117, 23)
        Me.txtParts.TabIndex = 2
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(224, 47)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(62, 69)
        Me.btnDisplay.TabIndex = 3
        Me.btnDisplay.Text = "Display Bill"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 15
        Me.lstOutput.Location = New System.Drawing.Point(96, 129)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(190, 64)
        Me.lstOutput.TabIndex = 4
        '
        'lblCustomer
        '
        Me.lblCustomer.Location = New System.Drawing.Point(26, 12)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(68, 23)
        Me.lblCustomer.TabIndex = 5
        Me.lblCustomer.Text = "Customer:"
        Me.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblParts
        '
        Me.lblParts.Location = New System.Drawing.Point(5, 93)
        Me.lblParts.Name = "lblParts"
        Me.lblParts.Size = New System.Drawing.Size(89, 33)
        Me.lblParts.TabIndex = 6
        Me.lblParts.Text = "Cost of Parts and Supplies:"
        '
        'lblLabor
        '
        Me.lblLabor.Location = New System.Drawing.Point(5, 50)
        Me.lblLabor.Name = "lblLabor"
        Me.lblLabor.Size = New System.Drawing.Size(89, 23)
        Me.lblLabor.TabIndex = 7
        Me.lblLabor.Text = "Hours of Labor:"
        Me.lblLabor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 205)
        Me.Controls.Add(Me.lblLabor)
        Me.Controls.Add(Me.lblParts)
        Me.Controls.Add(Me.lblCustomer)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtParts)
        Me.Controls.Add(Me.txtLabor)
        Me.Controls.Add(Me.txtCustomer)
        Me.Name = "frmName"
        Me.Text = "Auto Repair"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCustomer As TextBox
    Friend WithEvents txtLabor As TextBox
    Friend WithEvents txtParts As TextBox
    Friend WithEvents btnDisplay As Button
    Friend WithEvents lstOutput As ListBox
    Friend WithEvents lblCustomer As Label
    Friend WithEvents lblParts As Label
    Friend WithEvents lblLabor As Label
End Class
