using System.Data;
using MySql.Data.MySqlClient;

namespace AeroportList
{
    public class DbSender
    {
        private const string _connectionString = "Server=localhost;database=aeroport;user=root;password=test";
        private readonly string _quary;

        public DataSet Data { get; private set; }

        public DbSender(string quary)
        {
            this._quary = quary;
            this.Data = new DataSet();
        }

        public void Send()
        {
            using (MySqlConnection connect = new MySqlConnection(_connectionString))
            {
                connect.Open();
                using (MySqlCommand command = new MySqlCommand(_quary, connect))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(Data);
                    }
                }
            }
        }
    }
}
