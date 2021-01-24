using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Repository_LibrStandart.Interfaces;
using Repository_LibrStandart.Mockups_demo;
using Repository_LibrStandart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace L2_depend_injection
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;        }

        public IConfiguration Configuration { get; }



        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            //++ from errror- employeesController 
            //den skapa new Instanse: som- var m = new MockupEmployeeRepos-->g� to Controller
            // services.AddSingleton();          
            //*laddar 1 g�ng & har samma info oavsett controller view||partial
            //exemple: employees-h�mta 1 g�ng n�r App startar
            /* controller - 33b14ba0-9152-4c4e-9047-e5e352416b99*/
            /* view        -33b14ba0-9152-4c4e-9047-e5e352416b99
             * partialView -33b14ba0-9152-4c4e-9047-e5e352416b99*/

            //kan best�mma funktionailtet h�r:
            services.AddSingleton<IEmployeeRepos, MockupEmployeeRepos>();

            //()n�r anv�nda"IEmployeeRepos"interface->s� ska du anv�nda "MockupEmployeeRepos"funktionalitet
            //n�r du byygt allt DB d� kan du :
            //            services.AddSingleton<IEmployeeRepos, EmployeeRepos>();//error - vi gl�mt att implementera

            services.AddScoped<IEmployeeRepos, MockupEmployeeRepos>();
            //*laddar 1 g�ng for view &samma info ligger i partial /new h�mtning
            /* controller - 3654a0-9152-4c4e-9047-e5e352416b222
             * view        -33b14ba0-9152-4c4e-9047-e5e352416b99
             * partialView -33b14ba0-9152-4c4e-9047-e5e352416b99
             */
            services.AddTransient<IEmployeeRepos, MockupEmployeeRepos>();
            //*laddar om varja g�ng oavsett controller,view,partial
            /* controller - 33b14ba0-9152-4c4e-9047-e5e352416b91
             * view        -33b14ba0-9152-4c4e-9047-e5e352416b96
             * partialView -33b14ba0-9152-4c4e-9047-e5e352416b93
             */

            //-------------------------------
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
            app.UseStaticFiles();//anv�nda fil i C V M

            app.UseRouting();//hoppar mellan sida

            app.UseAuthorization();//just nu anv�nds inte

            app.UseEndpoints(endpoints =>    //vilken controller starta up
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Employees}/{action=Index}/{id?}");
            });
        }
    }
}
