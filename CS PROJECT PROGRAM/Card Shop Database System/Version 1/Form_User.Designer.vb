<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_User
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
        Me.group_manager = New System.Windows.Forms.GroupBox()
        Me.btn_LogViewer = New System.Windows.Forms.Button()
        Me.btn_RemoveStock = New System.Windows.Forms.Button()
        Me.group_admin = New System.Windows.Forms.GroupBox()
        Me.btn_usermanagment = New System.Windows.Forms.Button()
        Me.btn_AddStock = New System.Windows.Forms.Button()
        Me.group_user = New System.Windows.Forms.GroupBox()
        Me.btn_LogOff = New System.Windows.Forms.Button()
        Me.btn_Account = New System.Windows.Forms.Button()
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.lbl_header = New System.Windows.Forms.Label()
        Me.group_manager.SuspendLayout()
        Me.group_admin.SuspendLayout()
        Me.group_user.SuspendLayout()
        Me.SuspendLayout()
        '
        'group_manager
        '
        Me.group_manager.Controls.Add(Me.btn_LogViewer)
        Me.group_manager.Controls.Add(Me.btn_RemoveStock)
        Me.group_manager.Controls.Add(Me.group_admin)
        Me.group_manager.Controls.Add(Me.btn_AddStock)
        Me.group_manager.Location = New System.Drawing.Point(113, 0)
        Me.group_manager.Name = "group_manager"
        Me.group_manager.Size = New System.Drawing.Size(229, 170)
        Me.group_manager.TabIndex = 0
        Me.group_manager.TabStop = False
        '
        'btn_LogViewer
        '
        Me.btn_LogViewer.Location = New System.Drawing.Point(6, 114)
        Me.btn_LogViewer.Name = "btn_LogViewer"
        Me.btn_LogViewer.Size = New System.Drawing.Size(101, 40)
        Me.btn_LogViewer.TabIndex = 3
        Me.btn_LogViewer.Text = "Logs Viewer"
        Me.btn_LogViewer.UseVisualStyleBackColor = True
        '
        'btn_RemoveStock
        '
        Me.btn_RemoveStock.Location = New System.Drawing.Point(6, 68)
        Me.btn_RemoveStock.Name = "btn_RemoveStock"
        Me.btn_RemoveStock.Size = New System.Drawing.Size(101, 40)
        Me.btn_RemoveStock.TabIndex = 2
        Me.btn_RemoveStock.Text = "Remove Stock"
        Me.btn_RemoveStock.UseVisualStyleBackColor = True
        '
        'group_admin
        '
        Me.group_admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.group_admin.Controls.Add(Me.btn_usermanagment)
        Me.group_admin.Location = New System.Drawing.Point(113, 0)
        Me.group_admin.Name = "group_admin"
        Me.group_admin.Size = New System.Drawing.Size(116, 170)
        Me.group_admin.TabIndex = 4
        Me.group_admin.TabStop = False
        '
        'btn_usermanagment
        '
        Me.btn_usermanagment.Location = New System.Drawing.Point(9, 22)
        Me.btn_usermanagment.Name = "btn_usermanagment"
        Me.btn_usermanagment.Size = New System.Drawing.Size(101, 40)
        Me.btn_usermanagment.TabIndex = 2
        Me.btn_usermanagment.Text = "Manage Users"
        Me.btn_usermanagment.UseVisualStyleBackColor = True
        '
        'btn_AddStock
        '
        Me.btn_AddStock.Location = New System.Drawing.Point(6, 22)
        Me.btn_AddStock.Name = "btn_AddStock"
        Me.btn_AddStock.Size = New System.Drawing.Size(101, 40)
        Me.btn_AddStock.TabIndex = 2
        Me.btn_AddStock.Text = "Add Stock"
        Me.btn_AddStock.UseVisualStyleBackColor = True
        '
        'group_user
        '
        Me.group_user.Controls.Add(Me.btn_LogOff)
        Me.group_user.Controls.Add(Me.btn_Account)
        Me.group_user.Controls.Add(Me.btn_Search)
        Me.group_user.Controls.Add(Me.group_manager)
        Me.group_user.Location = New System.Drawing.Point(12, 42)
        Me.group_user.Name = "group_user"
        Me.group_user.Size = New System.Drawing.Size(342, 170)
        Me.group_user.TabIndex = 4
        Me.group_user.TabStop = False
        '
        'btn_LogOff
        '
        Me.btn_LogOff.Location = New System.Drawing.Point(6, 114)
        Me.btn_LogOff.Name = "btn_LogOff"
        Me.btn_LogOff.Size = New System.Drawing.Size(101, 40)
        Me.btn_LogOff.TabIndex = 3
        Me.btn_LogOff.Text = "Log Off"
        Me.btn_LogOff.UseVisualStyleBackColor = True
        '
        'btn_Account
        '
        Me.btn_Account.Location = New System.Drawing.Point(6, 68)
        Me.btn_Account.Name = "btn_Account"
        Me.btn_Account.Size = New System.Drawing.Size(101, 40)
        Me.btn_Account.TabIndex = 2
        Me.btn_Account.Text = "Edit Profile"
        Me.btn_Account.UseVisualStyleBackColor = True
        '
        'btn_Search
        '
        Me.btn_Search.Location = New System.Drawing.Point(6, 22)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(101, 40)
        Me.btn_Search.TabIndex = 2
        Me.btn_Search.Text = "Search"
        Me.btn_Search.UseVisualStyleBackColor = True
        '
        'lbl_header
        '
        Me.lbl_header.AutoSize = True
        Me.lbl_header.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_header.Location = New System.Drawing.Point(12, 9)
        Me.lbl_header.Name = "lbl_header"
        Me.lbl_header.Size = New System.Drawing.Size(131, 30)
        Me.lbl_header.TabIndex = 5
        Me.lbl_header.Text = "Select action"
        '
        'Form_User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 224)
        Me.Controls.Add(Me.lbl_header)
        Me.Controls.Add(Me.group_user)
        Me.Name = "Form_User"
        Me.Text = "Form_User"
        Me.group_manager.ResumeLayout(False)
        Me.group_admin.ResumeLayout(False)
        Me.group_user.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents group_manager As GroupBox
    Friend WithEvents btn_LogViewer As Button
    Friend WithEvents btn_RemoveStock As Button
    Friend WithEvents btn_AddStock As Button
    Friend WithEvents group_admin As GroupBox
    Friend WithEvents btn_usermanagment As Button
    Friend WithEvents group_user As GroupBox
    Friend WithEvents btn_LogOff As Button
    Friend WithEvents btn_Account As Button
    Friend WithEvents btn_Search As Button
    Friend WithEvents lbl_header As Label
End Class
