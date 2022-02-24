namespace Archive.EFCore.Models
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class DocumentConfiguration : IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            builder.Property(d => d.Number)
                .ValueGeneratedNever();

            builder.HasKey(document => document.Number);

            builder.Property(document => document.DocumentTitle)
                .IsRequired();

            builder.Property(document => document.KeyWords)
                .IsRequired();

            builder.Property(document => document.Path)
                .IsRequired();

            builder.Property(document => document.Summary)
                .IsRequired();

            builder.Property(document => document.Text)
                .IsRequired();

            builder.HasMany(document => document.ReferenceDocuments)
                .WithMany(refDoc => refDoc.Documents);
        }
    }
}
