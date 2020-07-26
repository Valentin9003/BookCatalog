using BookCatalog.Books.Data.Models;
using BookCatalog.Data;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BookCatalog.Books.Data
{
    public class BookDbContext: MessageDbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options)
            :base(options)
        {

        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Genre> Genre { get; set; }

        protected override Assembly ConfigurationsAssembly => Assembly.GetExecutingAssembly();
    }
}
