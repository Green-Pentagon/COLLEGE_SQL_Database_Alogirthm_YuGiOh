<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Search
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_SetPrefix = New System.Windows.Forms.TextBox()
        Me.txt_ItemName = New System.Windows.Forms.TextBox()
        Me.cbox_itemQuality_filter = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_HelpPrompt = New System.Windows.Forms.Button()
        Me.btn_StartSearch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Card Set ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Item Condition:"
        Me.Label3.Visible = False
        '
        'txt_SetPrefix
        '
        Me.txt_SetPrefix.Location = New System.Drawing.Point(107, 85)
        Me.txt_SetPrefix.MaxLength = 4
        Me.txt_SetPrefix.Name = "txt_SetPrefix"
        Me.txt_SetPrefix.Size = New System.Drawing.Size(86, 23)
        Me.txt_SetPrefix.TabIndex = 7
        '
        'txt_ItemName
        '
        Me.txt_ItemName.Location = New System.Drawing.Point(107, 55)
        Me.txt_ItemName.Name = "txt_ItemName"
        Me.txt_ItemName.Size = New System.Drawing.Size(183, 23)
        Me.txt_ItemName.TabIndex = 8
        '
        'cbox_itemQuality_filter
        '
        Me.cbox_itemQuality_filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_itemQuality_filter.Enabled = False
        Me.cbox_itemQuality_filter.FormattingEnabled = True
        Me.cbox_itemQuality_filter.Items.AddRange(New Object() {"Any", "Card Set", "Near-Mint", "Excillent ", "Good", "Light-Played"})
        Me.cbox_itemQuality_filter.Location = New System.Drawing.Point(108, 190)
        Me.cbox_itemQuality_filter.Name = "cbox_itemQuality_filter"
        Me.cbox_itemQuality_filter.Size = New System.Drawing.Size(121, 23)
        Me.cbox_itemQuality_filter.TabIndex = 6
        Me.cbox_itemQuality_filter.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(12, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(209, 30)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Search Stock Records"
        '
        'btn_HelpPrompt
        '
        Me.btn_HelpPrompt.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_HelpPrompt.Location = New System.Drawing.Point(199, 122)
        Me.btn_HelpPrompt.Name = "btn_HelpPrompt"
        Me.btn_HelpPrompt.Size = New System.Drawing.Size(86, 27)
        Me.btn_HelpPrompt.TabIndex = 10
        Me.btn_HelpPrompt.Text = "Help"
        Me.btn_HelpPrompt.UseVisualStyleBackColor = True
        '
        'btn_StartSearch
        '
        Me.btn_StartSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_StartSearch.Location = New System.Drawing.Point(107, 122)
        Me.btn_StartSearch.Name = "btn_StartSearch"
        Me.btn_StartSearch.Size = New System.Drawing.Size(86, 27)
        Me.btn_StartSearch.TabIndex = 11
        Me.btn_StartSearch.Text = "Search"
        Me.btn_StartSearch.UseVisualStyleBackColor = True
        '
        'Form_Search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 161)
        Me.Controls.Add(Me.btn_StartSearch)
        Me.Controls.Add(Me.btn_HelpPrompt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_ItemName)
        Me.Controls.Add(Me.txt_SetPrefix)
        Me.Controls.Add(Me.cbox_itemQuality_filter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(315, 200)
        Me.MinimumSize = New System.Drawing.Size(315, 200)
        Me.Name = "Form_Search"
        Me.Text = "Search"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_SetPrefix As TextBox
    Friend WithEvents txt_ItemName As TextBox
    Friend WithEvents cbox_itemQuality_filter As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_HelpPrompt As Button
    Friend WithEvents btn_StartSearch As Button
End Class
