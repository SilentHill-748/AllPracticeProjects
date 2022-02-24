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

using Basics.Database;
using Basics.Database.Models;

using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Basics
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //InitData();

            //SqlFromRaw();
            //StoredFunctions();
            StoredProcedures();
        }

        private void InitData()
        {
            using AppDbContext db = new();

            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            db.Companies.AddRange(new[]
            {
                new Company() { Name = "Apple" },
                new Company() { Name = "Microsoft" },
                new Company() { Name = "Amazon" }
            });
            db.SaveChanges();

            db.Users.AddRange(new[] {
                new User() { Name = "Никита", Age = 23, CompanyId = 2 },
                new User() { Name = "Иван", Age = 31, CompanyId = 1 },
                new User() { Name = "Олег", Age = 18, CompanyId = 1 },
                new User() { Name = "Петр", Age = 15, CompanyId = 2 },
                new User() { Name = "Матвей", Age = 25, CompanyId = 2 },
                new User() { Name = "Игорь", Age = 21, CompanyId = 2 },
                new User() { Name = "Илья", Age = 27, CompanyId = 3 },
                new User() { Name = "Слава", Age = 45, CompanyId = 1 },
                new User() { Name = "Валерий", Age = 38, CompanyId = 3 }
            });

            db.SaveChanges();
        }

        private void SqlFromRaw()
        {
            using AppDbContext db = new();

            SqlParameter age = new("@age", 18);
            db.Database.ExecuteSqlRaw("Update users set age = {0} where name = 'Петр'", age.Value);
            db.Database.ExecuteSqlInterpolated($"Update users set age = {age} where name = 'Петр'");
            var users = db.Users.FromSqlRaw("select * from users left join companies c on c.id = users.companyId")
                .ToList();

           // db.Users.FromSqlInterpolated($"...");
            _someGrid.ItemsSource = users;
        }

        private void StoredProcedures()
        {
            using AppDbContext db = new();

            db.Database.ExecuteSqlInterpolated($"AddUser 'Аслан', {22}, {3}");
            var users = db.Users
                .Include(u => u.Company)
                .ToList();
            SqlParameter count = new()
            {
                ParameterName = "@count",
                SqlDbType = System.Data.SqlDbType.Int,
                Direction = System.Data.ParameterDirection.Output,
                Size = 50
            };
            db.Database.ExecuteSqlRaw("GetCountOfUsers3 @count OUT", count);

            _someTextBlock.Text = $"Count of users is {count.Value}";
            _someGrid.ItemsSource = users;
        }

        private void StoredFunctions()
        {
            using AppDbContext db = new();
            var test = db.GetAllUsers();
            _someGrid.ItemsSource = test;
        }
    }
}
