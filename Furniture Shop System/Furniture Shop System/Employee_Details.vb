Imports MySql.Data.MySqlClient
Public Class Employee_Details

    Private Sub clear()
        txtEmpID.Clear()
        txtEmpName.Clear()
        txtEmpPhoneno.Clear()
        txtEmpPosition.Clear()
        txtEmpDescribe.Clear()
        txtEmpID.Select()
    End Sub
    Private Sub setView()
        Dim row As DataGridViewRow = dgvEmpDetail.CurrentRow
        Try
            txtEmpID.Text = row.Cells(1).Value.ToString()
            txtEmpName.Text = row.Cells(2).Value.ToString()
            txtEmpPhoneno.Text = row.Cells(3).Value.ToString()
            txtEmpPosition.Text = row.Cells(4).Value.ToString()
            txtEmpDescribe.Text = row.Cells(5).Value.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub displayTable()
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("select * from employee_detailstbl", constring)
        adapter.Fill(table)
        dgvEmpDetail.DataSource = table

    End Sub

    Private Sub Employee_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        displayTable()
    End Sub

    Private Sub btnAddEmp_Click(sender As Object, e As EventArgs) Handles btnAddEmp.Click
        Try

            cm = New MySqlCommand("INSERT INTO `employee_detailstbl`(`Emp_ID`, `Emp_Name`, `Phone_No`, `Position`, `Description`) VALUES ('" & txtEmpID.Text & "','" & txtEmpName.Text & "','" & txtEmpPhoneno.Text & "','" & txtEmpPosition.Text & "','" & txtEmpDescribe.Text & "')", constring)
            cm.ExecuteNonQuery()
            MsgBox("New Item Added ")
            displayTable()
            clear()

        Catch ex As Exception
            MsgBox("Cann't Added")
        End Try
    End Sub

    Private Sub btnDelEmp_Click(sender As Object, e As EventArgs) Handles btnDelEmp.Click
        Dim row As DataGridViewRow = dgvEmpDetail.CurrentRow

        Try
            cm = New MySqlCommand(" DELETE FROM `employee_detailstbl`WHERE Emp_ID='" & row.Cells(0).Value.ToString() & "'", constring)
            cm.ExecuteNonQuery()
            MsgBox("Successfully Deleted")
            displayTable()
            clear()
        Catch ex As Exception
            MsgBox("Can't Delete")
        End Try
    End Sub

    Private Sub btnEditEmp_Click(sender As Object, e As EventArgs) Handles btnEditEmp.Click
        Dim row As DataGridViewRow = dgvEmpDetail.CurrentRow

        Try
            cm = New MySqlCommand("UPDATE `employee_detailstbl` SET `Emp_Name`='" & txtEmpName.Text & "',`Phone_No`='" & txtEmpPhoneno.Text & "',`Description`='" & txtEmpDescribe.Text & "' WHERE `Item_ID`='" & txtEmpID.Text & "')", constring)
            cm.ExecuteNonQuery()
            MsgBox("Successfully Updated")
            displayTable()
            clear()
        Catch ex As Exception
            MsgBox("Can't Update")
        End Try
    End Sub

    Private Sub btnClearEmp_Click(sender As Object, e As EventArgs) Handles btnClearEmp.Click
        clear()
    End Sub

    Private Sub dgvEmpDetail_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpDetail.CellContentClick
        setView()
    End Sub
End Class