Public Class splash

    Private Sub splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        pBar.Show()
        txtLoading.Show()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        pBar.Increment(5)
        If pBar.Value = 100 Then
            Timer1.Stop()
            pBar.Hide()
            txtLoading.Hide()
            'Form1.Show()
            'Close()

        End If
    End Sub
End Class