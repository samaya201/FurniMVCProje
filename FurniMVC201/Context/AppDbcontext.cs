using FurniMVC201.Models;
using Microsoft.EntityFrameworkCore;

namespace FurniMVC201.Context;

public class AppDbcontext:DbContext
{
    public AppDbcontext(DbContextOptions<AppDbcontext> options) : base(options)
    {

    }
    public DbSet<Product> Products { get; set; }
    public DbSet<Employee> Employees { get; set; }
   public DbSet<Blog> Blogs { get; set; }

    public DbSet<Comment> Comments { get; set; }


}
