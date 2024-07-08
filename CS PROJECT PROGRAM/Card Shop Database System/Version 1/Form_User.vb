Public Class Form_User
    Private UserDetails
    'Position at 0 can be changed to any desired value if needed
    'Order of details: Temporary Value , UserID, Username, Password, AccessLvl, FirstName, Surname, Email
    Public Sub New(userRecord As Array)
        InitializeComponent() 'This call is required by the designer, add any initialization after the InitializeComponent() call.
        UserDetails = userRecord
    End Sub

    Private Sub ReloadUserInformation()
        'performs an automatic refresh of the local array storing user information, in the event that an administrator has changed this user's credentials
        Dim users = New NewDataSet("tblUser", mod_DB_communication.GetDatabaseObject, "*", "UserID = " & UserDetails(1), "")
        UserDetails(0) = "USER"
        For attribute_index = 1 To users.GetWidth
            UserDetails(attribute_index) = users.GetRecordItem(0, attribute_index - 1)
        Next

        Me.Text = "Welcome, " & UserDetails(5) & " " & UserDetails(6)
        'visually display name change
    End Sub


    Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
        'In the event that the user attempts to close down the form, a question message box appears to confirm their choice.
        'Only once user confirms their choice will the program open new instance of login form and close the current user form.
        If e.CloseReason = CloseReason.UserClosing And Not e.Cancel Then
            If MsgBox("Are you sure you want to Log Off?", MsgBoxStyle.Question Or MsgBoxStyle.OkCancel) = vbCancel Then
                e.Cancel = True
            Else
                Dim NewLoginForm As New Form_Login()
                NewLoginForm.Show()
            End If
        End If
    End Sub

    Private Sub Form_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If UserDetails(4) <> "ADMN" Then                    'If user doesn't have admin level access, hide admin features
            Me.group_admin.Hide()
            Me.Width -= group_admin.Width                   'Visual tweak to form
            group_user.Width = group_user.Width * (2 / 3)   'Decrease the size of the user GroupBox by 1/3 & manager group box by a half
            group_manager.Width = group_manager.Width \ 2
            If UserDetails(4) <> "MNGR" Then                'If user doesn't have manager level access, hide manager features
                Me.group_manager.Hide()
                group_user.Width = group_user.Width \ 2     'make GroupBox width even on right side by halfing the width
                group_user.Left += group_admin.Width \ 2    'Centers the group box
            End If
        End If
        Me.MaximumSize = Me.Size                            'Due to Windows10 forms that are displayed, the Locked property doesn't work properly:
        Me.MinimumSize = Me.Size                            'this is an alternative solution
        Try
            Me.Icon = New Icon(Environment.CurrentDirectory.Replace("bin\Debug\net5.0-windows", "Files\Icons\Form_User_icon.ico"))
        Catch ex As IO.FileNotFoundException
        End Try
        Me.Text = "Welcome, " & UserDetails(5) & " " & UserDetails(6)   'Displays the first and last name of the user who logged in
    End Sub

    Private Sub btn_Account_Click(sender As Object, e As EventArgs) Handles btn_Account.Click
        ReloadUserInformation()
        Dim NewEditProfile As New Form_Edit_Profile(UserDetails, "Myself")
        NewEditProfile.ShowDialog()
    End Sub
    Private Sub btn_Search_Click(sender As Object, e As EventArgs) Handles btn_Search.Click
        Dim NewSearchForm As New Form_Search("Search")
        NewSearchForm.ShowDialog()
        'Constructor is ran and tossed the UserID of current user in the event they change pricing in Form_Item later on
        'This is also useful, as when the Remove form will be using this form for indentifing the record to remove, it will
    End Sub
    Private Sub btn_LogOff_Click(sender As Object, e As EventArgs) Handles btn_LogOff.Click
        Me.Close()
    End Sub
    Private Sub btn_RemoveStock_Click(sender As Object, e As EventArgs) Handles btn_RemoveStock.Click
        Dim NewFormInstance As New Form_Remove(UserDetails(1))
        NewFormInstance.ShowDialog()
    End Sub
    Private Sub btn_usermanagment_Click_1(sender As Object, e As EventArgs) Handles btn_usermanagment.Click
        ReloadUserInformation()
        Dim NewFormInstance As New Form_UserManagment(UserDetails)
        Dim NewFormState = NewFormInstance.ShowDialog()
    End Sub
    Private Sub btn_LogViewer_Click(sender As Object, e As EventArgs) Handles btn_LogViewer.Click
        Dim NewFormInstance As New Form_Log_Viewer(UserDetails(4))
        NewFormInstance.Show()
    End Sub
    Private Sub btn_AddStock_Click(sender As Object, e As EventArgs) Handles btn_AddStock.Click
        Dim NewFormInstance As New Form_Add_ItemOrStock(UserDetails(1))
        NewFormInstance.ShowDialog()
    End Sub
End Class