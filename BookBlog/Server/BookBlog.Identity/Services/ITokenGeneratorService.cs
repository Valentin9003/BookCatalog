using BookBlog.Identity.Data.Models;
using System.Collections.Generic;

namespace BookBlog.Identity.Services
{
    public interface ITokenGeneratorService
        {
            string GenerateToken(User user, IEnumerable<string> roles = null);
        }
}
