<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Debug_Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Debug_Menu))
        Me.lblDebug = New System.Windows.Forms.Label()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnFolder = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDebug
        '
        Me.lblDebug.AutoSize = True
        Me.lblDebug.Location = New System.Drawing.Point(12, 9)
        Me.lblDebug.Name = "lblDebug"
        Me.lblDebug.Size = New System.Drawing.Size(101, 20)
        Me.lblDebug.TabIndex = 0
        Me.lblDebug.Text = "Debug Menu"
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(16, 32)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(201, 37)
        Me.btnReport.TabIndex = 1
        Me.btnReport.Text = "Generate Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(16, 75)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(201, 37)
        Me.btnBrowse.TabIndex = 2
        Me.btnBrowse.Text = "Open Readme"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnFolder
        '
        Me.btnFolder.Location = New System.Drawing.Point(16, 118)
        Me.btnFolder.Name = "btnFolder"
        Me.btnFolder.Size = New System.Drawing.Size(201, 37)
        Me.btnFolder.TabIndex = 3
        Me.btnFolder.Text = "Show program folder"
        Me.btnFolder.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BUG
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(225, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(193, 80)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Debug_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 169)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnFolder)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.lblDebug)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Debug_Menu"
        Me.Text = "Debug Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDebug As Label
    Friend WithEvents btnReport As Button
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnFolder As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
