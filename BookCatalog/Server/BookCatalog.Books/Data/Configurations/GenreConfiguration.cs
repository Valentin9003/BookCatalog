using BookCatalog.Books.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookCatalog.Books.Data.Configurations
{
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasKey(pk => pk.GenreId);

            builder.Property(p => p.BookGenre)
                .IsRequired();

            builder.HasOne(b => b.Book)
                .WithOne(g => g.Genre)
                .HasForeignKey<Book>(fk => fk.BookId)
                .IsRequired();
        }
    }
}
