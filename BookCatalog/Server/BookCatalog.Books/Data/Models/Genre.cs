using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookCatalog.Books.Data.Models
{
    public class Genre
    {
        public string GenreId { get; set; }

        public string BookGenre { get; set; }

        public string BookId { get; set; }

        public Book Book { get; set; }
    }
}
