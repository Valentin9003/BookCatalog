using System.Reflection;
using BookCatalog.Identity.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookCatalog.Identity.Data
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
