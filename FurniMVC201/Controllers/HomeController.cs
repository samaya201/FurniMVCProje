using Microsoft.AspNetCore.Mvc;

namespace FurniMVC201.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
