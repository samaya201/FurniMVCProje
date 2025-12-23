using FurniMVC201.Context;
using FurniMVC201.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FurniMVC201.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbcontext _context;

        public HomeController(AppDbcontext context)
        {
            _context = context
                ;
        }

        public IActionResult Index()
        {
            var comments= _context.Comments
                                   .Include(c => c.Employee)
                                   .ToList();
            CommentViewModel vm = new CommentViewModel
            {
                Comments = comments
            };

            return View(vm);
        }
    }
}
