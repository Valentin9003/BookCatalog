using BookCatalog.Authors.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookCatalog.Authors.Data.Configurations
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {

        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(k => k.AuthorId);

            builder.HasMany(b => b.Books)
                .WithOne(a => a.Author)
                .HasForeignKey(b => b.BookId);

            builder.Property(p => p.FirstName)
                .IsRequired();

            builder.Property(p => p.LastName)
                .IsRequired();

            builder.Property(p => p.Biography)
                .IsRequired();

            builder.Property(p => p.UserId)
                .IsRequired();
        }
    }
}

