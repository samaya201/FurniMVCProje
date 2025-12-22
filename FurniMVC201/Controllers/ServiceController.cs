using Microsoft.AspNetCore.Mvc;

namespace FurniMVC201.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
