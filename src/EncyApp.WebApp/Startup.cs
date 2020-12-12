/*
    Copyright (c) 2020 dotfelixb
    See License in the project root for license information.
*/

namespace EncyApp.WebApp
{
    using ExtCore.WebApplication.Extensions;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;

    public class Startup
    {
        public Startup(IWebHostEnvironment env, IConfiguration configuration)
        {
            ExtensionPath = env.ContentRootPath + configuration["Extensions:Path"];
        }

        public string ExtensionPath { get; set; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddExtCore(ExtensionPath);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseExtCore();
        }
    }
}