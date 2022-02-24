using Basics.Database.Model;

using Microsoft.EntityFrameworkCore;

namespace Basics.Database
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base()
        {

        }



        public DbSet<User> Users { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }

        public DbSet<Company> Companies { get; set; }

        public DbSet<Country> Countries { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=LinqEntities;User=Silent;Password=Silent748;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasQueryFilter(u => u.Age >= 24 && u.UserRoleId == 1);
        }
    }
}
