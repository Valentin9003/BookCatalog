using BookCatalog.Authors;
using BookCatalog.Authors.Services.Authors;
using BookCatalog.Common.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BookCatalog.Statistics.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services) =>
                   services.AddTransient<IAuthorService, AuthorService>();
    }
}
