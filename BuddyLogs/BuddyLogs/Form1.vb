Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading

Public Class Form1
    Private server As TcpListener
    Private clients As New List(Of TcpClient)
    Private serverThread As Thread

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

    Private Sub StartServer()
        Try
            ' Get the local machine's IP address dynamically
            Dim localIP As String = GetLocalIPAddress()

            If String.IsNullOrEmpty(localIP) Then
                Log("No local IP address found.")
                Return
            End If

            ' Start the server to listen on the local IP address and port 5000
            server = New TcpListener(IPAddress.Parse(localIP), 5000)
            server.Start()
            Log("Server started at " & localIP)

            While True
                Dim client As TcpClient = server.AcceptTcpClient()
                SyncLock clients
                    clients.Add(client)
                End SyncLock
                Dim clientThread As New Thread(AddressOf HandleClient)
                clientThread.Start(client)
            End While
        Catch ex As Exception
            Log("Server error: " & ex.Message)
        End Try
    End Sub

    Private Sub HandleClient(client As TcpClient)
        Dim stream As NetworkStream = client.GetStream()
        Dim buffer(1024) As Byte
        Dim bytesRead As Integer
        Dim clientName As String = ""

        bytesRead = stream.Read(buffer, 0, buffer.Length)
        clientName = Encoding.ASCII.GetString(buffer, 0, bytesRead).Replace("[USER]", "")

        Log(clientName & " joined the chat!")

        Try
            While client.Connected
                bytesRead = stream.Read(buffer, 0, buffer.Length)
                If bytesRead = 0 Then Exit While

                Dim message As String = Encoding.ASCII.GetString(buffer, 0, bytesRead)
                Log(message)
                BroadcastMessage(message, client, clientName)
            End While
        Catch ex As Exception
            Log(clientName & " disconnected.")
        End Try
    End Sub

    Private Sub BroadcastMessage(message As String, sender As TcpClient, senderName As String)
        Dim data As Byte() = Encoding.ASCII.GetBytes(message)
        SyncLock clients
            For Each client In clients
                If client IsNot sender Then
                    Try
                        client.GetStream().Write(data, 0, data.Length)
                    Catch ex As Exception
                        Log("Error sending message.")
                    End Try
                End If
            Next
        End SyncLock
    End Sub

    Private Sub Log(message As String)
        If txtLog.InvokeRequired Then
            txtLog.Invoke(Sub() txtLog.AppendText(message & Environment.NewLine))
        Else
            txtLog.AppendText(message & Environment.NewLine)
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub StartServerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartServerToolStripMenuItem.Click
        serverThread = New Thread(AddressOf StartServer)
        serverThread.IsBackground = True
        serverThread.Start()
        Log("Server started...")
    End Sub

    Private Sub StopServerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopServerToolStripMenuItem.Click

    End Sub

    Private Sub SelectFontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectFontToolStripMenuItem.Click
        If FontDialog1.ShowDialog() = DialogResult.OK Then
            txtLog.Font = FontDialog1.Font
        End If
    End Sub
End Class
