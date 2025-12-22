using Microsoft.AspNetCore.Mvc;

namespace FurniMVC201.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
