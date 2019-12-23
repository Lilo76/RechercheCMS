Imports System.IO
Imports MySql.Data.MySqlClient


Public Class Form1
    Private Sub Btn_page_import_Click(sender As Object, e As EventArgs) Handles Btn_page_import.Click
        Dim selectedFile As String = String.Empty
        OpenFileDialog1.Title = "Choisissez "
        OpenFileDialog1.Filter = "csv|*.csv"
        OpenFileDialog1.FilterIndex = 1
        OpenFileDialog1.InitialDirectory = "G:\Recherche\Chargement prog\"
        OpenFileDialog1.ShowDialog()

        ' Pour insérer l'emplacement du fichier choisi dans le TextBox
        selectedFile = OpenFileDialog1.FileName

        If (selectedFile IsNot Nothing) Then
            TxtBox_Dir.Text = selectedFile
        End If

        Dim dt As New DataTable
        Dim SR As StreamReader = File.OpenText(TxtBox_Dir.Text) '
        Dim newline() As String = SR.ReadLine.Split(";")

        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        '   Controls.Add(DataGridView1)

        dt.Columns.AddRange({New DataColumn(newline(0)), New DataColumn(newline(1)), New DataColumn(newline(2)), New DataColumn(newline(3)),
                            New DataColumn(newline(4)), New DataColumn(newline(5)), New DataColumn(newline(6)), New DataColumn(newline(7)),
                            New DataColumn(newline(8)), New DataColumn(newline(9)), New DataColumn(newline(10)), New DataColumn(newline(11)),
                            New DataColumn(newline(12)), New DataColumn(newline(13))})
        While (Not SR.EndOfStream)
            newline = SR.ReadLine.Split(";")
            Dim newrow As DataRow = dt.NewRow
            newrow.ItemArray = {newline(0), newline(1), newline(2), newline(3), newline(4), newline(5), newline(6), newline(7), newline(8), newline(9), newline(10),
                newline(11), newline(12), newline(13)}
            dt.Rows.Add(newrow)
        End While
        DataGridView1.DataSource = dt

    End Sub


    Private Sub btnCreateTbl_Click(sender As Object, e As EventArgs) Handles btnCreateTbl.Click
        Dim conStr As String = "server=127.0.0.1;user id=root;database=prod"
        Dim objCon As New MySqlConnection(conStr)
        Dim obj As MySqlCommand
        Dim strSQL As String

        conStr = "server=127.0.0.1;user id=root;database=prod"
        objCon = New MySqlConnection(conStr)
        objCon.Open()
        obj = objCon.CreateCommand()
        Dim nomtable As String = txt_nomTable.Text
        strSQL = "CREATE TABLE " & nomtable & " (id int(4) NOT NULL, mach VARCHAR (25), pos int(4), part int(4), num int(12), feeder VARCHAR (25), type VARCHAR (25), width int(4), feed VARCHAR (25), pitch VARCHAR (25), nbPart int(4), height VARCHAR (25), status VARCHAR (25), qty int(4))"
        ' Execute
        obj.CommandText = strSQL
        Try
            obj.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        objCon.Close()
        objCon = Nothing
    End Sub



    Private Sub Btn_CreateUpdate2_Click(sender As Object, e As EventArgs) Handles Btn_CreateUpdate2.Click

        For index As Integer = 0 To DataGridView1.RowCount - 2

            Dim nomtable As String = txt_nomTable.Text
            Dim connectionString = "server=127.0.0.1;user id=root;database=prod"
            Dim query0 = "insert into " & nomtable & "(Id,Mach,Pos,Part,Num,Feeder,Type,Width,Feed,Pitch,NbPart,Height,Status,Qty) values(@Id,@Mach,@Pos,@Part,@Num,@Feeder,@Type,@Width,@Feed,@Pitch,@NbPart,@Height,@Status,@Qty)"
            Dim connection0 As New MySqlConnection(connectionString)
            Dim command0 As New MySqlCommand(query0, connection0)


            command0.Parameters.AddWithValue("@Id", DataGridView1.Rows(index).Cells(0).Value)
            command0.Parameters.AddWithValue("@Mach", DataGridView1.Rows(index).Cells(1).Value)
            command0.Parameters.AddWithValue("@Pos", DataGridView1.Rows(index).Cells(2).Value)
            command0.Parameters.AddWithValue("@Part", DataGridView1.Rows(index).Cells(3).Value)
            command0.Parameters.AddWithValue("@Num", DataGridView1.Rows(index).Cells(4).Value)
            command0.Parameters.AddWithValue("@Feeder", DataGridView1.Rows(index).Cells(5).Value)
            command0.Parameters.AddWithValue("@Type", DataGridView1.Rows(index).Cells(6).Value)
            command0.Parameters.AddWithValue("@Width", DataGridView1.Rows(index).Cells(7).Value)
            command0.Parameters.AddWithValue("@Feed", DataGridView1.Rows(index).Cells(8).Value)
            command0.Parameters.AddWithValue("@Pitch", DataGridView1.Rows(index).Cells(9).Value)
            command0.Parameters.AddWithValue("@NbPart", DataGridView1.Rows(index).Cells(10).Value)
            command0.Parameters.AddWithValue("@Height", DataGridView1.Rows(index).Cells(11).Value)
            command0.Parameters.AddWithValue("@Status", DataGridView1.Rows(index).Cells(12).Value)
            command0.Parameters.AddWithValue("@Qty", DataGridView1.Rows(index).Cells(13).Value)

            connection0.Open()
            command0.Connection = connection0
            command0.ExecuteNonQuery()

        Next
    End Sub
End Class


