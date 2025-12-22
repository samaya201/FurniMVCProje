using FurniMVC201.Context;
using FurniMVC201.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FurniMVC201.Controllers
{
    public class ShopController : Controller
    {
        private AppDbcontext _context;
        public ShopController(AppDbcontext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            ShopViewModel shopViewModel = new ShopViewModel()
            {
                Products = products
            };

            return View(shopViewModel);
        }
    }
}
