using System;
using System.Windows.Forms;

namespace Jeweler
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void CancelBut_Click(object sender, EventArgs e)
        {
            this.Close();
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
                MessageBox.Show($"Введите корректные данные! Подробности: {ex.Message}", "Упс...",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private object[] SetValuesFromForm()
        {
            int idProduct = Convert.ToInt32(idProdText.Text);
            int idProvider = Convert.ToInt32(idProviderText.Text);
            int type = Convert.ToInt32(typeText.Text);
            int count = Convert.ToInt32(countText.Text);
            decimal price = Convert.ToInt32(priceText.Text);
            decimal buyPrice = Convert.ToInt32(buyPriceText.Text);

            return new object[]
            {
                idProduct, idProvider, "\'" + nameText.Text + "\'", type, 
                count, Math.Round(price, 0), Math.Round(buyPrice, 0)
            };
        }

        private string BuildCommand()
        {
            string values = string.Join(", ", SetValuesFromForm());
            string sqlCommand = $"INSERT INTO Изделия VALUES ({values});";
            return sqlCommand;
        }
    }
}
