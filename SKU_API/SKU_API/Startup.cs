using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SKU_API.DataAccess;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace SKU_API
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
            services.AddControllers();
            //var connectionString = Configuration["PostgreSql:ConnectionString"];
            //var dbPassword = Configuration["PostgreSql:DbPassword"];

            //var builder = new NpgsqlConnectionStringBuilder(connectionString)
            //{
            //    Password = dbPassword
            //};

            //services.AddDbContext<SkuDbContext>(options => options.UseNpgsql(builder.ConnectionString));


            //services.AddEntityFrameworkNpgsql()
            //    .AddDbContext<SkuDbContext>(opt => 
            //                    opt.UseNpgsql(Configuration.GetConnectionString("MyWebApiConection")));

            services.AddDbContext<SkuDbContext>(cfg =>
            {
                cfg.UseNpgsql(Configuration.GetConnectionString("MyWebApiConection"));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
