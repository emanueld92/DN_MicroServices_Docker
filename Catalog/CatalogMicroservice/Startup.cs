using CatalogMicroservice.AppSerivces;
using CatalogMicroservice.Core.Entity;
using CatalogMicroservice.DataAccess;
using CatalogMicroservice.DataAccess.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogMicroservice
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
            //Database Connection
            string connectionStrig = Configuration.GetConnectionString("Default");
            services.AddDbContext<CatalogMicroserviceContext>(
                options => options.UseMySql(connectionStrig, ServerVersion.AutoDetect(connectionStrig)));


            //Services Transient

          
            services.AddTransient<IProductAppService, ProductAppService>();
            services.AddTransient<IMakeAppService, MakeAppService>();
            services.AddTransient<IRepository<int, Category>, CategoriesRepository>();
            services.AddTransient<IRepository<int, Make>, MakesRepository>();
            services.AddTransient<IRepository<int, Product>, ProductsRepository>();
            services.AddTransient<ICategoryAppService, CategoryAppService>();

            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });
            services.AddControllers().AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CatalogMicroservice", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, CatalogMicroserviceContext db)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CatalogMicroservice v1"));
            }

            db.Database.Migrate();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
