Public Class Form1
    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        Dim openFileDialog As New OpenFileDialog()

        ' Set the filter for text files
        openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                Dim filePath As String = openFileDialog.FileName

                ' Read the content of the selected file and display it in the TextBox control
                Dim fileContent As String = My.Computer.FileSystem.ReadAllText(filePath)
                txtFileContent.Text = fileContent
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "File Open Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class
