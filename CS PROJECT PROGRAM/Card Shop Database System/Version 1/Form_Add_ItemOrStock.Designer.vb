<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Add_ItemOrStock
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
        Me.lbl_header = New System.Windows.Forms.Label()
        Me.lbl_ItemName = New System.Windows.Forms.Label()
        Me.group_stock_properties = New System.Windows.Forms.GroupBox()
        Me.txt_MoneySymbol = New System.Windows.Forms.TextBox()
        Me.num_ItemQuantityToAdd = New System.Windows.Forms.NumericUpDown()
        Me.cbox_ItemQuality = New System.Windows.Forms.ComboBox()
        Me.txt_ItemNotes = New System.Windows.Forms.TextBox()
        Me.txt_ItemPrice = New System.Windows.Forms.TextBox()
        Me.lbl_ItemNotes = New System.Windows.Forms.Label()
        Me.lbl_ItemPrice = New System.Windows.Forms.Label()
        Me.lbl_ItemQuality = New System.Windows.Forms.Label()
        Me.lbl_ItemQuantity = New System.Windows.Forms.Label()
        Me.lbl_item_name = New System.Windows.Forms.Label()
        Me.txt_ItemName = New System.Windows.Forms.TextBox()
        Me.txt_ItemPrefix = New System.Windows.Forms.TextBox()
        Me.chk_AddToStock = New System.Windows.Forms.CheckBox()
        Me.lbl_ItemImage = New System.Windows.Forms.Label()
        Me.btn_BrowseForImage = New System.Windows.Forms.Button()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dialog_BrowseForImage = New System.Windows.Forms.OpenFileDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbox_ItemRarity = New System.Windows.Forms.ComboBox()
        Me.txt_ImageFilename = New System.Windows.Forms.TextBox()
        Me.group_stock_properties.SuspendLayout()
        CType(Me.num_ItemQuantityToAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_header
        '
        Me.lbl_header.AutoSize = True
        Me.lbl_header.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_header.Location = New System.Drawing.Point(12, 9)
        Me.lbl_header.Name = "lbl_header"
        Me.lbl_header.Size = New System.Drawing.Size(296, 30)
        Me.lbl_header.TabIndex = 0
        Me.lbl_header.Text = "Add New item or Stock Record"
        '
        'lbl_ItemName
        '
        Me.lbl_ItemName.AutoSize = True
        Me.lbl_ItemName.Location = New System.Drawing.Point(12, 55)
        Me.lbl_ItemName.Name = "lbl_ItemName"
        Me.lbl_ItemName.Size = New System.Drawing.Size(69, 15)
        Me.lbl_ItemName.TabIndex = 1
        Me.lbl_ItemName.Text = "Item Name:"
        '
        'group_stock_properties
        '
        Me.group_stock_properties.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.group_stock_properties.Controls.Add(Me.txt_MoneySymbol)
        Me.group_stock_properties.Controls.Add(Me.num_ItemQuantityToAdd)
        Me.group_stock_properties.Controls.Add(Me.cbox_ItemQuality)
        Me.group_stock_properties.Controls.Add(Me.txt_ItemNotes)
        Me.group_stock_properties.Controls.Add(Me.txt_ItemPrice)
        Me.group_stock_properties.Controls.Add(Me.lbl_ItemNotes)
        Me.group_stock_properties.Controls.Add(Me.lbl_ItemPrice)
        Me.group_stock_properties.Controls.Add(Me.lbl_ItemQuality)
        Me.group_stock_properties.Controls.Add(Me.lbl_ItemQuantity)
        Me.group_stock_properties.Enabled = False
        Me.group_stock_properties.Location = New System.Drawing.Point(5, 192)
        Me.group_stock_properties.Name = "group_stock_properties"
        Me.group_stock_properties.Size = New System.Drawing.Size(261, 164)
        Me.group_stock_properties.TabIndex = 3
        Me.group_stock_properties.TabStop = False
        Me.group_stock_properties.Visible = False
        '
        'txt_MoneySymbol
        '
        Me.txt_MoneySymbol.Location = New System.Drawing.Point(95, 92)
        Me.txt_MoneySymbol.Name = "txt_MoneySymbol"
        Me.txt_MoneySymbol.ReadOnly = True
        Me.txt_MoneySymbol.Size = New System.Drawing.Size(25, 23)
        Me.txt_MoneySymbol.TabIndex = 31
        Me.txt_MoneySymbol.Text = "£"
        '
        'num_ItemQuantityToAdd
        '
        Me.num_ItemQuantityToAdd.Location = New System.Drawing.Point(96, 21)
        Me.num_ItemQuantityToAdd.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.num_ItemQuantityToAdd.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_ItemQuantityToAdd.Name = "num_ItemQuantityToAdd"
        Me.num_ItemQuantityToAdd.Size = New System.Drawing.Size(101, 23)
        Me.num_ItemQuantityToAdd.TabIndex = 30
        Me.num_ItemQuantityToAdd.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cbox_ItemQuality
        '
        Me.cbox_ItemQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_ItemQuality.FormattingEnabled = True
        Me.cbox_ItemQuality.Items.AddRange(New Object() {"Card Set", "Near-Mint", "Excillent ", "Good", "Light-Played"})
        Me.cbox_ItemQuality.Location = New System.Drawing.Point(95, 58)
        Me.cbox_ItemQuality.Name = "cbox_ItemQuality"
        Me.cbox_ItemQuality.Size = New System.Drawing.Size(121, 23)
        Me.cbox_ItemQuality.TabIndex = 8
        '
        'txt_ItemNotes
        '
        Me.txt_ItemNotes.Location = New System.Drawing.Point(95, 126)
        Me.txt_ItemNotes.MaxLength = 255
        Me.txt_ItemNotes.Name = "txt_ItemNotes"
        Me.txt_ItemNotes.Size = New System.Drawing.Size(141, 23)
        Me.txt_ItemNotes.TabIndex = 10
        '
        'txt_ItemPrice
        '
        Me.txt_ItemPrice.Location = New System.Drawing.Point(126, 92)
        Me.txt_ItemPrice.MaxLength = 6
        Me.txt_ItemPrice.Name = "txt_ItemPrice"
        Me.txt_ItemPrice.Size = New System.Drawing.Size(110, 23)
        Me.txt_ItemPrice.TabIndex = 9
        Me.txt_ItemPrice.Text = "000.00"
        '
        'lbl_ItemNotes
        '
        Me.lbl_ItemNotes.AutoSize = True
        Me.lbl_ItemNotes.Location = New System.Drawing.Point(7, 129)
        Me.lbl_ItemNotes.Name = "lbl_ItemNotes"
        Me.lbl_ItemNotes.Size = New System.Drawing.Size(65, 15)
        Me.lbl_ItemNotes.TabIndex = 5
        Me.lbl_ItemNotes.Text = "Item Notes"
        '
        'lbl_ItemPrice
        '
        Me.lbl_ItemPrice.AutoSize = True
        Me.lbl_ItemPrice.Location = New System.Drawing.Point(7, 95)
        Me.lbl_ItemPrice.Name = "lbl_ItemPrice"
        Me.lbl_ItemPrice.Size = New System.Drawing.Size(63, 15)
        Me.lbl_ItemPrice.TabIndex = 4
        Me.lbl_ItemPrice.Text = "Item Price:"
        '
        'lbl_ItemQuality
        '
        Me.lbl_ItemQuality.AutoSize = True
        Me.lbl_ItemQuality.Location = New System.Drawing.Point(7, 61)
        Me.lbl_ItemQuality.Name = "lbl_ItemQuality"
        Me.lbl_ItemQuality.Size = New System.Drawing.Size(75, 15)
        Me.lbl_ItemQuality.TabIndex = 2
        Me.lbl_ItemQuality.Text = "Item Quality:"
        '
        'lbl_ItemQuantity
        '
        Me.lbl_ItemQuantity.AutoSize = True
        Me.lbl_ItemQuantity.Location = New System.Drawing.Point(7, 23)
        Me.lbl_ItemQuantity.Name = "lbl_ItemQuantity"
        Me.lbl_ItemQuantity.Size = New System.Drawing.Size(83, 15)
        Me.lbl_ItemQuantity.TabIndex = 0
        Me.lbl_ItemQuantity.Text = "Item Quantity:"
        '
        'lbl_item_name
        '
        Me.lbl_item_name.AutoSize = True
        Me.lbl_item_name.Location = New System.Drawing.Point(12, 85)
        Me.lbl_item_name.Name = "lbl_item_name"
        Me.lbl_item_name.Size = New System.Drawing.Size(67, 15)
        Me.lbl_item_name.TabIndex = 4
        Me.lbl_item_name.Text = "Item Prefix:"
        '
        'txt_ItemName
        '
        Me.txt_ItemName.Location = New System.Drawing.Point(100, 52)
        Me.txt_ItemName.MaxLength = 55
        Me.txt_ItemName.Name = "txt_ItemName"
        Me.txt_ItemName.Size = New System.Drawing.Size(141, 23)
        Me.txt_ItemName.TabIndex = 5
        '
        'txt_ItemPrefix
        '
        Me.txt_ItemPrefix.Location = New System.Drawing.Point(101, 82)
        Me.txt_ItemPrefix.MaxLength = 4
        Me.txt_ItemPrefix.Name = "txt_ItemPrefix"
        Me.txt_ItemPrefix.Size = New System.Drawing.Size(48, 23)
        Me.txt_ItemPrefix.TabIndex = 6
        Me.txt_ItemPrefix.Text = "XXXX"
        '
        'chk_AddToStock
        '
        Me.chk_AddToStock.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.chk_AddToStock.AutoSize = True
        Me.chk_AddToStock.Location = New System.Drawing.Point(12, 177)
        Me.chk_AddToStock.Name = "chk_AddToStock"
        Me.chk_AddToStock.Size = New System.Drawing.Size(94, 19)
        Me.chk_AddToStock.TabIndex = 7
        Me.chk_AddToStock.Text = "Add to Stock"
        Me.chk_AddToStock.UseVisualStyleBackColor = True
        '
        'lbl_ItemImage
        '
        Me.lbl_ItemImage.AutoSize = True
        Me.lbl_ItemImage.Location = New System.Drawing.Point(12, 146)
        Me.lbl_ItemImage.Name = "lbl_ItemImage"
        Me.lbl_ItemImage.Size = New System.Drawing.Size(70, 15)
        Me.lbl_ItemImage.TabIndex = 9
        Me.lbl_ItemImage.Text = "Item Image:"
        '
        'btn_BrowseForImage
        '
        Me.btn_BrowseForImage.Location = New System.Drawing.Point(100, 142)
        Me.btn_BrowseForImage.Name = "btn_BrowseForImage"
        Me.btn_BrowseForImage.Size = New System.Drawing.Size(75, 23)
        Me.btn_BrowseForImage.TabIndex = 10
        Me.btn_BrowseForImage.Text = "Browse"
        Me.btn_BrowseForImage.UseVisualStyleBackColor = True
        '
        'btn_Add
        '
        Me.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_Add.Location = New System.Drawing.Point(216, 376)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(101, 40)
        Me.btn_Add.TabIndex = 11
        Me.btn_Add.Text = "Add"
        Me.btn_Add.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(155, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "(XXXX-AB01)"
        '
        'dialog_BrowseForImage
        '
        Me.dialog_BrowseForImage.FileName = "OpenFileDialog1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Item Rarity:"
        '
        'cbox_ItemRarity
        '
        Me.cbox_ItemRarity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_ItemRarity.FormattingEnabled = True
        Me.cbox_ItemRarity.Items.AddRange(New Object() {"N", "R", "SR", "UR"})
        Me.cbox_ItemRarity.Location = New System.Drawing.Point(100, 113)
        Me.cbox_ItemRarity.Name = "cbox_ItemRarity"
        Me.cbox_ItemRarity.Size = New System.Drawing.Size(121, 23)
        Me.cbox_ItemRarity.TabIndex = 32
        '
        'txt_ImageFilename
        '
        Me.txt_ImageFilename.Location = New System.Drawing.Point(181, 142)
        Me.txt_ImageFilename.Name = "txt_ImageFilename"
        Me.txt_ImageFilename.ReadOnly = True
        Me.txt_ImageFilename.Size = New System.Drawing.Size(85, 23)
        Me.txt_ImageFilename.TabIndex = 33
        '
        'Form_Add_ItemOrStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 428)
        Me.Controls.Add(Me.txt_ImageFilename)
        Me.Controls.Add(Me.cbox_ItemRarity)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Add)
        Me.Controls.Add(Me.btn_BrowseForImage)
        Me.Controls.Add(Me.lbl_ItemImage)
        Me.Controls.Add(Me.chk_AddToStock)
        Me.Controls.Add(Me.txt_ItemPrefix)
        Me.Controls.Add(Me.txt_ItemName)
        Me.Controls.Add(Me.lbl_item_name)
        Me.Controls.Add(Me.group_stock_properties)
        Me.Controls.Add(Me.lbl_ItemName)
        Me.Controls.Add(Me.lbl_header)
        Me.MaximumSize = New System.Drawing.Size(345, 467)
        Me.MinimumSize = New System.Drawing.Size(345, 467)
        Me.Name = "Form_Add_ItemOrStock"
        Me.Text = "Add New Item"
        Me.group_stock_properties.ResumeLayout(False)
        Me.group_stock_properties.PerformLayout()
        CType(Me.num_ItemQuantityToAdd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_header As Label
    Friend WithEvents lbl_ItemName As Label
    Friend WithEvents group_stock_properties As GroupBox
    Friend WithEvents txt_ItemNotes As TextBox
    Friend WithEvents txt_ItemPrice As TextBox
    Friend WithEvents lbl_ItemNotes As Label
    Friend WithEvents lbl_ItemPrice As Label
    Friend WithEvents lbl_ItemQuality As Label
    Friend WithEvents lbl_ItemQuantity As Label
    Friend WithEvents lbl_item_name As Label
    Friend WithEvents txt_ItemName As TextBox
    Friend WithEvents txt_ItemPrefix As TextBox
    Friend WithEvents chk_AddToStock As CheckBox
    Friend WithEvents cbox_ItemQuality As ComboBox
    Friend WithEvents lbl_ItemImage As Label
    Friend WithEvents btn_BrowseForImage As Button
    Friend WithEvents num_ItemQuantityToAdd As NumericUpDown
    Friend WithEvents txt_MoneySymbol As TextBox
    Friend WithEvents btn_Add As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dialog_BrowseForImage As OpenFileDialog
    Friend WithEvents Label2 As Label
    Friend WithEvents cbox_ItemRarity As ComboBox
    Friend WithEvents txt_ImageFilename As TextBox
End Class
