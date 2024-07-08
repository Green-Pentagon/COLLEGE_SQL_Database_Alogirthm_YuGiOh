Public Class Form_UserManagment
    Private TableName As String
    Private selectedTableDS
    Private DSCopy As List(Of Object)
    'Details stored in DSCopy: UserID, Username, Password, AccessLvl, FirstName, Surname, Email
    'OR If the admin decides to use the customer table
    'CustomerID, CustomerFirstName, CustomerSurname, CustomerTelephone, CustomerEmail
    Private UserDetails 'Order of details: Temporary Value , UserID, Username, Password, AccessLvl, FirstName, Surname, Email

    Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
        If e.CloseReason = CloseReason.UserClosing And Not e.Cancel Then
            cbox_UserSelection.Items.Clear()
        End If
    End Sub
    Public Sub New(AdminUserDetails)
        InitializeComponent()
        UserDetails = AdminUserDetails
        If UserDetails(0) = "SELECTING CUSTOMER" Then
            TableName = "tblCustomer"
            btn_edit_selected_user.Visible = False
        Else
            btn_select_customer.Visible = False
        End If
    End Sub
    Private Sub SetUpComboBox(ByRef selectedTableDS)
        DSCopy = New List(Of Object)
        For record_index = 0 To selectedTableDS.GetLength() - 1
            DSCopy.Add(selectedTableDS.GetRecordAsList(record_index))
            If TableName = "tblUser" Then
                cbox_UserSelection.Items.Add(selectedTableDS.GetRecordItem(record_index, 4) & " | " & selectedTableDS.GetRecordItem(record_index, 5) & "  |  (" & selectedTableDS.GetRecordItem(record_index, 1) & ")  |  " & selectedTableDS.GetRecordItem(record_index, 3))
            Else
                cbox_UserSelection.Items.Add(selectedTableDS.GetRecordItem(record_index, 1) & " | " & selectedTableDS.GetRecordItem(record_index, 2) & "  |  (" & selectedTableDS.GetRecordItem(record_index, 4) & ")")
            End If
        Next
        cbox_UserSelection.SelectedIndex() = 0
    End Sub
    Private Sub Form_UserManagment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Icon = New Icon(Environment.CurrentDirectory.Replace("bin\Debug\net5.0-windows", "Files\Icons\Form_User_Managment.ico"))
        Catch ex As IO.FileNotFoundException
        End Try

        If UserDetails(0) <> "SELECTING CUSTOMER" Then 'skips the process of choosing the table if the user comes from the remove form
            Dim TableToSelect = MsgBox("Do you wish to manage Customers instead of system users?", MsgBoxStyle.Question Or MsgBoxStyle.YesNoCancel)
            Select Case TableToSelect
                Case 6 'if yes clicked
                    TableName = "tblCustomer"
                Case 7 'If no clicked
                    TableName = "tblUser"
                Case Else 'If cancel is clicked or form is closed
                    Me.Close()
                    Exit Sub
            End Select
        End If
        Dim SortByName As String = TableName.Replace("tbl", "") + "Surname ASC"
        selectedTableDS = New NewDataSet(TableName, mod_DB_communication.GetDatabaseObject, "*", "", SortByName)
        SetUpComboBox(selectedTableDS)
    End Sub



    Private Sub btn_edit_selected_user_Click(sender As Object, e As EventArgs) Handles btn_edit_selected_user.Click
        'Order of details: Temporary Value , UserID, Username, Password, AccessLvl, FirstName, Surname, Email
        'Since the temporary serves it purpose during the login authentication and is still passed on to EditProfile form,
        'It can be utilised to tell the form that the profile should be of a customer
        Dim UserValues(DSCopy(cbox_UserSelection.SelectedIndex).Count()) As Object

        If TableName = "tblCustomer" Then 'Puts the first value of the UserDetails array within Edit_profile to use by serving to differentiate between user and customer
            UserValues(0) = ("CUSTOMER")
        Else
            UserValues(0) = ("USER")
        End If
        For index = 1 To DSCopy(cbox_UserSelection.SelectedIndex).Count()
            UserValues(index) = (DSCopy(cbox_UserSelection.SelectedIndex)(index - 1))
        Next

        Dim NewEditFormInstance = New Form_Edit_Profile(UserValues, "Admin")
        NewEditFormInstance.ShowDialog()
        Me.Close()
    End Sub
    Private Sub btn_MakeNewAccount_Click(sender As Object, e As EventArgs) Handles btn_MakeNewAccount.Click
        Dim UserValues(DSCopy(cbox_UserSelection.SelectedIndex).Count()) As Object
        'Dummy array that is empty but the right size to not throw exceptions when tossed into edit profile form.
        If TableName = "tblCustomer" Then 'Puts the first value of the UserDetails array within Edit_profile to use by serving to differentiate between user and customer
            UserValues(0) = ("CUSTOMER")
        Else
            UserValues(0) = ("USER")
        End If
        Dim NewEditFormInstance = New Form_Edit_Profile(UserValues, "MakeNew")
        NewEditFormInstance.ShowDialog()
        Me.Close()
    End Sub
    Public Function FetchCustomerDetails()
        Return UserDetails
    End Function
    Private Sub btn_select_customer_Click(sender As Object, e As EventArgs) Handles btn_select_customer.Click
        ReDim UserDetails(DSCopy(cbox_UserSelection.SelectedIndex).Count())
        For index = 1 To DSCopy(cbox_UserSelection.SelectedIndex).Count()
            UserDetails(index) = (DSCopy(cbox_UserSelection.SelectedIndex)(index - 1))
        Next
        Me.Close()
    End Sub
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub
    'DUE TO THE CASCADE EFFECT OF DELETING USERS OR CUSTOMERS FROM RECORDS, IT IS OUT OF MY SKILL SET TO IMPLEMENT
    'Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
    '    Dim UserValues(DSCopy(cbox_UserSelection.SelectedIndex).Count()) As Object

    '    For index = 1 To DSCopy(cbox_UserSelection.SelectedIndex).Count()
    '        UserValues(index) = (DSCopy(cbox_UserSelection.SelectedIndex)(index - 1))
    '    Next

    '    If TableName = "tblUser" And UserDetails(1) = DSCopy(cbox_UserSelection.SelectedIndex)(0) Then
    '        MsgBox("You cannot delete your own account!", MsgBoxStyle.Exclamation)
    '    Else
    '        Dim ConfirmDelete = MsgBox("Are you sure you wish to delete this user? (THIS CHANGE CANNOT BE UNDONE)", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkCancel)
    '        If ConfirmDelete = 1 Then

    '            Dim PropertyIDName As String = TableName.Replace("tbl", "") & "ID"

    '            Dim DeleteUserWhere As String = PropertyIDName & " = " & DSCopy(0)(0)
    '            selectedTableDS.DeleteRecordInDB(mod_DB_communication.GetDatabaseObject, TableName, DeleteUserWhere)
    '        End If
    '    End If
    'End Sub

End Class