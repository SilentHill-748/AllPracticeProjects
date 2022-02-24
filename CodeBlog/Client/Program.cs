using System;
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace Client
{
    class Program
    {
        private static string _serverIp = "127.0.0.1";
        private static int _port = 8080;


        static void Main(string[] args)
        {
            //Client
            EndPoint serverPoint = new IPEndPoint(IPAddress.Parse(_serverIp), _port);
            Socket serverSocket = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            while (true)
            {
                Console.Write("Введите сообщение: ");
                string message = Console.ReadLine();
                byte[] clientMessage = Encoding.UTF8.GetBytes(message);

                if (!serverSocket.Connected)
                {
                    serverSocket.Connect(serverPoint);
                }

                serverSocket.Send(clientMessage);
            }
        }
    }
}
