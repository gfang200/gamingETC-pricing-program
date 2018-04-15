<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class setSelector
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(setSelector))
        Me.lsbSets = New System.Windows.Forms.ListBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnJson = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblSets = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lsbSets
        '
        Me.lsbSets.FormattingEnabled = True
        Me.lsbSets.ItemHeight = 20
        Me.lsbSets.Location = New System.Drawing.Point(12, 28)
        Me.lsbSets.Name = "lsbSets"
        Me.lsbSets.Size = New System.Drawing.Size(376, 264)
        Me.lsbSets.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(12, 298)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(262, 26)
        Me.txtSearch.TabIndex = 1
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(12, 335)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(128, 35)
        Me.btnSelect.TabIndex = 3
        Me.btnSelect.Text = "Import Setlist"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(146, 335)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(97, 35)
        Me.btnRefresh.TabIndex = 4
        Me.btnRefresh.Text = "Reset"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnJson
        '
        Me.btnJson.Location = New System.Drawing.Point(249, 335)
        Me.btnJson.Name = "btnJson"
        Me.btnJson.Size = New System.Drawing.Size(137, 35)
        Me.btnJson.TabIndex = 5
        Me.btnJson.Text = "Update JSON"
        Me.btnJson.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(280, 295)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(106, 35)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblSets
        '
        Me.lblSets.AutoSize = True
        Me.lblSets.Location = New System.Drawing.Point(13, 5)
        Me.lblSets.Name = "lblSets"
        Me.lblSets.Size = New System.Drawing.Size(109, 20)
        Me.lblSets.TabIndex = 7
        Me.lblSets.Text = "Available Sets"
        '
        'setSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 387)
        Me.Controls.Add(Me.lblSets)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnJson)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lsbSets)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "setSelector"
        Me.Text = "Set Selector"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lsbSets As ListBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSelect As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnJson As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblSets As Label
End Class
