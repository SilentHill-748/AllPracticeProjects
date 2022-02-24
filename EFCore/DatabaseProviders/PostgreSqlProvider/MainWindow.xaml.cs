using Microsoft.EntityFrameworkCore;

using System.Linq;
using System.Windows;

namespace PostgreSqlProvider
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            AddUsers();
            OutputUsers();
        }

        private void AddUsers()
        {
            using PostgreSqlContext db = new();

            db.Users.AddRange(new[] {
                new User2() { Name = "Алиса", Age = 18 },
                new User2() { Name = "Антон", Age = 25 },
                new User2() { Name = "Георгий", Age = 37 }
            });
            db.SaveChanges();
        }

        private void OutputUsers()
        {
            using PostgreSqlContext db = new();

            if (db.Users.ToList().Count > 0)
                _label.Content = "PostgreSQL connection is done!";
            else
                _label.Content = "PostgreSQL connection is failed!";

            grid.ItemsSource = db.Users.ToList();
        }
    }

    public class PostgreSqlContext : DbContext
    {
        public DbSet<User2> Users { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=UserDB;Username=postgres;Password=Silent748;");
        }
    }

    public class User2
    {
        public int UserId { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}
