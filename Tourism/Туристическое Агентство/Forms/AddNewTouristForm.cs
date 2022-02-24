using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

using Tourism.Entities;

namespace Tourism.Forms
{
    public partial class AddNewTouristForm : Form
    {
        private readonly MainForm _main;

        private readonly string _getTicketId = "select count(0) from ticket;";
        private readonly string _getVoucherId = "select count(0) from voucher;";

        public AddNewTouristForm(Form owner)
        {
            this.InitializeComponent();
            this.LoadHotels();
            this._main = (MainForm)owner;
        }

        // Добавление новой путёвки.
        private void AddVoucher_Click(object sender, EventArgs e)
        {
            try
            {
                ExecuteEntity("Voucher");
                ExecuteEntity("Ticket");
                ExecuteEntity("Client");

                ShowTicket();
                _main.LoadVouchersInfo();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageShow("Что-то пошло не так...\n" + ex.Message, "Ошибка!");
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Регистрирует новый отель.
        private void AddHotel_Click(object sender, EventArgs e)
        {
            Hotels hotel = new Hotels()
            {
                Id = 0,
                Name = this.hotelName.Text,
                Price = Convert.ToDecimal(this.hotelPrice.Text)
            };
            SqlExecuter.ExecuteEntity(hotel);
            this.LoadHotels();
            this.CleanHotelsBlock();
        }

        // Отображает/скрывает блок регистрации отеля.
        private void AddHotelCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.addHotelCheckbox.Checked)
            {
                this.addHotelBlock.Visible = true;
            }
            else
            {
                this.addHotelBlock.Visible = false;
            }
        }

        // Отображает информацию по добавленному билету.
        private void ShowTicket()
        {
            string sql = $"select * from vouchers_info where Телефон = {phone.Text};";
            DataTable table = SqlExecuter.ExecuteCommand(sql);

            Dictionary<string, object> ticketInfo = new Dictionary<string, object>();
            for (var i = 0; i < table.Columns.Count; i++)
            {
                string column = table.Columns[i].ColumnName + ":";
                ticketInfo.Add(column.PadRight(18), table.Rows[0].ItemArray[i]);
            }

            string ticket = "";
            foreach (KeyValuePair<string, object> pair in ticketInfo)
            {
                if (pair.Value is DateTime)
                    ticket += pair.Key + $"{pair.Value:dd:MM:yyyy}" + "\n";
                else
                    ticket += pair.Key + pair.Value + "\n";
            }

            SaveTicket(ticket);
            MessageShow(ticket, "Билет добавлен!");
        }

        // Загружает имеющиеся отели в список из БД.
        private void LoadHotels()
        {
            hotels.Items.Clear();
            string sql = "SELECT name FROM hotels;";
            DataTable table = SqlExecuter.ExecuteCommand(sql);
            for (var i = 0; i < table.Rows.Count; i++)
                hotels.Items.Add(table.Rows[i].ItemArray[0]);
            hotels.SelectedIndex = -1;
        }

        // Очистка всех полей в блоке регистрации отеля.
        private void CleanHotelsBlock()
        {
            this.hotelName.Clear();
            this.hotelPrice.Clear();
            this.addHotelBlock.Visible = false;
            addHotelCheckbox.Checked = false;
        }

        // Отправляет в БД указанную сущность.
        private void ExecuteEntity(string entityname)
        {
            if (hotels.SelectedIndex == -1) 
                throw new Exception("Укажите отель!");

            string getHotelId = $"select id from hotels where name = \'{hotels.SelectedItem}\'";
            object ticketId = SqlExecuter.ExecuteScalarCommand(_getTicketId);
            object voucherId = SqlExecuter.ExecuteScalarCommand(_getVoucherId);
            object hotelId = SqlExecuter.ExecuteScalarCommand(getHotelId);

            switch (entityname)
            {
                case "Client":
                    Client client = new Client()
                    {
                        Id = 0,
                        Data = purchaseDate.Value,
                        FullName = fullName.Text,
                        Phone = Convert.ToDecimal(phone.Text),
                        TicketId = int.Parse($"{ticketId}")
                    };
                    SqlExecuter.ExecuteEntity(client);
                    break;
                case "Ticket":
                    Ticket ticket = new Ticket()
                    {
                        Id = 0,
                        InitialRoute = initialRoute.Text,
                        FinalRoute = finalRoute.Text,
                        VoucherId = int.Parse($"{voucherId}")
                    };
                    SqlExecuter.ExecuteEntity(ticket);
                    break;
                case "Voucher":
                    Voucher voucher = new Voucher()
                    {
                        Id = 0,
                        Data = beginDate.Value,
                        HotelsId = int.Parse($"{hotelId}")
                    };
                    SqlExecuter.ExecuteEntity(voucher);
                    break;
                default: throw new Exception("Такой сущности не существует!");
            }
        }

        // Сохраняет билет в текстовый файл.
        private void SaveTicket(string ticketInfo)
        {
            using (StreamWriter writer = new StreamWriter("ticket.txt"))
            {
                writer.WriteLine(ticketInfo);
                writer.Flush();
            }
        }

        // Отображает информацию для пользователя.
        private void MessageShow(string text, string caption)
        {
            Form mess = new ShowMessageForm(text, caption);
            mess.ShowDialog();
        }
    }
}
