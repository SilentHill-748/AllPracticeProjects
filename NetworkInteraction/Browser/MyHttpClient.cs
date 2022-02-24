using System;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace Browser
{
    public class MyHttpClient
    {
        public const int Web_PAGE_STATUS_OK = 200;

        public const int Web_ERROR_UNKNOWN_ERROR = 0;
        public const int Web_ERROR_HOST_NOT_FOUND = -1;
        public const int Web_ERROR_CANT_CONNECT = -2;
        public const int Web_ERROR_UNAVAILABLE = -3;
        public const int Web_ERROR_UNKNOWN_CODE = -4;



        public MyHttpClient()
        {
            Port = 80;
            _pageContent = new StringBuilder();
        }


        // Здесь хранится загруженная страница.
        private StringBuilder _pageContent;

        public StringBuilder PageContent
        {
            get => _pageContent;
        }

        public int Port { get; set; }




        public int GetPageStatus(Uri url)
        {
            IPAddress address = GetAddress(url.Host);
            if (address == null)
            {
                return Web_ERROR_HOST_NOT_FOUND;
            }

            Socket socket = new(
                AddressFamily.InterNetwork, 
                SocketType.Stream, 
                ProtocolType.Tcp);
            EndPoint endPoint = new IPEndPoint(address, Port); 
            try
            {
                socket.Connect(endPoint);
            }
            catch (Exception)
            {
                return Web_ERROR_CANT_CONNECT;
            }

            string command = GetCommand(url);
            byte[] bytesSent = Encoding.ASCII.GetBytes(command.Substring(1, command.Length - 1) + "\r\n");
            socket.Send(bytesSent);

            byte[] buffer = new byte[1024];
            int readBytes;
            int result = Web_ERROR_UNAVAILABLE;

            while ((readBytes = socket.Receive(buffer)) > 0)
            {
                string resultStr = Encoding.UTF8.GetString(buffer, 0, readBytes);
                if (_pageContent == null)   
                {
                    string statusStr = resultStr.Remove(0, resultStr.IndexOf(' ') + 1);
                    try
                    {
                        result = Convert.ToInt32(statusStr.Substring(0, 3)); // 200
                    }
                    catch (Exception)
                    {
                        result = Web_ERROR_UNKNOWN_CODE;
                    }
                    _pageContent = new StringBuilder();
                }
                _pageContent.AppendLine(resultStr);
            }
            socket.Close();
            return result;
        }

        protected string GetCommand(Uri url)
        {
            string command = $"GET {url.PathAndQuery} HTTP/1.1\r\n";
            command += $"HOST: {url.Host} \r\n";
            command += $"User-Agent: CyD Network Utilities \r\n";
            command += $"Accept: */* \r\n";
            command += $"Accept-Language: en-us \r\n";
            command += $"Accept-Encoding: gzip, deflate \r\n";
            command += $"\r\n";
            return command;
        }

        public IPAddress GetAddress(string address)
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
    }
}
