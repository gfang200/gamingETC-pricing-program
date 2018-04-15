<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDebugReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDebugReport))
        Me.gbxSevere = New System.Windows.Forms.GroupBox()
        Me.rbLow = New System.Windows.Forms.RadioButton()
        Me.rbMed = New System.Windows.Forms.RadioButton()
        Me.rbHigh = New System.Windows.Forms.RadioButton()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.gbxSevere.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxSevere
        '
        Me.gbxSevere.Controls.Add(Me.rbHigh)
        Me.gbxSevere.Controls.Add(Me.rbMed)
        Me.gbxSevere.Controls.Add(Me.rbLow)
        Me.gbxSevere.Location = New System.Drawing.Point(16, 16)
        Me.gbxSevere.Name = "gbxSevere"
        Me.gbxSevere.Size = New System.Drawing.Size(348, 69)
        Me.gbxSevere.TabIndex = 0
        Me.gbxSevere.TabStop = False
        Me.gbxSevere.Text = "Bug Severity"
        '
        'rbLow
        '
        Me.rbLow.AutoSize = True
        Me.rbLow.Location = New System.Drawing.Point(20, 26)
        Me.rbLow.Name = "rbLow"
        Me.rbLow.Size = New System.Drawing.Size(63, 24)
        Me.rbLow.TabIndex = 0
        Me.rbLow.TabStop = True
        Me.rbLow.Text = "Low"
        Me.rbLow.UseVisualStyleBackColor = True
        '
        'rbMed
        '
        Me.rbMed.AutoSize = True
        Me.rbMed.Location = New System.Drawing.Point(123, 26)
        Me.rbMed.Name = "rbMed"
        Me.rbMed.Size = New System.Drawing.Size(90, 24)
        Me.rbMed.TabIndex = 1
        Me.rbMed.TabStop = True
        Me.rbMed.Text = "Medium"
        Me.rbMed.UseVisualStyleBackColor = True
        '
        'rbHigh
        '
        Me.rbHigh.AutoSize = True
        Me.rbHigh.Location = New System.Drawing.Point(252, 26)
        Me.rbHigh.Name = "rbHigh"
        Me.rbHigh.Size = New System.Drawing.Size(67, 24)
        Me.rbHigh.TabIndex = 2
        Me.rbHigh.TabStop = True
        Me.rbHigh.Text = "High"
        Me.rbHigh.UseVisualStyleBackColor = True
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(16, 121)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(348, 164)
        Me.txtDesc.TabIndex = 1
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Location = New System.Drawing.Point(12, 98)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(122, 20)
        Me.lblDesc.TabIndex = 2
        Me.lblDesc.Text = "Bug Description"
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(16, 302)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(348, 42)
        Me.btnGenerate.TabIndex = 3
        Me.btnGenerate.Text = "Generate Report"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'frmDebugReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 356)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.gbxSevere)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDebugReport"
        Me.Text = "Generate Report"
        Me.gbxSevere.ResumeLayout(False)
        Me.gbxSevere.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbxSevere As GroupBox
    Friend WithEvents rbHigh As RadioButton
    Friend WithEvents rbMed As RadioButton
    Friend WithEvents rbLow As RadioButton
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents lblDesc As Label
    Friend WithEvents btnGenerate As Button
End Class
