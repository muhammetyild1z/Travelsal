using BusinessLayer.Abstract;
using BusinessLayer.Concrate;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traversal_holiday.Models;

namespace Traversal_holiday
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
            services.AddSession();
            //Proje seviyesi Authorize
            services.AddMvc(
                config =>
                {
                    var policy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .Build();
                    config.Filters.Add(new AuthorizeFilter(policy));
                });

            services.AddMvc();

           

            //proje finish
          
            //identity
            services.AddDbContext<Context>();
            services.AddIdentity<AppUser, AppRole>(
                opt =>
                {
                    opt.Password.RequireDigit = false;//bir sayý içersin mi
                    opt.Password.RequireLowercase = false;//bir küçük karakter olsun mu
                    opt.Password.RequireNonAlphanumeric = false;//alpha karakter olsun mu
                    opt.Password.RequireUppercase = false;
                    opt.Password.RequiredLength = 1;
                    // opt.SignIn.RequireConfirmedEmail = true;//mail doðrulamasý olsun mu
                }
                
                ).AddEntityFrameworkStores<Context>()
                .AddErrorDescriber<CustomIdentityValidator>().AddEntityFrameworkStores<Context>();
            //

            //ef bagýlmllýðý kaldýrma
            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<ICommentDal, efCommentRepository>();
            services.AddScoped<IDestinationService, DestinationManager>();
            services.AddScoped<IDestinationDal, efDestinationRepository>(); 
            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, efAppUserRepository>();


            services.AddControllersWithViews();

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
            //authorize proje seviyesi
            app.UseAuthentication();
            app.UseRouting();
            app.UseSession();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            //Areas endpoint
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });

        }
    }
}
