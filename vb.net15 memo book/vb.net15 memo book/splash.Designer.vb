<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class splash
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pBar = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtLoading = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe Script", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(204, 304)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(15)
        Me.Label1.Size = New System.Drawing.Size(264, 87)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Memo Book"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(449, 349)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(15)
        Me.Label2.Size = New System.Drawing.Size(84, 43)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ver.0.1.1.01"
        '
        'pBar
        '
        Me.pBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pBar.Location = New System.Drawing.Point(0, 467)
        Me.pBar.Name = "pBar"
        Me.pBar.Size = New System.Drawing.Size(738, 23)
        Me.pBar.TabIndex = 2
        Me.pBar.Visible = False
        '
        'Timer1
        '
        '
        'txtLoading
        '
        Me.txtLoading.AutoSize = True
        Me.txtLoading.BackColor = System.Drawing.Color.Transparent
        Me.txtLoading.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoading.ForeColor = System.Drawing.Color.Black
        Me.txtLoading.Location = New System.Drawing.Point(352, 447)
        Me.txtLoading.Name = "txtLoading"
        Me.txtLoading.Size = New System.Drawing.Size(141, 17)
        Me.txtLoading.TabIndex = 1
        Me.txtLoading.Text = "Loading . . .                "
        Me.txtLoading.Visible = False
        '
        'splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.vb.net15_memo_book.My.Resources.Resources.mem1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(738, 490)
        Me.Controls.Add(Me.txtLoading)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pBar)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "splash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "splash"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pBar As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtLoading As System.Windows.Forms.Label
End Class
