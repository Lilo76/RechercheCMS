Imports System.IO
Imports MySql.Data.MySqlClient
Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class Form1


    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MachDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FeederDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WidthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FeedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PitchDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NbPartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Btn_page_import = New System.Windows.Forms.Button()
        Me.TxtBox_Dir = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Btn_export = New System.Windows.Forms.Button()
        Me.txtdbname = New System.Windows.Forms.TextBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbdb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txttblName = New System.Windows.Forms.TextBox()
        Me.btnCreateTbl = New System.Windows.Forms.Button()
        Me.btnAddtbl = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.MachDataGridViewTextBoxColumn, Me.PosDataGridViewTextBoxColumn, Me.PartDataGridViewTextBoxColumn, Me.NumDataGridViewTextBoxColumn, Me.FeederDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.WidthDataGridViewTextBoxColumn, Me.FeedDataGridViewTextBoxColumn, Me.PitchDataGridViewTextBoxColumn, Me.NbPartDataGridViewTextBoxColumn, Me.HeightDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.QtyDataGridViewTextBoxColumn})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 115)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(856, 338)
        Me.DataGridView1.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.Width = 40
        '
        'MachDataGridViewTextBoxColumn
        '
        Me.MachDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.MachDataGridViewTextBoxColumn.DataPropertyName = "mach"
        Me.MachDataGridViewTextBoxColumn.HeaderText = "mach"
        Me.MachDataGridViewTextBoxColumn.Name = "MachDataGridViewTextBoxColumn"
        Me.MachDataGridViewTextBoxColumn.Width = 58
        '
        'PosDataGridViewTextBoxColumn
        '
        Me.PosDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.PosDataGridViewTextBoxColumn.DataPropertyName = "pos"
        Me.PosDataGridViewTextBoxColumn.HeaderText = "pos"
        Me.PosDataGridViewTextBoxColumn.Name = "PosDataGridViewTextBoxColumn"
        Me.PosDataGridViewTextBoxColumn.Width = 49
        '
        'PartDataGridViewTextBoxColumn
        '
        Me.PartDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.PartDataGridViewTextBoxColumn.DataPropertyName = "part"
        Me.PartDataGridViewTextBoxColumn.HeaderText = "part"
        Me.PartDataGridViewTextBoxColumn.Name = "PartDataGridViewTextBoxColumn"
        Me.PartDataGridViewTextBoxColumn.Width = 50
        '
        'NumDataGridViewTextBoxColumn
        '
        Me.NumDataGridViewTextBoxColumn.DataPropertyName = "num"
        Me.NumDataGridViewTextBoxColumn.HeaderText = "num"
        Me.NumDataGridViewTextBoxColumn.Name = "NumDataGridViewTextBoxColumn"
        '
        'FeederDataGridViewTextBoxColumn
        '
        Me.FeederDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.FeederDataGridViewTextBoxColumn.DataPropertyName = "feeder"
        Me.FeederDataGridViewTextBoxColumn.HeaderText = "feeder"
        Me.FeederDataGridViewTextBoxColumn.Name = "FeederDataGridViewTextBoxColumn"
        Me.FeederDataGridViewTextBoxColumn.Width = 62
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "type"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        Me.TypeDataGridViewTextBoxColumn.Width = 52
        '
        'WidthDataGridViewTextBoxColumn
        '
        Me.WidthDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.WidthDataGridViewTextBoxColumn.DataPropertyName = "width"
        Me.WidthDataGridViewTextBoxColumn.HeaderText = "width"
        Me.WidthDataGridViewTextBoxColumn.Name = "WidthDataGridViewTextBoxColumn"
        Me.WidthDataGridViewTextBoxColumn.Width = 57
        '
        'FeedDataGridViewTextBoxColumn
        '
        Me.FeedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.FeedDataGridViewTextBoxColumn.DataPropertyName = "feed"
        Me.FeedDataGridViewTextBoxColumn.HeaderText = "feed"
        Me.FeedDataGridViewTextBoxColumn.Name = "FeedDataGridViewTextBoxColumn"
        Me.FeedDataGridViewTextBoxColumn.Width = 53
        '
        'PitchDataGridViewTextBoxColumn
        '
        Me.PitchDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.PitchDataGridViewTextBoxColumn.DataPropertyName = "pitch"
        Me.PitchDataGridViewTextBoxColumn.HeaderText = "pitch"
        Me.PitchDataGridViewTextBoxColumn.Name = "PitchDataGridViewTextBoxColumn"
        Me.PitchDataGridViewTextBoxColumn.Width = 55
        '
        'NbPartDataGridViewTextBoxColumn
        '
        Me.NbPartDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.NbPartDataGridViewTextBoxColumn.DataPropertyName = "nbPart"
        Me.NbPartDataGridViewTextBoxColumn.HeaderText = "nbPart"
        Me.NbPartDataGridViewTextBoxColumn.Name = "NbPartDataGridViewTextBoxColumn"
        Me.NbPartDataGridViewTextBoxColumn.Width = 63
        '
        'HeightDataGridViewTextBoxColumn
        '
        Me.HeightDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.HeightDataGridViewTextBoxColumn.DataPropertyName = "height"
        Me.HeightDataGridViewTextBoxColumn.HeaderText = "height"
        Me.HeightDataGridViewTextBoxColumn.Name = "HeightDataGridViewTextBoxColumn"
        Me.HeightDataGridViewTextBoxColumn.Width = 61
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.Width = 60
        '
        'QtyDataGridViewTextBoxColumn
        '
        Me.QtyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.QtyDataGridViewTextBoxColumn.DataPropertyName = "qty"
        Me.QtyDataGridViewTextBoxColumn.HeaderText = "qty"
        Me.QtyDataGridViewTextBoxColumn.Name = "QtyDataGridViewTextBoxColumn"
        Me.QtyDataGridViewTextBoxColumn.Width = 46
        '
        'Btn_page_import
        '
        Me.Btn_page_import.Location = New System.Drawing.Point(13, 13)
        Me.Btn_page_import.Name = "Btn_page_import"
        Me.Btn_page_import.Size = New System.Drawing.Size(75, 23)
        Me.Btn_page_import.TabIndex = 1
        Me.Btn_page_import.Text = "Button1"
        Me.Btn_page_import.UseVisualStyleBackColor = True
        '
        'TxtBox_Dir
        '
        Me.TxtBox_Dir.Location = New System.Drawing.Point(95, 15)
        Me.TxtBox_Dir.Name = "TxtBox_Dir"
        Me.TxtBox_Dir.Size = New System.Drawing.Size(308, 20)
        Me.TxtBox_Dir.TabIndex = 2
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Btn_export
        '
        Me.Btn_export.Location = New System.Drawing.Point(12, 42)
        Me.Btn_export.Name = "Btn_export"
        Me.Btn_export.Size = New System.Drawing.Size(75, 23)
        Me.Btn_export.TabIndex = 3
        Me.Btn_export.Text = "Button1"
        Me.Btn_export.UseVisualStyleBackColor = True
        '
        'txtdbname
        '
        Me.txtdbname.Location = New System.Drawing.Point(95, 45)
        Me.txtdbname.Name = "txtdbname"
        Me.txtdbname.Size = New System.Drawing.Size(231, 20)
        Me.txtdbname.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 71)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cbdb
        '
        Me.cbdb.Location = New System.Drawing.Point(449, 20)
        Me.cbdb.Name = "cbdb"
        Me.cbdb.Size = New System.Drawing.Size(100, 20)
        Me.cbdb.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(449, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Base de données"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(449, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Table"
        '
        'txttblName
        '
        Me.txttblName.Location = New System.Drawing.Point(449, 61)
        Me.txttblName.Name = "txttblName"
        Me.txttblName.Size = New System.Drawing.Size(100, 20)
        Me.txttblName.TabIndex = 9
        '
        'btnCreateTbl
        '
        Me.btnCreateTbl.Location = New System.Drawing.Point(675, 12)
        Me.btnCreateTbl.Name = "btnCreateTbl"
        Me.btnCreateTbl.Size = New System.Drawing.Size(75, 23)
        Me.btnCreateTbl.TabIndex = 10
        Me.btnCreateTbl.Text = "Creer table"
        Me.btnCreateTbl.UseVisualStyleBackColor = True
        '
        'btnAddtbl
        '
        Me.btnAddtbl.Location = New System.Drawing.Point(675, 45)
        Me.btnAddtbl.Name = "btnAddtbl"
        Me.btnAddtbl.Size = New System.Drawing.Size(87, 23)
        Me.btnAddtbl.TabIndex = 11
        Me.btnAddtbl.Text = "Adapter table"
        Me.btnAddtbl.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(675, 74)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 489)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnAddtbl)
        Me.Controls.Add(Me.btnCreateTbl)
        Me.Controls.Add(Me.txttblName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbdb)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtdbname)
        Me.Controls.Add(Me.Btn_export)
        Me.Controls.Add(Me.TxtBox_Dir)
        Me.Controls.Add(Me.Btn_page_import)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
