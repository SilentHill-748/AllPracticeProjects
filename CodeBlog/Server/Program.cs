using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    class Program
    {
        private const int SERVER_PORT = 8080;
        private const string SERVER_IP = "127.0.0.1";



        static void Main(string[] args)
        {
            //server
            EndPoint serverPoint = new IPEndPoint(IPAddress.Parse(SERVER_IP), SERVER_PORT);
            Socket serverSocket = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            serverSocket.Bind(serverPoint);
            serverSocket.Listen();
            Socket clientSocket = serverSocket.Accept();

            while (true)
            {
                byte[] clientMessage = new byte[1024];
                int messageSize;
                StringBuilder data = new();

                do
                {
                    messageSize = clientSocket.Receive(clientMessage);
                    data.Append(Encoding.UTF8.GetString(clientMessage, 0, messageSize));
                    Console.WriteLine(data);
                }
                while (clientSocket.Available > 0);
            }
        }
    }
}
