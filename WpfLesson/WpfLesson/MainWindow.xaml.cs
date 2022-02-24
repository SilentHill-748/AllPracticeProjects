using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfLesson
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int counter = 1;

        private DateTime time;
        private DateTime date;

        char[] sex = new char[] { 'М', 'Ж' };

        string[] choiceInQuestion = new string[] { "Да", "Нет", "Затрудняюсь ответить" };
        string[] age = new string[] { "До 18", "19-30", "31-45", "46-60", "Старше 60" };
        string[] sources = new string[]
        {"Семья/друзья", "СМИ/Интернет","Книги","Медиа","Случайно узнал","Из опроса" };

        public MainWindow()
        {
            InitializeComponent();
        }

        // TODO: Написать метод генерации времени.
        // TODO: Написать метод генерации выбора.
        // TODO: Написать метод генерации возраста.
        // TODO: Написать метод генерации источника.
        // TODO: Написать метод составления SQL-запроса.
        // TODO: Написать метод проверки запроса на корректный ввод.
        // TODO: Написать логику отправки 10 запросов с разницей отправки в 1 секунду.
    }
}
