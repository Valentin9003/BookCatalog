using AutoMapper;
using BookCatalog.Books.Models;
using BookCatalog.Books.Services;
using BookCatalog.Books.Services.Models;
using BookCatalog.Common.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BookCatalog.Books.Controllers
{
    public class BookController: ApiController
    {

        public readonly IBookService bookService;
        public readonly IMapper mapper;
        public BookController(IBookService bookService, IMapper mapper)
        {
            this.bookService = bookService;
            this.mapper = mapper;
        }

        [HttpGet]
        [Route("GetBook/{id}")]
        public async Task<ActionResult<BookOutputModel>> GetBook(string id)
        {
            var book = await this.bookService.GetBook(id);

            if (book == null)
            {
                return NotFound();
            }
            return book;
        }

        [HttpDelete]
        [Route("DeleteBook/{id}")]
        public async Task<ActionResult<BookOutputModel>> DeleteBook(string id)
        {
            var isSuccessed = await this.bookService.DeleteBook(id);

            if (!isSuccessed)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpPut]
        [Route("EditBook/{id}")]
        public async Task<ActionResult<BookOutputModel>> EditBook(string id, BookInputModel model)
        {
            var isSuccessed = await this.bookService.EditBook(id, model);

            if (!isSuccessed)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpPut]
        [Route("AddBook")]
        public async Task<ActionResult<BookOutputModel>> AddBook(BookInputModel model)
        {
            var isSuccessed = await this.bookService.AddBook(model);

            if (!isSuccessed)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpGet]
        [Route("AllBook")]
        public async Task<ActionResult<BookListOutputModel>> AllBook(int page)
        {
            var books = await this.bookService.AllBooks(page);

            if (books == null)
            {
                return NotFound();
            }

            return books;
        }

        [HttpGet]
        [Route("AllBookByAuthor/{id}/{page}")]
        public async Task<ActionResult<BookListOutputModel>> AllBookByAuthor(string id, int page)
        {
            var books = await this.bookService.AllBooksByAuthor(id, page);

            if (books == null)
            {
                return NotFound();
            }

            return books;
        }
    }
}
