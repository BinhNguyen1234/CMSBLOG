using Microsoft.AspNetCore.Mvc;
namespace dotnet_vite_vuejs.Controllers
{
    public class TestController : Controller
    {
        IActionResult Index()
        {
            return Content("test api");
        }
    }
}
