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

using TPH.Database;
using TPH.Database.Models;

using Microsoft.EntityFrameworkCore;

namespace TPH
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            WriteData();
            //CanChangeDiscriminator();
        }

        // TPH
        private void WriteData()
        {
            using TphContext db = new();

            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            User[] users = new User[]
            {
                new Employee() { Login = "Employee1", Password = "123", Experience = 2, Salary = 15000 },
                new Manager() { Login = "Manager1", Password = "1234", Department = "Development", Experience = 5, Salary = 10000 },
                new User() { Login = "User1", Password = "135" },
                new User() { Login = "User2", Password = "587" },
                new Manager() { Login = "Manager2", Password = "1758", Department = "Managment", Experience = 4, Salary = 15500 }
            };
            db.Users.AddRange(users);
            db.SaveChanges();
        }

        private bool CanChangeDiscriminator()
        {
            // Попробуй изменить дискриминатор у юзера2.
            using TphContext db = new();
            User user2 = db.Users.FirstOrDefault(u => u.Login == "User2");
            user2.Discriminator = "Manager";

            try
            {
                _someTextBlock.Text = "";
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                _someTextBlock.Text = ex.Message + "\n\nFALSE!";
                return false;
            }
            return true;
        }
    }
}
