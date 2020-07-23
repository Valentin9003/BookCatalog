using BookCatalog.Admin.Services.Books.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookCatalog.Admin.Services.Books
{
    public class BookService : IBookService
    {
        public Task<bool> DeleteBook(string bookId)
        {
            throw new NotImplementedException();
        }

        public Task<BookModel> EditBook(string id, BookModel bookModel)
        {
            throw new NotImplementedException();
        }

        public Task<BookModel> GetBook(string bookId)
        {
            throw new NotImplementedException();
        }
    }
}
