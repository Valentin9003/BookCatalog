using AutoMapper;
using BookCatalog.Common.Services;
using BookCatalog.Gateway.Models;
using System.Collections.Generic;

namespace BookCatalog.Books.Data.Models
{
    public class BibliographyOutputModel
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<BookModel> Books { get; set; }

        public Paging Paging { get; set; }

        public void ConfigureMapping(Profile mapper)
        {
          
        }
    }
}
