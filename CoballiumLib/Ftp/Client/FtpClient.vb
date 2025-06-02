Imports Windows.Networking
Imports Windows.Networking.Sockets
Imports Windows.Storage.Streams
Imports System.Text

Namespace Coballium.Ftp.Client

    Public Class FtpClient
        Private socket As StreamSocket
        Private writer As DataWriter
        Private reader As DataReader
        Private host As String
    End Class
End Namespace
