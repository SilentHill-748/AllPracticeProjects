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

using Microsoft.EntityFrameworkCore;

using TPT.Database;
using TPT.Database.Models;

namespace TPT
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            WriteData();
            Update(GetUser());
        }

        private void WriteData()
        {
            using TptContext db = new();

            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            User[] users = new User[]
            {
                new Employee() { Name = "Employee1", Experience = 2, Salary = 15000 },
                new Manager() { Name = "Manager1", Department = "Development", Experience = 5, Salary = 10000 },
                new User() { Name = "User1" },
                new User() { Name = "User2" },
                new Manager() { Name = "Manager2", Department = "Managment", Experience = 4, Salary = 15500 }
            };
            db.Users.AddRange(users);
            db.SaveChanges();
        }


        //Тест метода Update().
        private User GetUser()
        {
            using TptContext db = new();

            return db.Users.FirstOrDefault();
        }

        private void Update(User user)
        {
            using TptContext db = new();

            user.Name = "TEST";
            db.Users.Update(user);
            db.SaveChanges();
        }
    }
}
