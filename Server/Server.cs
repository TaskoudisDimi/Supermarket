using ClassLibrary1;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace Server
{
    public partial class Server : Form
    {

        private Dictionary<string, IPEndPoint> udpClients = new Dictionary<string, IPEndPoint>();

        public Server()
        {
            InitializeComponent();
        }
        private TCPServer tcpServer;

        private void startButton_Click(object sender, EventArgs e)
        {
            #region UDP
            //serverUDP = new UdpClient(8080);
            //endPoint = new IPEndPoint(IPAddress.Any, 0);
            //serverUDP.BeginReceive(ReceiveCallback, null);
            #endregion

            #region TCP

            tcpServer = new TCPServer();
            tcpServer.StartTCP();
            startButton.Enabled = false;
            logListBox.Items.Add("Server started listening on port 8080." + Environment.NewLine);
            
            #endregion


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logListBox.Items.Add("Server started. Waiting for connections..." + Environment.NewLine);
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            tcpServer.StopTCPServer();
        }

        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}