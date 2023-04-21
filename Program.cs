using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

namespace dotnet_vite_vuejs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = createWebBuilder(args);
            var app = builder.Build();
            var startup = new Startup(builder, builder.Environment);
            startup.ConfigureServices(builder.Services);
            startup.Configure(app, app.Environment);
            app.Run();
          
        }
        private static WebApplicationBuilder createWebBuilder(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            return builder;
        }
    }
}