using BookCatalog.Authors.Data.Models;
using BookCatalog.Common.Services;
using System.Collections.Generic;
using System.Linq;

namespace BookCatalog.Authors.Data
{
    public class AuthorDbSeeder : IDataSeeder
    {
        private static readonly List<Author> authors = new List<Author>()
        {
        };

        private readonly AuthorDbContext db;

        public AuthorDbSeeder(AuthorDbContext db)
        {
            this.db = db;
        }
       

        public void SeedData()
        {
            if (db.Author.Any())
            {
                return;
            }

            foreach (var author in authors)
            {
                db.Author.Add(author);
            }

            db.SaveChanges();
        }
    }
}
