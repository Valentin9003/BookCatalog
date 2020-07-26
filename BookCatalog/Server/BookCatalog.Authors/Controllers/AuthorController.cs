using System.Threading.Tasks;
using BookCatalog.Authors.Models;
using BookCatalog.Authors.Services.Authors;
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
        [HttpGet]
        [Route("GetAuthor/{id}")]
        public async Task<ActionResult<AuthorOutputModel>> GetAuthor(string id)
        {
            var author = await authorService.GetAuthor(id);

            if (author == null)
            {
                return NotFound();
            }

            return author;
        }

        public async Task<ActionResult<AuthorOutputModel>> AddAuthor(AuthorInputModel author)
        {
            var isSuccessed = await this.authorService.AddAuthor(author);

            if (!isSuccessed)
            {
                return BadRequest();
            }

            return Ok();
        }

        public async Task<ActionResult<AuthorOutputModel>> UpdateAuthor(AuthorInputModel author)
        {
            var isSuccessed = await this.authorService.UpdateAuthor(author);

            if (!isSuccessed)
            {
                return NotFound();
            }

            return Ok();
        }

        public async Task<ActionResult<bool>> DeleteAuthor(string authorId)
        {
            var isSuccessed = await this.authorService.DeleteAuthor(authorId);

            if (!isSuccessed)
            {
                return NotFound();
            }

            return Ok();
        }
    }
}
