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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        btnConnect = New ToolStripMenuItem()
        btnDisconnect = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        ExitCloseToolStripMenuItem = New ToolStripMenuItem()
        SettingsToolStripMenuItem = New ToolStripMenuItem()
        SelectFontToolStripMenuItem = New ToolStripMenuItem()
        txtMessages = New TextBox()
        txtMessage = New TextBox()
        btnSend = New Button()
        txtUsername = New TextBox()
        FontDialog1 = New FontDialog()
        txtServerIP = New TextBox()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, SettingsToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {btnConnect, btnDisconnect, ToolStripSeparator1, ExitCloseToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' btnConnect
        ' 
        btnConnect.Name = "btnConnect"
        btnConnect.Size = New Size(180, 22)
        btnConnect.Text = "Connect"
        ' 
        ' btnDisconnect
        ' 
        btnDisconnect.Name = "btnDisconnect"
        btnDisconnect.Size = New Size(180, 22)
        btnDisconnect.Text = "Disconnect"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(177, 6)
        ' 
        ' ExitCloseToolStripMenuItem
        ' 
        ExitCloseToolStripMenuItem.Name = "ExitCloseToolStripMenuItem"
        ExitCloseToolStripMenuItem.Size = New Size(180, 22)
        ExitCloseToolStripMenuItem.Text = "Exit (Close)"
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
        SelectFontToolStripMenuItem.Size = New Size(132, 22)
        SelectFontToolStripMenuItem.Text = "Select Font"
        ' 
        ' txtMessages
        ' 
        txtMessages.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtMessages.Location = New Point(12, 57)
        txtMessages.Multiline = True
        txtMessages.Name = "txtMessages"
        txtMessages.PlaceholderText = "Message Area"
        txtMessages.ReadOnly = True
        txtMessages.ScrollBars = ScrollBars.Both
        txtMessages.Size = New Size(776, 352)
        txtMessages.TabIndex = 1
        ' 
        ' txtMessage
        ' 
        txtMessage.Location = New Point(12, 415)
        txtMessage.Name = "txtMessage"
        txtMessage.PlaceholderText = "Type Message..."
        txtMessage.Size = New Size(695, 23)
        txtMessage.TabIndex = 2
        ' 
        ' btnSend
        ' 
        btnSend.FlatStyle = FlatStyle.System
        btnSend.Location = New Point(713, 415)
        btnSend.Name = "btnSend"
        btnSend.Size = New Size(75, 23)
        btnSend.TabIndex = 3
        btnSend.Text = "Send"
        btnSend.UseVisualStyleBackColor = True
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(12, 28)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "Enter Username"
        txtUsername.Size = New Size(400, 23)
        txtUsername.TabIndex = 4
        ' 
        ' txtServerIP
        ' 
        txtServerIP.Location = New Point(418, 28)
        txtServerIP.Name = "txtServerIP"
        txtServerIP.PlaceholderText = "IP Address"
        txtServerIP.Size = New Size(370, 23)
        txtServerIP.TabIndex = 5
        ' 
        ' Form1
        ' 
        AcceptButton = btnSend
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtServerIP)
        Controls.Add(txtUsername)
        Controls.Add(btnSend)
        Controls.Add(txtMessage)
        Controls.Add(txtMessages)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        Name = "Form1"
        Text = "BuddyMessaging"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnConnect As ToolStripMenuItem
    Friend WithEvents txtMessages As TextBox
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents btnSend As Button
    Friend WithEvents ExitCloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnDisconnect As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents SelectFontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents txtServerIP As TextBox

End Class
