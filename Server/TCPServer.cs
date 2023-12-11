using ClassLibrary1;
using ClassLibrary1.Models;
using Microsoft.VisualBasic.Devices;
using SupermarketTuto.Utils;
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

        public void StartServer(object? obj)
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

        public void HandleClient(Socket clientSocket)
        {
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
                    _clients.Remove(clientSocket);
                }
            }
        }

        public void BroadcastToClients(Socket senderSocket, byte[] data)
        {
            lock (_lock)
            {
                foreach (Socket client in _clients)
                {
                    if (client != senderSocket)
                        client.Send(data);
                }
            }
        }

        public void StopTCPServer()
        {
            serverTCP.Close();
        }



    }
}
