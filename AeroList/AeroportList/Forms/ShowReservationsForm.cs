using System.Windows.Forms;

namespace AeroportList.Forms
{
    public partial class ShowReservationsForm : Form
    {
        public ShowReservationsForm()
        {
            InitializeComponent();
            LoadAllReservations();
        }

        public void LoadAllReservations()
        {
            string sql = "select Номер_брони 'Бронь', бил.Номер_билета 'Билет', бил.Посадочное_место 'Место', " +
                "пас.ФИО 'Полное имя', пас.Номер_паспорта 'Паспорт', id_рейса 'Рейс' from бронирование брон " +
                "join билеты бил on бил.Номер_билета = брон.Номер_билета " +
                "join пассажиры пас on пас.Номер_паспорта = брон.Номер_паспорта;";

            DbSender sender = new DbSender(sql);
            sender.Send();
            reservationsGrid.DataSource = sender.Data.Tables[0];
        }
    }
}
