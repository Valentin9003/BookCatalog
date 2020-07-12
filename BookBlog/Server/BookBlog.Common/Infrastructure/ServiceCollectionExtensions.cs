using System;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BookBlog.Common.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddWebService<TDbContext>(
            this IServiceCollection services,
            IConfiguration configuration)
            where TDbContext : DbContext
        {
            services
                .AddDatabase<TDbContext>(configuration)
                .AddApplicationSettings(configuration)
                .AddTokenAuthentication(configuration)
                .AddHealth(configuration)
                .AddAutoMapperProfile(Assembly.GetCallingAssembly())
                .AddControllers();

            return services;
        }

        public static IServiceCollection AddDatabase<TDbContext>(
          this IServiceCollection services,
          IConfiguration configuration)
          where TDbContext : DbContext
          => services
              .AddScoped<DbContext, TDbContext>()
              .AddDbContext<TDbContext>(options => options
                  .UseSqlServer(
                      configuration.GetDefaultConnectionString(),
                      sqlOptions => sqlOptions
                          .EnableRetryOnFailure(
                              maxRetryCount: 10,
                              maxRetryDelay: TimeSpan.FromSeconds(30),
                              errorNumbersToAdd: null)));
    }
}
