using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookCatalog.Common.Controllers;
using BookCatalog.Gateway.Models;
using BookCatalog.Gateway.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace BookCatalog.Gateway.Controllers
{
    public class AuthorsController : ApiController
    {
        private readonly IAuthorService authorService;

        private readonly IBookService bookService;

        private readonly IMapper mapper;

        public AuthorsController(IBookService bookService, IAuthorService authorService, IMapper mapper)
        {
            this.bookService = bookService;
            this.authorService = authorService;
            this.mapper = mapper;
        }
        public async Task<ActionResult<BibliographyOutputModel>> Bibliography(string authorId, int page)
        {
            var books = this.mapper
                .Map<BookListOutputModel>(await this.bookService.Books(authorId, page));

            var author = this.mapper
                .Map<AuthorModel>(await this.authorService.AuthorInformation(authorId));

            return new BibliographyOutputModel
            {
                Author = author,
                Books = books
            };
        }
    }
}
