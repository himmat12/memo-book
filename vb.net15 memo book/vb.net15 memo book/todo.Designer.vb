<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class todo
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtSN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTask = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtExit = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(439, 261)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(62, 31)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDelete.Location = New System.Drawing.Point(371, 261)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(62, 31)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnUpdate.Location = New System.Drawing.Point(303, 261)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(62, 31)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSave.Location = New System.Drawing.Point(235, 261)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(62, 31)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClear.Location = New System.Drawing.Point(167, 261)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(62, 31)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtSN
        '
        Me.txtSN.Location = New System.Drawing.Point(102, 84)
        Me.txtSN.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
        Me.txtSN.Name = "txtSN"
        Me.txtSN.ReadOnly = True
        Me.txtSN.Size = New System.Drawing.Size(67, 25)
        Me.txtSN.TabIndex = 0
        Me.txtSN.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 17)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "SN :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Task :"
        '
        'txtTask
        '
        Me.txtTask.Location = New System.Drawing.Point(102, 123)
        Me.txtTask.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
        Me.txtTask.Multiline = True
        Me.txtTask.Name = "txtTask"
        Me.txtTask.Size = New System.Drawing.Size(372, 82)
        Me.txtTask.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(196, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 17)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Date :"
        '
        'dtpDate
        '
        Me.dtpDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpDate.Location = New System.Drawing.Point(262, 84)
        Me.dtpDate.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(212, 25)
        Me.dtpDate.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(33, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(161, 30)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Create schedule"
        '
        'txtExit
        '
        Me.txtExit.AutoSize = True
        Me.txtExit.BackColor = System.Drawing.Color.Red
        Me.txtExit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtExit.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExit.ForeColor = System.Drawing.Color.White
        Me.txtExit.Location = New System.Drawing.Point(476, 9)
        Me.txtExit.Name = "txtExit"
        Me.txtExit.Padding = New System.Windows.Forms.Padding(2)
        Me.txtExit.Size = New System.Drawing.Size(25, 27)
        Me.txtExit.TabIndex = 21
        Me.txtExit.Text = "X"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(513, 308)
        Me.Panel1.TabIndex = 22
        '
        'todo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(513, 308)
        Me.Controls.Add(Me.txtExit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTask)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "todo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "todo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtSN As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTask As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtExit As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
