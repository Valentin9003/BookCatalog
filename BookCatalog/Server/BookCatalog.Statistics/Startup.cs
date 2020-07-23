using BookCatalog.Common.Infrastructure;
using BookCatalog.Statistics.Data;
using BookCatalog.Statistics.Infrastructure;
using BookCatalog.Statistics.Services.Statistic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BookCatalog.Statistics
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services) =>
            services.AddWebService<StatisticsDbContext>(this.Configuration)
                    .AddServices();

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) =>
            app.UseWebService(env)
               .Initialize();
    }
}
