using System.Linq;
using System.Windows;

using Microsoft.EntityFrameworkCore;

namespace MySqlProvider
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
            using LocalDbContext db = new();

            _label.Content = "Connection is Done!";

            db.AddRange(new[] {
                new User() { Name = "Никита", Age = 23 }
            });

            db.SaveChanges();
        }

        private void OutputUsers()
        {
            using LocalDbContext db = new();
            grid.ItemsSource = db.Users.ToList();
        }
    }

    public class MySqlContext : DbContext
    {
        public DbSet<User> Users { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "Server=localhost;Database=LocalDb;User=Silent;Password=Silent748;", 
                ServerVersion.Parse("8, 0, 21"));
        }
    }

    public class User2
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}
