Public Class Dashboard

    Sub switchpanel(ByVal panel As Form)
        gpanel.Controls.Clear()
        panel.TopLevel = False
        gpanel.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub btnItementry_Click(sender As Object, e As EventArgs) Handles btnItementry.Click
        switchpanel(ItemEntry)

    End Sub

    Private Sub btnAdminLogOut_Click(sender As Object, e As EventArgs) Handles btnAdminLogOut.Click
        Dim obj As New Dashboard
        Login.Show()
        Me.Hide()

    End Sub

    Private Sub btnStockdetail_Click(sender As Object, e As EventArgs) Handles btnStockdetail.Click
        switchpanel(Stock_Details)

    End Sub

    Private Sub btnBillingStatement_Click(sender As Object, e As EventArgs) Handles btnBillingStatement.Click
        switchpanel(Billing_Statement)
    End Sub

    Private Sub btnEmployeeDetails_Click(sender As Object, e As EventArgs) Handles btnEmployeeDetails.Click
        switchpanel(Employee_Details)
    End Sub

    Private Sub btnManageorder_Click(sender As Object, e As EventArgs) Handles btnManageorder.Click
        switchpanel(Manage_Order)
    End Sub
End Class