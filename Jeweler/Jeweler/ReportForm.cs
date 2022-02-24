using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Jeweler   
{
    public partial class ReportForm : Form
    {
        private DataTable report;
        private List<object[]> values;

        public ReportForm()
        {
            InitializeComponent();
            Init();
        }

        private void OkBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBut_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFile = new SaveFileDialog())
            {
                saveFile.Filter = "Text files *.txt | *.txt";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFile.FileName, SaveToString());
                }
            }
        }

        private void Init()
        {
            values = new List<object[]>();
            LoadReportData();
            dataGridView1.DataSource = report;
        }

        private void LoadReportData()
        {
            report = DbCommand.Send(SelectCommands.SelectReport);
            values.Add(GetColumnNames());

            for (var i = 0; i < report.Rows.Count; i++)
            {
                values.Add(report.Rows[i].ItemArray);
            }

        }

        private string[] GetColumnNames()
        {
            DataColumnCollection collumns = report.Columns;
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
            
            for (var i = 0; i < report.Rows.Count; i++)
            {
                result += "| ";
                for (var j = 0; j < report.Columns.Count; j++)
                {
                    string value = values[i][j].ToString();
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

            for (var i = 0; i < report.Columns.Count; i++)
            {
                int buffer = 0;
                for (var k = 0; k < report.Rows.Count; k++)
                {
                    string value = report.Rows[k].ItemArray[i].ToString();
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
