using BookCatalog.Admin.Services.Authors.Models;
using Refit;
using System.Threading.Tasks;

namespace BookCatalog.Admin.Services.Authors
{
    public interface IAuthorsService
    {
        [Get("/DeleteAuthor")]
        Task<bool> DeleteAuthor(string authorId);
    }
}
