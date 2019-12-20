Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class reportTodo
    Dim memo As New Memo
    Dim query As String
   

    Private Sub reportTodo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        memo.showrecord("SELECT *FROM todoList", dgvTodoList)

    End Sub


    Private Sub txtExit_Click_1(sender As Object, e As EventArgs) Handles txtExit.Click
        Close()

    End Sub

    Private Sub dgvTodoList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTodoList.CellContentClick

    End Sub

    Private Sub dgvTodoList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTodoList.CellDoubleClick
        todo.Show()
        
    End Sub


End Class