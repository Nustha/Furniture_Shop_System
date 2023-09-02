Public Class Admin
    Private Sub btnAdminSignin_Click(sender As Object, e As EventArgs) Handles btnAdminSignin.Click

        Dim a, b As String
        a = txtAdminUsername.Text
        b = txtAdminPassword.Text
        If a = "Admin" And b = "Admin123" Then
            Me.Hide()
            Dim dashboard = New Dashboard
            dashboard.Show()
        End If
    End Sub

    Private Sub GunaLabel1_Click(sender As Object, e As EventArgs) Handles GunaLabel1.Click

    End Sub
End Class