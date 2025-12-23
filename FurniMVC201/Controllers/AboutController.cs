using FurniMVC201.Context;
using FurniMVC201.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FurniMVC201.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbcontext _context;
        public AboutController(AppDbcontext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var employees = _context.Employees.ToList();
          
            EmployeeViewModel employeeViewModel = new EmployeeViewModel()
            {
                Employees = employees,
                
            };
            return View(employeeViewModel);
        }
    }
}
