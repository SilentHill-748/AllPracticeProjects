using System;
using System.Windows.Forms;

namespace TableUI
{
    public partial class OperationsForm : Form
    {
        private Table source;

        public bool Error { get; private set; } = true;
        public Table SelectedTable { get; private set; }
        public Table EditedTable { get; private set; }

        public OperationsForm()
        {
            InitializeComponent();
            EditedTable = new Table();
            SelectedTable = new Table();
        }

        public OperationsForm(Table source) : this()
        {
            this.source = source;
            EditedTable = source;
            FillRemoveList();
        }

        public void SetData(Table source) => this.source = source;

        private void AddRowB_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckAddParams()) 
                    throw new Exception("Одно из полей незаполнено или введено неверно!");

                int pageNum = int.Parse(PageNumTB.Text);
                int stringNum = int.Parse(StringNumTB.Text);

                object[] values = { pageNum, stringNum, TextEditStringTB.Text };
                source.Add(values);
                EditedTable = source;
                Error = false;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void EditRowB_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckNumTB(RowNumForEditTB) & !CheckAddParams())
                    throw new Exception("Одно из полей незаполнено или введено неверно!");

                int pageNum = int.Parse(PageNumTB.Text);
                int stringNum = int.Parse(StringNumTB.Text);

                object[] values = { pageNum, stringNum, TextEditStringTB.Text };
                source.Edit(int.Parse(RowNumForEditTB.Text), values);
                EditedTable = source;
                Error = false;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void RemoveRowB_Click(object sender, EventArgs e)
        {
            try
            {
                if (RowNumForRemoveCB.SelectedIndex == -1) return;

                int index = int.Parse(RowNumForRemoveCB.SelectedItem.ToString());
                source.RemoveAt(index - 1);
                EditedTable = source;
                Error = false;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void SelectRowsB_Click(object sender, EventArgs e)
        {
            try
            {
                if (source.Count == 0) throw new Exception("Таблица пуста!");

                if (CheckEmptySelectValues())
                {
                    MessageBox.Show("Некорректные данные!", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SelectedTable = Select(SelectColumnTB.Text, SelectConditionTB.Text, SelectValueTB.Text);
                Error = false;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void FindValueB_Click(object sender, EventArgs e)
        {
            try
            {
                bool valueIsEmpty = string.IsNullOrWhiteSpace(FindValueTextTB.Text);
                bool columnIsEmpty = string.IsNullOrWhiteSpace(ColumnNameTB.Text);

                if (valueIsEmpty && columnIsEmpty)
                    throw new Exception("Для поиска по значению нужно ввести значение и имя столбца!");

                SelectedTable = source.FindRows(FindValueTextTB.Text, ColumnNameTB.Text);
                Error = false;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void FindMinValueB_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ColumnNameTB.Text))
                    throw new Exception("Для поиска записи с минимальным значением нужно ввести имя столбца!");

                SelectedTable = source.FindMinimum(ColumnNameTB.Text);
                Error = false;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void FindEmptyValueB_Click(object sender, EventArgs e)
        {
            SelectedTable = source.FindEmpty();
            Error = false;
            Close();
        }

        private bool CheckAddParams()
        {
            bool pageNum = CheckNumTB(PageNumTB);
            bool stringNum = CheckNumTB(StringNumTB);

            return pageNum && stringNum;
        }

        private bool CheckNumTB(TextBox tb)
        {
            if (string.IsNullOrWhiteSpace(tb.Text))
                return false;
            if (!int.TryParse(tb.Text, out int res))
                return false;
            return true;
        }

        private void FillRemoveList()
        {
            foreach (object[] row in source)
                RowNumForRemoveCB.Items.Add(row[0]);
        }

        private bool CheckEmptySelectValues()
        {
            bool columnIsEmpty = string.IsNullOrWhiteSpace(SelectColumnTB.Text);
            bool conditionIsEmpty = string.IsNullOrWhiteSpace(SelectConditionTB.Text);
            bool valueIsEmpty = string.IsNullOrWhiteSpace(SelectValueTB.Text);

            return columnIsEmpty & conditionIsEmpty & valueIsEmpty;
        }

        private Table Select(string column, string condition, object value)
        {
            int index = source.IndexOf(column);
            if (index != -1)
            {
                switch (index)
                {
                    case 0: return Selecting(0, condition, Convert.ToInt32(value));
                    case 1: return Selecting(1, condition, Convert.ToInt32(value));
                    case 2: return Selecting(2, condition, Convert.ToInt32(value));
                    case 3: return Selecting(3, condition, Convert.ToString(value));
                    default: return Selecting(4, condition, Convert.ToDateTime(value));
                }
            }
            else
                throw new Exception("Столбец не найден!");
        }

        private Table Selecting(int columnId, string condition, int value)
        {
            switch (condition)
            {
                case ">": return source.Select(row => (int)row[columnId] > value);
                case "<": return source.Select(row => (int)row[columnId] < value);
                case ">=": return source.Select(row => (int)row[columnId] >= value);
                case "<=": return source.Select(row => (int)row[columnId] <= value);
                default: throw new Exception("Неверно задано условие!");
            }
        }

        private Table Selecting(int columnId, string condition, string value)
        {
            if (condition == "=")
                return source.Select(row => row[columnId].Equals(value));
            else
                throw new Exception();
        }

        private Table Selecting(int columnId, string condition, DateTime value)
        {
            switch (condition)
            {
                case ">": return source.Select(row => (DateTime)row[columnId] > value);
                case "<": return source.Select(row => (DateTime)row[columnId] < value);
                case ">=": return source.Select(row => (DateTime)row[columnId] >= value);
                case "<=": return source.Select(row => (DateTime)row[columnId] <= value);
                case "=": return source.Select(row => (DateTime)row[columnId] == value);
                default: throw new Exception("Неверно задано условие!");
            }
        }
    }
}