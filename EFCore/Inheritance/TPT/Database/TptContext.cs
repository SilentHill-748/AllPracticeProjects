using Microsoft.EntityFrameworkCore;

using TPT.Database.Models;

namespace TPT.Database
{
    public class TptContext : DbContext
    {
        public TptContext() : base()
        { }



        public DbSet<User> Users { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Manager> Managers { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=TPT;User=Silent;Password=Silent748;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Manager>().ToTable("Managers");
            modelBuilder.Entity<Employee>().ToTable("Employees");
        }
    }
}
