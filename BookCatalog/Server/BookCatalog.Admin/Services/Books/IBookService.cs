using BookCatalog.Admin.Services.Books.Models;
using Refit;
using System.Threading.Tasks;

namespace BookCatalog.Admin.Services.Books
{
    public interface IBookService
    {
        [Get("Book/{Id}")]
        Task<BookModel> GetBook(string bookId);

        [Put("EditBook/{id}")]
        Task<BookModel> EditBook(string id,BookModel bookModel);

        [Delete("DeleteBook/{id}")]
        Task<bool> DeleteBook(string bookId);

    }
}
