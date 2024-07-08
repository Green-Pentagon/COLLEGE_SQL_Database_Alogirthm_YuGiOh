<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Login
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
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.lbl_signin = New System.Windows.Forms.Label()
        Me.btn_run_check = New System.Windows.Forms.Button()
        Me.lbl_error_msg = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(106, 70)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(157, 23)
        Me.txt_username.TabIndex = 0
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(106, 99)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(157, 23)
        Me.txt_password.TabIndex = 1
        Me.txt_password.UseSystemPasswordChar = True
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Location = New System.Drawing.Point(37, 73)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(63, 15)
        Me.lbl_username.TabIndex = 2
        Me.lbl_username.Text = "Username:"
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Location = New System.Drawing.Point(40, 102)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(60, 15)
        Me.lbl_password.TabIndex = 3
        Me.lbl_password.Text = "Password:"
        '
        'lbl_signin
        '
        Me.lbl_signin.AutoSize = True
        Me.lbl_signin.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_signin.Location = New System.Drawing.Point(106, 21)
        Me.lbl_signin.Name = "lbl_signin"
        Me.lbl_signin.Size = New System.Drawing.Size(76, 30)
        Me.lbl_signin.TabIndex = 4
        Me.lbl_signin.Text = "Sign in"
        '
        'btn_run_check
        '
        Me.btn_run_check.Location = New System.Drawing.Point(106, 143)
        Me.btn_run_check.Name = "btn_run_check"
        Me.btn_run_check.Size = New System.Drawing.Size(75, 23)
        Me.btn_run_check.TabIndex = 5
        Me.btn_run_check.Text = "Enter"
        Me.btn_run_check.UseVisualStyleBackColor = True
        '
        'lbl_error_msg
        '
        Me.lbl_error_msg.AutoSize = True
        Me.lbl_error_msg.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_error_msg.ForeColor = System.Drawing.Color.Red
        Me.lbl_error_msg.Location = New System.Drawing.Point(55, 125)
        Me.lbl_error_msg.Name = "lbl_error_msg"
        Me.lbl_error_msg.Size = New System.Drawing.Size(176, 15)
        Me.lbl_error_msg.TabIndex = 6
        Me.lbl_error_msg.Text = "Incorrect username or password"
        Me.lbl_error_msg.Visible = False
        '
        'Form_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 186)
        Me.Controls.Add(Me.lbl_error_msg)
        Me.Controls.Add(Me.btn_run_check)
        Me.Controls.Add(Me.lbl_signin)
        Me.Controls.Add(Me.lbl_username)
        Me.Controls.Add(Me.lbl_password)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.txt_password)
        Me.MaximumSize = New System.Drawing.Size(311, 225)
        Me.MinimumSize = New System.Drawing.Size(311, 225)
        Me.Name = "Form_Login"
        Me.Text = "Card Stock Database"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_username As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents lbl_username As Label
    Friend WithEvents lbl_password As Label
    Friend WithEvents lbl_signin As Label
    Friend WithEvents btn_run_check As Button
    Friend WithEvents lbl_error_msg As Label
End Class
