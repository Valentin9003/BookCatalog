using BookCatalog.Admin.Services.Books;
using BookCatalog.Admin.Services.Books.Models;
using BookCatalog.Common.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BookCatalog.Admin.Controllers.Books
{
    public class BooksController : ApiController
    {
        private readonly IBookService bookService;
        public BooksController(IBookService bookService)
        {
            this.bookService = bookService;
        }

        [HttpDelete("DeleteBook/{id}")]
        async Task<ActionResult<bool>> DeleteBook(string id)
        {
            return await this.bookService.DeleteBook(id);
        }

        [HttpPut("EditBook/{id}")]
        async Task<ActionResult<BookModel>> EditBook(string id, BookModel bookModel)
        {
            return await this.bookService.EditBook(id, bookModel);
        }
    }
}
