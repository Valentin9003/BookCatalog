using BookCatalog.Admin.Services.Authors;
using Microsoft.Extensions.DependencyInjection;

namespace BookCatalog.Statistics.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services) =>
                   services.AddTransient<IAuthorsService, AuthorsService>();
    }
}
