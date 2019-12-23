Imports System.IO
Public Class Form1

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        Try

            ' Dim SR As StreamReader = File.OpenText("C:\Users\alex\Downloads\alex\293746207_B02_PROD_AB_FACE_1.csv") 
            Dim SR As StreamReader = File.OpenText(TextBox5.Text)
            Dim ligne As String

            Me.TextBox1.Text = Replace(Me.TextBox1.Text, "P", "")
            Me.TextBox1.Text = Replace(Me.TextBox1.Text, " ", "")

            If TextBox1.Text <> ("") Then
                TextBox3.Text = ("")
                TextBox2.Text = ("")
                TextBox4.Text = ("")
                TextBox6.Text = ("")
            End If

            TextBox1.SelectionLength = 9

            Do Until SR.Peek = -1

                ligne = SR.ReadLine()
                Dim spli() As String = ligne.Split(";") 'string séparée par un ; dans une case du tableau de string spli()
                Dim strMach As String = spli(0) 'Machine
                Dim strCode As String = spli(3) 'code million
                Dim strMod As String = spli(1) 'module
                Dim strPos As String = spli(2) 'position
                ' ici le traitement genre
                If spli(3).Equals(TextBox1.Text) Then
                    ' traitement
                    TextBox3.Text = spli(0)
                    TextBox2.Text = spli(1)
                    TextBox4.Text = spli(2)
                End If
            Loop
            SR.Close()
            If (TextBox1.Text = ("")) Then

            End If

        Catch ex As Exception
            MsgBox("Cliquer sur Import pour charger un produit")

        End Try

        If (TextBox3.Text = ("")) Then
            TextBox6.Text = ("N'est pas utilisée")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim selectedFile As String = String.Empty

        ' Pour afficher l'OpenFileDialog
        OpenFileDialog1.ShowDialog()

        ' Pour insérer l'emplacement du fichier choisi dans le TextBox
        selectedFile = OpenFileDialog1.FileName

        If (selectedFile IsNot Nothing) Then
            TextBox5.Text = selectedFile
        End If
    End Sub


End Class
