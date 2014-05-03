<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Candidate
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_image = New System.Windows.Forms.TextBox()
        Me.txt_sponsor = New System.Windows.Forms.TextBox()
        Me.txt_info = New System.Windows.Forms.TextBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_browse = New System.Windows.Forms.Button()
        Me.pb_image = New System.Windows.Forms.PictureBox()
        Me.txt_candidate_no = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgv_candidates = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_candidate_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_sponsor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_info = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.image = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.pb_image, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_candidates, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Image:*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 508)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Sponsor:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 571)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Information:"
        '
        'txt_image
        '
        Me.txt_image.Enabled = False
        Me.txt_image.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_image.Location = New System.Drawing.Point(7, 336)
        Me.txt_image.Name = "txt_image"
        Me.txt_image.Size = New System.Drawing.Size(174, 26)
        Me.txt_image.TabIndex = 1
        '
        'txt_sponsor
        '
        Me.txt_sponsor.Enabled = False
        Me.txt_sponsor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sponsor.Location = New System.Drawing.Point(7, 531)
        Me.txt_sponsor.Name = "txt_sponsor"
        Me.txt_sponsor.Size = New System.Drawing.Size(268, 26)
        Me.txt_sponsor.TabIndex = 1
        '
        'txt_info
        '
        Me.txt_info.Enabled = False
        Me.txt_info.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_info.Location = New System.Drawing.Point(7, 594)
        Me.txt_info.Multiline = True
        Me.txt_info.Name = "txt_info"
        Me.txt_info.Size = New System.Drawing.Size(268, 91)
        Me.txt_info.TabIndex = 1
        '
        'btn_save
        '
        Me.btn_save.Enabled = False
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(464, 501)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(93, 40)
        Me.btn_save.TabIndex = 2
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.Location = New System.Drawing.Point(563, 501)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(93, 40)
        Me.btn_edit.TabIndex = 2
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Enabled = False
        Me.btn_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Location = New System.Drawing.Point(860, 501)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(93, 40)
        Me.btn_cancel.TabIndex = 2
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Enabled = False
        Me.btn_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(662, 501)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(93, 40)
        Me.btn_update.TabIndex = 2
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_browse)
        Me.Panel1.Controls.Add(Me.pb_image)
        Me.Panel1.Controls.Add(Me.txt_candidate_no)
        Me.Panel1.Controls.Add(Me.txt_name)
        Me.Panel1.Controls.Add(Me.txt_image)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txt_sponsor)
        Me.Panel1.Controls.Add(Me.txt_info)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(290, 708)
        Me.Panel1.TabIndex = 3
        '
        'btn_browse
        '
        Me.btn_browse.Enabled = False
        Me.btn_browse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_browse.Location = New System.Drawing.Point(187, 328)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(93, 40)
        Me.btn_browse.TabIndex = 4
        Me.btn_browse.Text = "Browse"
        Me.btn_browse.UseVisualStyleBackColor = True
        '
        'pb_image
        '
        Me.pb_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_image.Location = New System.Drawing.Point(7, 36)
        Me.pb_image.Name = "pb_image"
        Me.pb_image.Size = New System.Drawing.Size(273, 286)
        Me.pb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_image.TabIndex = 3
        Me.pb_image.TabStop = False
        '
        'txt_candidate_no
        '
        Me.txt_candidate_no.Enabled = False
        Me.txt_candidate_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_candidate_no.Location = New System.Drawing.Point(7, 400)
        Me.txt_candidate_no.Name = "txt_candidate_no"
        Me.txt_candidate_no.Size = New System.Drawing.Size(268, 26)
        Me.txt_candidate_no.TabIndex = 1
        '
        'txt_name
        '
        Me.txt_name.Enabled = False
        Me.txt_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(7, 467)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(268, 26)
        Me.txt_name.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 377)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Candidate No.:*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 444)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Name:*"
        '
        'dgv_candidates
        '
        Me.dgv_candidates.AllowUserToAddRows = False
        Me.dgv_candidates.AllowUserToDeleteRows = False
        Me.dgv_candidates.AllowUserToOrderColumns = True
        Me.dgv_candidates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_candidates.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.dgv_candidate_number, Me.dgv_name, Me.dgv_sponsor, Me.dgv_info, Me.image})
        Me.dgv_candidates.Location = New System.Drawing.Point(320, 12)
        Me.dgv_candidates.Name = "dgv_candidates"
        Me.dgv_candidates.ReadOnly = True
        Me.dgv_candidates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_candidates.Size = New System.Drawing.Size(676, 483)
        Me.dgv_candidates.TabIndex = 4
        '
        'id
        '
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'dgv_candidate_number
        '
        Me.dgv_candidate_number.HeaderText = "Candidate No."
        Me.dgv_candidate_number.Name = "dgv_candidate_number"
        Me.dgv_candidate_number.ReadOnly = True
        Me.dgv_candidate_number.Width = 150
        '
        'dgv_name
        '
        Me.dgv_name.HeaderText = "Name"
        Me.dgv_name.Name = "dgv_name"
        Me.dgv_name.ReadOnly = True
        Me.dgv_name.Width = 250
        '
        'dgv_sponsor
        '
        Me.dgv_sponsor.HeaderText = "Sponsor"
        Me.dgv_sponsor.Name = "dgv_sponsor"
        Me.dgv_sponsor.ReadOnly = True
        Me.dgv_sponsor.Width = 250
        '
        'dgv_info
        '
        Me.dgv_info.HeaderText = "Information"
        Me.dgv_info.Name = "dgv_info"
        Me.dgv_info.ReadOnly = True
        Me.dgv_info.Width = 250
        '
        'image
        '
        Me.image.HeaderText = "Image"
        Me.image.Name = "image"
        Me.image.ReadOnly = True
        Me.image.Visible = False
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(761, 501)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(93, 40)
        Me.btn_delete.TabIndex = 2
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(365, 501)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(93, 40)
        Me.btn_add.TabIndex = 2
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.Filter = "All Files |*.*| JPG |*.jpg| PNG |*.png"
        '
        'Candidate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.dgv_candidates)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_cancel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Candidate"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Candidates"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pb_image, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_candidates, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_image As System.Windows.Forms.TextBox
    Friend WithEvents txt_sponsor As System.Windows.Forms.TextBox
    Friend WithEvents txt_info As System.Windows.Forms.TextBox
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents btn_browse As System.Windows.Forms.Button
    Friend WithEvents pb_image As System.Windows.Forms.PictureBox
    Friend WithEvents txt_candidate_no As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgv_candidates As System.Windows.Forms.DataGridView
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_candidate_number As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_sponsor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_info As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents image As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
