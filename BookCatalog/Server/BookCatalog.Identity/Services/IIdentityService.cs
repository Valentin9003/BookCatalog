using BookCatalog.Common.Services;
using BookCatalog.Identity.Data.Models;
using BookCatalog.Identity.Models;
using System.Threading.Tasks;

namespace BookCatalog.Identity.Services
{
    public interface IIdentityService
    {
        Task<Result<User>> Register(UserInputModel userInput);

        Task<Result<UserOutputModel>> Login(UserInputModel userInput);

        Task<Result> ChangePassword(string userId, ChangePasswordInputModel changePasswordInput);
    }
}
