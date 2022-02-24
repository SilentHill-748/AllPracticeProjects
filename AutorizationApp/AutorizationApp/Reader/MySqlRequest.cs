using System.Data;
using System.IO;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AutorizationApp.Reader
{
    internal class MySqlRequest
    {
        private readonly string connectString = $"server=localhost; database=mydb; user=root; password=K20PQR3256qsh1;";
        private DataSet data;

        public string XmlRepresentation { get; private set; }

        public MySqlRequest() { }

        public MySqlRequest(string connectString)
        {
            this.connectString = connectString;
        }

        /// <summary>
        /// Отправка запроса в локальный MySQL Server.
        /// </summary>
        public void Send(string quary)
        {
            data = new DataSet();
            using (var connect = new MySqlConnection(connectString))
            {
                var adapter = new MySqlDataAdapter(quary, connect);
                adapter.Fill(data);
                XmlRepresentation = data.GetXml();
            }
        }

        /// <summary>
        /// Асинхронная отправка запроса в локальный MySQL Server.
        /// </summary>
        public async void SendAsync(string quary)
        {
            data = new DataSet();

            await Task.Run(() =>
            {
                using (var connect = new MySqlConnection(connectString))
                {
                    var adapter = new MySqlDataAdapter(quary, connect);
                    adapter.Fill(data);
                    XmlRepresentation = data.GetXml();
                }
            });
        }

        /// <summary>
        /// Запись результата запроса в текстовый файл по указанному пути.
        /// </summary>
        public void ToTextFile(string path)
        {
            using (var writer = new StreamWriter(path))
                writer.WriteLine(XmlRepresentation);
        }
    }
}
