using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using SavvyDB.Entities;
using SavvyDB;
using SavvyDB.Models;
using SavvyDB.Mappers;
using SavvyLib;

namespace SavvyAPI
{
    public class Startup
    {
        readonly string AllowSpecificOrigins = "_AllowSpecificOrigins";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options => {
                options.AddPolicy(name: AllowSpecificOrigins,
                    builder => {
                        builder.WithOrigins("*")
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                    });
            });
            services.AddControllers();
            services.AddDbContext<SavvyContext>(options => options.UseNpgsql(Configuration.GetConnectionString("SavvyDB")));

            //Mappers and Repos
            services.AddScoped<IMapper, DBMapper>();
            services.AddScoped<IRepo, SavvyRepo>();

            services.AddScoped<ICartItemMapper, DBMapper>();
            services.AddScoped<ICartItemRepo, SavvyRepo>();

            services.AddScoped<ICartMapper, DBMapper>();
            services.AddScoped<ICartRepo, SavvyRepo>();

            services.AddScoped<ICustomerMapper, DBMapper>();
            services.AddScoped<ICustomerRepo, SavvyRepo>();

            services.AddScoped<IInventoryMapper, DBMapper>();
            services.AddScoped<IInventoryRepo, SavvyRepo>();

            services.AddScoped<ILocationMapper, DBMapper>();
            services.AddScoped<ILocationRepo, SavvyRepo>();

            services.AddScoped<IManagerMapper, DBMapper>();
            services.AddScoped<IManagerRepo, SavvyRepo>();

            services.AddScoped<IOrderItemMapper, DBMapper>();
            services.AddScoped<IOrderItemRepo, SavvyRepo>();

            services.AddScoped<IOrderMapper, DBMapper>();
            services.AddScoped<IOrderRepo, SavvyRepo>();

            services.AddScoped<IProductMapper, DBMapper>();
            services.AddScoped<IProductsRepo, SavvyRepo>();

            //Services
            services.AddScoped<ICartItemTask, CartItemTask>();
            services.AddScoped<IProductTask, ProductTask>();
            services.AddScoped<IInventoryTask, InventoryTask>();
            services.AddScoped<ILocationTask, LocationTask>();
            services.AddScoped<ICustomerTask, CustomerTask>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors(AllowSpecificOrigins);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                    //name: "default",
                    //pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
