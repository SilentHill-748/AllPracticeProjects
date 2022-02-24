using System;
using System.Data;
using System.Windows.Forms;

namespace Tourism.Forms
{
    public partial class SearchVoucherInfoForm : Form
    {
        public SearchVoucherInfoForm()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fullname.Text) ||
                string.IsNullOrEmpty(fullname.Text))
            {
                ShowMessage("Не указано полное имя!", "Ошибка!");
                return;
            }    

            string sql = $"CALL get_client(\'{fullname.Text}\')";
            DataTable result = SqlExecuter.ExecuteCommand(sql);
            if (result.Rows.Count == 0)
            {
                ShowMessage("Ничего не найдено!", "Внимание!");
                return;
            }

            Form getInfo = new GetInfoForm(result);
            this.Close();
            getInfo.ShowDialog();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox_EnterUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Ok_Click(null, null);
        }

        private void ShowMessage(string text, string caption)
        {
            Form mess = new ShowMessageForm(text, caption);
            mess.ShowDialog();
        }
    }
}
