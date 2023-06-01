using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Server
{
    public partial class Server : Form
    {
        private List<Socket> _clients = new List<Socket>();
        private readonly object _lock = new object();
        private Socket _serverSocket;
        private Thread _serverThread;

        public Server()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _serverSocket.Bind(new IPEndPoint(IPAddress.Any, 1234));
            _serverSocket.Listen(10);

            _serverThread = new Thread(StartServer);
            _serverThread.Start();

            startButton.Enabled = false;
            logListBox.Items.Add("Server started listening on port 1234." + Environment.NewLine);
        }

        private void StartServer(object? obj)
        {
            while (true)
            {
                Socket clientSocket = _serverSocket.Accept();
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
            byte[] buffer;
            buffer = Encoding.UTF8.GetBytes(bufferSizeTextBox.Text);
            int bytesRead;

            try
            {
                while ((bytesRead = clientSocket.Receive(buffer)) > 0)
                {
                    byte[] receivedData = new byte[bytesRead];
                    Array.Copy(buffer, receivedData, bytesRead);

                    string receivedMessage = Encoding.ASCII.GetString(receivedData);
                    logListBox.Invoke(new Action(() =>
                    {
                        logListBox.Items.Add("Received message from client: " + receivedMessage + Environment.NewLine);
                    }));
                    countLabel.Invoke(new Action(() =>
                    {
                        countLabel.Text = $"{_clients.Count}";
                    }));

                    BroadcastToClients(clientSocket, receivedMessage);
                }
            }
            catch (SocketException)
            {
                lock (_lock)
                {
                    _clients.Remove(clientSocket);
                }
                logListBox.Invoke(new Action(() =>
                {
                    logListBox.Items.Add("Client disconnected." + Environment.NewLine);
                }));
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

        private void Form1_Load(object sender, EventArgs e)
        {
            logListBox.Items.Add("Server started. Waiting for connections..." + Environment.NewLine);
        }
    }
}