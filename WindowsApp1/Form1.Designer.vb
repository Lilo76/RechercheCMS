﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
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
        Me.btnCreateTbl = New System.Windows.Forms.Button()
        Me.txt_nomTable = New System.Windows.Forms.TextBox()
        Me.Btn_CreateUpdate2 = New System.Windows.Forms.Button()
        Me.btn_CreateAndCopy = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.MachDataGridViewTextBoxColumn, Me.PosDataGridViewTextBoxColumn, Me.PartDataGridViewTextBoxColumn, Me.NumDataGridViewTextBoxColumn, Me.FeederDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.WidthDataGridViewTextBoxColumn, Me.FeedDataGridViewTextBoxColumn, Me.PitchDataGridViewTextBoxColumn, Me.NbPartDataGridViewTextBoxColumn, Me.HeightDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.QtyDataGridViewTextBoxColumn})
        Me.DataGridView1.Location = New System.Drawing.Point(13, 62)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(852, 338)
        Me.DataGridView1.TabIndex = 1
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
        Me.Btn_page_import.TabIndex = 2
        Me.Btn_page_import.Text = "Import"
        Me.Btn_page_import.UseVisualStyleBackColor = True
        '
        'TxtBox_Dir
        '
        Me.TxtBox_Dir.Location = New System.Drawing.Point(95, 13)
        Me.TxtBox_Dir.Name = "TxtBox_Dir"
        Me.TxtBox_Dir.Size = New System.Drawing.Size(238, 20)
        Me.TxtBox_Dir.TabIndex = 3
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnCreateTbl
        '
        Me.btnCreateTbl.Location = New System.Drawing.Point(762, 7)
        Me.btnCreateTbl.Name = "btnCreateTbl"
        Me.btnCreateTbl.Size = New System.Drawing.Size(75, 23)
        Me.btnCreateTbl.TabIndex = 4
        Me.btnCreateTbl.Text = "Créer Table"
        Me.btnCreateTbl.UseVisualStyleBackColor = True
        '
        'txt_nomTable
        '
        Me.txt_nomTable.Location = New System.Drawing.Point(466, 15)
        Me.txt_nomTable.Name = "txt_nomTable"
        Me.txt_nomTable.Size = New System.Drawing.Size(100, 20)
        Me.txt_nomTable.TabIndex = 5
        '
        'Btn_CreateUpdate2
        '
        Me.Btn_CreateUpdate2.Location = New System.Drawing.Point(747, 33)
        Me.Btn_CreateUpdate2.Name = "Btn_CreateUpdate2"
        Me.Btn_CreateUpdate2.Size = New System.Drawing.Size(112, 23)
        Me.Btn_CreateUpdate2.TabIndex = 6
        Me.Btn_CreateUpdate2.Text = "Création de la table"
        Me.Btn_CreateUpdate2.UseVisualStyleBackColor = True
        '
        'btn_CreateAndCopy
        '
        Me.btn_CreateAndCopy.Location = New System.Drawing.Point(365, 13)
        Me.btn_CreateAndCopy.Name = "btn_CreateAndCopy"
        Me.btn_CreateAndCopy.Size = New System.Drawing.Size(95, 23)
        Me.btn_CreateAndCopy.TabIndex = 7
        Me.btn_CreateAndCopy.Text = "Create And Copy"
        Me.btn_CreateAndCopy.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 406)
        Me.Controls.Add(Me.btn_CreateAndCopy)
        Me.Controls.Add(Me.Btn_CreateUpdate2)
        Me.Controls.Add(Me.txt_nomTable)
        Me.Controls.Add(Me.btnCreateTbl)
        Me.Controls.Add(Me.TxtBox_Dir)
        Me.Controls.Add(Me.Btn_page_import)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MachDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PartDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FeederDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WidthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FeedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PitchDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NbPartDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HeightDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Btn_page_import As Button
    Friend WithEvents TxtBox_Dir As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnCreateTbl As Button
    Friend WithEvents txt_nomTable As TextBox
    Friend WithEvents Btn_CreateUpdate2 As Button
    Friend WithEvents btn_CreateAndCopy As Button
End Class
