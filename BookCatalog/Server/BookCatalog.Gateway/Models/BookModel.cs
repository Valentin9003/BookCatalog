using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookCatalog.Gateway.Models
{
    public class BookModel
    {
        public string Title { get; set; }

        public string Summary { get; set; }

        public int NumberOfPages { get; set; }

        public string Genre { get; set; }
    }
}
