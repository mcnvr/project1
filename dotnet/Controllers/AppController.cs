using Microsoft.AspNetCore.Mvc;

namespace dotnet.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}