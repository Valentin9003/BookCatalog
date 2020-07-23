using BookCatalog.Books.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BookCatalog.Books.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services) =>
                   services.AddTransient<IBookService, BookService>();
    }
}
