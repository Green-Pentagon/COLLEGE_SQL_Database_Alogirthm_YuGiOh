Module mod_DB_communication
    Function getConfiginfo() As Array
        Dim Config As New mod_DB_config.DBConfig("DBconfig.csv")
        Dim array() = {Config.GetDBFileName(), Config.GetDBFilePath()}
        Return array 'Blah array stuff
    End Function

    Dim Infocopy = getConfiginfo()
    Dim DBFileName = Infocopy(0)
    Dim DBFilePath = Infocopy(1)

    'make DBFileName equal to part of returned array from function get
    Function PrepItemValues(ByRef ObjectArray) As Object
        'prepares the raw values of the items, where it envelopes the values with single quotation marks to be used in SQL query
        Dim FieldVals() As Object = ObjectArray
        For item_index = 0 To FieldVals.Length - 1
            FieldVals(item_index) = "'" & FieldVals(item_index) & "'"
        Next
        Return FieldVals
    End Function

    Dim CardDatabase As New Database(DBFileName)

    Function GetDatabaseObject() 'used to toss the CardDatabase to different parts of the program, as access is restricted to it anywhere else in the project
        Return CardDatabase.GetConnectorObject()
    End Function

    'Sub CheckStatus() 'command for debugging
    '    MsgBox("Database status: " & CardDatabase.GetConnectionStatus())
    'End Sub
    Sub TerminateDBConnection()
        CardDatabase.CloseConnection()
    End Sub

    '=================================================
    'in the event of another Database class being implemented, this interface serves as a baseline for the minimum requied functionality.
    Interface DatabaseSkeleton 'interface in the event another Database subclass is made by a developer
        Sub OpenConnection()
        Sub CloseConnection()
        Function ConnectionStatus()
        Function GetConnector() 'returns the connector object or equivalent
    End Interface
    '=================================================
    Class SQLQueryMaker 'This class creates the different queries with it's methods, in text format
        Public Function SelectQuery(TableName As String, Parameter As String)
            'returns string SELECT Parameter FROM TableName
            Return "SELECT " & Parameter & " FROM " & TableName
        End Function

        Public Function SelectQuery(TableName As String, Parameter As String, WhereCondition As String, SortBy As String)
            'returns either SELECT Parameter FROM TableName WHERE WhereCondition,
            'SELECT Parameter FROM TableName SORT BY SortBy
            'or both combined
            Dim sql_text As String = SelectQuery(TableName, Parameter)
            If WhereCondition <> "" Then
                sql_text += " WHERE " & WhereCondition 'TEST IF WORKS NOW
            End If
            If SortBy <> "" Then
                sql_text += " ORDER BY " & SortBy
            End If
            sql_text += ";"
            Return sql_text
        End Function

        Public Function UpdateQuery(TableName As String, Fields() As String, Values() As Object, WhereCondition As String)
            Dim sql_text As String = "UPDATE " & TableName & " SET "

            For paramter_index = 0 To Fields.Length - 1
                sql_text += Fields(paramter_index) & " = " & Values(paramter_index) & ", "
            Next
            sql_text = sql_text.Remove(sql_text.Length - 2)

            If WhereCondition <> "" Then
                sql_text += " WHERE " & WhereCondition
            End If

            sql_text += ";"
            Return sql_text
        End Function

        Public Function DeleteQuery(TableName As String, WhereCondition As String)
            Dim sql_text As String = "DELETE FROM " & TableName & " WHERE " & WhereCondition & ";"
            Return sql_text
        End Function

        Public Function InsertQuery(TableName As String, Fields() As String, Values() As Object, WhereCondition As String)
            Dim sql_text As String = "INSERT INTO "
            sql_text += TableName & " ( "

            For Each field In Fields
                sql_text += field.ToString & ", "
            Next
            sql_text = sql_text.Remove(sql_text.Length - 2)
            sql_text += " ) VALUES ( "

            For Each raw_value In Values
                sql_text += raw_value & ", "
            Next
            sql_text = sql_text.Remove(sql_text.Length - 2)
            sql_text += ") "
            If WhereCondition <> "" Then
                sql_text += "WHERE " & WhereCondition
            End If
            sql_text += ";"

            Return sql_text
        End Function
    End Class
    '=================================================
    Class NewDataSet
        Private DataSet As New DataSet
        Private DataAdapter As New OleDb.OleDbDataAdapter
        Private TableName
        Private SQL As New SQLQueryMaker 'creates new instance of class, accessible through the dataset
        Public Sub New(GivenTableName As String, DatabaseObject As OleDb.OleDbConnection, SelectionParameter As String, WhereCondition As String, SortBy As String)
            TableName = GivenTableName
            If WhereCondition = "" And SortBy = "" Then
                DataAdapter = New OleDb.OleDbDataAdapter(SQL.SelectQuery(TableName, SelectionParameter), DatabaseObject)
            Else
                DataAdapter = New OleDb.OleDbDataAdapter(SQL.SelectQuery(TableName, SelectionParameter, WhereCondition, SortBy), DatabaseObject)
            End If

            DataAdapter.Fill(DataSet, TableName) 'fills the empty DataSet object 'ds' and referred to by the name of the table provided
        End Sub

        Public Sub TerminateDataSet()
            DataAdapter.Dispose()
        End Sub
        Public Function GetRecordItem(row, column)
            'Gets the value of a property in a record.
            Return DataSet.Tables(TableName).Rows(row).Item(column)
        End Function
        Public Function GetRecordAsList(record_index)
            Dim temp_list As New List(Of Object)
            For count = 0 To (GetWidth() - 1)
                temp_list.Add(GetRecordItem(record_index, count))
            Next
            Return temp_list
        End Function
        Public Sub SetRecordItem(record_index, item_index, new_info)
            DataSet.Tables(TableName).Rows(record_index).Item(item_index) = new_info
        End Sub
        Public Sub InsertNewRecordIntoDB(DataBaseConnectorObject As OleDb.OleDbConnection, TableName As String, Fields() As String, Values() As Object, WhereCondition As String)
            DataAdapter = New OleDb.OleDbDataAdapter(SQL.InsertQuery(TableName, Fields, Values, WhereCondition), DataBaseConnectorObject)
            DataAdapter.Fill(DataSet, TableName)

        End Sub
        Public Sub DeleteRecordInDB(DataBaseConnectorObject As OleDb.OleDbConnection, TableName As String, WhereCondition As String)
            DataAdapter = New OleDb.OleDbDataAdapter(SQL.DeleteQuery(TableName, WhereCondition), DataBaseConnectorObject)
            DataAdapter.Fill(DataSet, TableName)
        End Sub
        Public Sub UpdateDB() 'updates table in database with local information!
            Dim com_builder As New OleDb.OleDbCommandBuilder(DataAdapter)
            DataAdapter.Update(DataSet, TableName)
            TerminateDataSet()
        End Sub

        Public Sub UpdateRecordInDB(DataBaseConnectorObject As OleDb.OleDbConnection, TableName As String, Fields() As String, Values() As Object, WhereCondition As String)
            DataAdapter = New OleDb.OleDbDataAdapter(SQL.UpdateQuery(TableName, Fields, Values, WhereCondition), DataBaseConnectorObject)
            DataAdapter.Fill(DataSet, TableName)
            TerminateDataSet()
        End Sub

        Public Function GetLength() 'Gets the number of records present in the datastructure
            Return DataSet.Tables(TableName).Rows.Count
        End Function

        Public Function GetWidth() 'Gets the number of attributes within the table
            Return DataSet.Tables(TableName).Columns.Count
        End Function
    End Class
    '=================================================
    Class Database
        Implements DatabaseSkeleton
        Private DatabaseFilePath
        Private con As New OleDb.OleDbConnection                            'connecting object
        Private dbProvider As String = "PROVIDER=Microsoft.ACE.OLEDB.12.0;" 'database connection driver
        Private dbSource As String                                          'stores the exact filepath with name of database
        Private FileName As String

        '-----CONSTRUCTOR-----
        Public Sub New(DataBaseFileName)
            DatabaseFilePath = DBFilePath
            FileName = DataBaseFileName
            dbSource = "Data Source = " & DatabaseFilePath & FileName
            con.ConnectionString = dbProvider & dbSource
            Me.ConnectionToggle(True)
        End Sub
        '---------------------
        Private Sub ConnectionToggle(Toggle) 'switches on/off the connection to the database, inaccessible outside of class
            Try
                Select Case Toggle
                    Case True
                        con.Open()
                    Case Else
                        con.Close()
                End Select
            Catch ex As Exception
                MsgBox(("ERROR: Could not connect to Database" & vbCrLf & "Ensure " & FileName & " Is located in the directory:" & vbCrLf & DatabaseFilePath), MsgBoxStyle.Critical)
                con.Close()
            End Try
        End Sub
        '----Accessibility Features----
        Public Sub OpenConnection() Implements DatabaseSkeleton.OpenConnection
            If GetConnectionStatus() = "CLOSED" Then 'only open connection if it is initially closed
                Me.ConnectionToggle(True)
            Else
                MsgBox("Connection is already open", MsgBoxStyle.Information)
            End If
        End Sub
        Public Sub CloseConnection() Implements DatabaseSkeleton.CloseConnection 'only close connection if all processes are finished or if the connection is broken
            If GetConnectionStatus() = "OPEN" Or GetConnectionStatus() = "BROKEN" Then
                Me.ConnectionToggle(False)
                Me.Finalize()
            Else
                MsgBox("Connection is already closed", MsgBoxStyle.Information)
            End If
        End Sub
        '------------------------------
        Public Function GetConnectionStatus() Implements DatabaseSkeleton.ConnectionStatus
            Dim status_text As String
            Select Case con.State
                Case 0
                    status_text = "CLOSED"
                Case 1
                    status_text = "OPEN"
                Case 2
                    status_text = "CONNECTING"
                Case 4
                    status_text = "EXECUTING"
                Case 8
                    status_text = "FETCHING"
                Case 16
                    status_text = "BROKEN"
                Case Else
                    status_text = "UNKNOWN"
            End Select
            Return status_text
        End Function
        Public Function GetConnectorObject() Implements DatabaseSkeleton.GetConnector
            Return con
        End Function
    End Class
    '=================================================


End Module
