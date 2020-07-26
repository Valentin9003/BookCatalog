using AutoMapper;
using BookCatalog.Books.Data;
using BookCatalog.Books.Data.Models;
using BookCatalog.Books.Models;
using BookCatalog.Books.Services.Models;
using BookCatalog.Common.Services;
using BookCatalog.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using static BookCatalog.Books.BookConstants;

namespace BookCatalog.Books.Services
{
    public class BookService : DataService<Book>, IBookService
    {
        private readonly BookDbContext db;
        public BookService(BookDbContext db)
            : base(db)
        {
            this.db = db;
        }
        public async Task<bool> AddBook(BookInputModel inputModel)
        {
            var bookId = Guid.NewGuid().ToString();

            var book = new Book
            {
                BookId = bookId,
                AuthorId = inputModel.AuthorId,
                NumberOfPages = inputModel.NumberOfPages,
                Summary = inputModel.Summary,
                Title = inputModel.Title,

                Genre = new Genre
                {
                    GenreId = Guid.NewGuid().ToString(),
                    BookId = bookId,
                    BookGenre = inputModel.Genre
                }
            };

            await this.db.Books.AddAsync(book);
            await this.db.SaveChangesAsync();

            return true;
        }

        public async Task<BookListOutputModel> AllBooks(int page)
        {
            var skip = (BookPagingCount * page) - 1;

            var books = await this.db.Books
               .Include(g => g.Genre)
               .Select(b => new BookOutputModel
               {
                   AuthorId = b.AuthorId,
                   BookId = b.BookId,
                   Genre = b.Genre.BookGenre,
                   Summary = b.Summary,
                   Title = b.Title,
                   NumberOfPages = b.NumberOfPages
               })
                .Skip(skip)
                .Take(BookPagingCount)
                .ToListAsync();

            var totalItems = await this.db.
                Books.
                CountAsync();

            var totalPages = totalItems % BookPagingCount == 0 ? totalItems / BookPagingCount : (totalItems / BookPagingCount + 1);

            var paging = new Paging
            {
                CurrentPage = page,
                TotalPages = totalPages,
                HaveNextPage = (page != totalPages)
            };

            return new BookListOutputModel
            {
                Books = books,
                Paging = paging
            };
        }

        public async Task<BookListOutputModel> AllBooksByAuthor(string authorId, int page)
        {
            var skip = (BookPagingCount * page) - 1;

            var books = await this.db.Books
               .Include(g => g.Genre)
               .Where(a => a.AuthorId == authorId)
               .Select(b => new BookOutputModel
               {
                   AuthorId = b.AuthorId,
                   BookId = b.BookId,
                   Genre = b.Genre.BookGenre,
                   Summary = b.Summary,
                   Title = b.Title,
                   NumberOfPages = b.NumberOfPages
               })
                .Skip(skip)
                .Take(BookPagingCount)
                .ToListAsync();

            var totalItems = await this.db.
                Books.
                CountAsync();

            var totalPages = totalItems % BookPagingCount == 0 ? totalItems / BookPagingCount : (totalItems / BookPagingCount + 1);

            var paging = new Paging
            {
                CurrentPage = page,
                TotalPages = totalPages,
                HaveNextPage = (page != totalPages)
            };

            return new BookListOutputModel
            {
                Books = books,
                Paging = paging
            };
        }

        public async Task<bool> DeleteBook(string id)
        {
            var book = await this.db
                .Books.Where(b => b.BookId == id)
                .FirstOrDefaultAsync();

            if (book == null)
            {
                return false;
            }

            this.db.Books.Remove(book);

            return true;
        }

        public async Task<bool> EditBook(string id, BookInputModel inputModel)
        {
            var book = await this.db
                 .Books
                 .Where(b => b.BookId == id)
                 .FirstOrDefaultAsync();

            if (book == null)
            {
                return false;
            }

            book.Genre.BookGenre = inputModel.Genre;
            book.Summary = inputModel.Summary;
            book.Title = inputModel.Title;
            book.NumberOfPages = inputModel.NumberOfPages;

            await this.db.SaveChangesAsync();

            return true;
        }

        public async Task<BookOutputModel> GetBook(string id)
        {
            var book = await db.Books
                .Include(g => g.Genre)
                .Where(b => b.BookId == id)
                .FirstOrDefaultAsync();

            if (book == null)
            {
                return null;
            }

            var result = new BookOutputModel
            {
                BookId = book.BookId,
                AuthorId = book.AuthorId,
                Genre = book.Genre.BookGenre,
                NumberOfPages = book.NumberOfPages,
                Summary = book.Summary,
                Title = book.Title
            };

            return result;
        }
    }
}
