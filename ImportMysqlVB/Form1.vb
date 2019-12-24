Imports MySql.Data.MySqlClient

Public Class Form1

    Public Sub btn_Import_Click(sender As Object, e As EventArgs) Handles btn_Import.Click

        Dim conStr As String = "server=127.0.0.1;user id=root;database=prod"
        Dim Con As New MySqlConnection(conStr)
        Dim obj As MySqlCommand
        Dim nomtable As String = txt_nomTable.Text
        Dim strSQL As String

        '   obj = Con.CreateCommand()
        Con = New MySqlConnection(conStr)
        Con.Open()
        obj = Con.CreateCommand()
        Try
            strSQL = "SELECT * FROM " & nomtable & ""

            Dim Search As New MySqlDataAdapter(strSQL, Con)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, nomtable)
            DataGridView1.DataSource = ds.Tables(nomtable)
            Con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Con.Close()
        End Try

    End Sub

End Class
