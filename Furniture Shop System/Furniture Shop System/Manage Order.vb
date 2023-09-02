Imports MySql.Data.MySqlClient
Public Class Manage_Order

    Private Sub clear()
        txtOrderID.Clear()
        txtCusName.Clear()

        txtAdvancePay.Clear()

        txtOrderID.Select()
    End Sub

    Private Sub setView()
        Dim row As DataGridViewRow = dgvManageOrder.CurrentRow
        Try
            txtOrderID.Text = row.Cells(1).Value.ToString()
            txtCusName.Text = row.Cells(2).Value.ToString()
            cmbCategory.Text = row.Cells(3).Value.ToString()
            txtAdvancePay.Text = row.Cells(4).Value.ToString()
            gdatetime.Text = row.Cells(5).Value.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub displayTable()
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("select * from manage_order", constring)
        adapter.Fill(table)
        dgvManageOrder.DataSource = table

    End Sub
    Private Sub Manage_Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        displayTable()
    End Sub

    Private Sub btnAddOrder_Click(sender As Object, e As EventArgs) Handles btnAddOrder.Click
        Try

            cm = New MySqlCommand("INSERT INTO `manage_order`(`Order_ID`, `Customer_Name`, `Item_Name`, `Advanced_Payment`, `Payment_Date`) VALUES ('" & txtOrderID.Text & "','" & txtCusName.Text & "','" & cmbCategory.Text & "','" & Val(txtAdvancePay.Text) & "','" & gdatetime.Value.Date.ToString("yyyy/MM/dd") & "')", constring)
            cm.ExecuteNonQuery()
            MsgBox("New Item Added ")
            displayTable()
            clear()

        Catch ex As Exception
            MsgBox("Cann't Added")
        End Try
    End Sub

    Private Sub btnEditOrder_Click(sender As Object, e As EventArgs) Handles btnEditOrder.Click
        Dim row As DataGridViewRow = dgvManageOrder.CurrentRow

        Try
            cm = New MySqlCommand("UPDATE `manage_order` SET `Customer_Name`='" & txtCusName.Text & "',`Item_Name`='" & cmbCategory.Text & "',`Advanced_Payment`='" & Val(txtAdvancePay.Text) & "',`Payment_Date`='" & gdatetime.Value.Date.ToString("dd - mm - yyyy") & "' WHERE `Order_ID`='" & txtOrderID.Text & "')", constring)
            cm.ExecuteNonQuery()
            MsgBox("Successfully Updated")
            displayTable()
            clear()
        Catch ex As Exception
            MsgBox("Can't Update")
        End Try
    End Sub

    Private Sub btnDelOrder_Click(sender As Object, e As EventArgs) Handles btnDelOrder.Click
        Dim row As DataGridViewRow = dgvManageOrder.CurrentRow

        Try
            cm = New MySqlCommand(" DELETE FROM `manage_order`WHERE Order_ID='" & row.Cells(0).Value.ToString() & "'", constring)
            cm.ExecuteNonQuery()
            MsgBox("Successfully Deleted")
            displayTable()
            clear()
        Catch ex As Exception
            MsgBox("Can't Delete")
        End Try
    End Sub

    Private Sub btnClearOrder_Click(sender As Object, e As EventArgs) Handles btnClearOrder.Click
        clear()
    End Sub

    Private Sub dgvManageOrder_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvManageOrder.CellContentClick
        setView()
    End Sub

    Private Sub gdatetime_ValueChanged(sender As Object, e As EventArgs) Handles gdatetime.ValueChanged

       
    End Sub
End Class