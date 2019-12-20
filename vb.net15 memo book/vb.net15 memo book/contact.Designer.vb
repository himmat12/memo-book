<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class contact
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
        Me.txtSN = New System.Windows.Forms.TextBox()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtOffice = New System.Windows.Forms.TextBox()
        Me.btnClaer = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtExit = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SN :"
        '
        'txtSN
        '
        Me.txtSN.Location = New System.Drawing.Point(115, 78)
        Me.txtSN.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtSN.Name = "txtSN"
        Me.txtSN.ReadOnly = True
        Me.txtSN.Size = New System.Drawing.Size(75, 25)
        Me.txtSN.TabIndex = 0
        Me.txtSN.TabStop = False
        '
        'dtpDOB
        '
        Me.dtpDOB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpDOB.Location = New System.Drawing.Point(115, 267)
        Me.dtpDOB.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(388, 25)
        Me.dtpDOB.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(193, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Fullname :"
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(261, 81)
        Me.txtFullName.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(242, 25)
        Me.txtFullName.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Address :"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(115, 125)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(155, 25)
        Me.txtAddress.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Tel :"
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(115, 176)
        Me.txtTel.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(388, 25)
        Me.txtTel.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Mobile :"
        '
        'txtMobile
        '
        Me.txtMobile.Location = New System.Drawing.Point(115, 222)
        Me.txtMobile.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(388, 25)
        Me.txtMobile.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(43, 274)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "DOB :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(273, 129)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Office :"
        '
        'txtOffice
        '
        Me.txtOffice.Location = New System.Drawing.Point(339, 125)
        Me.txtOffice.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtOffice.Name = "txtOffice"
        Me.txtOffice.Size = New System.Drawing.Size(164, 25)
        Me.txtOffice.TabIndex = 2
        '
        'btnClaer
        '
        Me.btnClaer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnClaer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClaer.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClaer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClaer.Location = New System.Drawing.Point(146, 371)
        Me.btnClaer.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnClaer.Name = "btnClaer"
        Me.btnClaer.Size = New System.Drawing.Size(71, 33)
        Me.btnClaer.TabIndex = 8
        Me.btnClaer.Text = "Clear"
        Me.btnClaer.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSave.Location = New System.Drawing.Point(225, 371)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(71, 33)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnUpdate.Location = New System.Drawing.Point(305, 371)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(71, 33)
        Me.btnUpdate.TabIndex = 9
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDelete.Location = New System.Drawing.Point(384, 371)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(71, 33)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(463, 371)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(71, 33)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(41, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(148, 30)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Create contact"
        '
        'txtExit
        '
        Me.txtExit.AutoSize = True
        Me.txtExit.BackColor = System.Drawing.Color.Red
        Me.txtExit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtExit.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExit.ForeColor = System.Drawing.Color.White
        Me.txtExit.Location = New System.Drawing.Point(509, 9)
        Me.txtExit.Name = "txtExit"
        Me.txtExit.Padding = New System.Windows.Forms.Padding(2)
        Me.txtExit.Size = New System.Drawing.Size(25, 27)
        Me.txtExit.TabIndex = 12
        Me.txtExit.Text = "X"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(546, 418)
        Me.Panel2.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(43, 312)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Gender :"
        '
        'cmbGender
        '
        Me.cmbGender.AutoCompleteCustomSource.AddRange(New String() {"Male", "Female"})
        Me.cmbGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(115, 309)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(388, 25)
        Me.cmbGender.TabIndex = 6
        '
        'contact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(546, 418)
        Me.Controls.Add(Me.cmbGender)
        Me.Controls.Add(Me.txtExit)
        Me.Controls.Add(Me.dtpDOB)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClaer)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtMobile)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtOffice)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MaximizeBox = False
        Me.Name = "contact"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "contact"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSN As System.Windows.Forms.TextBox
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtOffice As System.Windows.Forms.TextBox
    Friend WithEvents btnClaer As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtExit As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbGender As System.Windows.Forms.ComboBox
End Class
