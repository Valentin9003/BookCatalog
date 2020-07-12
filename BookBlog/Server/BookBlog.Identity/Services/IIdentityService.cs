using BookBlog.Common.Services;
using BookBlog.Identity.Data.Models;
using BookBlog.Identity.Models;
using System.Threading.Tasks;

namespace BookBlog.Identity.Services
{
    public interface IIdentityService
    {
        Task<Result<User>> Register(UserInputModel userInput);

        Task<Result<UserOutputModel>> Login(UserInputModel userInput);

        Task<Result> ChangePassword(string userId, ChangePasswordInputModel changePasswordInput);
    }
}
