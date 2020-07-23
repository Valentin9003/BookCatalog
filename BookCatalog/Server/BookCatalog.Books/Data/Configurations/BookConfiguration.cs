using BookCatalog.Books.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookCatalog.Books.Data.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(k => k.BookId);

            builder.Property(p => p.AuthorId)
                .IsRequired();

            builder.Property(p => p.Title)
                .IsRequired();

            builder.Property(p => p.Title)
                .IsRequired();

            builder.Property(p => p.NumberOfPages)
                .IsRequired();
        }
    }
}
