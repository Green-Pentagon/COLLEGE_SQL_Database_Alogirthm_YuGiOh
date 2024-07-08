<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Search_Result
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
        Me.group_item_details = New System.Windows.Forms.GroupBox()
        Me.txt_item_quantity = New System.Windows.Forms.TextBox()
        Me.txt_item_price = New System.Windows.Forms.TextBox()
        Me.txt_item_notes = New System.Windows.Forms.TextBox()
        Me.txt_item_quality = New System.Windows.Forms.TextBox()
        Me.txt_item_rarity = New System.Windows.Forms.TextBox()
        Me.txt_item_type = New System.Windows.Forms.TextBox()
        Me.lbl_item_price = New System.Windows.Forms.Label()
        Me.lbl_item_quantity = New System.Windows.Forms.Label()
        Me.lbl_item_notes = New System.Windows.Forms.Label()
        Me.lbl_item_quality = New System.Windows.Forms.Label()
        Me.lbl_item_rarity = New System.Windows.Forms.Label()
        Me.lbl_item_type = New System.Windows.Forms.Label()
        Me.lbl_item_name = New System.Windows.Forms.Label()
        Me.pbox_item_image = New System.Windows.Forms.PictureBox()
        Me.btn_previous_record = New System.Windows.Forms.Button()
        Me.btn_next_record = New System.Windows.Forms.Button()
        Me.btn_confirm_delete_choice = New System.Windows.Forms.Button()
        Me.lbl_ShowingRecord = New System.Windows.Forms.Label()
        Me.lbl_record_navigation = New System.Windows.Forms.Label()
        Me.lbl_Remove_Quantity = New System.Windows.Forms.Label()
        Me.num_remove_quantity = New System.Windows.Forms.NumericUpDown()
        Me.group_remove = New System.Windows.Forms.GroupBox()
        Me.txt_StockID = New System.Windows.Forms.TextBox()
        Me.txt_ItemID = New System.Windows.Forms.TextBox()
        Me.lbl_StockAndItemID = New System.Windows.Forms.Label()
        Me.group_item_details.SuspendLayout()
        CType(Me.pbox_item_image, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_remove_quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group_remove.SuspendLayout()
        Me.SuspendLayout()
        '
        'group_item_details
        '
        Me.group_item_details.Controls.Add(Me.txt_item_quantity)
        Me.group_item_details.Controls.Add(Me.txt_item_price)
        Me.group_item_details.Controls.Add(Me.txt_item_notes)
        Me.group_item_details.Controls.Add(Me.txt_item_quality)
        Me.group_item_details.Controls.Add(Me.txt_item_rarity)
        Me.group_item_details.Controls.Add(Me.txt_item_type)
        Me.group_item_details.Controls.Add(Me.lbl_item_price)
        Me.group_item_details.Controls.Add(Me.lbl_item_quantity)
        Me.group_item_details.Controls.Add(Me.lbl_item_notes)
        Me.group_item_details.Controls.Add(Me.lbl_item_quality)
        Me.group_item_details.Controls.Add(Me.lbl_item_rarity)
        Me.group_item_details.Controls.Add(Me.lbl_item_type)
        Me.group_item_details.Location = New System.Drawing.Point(196, 44)
        Me.group_item_details.Name = "group_item_details"
        Me.group_item_details.Size = New System.Drawing.Size(200, 207)
        Me.group_item_details.TabIndex = 16
        Me.group_item_details.TabStop = False
        '
        'txt_item_quantity
        '
        Me.txt_item_quantity.Location = New System.Drawing.Point(66, 135)
        Me.txt_item_quantity.Name = "txt_item_quantity"
        Me.txt_item_quantity.ReadOnly = True
        Me.txt_item_quantity.Size = New System.Drawing.Size(81, 23)
        Me.txt_item_quantity.TabIndex = 18
        '
        'txt_item_price
        '
        Me.txt_item_price.Location = New System.Drawing.Point(47, 106)
        Me.txt_item_price.Name = "txt_item_price"
        Me.txt_item_price.ReadOnly = True
        Me.txt_item_price.Size = New System.Drawing.Size(100, 23)
        Me.txt_item_price.TabIndex = 16
        '
        'txt_item_notes
        '
        Me.txt_item_notes.Location = New System.Drawing.Point(47, 166)
        Me.txt_item_notes.Name = "txt_item_notes"
        Me.txt_item_notes.ReadOnly = True
        Me.txt_item_notes.Size = New System.Drawing.Size(147, 23)
        Me.txt_item_notes.TabIndex = 15
        '
        'txt_item_quality
        '
        Me.txt_item_quality.Location = New System.Drawing.Point(47, 76)
        Me.txt_item_quality.Name = "txt_item_quality"
        Me.txt_item_quality.ReadOnly = True
        Me.txt_item_quality.Size = New System.Drawing.Size(100, 23)
        Me.txt_item_quality.TabIndex = 14
        '
        'txt_item_rarity
        '
        Me.txt_item_rarity.Location = New System.Drawing.Point(47, 46)
        Me.txt_item_rarity.Name = "txt_item_rarity"
        Me.txt_item_rarity.ReadOnly = True
        Me.txt_item_rarity.Size = New System.Drawing.Size(100, 23)
        Me.txt_item_rarity.TabIndex = 13
        '
        'txt_item_type
        '
        Me.txt_item_type.Location = New System.Drawing.Point(47, 16)
        Me.txt_item_type.Name = "txt_item_type"
        Me.txt_item_type.ReadOnly = True
        Me.txt_item_type.Size = New System.Drawing.Size(100, 23)
        Me.txt_item_type.TabIndex = 12
        '
        'lbl_item_price
        '
        Me.lbl_item_price.AutoSize = True
        Me.lbl_item_price.Location = New System.Drawing.Point(6, 109)
        Me.lbl_item_price.Name = "lbl_item_price"
        Me.lbl_item_price.Size = New System.Drawing.Size(36, 15)
        Me.lbl_item_price.TabIndex = 11
        Me.lbl_item_price.Text = "Price:"
        '
        'lbl_item_quantity
        '
        Me.lbl_item_quantity.AutoSize = True
        Me.lbl_item_quantity.Location = New System.Drawing.Point(6, 139)
        Me.lbl_item_quantity.Name = "lbl_item_quantity"
        Me.lbl_item_quantity.Size = New System.Drawing.Size(54, 15)
        Me.lbl_item_quantity.TabIndex = 10
        Me.lbl_item_quantity.Text = "In-Stock:"
        '
        'lbl_item_notes
        '
        Me.lbl_item_notes.AutoSize = True
        Me.lbl_item_notes.Location = New System.Drawing.Point(6, 169)
        Me.lbl_item_notes.Name = "lbl_item_notes"
        Me.lbl_item_notes.Size = New System.Drawing.Size(41, 15)
        Me.lbl_item_notes.TabIndex = 8
        Me.lbl_item_notes.Text = "Notes:"
        '
        'lbl_item_quality
        '
        Me.lbl_item_quality.AutoSize = True
        Me.lbl_item_quality.Location = New System.Drawing.Point(6, 79)
        Me.lbl_item_quality.Name = "lbl_item_quality"
        Me.lbl_item_quality.Size = New System.Drawing.Size(37, 15)
        Me.lbl_item_quality.TabIndex = 6
        Me.lbl_item_quality.Text = "Ware:"
        '
        'lbl_item_rarity
        '
        Me.lbl_item_rarity.AutoSize = True
        Me.lbl_item_rarity.Location = New System.Drawing.Point(6, 49)
        Me.lbl_item_rarity.Name = "lbl_item_rarity"
        Me.lbl_item_rarity.Size = New System.Drawing.Size(40, 15)
        Me.lbl_item_rarity.TabIndex = 4
        Me.lbl_item_rarity.Text = "Rarity:"
        '
        'lbl_item_type
        '
        Me.lbl_item_type.AutoSize = True
        Me.lbl_item_type.Location = New System.Drawing.Point(6, 19)
        Me.lbl_item_type.Name = "lbl_item_type"
        Me.lbl_item_type.Size = New System.Drawing.Size(34, 15)
        Me.lbl_item_type.TabIndex = 2
        Me.lbl_item_type.Text = "Type:"
        '
        'lbl_item_name
        '
        Me.lbl_item_name.AutoSize = True
        Me.lbl_item_name.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_item_name.Location = New System.Drawing.Point(12, 14)
        Me.lbl_item_name.Name = "lbl_item_name"
        Me.lbl_item_name.Size = New System.Drawing.Size(126, 30)
        Me.lbl_item_name.TabIndex = 15
        Me.lbl_item_name.Text = "ITEM NAME"
        '
        'pbox_item_image
        '
        Me.pbox_item_image.ImageLocation = ""
        Me.pbox_item_image.Location = New System.Drawing.Point(12, 53)
        Me.pbox_item_image.Name = "pbox_item_image"
        Me.pbox_item_image.Size = New System.Drawing.Size(178, 178)
        Me.pbox_item_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbox_item_image.TabIndex = 14
        Me.pbox_item_image.TabStop = False
        '
        'btn_previous_record
        '
        Me.btn_previous_record.Enabled = False
        Me.btn_previous_record.Location = New System.Drawing.Point(12, 279)
        Me.btn_previous_record.Name = "btn_previous_record"
        Me.btn_previous_record.Size = New System.Drawing.Size(71, 40)
        Me.btn_previous_record.TabIndex = 20
        Me.btn_previous_record.Text = "<-"
        Me.btn_previous_record.UseVisualStyleBackColor = True
        '
        'btn_next_record
        '
        Me.btn_next_record.Location = New System.Drawing.Point(89, 279)
        Me.btn_next_record.Name = "btn_next_record"
        Me.btn_next_record.Size = New System.Drawing.Size(71, 40)
        Me.btn_next_record.TabIndex = 21
        Me.btn_next_record.Text = "->"
        Me.btn_next_record.UseVisualStyleBackColor = True
        '
        'btn_confirm_delete_choice
        '
        Me.btn_confirm_delete_choice.Location = New System.Drawing.Point(6, 22)
        Me.btn_confirm_delete_choice.Name = "btn_confirm_delete_choice"
        Me.btn_confirm_delete_choice.Size = New System.Drawing.Size(101, 40)
        Me.btn_confirm_delete_choice.TabIndex = 23
        Me.btn_confirm_delete_choice.Text = "Confirm for Deletion"
        Me.btn_confirm_delete_choice.UseVisualStyleBackColor = True
        '
        'lbl_ShowingRecord
        '
        Me.lbl_ShowingRecord.AutoSize = True
        Me.lbl_ShowingRecord.Location = New System.Drawing.Point(12, 324)
        Me.lbl_ShowingRecord.Name = "lbl_ShowingRecord"
        Me.lbl_ShowingRecord.Size = New System.Drawing.Size(96, 15)
        Me.lbl_ShowingRecord.TabIndex = 23
        Me.lbl_ShowingRecord.Text = "Showing Record:"
        '
        'lbl_record_navigation
        '
        Me.lbl_record_navigation.AutoSize = True
        Me.lbl_record_navigation.Location = New System.Drawing.Point(114, 324)
        Me.lbl_record_navigation.Name = "lbl_record_navigation"
        Me.lbl_record_navigation.Size = New System.Drawing.Size(36, 15)
        Me.lbl_record_navigation.TabIndex = 24
        Me.lbl_record_navigation.Text = "0 of 0"
        '
        'lbl_Remove_Quantity
        '
        Me.lbl_Remove_Quantity.AutoSize = True
        Me.lbl_Remove_Quantity.Location = New System.Drawing.Point(126, 21)
        Me.lbl_Remove_Quantity.Name = "lbl_Remove_Quantity"
        Me.lbl_Remove_Quantity.Size = New System.Drawing.Size(102, 15)
        Me.lbl_Remove_Quantity.TabIndex = 28
        Me.lbl_Remove_Quantity.Text = "Remove Quantity:"
        '
        'num_remove_quantity
        '
        Me.num_remove_quantity.Location = New System.Drawing.Point(126, 39)
        Me.num_remove_quantity.Name = "num_remove_quantity"
        Me.num_remove_quantity.Size = New System.Drawing.Size(101, 23)
        Me.num_remove_quantity.TabIndex = 29
        '
        'group_remove
        '
        Me.group_remove.Controls.Add(Me.btn_confirm_delete_choice)
        Me.group_remove.Controls.Add(Me.num_remove_quantity)
        Me.group_remove.Controls.Add(Me.lbl_Remove_Quantity)
        Me.group_remove.Location = New System.Drawing.Point(166, 257)
        Me.group_remove.Name = "group_remove"
        Me.group_remove.Size = New System.Drawing.Size(230, 70)
        Me.group_remove.TabIndex = 30
        Me.group_remove.TabStop = False
        '
        'txt_StockID
        '
        Me.txt_StockID.Location = New System.Drawing.Point(124, 237)
        Me.txt_StockID.Name = "txt_StockID"
        Me.txt_StockID.ReadOnly = True
        Me.txt_StockID.Size = New System.Drawing.Size(30, 23)
        Me.txt_StockID.TabIndex = 31
        '
        'txt_ItemID
        '
        Me.txt_ItemID.Location = New System.Drawing.Point(160, 237)
        Me.txt_ItemID.Name = "txt_ItemID"
        Me.txt_ItemID.ReadOnly = True
        Me.txt_ItemID.Size = New System.Drawing.Size(30, 23)
        Me.txt_ItemID.TabIndex = 32
        '
        'lbl_StockAndItemID
        '
        Me.lbl_StockAndItemID.AutoSize = True
        Me.lbl_StockAndItemID.Location = New System.Drawing.Point(12, 240)
        Me.lbl_StockAndItemID.Name = "lbl_StockAndItemID"
        Me.lbl_StockAndItemID.Size = New System.Drawing.Size(103, 15)
        Me.lbl_StockAndItemID.TabIndex = 33
        Me.lbl_StockAndItemID.Text = "Stock and Item ID:"
        '
        'Form_Search_Result
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 351)
        Me.Controls.Add(Me.lbl_StockAndItemID)
        Me.Controls.Add(Me.txt_ItemID)
        Me.Controls.Add(Me.txt_StockID)
        Me.Controls.Add(Me.group_remove)
        Me.Controls.Add(Me.lbl_ShowingRecord)
        Me.Controls.Add(Me.lbl_record_navigation)
        Me.Controls.Add(Me.btn_next_record)
        Me.Controls.Add(Me.btn_previous_record)
        Me.Controls.Add(Me.group_item_details)
        Me.Controls.Add(Me.lbl_item_name)
        Me.Controls.Add(Me.pbox_item_image)
        Me.MaximumSize = New System.Drawing.Size(418, 390)
        Me.MinimumSize = New System.Drawing.Size(418, 390)
        Me.Name = "Form_Search_Result"
        Me.Text = "Form_Search_Result"
        Me.group_item_details.ResumeLayout(False)
        Me.group_item_details.PerformLayout()
        CType(Me.pbox_item_image, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_remove_quantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group_remove.ResumeLayout(False)
        Me.group_remove.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents group_item_details As GroupBox
    Friend WithEvents lbl_item_price As Label
    Friend WithEvents lbl_item_quantity As Label
    Friend WithEvents lbl_item_notes As Label
    Friend WithEvents lbl_item_quality As Label
    Friend WithEvents lbl_item_rarity As Label
    Friend WithEvents lbl_item_type As Label
    Friend WithEvents lbl_item_name As Label
    Friend WithEvents pbox_item_image As PictureBox
    Friend WithEvents btn_previous_record As Button
    Friend WithEvents btn_next_record As Button
    Friend WithEvents btn_confirm_delete_choice As Button
    Friend WithEvents lbl_ShowingRecord As Label
    Friend WithEvents lbl_record_navigation As Label
    Friend WithEvents txt_item_price As TextBox
    Friend WithEvents txt_item_notes As TextBox
    Friend WithEvents txt_item_quality As TextBox
    Friend WithEvents txt_item_rarity As TextBox
    Friend WithEvents txt_item_type As TextBox
    Friend WithEvents txt_item_quantity As TextBox
    Friend WithEvents lbl_Remove_Quantity As Label
    Friend WithEvents num_remove_quantity As NumericUpDown
    Friend WithEvents group_remove As GroupBox
    Friend WithEvents txt_StockID As TextBox
    Friend WithEvents txt_ItemID As TextBox
    Friend WithEvents lbl_StockAndItemID As Label
End Class
