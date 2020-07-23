using BookCatalog.Authors;
using BookCatalog.Authors.Services.Author;
using Microsoft.Extensions.DependencyInjection;

namespace BookCatalog.Statistics.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services) =>
                   services.AddTransient<IAuthorService, AuthorService>();
    }
}
