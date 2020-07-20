using BookCatalog.Identity.Data.Models;
using System.Collections.Generic;

namespace BookCatalog.Identity.Services
{
    public interface ITokenGeneratorService
        {
            string GenerateToken(User user, IEnumerable<string> roles = null);
        }
}
