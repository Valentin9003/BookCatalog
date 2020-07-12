using System.Reflection;
using BookBlog.Identity.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace BookBlog.Identity.Data
{
        public class IdentityDbContext : IdentityDbContext<User>
        {
            public IdentityDbContext(DbContextOptions<IdentityDbContext> options)
                : base(options)
            {
            }

            protected override void OnModelCreating(ModelBuilder builder)
            {
                builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

                base.OnModelCreating(builder);
            }
        }
    }
