using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookCatalog.Books.Services.Models
{
    public class BookInputModel
    {
        public string BookId { get; set; }

        public string AuthorId { get; set; }

        public string Title { get; set; }

        public string Summary { get; set; }

        public int NumberOfPages { get; set; }

        public string Genre { get; set; }
    }
}
