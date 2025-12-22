using Microsoft.EntityFrameworkCore;

namespace FurniMVC201.Context;

public class AppDbcontext:DbContext
{
    public AppDbcontext(DbContextOptions<AppDbcontext> options) : base(options)
    {

    }
    public DbSet<Models.Product> Products { get; set; }
}
