using Microsoft.EntityFrameworkCore;

using Parallelism.Database.Models;

namespace Parallelism.Database
{
    public class UserContext : DbContext
    {
        public UserContext() : base()
        {

        }



        public DbSet<User> Users { get; set; }

        public DbSet<UserProfile> Profiles { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "Server=localhost;Database=UserDb;User=Silent;Password=Silent748;",
                new MySqlServerVersion(new System.Version(8,0,21)));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Установка оптимистичного параллелизма для поля "Age".
            modelBuilder.Entity<User>()
                .Property(u => u.Age)
                .IsConcurrencyToken();

            modelBuilder.Entity<User>()
                .Property(u => u.Test)
                .IsRowVersion();

            // Установка пессиместичного параллелизма для поля "DateOfEnrollment".
            modelBuilder.Entity<UserProfile>()
                .Property(up => up.DateOfEnrollment)
                .IsRowVersion();
        }
    }
}
