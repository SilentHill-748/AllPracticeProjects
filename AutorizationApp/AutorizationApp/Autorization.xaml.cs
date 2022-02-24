using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

using AutorizationApp.Data;
using AutorizationApp.Reader;

namespace AutorizationApp
{
    public partial class Autorization : Window
    {
        private Registration regWindow;

        public Autorization()
        {
            InitializeComponent();
            HelpL.MouseEnter += Label_MouseEnter;
            HelpL.MouseLeave += Label_MouseLeave;
            LoginL.MouseEnter += Label_MouseEnter;
            LoginL.MouseLeave += Label_MouseLeave;
            RegistrationL.MouseEnter += Label_MouseEnter;
            RegistrationL.MouseLeave += Label_MouseLeave;
        }

        private void Label_MouseEnter(object sender, EventArgs e)
        {
            Label lable = sender as Label;
            lable.Foreground = new SolidColorBrush(Color.FromRgb(93, 96, 223));
        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            Label lable = sender as Label;
            lable.Foreground = Brushes.Black;
        }

        private void LoginL_MouseDown(object sender, MouseButtonEventArgs e)
        {
            GetAllData();

            if (CheckData())
            {
                Start();
                Clean();
            }
            else
                MessageBox.Show("Wrong login or password!", "Attention!", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void HelpL_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string message = "If you forgot your password, please tell about it your system administrator!";
            MessageBox.Show(message, "Attention!", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void RegistrationL_MouseDown(object sender, MouseButtonEventArgs e)
        {
            regWindow = new Registration();
            regWindow.Show();
            this.Close();
        }

        private void Start()
        {
            string quary = $"SELECT name FROM users WHERE login = \"{LoginTB.Text}\" AND password = \"{PasswordPB.Password}\"";

            try
            {
                var request = new MySqlRequest();
                request.Send(quary);

                string name = Regex.Match(request.XmlRepresentation, "<name>(.*?)</name>").Groups[1].Value;
                WelcomL.Content = $"Welcom , {name} <3";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Attention!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Из БД вытаскивает пару логин/пароль всех пользователей.
        private void GetAllData()
        {
            var request = Request("SELECT * FROM users");

            string pattern = "<login>(.*?)</login>(.*?)<password>(.*?)</password>";
            var matches = Regex.Matches(request.XmlRepresentation, pattern, RegexOptions.Singleline);
            ToFile(matches);
        }

        // Записывает все пары логин/пароль в текстовый файл.
        private void ToFile(MatchCollection matches)
        {
            using (var writer = new StreamWriter("Data.txt"))
                foreach (Match data in matches)
                    writer.WriteLine(data.Groups[1].Value + "," + data.Groups[3].Value);
        }

        /// <summary>
        /// Выполняет запрос в MySql Server.
        /// </summary>
        /// <returns> Объект MySqlRequest с записанным Xml-представлением таблиц. </returns>
        private MySqlRequest Request(string quary)
        {
            var request = new MySqlRequest();
            request.Send(quary);
            return request;
        }

        // Проверяет вводимые значения логина и пароля со значениями из БД.
        private bool CheckData()
        {
            string userInputData = LoginTB.Text + PasswordPB.Password;
            try
            {
                using (var reader = new StreamReader("Data.txt"))
                    return string.Join(null, reader.ReadToEnd().Split(',')).Contains(userInputData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Attention!", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
        }

        private void Clean()
        {
            LoginTB.Text = "";
            PasswordPB.Password = "";
        }
    }
}
