using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookCatalog.Books.Data;
using BookCatalog.Common.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace BookCatalog.Books
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services) =>
            services.AddWebService<BookDbContext>(this.Configuration);


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) =>
            app.UseWebService(env)
               .Initialize(); 
    }
}
