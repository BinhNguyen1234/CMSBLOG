using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using System.IO;

namespace dotnet_vite_vuejs
{
    public class Startup
    {
        public Startup(WebApplicationBuilder builder, IWebHostEnvironment env) { }
        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            app.UseRouting();
            app.UseEndpoints((endpoint) =>
            {
                endpoint.Map("/", async (context) =>
                {
                    await context.Response.WriteAsync("Hello W");
                });
            });
            
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
                    Path.Combine(
                        app.Environment.ContentRootPath, 
                        "ClientApp/dist"
                        )
                    )
                ,RequestPath = ""
            });
        }
        public void ConfigureServices(IServiceCollection services)
        {
           
        }
    }
}
