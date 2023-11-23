using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Server
{
    public class TCPServer
    {

        private Socket serverTCP;
        private Thread serverThread;
        private readonly object _lock = new object();
        private List<Socket> _clients = new List<Socket>();

        public void StartTCP()
        {
            serverTCP = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            serverTCP.Bind(new IPEndPoint(IPAddress.Any, 8080));
            serverTCP.Listen(10);

            serverThread = new Thread(StartServer);
            serverThread.Start();

        }

        private void StartServer(object? obj)
        {
            while (true)
            {
                Socket clientSocket = serverTCP.Accept();
                lock (_lock)
                {
                    _clients.Add(clientSocket);

                }

                Thread clientThread = new Thread(() => HandleClient(clientSocket));
                clientThread.Start();
            }
        }

        private void HandleClient(Socket clientSocket)
        {

            byte[] buffer = new byte[1024];
            int bytesRead;
            try
            {
                while ((bytesRead = clientSocket.Receive(buffer)) > 0)
                {
                    byte[] receivedData = new byte[bytesRead];
                    Array.Copy(buffer, receivedData, bytesRead);

                    string jsonData = Encoding.UTF8.GetString(receivedData);

                    // Parse the JSON string into a JsonDocument
                    JsonDocument jsonDocument = JsonDocument.Parse(jsonData);

                    // Access the root element of the JSON array
                    JsonElement root = jsonDocument.RootElement;
                    string newValue = "";

                    foreach (JsonElement element in root.EnumerateArray())
                    {
                        // Access the properties dynamically
                        int rowIndex = element.GetProperty("RowIndex").GetInt32();
                        int columnIndex = element.GetProperty("ColumnIndex").GetInt32();
                        newValue = element.GetProperty("NewValue").GetString();

                    }

                    BroadcastToClients(clientSocket, jsonData);
                }
            }
            catch (SocketException)
            {
                lock (_lock)
                {
                    _clients.Remove(clientSocket);
                }
            }
        }

        private void BroadcastToClients(Socket senderSocket, string message)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(message);
            lock (_lock)
            {
                foreach (Socket client in _clients)
                {
                    if (client != senderSocket)
                        client.Send(buffer);
                }
            }
        }

    }
}
