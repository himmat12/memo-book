Imports System.Data.SqlClient

Public Class reportContact
    Dim memo As New Memo
    Private Sub txtExit_Click(sender As Object, e As EventArgs) Handles txtExit.Click
        Close()

    End Sub

    Private Sub reportContact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        memo.showrecord("SELECT *FROM newContact", dgvContactList)

    End Sub



End Class

