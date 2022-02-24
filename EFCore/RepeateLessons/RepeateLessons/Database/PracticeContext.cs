using System.IO;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using RepeateLessons.Database.Entities;

namespace RepeateLessons.Database
{
    public class PracticeContext : DbContext
    {
        public PracticeContext() : base()
        {
            _ = Database.EnsureDeleted();
            _ = Database.EnsureCreated();
        }



        public DbSet<User> Users { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            _ = optionsBuilder.UseSqlServer(GetConnectionString());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            UserConfiguration userConfig = new();
            _ = modelBuilder.ApplyConfiguration(userConfig);
            //_ = modelBuilder.Entity<User>(UserConfiguration);
        }

        //private static void UserConfiguration(EntityTypeBuilder<User> builder) { }

        private static string GetConnectionString()
        {
            byte[] appSettingsJsonFile = Properties.Resources.appsettings;
            using FileStream jsonConfigFile = new("appsettings.json", FileMode.OpenOrCreate);
            jsonConfigFile.Write(appSettingsJsonFile, 0, appSettingsJsonFile.Length);
            jsonConfigFile.Close();

            ConfigurationBuilder configBuilder = new();
            return configBuilder
                .AddJsonFile(@"appsettings.json")
                .Build()
                .GetConnectionString("MSSQL");
        }
    }
}
