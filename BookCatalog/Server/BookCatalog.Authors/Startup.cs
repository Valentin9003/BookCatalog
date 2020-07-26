using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookCatalog.Authors.Data;
using BookCatalog.Common.Infrastructure;
using BookCatalog.Statistics.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace BookBlog.Authors
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services) =>
            services.AddWebService<AuthorDbContext>(this.Configuration)
            .AddDomainServices()
            .AddMessaging(this.Configuration);

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) =>
            app.UseWebService(env)
               .Initialize();
    }
}
