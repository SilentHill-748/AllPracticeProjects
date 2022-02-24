using System;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DataReader
{
    public static class Request
    {
        private static string connectionString = "Server=localhost;" +
                                                 "database=University;" +
                                                 "user=root;" +
                                                 "password=K20PQR3256qsh1";

        /// <summary>
        /// Отправляет запрос в базу данных и возвращает таблицу с данными запроса асинхронно
        /// </summary>
        /// <exception cref="Exception"/>
        public static async Task<DataTable> SendAsync(string quary)
        {
            DataSet set = new();
            using MySqlConnection connection = new(connectionString);
            if (connection.Ping())
                connection.Open();

            using MySqlCommand command = new(quary, connection);
            using MySqlDataAdapter adapter = new(command);
            await Task.Run(() => adapter.Fill(set));
            connection.Close();

            if (set.Tables.Count > 0)
                return set.Tables[0];
            throw new Exception("Запрос не дал результатов!");
        }
    }
}
