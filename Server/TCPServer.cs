using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Server
{
    public class TCPServer
    {
        private Socket serverTCP;
        private Thread serverThread;
        private readonly object _lock = new object();
        private HashSet<EndPoint> _clientEndPoints = new HashSet<EndPoint>(); // Use HashSet for unique client endpoints
        public int countTCPClients = 0;

        public delegate void ClientConnectedHandler(int numberOfClients);
        public event ClientConnectedHandler ClientConnected;

        public void StartTCP()
        {
            serverTCP = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            serverTCP.Bind(new IPEndPoint(IPAddress.Any, 8080));
            serverTCP.Listen(10);
            serverThread = new Thread(StartServer);
            serverThread.Start();
        }

        public void StartServer(object? obj)
        {
            while (true)
            {
                Socket clientSocket = serverTCP.Accept();
                Thread clientThread = new Thread(() => HandleClient(clientSocket));
                clientThread.Start();
            }
        }

        public void HandleClient(Socket clientSocket)
        {
            EndPoint clientEndPoint = clientSocket.RemoteEndPoint;

            lock (_lock)
            {
                // Check if the client's endpoint already exists in the set
                if (!_clientEndPoints.Contains(clientEndPoint))
                {
                    _clientEndPoints.Add(clientEndPoint); // Add the unique client endpoint to the set
                    countTCPClients = _clientEndPoints.Count; // Update the count of unique clients
                }
            }

            ClientConnected?.Invoke(countTCPClients); // Fire the event with the count of unique clients

            byte[] buffer = new byte[1024];
            int bytesRead;
            try
            {
                while ((bytesRead = clientSocket.Receive(buffer)) > 0)
                {
                    byte[] receivedData = new byte[bytesRead];
                    Array.Copy(buffer, receivedData, bytesRead);
                    BroadcastToClients(clientSocket, receivedData);
                }
            }
            catch (SocketException)
            {
                lock (_lock)
                {
                    _clientEndPoints.Remove(clientEndPoint); // Remove client endpoint on disconnection
                    countTCPClients = _clientEndPoints.Count; // Update the count of unique clients
                }
                ClientConnected?.Invoke(countTCPClients); // Fire the event with the updated count
            }
        }

        public void BroadcastToClients(Socket senderSocket, byte[] data)
        {
            lock (_lock)
            {
                foreach (EndPoint endPoint in _clientEndPoints)
                {
                    if (!endPoint.Equals(senderSocket.RemoteEndPoint))
                    {
                        Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        client.Connect(endPoint);
                        client.Send(data);
                        client.Close();
                    }
                }
            }
        }

        public void StopTCPServer()
        {
            serverTCP.Close();
        }
    }
}
