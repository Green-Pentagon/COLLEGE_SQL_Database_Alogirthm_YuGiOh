<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Edit_Profile
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_FirstName = New System.Windows.Forms.TextBox()
        Me.txt_Surname = New System.Windows.Forms.TextBox()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_password_confirm = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.lbl_FirstName = New System.Windows.Forms.Label()
        Me.lbl_Surname = New System.Windows.Forms.Label()
        Me.lbl_Email = New System.Windows.Forms.Label()
        Me.lbl_Username = New System.Windows.Forms.Label()
        Me.lbl_Password = New System.Windows.Forms.Label()
        Me.lbl_Confirm_Password = New System.Windows.Forms.Label()
        Me.lbl_header = New System.Windows.Forms.Label()
        Me.btn_confirm_changes = New System.Windows.Forms.Button()
        Me.btn_cancel_changes = New System.Windows.Forms.Button()
        Me.chk_changepassword = New System.Windows.Forms.CheckBox()
        Me.chk_showpassword = New System.Windows.Forms.CheckBox()
        Me.lbl_AccessLevel = New System.Windows.Forms.Label()
        Me.txt_access_level = New System.Windows.Forms.TextBox()
        Me.group_password_controls = New System.Windows.Forms.GroupBox()
        Me.group_password_controls.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_FirstName
        '
        Me.txt_FirstName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_FirstName.Location = New System.Drawing.Point(166, 56)
        Me.txt_FirstName.MaxLength = 20
        Me.txt_FirstName.Name = "txt_FirstName"
        Me.txt_FirstName.ReadOnly = True
        Me.txt_FirstName.Size = New System.Drawing.Size(145, 23)
        Me.txt_FirstName.TabIndex = 0
        '
        'txt_Surname
        '
        Me.txt_Surname.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Surname.Location = New System.Drawing.Point(166, 85)
        Me.txt_Surname.MaxLength = 30
        Me.txt_Surname.Name = "txt_Surname"
        Me.txt_Surname.ReadOnly = True
        Me.txt_Surname.Size = New System.Drawing.Size(145, 23)
        Me.txt_Surname.TabIndex = 1
        '
        'txt_username
        '
        Me.txt_username.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_username.Location = New System.Drawing.Point(166, 143)
        Me.txt_username.MaxLength = 30
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(145, 23)
        Me.txt_username.TabIndex = 3
        '
        'txt_email
        '
        Me.txt_email.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_email.Location = New System.Drawing.Point(166, 114)
        Me.txt_email.MaxLength = 50
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(145, 23)
        Me.txt_email.TabIndex = 2
        '
        'txt_password_confirm
        '
        Me.txt_password_confirm.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_password_confirm.Location = New System.Drawing.Point(176, 45)
        Me.txt_password_confirm.MaxLength = 30
        Me.txt_password_confirm.Name = "txt_password_confirm"
        Me.txt_password_confirm.ReadOnly = True
        Me.txt_password_confirm.Size = New System.Drawing.Size(145, 23)
        Me.txt_password_confirm.TabIndex = 5
        Me.txt_password_confirm.UseSystemPasswordChar = True
        '
        'txt_password
        '
        Me.txt_password.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_password.Location = New System.Drawing.Point(176, 16)
        Me.txt_password.MaxLength = 30
        Me.txt_password.Name = "txt_password"
        Me.txt_password.ReadOnly = True
        Me.txt_password.Size = New System.Drawing.Size(145, 23)
        Me.txt_password.TabIndex = 4
        Me.txt_password.UseSystemPasswordChar = True
        '
        'lbl_FirstName
        '
        Me.lbl_FirstName.AutoSize = True
        Me.lbl_FirstName.Location = New System.Drawing.Point(13, 59)
        Me.lbl_FirstName.Name = "lbl_FirstName"
        Me.lbl_FirstName.Size = New System.Drawing.Size(67, 15)
        Me.lbl_FirstName.TabIndex = 6
        Me.lbl_FirstName.Text = "First Name:"
        '
        'lbl_Surname
        '
        Me.lbl_Surname.AutoSize = True
        Me.lbl_Surname.Location = New System.Drawing.Point(13, 88)
        Me.lbl_Surname.Name = "lbl_Surname"
        Me.lbl_Surname.Size = New System.Drawing.Size(57, 15)
        Me.lbl_Surname.TabIndex = 7
        Me.lbl_Surname.Text = "Surname:"
        '
        'lbl_Email
        '
        Me.lbl_Email.AutoSize = True
        Me.lbl_Email.Location = New System.Drawing.Point(13, 117)
        Me.lbl_Email.Name = "lbl_Email"
        Me.lbl_Email.Size = New System.Drawing.Size(39, 15)
        Me.lbl_Email.TabIndex = 8
        Me.lbl_Email.Text = "Email:"
        '
        'lbl_Username
        '
        Me.lbl_Username.AutoSize = True
        Me.lbl_Username.Location = New System.Drawing.Point(13, 146)
        Me.lbl_Username.Name = "lbl_Username"
        Me.lbl_Username.Size = New System.Drawing.Size(63, 15)
        Me.lbl_Username.TabIndex = 9
        Me.lbl_Username.Text = "Username:"
        '
        'lbl_Password
        '
        Me.lbl_Password.AutoSize = True
        Me.lbl_Password.Location = New System.Drawing.Point(23, 19)
        Me.lbl_Password.Name = "lbl_Password"
        Me.lbl_Password.Size = New System.Drawing.Size(60, 15)
        Me.lbl_Password.TabIndex = 10
        Me.lbl_Password.Text = "Password:"
        '
        'lbl_Confirm_Password
        '
        Me.lbl_Confirm_Password.AutoSize = True
        Me.lbl_Confirm_Password.Location = New System.Drawing.Point(22, 48)
        Me.lbl_Confirm_Password.Name = "lbl_Confirm_Password"
        Me.lbl_Confirm_Password.Size = New System.Drawing.Size(107, 15)
        Me.lbl_Confirm_Password.TabIndex = 11
        Me.lbl_Confirm_Password.Text = "Confirm Password:"
        '
        'lbl_header
        '
        Me.lbl_header.AutoSize = True
        Me.lbl_header.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_header.Location = New System.Drawing.Point(81, 9)
        Me.lbl_header.Name = "lbl_header"
        Me.lbl_header.Size = New System.Drawing.Size(159, 30)
        Me.lbl_header.TabIndex = 12
        Me.lbl_header.Text = "Account Details"
        '
        'btn_confirm_changes
        '
        Me.btn_confirm_changes.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_confirm_changes.Location = New System.Drawing.Point(57, 347)
        Me.btn_confirm_changes.Name = "btn_confirm_changes"
        Me.btn_confirm_changes.Size = New System.Drawing.Size(101, 40)
        Me.btn_confirm_changes.TabIndex = 13
        Me.btn_confirm_changes.Text = "Confirm"
        Me.btn_confirm_changes.UseVisualStyleBackColor = True
        '
        'btn_cancel_changes
        '
        Me.btn_cancel_changes.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_cancel_changes.Location = New System.Drawing.Point(164, 347)
        Me.btn_cancel_changes.Name = "btn_cancel_changes"
        Me.btn_cancel_changes.Size = New System.Drawing.Size(101, 40)
        Me.btn_cancel_changes.TabIndex = 14
        Me.btn_cancel_changes.Text = "Cancel"
        Me.btn_cancel_changes.UseVisualStyleBackColor = True
        '
        'chk_changepassword
        '
        Me.chk_changepassword.AutoSize = True
        Me.chk_changepassword.Location = New System.Drawing.Point(23, 75)
        Me.chk_changepassword.Name = "chk_changepassword"
        Me.chk_changepassword.Size = New System.Drawing.Size(120, 19)
        Me.chk_changepassword.TabIndex = 15
        Me.chk_changepassword.Text = "Change Password"
        Me.chk_changepassword.UseVisualStyleBackColor = True
        '
        'chk_showpassword
        '
        Me.chk_showpassword.AutoSize = True
        Me.chk_showpassword.Location = New System.Drawing.Point(23, 100)
        Me.chk_showpassword.Name = "chk_showpassword"
        Me.chk_showpassword.Size = New System.Drawing.Size(108, 19)
        Me.chk_showpassword.TabIndex = 16
        Me.chk_showpassword.Text = "Show Password"
        Me.chk_showpassword.UseVisualStyleBackColor = True
        '
        'lbl_AccessLevel
        '
        Me.lbl_AccessLevel.AutoSize = True
        Me.lbl_AccessLevel.Location = New System.Drawing.Point(13, 175)
        Me.lbl_AccessLevel.Name = "lbl_AccessLevel"
        Me.lbl_AccessLevel.Size = New System.Drawing.Size(76, 15)
        Me.lbl_AccessLevel.TabIndex = 18
        Me.lbl_AccessLevel.Text = "Access Level:"
        '
        'txt_access_level
        '
        Me.txt_access_level.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_access_level.Location = New System.Drawing.Point(166, 172)
        Me.txt_access_level.MaxLength = 4
        Me.txt_access_level.Name = "txt_access_level"
        Me.txt_access_level.ReadOnly = True
        Me.txt_access_level.Size = New System.Drawing.Size(145, 23)
        Me.txt_access_level.TabIndex = 17
        '
        'group_password_controls
        '
        Me.group_password_controls.Controls.Add(Me.lbl_Password)
        Me.group_password_controls.Controls.Add(Me.txt_password)
        Me.group_password_controls.Controls.Add(Me.txt_password_confirm)
        Me.group_password_controls.Controls.Add(Me.chk_showpassword)
        Me.group_password_controls.Controls.Add(Me.lbl_Confirm_Password)
        Me.group_password_controls.Controls.Add(Me.chk_changepassword)
        Me.group_password_controls.Location = New System.Drawing.Point(-10, 201)
        Me.group_password_controls.Name = "group_password_controls"
        Me.group_password_controls.Size = New System.Drawing.Size(346, 137)
        Me.group_password_controls.TabIndex = 19
        Me.group_password_controls.TabStop = False
        '
        'Form_Edit_Profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 399)
        Me.Controls.Add(Me.group_password_controls)
        Me.Controls.Add(Me.lbl_AccessLevel)
        Me.Controls.Add(Me.txt_access_level)
        Me.Controls.Add(Me.btn_cancel_changes)
        Me.Controls.Add(Me.btn_confirm_changes)
        Me.Controls.Add(Me.lbl_header)
        Me.Controls.Add(Me.lbl_Username)
        Me.Controls.Add(Me.lbl_Email)
        Me.Controls.Add(Me.lbl_Surname)
        Me.Controls.Add(Me.lbl_FirstName)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_Surname)
        Me.Controls.Add(Me.txt_FirstName)
        Me.MaximumSize = New System.Drawing.Size(339, 438)
        Me.MinimumSize = New System.Drawing.Size(339, 438)
        Me.Name = "Form_Edit_Profile"
        Me.Text = "Edit Profile"
        Me.group_password_controls.ResumeLayout(False)
        Me.group_password_controls.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_FirstName As TextBox
    Friend WithEvents txt_Surname As TextBox
    Friend WithEvents txt_username As TextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_password_confirm As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents lbl_FirstName As Label
    Friend WithEvents lbl_Surname As Label
    Friend WithEvents lbl_Email As Label
    Friend WithEvents lbl_Username As Label
    Friend WithEvents lbl_Password As Label
    Friend WithEvents lbl_Confirm_Password As Label
    Friend WithEvents lbl_header As Label
    Friend WithEvents btn_confirm_changes As Button
    Friend WithEvents btn_cancel_changes As Button
    Friend WithEvents chk_changepassword As CheckBox
    Friend WithEvents chk_showpassword As CheckBox
    Friend WithEvents lbl_AccessLevel As Label
    Friend WithEvents txt_access_level As TextBox
    Friend WithEvents group_password_controls As GroupBox
End Class
