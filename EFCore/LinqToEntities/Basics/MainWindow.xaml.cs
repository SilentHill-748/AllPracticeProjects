using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

using Basics.Database;
using Basics.Database.Model;

using Microsoft.EntityFrameworkCore;

namespace Basics
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitData();

            //UsersByCompany("Apple");
            //LikeToEF();
            //ProjectionAndSort();
            //JoinAndGroupBy();
            //UnionExceptIntersect();
            //AggregateFunctions();
            //AsNoTracking();
            //QuaryExecutionInEF();
            TestQueryFilter();
        }

        private void InitData()
        {
            using ApplicationContext db = new();

            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            db.Countries.AddRange(new[] {
                new Country() { Name = "Russia" },
                new Country() { Name = "USA" }
            });
            db.SaveChanges();

            db.Companies.AddRange(new[] {
                new Company() { Name = "Microsoft", CountryId = 2 },
                new Company() { Name = "Apple", CountryId = 2 },
                new Company() { Name = "Amazon", CountryId = 1 }
            });

            db.UserRoles.AddRange(new[] {
                new UserRole() { Name = "Admin" },
                new UserRole() { Name = "Worker" }
            });

            db.Users.AddRange(new[] {
                new User() { Name = "Никита", Age = 24, CompanyId = 3, UserRoleId = 1 },
                new User() { Name = "Олег", Age = 27, CompanyId = 1, UserRoleId = 2 },
                new User() { Name = "Иван", Age = 21, CompanyId = 2, UserRoleId = 2 },
                new User() { Name = "Матвей", Age = 22, CompanyId = 3, UserRoleId = 2 },
                new User() { Name = "Андрей", Age = 22, CompanyId = 1, UserRoleId = 2 },
                new User() { Name = "Егор", Age = 23, CompanyId = 3, UserRoleId = 1 },
                new User() { Name = "Никита", Age = 24, CompanyId = 2, UserRoleId = 2 },
                new User() { Name = "Петр", Age = 22, CompanyId = 3, UserRoleId = 2 }
            });
            db.SaveChanges();
        }

        private void UsersByCompany(string companyName)
        {
            using ApplicationContext db = new();

            // Выборка данных.
            var users = (from user in db.Users.Include(u => u.Company)
                         where user.Company.Name == companyName
                         select user).ToList();

            //OR
            //var users = db.Users
            //    .Include(u => u.Company)
            //    .Where(u => u.Company.Name == companyName)
            //    .ToList();

            _someGrid.ItemsSource = users;
        }

        // LIKE оператор SQL в EF Core.
        private void LikeToEF()
        {
            using ApplicationContext db = new();

            var users = db.Users.Where(u => u.Company.Name == "Amazon");

            // OR

            var users2 = db.Users.Where(u => EF.Functions.Like(u.Company.Name, "A___on"));
            var users3 = db.Users.Where(u => EF.Functions.Like(u.Age.ToString(), "2[3-9]"));
            var users4 = from user in db.Users
                         where EF.Functions.Like(user.Name, "%[та]")
                         select user;

            // Метод Find
            var result = db.Users.Find(5); // Andre

            // Минутка закрепа.
            //db.Users.SingleOrDefault();               // exception? Yes.
            //db.Users.SingleOrDefault(u => u.Id == 1); // exception? No.
            //db.Users.Last();                          // Exception without OrderBy.
            //db.Users.LastOrDefault(u => u.Name == "Никита"); // exception without OrderBy.

            _someGrid.ItemsSource = users.Concat(users2).Concat(users3).ToList();
        }

        // Проекция и Сортировка
        private void ProjectionAndSort()
        {
            using ApplicationContext db = new();

            // Projection
            var users = (from user in db.Users
                         select new
                         {
                             Name = user.Name,
                             Company = user.Company.Name
                         }).ToList();
            // Вместо анонимного объекта можно юзать конкретный созданный класс.

            var orderedUsers = from user in users
                               orderby user.Name 
                               select user;
            _someGrid.ItemsSource = orderedUsers;
        }

        // Группировка и соединение
        private void JoinAndGroupBy()
        {
            using ApplicationContext db = new();

            var users = (from user in db.Users
                         join company in db.Companies on user.CompanyId equals company.Id
                         join country in db.Countries on company.CountryId equals country.Id
                         select new 
                         { 
                             Name = user.Name, 
                             Company = company.Name,
                             Age = user.Age,
                             Country = country.Name
                         }).ToList();

            var groups = from user in db.Users
                         join company in db.Companies on user.CompanyId equals company.Id
                         join country in db.Countries on company.CountryId equals country.Id
                         group user by user.Company.Name into companyGroup
                         select new { Name = companyGroup.Key, Count = companyGroup.Count() };

            var groups2 = db.Users.Include(u => u.Company)
                .GroupBy(u => u.Company.Name)
                .Select(g => new { Name = g.Key, Count = g.Count() });

            // groups == groups2
            foreach (var group in groups.ToList())
            {
                string text = $"{group.Name}, Users - {group.Count}";
                _someTextBlock.Text += text + "\n";
            }

            _someGrid.ItemsSource = users;
        }

        private void UnionExceptIntersect()
        {
            using ApplicationContext db = new();

            var union = db.Users.Where(u => u.CompanyId == 1)
                .Union(db.Users
                    .Where(u => u.CompanyId == 1));

            var intersect = db.Users.Where(u => u.Age > 23)
                .Intersect(db.Users
                    .Where(u => EF.Functions.Like(u.CompanyId.ToString(), "[2-3]")));

            var except = db.Users.Where(u => u.Age > 23)
                .Except(db.Users
                    .Where(u => EF.Functions.Like(u.CompanyId.ToString(), "[2-3]")));
            _someGrid.ItemsSource = union.Concat(intersect).Concat(except).ToList();
        }

        private void AggregateFunctions()
        {
            using ApplicationContext db = new();

            bool isApple = db.Users.Any(u => u.Company.Name == "Apple");
            if (isApple)
            {
                _someTextBlock.Text += "Есть работники из Apple.\n";
            }

            bool isAllApple = db.Users.All(u => u.Company.Name == "Apple");
            if (!isAllApple)
            {
                _someTextBlock.Text += "Не все работают в Apple.\n";
            }

            _someTextBlock.Text += $"Максимальный возраст: {db.Users.Max(u => u.Age)}" +
                $"\nМинимальный возраст: {db.Users.Min(u => u.Age)}" +
                $"\nСредний возраст: {Math.Truncate(db.Users.Average(u => u.Age))}" +
                $"\nЧисло юзеров: {db.Users.Count()}" +
                $"\nСумма: {db.Users.Sum(u => u.Age)}";
        }

        // Отключение отслеживания в EF Core.
        private void AsNoTracking()
        {
            using ApplicationContext db = new();

            // Ничто не отслеживается в данный момент. Любые изменения в users не будут сохранены в БД.
            var users = db.Users.AsNoTracking().ToList();
            _someTextBlock.Text += $"Отслеживаемых объектов: {db.ChangeTracker.Entries().Count()}";

            users[0].Age = 150;
            db.SaveChanges();

            _someTextBlock.Text += $"\nUser: Age = {db.Users.AsNoTracking().FirstOrDefault().Age}"; // Age = 24

            //------------------------------------------------
            // Можно отключить отслеживание для всего контекста.
            db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTrackingWithIdentityResolution;

            //Test
            User user = db.Users.FirstOrDefault();
            user.Name = "123456798";
            db.SaveChanges();

            _someTextBlock.Text += $"\nUser: Name is {db.Users.First().Name}"; // Никита
            // AsNoTracking не применён, но данные так же не изменились. Это доказывает, что отслеживание не работает.
        }

        // отслеживаемые и неотслеживаемые запросы и как они работают.
        private void QuaryExecutionInEF()
        {
            using ApplicationContext db = new();

            User user1 = db.Users.First();
            User user2 = db.Users.First();

            _someTextBlock.Text += $"user1 [{user1.Name}] AND user2 [{user2.Name}]\n";
            user1.Name = "TESTER";
            _someTextBlock.Text += $"user1 [{user1.Name}] AND user2 [{user2.Name}]\n";

            User user3 = db.Users.First();
            User user4 = db.Users.AsNoTracking().First();

            _someTextBlock.Text += $"user3 [{user3.Name}] AND user4 [{user4.Name}]\n";
            user3.Name = "BLOCKED";
            _someTextBlock.Text += $"user3 [{user3.Name}] AND user4 [{user4.Name}]\n";
        }

        private void TestQueryFilter()
        {
            using ApplicationContext db = new();

            var users = db.Users
                .Include(u => u.UserRole)
                .Include(u => u.Company)
                    .ThenInclude(c => c.Country)
                .Select(u => new 
                {
                    u.Id,
                    u.Name,
                    u.Age,
                    Company = u.Company.Name,
                    Country = u.Company.Country.Name,
                    Role = u.UserRole.Name
                })
                .ToList();

            var ignoredQuaryFilterUsers = db.Users
                .Include(u => u.UserRole)
                .Include(u => u.Company)
                    .ThenInclude(c => c.Country)
                .IgnoreQueryFilters()
                .Select(u => new
                {
                    u.Id,
                    u.Name,
                    u.Age,
                    Company = u.Company.Name,
                    Country = u.Company.Country.Name,
                    Role = u.UserRole.Name
                })
                .ToList();
            _someGrid.ItemsSource = users.Concat(ignoredQuaryFilterUsers); // 1 user [Name = Никита] + all users
        }
    }
}
