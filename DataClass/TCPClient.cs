using ClassLibrary1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class TCPClient
    {
        public Socket client;
        private Thread clientThread;
        List<DataGridViewCellChange> changedCells = new List<DataGridViewCellChange>();
        public event EventHandler<List<DataGridViewCellChange>> UpdateDataServer;
        public void ConnectClient()
        {
            string ipAddress = "127.0.0.1";
            int port = 8080;
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            client.Connect(ipAddress, port);

            clientThread = new Thread(ReceiveData);
            clientThread.Start();

        }

        private void ReceiveData(object obj)
        {
            
            DataGridViewCellChange dataCell = new DataGridViewCellChange();
            byte[] buffer = new byte[1024];
            int readBytes;
            while ((readBytes = client.Receive(buffer)) > 0)
            {
                byte[] receiveData = new byte[readBytes];
                Array.Copy(buffer, receiveData, readBytes);

                string json = Encoding.UTF8.GetString(receiveData);
                JsonDocument jsonData = JsonDocument.Parse(json);
                JsonElement root = jsonData.RootElement;
                string newValue = "";
                foreach (JsonElement elem in root.EnumerateArray())
                {
                    // Access the properties dynamically
                    dataCell.RowIndex = elem.GetProperty("RowIndex").GetInt32();
                    dataCell.ColumnIndex = elem.GetProperty("ColumnIndex").GetInt32();
                    dataCell.NewValue = elem.GetProperty("NewValue").GetString();
                    changedCells.Add(dataCell);
                    UpdateDataServer?.Invoke(this, changedCells);
                }

            }
        }

        public void SendData(List<DataGridViewCellChange> data)
        {
            try
            {
                string json = JsonSerializer.Serialize(data);
                byte[] bytes = Encoding.UTF8.GetBytes(json);
                client.Send(bytes);
                
            }
            catch
            {

            }
            

        }

        public void StopClient()
        {
            // Close the connection
            client.Shutdown(SocketShutdown.Both);
           
        }
    }
}
