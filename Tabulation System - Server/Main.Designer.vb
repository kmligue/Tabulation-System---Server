<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.strip_candidate = New System.Windows.Forms.ToolStripMenuItem()
        Me.JudgeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EventToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CriteriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InquiryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TalentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InterviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SwimwearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FinalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.cb_category = New System.Windows.Forms.ComboBox()
        Me.lbl_event = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.OverallToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.InquiryToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.strip_candidate, Me.JudgeToolStripMenuItem, Me.EventToolStripMenuItem, Me.CriteriaToolStripMenuItem, Me.TopToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'strip_candidate
        '
        Me.strip_candidate.Name = "strip_candidate"
        Me.strip_candidate.Size = New System.Drawing.Size(128, 22)
        Me.strip_candidate.Text = "Candidate"
        '
        'JudgeToolStripMenuItem
        '
        Me.JudgeToolStripMenuItem.Name = "JudgeToolStripMenuItem"
        Me.JudgeToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.JudgeToolStripMenuItem.Text = "Judge"
        '
        'EventToolStripMenuItem
        '
        Me.EventToolStripMenuItem.Name = "EventToolStripMenuItem"
        Me.EventToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.EventToolStripMenuItem.Text = "Event"
        '
        'CriteriaToolStripMenuItem
        '
        Me.CriteriaToolStripMenuItem.Name = "CriteriaToolStripMenuItem"
        Me.CriteriaToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.CriteriaToolStripMenuItem.Text = "Criteria"
        Me.CriteriaToolStripMenuItem.Visible = False
        '
        'TopToolStripMenuItem
        '
        Me.TopToolStripMenuItem.Name = "TopToolStripMenuItem"
        Me.TopToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.TopToolStripMenuItem.Text = "Top"
        '
        'InquiryToolStripMenuItem
        '
        Me.InquiryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GownToolStripMenuItem, Me.TalentToolStripMenuItem, Me.InterviewToolStripMenuItem, Me.SwimwearToolStripMenuItem, Me.OverallToolStripMenuItem, Me.ToolStripMenuItem1, Me.FinalToolStripMenuItem})
        Me.InquiryToolStripMenuItem.Name = "InquiryToolStripMenuItem"
        Me.InquiryToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.InquiryToolStripMenuItem.Text = "Inquiry"
        '
        'GownToolStripMenuItem
        '
        Me.GownToolStripMenuItem.Name = "GownToolStripMenuItem"
        Me.GownToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GownToolStripMenuItem.Text = "Gown"
        '
        'TalentToolStripMenuItem
        '
        Me.TalentToolStripMenuItem.Name = "TalentToolStripMenuItem"
        Me.TalentToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TalentToolStripMenuItem.Text = "Talent"
        '
        'InterviewToolStripMenuItem
        '
        Me.InterviewToolStripMenuItem.Name = "InterviewToolStripMenuItem"
        Me.InterviewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.InterviewToolStripMenuItem.Text = "Interview"
        '
        'SwimwearToolStripMenuItem
        '
        Me.SwimwearToolStripMenuItem.Name = "SwimwearToolStripMenuItem"
        Me.SwimwearToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SwimwearToolStripMenuItem.Text = "Swimwear"
        '
        'FinalToolStripMenuItem
        '
        Me.FinalToolStripMenuItem.Name = "FinalToolStripMenuItem"
        Me.FinalToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FinalToolStripMenuItem.Text = "Final"
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Location = New System.Drawing.Point(12, 95)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView.Size = New System.Drawing.Size(984, 600)
        Me.DataGridView.TabIndex = 3
        '
        'cb_category
        '
        Me.cb_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_category.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_category.FormattingEnabled = True
        Me.cb_category.Location = New System.Drawing.Point(767, 20)
        Me.cb_category.Name = "cb_category"
        Me.cb_category.Size = New System.Drawing.Size(204, 28)
        Me.cb_category.TabIndex = 4
        '
        'lbl_event
        '
        Me.lbl_event.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_event.Location = New System.Drawing.Point(396, 20)
        Me.lbl_event.Name = "lbl_event"
        Me.lbl_event.Size = New System.Drawing.Size(195, 31)
        Me.lbl_event.TabIndex = 5
        Me.lbl_event.Text = "Event"
        Me.lbl_event.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.cb_category)
        Me.Panel1.Controls.Add(Me.lbl_event)
        Me.Panel1.Location = New System.Drawing.Point(12, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 64)
        Me.Panel1.TabIndex = 6
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
        '
        'OverallToolStripMenuItem
        '
        Me.OverallToolStripMenuItem.Name = "OverallToolStripMenuItem"
        Me.OverallToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OverallToolStripMenuItem.Text = "Overall"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents strip_candidate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JudgeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EventToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CriteriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InquiryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GownToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TalentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InterviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SwimwearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FinalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents cb_category As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_event As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OverallToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
End Class
