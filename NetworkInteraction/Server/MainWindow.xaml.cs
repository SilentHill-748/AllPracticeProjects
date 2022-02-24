using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Server
{
    public partial class MainWindow : Window
    {
        private Socket server;
        private Socket client;



        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitServer()
        {
            if (server is not null && server.Connected)
            {
                server.Disconnect(false);
            }

            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            EndPoint endPoint = new IPEndPoint(IPAddress.Any, 12345);

            try
            {
                server.Bind(endPoint);
                server.Listen(100);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Невозможно запустить сервер:\n" + exc.Message);
                return;
            }
            server.BeginAccept(AsyncAcceptCallback, server);
        }

        private void AsyncAcceptCallback(IAsyncResult result)
        {
            Socket serverSocket = (Socket)result.AsyncState;
            SocketData data = new();
            data.ClientConnection = serverSocket.EndAccept(result);

            byte[] bytes = new byte[1024];
            data.ClientConnection
                .BeginReceive(data.Buffer, 0, SocketData.BufferSize, SocketFlags.None, ReadCallback, data);
        }

        private void ReadCallback(IAsyncResult result)
        {
            SocketData data = (SocketData)result.AsyncState;
            int bytes = data.ClientConnection.EndReceive(result);

            if (bytes > 0)
            {
                string message = Encoding.UTF8.GetString(data.Buffer, 0, bytes);
                data.ClientConnection.Send(Encoding.UTF8.GetBytes($"Получено: {message.Length} символов."));
            }
        }

        private void InitClient()
        {
            if (client is not null && client.Connected)
            {
                client.Disconnect(false);
            }

            IPAddress addr = GetAddress(addressText.Text);
            if (addr is null)
            {
                MessageBox.Show("Сервер не найден!");
                return;
            }

            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            EndPoint clientPoint = new IPEndPoint(addr, 12345);

            try
            {
                client.Connect(clientPoint);
            }
            catch (Exception exc)
            {
                MessageBox.Show($"Ошибка соединения.\n{exc.Message}");
            }
        }

        private void SendMessage()
        {
            if (client is null || !client.Connected)
            {
                MessageBox.Show("Подключитесь к серверу!");
                return;
            }
            client.Send(Encoding.UTF8.GetBytes(commandText.Text));
            byte[] buffer = new byte[1024];
            int bytes = client.Receive(buffer);
            if (bytes > 0)
            {
                string message = Encoding.UTF8.GetString(buffer, 0, bytes);
                clientChat.Text += $"{message}\n";
            }
        }

        private IPAddress GetAddress(string address)
        {
            IPAddress ipAddress;

            try
            {
                ipAddress = IPAddress.Parse(address);
            }
            catch (Exception)
            {
                IPHostEntry heServer = Dns.GetHostEntry(address);
                if (heServer.AddressList.Length == 0)
                {
                    return null;
                }
                ipAddress = heServer.AddressList.First();
            }
            return ipAddress;
        }

        private void runServer_Click(object sender, RoutedEventArgs e)
        {
            InitServer();
        }

        private void connectToServer_Click(object sender, RoutedEventArgs e)
        {
            InitClient();
        }

        private void sendBut_Click(object sender, RoutedEventArgs e)
        {
            SendMessage();
        }
    }

    class SocketData
    {
        public const int BufferSize = 1024;

        public Socket ClientConnection { get; set; }

        byte[] buffer = new byte[BufferSize];

        public byte[] Buffer
        {
            get { return buffer; }
            set { buffer = value; }
        }
    }
}
