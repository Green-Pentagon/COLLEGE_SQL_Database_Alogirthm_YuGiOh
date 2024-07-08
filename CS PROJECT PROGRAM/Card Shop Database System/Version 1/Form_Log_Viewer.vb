Public Class Form_Log_Viewer

    Private UserAccessLevel
    Public Sub New(CurrentUserAccess)
        InitializeComponent()
        UserAccessLevel = CurrentUserAccess
        If UserAccessLevel <> "ADMN" Then
            menu_Backup.Enabled = False
        End If
    End Sub
    Private Sub Form_Log_Viewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Icon = New Icon(Environment.CurrentDirectory.Replace("bin\Debug\net5.0-windows", "Files\Icons\Form_Log_Viewer.ico"))
        Catch ex As IO.FileNotFoundException
        End Try
    End Sub
    Private Sub OpenFile(FilePath As String)
        'Opens file at path and dumps contents into list box on form
        lbox_FileOutput.Items.Clear()
        Dim strFileReader As IO.StreamReader
        Dim FileLine As String
        Try
            strFileReader = New IO.StreamReader(FilePath)
        Catch ex As IO.FileNotFoundException
            MsgBox("Encountered error while opening file", MsgBoxStyle.Critical)
            Exit Sub
        End Try

        FileLine = strFileReader.ReadLine()
        Do Until FileLine Is Nothing
            lbox_FileOutput.Items.Add(FileLine)
            FileLine = strFileReader.ReadLine()
        Loop

        strFileReader.Close()
    End Sub

    Private Sub SaveFile(FilePath As String)
        'save the contents of list box into a new or existing text file
        Dim strFileWriter As IO.StreamWriter
        Dim FileLine As String
        Try
            strFileWriter = New IO.StreamWriter(FilePath)
        Catch ex As IO.FileNotFoundException
            MsgBox("Encountered error while opening file", MsgBoxStyle.Critical)
            Exit Sub
        End Try

        For lbox_index = 0 To lbox_FileOutput.Items.Count - 1
            FileLine = lbox_FileOutput.Items(lbox_index)
            strFileWriter.WriteLine(FileLine)
            'lbox_FileOutput.Items.Add(FileLine)
        Next
        strFileWriter.Close()
    End Sub


    Private Sub menu_File_Open_Click(sender As Object, e As EventArgs) Handles menu_File_Open.Click
        Dim SelectedFilepath As String

        dialog_file_open.InitialDirectory() = Environment.CurrentDirectory.Replace("bin\Debug\net5.0-windows", "") & "Files"
        dialog_file_open.Title = "Open Text File"
        dialog_file_open.Filter = "Text Files|*.txt"
        Dim FileOpenOperation = dialog_file_open.ShowDialog()
        If FileOpenOperation = DialogResult.Cancel Then
            'MsgBox("Process Cancelled!")
        Else
            SelectedFilepath = dialog_file_open.FileName()
            OpenFile(SelectedFilepath)
        End If
    End Sub

    Private Sub Menu_File_SaveAs_Click(sender As Object, e As EventArgs) Handles Menu_File_SaveAs.Click
        Dim SelectedFilepath As String
        dialog_file_saveas.FileName = "Untitled File"
        dialog_file_saveas.InitialDirectory() = Environment.CurrentDirectory.Replace("bin\Debug\net5.0-windows", "") & "Files"
        dialog_file_saveas.OverwritePrompt = True
        dialog_file_saveas.Title = "Save Text File As"
        dialog_file_saveas.Filter = "Text Files|*.txt"
        Dim FileSaveAsOperation = dialog_file_saveas.ShowDialog()
        If FileSaveAsOperation = DialogResult.Cancel Then
        Else
            SelectedFilepath = dialog_file_saveas.FileName()
            SaveFile(SelectedFilepath)
        End If

    End Sub

    Private Sub menu_view_clear_Click(sender As Object, e As EventArgs) Handles menu_view_clear.Click
        lbox_FileOutput.Items.Clear()
    End Sub

    Private Sub menu_Backup_CreateNew_Click(sender As Object, e As EventArgs) Handles menu_Backup_CreateNew.Click
        mod_backup.BackupDB()
    End Sub
End Class