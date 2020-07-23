using BookCatalog.Gateway.Models;
using Refit;
using System.Threading.Tasks;
namespace BookCatalog.Gateway.Services
{
    public interface IAuthorService
    {
        [Get("GetAuthor/{id}")]
        Task<AuthorModel> AuthorInformation(string id);
    }
}
