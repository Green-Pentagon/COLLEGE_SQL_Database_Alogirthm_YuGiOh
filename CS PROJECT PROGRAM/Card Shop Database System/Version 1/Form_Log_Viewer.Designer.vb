<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Log_Viewer
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
        Me.menu_strip = New System.Windows.Forms.MenuStrip()
        Me.menu_File = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_File_Open = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_File_SaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_Backup = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_Backup_CreateNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_view = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_view_clear = New System.Windows.Forms.ToolStripMenuItem()
        Me.dialog_file_open = New System.Windows.Forms.OpenFileDialog()
        Me.lbox_FileOutput = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dialog_file_saveas = New System.Windows.Forms.SaveFileDialog()
        Me.menu_strip.SuspendLayout()
        Me.SuspendLayout()
        '
        'menu_strip
        '
        Me.menu_strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_File, Me.menu_Backup, Me.menu_view})
        Me.menu_strip.Location = New System.Drawing.Point(0, 0)
        Me.menu_strip.Name = "menu_strip"
        Me.menu_strip.Size = New System.Drawing.Size(499, 24)
        Me.menu_strip.TabIndex = 0
        '
        'menu_File
        '
        Me.menu_File.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_File_Open, Me.Menu_File_SaveAs})
        Me.menu_File.Name = "menu_File"
        Me.menu_File.Size = New System.Drawing.Size(37, 20)
        Me.menu_File.Text = "&File"
        '
        'menu_File_Open
        '
        Me.menu_File_Open.Name = "menu_File_Open"
        Me.menu_File_Open.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.menu_File_Open.Size = New System.Drawing.Size(154, 22)
        Me.menu_File_Open.Text = "&Open"
        '
        'Menu_File_SaveAs
        '
        Me.Menu_File_SaveAs.Name = "Menu_File_SaveAs"
        Me.Menu_File_SaveAs.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.Menu_File_SaveAs.Size = New System.Drawing.Size(154, 22)
        Me.Menu_File_SaveAs.Text = "&Save As"
        '
        'menu_Backup
        '
        Me.menu_Backup.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_Backup_CreateNew})
        Me.menu_Backup.Name = "menu_Backup"
        Me.menu_Backup.Size = New System.Drawing.Size(76, 20)
        Me.menu_Backup.Text = "DB &Backup"
        '
        'menu_Backup_CreateNew
        '
        Me.menu_Backup_CreateNew.Name = "menu_Backup_CreateNew"
        Me.menu_Backup_CreateNew.Size = New System.Drawing.Size(135, 22)
        Me.menu_Backup_CreateNew.Text = "Create &New"
        '
        'menu_view
        '
        Me.menu_view.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_view_clear})
        Me.menu_view.Name = "menu_view"
        Me.menu_view.Size = New System.Drawing.Size(44, 20)
        Me.menu_view.Text = "&View"
        '
        'menu_view_clear
        '
        Me.menu_view_clear.Name = "menu_view_clear"
        Me.menu_view_clear.Size = New System.Drawing.Size(124, 22)
        Me.menu_view_clear.Text = "&Clear Box"
        '
        'dialog_file_open
        '
        Me.dialog_file_open.FileName = "OpenFileDialog1"
        '
        'lbox_FileOutput
        '
        Me.lbox_FileOutput.FormattingEnabled = True
        Me.lbox_FileOutput.ItemHeight = 15
        Me.lbox_FileOutput.Location = New System.Drawing.Point(12, 71)
        Me.lbox_FileOutput.Name = "lbox_FileOutput"
        Me.lbox_FileOutput.Size = New System.Drawing.Size(477, 244)
        Me.lbox_FileOutput.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 30)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Log File Viewer"
        '
        'Form_Log_Viewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 328)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbox_FileOutput)
        Me.Controls.Add(Me.menu_strip)
        Me.MainMenuStrip = Me.menu_strip
        Me.MaximumSize = New System.Drawing.Size(515, 367)
        Me.MinimumSize = New System.Drawing.Size(515, 367)
        Me.Name = "Form_Log_Viewer"
        Me.Text = "Log Viewer"
        Me.menu_strip.ResumeLayout(False)
        Me.menu_strip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menu_strip As MenuStrip
    Friend WithEvents menu_File As ToolStripMenuItem
    Friend WithEvents menu_File_Open As ToolStripMenuItem
    Friend WithEvents Menu_File_SaveAs As ToolStripMenuItem
    Friend WithEvents menu_Backup As ToolStripMenuItem
    Friend WithEvents menu_Backup_CreateNew As ToolStripMenuItem
    Friend WithEvents dialog_file_open As OpenFileDialog
    Friend WithEvents lbox_FileOutput As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dialog_file_saveas As SaveFileDialog
    Friend WithEvents menu_view As ToolStripMenuItem
    Friend WithEvents menu_view_clear As ToolStripMenuItem
End Class
