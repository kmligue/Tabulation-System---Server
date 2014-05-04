<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Elimination
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
        Me.txt_generate = New System.Windows.Forms.TextBox()
        Me.btn_generate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_generate
        '
        Me.txt_generate.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_generate.Location = New System.Drawing.Point(17, 35)
        Me.txt_generate.Name = "txt_generate"
        Me.txt_generate.Size = New System.Drawing.Size(100, 53)
        Me.txt_generate.TabIndex = 0
        '
        'btn_generate
        '
        Me.btn_generate.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_generate.Location = New System.Drawing.Point(123, 35)
        Me.btn_generate.Name = "btn_generate"
        Me.btn_generate.Size = New System.Drawing.Size(211, 53)
        Me.btn_generate.TabIndex = 1
        Me.btn_generate.Text = "Generate"
        Me.btn_generate.UseVisualStyleBackColor = True
        '
        'Elimination
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 125)
        Me.Controls.Add(Me.btn_generate)
        Me.Controls.Add(Me.txt_generate)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Elimination"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elimination"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_generate As System.Windows.Forms.TextBox
    Friend WithEvents btn_generate As System.Windows.Forms.Button
End Class
