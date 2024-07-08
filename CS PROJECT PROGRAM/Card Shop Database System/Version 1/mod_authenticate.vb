Module mod_authenticate
    'Check username item, if match found, check password item
    'if match found then check access level item
    'send corresponding access level into Form_User and let it handle it.
    Function check_credentials(username, password) As Array
        'returns a simple True or false, depending on if the credentials match any of the users in the user dataset
        Dim valid_user_details() As String = {"False"}
        Dim users As Object
        Try
            users = New NewDataSet("tblUser", mod_DB_communication.GetDatabaseObject, "*", "", "")
        Catch ex As Exception
            Return valid_user_details
        End Try

        For record_index As Integer = 0 To users.GetLength() - 1
            'For every record in the tblUser dataset, loop
            If username = users.GetRecordItem(record_index, 1) Then
                If password = users.GetRecordItem(record_index, 2) Then
                    'If username and password match, gather userID, access level and set valid_user to true
                    ReDim Preserve valid_user_details(users.GetWidth())
                    valid_user_details(0) = "True"
                    For attribute_index = 0 To users.GetWidth() - 1
                        valid_user_details(attribute_index + 1) = users.GetRecordItem(record_index, attribute_index)
                    Next
                    Exit For 'Kills loop once match is found, which reduces runtime of the loop unless worst-case scenario
                End If
            End If
        Next
        Return valid_user_details
        'Return array as String values since it is the most compatible with the different datatypes
    End Function
End Module
