using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BT2MWG
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddMvc();
            services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromMinutes(60);
            });
            services.AddMvc(options => options.EnableEndpointRouting = false);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            #region session
            app.UseSession();
            #endregion

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            

            //app.UseRouting();
            //Adding static file middleware
            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                //routes.MapRoute("default", "{controller=home}/{action=index}/{id?}");
                
                routes.MapRoute("Home", "{controller=Home}/{action=Index}");
                routes.MapRoute("Toy", "{controller=ProductCate}/{action=Toy}");
                routes.MapRoute("Admin", "{controller=Admin}/{action=Index}");
                routes.MapRoute("AdminAfterLogin", "{controller=Admin}/{action=Admin}");
                routes.MapRoute("AddNhaCC", "{controller=Admin}/{action=Brand}");
                routes.MapRoute("Default", "{controller=Product}/{action=Index}/do-choi/{id?}");
                //routes.MapRoute("AdminLogin", "{controller=Admin}/{action=Admin}");
                //routes.MapRoute("GetHTML", "{controller=GetHTML}/{action=Index}");
            });
        }
    }
}
