using BookCatalog.Common.Services;
using System.Collections.Generic;

namespace BookCatalog.Books.Models
{
    public class BookListOutputModel
    {
        public List<BookOutputModel> Books { get; set; }

        public Paging Paging { get; set; }
    }
}
