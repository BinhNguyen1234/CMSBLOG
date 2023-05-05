using dotnet_vite_vuejs.Model;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
namespace dotnet_vite_vuejs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = createWebBuilder(args);
            var startup = new Startup(builder, builder.Environment);
            startup.ConfigureServices(builder.Services);
            var app = builder.Build();
            startup.Configure(app, app.Environment);
<<<<<<< HEAD
            app.Run();

=======
            app.Run();
          
>>>>>>> becaa1c37634548212367ac51719e62547c5a39f
        }
        private static WebApplicationBuilder createWebBuilder(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            return builder;
        }
    }

}//thấy chưa
// gì v 3 :V
// này app nghich chơi thoi
// vô xem git changes chi :v
// vo coi xoa gi ma no bi loi =))
// không có xóa gì hết :v

// nay lỡ add MVC, controller vô nên mới phát hiện ra lỗi :v
// chứ xóa dòng đó đi app chạy bth\
// -_-