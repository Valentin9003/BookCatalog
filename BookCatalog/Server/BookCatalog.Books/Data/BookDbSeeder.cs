using BookCatalog.Books.Data.Models;
using BookCatalog.Common.Services;
using System.Collections.Generic;
using System.Linq;

namespace BookCatalog.Books.Data
{
    public class BookDbSeeder : IDataSeeder
    {
        private static List<Book> Data = new List<Book>()
        {
        new Book
        {
            BookId = "b1",
            Title = "Title1",
            Genre = new Genre
            {
                BookId = "1",
                BookGenre = "Fiction",
                GenreId = "g1"
            },
            NumberOfPages = 100,
            AuthorId = "a1",
            Summary = "Summary1"
        }
        };
        private readonly BookDbContext db;

        public BookDbSeeder(BookDbContext db) => this.db = db;

        public void SeedData()
        {
            if (db.Books.Any())
            {
                return;
            }

            foreach (var book in Data)
            {
                db.Books.Add(book);
            }

            this.db.SaveChanges();
        }
    }
}
