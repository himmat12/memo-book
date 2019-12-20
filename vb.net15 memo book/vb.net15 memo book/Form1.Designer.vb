<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnTodoList = New System.Windows.Forms.Button()
        Me.btnNewContact = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.panelBirthday = New System.Windows.Forms.Panel()
        Me.dgvBirthday = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCloseBirthdayPanel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.panelTask = New System.Windows.Forms.Panel()
        Me.dgvTask = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCloseTaskPanel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtExit = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.panelBirthday.SuspendLayout()
        CType(Me.dgvBirthday, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.panelTask.SuspendLayout()
        CType(Me.dgvTask, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.btnReport)
        Me.Panel1.Controls.Add(Me.btnTodoList)
        Me.Panel1.Controls.Add(Me.btnNewContact)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(238, 537)
        Me.Panel1.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(26, 465)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(182, 58)
        Me.btnExit.TabIndex = 1
        Me.btnExit.TabStop = False
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReport
        '
        Me.btnReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReport.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnReport.Location = New System.Drawing.Point(-1, 269)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(238, 78)
        Me.btnReport.TabIndex = 1
        Me.btnReport.TabStop = False
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnTodoList
        '
        Me.btnTodoList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTodoList.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnTodoList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnTodoList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTodoList.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTodoList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnTodoList.Location = New System.Drawing.Point(-1, 192)
        Me.btnTodoList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnTodoList.Name = "btnTodoList"
        Me.btnTodoList.Size = New System.Drawing.Size(238, 78)
        Me.btnTodoList.TabIndex = 1
        Me.btnTodoList.TabStop = False
        Me.btnTodoList.Text = "Todo List"
        Me.btnTodoList.UseVisualStyleBackColor = True
        '
        'btnNewContact
        '
        Me.btnNewContact.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewContact.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnNewContact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnNewContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewContact.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewContact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnNewContact.Location = New System.Drawing.Point(-1, 115)
        Me.btnNewContact.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNewContact.Name = "btnNewContact"
        Me.btnNewContact.Size = New System.Drawing.Size(238, 78)
        Me.btnNewContact.TabIndex = 1
        Me.btnNewContact.TabStop = False
        Me.btnNewContact.Text = "New Contact"
        Me.btnNewContact.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(14, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(15)
        Me.Label1.Size = New System.Drawing.Size(205, 63)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Memo Book"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(236, 115)
        Me.Panel6.TabIndex = 1
        '
        'panelBirthday
        '
        Me.panelBirthday.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.panelBirthday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelBirthday.Controls.Add(Me.dgvBirthday)
        Me.panelBirthday.Controls.Add(Me.txtCloseBirthdayPanel)
        Me.panelBirthday.Controls.Add(Me.Label4)
        Me.panelBirthday.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panelBirthday.Location = New System.Drawing.Point(341, 369)
        Me.panelBirthday.Name = "panelBirthday"
        Me.panelBirthday.Size = New System.Drawing.Size(291, 163)
        Me.panelBirthday.TabIndex = 0
        Me.panelBirthday.Visible = False
        '
        'dgvBirthday
        '
        Me.dgvBirthday.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvBirthday.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvBirthday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBirthday.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgvBirthday.Location = New System.Drawing.Point(4, 39)
        Me.dgvBirthday.Name = "dgvBirthday"
        Me.dgvBirthday.Size = New System.Drawing.Size(281, 119)
        Me.dgvBirthday.TabIndex = 5
        '
        'Column1
        '
        Me.Column1.HeaderText = "Birthday list"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 95
        '
        'Column2
        '
        Me.Column2.HeaderText = "Contact"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 75
        '
        'Column3
        '
        Me.Column3.HeaderText = "Gender"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 71
        '
        'txtCloseBirthdayPanel
        '
        Me.txtCloseBirthdayPanel.AutoSize = True
        Me.txtCloseBirthdayPanel.BackColor = System.Drawing.Color.Red
        Me.txtCloseBirthdayPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtCloseBirthdayPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtCloseBirthdayPanel.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCloseBirthdayPanel.ForeColor = System.Drawing.Color.White
        Me.txtCloseBirthdayPanel.Location = New System.Drawing.Point(267, 4)
        Me.txtCloseBirthdayPanel.Name = "txtCloseBirthdayPanel"
        Me.txtCloseBirthdayPanel.Padding = New System.Windows.Forms.Padding(2)
        Me.txtCloseBirthdayPanel.Size = New System.Drawing.Size(19, 21)
        Me.txtCloseBirthdayPanel.TabIndex = 4
        Me.txtCloseBirthdayPanel.Text = "X"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(5, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(3)
        Me.Label4.Size = New System.Drawing.Size(138, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Birthday Remainder"
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = Global.vb.net15_memo_book.My.Resources.Resources.mem1
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.panelTask)
        Me.Panel4.Controls.Add(Me.panelBirthday)
        Me.Panel4.Controls.Add(Me.txtExit)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Font = New System.Drawing.Font("Segoe UI Emoji", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(226, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(654, 537)
        Me.Panel4.TabIndex = 3
        '
        'panelTask
        '
        Me.panelTask.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.panelTask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelTask.Controls.Add(Me.dgvTask)
        Me.panelTask.Controls.Add(Me.txtCloseTaskPanel)
        Me.panelTask.Controls.Add(Me.Label2)
        Me.panelTask.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panelTask.Location = New System.Drawing.Point(34, 369)
        Me.panelTask.Name = "panelTask"
        Me.panelTask.Size = New System.Drawing.Size(291, 163)
        Me.panelTask.TabIndex = 2
        Me.panelTask.Visible = False
        '
        'dgvTask
        '
        Me.dgvTask.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvTask.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTask.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.DataGridViewTextBoxColumn1})
        Me.dgvTask.Location = New System.Drawing.Point(4, 39)
        Me.dgvTask.Name = "dgvTask"
        Me.dgvTask.Size = New System.Drawing.Size(281, 119)
        Me.dgvTask.TabIndex = 5
        '
        'Column4
        '
        Me.Column4.HeaderText = "Date"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 57
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ToDo task list"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 104
        '
        'txtCloseTaskPanel
        '
        Me.txtCloseTaskPanel.AutoSize = True
        Me.txtCloseTaskPanel.BackColor = System.Drawing.Color.Red
        Me.txtCloseTaskPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtCloseTaskPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtCloseTaskPanel.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCloseTaskPanel.ForeColor = System.Drawing.Color.White
        Me.txtCloseTaskPanel.Location = New System.Drawing.Point(267, 4)
        Me.txtCloseTaskPanel.Name = "txtCloseTaskPanel"
        Me.txtCloseTaskPanel.Padding = New System.Windows.Forms.Padding(2)
        Me.txtCloseTaskPanel.Size = New System.Drawing.Size(19, 21)
        Me.txtCloseTaskPanel.TabIndex = 4
        Me.txtCloseTaskPanel.Text = "X"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(5, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(3)
        Me.Label2.Size = New System.Drawing.Size(95, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Today's task "
        '
        'txtExit
        '
        Me.txtExit.AutoSize = True
        Me.txtExit.BackColor = System.Drawing.Color.Red
        Me.txtExit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtExit.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExit.ForeColor = System.Drawing.Color.White
        Me.txtExit.Location = New System.Drawing.Point(614, 8)
        Me.txtExit.Name = "txtExit"
        Me.txtExit.Padding = New System.Windows.Forms.Padding(2)
        Me.txtExit.Size = New System.Drawing.Size(25, 27)
        Me.txtExit.TabIndex = 3
        Me.txtExit.Text = "X"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe Script", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(183, 334)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(15)
        Me.Label3.Size = New System.Drawing.Size(264, 87)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Memo Book"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(880, 537)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelBirthday.ResumeLayout(False)
        Me.panelBirthday.PerformLayout()
        CType(Me.dgvBirthday, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.panelTask.ResumeLayout(False)
        Me.panelTask.PerformLayout()
        CType(Me.dgvTask, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnNewContact As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents btnTodoList As System.Windows.Forms.Button
    Friend WithEvents panelTask As System.Windows.Forms.Panel
    Friend WithEvents panelBirthday As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents txtExit As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgvBirthday As System.Windows.Forms.DataGridView
    Friend WithEvents txtCloseBirthdayPanel As System.Windows.Forms.Label
    Friend WithEvents txtCloseTaskPanel As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvTask As System.Windows.Forms.DataGridView
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
