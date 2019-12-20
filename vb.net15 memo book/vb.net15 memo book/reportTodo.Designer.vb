<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reportTodo
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
        Me.txtExit = New System.Windows.Forms.Label()
        Me.dgvTodoList = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpSearchByDate = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvTodoList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtExit)
        Me.Panel1.Controls.Add(Me.dgvTodoList)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(879, 521)
        Me.Panel1.TabIndex = 0
        '
        'txtExit
        '
        Me.txtExit.AutoSize = True
        Me.txtExit.BackColor = System.Drawing.Color.Red
        Me.txtExit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtExit.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExit.ForeColor = System.Drawing.Color.White
        Me.txtExit.Location = New System.Drawing.Point(841, 8)
        Me.txtExit.Name = "txtExit"
        Me.txtExit.Padding = New System.Windows.Forms.Padding(2)
        Me.txtExit.Size = New System.Drawing.Size(25, 27)
        Me.txtExit.TabIndex = 26
        Me.txtExit.Text = "X"
        '
        'dgvTodoList
        '
        Me.dgvTodoList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvTodoList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTodoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTodoList.Location = New System.Drawing.Point(1, 111)
        Me.dgvTodoList.Name = "dgvTodoList"
        Me.dgvTodoList.Size = New System.Drawing.Size(875, 408)
        Me.dgvTodoList.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 30)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Todo Lists"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(540, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 17)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Search by date :"
        '
        'dtpSearchByDate
        '
        Me.dtpSearchByDate.Location = New System.Drawing.Point(654, 73)
        Me.dtpSearchByDate.Name = "dtpSearchByDate"
        Me.dtpSearchByDate.Size = New System.Drawing.Size(213, 25)
        Me.dtpSearchByDate.TabIndex = 25
        '
        'reportTodo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(879, 521)
        Me.Controls.Add(Me.dtpSearchByDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "reportTodo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "reportTodo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvTodoList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgvTodoList As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpSearchByDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtExit As System.Windows.Forms.Label
End Class
