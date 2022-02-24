using System.Collections.Generic;
using System.Data;
using System.IO;

namespace Shop.DbModel
{
    public class SaveTable
    {
        private DataTable _table;
        private string _path;
        private readonly List<object[]> _values;

        public SaveTable()
        {
            this._table = new DataTable();
            this._values = new List<object[]>();
            this._path = $@"Reports";
        }

        public void Save(DataTable table)
        {
            this._table = table;

            LoadReportData();
            string path = BuildPath();

            File.WriteAllText(path, SaveToString());
        }

        private string BuildPath()
        {
            if (!Directory.Exists(_path))
                Directory.CreateDirectory(_path);
            return Path.Combine(_path, $@"{_table.TableName}.txt");
        }

        private void LoadReportData()
        {
            _values.Clear();
            _values.Add(GetColumnNames());
            for (var i = 0; i < _table.Rows.Count; i++)
                _values.Add(_table.Rows[i].ItemArray);
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
