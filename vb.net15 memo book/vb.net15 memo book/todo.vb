Public Class todo
    Dim memo As New Memo
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click, txtExit.Click
        Close()
        Form1.Show()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        frmVliadte()
        getSN()
        txtTask.Focus()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
       memo.delete("delete from todoList where sn = '" & txtSN.Text & "'  ")
        MsgBox("Todo deleted!", vbInformation, "Delete")
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        memo.update("UPDATE todoList set date ='" & dtpDate.Value & "', task = '" & txtTask.Text & "' where sn = '" & txtSN.Text & "'  ")
        MsgBox("Todo updated!", vbInformation, "Update")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Try
            memo.clear_todo(dtpDate, txtTask)
            txtTask.Focus()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub todo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Hide()
        getSN()

    End Sub

    Private Sub getSN()
        memo.clear_todo(dtpDate, txtTask)
        txtSN.Text = memo.getSn("select top(1) * from todoList order by sn desc", "memo")
        
    End Sub

    Private Sub getInsert()
        memo.insert("INSERT INTO todoList (sn,date,task) VALUES ('" & txtSN.Text & "','" & dtpDate.Value & "','" & txtTask.Text & "') ")
        MsgBox("Todo saved!", vbInformation, "ToDo")

    End Sub

    Private Sub frmVliadte()
        If txtTask.Text = "" Then
            MsgBox("Please fill up the required feilds completely!!", vbCritical, "Required feild")
            Exit Sub

        Else
            getInsert()

        End If
    End Sub
End Class