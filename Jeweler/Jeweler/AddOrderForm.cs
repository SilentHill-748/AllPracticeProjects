using System;
using System.Windows.Forms;

namespace Jeweler
{
    public partial class AddOrderForm : Form
    {
        private string date;

        public AddOrderForm()
        {
            InitializeComponent();
        }

        private void AddBut_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlCommand = BuildCommand();
                DbCommand.Send(sqlCommand);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Введите корректные данные!\nПодробности: {ex.Message}",
                    "Упс...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string BuildCommand()
        {
            string values = string.Join(", ", SetValuesFromForm());
            return $"INSERT INTO Продажи Values ({values});";
        }

        private object[] SetValuesFromForm()
        {
            int idOrder = Convert.ToInt32(idOrderText.Text);
            int idProduct = Convert.ToInt32(idProductText.Text);
            decimal price = Convert.ToInt32(priceText.Text);
            int discount = Convert.ToInt32(discountText.Text);
            decimal priceWithDiscount = Math.Round(price * (discount / 100M), 0);

            return new object[] { idOrder, idProduct, date, price, discount, priceWithDiscount };
        }

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            DateTime orderDate = dateTimePicker1.Value;
            date = $"\'{orderDate:yy.MM.dd}\'";
        }
    }
}
