Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading

Public Class Form1
    Private client As TcpClient
    Private stream As NetworkStream
    Private receiveThread As Thread
    Private username As String

    Private Function GetLocalIPAddress() As String
        ' Get the host name of the current machine
        Dim host As String = Dns.GetHostName()

        ' Get all the IP addresses associated with this host
        Dim ipEntry As IPHostEntry = Dns.GetHostEntry(host)

        ' Loop through all the IP addresses
        For Each ip As IPAddress In ipEntry.AddressList
            ' If it's an IPv4 address, return it
            If ip.AddressFamily = Net.Sockets.AddressFamily.InterNetwork Then
                Return ip.ToString()
            End If
        Next

        ' If no IPv4 address found, return a default message
        Return String.Empty
    End Function

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Try
            If txtUsername.Text.Trim() = "" Then
                Log("Please enter a username.")
                Return
            End If

            If txtServerIP.Text.Trim() = "" Then
                Log("Please enter the server IP address.")
                Return
            End If

            Dim serverIPAddress As String = txtServerIP.Text.Trim() ' Get IP from textbox

            username = txtUsername.Text.Trim()
            client = New TcpClient(serverIPAddress, 5000) ' Connect to the server
            stream = client.GetStream()
            receiveThread = New Thread(AddressOf ReceiveMessages)
            receiveThread.IsBackground = True
            receiveThread.Start()

            ' Save the entered IP to My.Settings
            My.Settings.LastIP = serverIPAddress
            My.Settings.Save()

            ' Send the username to the server
            Dim data As Byte() = Encoding.ASCII.GetBytes("[USER]" & username)
            stream.Write(data, 0, data.Length)

            Log("Connected as " & username)
            txtUsername.Enabled = False
            txtUsername.ReadOnly = True
            txtServerIP.Enabled = False
            txtServerIP.ReadOnly = True

            txtMessage.ReadOnly = False
            txtMessage.Enabled = True
            btnSend.Enabled = True

            txtMessages.Text += "Connected to: " + serverIPAddress + Environment.NewLine
        Catch ex As Exception
            Log("Connection failed: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Try
            If client IsNot Nothing AndAlso client.Connected Then
                Dim message As String = txtMessage.Text.Trim()
                If message <> "" Then
                    Dim fullMessage As String = username & ": " & message
                    Dim data As Byte() = Encoding.ASCII.GetBytes(fullMessage)
                    stream.Write(data, 0, data.Length)
                    Log("You: " & message)
                    txtMessage.Clear()
                End If
            Else
                Log("Not connected to server.")
            End If
        Catch ex As Exception
            Log("Error sending message.")
        End Try
    End Sub

    Private Sub ReceiveMessages()
        Dim buffer(1024) As Byte
        Dim bytesRead As Integer
        Try
            While True
                bytesRead = stream.Read(buffer, 0, buffer.Length)
                If bytesRead = 0 Then Exit While

                Dim message As String = Encoding.ASCII.GetString(buffer, 0, bytesRead)

                ' Display the message without altering it, as the server already formats it
                Log(message)
            End While
        Catch ex As Exception
            Log("Disconnected from server.")
        End Try
    End Sub

    Private Sub Log(message As String)
        If txtMessages.InvokeRequired Then
            txtMessages.Invoke(Sub() txtMessages.AppendText(message & Environment.NewLine))
        Else
            txtMessages.AppendText(message & Environment.NewLine)
        End If
    End Sub

    Private Sub DisconnectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
        Try
            If client IsNot Nothing AndAlso client.Connected Then
                Log("Disconnected from server.")
                txtUsername.Enabled = True
                txtUsername.ReadOnly = False
                txtMessage.ReadOnly = True
                txtServerIP.Enabled = True
                txtServerIP.ReadOnly = False
                txtMessage.Enabled = False
                btnSend.Enabled = False
            End If
        Catch ex As Exception
            Log("Error disconnecting: " & ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Disable the text message box until connected
        txtMessage.ReadOnly = True
        txtMessage.Enabled = False

        ' Disable the send button until connected
        btnSend.Enabled = False

        ' Load the saved font settings
        Dim savedFontName As String = My.Settings.FontName
        Dim savedFontSize As Single = My.Settings.FontSize
        Dim savedFontStyle As FontStyle = CType(My.Settings.FontStyle, FontStyle)

        ' Check if a font name is saved
        If Not String.IsNullOrEmpty(savedFontName) Then
            Dim savedFont As New Font(savedFontName, savedFontSize, savedFontStyle)
            txtMessages.Font = savedFont ' Apply font to the text area
        End If

        ' Load the saved IP if available
        If Not String.IsNullOrEmpty(My.Settings.LastIP) Then
            txtServerIP.Text = My.Settings.LastIP
        End If
    End Sub

    Private Sub ExitCloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitCloseToolStripMenuItem.Click
        End
    End Sub

    Private Sub SelectFontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectFontToolStripMenuItem.Click
        If FontDialog1.ShowDialog() = DialogResult.OK Then
            txtMessages.Font = FontDialog1.Font
            My.Settings.FontName = FontDialog1.Font.Name
            My.Settings.FontSize = FontDialog1.Font.Size
            My.Settings.FontStyle = CInt(FontDialog1.Font.Style)
            My.Settings.Save()
        End If
    End Sub
End Class