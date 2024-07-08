Module mod_log_changes

    'call example: mod_log_changes.LogChange(1, 1, "DEBUG")
    Private Sub WriteIntoFile(Record As Object)

        Dim streamAppender As IO.StreamWriter
        Dim FileLine As String = ""
        Dim Filepath As String = Environment.CurrentDirectory.Replace("bin\Debug\net5.0-windows", "Files\Changes Log\")
        Filepath += "ACTIVE - Change Log.txt"
        streamAppender = New IO.StreamWriter(Filepath, True)

        For property_index = 0 To Record.Length - 1
            FileLine += Record(property_index) & "  |   "
        Next
        FileLine.TrimEnd()
        streamAppender.WriteLine(FileLine)
        streamAppender.Close()
    End Sub


    Sub LogChange(ProvidedUserID, ProvidedStockID, ChangeDescription)
        Dim ChangesDS As New NewDataSet("tblChange", mod_DB_communication.GetDatabaseObject, "*", "", "")
        Dim fields() As String = {"UserID", "StockID", "ChangeTimestamp", "ChangeDescription"}

        Dim values(3) As Object
        values(0) = ProvidedUserID
        values(1) = ProvidedStockID
        values(2) = ("[" & System.DateTime.Now.ToString & "]")
        values(3) = ChangeDescription
        values = mod_DB_communication.PrepItemValues(values)

        ChangesDS.InsertNewRecordIntoDB(mod_DB_communication.GetDatabaseObject, "tblChange", fields, values, "")

        values(0) = "UserID: " & ProvidedUserID
        values(1) = "StockID: " & ProvidedStockID

        WriteIntoFile(values)
        ChangesDS.UpdateDB() 'automatically updates the local database with the new change record.

    End Sub


End Module
