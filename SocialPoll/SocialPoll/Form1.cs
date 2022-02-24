using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Numerics;

namespace SocialPoll
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        OleDbConnection dbConnect;
        OleDbCommand command;

        private static int counter = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DBConnect();
            LoadData();
        }

        private string SetSex()
        {
            int percent = rnd.Next(0, 101);

            if (percent <= 45)
                return "Ж";
            else
                return "М";
        }

        private string SetAge()
        {
            int percent = rnd.Next(0, 101);

            if (percent <= 2) return "Старше 60";
            if (percent > 2 && percent <= 7) return "46-60";

            if (percent > 7 && percent <= 27)
            {
                if (rnd.Next(0, 2) == 0)
                    return "До 18";
                else
                    return "31-45";
            }
            if (percent > 27) return "19-30";

            throw new Exception("Возраст не указан!");
        }

        private string SetAnswer(int chanceNO, int chanceUnknown)
        {
            int percent = rnd.Next(0, 101);

            if (percent <= chanceUnknown)
                return "Затрудняюсь ответить";
            else if (percent <= chanceUnknown + chanceNO)
                return "Нет";
            else
                return "Да";
        }

        private string SetSource(params int[] chances)
        {
            int percent = rnd.Next(0, 101);

            string[] source = new string[]
            {
                "Семья/друзья", "СМИ/Интернет", "Книги", "Медиа", "Случайно узнал", "Из опроса"
            };

            if (percent <= chances[0]) return source[0];

            return GetSource(percent, chances, source);
        }

        private string GetSource(int percent, int[] chances, string[] source)
        {
            for (int i = 1; i < chances.Length - 2; i++)
            {
                if (percent <= chances[i] + chances[i - 1])
                {
                    if (chances[i] != chances[i + 1])
                        return source[i];
                    else
                        return source[rnd.Next(i, i + 2)]; // Возможно исключение!
                }
            }

            return source[source.Length - 1];
        }

        private void AddRecordButton_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                int newCounter = Convert.ToInt32(textBox3.Text);
                counter = newCounter;
                textBox3.Text = "";
            }

            command = AddRecord();
            command.ExecuteReader();
            LoadData();
        }

        private void DBConnect()
        {
            string provider = "Provider = Microsoft.ACE.OLEDB.12.0; ";
            string dataSource = "Data Source=" + @"D:\DataBase\DataBaseForApp.accdb";
            string connectionPath = provider + dataSource;

            dbConnect = new OleDbConnection(connectionPath);
            dbConnect.Open();
        }

        private void LoadData()
        {
            string quary = "SELECT * FROM Social_Poll;";

            OleDbCommand command = new OleDbCommand(quary, dbConnect);
            OleDbDataAdapter adapter = new OleDbDataAdapter();

            adapter.SelectCommand = command;
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            adapter.Update(dataSet);
            this.dataGridView1.Sort(this.dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private OleDbCommand AddRecord()
        {
            string insert = "INSERT INTO Social_Poll ";
            string columns1 = "([Counter], [Sex], [Age], ";
            string columns2 = "[First_question], [Second_question], [Third_question], [Fourth_question], [Fifth_question], [Sixth_question], ";
            string columns3 = "[Source_1], [Source_2], [Source_3], [Source_4], [Source_5], [Source_6]) ";

            string query = insert + columns1 + columns2 + columns3 + "VALUES ";

            string sexAndAge = ""+ counter.ToString() + ", '" + SetSex() + "', '" + SetAge() + "', ";

            string answers = "'" + SetAnswer(43, 7) + "', '" + SetAnswer(26, 6) + "', '" + SetAnswer(31, 23) + "', '" + 
                             SetAnswer(55, 15) + "', '" + SetAnswer(67, 3) + "', '" + SetAnswer(30, 20) + "', ";

            string sources = "'" + SetSource(9,45,14,13,13,6) + "', '" + SetSource(6,43,13,18,13,7) + "', '" +
                             SetSource(16,27,22,13,17,5) + "', '" + SetSource(8,46,14,14,15,3) + "', '" +
                             SetSource(14,45,8,14,16,3) + "', '" + SetSource(13,36,16,10,15,10) + "'";

            query = query + "(" + sexAndAge + answers + sources + ");";

            counter++;

            return new OleDbCommand(query, dbConnect);
        }

        private void AddTenRecordsButton_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                int newCounter = Convert.ToInt32(textBox3.Text);
                counter = newCounter;
                textBox3.Text = "";
            }

            for (int i = 0; i < 10; i++)
            {
                command = AddRecord();
                command.ExecuteReader();
            }
            LoadData();
        }

        // TODO: Написать метод проверки запроса на корректный ввод.
        // TODO: Написать логику отправки 10 запросов с разницей отправки в 1 секунду.
    }
}
