using BookCatalog.Authors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookCatalog.Authors.Services.Author
{
    public interface IAuthorService
    {
        Task<AuthorOutputModel> GetAuthor(string id);

        Task<bool> AddAuthor(AuthorInputModel author);

        Task<bool> UpdateAuthor(AuthorInputModel author);

        Task<bool> DeleteAuthor(string authorId);
    }
}
