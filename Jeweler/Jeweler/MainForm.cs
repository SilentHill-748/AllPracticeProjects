using System;
using System.Windows.Forms;

namespace Jeweler
{
    public partial class MainForm : Form
    {
        string entityName;

        public MainForm()
        {
            InitializeComponent();
            entityName = "";
        }

        private void EntityList_IndexChanged(object sender, EventArgs e)
        {
            if (entityList.SelectedIndex == -1)
                return;

            entityName = entityList.SelectedItem.ToString();
            LoadEntity();
        }

        private void AddProductBut_Click(object sender, EventArgs e)
        {
            AddProductForm addProduct = new AddProductForm();
            addProduct.ShowDialog();
        }

        private void AddOrderBut_Click(object sender, EventArgs e)
        {
            AddOrderForm addOrder = new AddOrderForm();
            addOrder.ShowDialog();
        }

        private void GetReportBut_Click(object sender, EventArgs e)
        {
            ReportForm report = new ReportForm();
            report.ShowDialog();
        }

        private void UpdateBut_Click(object sender, EventArgs e)
        {
            LoadEntity();
        }

        private void LoadEntity()
        {
            string sqlCommand = BuildCommand();
            if (sqlCommand == "")
                return;

            dataGrid.DataSource = DbCommand.Send(sqlCommand);
        }

        private string BuildCommand()
        {
            string sqlCommand = "";
            switch (entityName)
            {
                case "Изделия":
                    sqlCommand = SelectCommands.SelectProducts;
                    break;
                case "Поставщики":
                    sqlCommand = SelectCommands.SelectProviders;
                    break;
                case "Продажи":
                    sqlCommand = SelectCommands.SelectOrders;
                    break;
                case "Компании":
                    sqlCommand = SelectCommands.SelectCompanies;
                    break;
                default:
                    MessageBox.Show("Нет такой таблицы.", "Упс...",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            return sqlCommand;
        }
    }
}
