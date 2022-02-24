using System;
using System.Windows;

using AutorizationApp.Reader;

namespace AutorizationApp.Data
{
    public partial class Registration : Window
    {
        private Autorization autoWinsow;

        public Registration()
        {
            InitializeComponent();
        }

        private void RegistrationB_Click(object sender, RoutedEventArgs e)
        {
            string message = "You have not completed all the fields!";
            if (!CheckInput())
            {
                MessageBox.Show(message, "Attention", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (ConfirmPassword())
            {
                SendToDb();
                Return();
            }
        }

        private void ReturnB_Click(object sender, RoutedEventArgs e)
        {
            Return();
        }

        private void Return()
        {
            autoWinsow = new Autorization();
            autoWinsow.Show();
            this.Close();
        }

        // Проверка корректного ввода пароля.
        private bool ConfirmPassword()
        {
            if (PasswordPB.Password != ConfirmPassPB.Password)
            {
                MessageBox.Show("Password and confirm password not is match!", "Attention!", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }

        // Отправка данных в MySQL Server.
        private void SendToDb()
        {
            string quary = "INSERT INTO users (name, secondName, lastName, login, password)" +
                           $"VALUES (\"{NameTB.Text}\", \"{SecondNameTB.Text}\", \"{LastNameTB.Text}\", \"{LoginTB.Text}\", \"{PasswordPB.Password}\")";

            try
            {
                var request = new MySqlRequest();
                request.SendAsync(quary);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Attention", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private bool CheckInput()
        {
            if (NameTB.Text == "")            return false;
            if (SecondNameTB.Text == "")      return false;
            if (LastNameTB.Text == "")        return false;
            if (LoginTB.Text == "")           return false;
            if (PasswordPB.Password == "")    return false;
            if (ConfirmPassPB.Password == "") return false;

            return true;
        }
    }
}
