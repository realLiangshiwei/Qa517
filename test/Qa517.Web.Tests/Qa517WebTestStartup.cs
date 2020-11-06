using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace Qa517
{
    public class Qa517WebTestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<Qa517WebTestModule>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}