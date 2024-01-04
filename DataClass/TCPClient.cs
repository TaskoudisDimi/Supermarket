
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading;

namespace ClassLibrary1
{
    public class TCPClient
    {
        private Socket client;
        private Thread clientThread;
        public event EventHandler<string> DataReceived;
        private bool isConnected = false;

        public void ConnectTCPClient(string clientIpAddress, int clientPort)
        {
            string serverIpAddress = "127.0.0.1";
            int serverPort = 8080;
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // Explicitly bind the client socket to a specific local endpoint
            client.Bind(new IPEndPoint(IPAddress.Parse(clientIpAddress), clientPort));
            client.Connect(serverIpAddress, serverPort);
            isConnected = true;
            clientThread = new Thread(ReceiveData);
            clientThread.Start();
        }

        private void ReceiveData(object obj)
        {
            byte[] buffer = new byte[1024];
            int readBytes;
            while ((readBytes = client.Receive(buffer)) > 0)
            {
                byte[] receiveData = new byte[readBytes];
                Array.Copy(buffer, receiveData, readBytes);
                string json = Encoding.UTF8.GetString(receiveData);
                DataReceived?.Invoke(this, json);

            }
        }

        public void SendDataTCP<T>(List<T> data) where T : class
        {
            try
            {
                string json = JsonSerializer.Serialize(data);
                byte[] bytes = Encoding.UTF8.GetBytes(json);
                client.Send(bytes);
            }
            catch
            {
                // Handle exception
            }
        }

        public void StopClient()
        {
            if (isConnected)
            {
                // Close the connection
                client.Shutdown(SocketShutdown.Both);
                client.Close();
                isConnected = false;
            }
        }
    }
}