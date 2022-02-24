using System.Data;

using MySql.Data.MySqlClient;

using Tourism.Entities;

namespace Tourism
{
    public class SqlExecuter
    {
        private const string CONN_STR = "server=localhost;database=tourist_agency;uid=root;password=root;";

        public static DataTable ExecuteCommand(string commandStr)
        {
            using (var connect = new MySqlConnection(CONN_STR))
            {
                connect.Open();
                using (var command = new MySqlCommand(commandStr, connect))
                {
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
        }

        public static object ExecuteScalarCommand(string commandStr)
        {
            using (var connect = new MySqlConnection(CONN_STR))
            {
                connect.Open();
                using (var command = new MySqlCommand(commandStr, connect))
                {
                    return command.ExecuteScalar();
                }
            }
        }

        public static void ExecuteEntity(IEntity entity)
        {
            using (var connect = new MySqlConnection(CONN_STR))
            {
                connect.Open();
                using (var command = new MySqlCommand(entity.InsertCommand, connect))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
