using CompileQueries.Database.Models;

using Microsoft.EntityFrameworkCore;

namespace CompileQueries.Database
{
    public class UserDbContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }

        public DbSet<User> Users { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=UserDb;User=Silent;password=Silent748;");
        }
    }
}
