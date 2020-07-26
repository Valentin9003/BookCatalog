using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookCatalog.Gateway.Models
{
    public class BibliographyOutputModel
    {
        public BookListOutputModel Books { get; set; }

        public AuthorModel Author { get; set; }
    }
}
