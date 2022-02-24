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

using CompileQueries.Database;
using CompileQueries.Database.Models;

using Microsoft.EntityFrameworkCore;

namespace CompileQueries
{
    public partial class MainWindow : Window
    {
        private static Func<UserDbContext, int, User> _getUserById =
            EF.CompileQuery((UserDbContext db, int id) =>
                db.Users
                    .Include(u => u.Company)
                    .FirstOrDefault(u => u.Id == id));

        private static Func<UserDbContext, string, IEnumerable<User>> _getUserByCompanyName =
            EF.CompileQuery((UserDbContext db, string companyName) =>
                db.Users
                    .Include(u => u.Company)
                    .Where(user => EF.Functions.Like(user.Company.Name, companyName)));

        private static Func<UserDbContext, string, IAsyncEnumerable<User>> _getUsersByCompanyNameAsync =
            EF.CompileAsyncQuery((UserDbContext db, string companyName) =>
                db.Users
                    .Include(u => u.Company)
                    .Where(u => u.Company.Name == companyName));


        public MainWindow()
        {
            InitializeComponent();

            AddData();
            //TestAsyncGetUsersByCompanyName();
        }

        private void AddData()
        {
            using UserDbContext db = new();

            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            db.Companies.AddRange(new[] {
                new Company() { Name = "Microsoft" },
                new Company() { Name = "Apple" },
                new Company() { Name = "Yandex" }
            });
            db.SaveChanges();

            db.Users.AddRange(new[] {
                new User() { Name = "Петр", Salary = 25000, CompanyId = 3 },
                new User() { Name = "Михайл", Salary = 85000, CompanyId = 1 },
                new User() { Name = "Вячеслав", Salary = 125000, CompanyId = 1 },
                new User() { Name = "Никита", Salary = 150000, CompanyId = 2 },
                new User() { Name = "Владислав", Salary = 20000, CompanyId = 3 },
                new User() { Name = "Георгий", Salary = 45000, CompanyId = 2 },
                new User() { Name = "Матвей", Salary = 48000, CompanyId = 3 },
                new User() { Name = "Олег", Salary = 95000, CompanyId = 1 }
            });
            db.SaveChanges();
        }

        private void TestFindById()
        {
            using UserDbContext db = new();

            var users = new List<User>()
            {
                _getUserById(db, 1),
                _getUserById(db, 3),
                _getUserById(db, 5),
                _getUserById(db, 7)
            };

            grid.ItemsSource = users;
        }

        private async void TestAsyncGetUsersByCompanyName()
        {
            using UserDbContext db = new();
            string companyName = "Microsoft";

            List<User> users = new List<User>();
            await foreach (User u in _getUsersByCompanyNameAsync(db, companyName))
            {
                users.Add(u);
            }
            grid.ItemsSource = users;
        }

        private void TestFindUsersByCompanyName()
        {
            using UserDbContext db = new();
            string companyName = "Yandex";

            var users = _getUserByCompanyName(db, companyName).ToList();
            grid.ItemsSource = users;
        }

        private void testGetUserByIdBut_Click(object sender, RoutedEventArgs e)
        {
            if (grid.ItemsSource != null)
                grid.ItemsSource = null;
            grid?.Items?.Clear();
            TestFindById();
        }

        private void testGetUsersByCompanyNameBut_Click(object sender, RoutedEventArgs e)
        {
            if (grid.ItemsSource != null)
                grid.ItemsSource = null;
            grid?.Items?.Clear();
            TestFindUsersByCompanyName();
        }

    }
}
