using AutoMapper;
using LibModelsContext.DataDB;
using LibModelsContext.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using LibModelsContext.Helpers;
using System.Reflection;
using System.Linq;
using CV_System_API_New.Helpers;

namespace CV_System_API_New
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            // add db context
            services.AddDbContext<CVSystemContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString(ConnectionStringHelper.ExternalStringName)));
            // add identity and storage for identity data
            services.AddIdentity<LoginData, UserRole>().AddEntityFrameworkStores<CVSystemContext>();
            services.AddAutoMapper(ProfilesHelper.Profiles);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
