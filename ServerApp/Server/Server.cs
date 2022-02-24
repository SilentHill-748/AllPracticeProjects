using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ServerClientChat
{
    public class Server
    {
        static TcpListener listener;
        internal List<Client> tcpClients = new List<Client>(); // Коллекция подключений.

        // Добавление клиента в список подключений, в случае, когда юзер открывает приложение (клиентское).
        internal void AddConnection(Client newClient) => tcpClients.Add(newClient);
      

        // Удаление клиента в случае отключения из списка подключений.
        internal void RemoveConnection(string id)
        {
            Client client = tcpClients.FirstOrDefault(c => c.Id == id); // Ищем Id клиента в списке подключений.

            if (client != null) tcpClients.Remove(client); // Удаляем его, если такой есть.
        }

        // Данный метод прослушивает все подключения по УКАЗАННОМУ ЗАРАНЕЕ порту. В моем случае, я указал 8080 порт.
        internal void Listen()
        {
            try
            {
                listener = new TcpListener(IPAddress.Any, 8080); // Инициализация объекта TcpListener.
                listener.Start();

                while (true)
                {
                    TcpClient tcpClient = listener.AcceptTcpClient();                   // Подключаем очердного клиента.
                    Client client = new Client(tcpClient, this);                        // Записываем его в наш класс.
                    Thread clientThread = new Thread(new ThreadStart(client.Process));  
                    // Создаю новый поток для получения сообщений и трансляции его всем подключенным клиентам, кроме отправителя.
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Disconnect();
            }
        }

        // Широковещательная отправка сообщений. Отправляем сообщение всем клиента, где id != id отправителя.
        internal void BroadcastMessage(string message, string id)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(message);
            for (int i = 0; i < tcpClients.Count; i++)
            {
                if (tcpClients[i].Id != id)
                    tcpClients[i].Stream.Write(bytes, 0, bytes.Length);
            }
        }

        // В случае исключения - отключаем всех от сервера и удаляем клиентов.
        internal void Disconnect()
        {
            listener.Stop();

            for (int i = 0; i < tcpClients.Count; i++)
            {
                tcpClients[i].Close();
            }
        }
    }
}
