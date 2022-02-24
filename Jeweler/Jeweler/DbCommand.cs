using System.Data;
using MySql.Data.MySqlClient;

namespace Jeweler
{
    public class DbCommand
    {
        private const string connectionStr = "Server=localhost; " +
                                            "Database=jewelerdb;" +
                                            "user=root;" + 
                                            "password=test";

        public static DataTable Send(string quary)
        {
            DataSet set = new DataSet();
            MySqlConnection connection = InitConnection();


            using (var command = new MySqlCommand(quary, connection))
            {
                if (!connection.Ping())
                    connection.Open();
                using (var adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(set);
                    if (set.Tables.Count != 0)
                        return set.Tables[0];
                    else
                        return new DataTable();
                }
            }
        }

        private static MySqlConnection InitConnection()
        {
            var connection = new MySqlConnection(connectionStr);
            return connection;
        }
    }
}
