using BookCatalog.Authors.Data;
using BookCatalog.Authors.Data.Models;
using BookCatalog.Authors.Models;
using BookCatalog.Authors.Services.Authors;
using BookCatalog.Common.Services;
using BookCatalog.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace BookCatalog.Authors
{
    public class AuthorService : DataService<Author>, IAuthorService
    {
        private readonly AuthorDbContext db;
        private readonly ICurrentUserService userService;
        public AuthorService(AuthorDbContext db, ICurrentUserService userService)
            : base(db)
        {
            this.db = db;
            this.userService = userService;
        }
        public async Task<bool> AddAuthor(AuthorInputModel author)
        {
            await this.db.AddAsync(new Author
            {
                FirstName = author.FirstName,
                LastName = author.LastName,
                Biography = author.Biography,
                UserId = userService.UserId,
                AuthorId = Guid.NewGuid().ToString()
            });

            await this.db.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteAuthor(string authorId)
        {
            var author = await this.db
                .Author
                .Where(a => a.AuthorId == authorId)
                .FirstOrDefaultAsync();

            if (author == null)
            {
                return false;
            }

            this.db.Author.Remove(author);
            await this.db.SaveChangesAsync();

            return true;

        }

        public async Task<AuthorOutputModel> GetAuthor(string authorId)
        {
            return await this.db
               .Author
               .Where(a => a.AuthorId == authorId)
               .Select(a => new AuthorOutputModel
               {
                   FirstName = a.FirstName,
                   LastName = a.LastName,
                   Biography = a.Biography

               })
               .FirstOrDefaultAsync();
        }

        public async Task<bool> UpdateAuthor(AuthorInputModel author)
        {
            var authorEntity = await this.db
                .Author
                .Where(a => a.AuthorId == author.Id)
                .FirstOrDefaultAsync();

            if (authorEntity == null)
            {
                return false;
            }
            authorEntity.Biography = author.Biography;
            authorEntity.FirstName = author.FirstName;
            authorEntity.LastName = authorEntity.LastName;

            this.db.Author.Update(authorEntity);
            await this.db.SaveChangesAsync();

            return true;
        }
    }
}
