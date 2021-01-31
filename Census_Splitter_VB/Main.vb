Public Class Main
    'Input Folder'
    Private Sub InputFolderButton_Click(sender As Object, e As EventArgs) Handles InputFolderButton.Click
        If (InputFolderDialog.ShowDialog() = DialogResult.OK) Then
            InputFolderTextbox.Text = InputFolderDialog.SelectedPath
        End If
    End Sub

    'Output Folder' 
    Private Sub OutputFolderButton_Click(sender As Object, e As EventArgs) Handles OutputFolderButton.Click
        If (OutputFolderDialog.ShowDialog() = DialogResult.OK) Then
            OutputFolderTextbox.Text = OutputFolderDialog.SelectedPath
        End If
    End Sub

    Private Sub RunButton_Click(sender As Object, e As EventArgs) Handles RunButton.Click
        'Declare Variables'
        Dim census_splitter As String = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Census_Splitter\Scripts\census_splitter.bat")
        Dim input_folder = InputFolderTextbox.Text
        Dim output_folder = OutputFolderTextbox.Text

        'Batch Script'
        ChDir(Environment.GetFolderPath(Environment.SpecialFolder.Personal))
        Dim p As New Process
        Cursor.Current = Cursors.WaitCursor
        p.StartInfo.FileName = census_splitter
        p.StartInfo.Arguments = input_folder & " " & output_folder
        p.StartInfo.CreateNoWindow = True
        p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        p.Start()
        p.WaitForExit()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

End Class
