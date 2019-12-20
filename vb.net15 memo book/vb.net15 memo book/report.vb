Public Class report

    Private Sub txtExit_Click(sender As Object, e As EventArgs) Handles txtExit.Click
        Close()
        Form1.Show()

    End Sub

    Private Sub btnContactList_Click(sender As Object, e As EventArgs) Handles btnContactList.Click
        reportContact.Show()

    End Sub

    Private Sub btnTodoList_Click(sender As Object, e As EventArgs) Handles btnTodoList.Click
        reportTodo.Show()

    End Sub

    Private Sub report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Hide()

    End Sub
End Class