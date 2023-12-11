using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class UDPClient
    {

        public UdpClient udpClient;
        public IPEndPoint endPoint;
        private Thread threadReceive;
        public event EventHandler<string> DataReceived;

        public void ConnectUDPClient()
        {
            string host = "127.0.0.1";
            int port = 9999;
            udpClient = new UdpClient();
            udpClient.Client.Bind(new IPEndPoint(IPAddress.Any,0));
            endPoint = new IPEndPoint(IPAddress.Parse(host), Convert.ToInt32(port));
            threadReceive = new Thread(Receive);
            threadReceive.Start();
        }

        public void SendDataUDP<T>(List<T> data) where T : class
        {
            string json = JsonSerializer.Serialize(data);
            byte[] messageBytes = Encoding.ASCII.GetBytes(json);
            // Send the message to the server
            udpClient.Send(messageBytes, messageBytes.Length, endPoint);
        }

        private void Receive()
        {
            udpClient.BeginReceive(ReceiveCallBack, null);
        }

        private void ReceiveCallBack(IAsyncResult ar)
        {
            byte[] receivedBytes = udpClient.EndReceive(ar, ref endPoint);
            //string receivedMessage = Encoding.ASCII.GetString(receivedBytes);
            string json = Encoding.UTF8.GetString(receivedBytes);
            DataReceived?.Invoke(this, json);
            // Continue receiving messages
            udpClient.BeginReceive(ReceiveCallBack, null);


        }

        public void Discconect()
        {
            udpClient.Close();
        }

    }
}
