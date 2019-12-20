
Public Class contact

    Dim memo As New Memo

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click, txtExit.Click
        Close()
        Form1.Show()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        frmVliadte()
        getSN()
        txtFullName.Focus()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        memo.delete("delete from newContact where sn = '" & txtSN.Text & "' ")
        MsgBox("Contact deleted!", vbInformation, "Delete")
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        memo.update("UPDATE newContact set fullname='" & txtFullName.Text & "',address='" & txtAddress.Text & "',office = '" & txtOffice.Text & "',tel= '" & txtTel.Text & "',mob =  '" & txtMobile.Text & "',dob = '" & dtpDOB.Value & "',gender =  '" & cmbGender.Text & "' where sn = '" & txtSN.Text & "'  ")
        MsgBox("Contact updated!", vbInformation, "Update")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClaer.Click
        memo.clear_contact(txtFullName, txtAddress, txtOffice, txtTel, txtMobile, dtpDOB, cmbGender)
        txtFullName.Focus()

    End Sub

    Private Sub contact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Hide()
        getSN()

    End Sub

    Private Sub getSN()
        memo.clear_contact(txtFullName, txtAddress, txtOffice, txtTel, txtMobile, dtpDOB, cmbGender)
        txtSN.Text = memo.getSn("select top(1) *from newContact  order by sn desc", "memo")
        
    End Sub

    Private Sub getInsert()
        Try
            memo.insert("INSERT INTO newContact (sn,fullname,office,address,tel,mob,dob,gender) VALUES('" & txtSN.Text & "', '" & txtFullName.Text & "','" & txtAddress.Text & "','" & txtOffice.Text & "','" & txtTel.Text & "','" & txtMobile.Text & "','" & dtpDOB.Value & "','" & cmbGender.Text & "' ) ")
            MsgBox("Contact created!", vbInformation, "Conatct")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub

    Private Sub frmVliadte()
        If txtFullName.Text = "" Then
            MsgBox("Please fill up the required feilds completely!!", vbCritical, "Required feild")
            Exit Sub
        ElseIf txtAddress.Text = "" Then
            MsgBox("Please fill up the required feilds completely!!", vbCritical, "Required feild")
            Exit Sub
        ElseIf txtOffice.Text = "" Then
            MsgBox("Please fill up the required feilds completely!!", vbCritical, "Required feild")
            Exit Sub
        ElseIf txtTel.Text = "" Then
            MsgBox("Please fill up the required feilds completely!!", vbCritical, "Required feild")
            Exit Sub
        ElseIf txtMobile.Text = "" Then
            MsgBox("Please fill up the required feilds completely!!", vbCritical, "Required feild")
            Exit Sub
        ElseIf cmbGender.Text = "" Then
            MsgBox("Please fill up the required feilds completely!!", vbCritical, "Required feild")
            Exit Sub
        Else
            getInsert()

        End If
    End Sub

End Class