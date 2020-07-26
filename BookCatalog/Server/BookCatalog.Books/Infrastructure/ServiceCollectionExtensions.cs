using BookCatalog.Books.Data;
using BookCatalog.Books.Services;
using BookCatalog.Common.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BookCatalog.Books.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services) =>
                   services.AddTransient<IDataSeeder, BookDbSeeder>()
                           .AddTransient<IBookService, BookService>();
                          
    }
}
