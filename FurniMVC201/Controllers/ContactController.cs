using Microsoft.AspNetCore.Mvc;

namespace FurniMVC201.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
