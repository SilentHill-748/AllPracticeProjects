using System;
using System.Windows.Forms;

using AeroportList.Forms;

namespace AeroportList
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadAerolines();
        }

        private void LoadAerolines()
        {
            string sql = "select 	рейсы.id_рейса 'ID', компании.Название 'Компания', отпр.Название 'Отправка из', " +
                "приб.Название 'Прибытие в', concat_ws(' ', дата_отправления, время_отправления) 'Дата отправки', " +
                "цена 'Цена' from Авиарейсы рейсы join авиакомпании компании on компании.Индекс = рейсы.Авиакомпания " +
                "left join аэропорты отпр on отпр.Индекс = рейсы.Аэропорт_отправления left join аэропорты приб on приб.Индекс = рейсы.Аэропорт_прибытия;";
           
            DbSender quarySender = new DbSender(sql);
            quarySender.Send();
            aerolinesGrid.DataSource = quarySender.Data.Tables[0];
        }

        private void показатьСписокБронированияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowReservationsForm reservationsInfoForm = new ShowReservationsForm();
            reservationsInfoForm.ShowDialog();
        }

        private void отчетПоБронированиюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.ShowDialog();
        }

        private void добавитьБроньToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewReservasionForm addResFrom = new AddNewReservasionForm();
            addResFrom.ShowDialog();
        }
    }
}
