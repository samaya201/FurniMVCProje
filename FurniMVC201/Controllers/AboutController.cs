using Microsoft.AspNetCore.Mvc;

namespace FurniMVC201.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
