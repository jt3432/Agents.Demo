using Agents.Demo.Api.Services;
using Agents.Demo.Api.Services.Interfaces;
using Agents.Demo.Data.Repositories;
using Agents.Demo.Data.Repositories.Interfaces;
using AutoMapper;
using Customers.Demo.Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.IO;

namespace Agents.Demo.Api
{
    public class Startup
    {
        readonly string AllowSpecificOrigins = "_allowSpecificOrigins";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Startup));

            services.AddCors(options =>
            {
                options.AddPolicy(name: AllowSpecificOrigins,
                                  builder =>
                                  {
                                      builder.WithOrigins("http://localhost:1337");
                                  });
            });

            services.AddControllers();

            var contentRootPath = Configuration.GetValue<string>(WebHostDefaults.ContentRootKey);
            var jsonDataFilePath = Configuration["JsonDataStorePath"];
            var jsonDataStorePath = Path.Combine(contentRootPath, jsonDataFilePath);

            services.AddTransient<IAgentsRepository>(r => new AgentsJsonRepository(jsonDataStorePath));
            services.AddTransient<IAgentsService, AgentsService>();

            services.AddTransient<ICustomersRepository>(r => new CustomersJsonRepository(jsonDataStorePath));
            services.AddTransient<ICustomersService, CustomersService>();

            services.AddTransient<CustomersService>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Agents Demo API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(AllowSpecificOrigins);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Agents Demo API V1");
                c.RoutePrefix = String.Empty;
            });
        }
    }
}
