using System;
using System.Windows.Forms;

namespace AeroportList.Forms
{
    public partial class AddNewReservasionForm : Form
    {
        private string flightId;

        public AddNewReservasionForm()
        {
            InitializeComponent();
            FillFlightIDs();
        }

        private void AddResBut_Click(object sender, EventArgs e)
        {
            try
            {
                if (flightIDs.SelectedIndex == -1)
                    return;

                AddTicket();
                AddPassenger();

                string sql = $"insert into бронирование values (0, {numTicketText.Text}, \'{passNumText.Text}\', \'{flightId}\')";
                DbSender dbSender = new DbSender(sql);
                dbSender.Send();
          
                MessageBox.Show("Бронь успешно добавлена!", "Успех!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetAddedRecord();
                Clean();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так.\n" + ex.Message, "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetAddedRecord()
        {
            string sql = $"select * from бронирование where номер_билета = {numTicketText.Text}";

            DbSender dbSender = new DbSender(sql);
            dbSender.Send();
            resultGrid.DataSource = dbSender.Data.Tables[0];
        }

        private void FlightIDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flightIDs.SelectedIndex == -1)
                return;
            flightId = flightIDs.SelectedItem.ToString();
        }

        private void FillFlightIDs()
        {
            string sql = "select id_рейса from авиарейсы order by id_рейса;";
            DbSender getIDs = new DbSender(sql);
            getIDs.Send();

            var rows = getIDs.Data.Tables[0].Rows;
            for (int i = 0; i < rows.Count; i++)
            {
                flightIDs.Items.Add(rows[i].ItemArray[0]);
            }
        }

        private void AddPassenger()
        {
            string fullName = $"{firstNameText.Text} {midNameText.Text} {lastNameText.Text}";
            string sql = "insert into пассажиры values" +
                $"(\'{passNumText.Text}\', \'{fullName}\', \'{bornDateText.Text}\');";

            DbSender dbSender = new DbSender(sql);
            dbSender.Send();
        }

        private void AddTicket()
        {
            string sql = $"insert into билеты values({numTicketText.Text}, {ticketPlaceText.Text});";

            DbSender dbSender = new DbSender(sql);
            dbSender.Send();
        }

        private void Clean()
        {
            passNumText.Text = string.Empty;
            firstNameText.Text = string.Empty;
            midNameText.Text = string.Empty;
            lastNameText.Text = string.Empty;
            bornDateText.Text = string.Empty;

            numTicketText.Text = string.Empty;
            ticketPlaceText.Text = string.Empty;

            flightIDs.SelectedIndex = -1;
        }
    }
}
