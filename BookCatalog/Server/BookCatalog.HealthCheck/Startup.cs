using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace BookCatalog.HealthCheck
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services) => services
                .AddHealthChecksUI()
                .AddInMemoryStorage();

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) =>
            app
               .UseRouting()
               .UseEndpoints(endpoints => endpoints
                    .MapHealthChecksUI());
    }
}
