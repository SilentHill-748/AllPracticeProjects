using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;

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

namespace Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            InitData();
            CreateView();
            TestView();
        }

        private void CreateView()
        {
            string sql = @"CREATE VIEW View_UsersInfo AS
                                SELECT [U].FirstName AS 'UserName', 
                                       [P].ModelName AS 'Phone',
                                       [P].Price AS 'PhonePrice',
                                       [C].Name AS 'Company'
                                FROM Users AS U
                                    LEFT JOIN Phones AS P ON [P].Id = [U].PhoneId
                                    LEFT JOIN Companies AS C ON [C].Id = [U].CompanyId";
            using ViewContext db = new();
            db.Database.ExecuteSqlRaw(sql);
        }

        private void InitData()
        {
            using ViewContext db = new();

            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            List<Company> companies = new()
            {
                new Company() { Name = "Microsoft" },
                new Company() { Name = "Apple" },
                new Company() { Name = "Yandex" }
            };

            List<Phone> phones = new()
            {
                new Phone() { ModelName = "iPhone 7", Price = 25000 },
                new Phone() { ModelName = "Nokia Lumia", Price = 12000 },
                new Phone() { ModelName = "Samsung Galaxy S9", Price = 32000 },
                new Phone() { ModelName = "iPhone 9", Price = 55000 },
                new Phone() { ModelName = "iPhone 10", Price = 74000 }
            };

            List<User> users = new()
            {
                new User() { FirstName = "Никита", PhoneId = 1, CompanyId = 1 },
                new User() { FirstName = "Олег", PhoneId = 2, CompanyId = 2 },
                new User() { FirstName = "Петр", PhoneId = 3, CompanyId = 2 },
                new User() { FirstName = "Алиса", PhoneId = 4, CompanyId = 3 },
                new User() { FirstName = "Зинаида", PhoneId = 5, CompanyId = 3 }
            };

            db.Companies.AddRange(companies);
            db.Phones.AddRange(phones);
            db.Users.AddRange(users);
            db.SaveChanges();
        }

        private void TestView()
        {
            using ViewContext db = new();

            db.Users.Add(new User() { FirstName = "TEST", PhoneId = 2, CompanyId = 1 });
            db.SaveChanges();

            List<UsersView> users = db.UsersView.ToList();
            users.First().Company = "TEST";
            db.SaveChanges();
            viewGrid.ItemsSource = users;
        }
    }



    public class ViewContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Phone> Phones { get; set; }

        public DbSet<Company> Companies { get; set; }

        public DbSet<UsersView> UsersView { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=ViewDb;User=Silent;Password=Silent748;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsersView>()
                .HasNoKey()
                .ToView("View_UsersInfo");
        }
    }

    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public int CompanyId { get; set; }

        public Company Company { get; set; }

        public int PhoneId { get; set; }

        public Phone Phone { get; set; }
    }

    public class Phone
    {
        public int Id { get; set; }

        public string ModelName { get; set; }

        public decimal Price { get; set; }
    }

    public class Company
    {
        public Company()
        {
            Users = new List<User>();
        }



        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<User> Users { get; set; }
    }

    public class UsersView
    {
        public string UserName { get; set; }

        public string Phone { get; set; }

        public decimal PhonePrice { get; set; }

        public string Company { get; set; }
    }
}