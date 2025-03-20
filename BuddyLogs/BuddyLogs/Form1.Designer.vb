<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        ServerToolStripMenuItem = New ToolStripMenuItem()
        StartServerToolStripMenuItem = New ToolStripMenuItem()
        StopServerToolStripMenuItem = New ToolStripMenuItem()
        txtLog = New TextBox()
        SettingsToolStripMenuItem = New ToolStripMenuItem()
        FontDialog1 = New FontDialog()
        SelectFontToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, ServerToolStripMenuItem, SettingsToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(92, 22)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' ServerToolStripMenuItem
        ' 
        ServerToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {StartServerToolStripMenuItem, StopServerToolStripMenuItem})
        ServerToolStripMenuItem.Name = "ServerToolStripMenuItem"
        ServerToolStripMenuItem.Size = New Size(51, 20)
        ServerToolStripMenuItem.Text = "Server"
        ' 
        ' StartServerToolStripMenuItem
        ' 
        StartServerToolStripMenuItem.Name = "StartServerToolStripMenuItem"
        StartServerToolStripMenuItem.Size = New Size(180, 22)
        StartServerToolStripMenuItem.Text = "Start Server"
        ' 
        ' StopServerToolStripMenuItem
        ' 
        StopServerToolStripMenuItem.Name = "StopServerToolStripMenuItem"
        StopServerToolStripMenuItem.Size = New Size(180, 22)
        StopServerToolStripMenuItem.Text = "Stop Server"
        ' 
        ' txtLog
        ' 
        txtLog.Dock = DockStyle.Fill
        txtLog.Location = New Point(0, 24)
        txtLog.Multiline = True
        txtLog.Name = "txtLog"
        txtLog.ReadOnly = True
        txtLog.ScrollBars = ScrollBars.Both
        txtLog.Size = New Size(800, 426)
        txtLog.TabIndex = 1
        ' 
        ' SettingsToolStripMenuItem
        ' 
        SettingsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SelectFontToolStripMenuItem})
        SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        SettingsToolStripMenuItem.Size = New Size(61, 20)
        SettingsToolStripMenuItem.Text = "Settings"
        ' 
        ' SelectFontToolStripMenuItem
        ' 
        SelectFontToolStripMenuItem.Name = "SelectFontToolStripMenuItem"
        SelectFontToolStripMenuItem.Size = New Size(180, 22)
        SelectFontToolStripMenuItem.Text = "Select Font"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtLog)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "BuddyLogs"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtLog As TextBox
    Friend WithEvents ServerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartServerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StopServerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectFontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontDialog1 As FontDialog

End Class
