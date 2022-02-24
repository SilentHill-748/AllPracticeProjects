using System;
using System.Windows.Forms;

using Tourism.Forms;

namespace Tourism
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.LoadVouchersInfo();
        }

        // Заполняет грид данными из представления.
        public void LoadVouchersInfo()
        {
            string sql = "select * from vouchers_info";
            try
            {
                vouchersInfoGrid.DataSource = SqlExecuter.ExecuteCommand(sql);
            }
            catch (Exception ex)
            {
                Form mess = new ShowMessageForm("Что-то пошло не так...\n" + ex.Message, "Ошибка!");
                mess.ShowDialog();
            }
        }

        private void AddNewRecordBut_Click(object sender, EventArgs e)
        {
            Form addForm = new AddNewTouristForm(this);
            addForm.Show();
        }

        private void ClientInfo_Click(object sender, EventArgs e)
        {
            Form searchVoucherInfo = new SearchVoucherInfoForm();
            searchVoucherInfo.ShowDialog();
        }
    }
}
