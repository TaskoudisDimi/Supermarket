using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class UDPServer
    {
        private UdpClient udpServer;
        private bool isRunning;
        private IPEndPoint clientEndpoint;
        private List<IPEndPoint> clients = new List<IPEndPoint>();
        public int countUDPClients = 0;

        public UDPServer()
        {
            udpServer = new UdpClient(9999);
        }

        public void StartUDP()
        {
            isRunning = true;
            Thread receiveThread = new Thread(ReceiveData);
            receiveThread.Start();

        }

        private void ReceiveData(object? obj)
        {
            clientEndpoint = new IPEndPoint(IPAddress.Any, 0);
            while (isRunning)
            {
                byte[] receiveBytes = udpServer.Receive(ref clientEndpoint);
                string receivedData = Encoding.ASCII.GetString(receiveBytes);
                clients.Add(clientEndpoint);
                BroadcastToClients(receivedData);
            }

        }

        private void BroadcastToClients(string receivedData)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(receivedData);

            foreach (IPEndPoint client in clients)
            {
                if (!client.Equals(clientEndpoint))
                {
                    udpServer.Send(bytes, bytes.Length, client);
                }
            }
        }

        public void Stop()
        {
            isRunning = false;
            udpServer.Close();
        }


    }
}
