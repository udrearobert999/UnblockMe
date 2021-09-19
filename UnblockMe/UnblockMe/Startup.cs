using AspNetCoreHero.ToastNotification;
using MailKit;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using UnblockMe.Models;
using UnblockMe.Security;
using UnblockMe.Services;

namespace UnblockMe
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
            services.AddDbContext<UnblockMeContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<Users>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<UnblockMeContext>();
            services.AddAuthorization(o =>
            {
                o.AddPolicy("IsNotBanned", policy => policy.Requirements.Add(new IsNotBannedRequirement()));
               
            });
            services.AddTransient<IAuthorizationHandler, IsNotBannedHandler>();
           
            services.AddControllersWithViews(config=>
            {
                //config.Filters.Add(new AuthorizeFilter("IsNotBanned"));
            });
            
            services.AddRazorPages();
            services.Configure<IdentityOptions>(options =>
            {
                
                options.Password.RequireNonAlphanumeric = false;
                options.User.RequireUniqueEmail = true;
            });
           services.AddDbContext<UnblockMeContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddNotyf(config =>
            {
                config.DurationInSeconds = 10;
                config.IsDismissable = true;
                config.Position = NotyfPosition.BottomRight;
            });

            services.AddTransient<ICarsService, CarsService>();
            services.AddTransient<IUserService, UserService>();
            services.AddHttpContextAccessor();
            services.AddTransient<ISMSService, SMSService>();
            services.AddTransient<IEmailService, EmailService>();
            services.AddTransient<IRatingService, RatingService>();
            services.AddTransient<IRoleService, RoleService>();
            services.AddTransient<IMathService, MathService>();
            services.AddTransient<IMapInfoProviderService, MapInfoProviderService>();
            services.AddTransient<IBlockingInfoService, BlockingsInfoService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
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
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
