Public Class Form_Search_Result
    Private InStockDS
    Private InItemDS
    Private Mode
    Private NavigationIndex As Integer = 0
    Private RecordOrder As New List(Of List(Of Object))
    Private QualityFilter
    Private InfoForRemoval(5) As Object
    'Stores information of the item to fill the Remove queue item
    'returns the array of '{StockID , StockName, StockQuality, StockQuantity (selected), StockQuality (difference), StockPrice}

    'RecordOrder structure once it passes through CreateRecords is:
    '{ {Stock&ItemInfo}, { {StockID, ItemID, StockQuantity, StockQuality, StockPrice, StockNotes, ItemName, ItemRarity, ItemSetPrefix, ItemImageFilepath} } , ....}
    Private Sub Form_Search_Result_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Icon = New Icon(Environment.CurrentDirectory.Replace("bin\Debug\net5.0-windows", "Files\Icons\Form_Item.ico"))
        Catch ex As IO.FileNotFoundException
        End Try
        'If the user comes from the remove form and is selecting an item to add to the removal queue, show the controls associated with the process.
        If Mode <> "Remove" Then
            group_remove.Visible = False
        End If
        CreateRecordOrder()
        UpdateRecordDetils()
        If RecordOrder.Count = 1 Then
            btn_previous_record.Enabled = False
            btn_next_record.Enabled = False
        End If
    End Sub
    Public Sub New(ByRef StockDS, ByRef ItemDS, ByRef OperationMode, QualityDesired)
        'StockDS required to show items in stock, ItemDS can be a toggle feature which shows items that are also not in stock but in DB, as well as instock items
        'MODE SAME AS WITHIN FORM_SEARCH CONSTRUCTOR
        InitializeComponent()
        InStockDS = StockDS
        InItemDS = ItemDS
        Mode = OperationMode
        QualityFilter = QualityDesired
    End Sub
    Public Function GetInfoForRemoval()
        'called by Form_Search when it is in removal mode and passes the array of {SetID , Quantity}
        Return InfoForRemoval
    End Function
    Private Sub UpdateRecordDetils()
        Try
            lbl_record_navigation.Text = NavigationIndex.ToString + 1 & "Of" & RecordOrder.Count
            'Sets the different text box text values
            txt_StockID.Text = RecordOrder(NavigationIndex)(0)(0)
            txt_ItemID.Text = RecordOrder(NavigationIndex)(0)(1)
            txt_item_quantity.Text = RecordOrder(NavigationIndex)(0)(2)
            txt_item_quality.Text = RecordOrder(NavigationIndex)(0)(3)
            txt_item_price.Text = RecordOrder(NavigationIndex)(0)(4)
            Try 'In the event that there is no Notes added, this try catches exception caused.
                txt_item_notes.Text = RecordOrder(NavigationIndex)(0)(5)
            Catch ex As System.InvalidCastException
                txt_item_notes.Text = ""
            End Try
            lbl_item_name.Text = RecordOrder(NavigationIndex)(0)(6)
            txt_item_rarity.Text = RecordOrder(NavigationIndex)(0)(7)
            If RecordOrder(NavigationIndex)(0)(3) <> "FN" Then
                txt_item_type.Text = "Card"
            Else
                txt_item_type.Text = "Card set"
            End If
            'Does not require a try catch because it doesn't throw an exception if directory doesn't exist.
            pbox_item_image.ImageLocation = Environment.CurrentDirectory.Replace("bin\Debug\net5.0-windows", "") & "Files\Images\" & RecordOrder(NavigationIndex)(0)(9)

            'Sets the maximum quantity able to be removed to how much of the item there exists
            num_remove_quantity.Maximum = RecordOrder(NavigationIndex)(0)(2)
        Catch ex As ArgumentOutOfRangeException
            MsgBox("Searched item(s) are not in stock!")
            Close()
        End Try
    End Sub
    Private Sub CreateRecordOrder()
        'Dim TestObject As Object = InItemDS.GetRecord(0) 'Testing stuff
        'TestObject.ItemArray(0)
        Dim UserIDForeignKey

        For record_index = 0 To InStockDS.GetLength() - 1
            RecordOrder.Add(New List(Of Object))
            If QualityFilter = "XX" Or (QualityFilter = InStockDS.GetRecordItem(record_index, 3)) Then
                RecordOrder(record_index).Add(InStockDS.GetRecordAsList(record_index))
            Else
                Continue For
            End If
            UserIDForeignKey = RecordOrder(record_index)(0)(1)

            For item_record_index = 0 To InItemDS.GetLength() - 1
                If UserIDForeignKey = InItemDS.GetRecordItem(item_record_index, 0) Then 'if ItemID in stock record matches an itemID in item record
                    For desired_attributes = 1 To InItemDS.GetWidth - 1
                        RecordOrder(record_index)(0).Add(InItemDS.GetRecordItem(item_record_index, desired_attributes))
                    Next
                End If
            Next

        Next
    End Sub
    Private Sub btn_confirm_delete_choice_Click(sender As Object, e As EventArgs) Handles btn_confirm_delete_choice.Click
        If num_remove_quantity.Value <> 0 Then
            'Sets the information for removal
            'returns the array of '{StockID , StockName, StockQuality, StockQuantity (selected), StockQuality (difference), StockPrice}
            InfoForRemoval(0) = (RecordOrder(NavigationIndex)(0)(0))
            InfoForRemoval(1) = lbl_item_name.Text
            InfoForRemoval(2) = txt_item_quality.Text
            InfoForRemoval(3) = (num_remove_quantity.Value)
            InfoForRemoval(4) = (RecordOrder(NavigationIndex)(0)(2) - num_remove_quantity.Value)
            InfoForRemoval(5) = (RecordOrder(NavigationIndex)(0)(4))
            Me.Close()
        End If

    End Sub
    Private Sub UpdateNavButtons() 'updates fields for navigation buttons
        If NavigationIndex < 1 Then
            btn_previous_record.Enabled = False
            btn_next_record.Enabled = True
        ElseIf NavigationIndex = (RecordOrder.Count - 1) Then
            btn_next_record.Enabled = False
            btn_previous_record.Enabled = True
        Else
            btn_previous_record.Enabled = True
            btn_next_record.Enabled = True
        End If
    End Sub
    Private Sub btn_next_record_Click(sender As Object, e As EventArgs) Handles btn_next_record.Click
        NavigationIndex += 1
        UpdateNavButtons()
        UpdateRecordDetils()
    End Sub
    Private Sub btn_previous_record_Click(sender As Object, e As EventArgs) Handles btn_previous_record.Click
        NavigationIndex -= 1
        UpdateNavButtons()
        UpdateRecordDetils()
    End Sub

End Class