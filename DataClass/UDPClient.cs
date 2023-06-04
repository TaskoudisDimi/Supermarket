using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class UDPClient
    {

        public UdpClient udpClient;
        public IPEndPoint endPoint;
        private Thread threadReceive;

        public void CreateUDPClient()
        {
            udpClient = new UdpClient();
        }

        public void StartListenUDP(string host, string port)
        {
            udpClient.Client.Bind(new IPEndPoint(IPAddress.Any,0));

            endPoint = new IPEndPoint(IPAddress.Parse(host), Convert.ToInt32(port));

            threadReceive = new Thread(Receive);
            threadReceive.Start();
            
        }

        private void Receive()
        {
            udpClient.BeginReceive(ReceiveCallBack, null);
        }

        private void ReceiveCallBack(IAsyncResult ar)
        {
            byte[] receivedBytes = udpClient.EndReceive(ar, ref endPoint);
            string receivedMessage = Encoding.ASCII.GetString(receivedBytes);

            // Continue receiving messages
            udpClient.BeginReceive(ReceiveCallBack, null);
        }


        public void Discconect()
        {
            udpClient.Close();
        }
    }
}
