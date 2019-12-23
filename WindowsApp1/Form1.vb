Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Btn_page_import_Click(sender As Object, e As EventArgs) Handles Btn_page_import.Click
        Dim selectedFile As String = String.Empty
        ' Pour afficher l'OpenFileDialog
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
        'Controls.Add(DataGridView1)

        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ' Me.DataGridView1.Columns.AddRange({Me.IdDataGridViewTextBoxColumn, Me.MachDataGridViewTextBoxColumn, Me.PosDataGridViewTextBoxColumn, Me.PartDataGridViewTextBoxColumn, Me.NumDataGridViewTextBoxColumn, Me.FeederDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.WithsDataGridViewTextBoxColumn, Me.FeedDataGridViewTextBoxColumn, Me.PitchDataGridViewTextBoxColumn, Me.NbPartDataGridViewTextBoxColumn, Me.HeightDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.QtyDataGridViewTextBoxColumn, Me.TrayDataGridViewTextBoxColumn, Me.DirDataGridViewTextBoxColumn, Me.ImageDataGridViewTextBoxColumn})
        ' Me.DataGridView1.Location = New System.Drawing.Point(12, 41)
        '  Me.DataGridView1.Name = "DataGridView1"
        '  Me.DataGridView1.Size = New System.Drawing.Size(1011, 436)
        ' Me.DataGridView1.TabIndex = 0
        Controls.Add(DataGridView1)

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
        '   DataGridView1.Columns(0).Width = 45
        '  DataGridView1.Columns(1).Width = 35
        '  DataGridView1.Columns(2).Width = 35
        ' DataGridView1.Columns(3).Width = 80
    End Sub
    ''' <summary>
    ''' ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' 

    Private Sub btnCreateTbl_Click(sender As Object, e As EventArgs) Handles btnCreateTbl.Click
        Dim conStr As String = "server=127.0.0.1;user id=root;database=prod"
        Dim objCon As New MySqlConnection(conStr)
        Dim obj As MySqlCommand
        Dim strSQL As String

        ' Create the database
        '   objCon.Open()                                               'FONCTIONNE OK FONCTIONNE OK NE PAS TOUCHER
        '    obj = objCon.CreateCommand()
        '  strSQL = "CREATE TABLE People"
        ' Execute
        '   obj.CommandText = strSQL
        '    obj.ExecuteNonQuery()
        ' Create a table

        conStr = "server=127.0.0.1;user id=root;database=prod"
        objCon = New MySqlConnection(conStr)
        objCon.Open()
        obj = objCon.CreateCommand()
        Dim nomtable As String = txt_nomTable.Text
        strSQL = "CREATE TABLE " & nomtable & " (id int(4), mach VARCHAR (25), pos int(4), part int(4), num int(12), feeder VARCHAR (25), type VARCHAR (25), width int(4), feed VARCHAR (25), pitch VARCHAR (25), nbPart int(4), height VARCHAR (25), status VARCHAR (25), qty int(4))"
        ' Execute
        obj.CommandText = strSQL
        Try
            obj.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        objCon.Close()
        objCon = Nothing                                'FONCTIONNE OK FONCTIONNE OK NE PAS TOUCHER
    End Sub


    ''' <summary>
    ''' ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' 

    Private Sub Btn_CreateUpdate_Click(sender As Object, e As EventArgs) Handles Btn_CreateUpdate.Click
        Dim conStr As String = "server=127.0.0.1;user id=root;database=prod"
        Dim objCon As New MySqlConnection(conStr)
        Dim obj As MySqlCommand
        Dim strSQL As String
        Dim id As Integer
        Dim mach As String
        Dim pos As Integer
        Dim part As Integer
        Dim num As Integer
        Dim feeder As String
        Dim type As String
        Dim width As Integer
        Dim feed As String
        Dim pitch As String
        Dim nbPart As Integer
        Dim height As String
        Dim status As String
        Dim qty As Integer

        '   Dim alltxt As String
        '   Dim result As Integer
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        ' Create the database
        '   objCon.Open()                                               
        '    obj = objCon.CreateCommand()
        '  strSQL = "CREATE TABLE People"
        ' Execute
        '   obj.CommandText = strSQL
        '    obj.ExecuteNonQuery()
        ' Create a table

        conStr = "server=127.0.0.1;user id=root;database=prod"
        objCon = New MySqlConnection(conStr)
        objCon.Open()
        obj = objCon.CreateCommand()
        Dim nomtable As String = txt_nomTable.Text
        strSQL = "CREATE TABLE " & nomtable & " (id int(4), mach VARCHAR (25), pos int(4), part int(4), num int(12), feeder VARCHAR (25), type VARCHAR (25), width int(4), feed VARCHAR (25), pitch VARCHAR (25), nbPart int(4), height VARCHAR (25), status VARCHAR (25), qty int(4))"
        ' Execute
        obj.CommandText = strSQL
        Try
            obj.ExecuteNonQuery()


            For i As Integer = 0 To Me.DataGridView1.Rows.Count - 3

                ' field.Add(Me.dtgStructNewTbl.Rows(i).Cells("n_field").Value)
                id = Me.DataGridView1.Rows(i).Cells("IdDataGridViewTextBoxColumn").Value
                mach = Me.DataGridView1.Rows(i).Cells("MachDataGridViewTextBoxColumn").Value
                pos = Me.DataGridView1.Rows(i).Cells("PosDataGridViewTextBoxColumn").Value
                part = Me.DataGridView1.Rows(i).Cells("PartDataGridViewTextBoxColumn").Value
                num = Me.DataGridView1.Rows(i).Cells("NumDataGridViewTextBoxColumn").Value
                feeder = Me.DataGridView1.Rows(i).Cells("FeederDataGridViewTextBoxColumn").Value
                Type = Me.DataGridView1.Rows(i).Cells("TypeDataGridViewTextBoxColumn").Value
                Width = Me.DataGridView1.Rows(i).Cells("WidthDataGridViewTextBoxColumn").Value
                feed = Me.DataGridView1.Rows(i).Cells("FeedDataGridViewTextBoxColumn").Value
                pitch = Me.DataGridView1.Rows(i).Cells("PitchDataGridViewTextBoxColumn").Value
                nbPart = Me.DataGridView1.Rows(i).Cells("NbPartDataGridViewTextBoxColumn").Value
                Height = Me.DataGridView1.Rows(i).Cells("HeightDataGridViewTextBoxColumn").Value
                status = Me.DataGridView1.Rows(i).Cells("StatusDataGridViewTextBoxColumn").Value
                qty = Me.DataGridView1.Rows(i).Cells("QtyDataGridViewTextBoxColumn").Value

                objCon.Open
                cmd = New MySqlCommand("INSERT INTO" & nomtable & "id , mach , pos , part , num , feeder , Type , Width , feed , pitch , nbPart , Height , status , qty , vbNewLine")
                cmd.ExecuteNonQuery()
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        objCon.Close()
    End Sub
End Class


