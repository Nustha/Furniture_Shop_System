Imports MySql.Data.MySqlClient
Public Class Stock_Details
    Private Sub clear()
        txtItemName.Clear()
        txtItemQnty.Clear()
        cmbCategory.SelectedIndex = 0
        txtStockID.Clear()
        txtItemName.Select()
    End Sub
    Private Sub setView()
        Dim row As DataGridViewRow = dgvStockDet.CurrentRow
        Try
            txtItemName.Text = row.Cells(1).Value.ToString()
            txtItemQnty.Text = row.Cells(2).Value.ToString()
            cmbCategory.SelectedItem = row.Cells(3).Value.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub displayTable()
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("select * from stock_detailstbl", constring)
        adapter.Fill(table)
        dgvStockDet.DataSource = table

    End Sub
    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Try

            cm = New MySqlCommand("INSERT INTO `stock_detailstbl`(`Item_Name`, `Quantity`, `Item_ID`, `Category`) VALUES ('" & txtItemName.Text & "','" & Val(txtItemQnty.Text) & "','" & txtStockID.Text & "','" & cmbCategory.SelectedItem.ToString() & "')", constring)
            cm.ExecuteNonQuery()
            MsgBox("New Item Added ")
            displayTable()
            clear()

        Catch ex As Exception
            MsgBox("Cann't Added")
        End Try
    End Sub

    Private Sub Stock_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        displayTable()
    End Sub

    Private Sub btnEditItem_Click(sender As Object, e As EventArgs) Handles btnEditItem.Click
        Dim row As DataGridViewRow = dgvStockDet.CurrentRow

        Try
            cm = New MySqlCommand("UPDATE `stock_detailstbl` SET `Item_Name`='" & txtItemName.Text & "',`Quantity`='" & Val(txtItemQnty.Text) & "',`Category`='" & cmbCategory.SelectedItem.ToString() & "' WHERE `Item_ID`='" & Val(txtStockID.Text) & "')", constring)
            cm.ExecuteNonQuery()
            MsgBox("Successfully Updated")
            displayTable()
            clear()
        Catch ex As Exception
            MsgBox("Can't Update")
        End Try
    End Sub

    Private Sub btnDelItem_Click(sender As Object, e As EventArgs) Handles btnDelItem.Click
        Dim row As DataGridViewRow = dgvStockDet.CurrentRow

        Try
            cm = New MySqlCommand(" DELETE FROM `stock_detailstbl`WHERE Item_ID='" & row.Cells(0).Value.ToString() & "'", constring)
            cm.ExecuteNonQuery()
            MsgBox("Successfully Deleted")
            displayTable()
            clear()
        Catch ex As Exception
            MsgBox("Can't Delete")
        End Try
    End Sub


    Private Sub btnClearItem_Click(sender As Object, e As EventArgs) Handles btnClearItem.Click
        clear()

    End Sub

    Private Sub dgvItemsEntry_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStockDet.CellContentClick
        setView()
    End Sub
End Class