using System;
using System.Threading;

namespace ServerClientChat
{
    public class Program
    {
        static Server server;
        static Thread serverThread;

        static void Main(string[] args)
        {
            try
            {
                server = new Server();  // Инициализирую сервер.
                serverThread = new Thread(new ThreadStart(server.Listen)); // Создаю поток на прослушку сервера.
                serverThread.Start(); 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                server.Disconnect();
            }
        }
    }
}
