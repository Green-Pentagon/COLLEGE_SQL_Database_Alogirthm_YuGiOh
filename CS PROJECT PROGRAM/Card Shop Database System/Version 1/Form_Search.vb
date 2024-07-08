Public Class Form_Search

    Private QualityAcronyms As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String)
    Private Mode As String 'Mode can be Remove or Search
    Private StockIDandStockQuantity() 'If the mode is "Remove", this method stores array of {StockID , Quantity} of item that is pending removal
    'returns the array of '{StockID , StockName, StockQuality, StockQuantity (selected), StockQuality (difference), StockPrice}
    Private UserID
    'Linked to the combo box: allows for direct conversion of the combo box index into a value

    Private Sub SetDictionary()
        Dim Qualities() As String = {"XX", "FN", "NM", "EX", "GD", "LP"}
        'HARD CODED QUALITIES, THIS WILL NEED TO BE CHANGED IN ORDER TO ALLOW MORE QUALITIES OF ITEMS TO BE SEARCHABLE
        For quality_index = 0 To Qualities.Length() - 1
            QualityAcronyms.Add(quality_index, Qualities(quality_index))
        Next
    End Sub
    Public Sub New(OperationMode) 'In the event that the user decides to change the price of an item, the UserID will be required in that stage.
        'mode can either be "Search" or "Remove", where the only difference it makes is that it will return the selected ID and quantity of item selected
        InitializeComponent()
        Mode = OperationMode
    End Sub
    Private Sub Form_Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Icon = New Icon(Environment.CurrentDirectory.Replace("bin\Debug\net5.0-windows", "Files\Icons\Form_Search_icon.ico"))
        Catch ex As IO.FileNotFoundException
        End Try
        SetDictionary()
        cbox_itemQuality_filter.SelectedIndex = 0
    End Sub

    Public Function GetResultFormSelection()
        'When remove form will be using this to search for pre-exiting records
        Return StockIDandStockQuantity
    End Function

    Private Function Validate_field_Data()
        Dim valid As Boolean = True
        If txt_ItemName.Text.Length > 60 Then
            '55 is the longest currently existing card & set name: for sake of possibly longer name, a margin of error of 5 characters is added in validation.
            valid = False
        ElseIf txt_SetPrefix.Text.Length > 15 Or (txt_SetPrefix.Text.Length = 1 Or (txt_SetPrefix.Text.Length = 0 And txt_ItemName.Text.Length = 0)) Then
            'If prefix is unreasonably long OR if both text fields are empty
            'The largest card set ID is approximately 11
            valid = False
        Else 'If all the fields have a valid length, check the beginning characters of the SetID
            Try
                For letter_index = 0 To 3
                    If Asc(txt_SetPrefix.Text.Substring(letter_index)) < 91 And Asc(txt_SetPrefix.Text.Substring(letter_index)) > 47 Then
                        'If the ASCII Character Is within the range of ASCII numeral and Uppercase characters, it might be valid
                        If Asc(txt_SetPrefix.Text.Substring(letter_index)) > 57 And Asc(txt_SetPrefix.Text.Substring(letter_index)) < 65 Then
                            'If the ASCII Character Is in the special characters boundry, it is invalid
                            valid = False
                            Exit For
                        End If
                    Else
                        valid = False
                        Exit For 'Sudden exit, as no more values need to be checked: the set prefix is automatically deemed invalid as it contains invalid characters.
                    End If
                Next
            Catch ex As ArgumentException
                'Enters here when length of provided prefix is lower than 4 but higher than 1,
                'However, as it has checked up to the entire length of the characters for validity, it is safe to assume that the prefix is valid.
            End Try
        End If
        Return valid
    End Function
    Private Sub btn_HelpPrompt_Click(sender As Object, e As EventArgs) Handles btn_HelpPrompt.Click
        MsgBox(("To search, Please enter the name of the item or the Card Set ID" & vbCrLf &
               "Card Set ID is a code which can be found written on the front of the card, generally on the bottom left underneath card's art." & vbCr &
               "An Example of what a Card Set ID may look like HAC1-EN001," & vbCrLf & "However, only the first few characters are required for the search" & vbCrLf &
               "Only enter the card prefix characters that are present before the dash on the card ID."), MsgBoxStyle.Information)
    End Sub
    Private Sub QueryStockTable(ByRef ItemDS, QualityDesired)
        Dim WhereCondition As String = ""
        For record_index = 0 To (ItemDS.GetLength() - 1)
            WhereCondition += ("ItemID = " & ItemDS.GetRecordItem(record_index, 0) & " OR ")
        Next
        If QualityDesired = "XX" Then   'If all qualities are wanting to be included
            WhereCondition = WhereCondition.Remove(WhereCondition.Length - 4)
            'Else                            'If a specific quality has been selected
            '    WhereCondition += "StockQuality = '" & QualityDesired & "'"
        End If
        Dim StockDS As New NewDataSet("tblStock", mod_DB_communication.GetDatabaseObject(), "*", WhereCondition, "StockQuantity DESC")
        Dim NewSearchResultForm As New Form_Search_Result(StockDS, ItemDS, Mode, QualityDesired)
        NewSearchResultForm.ShowDialog()
        If Mode = "Remove" Then         'If the mode of operation is "Remove" obtain the information on the item that user decided to remove
            StockIDandStockQuantity = NewSearchResultForm.GetInfoForRemoval()
            Me.Close()
        End If
    End Sub
    Private Sub QueryItemTable(ItemName As String, SetPrefix As String, QualityFilter As String)
        Dim WhereCondition As String = ""
        If SetPrefix.Length > 0 Then                                    'If set prefix has been provided
            WhereCondition += ("ItemSetPrefix = '" & SetPrefix & "'")
            If ItemName.Length > 0 Then                                 'Id both set prefix and name were provided
                WhereCondition += (" AND " & "ItemName = '" & ItemName & "'")
            End If
        ElseIf ItemName.Length > 0 Then                                 'if only the name was provided
            WhereCondition += ("ItemName = '" & ItemName & "'")
        Else
            MsgBox("ERROR IN QUERTY_ITEM_TABLE FUNCTION WITHIN FORM_SEARCH")
        End If

        Dim ItemDS As New NewDataSet("tblItem", mod_DB_communication.GetDatabaseObject(), "*", WhereCondition, "")
        Try 'Check to see if the DataSet is empty: if dataset is empty that means that the item doesn't exist in tblItems in database
            ItemDS.GetRecordItem(0, 0)
            QueryStockTable(ItemDS, QualityFilter)  'Subroutine which sends a query to tblStock to get the stock records of matching ItemIDs
        Catch ex As IndexOutOfRangeException
            MsgBox(("Item doesn't exist in the database" & vbCrLf & "If all information is entered correctly, contact a stock manager or administrator."), MsgBoxStyle.Exclamation)
        End Try
    End Sub
    Private Sub btn_StartSearch_Click(sender As Object, e As EventArgs) Handles btn_StartSearch.Click
        txt_SetPrefix.Text = txt_SetPrefix.Text.ToUpper()
        txt_ItemName.Text = txt_ItemName.Text.ToUpper()
        If Validate_field_Data() Then
            Dim CardSetIDPrefix As String
            If txt_SetPrefix.Text.Length > 4 Then 'trims any trailing characters that the user has entered, only taking the first 4 characters
                CardSetIDPrefix = txt_SetPrefix.Text.Remove(4)
            Else 'Since the Validate_field_data checks for any length that is 
                CardSetIDPrefix = txt_SetPrefix.Text
            End If
            'Sets the rarity filter to the value equivalent to the selected index value in the combo list box
            Dim QualityFilter As String = QualityAcronyms(cbox_itemQuality_filter.SelectedIndex)

            QueryItemTable(txt_ItemName.Text, CardSetIDPrefix, QualityFilter)
            'Gathers information on items which match the search
        Else
            MsgBox("Field information invalid" & vbCrLf & "(CardID must start with only letters & numbers and must not contain any spaces before or between characters)")
        End If
    End Sub
End Class