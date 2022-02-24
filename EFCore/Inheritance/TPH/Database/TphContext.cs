using Microsoft.EntityFrameworkCore;

using TPH.Database.Models;

namespace TPH.Database
{
    public class TphContext : DbContext
    {
        public TphContext() : base()
        {

        }



        public DbSet<User> Users { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Manager> Managers { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=TPH;User=Silent;Password=Silent748;");
        }
    }
}
