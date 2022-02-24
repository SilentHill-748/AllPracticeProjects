using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Archive.EFCore.Models
{
    public class ReferenceDocumentConfiguration : IEntityTypeConfiguration<ReferenceDocument>
    {
        public void Configure(EntityTypeBuilder<ReferenceDocument> builder)
        {
            builder.HasKey(refDoc => refDoc.RefNumber);
           
            builder.Property(refDoc => refDoc.RefNumber)
                .ValueGeneratedNever();
            
            builder.Property(refDoc => refDoc.Title)
                .IsRequired();

            builder.Property(refDoc => refDoc.Path)
                .IsRequired();

            builder.HasMany(table => table.Documents)
                .WithMany(document => document.ReferenceDocuments);
        }
    }
}
