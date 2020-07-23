using BookCatalog.Authors.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace BookCatalog.Authors.Data
{
    public class AuthorDbContext: DbContext
    {
        public AuthorDbContext(DbContextOptions<AuthorDbContext> options)
            :base(options)
        {

        }

        public DbSet<Author> Author { get; set; }

        public DbSet<Book> Book { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}
