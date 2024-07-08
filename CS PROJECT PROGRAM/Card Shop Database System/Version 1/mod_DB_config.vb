Module mod_DB_config
    'Config should be in this exacy format, if it is not, a new copy with default presets will be created in \Files\Database
    'NAMEOFDBFILE.mdb,EXPIREDATE,BACKUPDELAY
    'String , Date/month/year , Integer (number of days to delay new backup)

    'Example:
    'StockSysDatabase.mdb,#12/16/2012#,7





    'Sadly, due to technical limitations and errors encountered, the config will not be serving it's initial purpose and simply will server to get info on DB whereabouts.





    Class DBConfig
        Private DB_FileName
        Private DB_FilePath As String
        Private ExpireDate As Date
        Private BackupDelay As Integer
        Private ConfigName As String 'Name of the .cvs configuration file

        Public Sub New(ConfigFileName)
            ConfigName = ConfigFileName
            FetchConfigData()
        End Sub

        Private Sub CreateFreshConfig()
            'SYSTEM DEFAULTS FOR CONFIGURATION PROPERTIES
            DB_FileName = "StockSysDatabase.mdb"
            ConfigName = "DBconfig.txt"
            BackupDelay = 7
            ExpireDate = Date.Today.AddDays(BackupDelay)
        End Sub
        Public Function getConfigName()
            Return ConfigName
        End Function
        Public Function GetDBFilePath()
            Return DB_FilePath
        End Function
        Public Function GetDBFileName()
            Return DB_FileName
        End Function

        Public Sub SetBackUpDelay(DaysDelay)
            BackupDelay = DaysDelay
        End Sub

        Public Sub RefreshExpireDate()
            ExpireDate = Date.Today.AddDays(BackupDelay)
        End Sub

        Public Function HasExpired()
            Dim expired As Boolean = False
            If Date.Compare(ExpireDate, Date.Today) <= 0 Then
                expired = True
            End If
            Return expired
        End Function
        Public Function GiveData()
            Return {ConfigName, ExpireDate, BackupDelay}
        End Function

        Private Sub FetchConfigData()
            Try
                DB_FilePath = Environment.CurrentDirectory.Replace("bin\Debug\net5.0-windows", "Files\Database\")

                Dim ReadConfig As New IO.StreamReader(DB_FilePath & ConfigName)
                Dim ConfigInfo() As String
                ConfigInfo = ReadConfig.ReadLine().Split(",")

                DB_FileName = ConfigInfo(0)
                ExpireDate = ConfigInfo(1)
                BackupDelay = ConfigInfo(2)

            Catch ex As IO.FileNotFoundException
                CreateFreshConfig()
                Exit Sub
            End Try
        End Sub
    End Class
End Module
