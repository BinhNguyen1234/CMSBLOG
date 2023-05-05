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
        private WebApplicationBuilder _builder;
        public Startup(WebApplicationBuilder builder, IWebHostEnvironment env) {
            this._builder = builder;
        }
        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            app.UseRouting();
            app.Map("/api",app => {
              
                app.UseRouting();
                app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapGet("", async context =>
                {
                   await context.Response.WriteAsync("rootAPi");
                });
                endpoints.MapGet("/12", async context =>
                {
                    await context.Response.WriteAsync("12");
                });
            });
            });
            app.Map("",app =>
            {
                StaticFileOptions ClientApp = new StaticFileOptions
                {
                    FileProvider = new PhysicalFileProvider(
                    Path.Combine(
                        this._builder.Environment.ContentRootPath,
                        "ClientApp/dist"
                        )
                    )
                };
                app.UseStaticFiles(ClientApp);
                app.UseSpa(spa =>
                {
                    spa.Options.DefaultPageStaticFileOptions = ClientApp;
                });
            } );
            
            
            
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
        }
    }
}