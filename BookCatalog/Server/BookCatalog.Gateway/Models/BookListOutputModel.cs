using BookCatalog.Common.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookCatalog.Gateway.Models
{
    public class BookListOutputModel
    {
     
        public List<BookModel> Books { get;set; }
        public Paging Paging { get; set; }
    }
}
