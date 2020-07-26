using BookCatalog.Admin.Services.Authors;
using BookCatalog.Admin.Services.Books.Models;
using BookCatalog.Common.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookCatalog.Admin.Controllers.Authors
{
    public class AuthorsController : ApiController
    {
        private readonly IAuthorsService authorService;
        public AuthorsController(IAuthorsService authorService)
        {
            this.authorService = authorService;
        }

        [HttpDelete("Author/{id}")]
        async Task<ActionResult<bool>> DeleteAuthor(string id)
        {
            return await this.authorService.DeleteAuthor(id);
        }
    }
}
