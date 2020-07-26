using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookCatalog.Admin.Services.Books.Models
{
    public class BookModel
    {

        public string BookId { get; set; }

        public string AuthorId { get; set; }

        public string Title { get; set; }

        public string Summary { get; set; }

        public int NumberOfPages { get; set; }

        public GenreModel Genre { get; set; }
    }
}
