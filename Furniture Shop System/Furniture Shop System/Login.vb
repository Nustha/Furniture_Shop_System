Public Class Login

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Admin.Show()
        Me.Hide()

    End Sub

    Private Sub btnSeller_Click(sender As Object, e As EventArgs) Handles btnSeller.Click
        Seller.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogExit_Click(sender As Object, e As EventArgs) Handles btnLogExit.Click
        MsgBox("Do you want to close")
        Application.Exit()
    End Sub
End Class