Public Class Seller

    Private Sub btnSellerSignin_Click(sender As Object, e As EventArgs) Handles btnSellerSignin.Click
        Dim a, b As String
        a = txtSellerUsername.Text
        b = txtSellerPassword.Text
        If a = "Seller" And b = "Seller123" Then
            Me.Hide()
            Dim seller1 = New Seller_Dash
            seller1.Show()
        End If
    End Sub
End Class