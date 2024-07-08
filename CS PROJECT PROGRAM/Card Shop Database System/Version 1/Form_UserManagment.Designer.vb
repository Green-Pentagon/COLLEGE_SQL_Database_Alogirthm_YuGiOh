<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_UserManagment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cbox_UserSelection = New System.Windows.Forms.ComboBox()
        Me.lbl_header = New System.Windows.Forms.Label()
        Me.btn_edit_selected_user = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.lbl_select_user = New System.Windows.Forms.Label()
        Me.btn_MakeNewAccount = New System.Windows.Forms.Button()
        Me.btn_select_customer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbox_UserSelection
        '
        Me.cbox_UserSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_UserSelection.FormattingEnabled = True
        Me.cbox_UserSelection.Location = New System.Drawing.Point(12, 77)
        Me.cbox_UserSelection.Name = "cbox_UserSelection"
        Me.cbox_UserSelection.Size = New System.Drawing.Size(420, 23)
        Me.cbox_UserSelection.TabIndex = 0
        '
        'lbl_header
        '
        Me.lbl_header.AutoSize = True
        Me.lbl_header.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_header.Location = New System.Drawing.Point(12, 9)
        Me.lbl_header.Name = "lbl_header"
        Me.lbl_header.Size = New System.Drawing.Size(199, 30)
        Me.lbl_header.TabIndex = 2
        Me.lbl_header.Text = "Select Profile to Edit"
        '
        'btn_edit_selected_user
        '
        Me.btn_edit_selected_user.Location = New System.Drawing.Point(309, 121)
        Me.btn_edit_selected_user.Name = "btn_edit_selected_user"
        Me.btn_edit_selected_user.Size = New System.Drawing.Size(75, 23)
        Me.btn_edit_selected_user.TabIndex = 3
        Me.btn_edit_selected_user.Text = "Edit"
        Me.btn_edit_selected_user.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(228, 121)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 4
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'lbl_select_user
        '
        Me.lbl_select_user.AutoSize = True
        Me.lbl_select_user.Location = New System.Drawing.Point(12, 56)
        Me.lbl_select_user.Name = "lbl_select_user"
        Me.lbl_select_user.Size = New System.Drawing.Size(78, 15)
        Me.lbl_select_user.TabIndex = 1
        Me.lbl_select_user.Text = "Select Profile:"
        '
        'btn_MakeNewAccount
        '
        Me.btn_MakeNewAccount.Location = New System.Drawing.Point(147, 121)
        Me.btn_MakeNewAccount.Name = "btn_MakeNewAccount"
        Me.btn_MakeNewAccount.Size = New System.Drawing.Size(75, 23)
        Me.btn_MakeNewAccount.TabIndex = 5
        Me.btn_MakeNewAccount.Text = "Make New"
        Me.btn_MakeNewAccount.UseVisualStyleBackColor = True
        '
        'btn_select_customer
        '
        Me.btn_select_customer.Location = New System.Drawing.Point(66, 121)
        Me.btn_select_customer.Name = "btn_select_customer"
        Me.btn_select_customer.Size = New System.Drawing.Size(75, 23)
        Me.btn_select_customer.TabIndex = 6
        Me.btn_select_customer.Text = "Select"
        Me.btn_select_customer.UseVisualStyleBackColor = True
        '
        'Form_UserManagment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 156)
        Me.Controls.Add(Me.btn_select_customer)
        Me.Controls.Add(Me.btn_MakeNewAccount)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_edit_selected_user)
        Me.Controls.Add(Me.lbl_header)
        Me.Controls.Add(Me.lbl_select_user)
        Me.Controls.Add(Me.cbox_UserSelection)
        Me.MaximumSize = New System.Drawing.Size(467, 195)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(467, 195)
        Me.Name = "Form_UserManagment"
        Me.Text = "Manage Users"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbox_UserSelection As ComboBox
    Friend WithEvents lbl_header As Label
    Friend WithEvents btn_edit_selected_user As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents lbl_select_user As Label
    Friend WithEvents btn_MakeNewAccount As Button
    Friend WithEvents btn_select_customer As Button
End Class
