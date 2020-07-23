using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookCatalog.Authors.Models;
using BookCatalog.Authors.Services.Author;
using BookCatalog.Common.Controllers;
using BookCatalog.Common.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookCatalog.Authors.Controllers
{
    public class AuthorController : ApiController
    {
        private readonly IAuthorService authorService;
        private readonly ICurrentUserService currentUser;
        public AuthorController(IAuthorService authorService, ICurrentUserService currentUser)
        {
            this.authorService = authorService;
            this.currentUser = currentUser;
        }
        public async Task<ActionResult<AuthorOutputModel>> GetAuthor()
        {
            return null;
        }

        public async Task<ActionResult<AuthorOutputModel>> AddAuthor()
        {
            return null;
        }

        public async Task<ActionResult<AuthorOutputModel>> UpdateAuthor()
        {
            return null;
        }

        public async Task<ActionResult<bool>> DeleteAuthor()
        {
            return null;
        }
    }
}
