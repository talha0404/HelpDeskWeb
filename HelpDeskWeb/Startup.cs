using HelpDeskWeb.EFCore;
using HelpDeskWeb.Services.Services.CategoryService;
using HelpDeskWeb.Services.Services.FirmService;
using HelpDeskWeb.Services.Services.PriorityService;
using HelpDeskWeb.Services.Services.StatusService;
using HelpDeskWeb.Services.Services.TicketHistoryService;
using HelpDeskWeb.Services.Services.TicketService;
using HelpDeskWeb.Services.Services.TicketTypeService;
using HelpDeskWeb.Services.Services.UsersService;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDeskWeb
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
            services.AddRazorPages();
            services.AddDbContext<HelpDeskWebDbContext>(item => item.UseSqlServer(Configuration.GetConnectionString("MyConnection")));

            #region Dependency Injection
            services.AddTransient<ICategoryServices, CategoryServices>(); 
            services.AddTransient<IFirmServices, FirmServices>(); 
            services.AddTransient<IPriorityServices, PriorityServices>(); 
            services.AddTransient<IStatusServices, StatusServices>(); 
            services.AddTransient<ITicketHistoryServices, TicketHistoryServices>(); 
            services.AddTransient<ITicketServices, TicketServices>(); 
            services.AddTransient<IUsersServices, UsersServices>(); 
            services.AddTransient<ITicketTypeServices, TicketTypeServices>();
            #endregion
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
