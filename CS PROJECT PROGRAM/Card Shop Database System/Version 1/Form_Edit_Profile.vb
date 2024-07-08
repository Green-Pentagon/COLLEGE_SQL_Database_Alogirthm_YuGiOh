Public Class Form_Edit_Profile
    Private UserDetails()
    Private Mode
    Private AllowedAccessLevels() = {"USER", "MNGR", "ADMN"}
    'Order of details: Temporary Value , UserID, Username, Password, AccessLvl, FirstName, Surname, Email
    'OR (IF CUSTOMER)
    'Order of details: Temporary Value , CustomerID, CustomerFirstName, CustomerSurname, CustomerTelephone, CustomerEmail
    Public Sub New(ByRef MyUserDetails As Array, EditMode As String)
        'Modes avaliable: Myself, Admin, MakeNew
        'Myself = A user came from the function that allows them to edit their own account
        'Admin = An administrator level account is editing a user or customer profile
        'MakeNew = Account with privilages is creating a new user or customer profile
        Mode = EditMode
        InitializeComponent()
        UserDetails = MyUserDetails
        If UserDetails(0) = "USER" Then
            'Sets the textbox values equal to the values equivalent in private attribute array
            txt_username.Text = UserDetails(2)
            txt_password.Text = UserDetails(3)
            txt_password_confirm.Text = UserDetails(3)
            txt_access_level.Text = UserDetails(4)
            txt_FirstName.Text = UserDetails(5)
            txt_Surname.Text = UserDetails(6)
            txt_email.Text = UserDetails(7)
            If Mode = "Admin" Then 'If admin is editing a user profile
                txt_FirstName.ReadOnly = False
                txt_Surname.ReadOnly = False
            ElseIf Mode = "MakeNew" Then 'When creating a new customer or user
                txt_FirstName.ReadOnly = False
                txt_Surname.ReadOnly = False
                txt_access_level.ReadOnly = False
                chk_changepassword.Checked = True
                chk_changepassword.Visible = False
            End If
        ElseIf UserDetails(0) = "CUSTOMER" Then
            Me.Height = 300 'adjusts the size of the form so that it looks more appealing when edingint customers
            lbl_Username.Text = "Telephone" 'the txt_username field is used like a telephone text field instead
            txt_FirstName.ReadOnly = False
            txt_Surname.ReadOnly = False
            lbl_AccessLevel.Visible = False
            txt_access_level.Visible = False
            group_password_controls.Visible = False
            txt_FirstName.MaxLength = 12
            txt_FirstName.Text = UserDetails(2)
            txt_Surname.Text = UserDetails(3)
            txt_username.Text = UserDetails(4)
            txt_email.Text = UserDetails(5)
        End If
        Me.MaximumSize = Me.Size
        Me.MinimumSize = Me.Size
    End Sub

    Private Sub Form_Edit_Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try 'Attempts to set the icon of the form: if an icon isn't found, the default setting is applied (no icon or filler icon built in)
            Me.Icon = New Icon(Environment.CurrentDirectory.Replace("bin\Debug\net5.0-windows", "Files\Icons\Form_Edit_Profile_icon.ico"))
        Catch ex As IO.FileNotFoundException
        End Try

    End Sub

    Private Sub Update_User_Details() 'Updates the user details & updates the local DataBase file right after
        Update_UserDetails_User()
        Dim users As New NewDataSet("tblUser", mod_DB_communication.GetDatabaseObject, "*", "", "")

        For user_index = 0 To users.GetLength - 1
            If UserDetails(1) = users.GetRecordItem(user_index, 0) Then
                'sets the corresponding information in UserDetails array in the correct property columns of the actual tables within the DB
                users.SetRecordItem(user_index, 1, UserDetails(2))
                users.SetRecordItem(user_index, 2, UserDetails(3))
                users.SetRecordItem(user_index, 6, UserDetails(7))
                If Mode = "Admin" Then 'update first name and surname if the mode allows it
                    users.SetRecordItem(user_index, 4, UserDetails(5))
                    users.SetRecordItem(user_index, 5, UserDetails(6))
                End If
                users.UpdateDB()
                Exit For
            End If
        Next

    End Sub

    Private Sub Update_UserDetails_User() 'the confusing name makes sense when you think of UserDetails joined together as the attribute of the class
        UserDetails(2) = txt_username.Text
        UserDetails(3) = txt_password.Text
        If Mode = "MakeNew" Then
            UserDetails(4) = txt_access_level.Text
        End If

        UserDetails(5) = txt_FirstName.Text 'Only changed if admin mode is on
        UserDetails(6) = txt_Surname.Text   'Only changed if admin mode is on
        UserDetails(7) = txt_email.Text
    End Sub

    Private Sub Update_UserDetails_Customer()
        UserDetails(2) = txt_FirstName.Text
        UserDetails(3) = txt_Surname.Text
        UserDetails(4) = txt_username.Text
        UserDetails(5) = txt_email.Text
    End Sub

    Private Sub Update_Customer_Details()
        Update_UserDetails_Customer()

        Dim customers As New NewDataSet("tblCustomer", mod_DB_communication.GetDatabaseObject, "*", "", "")
        For customer_index = 0 To customers.GetLength - 1
            If UserDetails(1) = customers.GetRecordItem(customer_index, 0) Then
                customers.SetRecordItem(customer_index, 1, UserDetails(2))
                customers.SetRecordItem(customer_index, 2, UserDetails(3))
                customers.SetRecordItem(customer_index, 4, UserDetails(5))
                customers.UpdateDB()
                Exit For
            End If
        Next
    End Sub

    Private Sub Create_New_Customer()
        Update_UserDetails_Customer()
        Dim CustFields() As String = {"CustomerFirstName", "CustomerSurname", "CustomerTelephone", "CustomerEmail"}
        Dim CustDetails(UserDetails.Length - 3) As Object
        For index = 2 To UserDetails.Length - 1
            CustDetails(index - 2) = "'" & UserDetails(index) & "'"
        Next
        Dim customers As New NewDataSet("tblCustomer", mod_DB_communication.GetDatabaseObject, "*", "", "")

        customers.InsertNewRecordIntoDB(mod_DB_communication.GetDatabaseObject, "tblCustomer", CustFields, CustDetails, "")

    End Sub

    Private Sub Create_New_User()
        Update_UserDetails_User()

        Dim UsrFields() As String = {"UserLogin", "UserPassword", "UserAccessLevel", "UserFirstName", "UserSurname", "UserEmail"}
        Dim UsrDetailsIntoInsert(UserDetails.Length - 3) As Object
        For index = 2 To UserDetails.Length - 1
            UsrDetailsIntoInsert(index - 2) = "'" & UserDetails(index) & "'"
        Next
        Dim user As New NewDataSet("tblUser", mod_DB_communication.GetDatabaseObject, "*", "", "")

        user.InsertNewRecordIntoDB(mod_DB_communication.GetDatabaseObject, "tblUser", UsrFields, UsrDetailsIntoInsert, "")

    End Sub


    Private Sub btn_confirm_changes_Click(sender As Object, e As EventArgs) Handles btn_confirm_changes.Click
        If UserDetails(0) = "USER" Then
            If txt_password.Text.Length > 0 And txt_password_confirm.Text.Length > 0 Then   'If both password fields have soemthing in them (neither are blank)
                If txt_password.Text = txt_password_confirm.Text Then                       'If password has been entered correctly into both fields
                    If txt_password.Text.Length > 9 And txt_password.Text.Length < 31 And txt_username.TextLength > 2 Then  'If password is of suitable length
                        If txt_username.Text.Length > 0 And txt_email.Text.Length > 0 Then  'If username is of suitable length
                            If Mode <> "MakeNew" Then
                                Update_User_Details()
                            Else
                                If AllowedAccessLevels.Contains(txt_access_level.Text) And txt_FirstName.TextLength > 2 And txt_Surname.TextLength > 2 Then
                                    Create_New_User()
                                End If
                            End If
                            Me.Close()
                        Else
                            MsgBox("Username and Email are required!")
                        End If
                    Else
                        MsgBox("Password or Username is invalid, please ensure your password has at least 10 and no more than 30 characters long")
                    End If
                Else
                    txt_password_confirm.ForeColor = Color.Red
                    txt_password.ForeColor = Color.Red
                End If
            Else
                MsgBox("Please enter your password in both fields to confirm any changes made")
            End If
        ElseIf UserDetails(0) = "CUSTOMER" Then 'If dealing with customer data & data is all valid, call sub
            If txt_username.TextLength < 13 And txt_FirstName.TextLength < 21 And txt_Surname.TextLength < 31 And txt_email.TextLength < 51 And txt_FirstName.TextLength > 0 And txt_Surname.TextLength > 0 Then
                If Mode <> "MakeNew" Then
                    Update_Customer_Details()
                Else
                    Create_New_Customer()
                End If
                Me.Close()
            Else
                MsgBox("Please enter a valid customer information!")
            End If
        End If
    End Sub

    Private Sub btn_cancel_changes_Click(sender As Object, e As EventArgs) Handles btn_cancel_changes.Click
        Me.Close()
    End Sub

    Private Sub Reset_password_field_Colours()
        'resets text colours of fields back to black if one of them is red
        If txt_password.ForeColor = Color.Red Then
            txt_password_confirm.ForeColor = Color.Black
            txt_password.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txt_password_confirm_TextChanged(sender As Object, e As EventArgs) Handles txt_password_confirm.TextChanged
        Reset_password_field_Colours()
    End Sub

    Private Sub txt_password_TextChanged(sender As Object, e As EventArgs) Handles txt_password.TextChanged
        Reset_password_field_Colours()
    End Sub

    Private Sub chk_showpassword_CheckedChanged(sender As Object, e As EventArgs) Handles chk_showpassword.CheckedChanged
        txt_password.UseSystemPasswordChar = Not chk_showpassword.Checked
        txt_password_confirm.UseSystemPasswordChar = Not chk_showpassword.Checked
    End Sub

    Private Sub chk_changepassword_CheckedChanged(sender As Object, e As EventArgs) Handles chk_changepassword.CheckedChanged
        txt_password.ReadOnly = Not chk_changepassword.Checked
        txt_password_confirm.ReadOnly = Not chk_changepassword.Checked
    End Sub
End Class