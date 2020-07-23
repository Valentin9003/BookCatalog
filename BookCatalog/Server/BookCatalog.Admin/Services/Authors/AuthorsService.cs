using BookCatalog.Admin.Services.Authors.Models;
using System;
using System.Threading.Tasks;

namespace BookCatalog.Admin.Services.Authors
{
    public class AuthorsService : IAuthorsService
    {
        public Task<bool> DeleteAuthor(string authorId)
        {
            throw new NotImplementedException();
        }
    }
}
