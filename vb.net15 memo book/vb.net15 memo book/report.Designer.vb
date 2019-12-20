<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class report
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
        Me.btnTodoList = New System.Windows.Forms.Button()
        Me.btnContactList = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtExit = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'btnTodoList
        '
        Me.btnTodoList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTodoList.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnTodoList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnTodoList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTodoList.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTodoList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnTodoList.Location = New System.Drawing.Point(36, 146)
        Me.btnTodoList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnTodoList.Name = "btnTodoList"
        Me.btnTodoList.Size = New System.Drawing.Size(281, 53)
        Me.btnTodoList.TabIndex = 0
        Me.btnTodoList.TabStop = False
        Me.btnTodoList.Text = "Todo List"
        Me.btnTodoList.UseVisualStyleBackColor = True
        '
        'btnContactList
        '
        Me.btnContactList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnContactList.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnContactList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnContactList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContactList.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContactList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnContactList.Location = New System.Drawing.Point(36, 79)
        Me.btnContactList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnContactList.Name = "btnContactList"
        Me.btnContactList.Size = New System.Drawing.Size(281, 53)
        Me.btnContactList.TabIndex = 0
        Me.btnContactList.TabStop = False
        Me.btnContactList.Text = "Contact List"
        Me.btnContactList.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 30)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Report"
        '
        'txtExit
        '
        Me.txtExit.AutoSize = True
        Me.txtExit.BackColor = System.Drawing.Color.Red
        Me.txtExit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtExit.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExit.ForeColor = System.Drawing.Color.White
        Me.txtExit.Location = New System.Drawing.Point(312, 9)
        Me.txtExit.Name = "txtExit"
        Me.txtExit.Padding = New System.Windows.Forms.Padding(2)
        Me.txtExit.Size = New System.Drawing.Size(25, 27)
        Me.txtExit.TabIndex = 5
        Me.txtExit.Text = "X"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(349, 249)
        Me.Panel1.TabIndex = 6
        '
        'report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(349, 249)
        Me.Controls.Add(Me.txtExit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnTodoList)
        Me.Controls.Add(Me.btnContactList)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "report"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTodoList As System.Windows.Forms.Button
    Friend WithEvents btnContactList As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtExit As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
