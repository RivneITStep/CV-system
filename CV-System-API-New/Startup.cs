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
using Newtonsoft.Json;
using CV_System_API_New.Controllers.GenericController;

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
            services.AddControllers();
            services.AddControllersWithViews()
                .AddNewtonsoftJson
                (options => options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);
            // add db context
            services.AddDbContext<CVSystemContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString(ConnectionStringHelper.ExternalStringName)));
            // add identity and storage for identity data
            services.AddIdentity<LoginData, UserRole>().AddEntityFrameworkStores<CVSystemContext>();
            services.AddAutoMapper(MapperProfilesHelper.MapperProfiles);
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
            
            app.UseAuthorization();

            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseDefaultFiles();

            app.UseStaticFiles();
        }
    }
}
