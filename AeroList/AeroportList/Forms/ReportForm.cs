using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace AeroportList.Forms
{
    public partial class ReportForm : Form
    {
        private readonly List<object[]> _values;
        private DataTable _table;

        public ReportForm()
        {
            InitializeComponent();

            _values = new List<object[]>();
            _table = new DataTable();
            LoadAllReport();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadReportData();
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text files | *.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, SaveToString());
                }
            }
        }

        public void LoadAllReport()
        {
            string sql = "select Номер_брони 'Бронь', бил.Номер_билета 'Билет', бил.Посадочное_место 'Место', " +
                "пас.ФИО 'Полное имя', пас.Номер_паспорта 'Паспорт', пас.Дата_рождения, брон.id_рейса 'Рейс', рейсы.Цена " +
                "from бронирование брон join авиарейсы рейсы on рейсы.id_рейса = брон.id_рейса " +
                "join билеты бил on бил.Номер_билета = брон.Номер_билета join пассажиры пас on пас.Номер_паспорта = брон.Номер_паспорта;";

            DbSender sender = new DbSender(sql);
            sender.Send();
            _table = sender.Data.Tables[0];
            reportGrid.DataSource = _table;
        }

        private void LoadReportData()
        {
            _values.Add(GetColumnNames());
            for (var i = 0; i < _table.Rows.Count; i++)
            {
                _values.Add(_table.Rows[i].ItemArray);
            }

        }
        private string[] GetColumnNames()
        {
            DataColumnCollection collumns = _table.Columns;
            string[] names = new string[collumns.Count];

            for (var i = 0; i < collumns.Count; i++)
            {
                names[i] = collumns[i].ColumnName;
            }
            return names;
        }

        private string SaveToString()
        {
            int[] buffers = GetArrayMaxSizesFromTable();
            string result = "";

            for (var i = 0; i < _values.Count; i++)
            {
                result += "| ";
                for (var j = 0; j < _values[i].Length; j++)
                {
                    string value = _values[i][j].ToString();
                    result += value.PadRight(buffers[j]) + " | ";
                }
                result += "\n";
            }
            return result;
        }

        // Вернет массив значений максимальной длины значения для каждого столбца - буффер.
        private int[] GetArrayMaxSizesFromTable()
        {
            List<int> buffers = new List<int>();
            string[] names = GetColumnNames();

            for (var i = 0; i < _table.Columns.Count; i++)
            {
                int buffer = 0;
                for (var k = 0; k < _table.Rows.Count; k++)
                {
                    string value = _table.Rows[k].ItemArray[i].ToString();
                    if (names[i].Length > value.Length)
                    {
                        if (buffer < names[i].Length)
                            buffer = names[i].Length;
                    }
                    else if (buffer < value.Length)
                        buffer = value.Length;

                }
                buffers.Add(buffer);
            }
            return buffers.ToArray();
        }
    }
}
