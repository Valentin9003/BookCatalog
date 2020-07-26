using BookCatalog.Authors.Data.Models;
using BookCatalog.Data;
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
    public class AuthorDbContext: MessageDbContext
    {
        public AuthorDbContext(DbContextOptions<AuthorDbContext> options)
            :base(options)
        {

        }

        public DbSet<Author> Author { get; set; }

        public DbSet<Book> Book { get; set; }

        protected override Assembly ConfigurationsAssembly => Assembly.GetExecutingAssembly();
    }
}
