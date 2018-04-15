<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnStep1 = New System.Windows.Forms.Button()
        Me.btnStep2 = New System.Windows.Forms.Button()
        Me.btnStep3 = New System.Windows.Forms.Button()
        Me.trkSpeed = New System.Windows.Forms.TrackBar()
        Me.lsbFiles = New System.Windows.Forms.ListBox()
        Me.lblSecondsLabel = New System.Windows.Forms.Label()
        Me.lblSeconds = New System.Windows.Forms.Label()
        Me.lblSelectFile = New System.Windows.Forms.Label()
        Me.btnSelectFile = New System.Windows.Forms.Button()
        Me.lblSelectedFileLabel = New System.Windows.Forms.Label()
        Me.lblSelectedFile = New System.Windows.Forms.Label()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSets = New System.Windows.Forms.Button()
        Me.ctnFileControl = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalMin = New System.Windows.Forms.Label()
        Me.btnStocks = New System.Windows.Forms.Button()
        Me.gbxOnline = New System.Windows.Forms.GroupBox()
        Me.btnCase = New System.Windows.Forms.Button()
        Me.btnDebug = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.trkSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctnFileControl.SuspendLayout()
        Me.gbxOnline.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStep1
        '
        Me.btnStep1.Location = New System.Drawing.Point(487, 107)
        Me.btnStep1.Name = "btnStep1"
        Me.btnStep1.Size = New System.Drawing.Size(156, 37)
        Me.btnStep1.TabIndex = 0
        Me.btnStep1.Text = "Step 1"
        Me.btnStep1.UseVisualStyleBackColor = True
        '
        'btnStep2
        '
        Me.btnStep2.Location = New System.Drawing.Point(487, 160)
        Me.btnStep2.Name = "btnStep2"
        Me.btnStep2.Size = New System.Drawing.Size(156, 37)
        Me.btnStep2.TabIndex = 1
        Me.btnStep2.Text = "Step 2"
        Me.btnStep2.UseVisualStyleBackColor = True
        '
        'btnStep3
        '
        Me.btnStep3.Location = New System.Drawing.Point(487, 214)
        Me.btnStep3.Name = "btnStep3"
        Me.btnStep3.Size = New System.Drawing.Size(156, 37)
        Me.btnStep3.TabIndex = 2
        Me.btnStep3.Text = "Step 3"
        Me.btnStep3.UseVisualStyleBackColor = True
        '
        'trkSpeed
        '
        Me.trkSpeed.LargeChange = 100
        Me.trkSpeed.Location = New System.Drawing.Point(12, 12)
        Me.trkSpeed.Maximum = 4000
        Me.trkSpeed.Name = "trkSpeed"
        Me.trkSpeed.Size = New System.Drawing.Size(444, 69)
        Me.trkSpeed.SmallChange = 100
        Me.trkSpeed.TabIndex = 3
        Me.trkSpeed.TickFrequency = 100
        Me.trkSpeed.Value = 2000
        '
        'lsbFiles
        '
        Me.lsbFiles.FormattingEnabled = True
        Me.lsbFiles.ItemHeight = 20
        Me.lsbFiles.Location = New System.Drawing.Point(32, 106)
        Me.lsbFiles.Name = "lsbFiles"
        Me.lsbFiles.Size = New System.Drawing.Size(430, 104)
        Me.lsbFiles.TabIndex = 4
        '
        'lblSecondsLabel
        '
        Me.lblSecondsLabel.AutoSize = True
        Me.lblSecondsLabel.Location = New System.Drawing.Point(216, 53)
        Me.lblSecondsLabel.Name = "lblSecondsLabel"
        Me.lblSecondsLabel.Size = New System.Drawing.Size(218, 20)
        Me.lblSecondsLabel.TabIndex = 5
        Me.lblSecondsLabel.Text = "Estimated Seconds Per Card:"
        '
        'lblSeconds
        '
        Me.lblSeconds.AutoSize = True
        Me.lblSeconds.Location = New System.Drawing.Point(436, 53)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.Size = New System.Drawing.Size(31, 20)
        Me.lblSeconds.TabIndex = 6
        Me.lblSeconds.Text = "2.5"
        '
        'lblSelectFile
        '
        Me.lblSelectFile.AutoSize = True
        Me.lblSelectFile.Location = New System.Drawing.Point(28, 83)
        Me.lblSelectFile.Name = "lblSelectFile"
        Me.lblSelectFile.Size = New System.Drawing.Size(83, 20)
        Me.lblSelectFile.TabIndex = 7
        Me.lblSelectFile.Text = "Select File"
        '
        'btnSelectFile
        '
        Me.btnSelectFile.Location = New System.Drawing.Point(32, 219)
        Me.btnSelectFile.Name = "btnSelectFile"
        Me.btnSelectFile.Size = New System.Drawing.Size(156, 37)
        Me.btnSelectFile.TabIndex = 9
        Me.btnSelectFile.Text = "Select File"
        Me.btnSelectFile.UseVisualStyleBackColor = True
        '
        'lblSelectedFileLabel
        '
        Me.lblSelectedFileLabel.AutoSize = True
        Me.lblSelectedFileLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedFileLabel.Location = New System.Drawing.Point(194, 227)
        Me.lblSelectedFileLabel.Name = "lblSelectedFileLabel"
        Me.lblSelectedFileLabel.Size = New System.Drawing.Size(119, 20)
        Me.lblSelectedFileLabel.TabIndex = 10
        Me.lblSelectedFileLabel.Text = "Selected File:"
        '
        'lblSelectedFile
        '
        Me.lblSelectedFile.AutoSize = True
        Me.lblSelectedFile.Location = New System.Drawing.Point(313, 227)
        Me.lblSelectedFile.Name = "lblSelectedFile"
        Me.lblSelectedFile.Size = New System.Drawing.Size(47, 20)
        Me.lblSelectedFile.TabIndex = 11
        Me.lblSelectedFile.Text = "None"
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(32, 293)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(130, 37)
        Me.btnImport.TabIndex = 13
        Me.btnImport.Text = "Import new file"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(151, 25)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(183, 37)
        Me.btnUpdate.TabIndex = 14
        Me.btnUpdate.Text = "Update selected file"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(341, 25)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(130, 37)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "Delete File"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSets
        '
        Me.btnSets.Location = New System.Drawing.Point(510, 293)
        Me.btnSets.Name = "btnSets"
        Me.btnSets.Size = New System.Drawing.Size(133, 37)
        Me.btnSets.TabIndex = 16
        Me.btnSets.Text = "Import Set"
        Me.btnSets.UseVisualStyleBackColor = True
        '
        'ctnFileControl
        '
        Me.ctnFileControl.Controls.Add(Me.btnDelete)
        Me.ctnFileControl.Controls.Add(Me.btnUpdate)
        Me.ctnFileControl.Location = New System.Drawing.Point(17, 268)
        Me.ctnFileControl.Name = "ctnFileControl"
        Me.ctnFileControl.Size = New System.Drawing.Size(641, 72)
        Me.ctnFileControl.TabIndex = 17
        Me.ctnFileControl.TabStop = False
        Me.ctnFileControl.Text = "File Controls"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(216, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Estimated total time (min):"
        '
        'lblTotalMin
        '
        Me.lblTotalMin.AutoSize = True
        Me.lblTotalMin.Location = New System.Drawing.Point(408, 74)
        Me.lblTotalMin.Name = "lblTotalMin"
        Me.lblTotalMin.Size = New System.Drawing.Size(27, 20)
        Me.lblTotalMin.TabIndex = 19
        Me.lblTotalMin.Text = "00"
        '
        'btnStocks
        '
        Me.btnStocks.Location = New System.Drawing.Point(32, 376)
        Me.btnStocks.Name = "btnStocks"
        Me.btnStocks.Size = New System.Drawing.Size(176, 37)
        Me.btnStocks.TabIndex = 20
        Me.btnStocks.Text = "Import mtgStock"
        Me.btnStocks.UseVisualStyleBackColor = True
        '
        'gbxOnline
        '
        Me.gbxOnline.Controls.Add(Me.btnCase)
        Me.gbxOnline.Location = New System.Drawing.Point(17, 351)
        Me.gbxOnline.Name = "gbxOnline"
        Me.gbxOnline.Size = New System.Drawing.Size(402, 72)
        Me.gbxOnline.TabIndex = 22
        Me.gbxOnline.TabStop = False
        Me.gbxOnline.Text = "Internet Controls"
        '
        'btnCase
        '
        Me.btnCase.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCase.Location = New System.Drawing.Point(213, 25)
        Me.btnCase.Name = "btnCase"
        Me.btnCase.Size = New System.Drawing.Size(179, 37)
        Me.btnCase.TabIndex = 14
        Me.btnCase.Text = "Import case sheet"
        Me.btnCase.UseVisualStyleBackColor = True
        '
        'btnDebug
        '
        Me.btnDebug.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDebug.Location = New System.Drawing.Point(440, 351)
        Me.btnDebug.Name = "btnDebug"
        Me.btnDebug.Size = New System.Drawing.Size(211, 72)
        Me.btnDebug.TabIndex = 15
        Me.btnDebug.Text = "Open Debug Menu"
        Me.btnDebug.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(475, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(176, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 443)
        Me.Controls.Add(Me.btnDebug)
        Me.Controls.Add(Me.btnStocks)
        Me.Controls.Add(Me.gbxOnline)
        Me.Controls.Add(Me.lblTotalMin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSets)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.lblSelectedFile)
        Me.Controls.Add(Me.lblSelectedFileLabel)
        Me.Controls.Add(Me.btnSelectFile)
        Me.Controls.Add(Me.lblSelectFile)
        Me.Controls.Add(Me.lblSeconds)
        Me.Controls.Add(Me.lblSecondsLabel)
        Me.Controls.Add(Me.lsbFiles)
        Me.Controls.Add(Me.trkSpeed)
        Me.Controls.Add(Me.btnStep3)
        Me.Controls.Add(Me.btnStep2)
        Me.Controls.Add(Me.btnStep1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ctnFileControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "MTG Card Pricer"
        CType(Me.trkSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctnFileControl.ResumeLayout(False)
        Me.gbxOnline.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStep1 As Button
    Friend WithEvents btnStep2 As Button
    Friend WithEvents btnStep3 As Button
    Friend WithEvents trkSpeed As TrackBar
    Friend WithEvents lsbFiles As ListBox
    Friend WithEvents lblSecondsLabel As Label
    Friend WithEvents lblSeconds As Label
    Friend WithEvents lblSelectFile As Label
    Friend WithEvents btnSelectFile As Button
    Friend WithEvents lblSelectedFileLabel As Label
    Friend WithEvents lblSelectedFile As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnImport As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSets As Button
    Friend WithEvents ctnFileControl As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotalMin As Label
    Friend WithEvents btnStocks As Button
    Friend WithEvents gbxOnline As GroupBox
    Friend WithEvents btnCase As Button
    Friend WithEvents btnDebug As Button
End Class
