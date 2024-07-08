Module mod_backup
    Dim expired As Boolean = False
    Dim Info() As String
    Dim config_filepath As String
    Sub BackupDB()
        'creates a backup of the database and if one already exists, it overrides the existing one
        Dim config As New mod_DB_config.DBConfig("DBconfig.txt")

        Info = config.GiveData()

        Dim current_filepath As String = (config.GetDBFilePath & config.GetDBFileName)
        Dim backup_filepath As String = (config.GetDBFilePath & "Backup\" & config.GetDBFileName)


        My.Computer.FileSystem.CopyFile(current_filepath, backup_filepath, True)

        'Dim StrWrite As IO.StreamWriter
        'config_filepath = config.GetDBFilePath & config.getConfigName()
        'StrWrite = New IO.StreamWriter("Test.txt")
        'For index = 0 To Info.Length - 2
        '    Info(index) += ","
        '    StrWrite.Write(Info(index))
        'Next
        'StrWrite.Write(Info(Info.Length - 1))
        'StrWrite.Close()

        MsgBox("New Backup created at directory: " & backup_filepath)
    End Sub

End Module
