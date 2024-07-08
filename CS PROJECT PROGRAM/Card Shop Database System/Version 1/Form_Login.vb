Public Class Form_Login

    Private ApplicationClosing As Boolean

    Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
        If e.CloseReason = CloseReason.UserClosing And Not e.Cancel And ApplicationClosing Or e.CloseReason = CloseReason.TaskManagerClosing Then
            mod_DB_communication.TerminateDBConnection()
            Application.Exit()
        End If
    End Sub

    Private Sub Form_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'mod_backup.BackupDB()
        ApplicationClosing = True
        Try
            Me.Icon = New Icon(Environment.CurrentDirectory.Replace("bin\Debug\net5.0-windows", "Files\Icons\Form_Login_icon.ico"))
        Catch ex As IO.FileNotFoundException
        End Try
    End Sub

    Private Sub btn_run_check_Click(sender As Object, e As EventArgs) Handles btn_run_check.Click
        Dim validity_check() As String = check_credentials(txt_username.Text, txt_password.Text)

        If validity_check(0) = "True" Then
            ApplicationClosing = False
            Dim UserFormInstance As New Form_User(validity_check)
            UserFormInstance.Show()
            Me.Close()
        Else
            lbl_error_msg.Visible = True
        End If
    End Sub
    Private Sub txt_username_TextChanged(sender As Object, e As EventArgs) Handles txt_username.TextChanged
        lbl_error_msg.Visible = False
    End Sub
    Private Sub txt_password_TextChanged(sender As Object, e As EventArgs) Handles txt_password.TextChanged
        lbl_error_msg.Visible = False
    End Sub
End Class
