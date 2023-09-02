Public Class Seller_Dash

    Sub switchpanel(ByVal panel As Form)
        gpanel1.Controls.Clear()
        panel.TopLevel = False
        gpanel1.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub btnBilling_Click(sender As Object, e As EventArgs) Handles btnBilling.Click
        switchpanel(Billing)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Login.Show()
        Me.Hide()
    End Sub
End Class