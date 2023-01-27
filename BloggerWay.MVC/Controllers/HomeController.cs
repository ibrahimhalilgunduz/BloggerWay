
using Microsoft.AspNetCore.Mvc;

namespace BloggerWay.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
