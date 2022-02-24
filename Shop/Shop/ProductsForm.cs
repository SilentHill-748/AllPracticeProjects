using System;
using System.Data;
using System.Windows.Forms;

using Shop.DbModel;
using Shop.Forms;

namespace Shop
{
    public partial class ProductsForm : Form
    {
        private readonly string delivScript = "SELECT №_сделки, Дата, поставщики.Название 'Поставщик', " +
            "товар.Наименование 'Товар', товар.Вид 'Вид товара', товар.Категория 'Категория товара', " +
            "количество_поставленного_товара 'Количество', (товар.Цена * количество_поставленного_товара) 'На сумму' " +
            "FROM Поставки JOIN поставщики ON поставщики.Код_поставщика = поставки.Код_поставщика " +
            "JOIN товар ON товар.код_товара = поставки.код_товара;";

        private readonly string salesScript = "SELECT №_сделки, Дата, пользователь.ФИО 'Покупатель', " +
            "товар.Наименование 'Товар', количество_проданного_товара 'Количество', " +
            "(товар.Цена * количество_проданного_товара) 'На сумму' FROM Продажи " +
            "JOIN пользователь ON пользователь.Код_пользователя = продажи.покупатель " +
            "JOIN товар ON товар.Код_товара = продажи.Код_товара;";

        public ProductsForm()
        {
            InitializeComponent();
            ShowProducts();
        }

        private void показатьОтчетПоПродажамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable salesTable = SqlCommand.Execute(salesScript);
            SalesInfoForm salesForm = new SalesInfoForm(salesTable);
            salesForm.ShowDialog();
        }

        private void показатьОтчётПоПоставкамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable deliveries = SqlCommand.Execute(delivScript);
            DeliveriesInfoForm delivInfoForm = new DeliveriesInfoForm(deliveries);
            delivInfoForm.ShowDialog();
        }

        private void сохранитьОтчетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveTable saveTable = new SaveTable();
            saveTable.Save(LoadNewTable(delivScript, "Поставки"));
            saveTable.Save(LoadNewTable(salesScript, "Продажи"));
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowProducts();
        }

        private void ShowProducts()
        {
            string script = "SELECT * FROM Товар;";
            productsGrid.DataSource = SqlCommand.Execute(script);
        }

        private DataTable LoadNewTable(string sqlScript, string name)
        {
            DataTable table = SqlCommand.Execute(sqlScript);
            table.TableName = name;
            return table;
        }
    }
}
