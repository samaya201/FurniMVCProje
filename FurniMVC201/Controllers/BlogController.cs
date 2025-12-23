using FurniMVC201.Context;
using FurniMVC201.Models;
using FurniMVC201.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FurniMVC201.Controllers;

public class BlogController : Controller
{
    private readonly AppDbcontext _context;
    

    public BlogController(AppDbcontext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        var blogs = _context.Blogs
    .Include(b => b.Employee)
    .ToList();
       
        BlogViewModel blogViewModel = new BlogViewModel()
        {
            Blogs = blogs,
            
        };


        return View(blogViewModel);
    }
}
