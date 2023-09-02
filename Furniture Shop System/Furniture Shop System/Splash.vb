Public Class Splash

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Guna2ProgressBar1.Value = Guna2ProgressBar1.Value + 1
        If Guna2ProgressBar1.Value >= 100 Then
            Timer1.Stop()
            Login.Show()
            Me.Hide()
        End If
    End Sub
End Class