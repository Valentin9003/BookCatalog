using BookCatalog.Gateway.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookCatalog.Gateway.Services
{
   public interface IBookService
    {
        [HttpGet("AllBookByAuthor/{id}/{page}")]
        Task<BookModel> Books(string id, int page);
    }
}
