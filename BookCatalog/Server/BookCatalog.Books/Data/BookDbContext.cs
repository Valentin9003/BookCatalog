using BookCatalog.Books.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BookCatalog.Books.Data
{
    public class BookDbContext: DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options)
            :base(options)
        {

        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Genre> Genre { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}
