using BookCatalog.Statistics.Services.Statistic;
using Microsoft.Extensions.DependencyInjection;

namespace BookCatalog.Statistics.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services) =>
                   services.AddTransient<IStatisticService, StatisticService>();
    }
}
