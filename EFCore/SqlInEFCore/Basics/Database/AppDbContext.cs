using Basics.Database.Models;

using Microsoft.EntityFrameworkCore;

using System.Linq;

namespace Basics.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base()
        {

        }



        public DbSet<Company> Companies { get; set; }

        public DbSet<User> Users { get; set; }



        public IQueryable<User> GetAllUsers() =>
            FromExpression(() => GetAllUsers());

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=SqlEFCore;User=Silent;Password=Silent748;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Company>().ToTable("Companies");
            modelBuilder.HasDbFunction(() => GetAllUsers());
        }
    }
}
