Imports MySql.Data.MySqlClient

Module DBConnection
    Public constring As MySqlConnection
    Public cm As MySqlCommand

    Sub connect()
        Try
            constring = New MySqlConnection("server=localhost;database=furnitureshop;username=root;password=")
            constring.Open()
            MsgBox("Database connected Successfully")

        Catch ex As Exception
            MsgBox("database not connected")
        End Try
    End Sub
End Module
