using BookCatalog.Authors.Data.Models;
using BookCatalog.Authors.Models;
using BookCatalog.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookCatalog.Authors.Services.Authors
{
    public interface IAuthorService : IDataService<Author>
    {
        Task<AuthorOutputModel> GetAuthor(string id);

        Task<bool> AddAuthor(AuthorInputModel author);

        Task<bool> UpdateAuthor(AuthorInputModel author);

        Task<bool> DeleteAuthor(string authorId);
    }
}
