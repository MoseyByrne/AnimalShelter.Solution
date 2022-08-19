using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;
using System.IO;
using System.Reflection;

namespace AnimalShelter
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
                        services.AddDbContext<AnimalShelterContext>(opt =>
                opt.UseMySql(Configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(Configuration["ConnectionStrings:DefaultConnection"])));

            services.AddControllers();
            // services.AddSwaggerGen(c =>
            // {
            //     c.SwaggerDoc("v1", new OpenApiInfo { Title = "AnimalShelter.Solution", Version = "v1" });
            // });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                // app.UseSwagger();
                // app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "AnimalShelter.Solution v1"));
            }

            // app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                                
            });

            // //Register the Swagger generator, defining 1 or more Swagger documents
            // services.AddSwaggerGen(c =>
            // {
            //     c.SwaggerDoc("v1", new OpenApiInfo
            //     {
            //         Version = "v1",
            //         Title = "AnimalShelter API",
            //         Description = "A simple example ASP.NET Core Web API",
            //         TermsOfService = new Uri("https://example.com/terms"),
            //         Contact = new OpenApiContact
            //         {
            //             Name = "Mo Byrne",
            //             Email = string.Empty,
            //             Url = new Uri("https://github.com/moseybyrne/AnimalShelter.Solution"),
            //         },
            //         License = new OpenApiLicense
            //         {
            //             Name = "Use under LICX",
            //             Url = new Uri("https://example.com/license"),
            //         }
            //     });

            //                //Enable middleware to serve generated Swagger as a Json endpoint
            // app.UseSwagger(c =>
            // {
            //     c.SerializeAsV2 = true;
            // });

            // //Enable middle ware to serve swagger-ui (HTML, JS, CSS, etc.)
            // //specify the Swagger JSON endpoint.
            // app.UseSwaggerUI(c => 
            // {
            //     c.SwaggerEndpoint("/swagger/v1/swagger.json", "My House Plant API V1");
            //     c.RoutePrefix = string.Empty;
            // });

            // });
        }
    }
}
        
    