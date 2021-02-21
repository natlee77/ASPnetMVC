using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RolesAndPolicy.Data;
using RolesAndPolicy.Services.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RolesAndPolicy
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

            //++
            services.AddAutoMapper(typeof(Startup));


            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDatabaseDeveloperPageExceptionFilter();


            //++<appuser> /true-confirmera user 
            //kan inte använda med ROLEs
            //services.AddDefaultIdentity<AppUser>(options => {
            //    options.SignIn.RequireConfirmedAccount = false;
            //    options.Password.RequireDigit = false;
            //    options.Password.RequireNonAlphanumeric = false;               
            //    options.User.RequireUniqueEmail = true;
            //    })
            

            //++ roles
            services.AddIdentity<AppUser, IdentityRole>(options => {
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequireDigit = false;
                options.Password.RequireNonAlphanumeric = false;
                options.User.RequireUniqueEmail = true;
            })

                .AddDefaultUI()              //++
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();   //+++

            services.AddScoped<IUserClaimsPrincipalFactory<AppUser>, AppUserClaims>();//++claims
            services.AddScoped<IIdentityService, IdentityServiceClass>();

            //++vad/vem få göra inne:roles
            services.AddAuthorization(options =>
            {
                options.AddPolicy("StandartAccess", builder => builder.RequireRole("Admin","User"));
                options.AddPolicy("AdminAccess", builder => builder.RequireRole("Admin"));
                options.AddPolicy("TeacherAccess", builder => builder.RequireRole("Manager"));
                options.AddPolicy("StudentAccess", builder => builder.RequireRole("Student"));
                //options.AddPolicy("passwordAdministrator", builder => {
                //    builder.RequireClaim("PasswordAdmin");
                //    builder.RequireRole("admin");
                //    });
            });




            services.AddControllersWithViews();   //-->admincontroller


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
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
                    name: "users",
                    pattern: "admin/users",
                    defaults:new {controller="Users",action="Index"}); 
               

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=home}/{action=index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
