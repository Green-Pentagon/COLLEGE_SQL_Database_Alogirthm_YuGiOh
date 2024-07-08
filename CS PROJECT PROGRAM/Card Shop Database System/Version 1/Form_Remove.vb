Public Class Form_Remove

    Private RemovalStack As Stack(Of Object) = New Stack(Of Object)

    'Dim NewSearchForm = New Form_Search() 
    'Structure : {{STOCK ITEM INFORMATION} , {StockID , StockName, StockQuality, StockQuantity (selected), StockQuality (difference), StockPrice}}
    'Dim RemoveQueueLine = NewSearchForm.GetResultFormSelection() 'Needs to be refreshed every time is refreshed
    Private UserID
    Public Sub New(ProvidedUserID)
        InitializeComponent()
        UserID = ProvidedUserID
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub RemoveLastItemFromStack()
        'If stack not empty, remove the last added item on the stack & remove the item from the lsit box view
        If RemovalStack.Count <> 0 Then
            RemovalStack.Pop()
            lbox_RemovePile.Items.RemoveAt(lbox_RemovePile.Items.Count - 1)
        End If
    End Sub
    Private Sub AddItemToStack(ItemInfo() As Object)
        'Tests If nothing was entered into the search & search result forms, adds the item info, otherwise does nothing
        If ItemInfo IsNot Nothing Then
            If ItemInfo(0) <> Nothing Then
                For Each item In RemovalStack 'Checks if the StockID of item the user wishes to add is the same as one which already exists in the stack
                    If ItemInfo(0) = item(0) Then
                        MsgBox("You already added this item to the queue!", MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                Next
                RemovalStack.Push(ItemInfo)
                lbox_RemovePile.Items.Add(ItemInfo(1) & " (" & ItemInfo(2) & ")" & " | x" & ItemInfo(3))
            End If
        End If
    End Sub

    Private Sub btn_AddStockItem_Click(sender As Object, e As EventArgs) Handles btn_AddStockItem.Click
        'Opens a new instance of search form in tossing it's mode of operation as "Remove" so it knows to perpare the values to be returned.
        Dim NewFormInstance = New Form_Search("Remove")
        NewFormInstance.ShowDialog()
        AddItemToStack(NewFormInstance.GetResultFormSelection())
    End Sub
    Private Sub btn_ConfimDeletion_Click(sender As Object, e As EventArgs) Handles btn_ConfimDeletion.Click
        'If queue isn't empty, set up the remove fields and values for every item in the removal stack
        If RemovalStack.Count <> 0 Then
            Dim UpdateStackTable As New NewDataSet("tblStock", mod_DB_communication.GetDatabaseObject, "*", "", "")
            Dim ParameterName() As String = {"StockQuantity"}
            Dim ValueToInsert(0) As Object
            Dim WhereCondition As String

            Dim RemovalMode = MsgBox("Is this a customer's order? ", MsgBoxStyle.YesNoCancel Or MsgBoxStyle.Question)
            If RemovalMode = 7 Then 'If not a customer order
                For Each stack_item In RemovalStack
                    mod_log_changes.LogChange(UserID, stack_item(0), "Removed " & stack_item(3) & " Of item ")
                Next
            ElseIf RemovalMode = 6 Then 'If a customer order, allow the user to select a customer
                Dim NewCustomerViewForm = New Form_UserManagment({"SELECTING CUSTOMER"})
                Dim CustomerDetails() As Object
                Do 'This loop allows the user to make and then associate a customer with the order: an oversight is that the user can make infinate amount of customers
                    'This loop will automatically exit once a customer has been selected.
                    NewCustomerViewForm = New Form_UserManagment({"SELECTING CUSTOMER"})
                    NewCustomerViewForm.ShowDialog()
                    CustomerDetails = NewCustomerViewForm.FetchCustomerDetails()
                Loop While CustomerDetails Is Nothing Or CustomerDetails.Length = 1
                'Information stored in CustomerDetails = {Dummy Value, CustomerID, CustomerFirstName, CustomerSurname, CustomerTelephone, CustomerEmail}

                'Prepares the information from the stack into a list of objects, which is the data type that the module logging the order accepts
                'While it does add an extra step in the process, it allows for easier future expansions, say if the data structurer is changed into a list,
                'Where the user could select what item to remove from the currently selected items.
                Dim OrderList As List(Of Object) = New List(Of Object)
                For Each stack_item In RemovalStack
                    OrderList.Add(stack_item)
                Next
                mod_log_orders.LogOrder(CustomerDetails(1), OrderList)
            Else
                MsgBox("Removal Cancelled")
                Exit Sub
            End If

            'For every item in the removal stack, updat the database file directly with the new item
            For Each stack_item In RemovalStack
                ValueToInsert(0) = (stack_item(4))
                WhereCondition = "StockID = " & stack_item(0)
                UpdateStackTable.UpdateRecordInDB(mod_DB_communication.GetDatabaseObject, "tblStock", ParameterName, ValueToInsert, WhereCondition)
            Next
            MsgBox("Selected Items have been removed", MsgBoxStyle.Information)
            Me.Close()
        End If
    End Sub
    Private Sub btn_RemoveSelectedItem_Click(sender As Object, e As EventArgs) Handles btn_RemoveSelectedItem.Click
        RemoveLastItemFromStack()
    End Sub
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub
End Class