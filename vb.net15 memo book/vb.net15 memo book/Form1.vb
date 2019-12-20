Public Class Form1
    Dim memo As New Memo

    Private Sub btnNewContact_Click(sender As Object, e As EventArgs) Handles btnNewContact.Click
        contact.Show()

    End Sub

    Private Sub btnTodoList_Click(sender As Object, e As EventArgs) Handles btnTodoList.Click
        todo.Show()

    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        report.Show()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MsgBox("Do you want to exit ?!", MsgBoxStyle.Critical, "Exit")
       
    End Sub

    Private Sub txtExit_Click(sender As Object, e As EventArgs) Handles txtExit.Click
        End

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        memo.showDOB("select *from newContact", "memo", dgvBirthday, panelBirthday)
        memo.showTodoNotification("select * from todoList", "memo", dgvTask, panelTask)

    End Sub

    
    Private Sub txtCloseTaskPanel_Click(sender As Object, e As EventArgs) Handles txtCloseTaskPanel.Click
        panelTask.Hide()

    End Sub

    Private Sub txtCloseBirthdayPanel_Click(sender As Object, e As EventArgs) Handles txtCloseBirthdayPanel.Click
        panelBirthday.Hide()

    End Sub
End Class

