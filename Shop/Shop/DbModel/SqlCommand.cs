using System;
using System.Data;

using MySql.Data.MySqlClient;

namespace Shop.DbModel
{
    public class SqlCommand
    {
        private const string conString = "Server=localhost;Database=Shop;user=root;password=root;";

        /// <summary>
        /// Выполняет запрос в базу данных.
        /// </summary>
        public static DataTable Execute(string quary)
        {
            MySqlConnection connect = OpenConnection();
            using (var command = new MySqlCommand(quary, connect))
            {
                using (var adapter = new MySqlDataAdapter(command))
                {
                    DataSet data = new DataSet();
                    adapter.Fill(data);
                    if (data.Tables.Count > 0)
                    {
                        connect.Close();
                        return data.Tables[0];
                    }
                }
            }
            throw new Exception("Ошибка отправки запроса. Данные отсутствуют или неверно составлен запрос!");
        }

        private static MySqlConnection OpenConnection()
        {
            var connect = new MySqlConnection(conString);
            if (connect.Ping())
                connect.Open();
            return connect;
        }
    }
}
