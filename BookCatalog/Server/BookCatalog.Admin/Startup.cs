using BookCatalog.Common.Infrastructure;
using BookCatalog.Statistics.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BookCatalog.Admin
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services) =>
               services
                       .AddServices()
                       .AddApplicationSettings(this.Configuration)
                       .AddTokenAuthentication(this.Configuration)
                       .AddControllers();


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) =>
            app.UseWebService(env);
    }
}
