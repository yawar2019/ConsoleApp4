using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ConsoleApp4
{
    public class StartUp
    {

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<CustomizeMiddleWare>();
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app)
        {



            ////app.Map("/test", GetMap);
            //app.MapWhen(context=> { return context.Request.Query.ContainsKey("Nidhi"); },GetMap);

            //app.UseMiddleware<CustomizeMiddleWare>();
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("<html><body>--End of the Story--<br></body></html>");

            //});
            //async void GetMap(IApplicationBuilder app) {

            //    app.Run(async (context) =>
            //    {
            //        await context.Response.WriteAsync("<html><body>Response Hello World 1<br></body></html>");

            //    });

            //}









            //app.Use(async (context, next) =>
            //{

            //    await context.Response.WriteAsync("<html><body>Request Hello World 1<br></body></html>");
            //    next();
            //    await context.Response.WriteAsync("<html><body>Response Hello World 1<br></body></html>");

            //});

            //app.UseStaticFiles();//javascript,css,images

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("<html><body>Request Hello World 2<br></body></html>");
            //    next();
            //    await context.Response.WriteAsync("<html><body>Response Hello World 2<br></body></html>");

            //});
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("<html><body>Request Hello World 3<br></body></html>");

            //});








            //app.Run(MyFirstMiddleware);

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("bye World");
            //});

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                //endpoints.MapControllerRoute(
                //    name: "test",
                //    pattern: "test/time",
                //    defaults: new { controller = "Home", action = "AboutUs" }
                //    );


                //endpoints.MapControllerRoute(
                //    name: "default",
                //    pattern: "{controller=Home}/{action=Index}/{id?}");
            });


            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapDefaultControllerRoute();
            //});
        }

        //public Task MyFirstMiddleware(HttpContext context)
        //{
        //   return context.Response.WriteAsync("Hello World");
        //}

        public async Task MyFirstMiddleware(HttpContext context)
        {
            await context.Response.WriteAsync("Hello World");
        }

    }
}
