using System;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    class Program
    {
        static string ip = "127.0.0.1";     // Ip/port сервера.
        static int port = 8080;
        static TcpClient client;            // Объект клиента.
        static NetworkStream stream;        // Поток NetworkStream для отправки/получения сообщений.

        static void Main()
        {
            try
            {
                client = new TcpClient();       // Инициализирую клиента.
                client.Connect(ip, port);       // Подключаюсь к серверу.
                stream = client.GetStream();    // Создаю поток NetworkStream клиента для получения/отправки сообщений.

                // Эта строка кода инициализирует новый поток, в котором будет асинхронно ожидаться получаемые сообщения.
                Thread receiveMessage = new Thread(new ThreadStart(() => ReceiveMessage()));
                receiveMessage.Start();

                SendMessage();               // См. описание метода.
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                client.Close(); // В случае исключения удаляю клиента.
            }
        }

        // Конвертирую сообщение юзера в массив байт и отправляю через поток NetworkStream клиента на сервер.
        private static void SendMessage()
        {
            while (true)
            {
                Console.WriteLine("Введите сообщение:");
                string message = Console.ReadLine();
                byte[] bytes = Encoding.UTF8.GetBytes(message);
                stream.Write(bytes, 0, bytes.Length);
            }
        }

        // Метод для получения сообщений от сервера. Он вызывается и исполняется в отдельном потоке.
        private static void ReceiveMessage()
        {
            while (true) // Вечный цикл, чтобы постоянно получать сообщения.
            {
                try
                {
                    byte[] bytes = new byte[64]; // 64 - буфер байтов, которое может принять клиент от сервера.
                    StringBuilder builder = new StringBuilder(); // Класс для динамической работы со строками.
                    do
                    {
                        // Внимание! Я выделил новый поток на данный метод, потому что метод Read класса NetworkStream 
                        // БЛОКИРУЕТ поток, в котором он был вызван! И если поток не выделить, то клиент "встанет" и не сможет отправлять
                        // Сообщения, пока не получит данные от сервера, если вообще не крашнется через исключение.
                        int size = stream.Read(bytes, 0, bytes.Length); // size - число полученных байтов.
                        builder.Append(Encoding.UTF8.GetString(bytes, 0, size)); // Полученное сообщение парсится из байтов в строковое значение.
                    }
                    while (stream.DataAvailable); // Возвращает false, если в потоке нет данных для чтения.
                    string message = builder.ToString();
                    Console.WriteLine("Server: " + message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
