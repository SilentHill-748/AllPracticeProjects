using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ServerClientChat
{
    public class Client
    {
        internal string Id { get; private set; }                // Уникальный ID.
        internal NetworkStream Stream { get; private set; }     // Поток NetworkStream для каждого нового клиента.
        private Server server;                                  // Данный объект нам нужен для широковещательной отправки сообщений.
        private TcpClient client;

        public Client(TcpClient tcpClient, Server server)
        {
            Id = Guid.NewGuid().ToString();
            client = tcpClient;
            this.server = server;               // Сервер, к которому будут подключены клиенты.
            this.server.AddConnection(this);    // Добавляем данного клиента в список подключений сервера.
        }

        // В данном методе каждый клиент получает сообщение от сервера и отображает его на сервере. (см. Server.Listen)
        internal void Process()
        {
            string message;

            try
            {
                // Блок приветственного сообщения.
                Stream = client.GetStream();
                message = "Пользователь вошёл!";
                server.BroadcastMessage(message, this.Id); // см. описание метода в классе Server.
                Console.WriteLine(message);
                while (true)
                {
                    try
                    {
                        // Блок ретрансляции полученного сообщения всем, кто подключен к серверу.
                        message = GetMessage();
                        Console.WriteLine(message);
                        server.BroadcastMessage(message, this.Id);
                    }
                    catch
                    {
                        // Блок оповещения об ушедшем клиенте.
                        message = "Пользователь вышел!";
                        Console.WriteLine(message);
                        server.BroadcastMessage(message, this.Id);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                server.RemoveConnection(this.Id);
                Close();
            }
        }

        // Метод для считывания байтов из потока и конвертирование их в string.
        private string GetMessage()
        {
            byte[] bytes = new byte[128];
            int size;
            StringBuilder builder = new StringBuilder();
            do
            {
                size = Stream.Read(bytes, 0, bytes.Length);
                builder.Append(Encoding.UTF8.GetString(bytes, 0, size));
            }
            while (Stream.DataAvailable);
            return builder.ToString();
        }

        // Используется для закрытия подключений.
        internal void Close()
        {
            if (Stream != null) Stream.Close();

            if (client != null) client.Close();
        }
    }
}
