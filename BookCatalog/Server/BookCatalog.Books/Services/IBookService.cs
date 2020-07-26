using BookCatalog.Books.Data.Models;
using BookCatalog.Books.Models;
using BookCatalog.Books.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookCatalog.Books.Services
{
    public interface IBookService : IDataService<Book>
    {
        Task<BookOutputModel> GetBook(string id);

        Task<bool> EditBook(string id, BookInputModel inputModel);

        Task<bool> DeleteBook(string id);

        Task<bool> AddBook(BookInputModel inputModel);

        Task<BookListOutputModel> AllBooks(int page);

        Task<BookListOutputModel> AllBooksByAuthor(string authorId, int page);
    }
}
