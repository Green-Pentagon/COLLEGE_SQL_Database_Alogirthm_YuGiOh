Public Class Form_Add_ItemOrStock

    Private QualityAcronyms As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String)
    'This dictionary, once the form object is made and constructor ran, servers to convert all of the text from the quality combo box into acronyms used in the database
    Private UserID 'Required for changes log.
    Private Sub SetDictionary()
        Dim Qualities() As String = {"FN", "NM", "EX", "GD", "LP"}
        'HARD CODED QUALITIES, THIS WILL NEED TO BE CHANGED IN ORDER TO ALLOW MORE QUALITIES OF ITEMS TO BE SEARCHABLE
        For quality_index = 0 To Qualities.Length() - 1
            QualityAcronyms.Add(quality_index, Qualities(quality_index))
        Next
    End Sub
    Public Sub New(ProvidedUserID)
        InitializeComponent()
        UserID = ProvidedUserID
        SetDictionary()
    End Sub
    Private Sub Form_Add_ItemOrStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbox_ItemQuality.SelectedIndex = 0
        cbox_ItemRarity.SelectedIndex = 0
    End Sub
    Private Sub chk_AddToStock_CheckedChanged(sender As Object, e As EventArgs) Handles chk_AddToStock.CheckedChanged
        'Sets the different form properties on and off
        group_stock_properties.Visible = chk_AddToStock.Checked
        group_stock_properties.Enabled = chk_AddToStock.Checked
        txt_ItemName.ReadOnly = chk_AddToStock.Checked
        txt_ItemPrefix.ReadOnly = chk_AddToStock.Checked
        btn_BrowseForImage.Enabled = Not chk_AddToStock.Checked
        cbox_ItemRarity.Enabled = Not chk_AddToStock.Checked
    End Sub
    Private Sub btn_BrowseForImage_Click(sender As Object, e As EventArgs) Handles btn_BrowseForImage.Click
        dialog_BrowseForImage.Filter = "JPG image|*.jpg"
        dialog_BrowseForImage.Title = "Select image to use:"
        dialog_BrowseForImage.InitialDirectory = Environment.CurrentDirectory.Replace("bin\Debug\net5.0-windows", "Files\Images")
        Dim DialogActivity = dialog_BrowseForImage.ShowDialog()
        If DialogActivity <> DialogResult.Cancel Then
            Try
                txt_ImageFilename.Text = dialog_BrowseForImage.FileName.Replace((Environment.CurrentDirectory.Replace("bin\Debug\net5.0-windows", "Files\Images\")), "")
            Catch ex As Exception
                MsgBox("Unknown Error when selecting image.", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        If txt_ItemPrefix.TextLength = 0 Or txt_ItemName.TextLength = 0 Then
            MsgBox("Please enter a valid Item name and Prefix." & vbCrLf & "If the item is a card set, add the prefix which a card within the set contains.", MsgBoxStyle.Exclamation)
        Else
            'Ensures that the information is not case-sensitive
            txt_ItemName.Text = txt_ItemName.Text.ToUpper()
            txt_ItemNotes.Text = txt_ItemNotes.Text.ToUpper()
            txt_ItemPrefix.Text = txt_ItemPrefix.Text.ToUpper()

            Dim ItemWhereCondition As String = "ItemName = '" & txt_ItemName.Text & "' AND ItemSetPrefix = '" & txt_ItemPrefix.Text & "'"
            Dim ItemDS As New NewDataSet("tblItem", mod_DB_communication.GetDatabaseObject(), "*", ItemWhereCondition, "")
            Dim ItemFields() As String = {"ItemName", "ItemRarity", "ItemSetPrefix"}
            Dim StockFields() As String = {"ItemID", "StockQuantity", "StockQuality", "StockPrice", "StockNotes"}
            Dim ItemValues() As Object = {txt_ItemName.Text, cbox_ItemRarity.SelectedItem.ToString, txt_ItemPrefix.Text}
            If txt_ImageFilename.TextLength <> 0 Then
                ReDim ItemFields(3)
                ReDim ItemValues(3)
                ItemFields = {"ItemName", "ItemRarity", "ItemSetPrefix", "ItemImageFilepath"}
                ItemValues = {txt_ItemName.Text, cbox_ItemRarity.SelectedItem.ToString, txt_ItemPrefix.Text, txt_ImageFilename.Text}
            End If

            ItemValues = mod_DB_communication.PrepItemValues(ItemValues)

            If Not chk_AddToStock.Checked Then 'If we are adding only the item into the tblItems within the Database
                If ItemDS.GetLength() <> 0 Then 'If an item was found to already be in the DB
                    Dim UserAction = MsgBox("Item already in database: do you wish to update it's image?", MsgBoxStyle.OkCancel)
                    Dim ImageField() As String = {"ItemImageFilepath"}
                    Dim FileName() As Object = {"'" & txt_ImageFilename.Text & "'"}
                    If txt_ImageFilename.Text <> "" Then
                        Dim ChangeImageCondition As String = "ItemID = " & ItemDS.GetRecordItem(0, 0)
                        ItemDS.UpdateRecordInDB(mod_DB_communication.GetDatabaseObject(), "tblItem", ImageField, FileName, ChangeImageCondition)
                        MsgBox("Image has been updated", MsgBoxStyle.Information)
                    Else
                        MsgBox("Error: No image has been selected, operation cancelled", MsgBoxStyle.Critical)
                    End If

                Else
                    ItemDS.InsertNewRecordIntoDB(mod_DB_communication.GetDatabaseObject(), "tblItem", ItemFields, ItemValues, "")
                    MsgBox("Item successfully added to Database file.", MsgBoxStyle.Information)
                End If
            Else
                Dim UserAction
                'validate price information & make it so that if the quality selected is Card Set, the rarity is automatically reset to N
                If txt_ItemPrice.Text.Substring(txt_ItemPrice.TextLength - 3, 1) <> "." Then
                    MsgBox("Price format invalid, make sure the price is in the form XXX.XX")
                    Exit Sub
                Else
                    For letter_index = 0 To txt_ItemPrice.TextLength - 1
                        If (Asc(txt_ItemPrice.Text.Substring(letter_index)) < 47 Or Asc(txt_ItemPrice.Text.Substring(letter_index)) > 57) And (letter_index <> txt_ItemPrice.TextLength - 3) Then
                            MsgBox("Price format invalid, make sure the price is in the form XXX.XX")
                            Exit Sub
                        End If
                    Next
                End If

                'When the user wishes to add an item to the stock instead to items table in Database

                'Sets up the specifics about the SQL QUERY for accessing tblStock of database
                Dim StockWhereCondition As String = ""
                If ItemDS.GetLength() = 0 Then 'If no matching items were found in the database that already exist
                    UserAction = MsgBox("There is no item with matching informaiton in the Database:" & vbCrLf & " make sure that the details entered are correct and if you want to add a brand new item," & vbCrLf & "do that before attempting to add it into the stock", MsgBoxStyle.Exclamation)
                    Exit Sub
                ElseIf ItemDS.GetLength() = 1 Then 'If a single matching item is found, set up the SQL where condition parameters
                    StockWhereCondition += "ItemID = " & ItemDS.GetRecordItem(0, 0) & ""
                    StockWhereCondition += " AND StockQuality = '" & QualityAcronyms(cbox_ItemQuality.SelectedIndex) & "' "
                    'DEFAULT CHARACTER FOR ItemNotes PARAMETER IN tblItems SET TO CHARACTER "-" DUE TO TECHNICAL PROBLEMS
                    If txt_ItemNotes.Text.Trim.Length <> 0 And txt_ItemNotes.Text <> "-" Then
                        'If textbox for notes isn't empty, use its info to narrow down Stock item record
                        StockWhereCondition += " AND StockNotes = '" & txt_ItemNotes.Text & "'"
                    Else
                        txt_ItemNotes.Text = "-"
                        StockWhereCondition += "AND StockNotes = '-'"
                    End If
                Else 'This error message should not appear unless there are duplicate Item records
                    MsgBox("To insert a new stock record, please narrow search down to a single item.", MsgBoxStyle.Critical)
                    Exit Sub
                End If
                Dim StockValues() As Object = {ItemDS.GetRecordItem(0, 0), num_ItemQuantityToAdd.Value, "'" & QualityAcronyms(cbox_ItemQuality.SelectedIndex.ToString) & "'", txt_ItemPrice.Text, "'" & txt_ItemNotes.Text & "'"}

                Dim StockDS As New NewDataSet("tblStock", mod_DB_communication.GetDatabaseObject(), "*", StockWhereCondition, "")
                If StockDS.GetLength() = 1 Then 'If there is a single stock record with identical information, QUERY DATABASE TO UPDATE THAT STOCK RECORD
                    Dim updated_quantity As Integer = StockDS.GetRecordItem(0, 2) + num_ItemQuantityToAdd.Value
                    StockValues(1) = updated_quantity

                    StockDS.UpdateRecordInDB(mod_DB_communication.GetDatabaseObject, "tblStock", StockFields, StockValues, ("StockID = " & StockDS.GetRecordItem(0, 0).ToString))
                    MsgBox("Record Quantity & price updated", MsgBoxStyle.Information)
                    mod_log_changes.LogChange(UserID, StockDS.GetRecordItem(0, 0), ("ADDED " & num_ItemQuantityToAdd.Value & " OF ITEM"))
                    mod_log_changes.LogChange(UserID, StockDS.GetRecordItem(0, 0), ("SET PRICE TO £" & txt_ItemPrice.Text & " OF ITEM"))
                ElseIf StockDS.GetLength() = 0 Then
                    'If there is no stock record with identical information, QUERY DATABASE TO CREAT NEW RECORD

                    StockDS.InsertNewRecordIntoDB(mod_DB_communication.GetDatabaseObject, "tblStock", StockFields, StockValues, "")
                    StockDS = New NewDataSet("tblStock", mod_DB_communication.GetDatabaseObject, "*", "", "StockID DESC")
                    MsgBox("Record added to Database File", MsgBoxStyle.Information)
                    mod_log_changes.LogChange(UserID, StockDS.GetRecordItem(0, 0), ("CREATED " & num_ItemQuantityToAdd.Value & " OF ITEM"))

                Else 'This message should not appear unless there are multiple Stock records with the same properties.
                    MsgBox("ERROR: MULTIPLE STOCK RECORDS FOUND WITH IDENTICAL INFORMATION", MsgBoxStyle.Critical)
                End If
            End If
        End If
    End Sub


End Class