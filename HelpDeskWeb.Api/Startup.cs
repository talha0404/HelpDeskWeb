using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelpDeskWeb.Services.Services.CategoryService;
using HelpDeskWeb.Services.Services.FirmService;
using HelpDeskWeb.Services.Services.PriorityService;
using HelpDeskWeb.Services.Services.StatusService;
using HelpDeskWeb.Services.Services.TicketHistoryService;
using HelpDeskWeb.Services.Services.TicketService;
using HelpDeskWeb.Services.Services.TicketTypeService;
using HelpDeskWeb.Services.Services.UsersService;
using HelpDeskWeb.EFCore;
using Microsoft.EntityFrameworkCore;

namespace HelpDeskWeb.Api
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
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "HelpDeskWeb.Api", Version = "v1" });
            });


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

            services.AddDbContext<HelpDeskWebDbContext>(item => item.UseSqlServer(Configuration.GetConnectionString("MyConnection")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "HelpDeskWeb.Api v1"));
            }

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
