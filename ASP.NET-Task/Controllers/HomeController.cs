using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Task.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
