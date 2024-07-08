Module mod_log_orders
    Private Sub WriteIntoFile(CustomerID As Object, OrderInformation As List(Of Object), OrderLineInformation As List(Of Object))
        'Private method subroutine which prints the order text file that can be viewed in the Log Viewer form or manually
        'If any order files exist which are the same in order number, it will simply append the order onto that file
        Dim streamAppender As IO.StreamWriter
        Dim FileLine As String = ""
        Dim Filepath As String = Environment.CurrentDirectory.Replace("bin\Debug\net5.0-windows", "Files\Orders Log\")
        Filepath += "Order Log - Order ID (" & OrderInformation(0) & ").txt"
        streamAppender = New IO.StreamWriter(Filepath, True)


        streamAppender.WriteLine("CustomerID | OrderTimeStamp | OrderCostSum |")
        For Each item In OrderInformation
            FileLine += item & " | "
        Next
        streamAppender.WriteLine(FileLine)

        FileLine = ""
        streamAppender.WriteLine(vbCrLf & "--------------------------------------------")
        streamAppender.WriteLine(FileLine.TrimEnd())
        streamAppender.WriteLine("ORDER BREAKDOWN" & vbCrLf & vbCrLf & "Stock ID | Quantity Ordered | Sum |")

        For Each item In OrderLineInformation
            For Each sub_item In item
                If sub_item IsNot item(0) Then
                    FileLine += sub_item & " | "
                End If
            Next
            streamAppender.WriteLine(FileLine.TrimEnd())
            FileLine = ""
        Next

        streamAppender.WriteLine(vbCrLf & "--------------------------------------------")
        streamAppender.Close()
    End Sub


    Sub LogOrder(CustomerID As Object, OrderInformation As List(Of Object))
        'Structure Of OrderInformation : {{STOCK ITEM INFORMATION} , {StockID , StockName, StockQuality, StockQuantity (selected), StockQuality (difference), StockPrice}}

        Dim OrderDS As New NewDataSet("tblOrder", mod_DB_communication.GetDatabaseObject, "*", "", "")
        Dim OrderLineDS As New NewDataSet("tblOrderLine", mod_DB_communication.GetDatabaseObject, "*", "", "")
        Dim Orderfields() As String = {"CustomerID", "OrderTimestamp", "OrderCostSum"}
        Dim totalCost As Double = 0.00

        For Each price In OrderInformation 'sets the total price of all the order items depending on how much of the item was bought
            totalCost += (price(3) * price(5))
        Next
        totalCost = Math.Round(totalCost, 2)
        Dim OrderValues() As Object = {CustomerID, ("'[" & System.DateTime.Now.ToString & "]'"), totalCost}
        Dim OrderLinefields() As String = {"OrderID", "StockID", "OrderLineQuantity", "OrderLineCost"}
        Dim OrderLineValues() As Object
        Dim OrderLineCostCombined As Double

        OrderDS.InsertNewRecordIntoDB(mod_DB_communication.GetDatabaseObject, "tblOrder", Orderfields, OrderValues, "")
        OrderDS = New NewDataSet("tblOrder", mod_DB_communication.GetDatabaseObject, "*", "", "OrderID DESC")
        'Re-establishes the dataset with the new order record: since the orderID is an automatically incrmeneting number, the highest number will always be the last record added.


        Dim FileInfoOrder As List(Of Object) = OrderDS.GetRecordAsList(0)   'Stores the same information as the record for the order in table tblOrder does
        Dim FileInfoOrderLines As List(Of Object) = New List(Of Object)     'Stores the information of every line in order for File making

        For Each item_ordered In OrderInformation 'individually adds a new OrderLine record with relevant information into the DB file
            OrderLineCostCombined = (item_ordered(3) * item_ordered(5))
            OrderLineValues = {(OrderDS.GetRecordItem(0, 0)), item_ordered(0), item_ordered(3), OrderLineCostCombined}
            FileInfoOrderLines.Add({(OrderDS.GetRecordItem(0, 0)), item_ordered(0), item_ordered(3), OrderLineCostCombined})
            OrderLineDS.InsertNewRecordIntoDB(mod_DB_communication.GetDatabaseObject, "tblOrderLine", OrderLinefields, OrderLineValues, "")
        Next

        WriteIntoFile(CustomerID, FileInfoOrder, FileInfoOrderLines)
    End Sub
End Module
