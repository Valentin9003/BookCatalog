

using BookBlog.Common.Infrastructure;
using BookBlog.Common.Services;
using BookBlog.Identity.Data;
using BookBlog.Identity.Infrastructure;
using BookBlog.Identity.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BookBlog.Identity
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => this.Configuration = configuration;

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
            => services
                .AddWebService<IdentityDbContext>(this.Configuration)
                .AddUserStorage()
                .AddTransient<IDataSeeder, IdentityDataSeeder>()
                .AddTransient<IIdentityService, IdentityService>()
                .AddTransient<ITokenGeneratorService, TokenGeneratorService>();

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
            => app
                .UseWebService(env)
                .Initialize();
    }
}
