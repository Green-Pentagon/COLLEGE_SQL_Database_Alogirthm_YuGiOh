<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Remove
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
        Me.lbox_RemovePile = New System.Windows.Forms.ListBox()
        Me.lbl_header = New System.Windows.Forms.Label()
        Me.btn_AddStockItem = New System.Windows.Forms.Button()
        Me.btn_RemoveSelectedItem = New System.Windows.Forms.Button()
        Me.btn_ConfimDeletion = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbox_RemovePile
        '
        Me.lbox_RemovePile.FormattingEnabled = True
        Me.lbox_RemovePile.HorizontalScrollbar = True
        Me.lbox_RemovePile.ItemHeight = 15
        Me.lbox_RemovePile.Location = New System.Drawing.Point(198, 55)
        Me.lbox_RemovePile.Name = "lbox_RemovePile"
        Me.lbox_RemovePile.Size = New System.Drawing.Size(413, 229)
        Me.lbox_RemovePile.TabIndex = 0
        '
        'lbl_header
        '
        Me.lbl_header.AutoSize = True
        Me.lbl_header.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_header.Location = New System.Drawing.Point(12, 9)
        Me.lbl_header.Name = "lbl_header"
        Me.lbl_header.Size = New System.Drawing.Size(177, 30)
        Me.lbl_header.TabIndex = 1
        Me.lbl_header.Text = "Remove Selection"
        '
        'btn_AddStockItem
        '
        Me.btn_AddStockItem.Location = New System.Drawing.Point(12, 55)
        Me.btn_AddStockItem.Name = "btn_AddStockItem"
        Me.btn_AddStockItem.Size = New System.Drawing.Size(101, 40)
        Me.btn_AddStockItem.TabIndex = 3
        Me.btn_AddStockItem.Text = "Add Item To Remove"
        Me.btn_AddStockItem.UseVisualStyleBackColor = True
        '
        'btn_RemoveSelectedItem
        '
        Me.btn_RemoveSelectedItem.Location = New System.Drawing.Point(12, 104)
        Me.btn_RemoveSelectedItem.Name = "btn_RemoveSelectedItem"
        Me.btn_RemoveSelectedItem.Size = New System.Drawing.Size(101, 40)
        Me.btn_RemoveSelectedItem.TabIndex = 4
        Me.btn_RemoveSelectedItem.Text = "Remove Last Selected Item"
        Me.btn_RemoveSelectedItem.UseVisualStyleBackColor = True
        '
        'btn_ConfimDeletion
        '
        Me.btn_ConfimDeletion.Location = New System.Drawing.Point(12, 198)
        Me.btn_ConfimDeletion.Name = "btn_ConfimDeletion"
        Me.btn_ConfimDeletion.Size = New System.Drawing.Size(101, 40)
        Me.btn_ConfimDeletion.TabIndex = 5
        Me.btn_ConfimDeletion.Text = "Confirm Deletion"
        Me.btn_ConfimDeletion.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(12, 244)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(101, 40)
        Me.btn_cancel.TabIndex = 6
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'Form_Remove
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 316)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_ConfimDeletion)
        Me.Controls.Add(Me.btn_RemoveSelectedItem)
        Me.Controls.Add(Me.btn_AddStockItem)
        Me.Controls.Add(Me.lbl_header)
        Me.Controls.Add(Me.lbox_RemovePile)
        Me.MaximumSize = New System.Drawing.Size(653, 355)
        Me.MinimumSize = New System.Drawing.Size(653, 355)
        Me.Name = "Form_Remove"
        Me.Text = "Select Items to Remove"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbox_RemovePile As ListBox
    Friend WithEvents lbl_header As Label
    Friend WithEvents btn_AddStockItem As Button
    Friend WithEvents btn_RemoveSelectedItem As Button
    Friend WithEvents btn_ConfimDeletion As Button
    Friend WithEvents btn_cancel As Button
End Class
