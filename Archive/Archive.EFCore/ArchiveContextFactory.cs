using System.IO;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Archive.EFCore
{
    public class ArchiveContextFactory : IDbContextFactory<ArchiveContext>
    {
        public ArchiveContext CreateDbContext()
        {
            string pathToJson = Directory.GetCurrentDirectory() + "\\Data\\DbSettings.json";

            ConfigurationBuilder builder = new();
            builder.AddJsonFile(pathToJson);

            DbContextOptionsBuilder<ArchiveContext> contextBuilder = new();
            contextBuilder
                .UseSqlServer(builder
                    .Build()
                    .GetConnectionString("MSSQL"));

            return new ArchiveContext(contextBuilder.Options);
        }
    }
}
