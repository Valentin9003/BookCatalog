using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookCatalog.Books.Data.Models
{
    public class Book
    {
        public string BookId { get; set; }

        public string AuthorId { get; set; }

        public string Title { get; set; }

        public string Summary { get; set; }

        public int NumberOfPages { get; set; }

        public Genre Genre { get; set; }
    }
}
