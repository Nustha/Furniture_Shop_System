Imports MySql.Data.MySqlClient
Public Class ItemEntry
    Private Sub clear()
        txtItemName.Clear()
        txtItemPrice.Clear()
        cmbCategory.SelectedIndex = 0
        txtItemName.Select()
    End Sub

    Private Sub ItemEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        displayTable()
    End Sub

    Private Sub setView()
        Dim row As DataGridViewRow = dgvItemsEntry.CurrentRow
        Try
            txtItemName.Text = row.Cells(1).Value.ToString()
            txtItemPrice.Text = row.Cells(2).Value.ToString()
            cmbCategory.SelectedItem = row.Cells(3).Value.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub displayTable()
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("select * from item_entrytbl", constring)
        adapter.Fill(table)
        dgvItemsEntry.DataSource = table

    End Sub
    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Try

            cm = New MySqlCommand("INSERT INTO `item_entrytbl`(`Item_Name`, `Price`, `Category`) VALUES ('" & txtItemName.Text & "','" & Val(txtItemPrice.Text) & "','" & cmbCategory.SelectedItem.ToString & "')", constring)
            cm.ExecuteNonQuery()
            MsgBox("New Item Added ")
            displayTable()
            clear()

        Catch ex As Exception
            MsgBox("Cann't Added")
        End Try
    End Sub

    Private Sub btnEditItem_Click(sender As Object, e As EventArgs) Handles btnEditItem.Click
        Dim row As DataGridViewRow = dgvItemsEntry.CurrentRow

        Try
            cm = New MySqlCommand("UPDATE `item_entrytbl` SET `Item_Name`='" & txtItemName.Text & "',`Price`='" & Val(txtItemPrice.Text) & "',`Category`='" & cmbCategory.SelectedItem.ToString & "' WHERE Item_ID='" & row.Cells(0).Value.ToString() & "'", constring)
            cm.ExecuteNonQuery()
            MsgBox("Successfully Updated")
            displayTable()
            clear()
        Catch ex As Exception
            MsgBox("Can't Update")
        End Try
    End Sub

    Private Sub btnDelItem_Click(sender As Object, e As EventArgs) Handles btnDelItem.Click
        Dim row As DataGridViewRow = dgvItemsEntry.CurrentRow

        Try
            cm = New MySqlCommand(" DELETE FROM `item_entrytbl`WHERE Item_ID='" & row.Cells(0).Value.ToString() & "'", constring)
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

    Private Sub dgvItemsEntry_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItemsEntry.CellContentClick
        setView()
    End Sub
End Class