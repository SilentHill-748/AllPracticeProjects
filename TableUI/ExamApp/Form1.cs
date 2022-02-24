using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace ExamApp
{
    public partial class Form1 : Form
    {
        private Table table;
        private Table selectTable;

        public Form1()
        {
            InitializeComponent();

            table = new Table();
            selectTable = new Table();
            InitDataGrid();
            OutputTable(table);
        }

        // Создал таблицу на форме.
        private void InitDataGrid()
        {
            string[] columns = { "Номер", "Имя", "Фамилия", "Отчество", "Дата рождения", "Адрес" };

            for (int i = 0; i < columns.Length; i++)
            {
                UserTable.Columns.Add(columns[i], columns[i]);
                switch (columns[i])
                {
                    case "Номер": UserTable.Columns[i].Width = 50; break;
                    case "Имя": UserTable.Columns[i].Width = 100; break;
                    case "Фамилия": UserTable.Columns[i].Width = 100; break;
                    case "Отчество": UserTable.Columns[i].Width = 110; break;
                    case "Дата рождения": UserTable.Columns[i].Width = 110; break;
                    case "Адрес": UserTable.Columns[i].Width = 155; break;
                }
                
            }
            SetDataGridDefaultProperties();
        }

        private void SetDataGridDefaultProperties()
        {
            UserTable.ReadOnly = true;
            UserTable.AllowUserToAddRows = false;
            UserTable.AllowUserToDeleteRows = false;
            UserTable.AllowUserToResizeColumns = false;
            UserTable.AllowUserToResizeRows = false;
            UserTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            UserTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
        }

        // Выводит текст справки.
        private void HelpButton_Click(object sender, EventArgs e)
        {
            try
            {
                string text = File.ReadAllText("Справка.txt");
                MessageBox.Show(text, "Справка");
            }
            catch
            {
                MessageBox.Show("Файл справки не найден.");
            }
        }

        // Вставка записей в таблицу.
        private void InsertButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddTextBox.Text)) return;
            
            try
            {
                string[] data = AddTextBox.Text.Split(',').Select(str => str.Trim()).ToArray();
                AddTextBox.Text = "";

                table.InsertRecord(data);
                UserTable.Rows.Add();
                OutputTable(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        // Удаление записи по индексу (ключу)
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RowNumTextBox.Text)) return;

            try
            {
                string num = RowNumTextBox.Text;
                RowNumTextBox.Text = "";

                if (int.TryParse(num, out int rowIndex))
                {
                    int index = SetRowIndex(rowIndex);
                    if (index == -1)
                        throw new Exception("Такой строки нет!");

                    table.DeleteRecord(index);
                    var row = UserTable.Rows[index];
                    UserTable.Rows.Remove(row);
                    OutputTable(table);
                }
                else
                    throw new Exception("Введён некорректный номер строки!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        // Удаление всех записей.
        private void DeleteAllButton_Click(object sender, EventArgs e)
        {
            table.Clear();
            selectTable.Clear();
            UserTable.Rows.Clear();
        }

        // Изменение строки по её индексу.
        private void EditButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EditRowNumTextBox.Text)) return;
            if (string.IsNullOrWhiteSpace(EditValuesTextBox.Text)) return;

            try
            {
                string num = EditRowNumTextBox.Text;
                string value = EditValuesTextBox.Text;
                EditRowNumTextBox.Text = "";
                EditValuesTextBox.Text = "";

                if (int.TryParse(num, out int rowIndex))
                {
                    int index = SetRowIndex(rowIndex);
                    if (index == -1)
                        throw new Exception("Такой строки нет!");

                    string[] data = EditValuesTextBox.Text.Split(',').Select(v => v.Trim()).ToArray();
                    table.EditRecord(index, data);
                    OutputTable(table);
                }
                else
                    throw new Exception("Введён некорректный номер строки!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        // Все найденные строки будут сохранены в xml-файл.
        private void SearchMinimumButton_Click(object sender, EventArgs e)
        {
            try
            {
                string column = SearchColumnsNameComboBox?.SelectedItem?.ToString();
                if (column == "") return;

                SearchColumnsNameComboBox.SelectedIndex = -1;
                int index = SetIndexColumn(column);
                selectTable = table.SearchMin(index);
                SerializeSelectedTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        // Все найденные строки будут сохранены в xml-файл.
        private void SearchButton_Click(object sender, EventArgs e)
        {
            string value = SearchValueTextBox.Text;
            string column = SearchColumnsNameComboBox?.SelectedItem?.ToString();
            SearchColumnsNameComboBox.SelectedIndex = -1;
            SearchValueTextBox.Text = "";

            if (string.IsNullOrWhiteSpace(value))
            {
                selectTable = table.SearchEmpty();
                SerializeSelectedTable();
            }
            else
            {
                try
                {
                    if (!string.IsNullOrWhiteSpace(column))
                    {
                        int index = SetIndexColumn(column);
                        selectTable = table.Search(value, index);
                        SerializeSelectedTable();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        // Сортировка таблицы.
        private void SortButton_Click(object sender, EventArgs e)
        {
            string column = ColumnsComboBox?.SelectedItem?.ToString();
            ColumnsComboBox.SelectedIndex = -1;
            if (string.IsNullOrWhiteSpace(column)) return;

            int index = SetIndexColumn(column);
            table.Sort(index);
            OutputTable(table);
        }

        // Выборка объектов из таблицы
        private void SelectButton_Click(object sender, EventArgs e)
        {
            string column = SelectColumnNames?.SelectedItem?.ToString();
            string condition = SelectCondition?.SelectedItem?.ToString();
            string value = SelectValueTextBox.Text;

            SelectColumnNames.SelectedIndex = -1;
            SelectCondition.SelectedIndex = -1;
            SelectValueTextBox.Text = "";

            if (column is null && condition is null) return;
            if (string.IsNullOrWhiteSpace(value)) return;

            int index = SetIndexColumn(column);
            selectTable = table.Select(index, condition, value);
            SerializeSelectedTable();
        }

        // Вывод таблицы на форму
        private void OutputTable(Table table)
        {
            for (int i = 0; i < UserTable.Rows.Count; i++)
                for (int j = 0; j < UserTable.Columns.Count; j++)
                {
                    UserTable[j, i].Value = table.Rows[i][j];
                }
        }

        // Сериализация отобранных/найденных строк
        private void SerializeSelectedTable()
        {
            using (SaveFileDialog openfile = new SaveFileDialog())
            {
                openfile.Filter = "Xml file | *.xml";
                if (openfile.ShowDialog() == DialogResult.OK)
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Table));
                    using (var stream = new FileStream(openfile.FileName, FileMode.OpenOrCreate))
                        xmlSerializer.Serialize(stream, selectTable);
                }
            }
        }

        // Вывод индекса столбца по названию.
        private int SetIndexColumn(string columnHeader)
        {
            int index = -1;
            for (int i = 0; i < UserTable.Columns.Count; i++)   // Поиск индекса столбца.
                if (UserTable.Columns[i].HeaderText == columnHeader)
                    index = i;
            return index;
        }

        // Проверка номера строки.
        private int SetRowIndex(int rowIndex)
        {
            int index = -1;
            for (int i = 0; i < UserTable.RowCount; i++)
                if (rowIndex == int.Parse(table.Rows[i][0].ToString()))
                    index = i;
            return index;
        }
    }
}