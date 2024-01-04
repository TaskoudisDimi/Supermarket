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


        public Server()
        {
            InitializeComponent();
        }
        private TCPServer tcpServer;
        private UDPServer udpServer;
        private void startButton_Click(object sender, EventArgs e)
        {
            #region UDP

            udpServer = new UDPServer();
            udpServer.StartUDP();
            startButton.Enabled = false;
            logListBox.Items.Add("Server UDP started listening on port 8080." + Environment.NewLine);
            #endregion

            #region TCP

            tcpServer = new TCPServer();
            tcpServer.StartTCP();
            startButton.Enabled = false;
            logListBox.Items.Add("Server TCP started listening on port 8080." + Environment.NewLine);

            tcpServer.ClientConnected += UpdateNumberOfClientsLabel;

            #endregion


        }

        // Method to update the label with the count of connected clients
        private void UpdateNumberOfClientsLabel(int numberOfClients)
        {
            if (labelNumberOfClients.InvokeRequired)
            {
                labelNumberOfClients.BeginInvoke((MethodInvoker)delegate ()
                {
                    labelNumberOfClients.Text = numberOfClients.ToString();
                });
            }
            else
            {
                labelNumberOfClients.Text = numberOfClients.ToString();
            }
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