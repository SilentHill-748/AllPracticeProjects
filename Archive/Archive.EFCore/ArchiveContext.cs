using Microsoft.EntityFrameworkCore;

using Archive.EFCore.Models;

namespace Archive.EFCore
{
    public class ArchiveContext : DbContext
    {
        public ArchiveContext(DbContextOptions<ArchiveContext> options)
            : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }


        public DbSet<Document> Documents { get;set; }

        public DbSet<ReferenceDocument> ReferenceDocuments {  get;set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Get current assembly (Archive.EFCore) and load all configurations for all models.
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ArchiveContext).Assembly);
        }
    }
}