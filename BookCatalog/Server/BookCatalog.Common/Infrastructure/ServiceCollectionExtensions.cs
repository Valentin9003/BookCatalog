using System;
using System.Reflection;
using System.Text;
using AutoMapper;
using BookCatalog.Common.Models;
using BookCatalog.Common.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace BookCatalog.Common.Infrastructure
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
                .AddHealth(configuration)
                .AddApplicationSettings(configuration)
                .AddTokenAuthentication(configuration)
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


        public static IServiceCollection AddApplicationSettings(
            this IServiceCollection services,
            IConfiguration configuration)
            => services
                .Configure<ApplicationSettings>(option =>
                    configuration.GetSection(nameof(ApplicationSettings)).Bind(option));

        public static IServiceCollection AddTokenAuthentication(
           this IServiceCollection services,
           IConfiguration configuration,
           JwtBearerEvents events = null)
        {
            var secret = configuration
                .GetSection(nameof(ApplicationSettings))
                .GetValue<string>(nameof(ApplicationSettings.Secret));

            var key = Encoding.ASCII.GetBytes(secret);

            services
                .AddAuthentication(authentication =>
                {
                    authentication.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    authentication.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(bearer =>
                {
                    bearer.RequireHttpsMetadata = false;
                    bearer.SaveToken = true;
                    bearer.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(key),
                        ValidateIssuer = false,
                        ValidateAudience = false
                    };

                    if (events != null)
                    {
                        bearer.Events = events;
                    }
                });

            services.AddHttpContextAccessor();
            services.AddScoped<ICurrentUserService, CurrentUserService>();

            return services;
        }

        public static IServiceCollection AddAutoMapperProfile(this IServiceCollection services, Assembly assembly)
        => services
            .AddAutoMapper(
                (_, config) => config
                    .AddProfile(new MappingProfile(assembly)),
                Array.Empty<Assembly>());

        public static IServiceCollection AddHealth(
           this IServiceCollection services,
           IConfiguration configuration)
        {
            var healthChecks = services.AddHealthChecks();

            healthChecks
                .AddSqlServer(configuration.GetDefaultConnectionString());

            healthChecks
                .AddRabbitMQ(rabbitConnectionString: "amqp://rabbitmq:rabbitmq@rabbitmq/");

            return services;
        }
    }
}
